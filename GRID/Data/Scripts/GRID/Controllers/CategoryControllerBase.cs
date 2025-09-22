using Sandbox.ModAPI;
using System;
using System.Collections.Generic;
using VRage.Game.ModAPI;
using VRage.Utils;
using GRID.Foundation;
using GRID.SpatialIntelligence;

namespace GRID.Controllers
{
    /// <summary>
    /// Base interface for all GRID components
    /// </summary>
    public interface IGridComponent
    {
        bool Initialize();
        void Update();
        void Shutdown();
    }
    
    /// <summary>
    /// GRID Category Controller Base - Foundation for All Controllers
    /// Provides shared functionality, block resolution, authority validation,
    /// and performance tracking for all specialized controllers.
    /// </summary>
    public abstract class CategoryControllerBase : IGridComponent
    {
        #region Constants and Performance Limits
        
        protected const int MAX_BULK_OPERATIONS_PER_FRAME = 50;
        protected const double SAFETY_MARGIN_SECONDS = 1.0;
        protected const int MAX_BLOCK_SEARCH_PER_FRAME = 100;
        
        #endregion
        
        #region Protected Properties
        
        protected GRID.SpatialIntelligence.BasicSpatialCoordinator SpatialCoordinator { get; private set; }
        protected bool IsInitialized { get; private set; } = false;
        protected bool IsEnabled { get; private set; } = true;
        
        #endregion
        
        #region Abstract Properties
        
        public abstract string ComponentName { get; }
        
        #endregion
        
        #region IGridComponent Implementation
        
        /// <summary>
        /// Initialize base controller functionality
        /// </summary>
        public virtual bool Initialize()
        {
            try
            {
                if (IsInitialized) return true;
                
                MyLog.Default.WriteLine($"GRID {ComponentName}: Initializing controller...");
                
                IsInitialized = true;
                IsEnabled = true;
                
                MyLog.Default.WriteLine($"GRID {ComponentName}: Controller initialized successfully");
                return true;
            }
            catch (Exception ex)
            {
                ErrorHandler.ReportError(ComponentName, "Controller initialization failed", ex, ErrorHandler.ErrorSeverity.Critical);
                return false;
            }
        }
        
        /// <summary>
        /// Update controller (called every frame)
        /// </summary>
        public virtual void Update()
        {
            if (!IsInitialized || !IsEnabled) return;
            
            try
            {
                using (PerformanceMonitor.TrackComponent($"{ComponentName}.Update"))
                {
                    // Base update functionality
                    // Specialized controllers override this for specific update logic
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.ReportError(ComponentName, "Controller update error", ex, ErrorHandler.ErrorSeverity.Medium);
            }
        }
        
        /// <summary>
        /// Shutdown controller
        /// </summary>
        public virtual void Shutdown()
        {
            try
            {
                IsEnabled = false;
                IsInitialized = false;
                
                MyLog.Default.WriteLine($"GRID {ComponentName}: Controller shutdown complete");
            }
            catch (Exception ex)
            {
                ErrorHandler.ReportError(ComponentName, "Controller shutdown error", ex, ErrorHandler.ErrorSeverity.Low);
            }
        }
        
        #endregion
        
        #region Dependency Injection
        
        /// <summary>
        /// Set spatial intelligence dependency
        /// </summary>
        public virtual void SetSpatialCoordinator(GRID.SpatialIntelligence.BasicSpatialCoordinator spatialCoordinator)
        {
            try
            {
                if (spatialCoordinator == null)
                {
                    throw new ArgumentNullException("spatialCoordinator");
                }
                
                SpatialCoordinator = spatialCoordinator;
                MyLog.Default.WriteLine($"GRID {ComponentName}: Spatial coordinator dependency set");
            }
            catch (Exception ex)
            {
                ErrorHandler.ReportError(ComponentName, "Spatial coordinator dependency error", ex, ErrorHandler.ErrorSeverity.High);
            }
        }
        
        #endregion
        
        #region Block Resolution and Validation
        
        /// <summary>
        /// Resolve target blocks using SE ModAPI
        /// </summary>
        protected List<IMyTerminalBlock> ResolveTargetBlocks(string target, Type interfaceType)
        {
            var blocks = new List<IMyTerminalBlock>();
            
            try
            {
                using (PerformanceMonitor.TrackComponent($"{ComponentName}.ResolveTargetBlocks"))
                {
                    // Get all entities
                    var entities = new HashSet<IMyEntity>();
                    MyAPIGateway.Entities.GetEntities(entities);
                    
                    var blocksFound = 0;
                    var targetLower = target.ToLower();
                    
                    foreach (var entity in entities)
                    {
                        var grid = entity as IMyCubeGrid;
                        if (grid == null) continue;
                        
                        var gridBlocks = new List<IMySlimBlock>();
                        grid.GetBlocks(gridBlocks);
                        
                        foreach (var slimBlock in gridBlocks)
                        {
                            // Skip non-functional blocks for performance
                            if (slimBlock == null || slimBlock.FatBlock == null) continue;
                            
                            var terminalBlock = slimBlock.FatBlock as IMyTerminalBlock;
                            if (terminalBlock == null) continue;
                            
                            // Simple type checking without reflection (SE ModAPI safe)
                            if (!IsCompatibleBlockType(terminalBlock, interfaceType)) continue;
                            
                            // Check target matching
                            if (MatchesTarget(terminalBlock, targetLower))
                            {
                                blocks.Add(terminalBlock);
                                blocksFound++;
                                
                                // Limit blocks per frame for performance
                                if (blocksFound >= MAX_BLOCK_SEARCH_PER_FRAME) break;
                            }
                        }
                        
                        if (blocksFound >= MAX_BLOCK_SEARCH_PER_FRAME) break;
                    }
                    
                    MyLog.Default.WriteLine($"GRID {ComponentName}: Found {blocks.Count} blocks matching '{target}'");
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.ReportError(ComponentName, "Block resolution error", ex, ErrorHandler.ErrorSeverity.Medium);
            }
            
            return blocks;
        }
        
        /// <summary>
        /// Check if block matches target specification
        /// </summary>
        protected bool MatchesTarget(IMyTerminalBlock block, string targetLower)
        {
            try
            {
                // Match by name
                var blockName = block.CustomName != null ? block.CustomName.ToLower() : "";
                if (blockName.Contains(targetLower)) return true;
                
                // Match by type (SerializableDefinitionId is struct, always valid)
                var blockType = block.BlockDefinition.ToString().ToLower();
                
                // Universal target patterns
                if (targetLower == "all" || targetLower == "reactor" && blockType.Contains("reactor"))
                    return true;
                if (targetLower == "lights" && blockType.Contains("light"))
                    return true;
                if (targetLower == "assembler" && blockType.Contains("assembler"))
                    return true;
                if (targetLower == "refinery" && blockType.Contains("refinery"))
                    return true;
                if (targetLower == "battery" && blockType.Contains("battery"))
                    return true;
                
                return false;
            }
            catch (Exception ex)
            {
                ErrorHandler.ReportError(ComponentName, "Target matching error", ex, ErrorHandler.ErrorSeverity.Low);
                return false;
            }
        }
        
        /// <summary>
        /// Validate user authority for block operation
        /// </summary>
        protected bool ValidateUserAuthority(IMyTerminalBlock block)
        {
            try
            {
                // Basic authority validation - can be enhanced for multiplayer
                if (block == null) return false;
                
                // Check if block is accessible
                if (!block.IsWorking && !block.IsFunctional) return false;
                
                // For now, allow all operations (multiplayer authority checking can be added later)
                return true;
            }
            catch (Exception ex)
            {
                ErrorHandler.ReportError(ComponentName, "Authority validation error", ex, ErrorHandler.ErrorSeverity.Medium);
                return false;
            }
        }
        
        /// <summary>
        /// Check if block is compatible with interface type (SE ModAPI safe)
        /// </summary>
        protected bool IsCompatibleBlockType(IMyTerminalBlock block, Type interfaceType)
        {
            try
            {
                // SE ModAPI safe type checking without reflection
                if (interfaceType == typeof(IMyFunctionalBlock))
                {
                    return block is IMyFunctionalBlock;
                }
                else if (interfaceType == typeof(IMyTerminalBlock))
                {
                    return true; // All terminal blocks are compatible
                }
                else
                {
                    // For specific types, use direct casting
                    var blockTypeName = block.GetType().Name;
                    var interfaceTypeName = interfaceType.Name;
                    
                    // Basic compatibility check
                    return blockTypeName.Contains(interfaceTypeName.Replace("IMy", "")) ||
                           blockTypeName.Contains(interfaceTypeName.Replace("I", ""));
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.ReportError(ComponentName, "Block type compatibility check error", ex, ErrorHandler.ErrorSeverity.Low);
                return false;
            }
        }
        
        #endregion
        
        #region Bulk Operations
        
        /// <summary>
        /// Execute bulk operation on blocks with performance monitoring
        /// </summary>
        protected bool ExecuteBulkOperation<T>(List<T> items, Func<T, bool> operation, string operationName, out string result) where T : IMyTerminalBlock
        {
            result = "";
            var successCount = 0;
            var totalCount = items.Count;
            
            try
            {
                using (PerformanceMonitor.TrackComponent($"{ComponentName}.{operationName}"))
                {
                    var processedThisFrame = 0;
                    
                    foreach (var item in items)
                    {
                        try
                        {
                            if (ValidateUserAuthority(item) && operation(item))
                            {
                                successCount++;
                            }
                            
                            processedThisFrame++;
                            
                            // Respect frame budget
                            if (processedThisFrame >= MAX_BULK_OPERATIONS_PER_FRAME)
                            {
                                break;
                            }
                        }
                        catch (Exception itemEx)
                        {
                            ErrorHandler.ReportError(ComponentName, $"Operation failed on block {item.CustomName}", itemEx, ErrorHandler.ErrorSeverity.Low);
                        }
                    }
                    
                    result = $"{operationName} completed: {successCount}/{totalCount} blocks affected";
                    
                    MyLog.Default.WriteLine($"GRID {ComponentName}: {result}");
                    return successCount > 0;
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.ReportError(ComponentName, $"Bulk operation {operationName} failed", ex, ErrorHandler.ErrorSeverity.Medium);
                result = $"{operationName} failed: {ex.Message}";
                return false;
            }
        }
        
        #endregion
        
        #region Protected Utilities
        
        /// <summary>
        /// Get controller status for debugging
        /// </summary>
        protected string GetControllerStatus()
        {
            return $"{ComponentName}: Initialized={IsInitialized}, Enabled={IsEnabled}, SpatialCoordinator={SpatialCoordinator != null}";
        }
        
        #endregion
    }
}
