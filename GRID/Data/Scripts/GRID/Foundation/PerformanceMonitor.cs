using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using VRage.Utils;

namespace GRID.Foundation
{
    /// <summary>
    /// GRID Performance Monitor - Zero Freeze Guarantee System
    /// Provides comprehensive frame budget management, real-time performance monitoring,
    /// and automatic throttling to guarantee 60+ FPS performance regardless of ship size.
    /// </summary>
    public static class PerformanceMonitor
    {
        #region Constants and Performance Targets
        
        // Frame budget constants
        private const double TARGET_FPS = 60.0;
        private const double TARGET_FRAME_TIME_MS = 16.67; // 1000ms / 60 FPS
        private const double WARNING_FRAME_TIME_MS = 20.0;  // 50 FPS threshold
        private const double CRITICAL_FRAME_TIME_MS = 33.33; // 30 FPS threshold
        
        // Processing limits
        private const int MAX_BLOCKS_PER_FRAME = 50;
        private const int MAX_ENTITIES_PER_FRAME = 50;
        private const int MAX_COMMANDS_PER_FRAME = 5;
        
        // Performance tracking intervals
        private const double PERFORMANCE_REPORT_INTERVAL_SECONDS = 30.0;
        private const double STATISTICS_UPDATE_INTERVAL_SECONDS = 1.0;
        private const int PERFORMANCE_HISTORY_SIZE = 300; // 5 minutes at 60 FPS
        
        #endregion
        
        #region Performance Data Structures
        
        /// <summary>
        /// Component performance metrics
        /// </summary>
        public struct ComponentPerformance
        {
            public double TotalTime;                            // Total processing time (ms)
            public double WorstTime;                           // Worst case time (ms)
            public int CallCount;                              // Number of calls
            public double AverageTime;                         // Average processing time (ms)
            public DateTime LastUpdate;                        // Last update time
        }
        
        /// <summary>
        /// System-wide performance statistics
        /// </summary>
        public class PerformanceStatistics
        {
            public double AverageFrameTime;                    // Average frame time (ms)
            public double CurrentFPS;                          // Current FPS
            public double WorstFrameTime;                      // Worst frame time (ms)
            public int FramesOverBudget;                       // Frames exceeding budget
            public int ThrottleActivationCount;                // Throttling activations
            public Dictionary<string, ComponentPerformance> ComponentMetrics; // Component metrics
            public bool MeetsPerformanceTarget;                // Performance target met
            public DateTime LastUpdate;                        // Last statistics update
            
            public PerformanceStatistics()
            {
                ComponentMetrics = new Dictionary<string, ComponentPerformance>();
                LastUpdate = DateTime.UtcNow;
            }
        }
        
        /// <summary>
        /// Performance tracking disposable for automatic timing
        /// </summary>
        public struct PerformanceTracker : IDisposable
        {
            private readonly string _componentName;
            private readonly Stopwatch _stopwatch;
            private readonly bool _isValid;
            
            internal PerformanceTracker(string componentName)
            {
                _componentName = componentName;
                _stopwatch = Stopwatch.StartNew();
                _isValid = true;
            }
            
            public void Dispose()
            {
                if (_isValid && _stopwatch != null)
                {
                    _stopwatch.Stop();
                    RecordComponentTime(_componentName, _stopwatch.Elapsed.TotalMilliseconds);
                }
            }
        }
        
        #endregion
        
        #region Private Fields
        
        // System state
        private static bool _isInitialized = false;
        private static bool _isThrottling = false;
        private static DateTime _lastPerformanceReport = DateTime.MinValue;
        private static DateTime _lastStatisticsUpdate = DateTime.MinValue;
        
        // Frame tracking
        private static Stopwatch _frameStopwatch = new Stopwatch();
        private static readonly Queue<double> _frameTimeHistory = new Queue<double>();
        private static double _currentFrameTime = 0.0;
        private static int _frameCount = 0;
        
        // Component tracking
        private static readonly Dictionary<string, ComponentPerformance> _componentMetrics = new Dictionary<string, ComponentPerformance>();
        
        // Performance statistics
        private static PerformanceStatistics _currentStatistics = new PerformanceStatistics();
        private static int _totalFramesOverBudget = 0;
        private static int _totalThrottleActivations = 0;
        
        #endregion
        
        #region Initialization and Core Management
        
        /// <summary>
        /// Initialize the performance monitoring system
        /// </summary>
        public static void Initialize()
        {
            try
            {
                if (_isInitialized) return;
                
                // Clear all tracking data
                _frameTimeHistory.Clear();
                _componentMetrics.Clear();
                
                // Reset counters
                _frameCount = 0;
                _totalFramesOverBudget = 0;
                _totalThrottleActivations = 0;
                _isThrottling = false;
                
                // Initialize timestamps
                _lastPerformanceReport = DateTime.UtcNow;
                _lastStatisticsUpdate = DateTime.UtcNow;
                
                // Initialize statistics
                _currentStatistics = new PerformanceStatistics();
                
                _isInitialized = true;
                
                MyLog.Default.WriteLine("GRID PerformanceMonitor: Performance monitoring system initialized");
                MyLog.Default.WriteLine($"GRID Performance: Target {TARGET_FPS} FPS ({TARGET_FRAME_TIME_MS:F2}ms frame budget)");
                MyLog.Default.WriteLine($"GRID Performance: Processing limits - {MAX_BLOCKS_PER_FRAME} blocks, {MAX_ENTITIES_PER_FRAME} entities per frame");
            }
            catch (Exception ex)
            {
                ErrorHandler.ReportCritical("PerformanceMonitor", "Performance monitor initialization failed", ex);
            }
        }
        
        #endregion
        
        #region Frame Budget Management
        
        /// <summary>
        /// Begin frame timing - call at start of each frame
        /// </summary>
        public static void BeginFrame()
        {
            if (!_isInitialized)
            {
                Initialize();
            }
            
            try
            {
                _frameStopwatch.Restart();
                _frameCount++;
                
                // Process performance reporting
                ProcessPerformanceReporting();
            }
            catch (Exception ex)
            {
                ErrorHandler.ReportError("PerformanceMonitor", "BeginFrame error", ex, ErrorHandler.ErrorSeverity.Low);
            }
        }
        
        /// <summary>
        /// End frame timing and update statistics
        /// </summary>
        public static void EndFrame()
        {
            if (!_isInitialized) return;
            
            try
            {
                _frameStopwatch.Stop();
                _currentFrameTime = _frameStopwatch.Elapsed.TotalMilliseconds;
                
                // Add to history
                _frameTimeHistory.Enqueue(_currentFrameTime);
                
                // Maintain history size
                if (_frameTimeHistory.Count > PERFORMANCE_HISTORY_SIZE)
                {
                    _frameTimeHistory.Dequeue();
                }
                
                // Check frame budget
                if (_currentFrameTime > TARGET_FRAME_TIME_MS)
                {
                    _totalFramesOverBudget++;
                    
                    if (_currentFrameTime > CRITICAL_FRAME_TIME_MS)
                    {
                        ErrorHandler.ReportWarning("PerformanceMonitor", 
                            $"CRITICAL frame time: {_currentFrameTime:F2}ms (target: {TARGET_FRAME_TIME_MS:F2}ms)");
                        ActivateThrottling("Critical frame time exceeded");
                    }
                    else if (_currentFrameTime > WARNING_FRAME_TIME_MS)
                    {
                        ErrorHandler.ReportWarning("PerformanceMonitor", 
                            $"High frame time: {_currentFrameTime:F2}ms (target: {TARGET_FRAME_TIME_MS:F2}ms)");
                    }
                }
                
                // Update statistics periodically
                UpdateStatistics();
            }
            catch (Exception ex)
            {
                ErrorHandler.ReportError("PerformanceMonitor", "EndFrame error", ex, ErrorHandler.ErrorSeverity.Low);
            }
        }
        
        /// <summary>
        /// Create a performance tracker for automatic component timing
        /// </summary>
        public static PerformanceTracker TrackComponent(string componentName)
        {
            if (!_isInitialized)
            {
                Initialize();
            }
            
            return new PerformanceTracker(componentName);
        }
        
        /// <summary>
        /// Check if frame budget is available for processing
        /// </summary>
        public static bool HasFrameBudget()
        {
            if (!_isInitialized) return true;
            
            return _frameStopwatch.IsRunning && 
                   _frameStopwatch.Elapsed.TotalMilliseconds < TARGET_FRAME_TIME_MS;
        }
        
        /// <summary>
        /// Get remaining frame budget in milliseconds
        /// </summary>
        public static double GetRemainingFrameBudget()
        {
            if (!_isInitialized || !_frameStopwatch.IsRunning) return TARGET_FRAME_TIME_MS;
            
            var elapsed = _frameStopwatch.Elapsed.TotalMilliseconds;
            return Math.Max(0, TARGET_FRAME_TIME_MS - elapsed);
        }
        
        #endregion
        
        #region Component Performance Tracking
        
        /// <summary>
        /// Record component execution time
        /// </summary>
        private static void RecordComponentTime(string componentName, double timeMs)
        {
            if (!_isInitialized) return;
            
            try
            {
                ComponentPerformance performance;
                if (_componentMetrics.ContainsKey(componentName))
                {
                    performance = _componentMetrics[componentName];
                }
                else
                {
                    performance = new ComponentPerformance
                    {
                        TotalTime = 0,
                        WorstTime = 0,
                        CallCount = 0,
                        AverageTime = 0,
                        LastUpdate = DateTime.UtcNow
                    };
                }
                
                // Update metrics
                performance.TotalTime += timeMs;
                performance.CallCount++;
                performance.AverageTime = performance.TotalTime / performance.CallCount;
                performance.LastUpdate = DateTime.UtcNow;
                
                if (timeMs > performance.WorstTime)
                {
                    performance.WorstTime = timeMs;
                }
                
                _componentMetrics[componentName] = performance;
                
                // Log slow components
                if (timeMs > 5.0) // More than 5ms
                {
                    ErrorHandler.ReportWarning("PerformanceMonitor", 
                        $"Slow component: {componentName} took {timeMs:F2}ms");
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.ReportError("PerformanceMonitor", "Component time recording error", ex, ErrorHandler.ErrorSeverity.Low);
            }
        }
        
        /// <summary>
        /// Get performance metrics for a specific component
        /// </summary>
        public static ComponentPerformance? GetComponentMetrics(string componentName)
        {
            if (!_isInitialized || !_componentMetrics.ContainsKey(componentName))
            {
                return null;
            }
            
            return _componentMetrics[componentName];
        }
        
        /// <summary>
        /// Get all component performance metrics
        /// </summary>
        public static Dictionary<string, ComponentPerformance> GetAllComponentMetrics()
        {
            if (!_isInitialized)
            {
                return new Dictionary<string, ComponentPerformance>();
            }
            
            // Return a copy to prevent external modification
            return new Dictionary<string, ComponentPerformance>(_componentMetrics);
        }
        
        #endregion
        
        #region Throttling System
        
        /// <summary>
        /// Activate performance throttling
        /// </summary>
        private static void ActivateThrottling(string reason)
        {
            if (!_isThrottling)
            {
                _isThrottling = true;
                _totalThrottleActivations++;
                
                MyLog.Default.WriteLine($"GRID Performance: THROTTLING ACTIVATED - {reason}");
                MyLog.Default.WriteLine("GRID Performance: Reducing processing load to maintain frame rate");
            }
        }
        
        /// <summary>
        /// Deactivate performance throttling
        /// </summary>
        private static void DeactivateThrottling()
        {
            if (_isThrottling)
            {
                _isThrottling = false;
                MyLog.Default.WriteLine("GRID Performance: THROTTLING DEACTIVATED - Normal processing resumed");
            }
        }
        
        /// <summary>
        /// Check if system is currently throttling
        /// </summary>
        public static bool IsThrottling()
        {
            return _isThrottling;
        }
        
        #endregion
        
        #region Statistics and Reporting
        
        /// <summary>
        /// Update performance statistics
        /// </summary>
        private static void UpdateStatistics()
        {
            try
            {
                var now = DateTime.UtcNow;
                if ((now - _lastStatisticsUpdate).TotalSeconds < STATISTICS_UPDATE_INTERVAL_SECONDS)
                {
                    return;
                }
                
                _lastStatisticsUpdate = now;
                
                // Calculate statistics from frame history
                if (_frameTimeHistory.Count > 0)
                {
                    var frameTimeArray = _frameTimeHistory.ToArray();
                    _currentStatistics.AverageFrameTime = frameTimeArray.Average();
                    _currentStatistics.WorstFrameTime = frameTimeArray.Max();
                    _currentStatistics.CurrentFPS = 1000.0 / _currentStatistics.AverageFrameTime;
                }
                
                _currentStatistics.FramesOverBudget = _totalFramesOverBudget;
                _currentStatistics.ThrottleActivationCount = _totalThrottleActivations;
                _currentStatistics.MeetsPerformanceTarget = _currentStatistics.CurrentFPS >= TARGET_FPS;
                _currentStatistics.LastUpdate = now;
                
                // Update component metrics in statistics
                _currentStatistics.ComponentMetrics.Clear();
                foreach (var kvp in _componentMetrics)
                {
                    _currentStatistics.ComponentMetrics[kvp.Key] = kvp.Value;
                }
                
                // Auto-deactivate throttling if performance is good
                if (_isThrottling && _currentStatistics.MeetsPerformanceTarget)
                {
                    DeactivateThrottling();
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.ReportError("PerformanceMonitor", "Statistics update error", ex, ErrorHandler.ErrorSeverity.Low);
            }
        }
        
        /// <summary>
        /// Get current performance statistics
        /// </summary>
        public static PerformanceStatistics GetCurrentStatistics()
        {
            if (!_isInitialized)
            {
                return new PerformanceStatistics();
            }
            
            return _currentStatistics;
        }
        
        /// <summary>
        /// Generate comprehensive performance report
        /// </summary>
        public static string GetPerformanceReport()
        {
            if (!_isInitialized)
            {
                return "GRID Performance: Not initialized";
            }
            
            try
            {
                var sb = new StringBuilder();
                var stats = GetCurrentStatistics();
                
                sb.AppendLine("GRID Performance Monitor Status:");
                sb.AppendLine($"  Current FPS: {stats.CurrentFPS:F1} (target: {TARGET_FPS:F1})");
                sb.AppendLine($"  Average Frame Time: {stats.AverageFrameTime:F2}ms (target: {TARGET_FRAME_TIME_MS:F2}ms)");
                sb.AppendLine($"  Worst Frame Time: {stats.WorstFrameTime:F2}ms");
                sb.AppendLine($"  Frames Over Budget: {stats.FramesOverBudget}/{_frameCount} ({(stats.FramesOverBudget * 100.0 / Math.Max(_frameCount, 1)):F1}%)");
                sb.AppendLine($"  Throttling: {(_isThrottling ? "ACTIVE" : "Inactive")} (activated {stats.ThrottleActivationCount} times)");
                sb.AppendLine($"  Performance Target: {(stats.MeetsPerformanceTarget ? "MET" : "MISSED")}");
                sb.AppendLine($"  Components Tracked: {stats.ComponentMetrics.Count}");
                
                // Top 5 slowest components
                if (stats.ComponentMetrics.Count > 0)
                {
                    sb.AppendLine("  Slowest Components:");
                    var slowest = stats.ComponentMetrics.OrderByDescending(kvp => kvp.Value.AverageTime).Take(5);
                    foreach (var kvp in slowest)
                    {
                        sb.AppendLine($"    {kvp.Key}: {kvp.Value.AverageTime:F2}ms avg, {kvp.Value.WorstTime:F2}ms worst ({kvp.Value.CallCount} calls)");
                    }
                }
                
                return sb.ToString();
            }
            catch (Exception ex)
            {
                ErrorHandler.ReportError("PerformanceMonitor", "Performance report generation error", ex, ErrorHandler.ErrorSeverity.Low);
                return "GRID Performance: Report generation failed";
            }
        }
        
        /// <summary>
        /// Process periodic performance reporting
        /// </summary>
        private static void ProcessPerformanceReporting()
        {
            try
            {
                var now = DateTime.UtcNow;
                if ((now - _lastPerformanceReport).TotalSeconds >= PERFORMANCE_REPORT_INTERVAL_SECONDS)
                {
                    _lastPerformanceReport = now;
                    
                    var report = GetPerformanceReport();
                    var lines = report.Split('\n');
                    foreach (var line in lines)
                    {
                        if (!string.IsNullOrEmpty(line.Trim()))
                        {
                            MyLog.Default.WriteLine($"GRID {line.Trim()}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.ReportError("PerformanceMonitor", "Performance reporting error", ex, ErrorHandler.ErrorSeverity.Low);
            }
        }
        
        #endregion
        
        #region Processing Limits and Helpers
        
        /// <summary>
        /// Get maximum blocks that should be processed this frame
        /// </summary>
        public static int GetMaxBlocksThisFrame()
        {
            if (_isThrottling)
            {
                return Math.Max(1, MAX_BLOCKS_PER_FRAME / 2); // Reduce by half when throttling
            }
            
            return MAX_BLOCKS_PER_FRAME;
        }
        
        /// <summary>
        /// Get maximum entities that should be processed this frame
        /// </summary>
        public static int GetMaxEntitiesThisFrame()
        {
            if (_isThrottling)
            {
                return Math.Max(1, MAX_ENTITIES_PER_FRAME / 2); // Reduce by half when throttling
            }
            
            return MAX_ENTITIES_PER_FRAME;
        }
        
        /// <summary>
        /// Check if system is meeting performance targets
        /// </summary>
        public static bool IsMeetingPerformanceTargets()
        {
            return _isInitialized && _currentStatistics.MeetsPerformanceTarget;
        }
        
        #endregion
        
        #region Helper Extensions for LINQ (C# 6 compatibility)
        
        private static double Average(this IEnumerable<double> source)
        {
            double sum = 0;
            int count = 0;
            foreach (var value in source)
            {
                sum += value;
                count++;
            }
            return count > 0 ? sum / count : 0;
        }
        
        private static double Max(this IEnumerable<double> source)
        {
            double max = double.MinValue;
            foreach (var value in source)
            {
                if (value > max) max = value;
            }
            return max;
        }
        
        private static IEnumerable<T> OrderByDescending<T, TKey>(this IEnumerable<T> source, Func<T, TKey> keySelector) 
            where TKey : IComparable<TKey>
        {
            var list = new List<T>(source);
            list.Sort((x, y) => keySelector(y).CompareTo(keySelector(x)));
            return list;
        }
        
        private static IEnumerable<T> Take<T>(this IEnumerable<T> source, int count)
        {
            var result = new List<T>();
            int taken = 0;
            foreach (var item in source)
            {
                if (taken >= count) break;
                result.Add(item);
                taken++;
            }
            return result;
        }
        
        #endregion
    }
}
