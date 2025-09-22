using System;
using System.Collections.Generic;

namespace GRID.CommandProcessing
{
    /// <summary>
    /// GRID Command Data Structures - Basic Foundation for Step 6
    /// Minimal command processing data structures for "turn on/off" recognition
    /// following C# 6.0 patterns and SE ModAPI constraints.
    /// </summary>
    
    /// <summary>
    /// Structured command from ClaudeBridge
    /// </summary>
    public struct StructuredCommand
    {
        public string CommandId;            // Command ID from SE knowledge system
        public string Target;               // Target specification ("all_reactors", "hangar_lights")
        public string Category;             // SE system category ("power", "lighting")
        public Dictionary<string, object> Parameters; // Command parameters
        public string SpatialContext;       // Spatial targeting context
        public string Source;               // Command source ("ClaudeBridge")
        public DateTime Timestamp;          // Command timestamp
    }
    
    /// <summary>
    /// Basic command specification
    /// </summary>
    public struct BasicCommandSpec
    {
        public string Id;                   // Command identifier
        public string Trigger;              // Trigger pattern ("turn on", "turn off")
        public string Category;             // Basic category ("power", "lighting")
        public string TargetType;           // SE block type target
        public string SeProperty;           // SE ModAPI property name
        public bool PropertyValue;          // Property value to set (for on/off)
        public string Description;          // Human-readable description
    }
    
    /// <summary>
    /// Command processing result
    /// </summary>
    public struct CommandProcessingResult
    {
        public bool Success;                // Processing success status
        public string Message;              // Result message
        public string CommandId;            // Processed command ID
        public string Target;               // Resolved target
        public DateTime ProcessingTime;     // Processing timestamp
        public double ProcessingDurationMs; // Processing duration
        public int AffectedBlocks;          // Number of blocks affected
        public string ErrorDetails;         // Error details if failed
    }
    
    /// <summary>
    /// Basic execution context
    /// </summary>
    public struct BasicExecutionContext
    {
        public long GridId;                 // Target grid ID
        public string UserSource;           // Command source
        public DateTime RequestTime;        // Request timestamp
        public BasicCommandSpec Command;    // Command to execute
        public StructuredCommand StructuredCommand; // Structured command from ClaudeBridge
    }
}
