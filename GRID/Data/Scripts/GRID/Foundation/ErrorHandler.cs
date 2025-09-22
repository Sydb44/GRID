using System;
using System.Collections.Generic;
using VRage.Utils;

namespace GRID.Foundation
{
    /// <summary>
    /// GRID Error Handler - Component Isolation and Recovery System
    /// Provides comprehensive error management, component isolation, and graceful degradation
    /// for the GRID AI Companion System with zero tolerance for system crashes.
    /// </summary>
    public static class ErrorHandler
    {
        #region Constants and Fields
        
        private const int MAX_ERRORS_PER_SECOND = 5;
        private const int COMPONENT_ISOLATION_THRESHOLD = 10;
        private const double ERROR_RATE_WINDOW_SECONDS = 60.0;
        
        // Component error tracking
        private static readonly Dictionary<string, int> _componentErrorCounts = new Dictionary<string, int>();
        private static readonly Dictionary<string, DateTime> _lastErrorTime = new Dictionary<string, DateTime>();
        private static readonly Dictionary<string, List<DateTime>> _errorHistory = new Dictionary<string, List<DateTime>>();
        private static readonly Dictionary<string, ComponentState> _componentStates = new Dictionary<string, ComponentState>();
        
        // System state tracking
        private static bool _isInitialized = false;
        private static int _totalErrorCount = 0;
        private static DateTime _systemStartTime;
        
        #endregion
        
        #region Data Structures
        
        /// <summary>
        /// Comprehensive error information structure
        /// </summary>
        public struct ErrorInfo
        {
            public string Component;                           // Component name
            public string Message;                             // Error message
            public Exception Exception;                        // Exception details
            public ErrorSeverity Severity;                     // Error severity
            public DateTime Timestamp;                         // Error timestamp
            public string RecoveryGuidance;                    // Recovery guidance
        }
        
        /// <summary>
        /// Error severity classification system
        /// </summary>
        public enum ErrorSeverity
        {
            Low,        // Non-critical, system continues normally
            Medium,     // Reduced functionality, user should be aware
            High,       // Significant impact, immediate attention needed
            Critical    // System integrity at risk, emergency measures
        }
        
        /// <summary>
        /// Component operational state tracking
        /// </summary>
        public enum ComponentState
        {
            Normal,         // Operating normally
            Degraded,       // Reduced functionality due to errors
            Isolated,       // Component isolated due to excessive errors
            Recovery        // Attempting recovery
        }
        
        #endregion
        
        #region Initialization and Core Management
        
        /// <summary>
        /// Initialize the error handling system
        /// </summary>
        public static void Initialize()
        {
            try
            {
                if (_isInitialized) return;
                
                _systemStartTime = DateTime.UtcNow;
                _totalErrorCount = 0;
                
                // Clear all tracking dictionaries
                _componentErrorCounts.Clear();
                _lastErrorTime.Clear();
                _errorHistory.Clear();
                _componentStates.Clear();
                
                _isInitialized = true;
                
                MyLog.Default.WriteLine("GRID ErrorHandler: Error handling system initialized");
            }
            catch (Exception ex)
            {
                // Fallback error handling for the error handler itself
                MyLog.Default.WriteLine($"GRID ErrorHandler CRITICAL INITIALIZATION FAILURE: {ex}");
            }
        }
        
        #endregion
        
        #region Primary Error Reporting Interface
        
        /// <summary>
        /// Primary error reporting method with component isolation and recovery guidance
        /// </summary>
        public static void ReportError(string component, string message, Exception exception = null, ErrorSeverity severity = ErrorSeverity.Medium)
        {
            try
            {
                if (!_isInitialized)
                {
                    Initialize();
                }
                
                var errorInfo = new ErrorInfo
                {
                    Component = component ?? "Unknown",
                    Message = message ?? "No message",
                    Exception = exception,
                    Severity = severity,
                    Timestamp = DateTime.UtcNow,
                    RecoveryGuidance = GenerateRecoveryGuidance(component, severity, exception)
                };
                
                ProcessError(errorInfo);
            }
            catch (Exception ex)
            {
                // Ultimate fallback - direct to SE log without any processing
                MyLog.Default.WriteLine($"GRID ErrorHandler Critical Failure: {ex}");
            }
        }
        
        /// <summary>
        /// Convenience methods for different severity levels
        /// </summary>
        public static void ReportCritical(string component, string message, Exception exception = null)
        {
            ReportError(component, message, exception, ErrorSeverity.Critical);
        }
        
        public static void ReportWarning(string component, string message, string recoveryGuidance = null)
        {
            ReportError(component, message, null, ErrorSeverity.Low);
        }
        
        #endregion
        
        #region Error Processing and Component Management
        
        /// <summary>
        /// Process error information and implement component isolation if necessary
        /// </summary>
        private static void ProcessError(ErrorInfo errorInfo)
        {
            try
            {
                _totalErrorCount++;
                
                // Update component error tracking
                UpdateComponentErrorTracking(errorInfo.Component);
                
                // Check for rate limiting
                if (ShouldRateLimit(errorInfo.Component))
                {
                    // Rate limit exceeded - isolate component
                    IsolateComponent(errorInfo.Component, "Error rate limit exceeded");
                }
                
                // Log the error with appropriate details
                LogError(errorInfo);
                
                // Update component state based on error patterns
                UpdateComponentState(errorInfo.Component, errorInfo.Severity);
                
                // Implement recovery actions for critical errors
                if (errorInfo.Severity == ErrorSeverity.Critical)
                {
                    HandleCriticalError(errorInfo);
                }
            }
            catch (Exception ex)
            {
                MyLog.Default.WriteLine($"GRID ErrorHandler ProcessError Failed: {ex}");
            }
        }
        
        /// <summary>
        /// Update error tracking for a component
        /// </summary>
        private static void UpdateComponentErrorTracking(string component)
        {
            // Update error count
            if (_componentErrorCounts.ContainsKey(component))
            {
                _componentErrorCounts[component]++;
            }
            else
            {
                _componentErrorCounts[component] = 1;
            }
            
            // Update last error time
            _lastErrorTime[component] = DateTime.UtcNow;
            
            // Update error history for rate limiting
            if (!_errorHistory.ContainsKey(component))
            {
                _errorHistory[component] = new List<DateTime>();
            }
            
            _errorHistory[component].Add(DateTime.UtcNow);
            
            // Clean old entries (keep only last 60 seconds)
            CleanErrorHistory(component);
        }
        
        /// <summary>
        /// Check if component should be rate limited
        /// </summary>
        private static bool ShouldRateLimit(string component)
        {
            if (!_errorHistory.ContainsKey(component))
            {
                return false;
            }
            
            var recentErrors = _errorHistory[component];
            var cutoffTime = DateTime.UtcNow.AddSeconds(-1.0); // Last 1 second
            
            var errorsInLastSecond = 0;
            for (int i = recentErrors.Count - 1; i >= 0; i--)
            {
                if (recentErrors[i] >= cutoffTime)
                {
                    errorsInLastSecond++;
                }
                else
                {
                    break; // Older entries, stop counting
                }
            }
            
            return errorsInLastSecond >= MAX_ERRORS_PER_SECOND;
        }
        
        /// <summary>
        /// Clean old error history entries to prevent memory growth
        /// </summary>
        private static void CleanErrorHistory(string component)
        {
            if (!_errorHistory.ContainsKey(component)) return;
            
            var cutoffTime = DateTime.UtcNow.AddSeconds(-ERROR_RATE_WINDOW_SECONDS);
            var history = _errorHistory[component];
            
            // Remove entries older than the window
            for (int i = history.Count - 1; i >= 0; i--)
            {
                if (history[i] < cutoffTime)
                {
                    history.RemoveAt(i);
                }
            }
        }
        
        #endregion
        
        #region Component State Management
        
        /// <summary>
        /// Update component operational state based on error patterns
        /// </summary>
        private static void UpdateComponentState(string component, ErrorSeverity severity)
        {
            if (!_componentStates.ContainsKey(component))
            {
                _componentStates[component] = ComponentState.Normal;
            }
            
            var errorCount = _componentErrorCounts.ContainsKey(component) ? _componentErrorCounts[component] : 0;
            
            // Determine new state based on error count and severity
            if (errorCount >= COMPONENT_ISOLATION_THRESHOLD)
            {
                _componentStates[component] = ComponentState.Isolated;
            }
            else if (severity == ErrorSeverity.Critical || errorCount >= 5)
            {
                _componentStates[component] = ComponentState.Degraded;
            }
            else if (errorCount >= 3)
            {
                _componentStates[component] = ComponentState.Recovery;
            }
        }
        
        /// <summary>
        /// Isolate component due to excessive errors
        /// </summary>
        private static void IsolateComponent(string component, string reason)
        {
            _componentStates[component] = ComponentState.Isolated;
            MyLog.Default.WriteLine($"GRID ErrorHandler: Component '{component}' ISOLATED - {reason}");
            MyLog.Default.WriteLine($"GRID ErrorHandler: System continues with reduced functionality");
        }
        
        /// <summary>
        /// Check if component is currently isolated
        /// </summary>
        public static bool IsComponentIsolated(string component)
        {
            return _componentStates.ContainsKey(component) && 
                   _componentStates[component] == ComponentState.Isolated;
        }
        
        /// <summary>
        /// Get component operational state
        /// </summary>
        public static ComponentState GetComponentState(string component)
        {
            return _componentStates.ContainsKey(component) ? 
                   _componentStates[component] : ComponentState.Normal;
        }
        
        #endregion
        
        #region Error Logging and Recovery
        
        /// <summary>
        /// Log error with appropriate detail level based on severity
        /// </summary>
        private static void LogError(ErrorInfo errorInfo)
        {
            var componentState = GetComponentState(errorInfo.Component);
            var errorCount = _componentErrorCounts.ContainsKey(errorInfo.Component) ? 
                           _componentErrorCounts[errorInfo.Component] : 0;
            
            var logPrefix = $"GRID {errorInfo.Severity.ToString().ToUpper()}";
            var componentInfo = $"[{errorInfo.Component}#{errorCount}:{componentState}]";
            
            switch (errorInfo.Severity)
            {
                case ErrorSeverity.Critical:
                    MyLog.Default.WriteLine($"{logPrefix} {componentInfo}: {errorInfo.Message}");
                    if (errorInfo.Exception != null)
                    {
                        MyLog.Default.WriteLine($"GRID EXCEPTION: {errorInfo.Exception}");
                    }
                    MyLog.Default.WriteLine($"GRID RECOVERY: {errorInfo.RecoveryGuidance}");
                    break;
                    
                case ErrorSeverity.High:
                    MyLog.Default.WriteLine($"{logPrefix} {componentInfo}: {errorInfo.Message}");
                    if (errorInfo.Exception != null)
                    {
                        MyLog.Default.WriteLine($"GRID EXCEPTION: {errorInfo.Exception.Message}");
                    }
                    break;
                    
                case ErrorSeverity.Medium:
                    MyLog.Default.WriteLine($"{logPrefix} {componentInfo}: {errorInfo.Message}");
                    break;
                    
                case ErrorSeverity.Low:
                    // Low severity errors logged with minimal detail
                    MyLog.Default.WriteLine($"{logPrefix} {componentInfo}: {errorInfo.Message}");
                    break;
            }
        }
        
        /// <summary>
        /// Generate recovery guidance based on error context
        /// </summary>
        private static string GenerateRecoveryGuidance(string component, ErrorSeverity severity, Exception exception)
        {
            if (severity == ErrorSeverity.Critical)
            {
                return "Critical error detected. Component isolated. System continues with reduced functionality.";
            }
            else if (severity == ErrorSeverity.High)
            {
                return "High severity error. Monitor system performance. Consider manual intervention.";
            }
            else if (exception != null && exception is NullReferenceException)
            {
                return "Null reference detected. Check component initialization and data validation.";
            }
            else
            {
                return "Monitor component performance. Error should resolve automatically.";
            }
        }
        
        /// <summary>
        /// Handle critical errors with emergency protocols
        /// </summary>
        private static void HandleCriticalError(ErrorInfo errorInfo)
        {
            // For critical errors, immediately isolate the component
            IsolateComponent(errorInfo.Component, $"Critical error: {errorInfo.Message}");
            
            // Log emergency information
            MyLog.Default.WriteLine("GRID EMERGENCY: Critical error detected - activating emergency protocols");
            MyLog.Default.WriteLine($"GRID EMERGENCY: Component '{errorInfo.Component}' isolated for system protection");
            MyLog.Default.WriteLine("GRID EMERGENCY: AI Companion System continues with available components");
        }
        
        #endregion
        
        #region System Status and Diagnostics
        
        /// <summary>
        /// Get system error statistics for diagnostics
        /// </summary>
        public static string GetSystemErrorStatus()
        {
            try
            {
                var uptime = DateTime.UtcNow - _systemStartTime;
                var activeComponents = _componentStates.Count;
                var isolatedComponents = 0;
                var degradedComponents = 0;
                
                foreach (var state in _componentStates.Values)
                {
                    if (state == ComponentState.Isolated) isolatedComponents++;
                    else if (state == ComponentState.Degraded) degradedComponents++;
                }
                
                return $"GRID ErrorHandler Status: {_totalErrorCount} total errors, " +
                       $"{activeComponents} components tracked, {isolatedComponents} isolated, " +
                       $"{degradedComponents} degraded, uptime: {uptime.TotalMinutes:F1}min";
            }
            catch (Exception ex)
            {
                return $"Error status unavailable: {ex.Message}";
            }
        }
        
        /// <summary>
        /// Reset component state (for recovery attempts)
        /// </summary>
        public static void ResetComponentState(string component)
        {
            try
            {
                if (_componentStates.ContainsKey(component))
                {
                    _componentStates[component] = ComponentState.Recovery;
                    MyLog.Default.WriteLine($"GRID ErrorHandler: Component '{component}' state reset to Recovery");
                }
            }
            catch (Exception ex)
            {
                MyLog.Default.WriteLine($"GRID ErrorHandler: Failed to reset component state: {ex.Message}");
            }
        }
        
        #endregion
    }
}
