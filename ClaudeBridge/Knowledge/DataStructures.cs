using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ClaudeBridge.Knowledge
{
    /// <summary>
    /// Complete Space Engineers command definition loaded from se_knowledge
    /// </summary>
    public class SECommand
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        
        [JsonProperty("title")]
        public string Title { get; set; }
        
        [JsonProperty("category")]
        public string Category { get; set; }
        
        [JsonProperty("verb")]
        public string Verb { get; set; }
        
        [JsonProperty("natural_language_triggers")]
        public List<string> NaturalLanguageTriggers { get; set; } = new List<string>();
        
        [JsonProperty("targets")]
        public CommandTargets Targets { get; set; }
        
        [JsonProperty("parameters")]
        public List<CommandParameter> Parameters { get; set; } = new List<CommandParameter>();
        
        [JsonProperty("se_implementation")]
        public SEImplementation Implementation { get; set; }
        
        [JsonProperty("preconditions")]
        public List<string> Preconditions { get; set; } = new List<string>();
        
        [JsonProperty("effects")]
        public List<string> Effects { get; set; } = new List<string>();
        
        [JsonProperty("constraints")]
        public CommandConstraints Constraints { get; set; }
        
        [JsonProperty("validation_hooks")]
        public List<string> ValidationHooks { get; set; } = new List<string>();
        
        [JsonProperty("error_cases")]
        public List<ErrorCase> ErrorCases { get; set; } = new List<ErrorCase>();
        
        [JsonProperty("safety_class")]
        public string SafetyClass { get; set; }
        
        [JsonProperty("idempotent")]
        public bool Idempotent { get; set; }
        
        [JsonProperty("reversible")]
        public bool Reversible { get; set; }
        
        [JsonProperty("examples")]
        public List<CommandExample> Examples { get; set; } = new List<CommandExample>();
        
        [JsonProperty("synonyms")]
        public List<string> Synonyms { get; set; } = new List<string>();
        
        [JsonProperty("tags")]
        public List<string> Tags { get; set; } = new List<string>();
        
        [JsonProperty("sources")]
        public List<CommandSource> Sources { get; set; } = new List<CommandSource>();
        
        [JsonProperty("version")]
        public CommandVersion Version { get; set; }
    }
    
    /// <summary>
    /// Target specifications for a command
    /// </summary>
    public class CommandTargets
    {
        [JsonProperty("allowed_types")]
        public List<string> AllowedTypes { get; set; } = new List<string>();
        
        [JsonProperty("allowed_selectors")]
        public List<string> AllowedSelectors { get; set; } = new List<string>();
        
        [JsonProperty("grid_scope")]
        public List<string> GridScope { get; set; } = new List<string>();
        
        [JsonProperty("multi_target")]
        public bool MultiTarget { get; set; }
        
        [JsonProperty("target_validation")]
        public string TargetValidation { get; set; }
    }
    
    /// <summary>
    /// Command parameter definition
    /// </summary>
    public class CommandParameter
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("type")]
        public string Type { get; set; }
        
        [JsonProperty("required")]
        public bool Required { get; set; }
        
        [JsonProperty("default")]
        public object Default { get; set; }
        
        [JsonProperty("min")]
        public object Min { get; set; }
        
        [JsonProperty("max")]
        public object Max { get; set; }
        
        [JsonProperty("description")]
        public string Description { get; set; }
        
        [JsonProperty("validation")]
        public string Validation { get; set; }
    }
    
    /// <summary>
    /// Space Engineers implementation details
    /// </summary>
    public class SEImplementation
    {
        [JsonProperty("toolbar_actions")]
        public List<string> ToolbarActions { get; set; } = new List<string>();
        
        [JsonProperty("terminal_path")]
        public List<string> TerminalPath { get; set; } = new List<string>();
        
        [JsonProperty("modapi_calls")]
        public List<ModAPICall> ModAPICalls { get; set; } = new List<ModAPICall>();
        
        [JsonProperty("group_compatible")]
        public bool GroupCompatible { get; set; }
        
        [JsonProperty("timer_compatible")]
        public bool TimerCompatible { get; set; }
        
        [JsonProperty("event_controller_compatible")]
        public bool EventControllerCompatible { get; set; }
    }
    
    /// <summary>
    /// ModAPI call specification
    /// </summary>
    public class ModAPICall
    {
        [JsonProperty("interface")]
        public string Interface { get; set; }
        
        [JsonProperty("property")]
        public string Property { get; set; }
        
        [JsonProperty("method")]
        public string Method { get; set; }
    }
    
    /// <summary>
    /// Command execution constraints
    /// </summary>
    public class CommandConstraints
    {
        [JsonProperty("power_required_mw")]
        public double PowerRequiredMW { get; set; }
        
        [JsonProperty("network_sync")]
        public bool NetworkSync { get; set; }
        
        [JsonProperty("multiplayer_authority")]
        public string MultiplayerAuthority { get; set; }
        
        [JsonProperty("execution_time_ms")]
        public int ExecutionTimeMs { get; set; }
        
        [JsonProperty("instruction_cost")]
        public int InstructionCost { get; set; }
    }
    
    /// <summary>
    /// Error case definition
    /// </summary>
    public class ErrorCase
    {
        [JsonProperty("condition")]
        public string Condition { get; set; }
        
        [JsonProperty("message")]
        public string Message { get; set; }
        
        [JsonProperty("recovery")]
        public string Recovery { get; set; }
    }
    
    /// <summary>
    /// Command usage example
    /// </summary>
    public class CommandExample
    {
        [JsonProperty("input")]
        public string Input { get; set; }
        
        [JsonProperty("parsed")]
        public object Parsed { get; set; }
    }
    
    /// <summary>
    /// Command documentation source
    /// </summary>
    public class CommandSource
    {
        [JsonProperty("type")]
        public string Type { get; set; }
        
        [JsonProperty("path")]
        public string Path { get; set; }
        
        [JsonProperty("sections")]
        public List<string> Sections { get; set; } = new List<string>();
    }
    
    /// <summary>
    /// Command version information
    /// </summary>
    public class CommandVersion
    {
        [JsonProperty("schema")]
        public string Schema { get; set; }
        
        [JsonProperty("command_version")]
        public string CommandVersionNumber { get; set; }
        
        [JsonProperty("last_validated")]
        public string LastValidated { get; set; }
    }
    
    /// <summary>
    /// Command library index information
    /// </summary>
    public class CommandLibraryInfo
    {
        [JsonProperty("version")]
        public string Version { get; set; }
        
        [JsonProperty("total_commands")]
        public int TotalCommands { get; set; }
        
        [JsonProperty("target_achieved")]
        public bool TargetAchieved { get; set; }
        
        [JsonProperty("target_exceeded_by")]
        public int TargetExceededBy { get; set; }
        
        [JsonProperty("completion_date")]
        public string CompletionDate { get; set; }
        
        [JsonProperty("validation_status")]
        public string ValidationStatus { get; set; }
        
        [JsonProperty("ready_for_grid_deployment")]
        public bool ReadyForGridDeployment { get; set; }
    }
    
    /// <summary>
    /// System category information
    /// </summary>
    public class SystemCategory
    {
        [JsonProperty("commands")]
        public int Commands { get; set; }
        
        [JsonProperty("files")]
        public List<string> Files { get; set; } = new List<string>();
        
        [JsonProperty("capabilities")]
        public List<string> Capabilities { get; set; } = new List<string>();
        
        [JsonProperty("status")]
        public string Status { get; set; }
    }
    
    /// <summary>
    /// Complete se_knowledge index structure
    /// </summary>
    public class SEKnowledgeIndex
    {
        [JsonProperty("command_library_info")]
        public CommandLibraryInfo CommandLibraryInfo { get; set; }
        
        [JsonProperty("system_categories")]
        public Dictionary<string, SystemCategory> SystemCategories { get; set; } = new Dictionary<string, SystemCategory>();
        
        [JsonProperty("command_distributions")]
        public Dictionary<string, object> CommandDistributions { get; set; } = new Dictionary<string, object>();
    }
    
    /// <summary>
    /// Command search result with relevance scoring
    /// </summary>
    public class CommandSearchResult
    {
        public SECommand Command { get; set; }
        public double RelevanceScore { get; set; }
        public string MatchReason { get; set; }
        public List<string> MatchedTriggers { get; set; } = new List<string>();
    }
    
    /// <summary>
    /// Knowledge loading statistics
    /// </summary>
    public class KnowledgeLoadingStats
    {
        public int TotalFilesProcessed { get; set; }
        public int CommandsLoaded { get; set; }
        public int LoadingErrors { get; set; }
        public TimeSpan LoadingTime { get; set; }
        public Dictionary<string, int> CategoryCounts { get; set; } = new Dictionary<string, int>();
    }
}
