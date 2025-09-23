using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ClaudeBridge.Knowledge
{
    /// <summary>
    /// Intelligent documentation retriever for SE commands
    /// Provides semantic search, fuzzy matching, and context-aware command lookups
    /// </summary>
    public class DocumentationRetriever
    {
        private readonly DocumentationCache _cache;
        private readonly List<SECommand> _allCommands;
        private readonly Dictionary<string, List<SECommand>> _categoryIndex;
        private readonly Dictionary<string, List<SECommand>> _verbIndex;
        private readonly Dictionary<string, List<SECommand>> _triggerIndex;
        
        /// <summary>
        /// Initialize retriever with knowledge base and caching
        /// </summary>
        /// <param name="commands">All loaded SE commands</param>
        /// <param name="cache">Documentation cache for performance</param>
        public DocumentationRetriever(List<SECommand> commands, DocumentationCache cache = null)
        {
            _allCommands = commands ?? throw new ArgumentNullException(nameof(commands));
            _cache = cache ?? new DocumentationCache();
            
            // Build indexes for fast lookups
            _categoryIndex = BuildCategoryIndex();
            _verbIndex = BuildVerbIndex();
            _triggerIndex = BuildTriggerIndex();
            
            // Populate cache with all commands
            PopulateCache();
            
            Console.WriteLine($"🔍 Documentation retriever initialized with {_allCommands.Count} commands");
        }
        
        /// <summary>
        /// Find commands matching natural language input with relevance scoring
        /// </summary>
        /// <param name="userInput">Natural language input from user</param>
        /// <param name="maxResults">Maximum number of results to return</param>
        /// <returns>Ranked search results</returns>
        public List<CommandSearchResult> FindCommands(string userInput, int maxResults = 10)
        {
            if (string.IsNullOrWhiteSpace(userInput))
                return new List<CommandSearchResult>();
            
            // DISABLED: Search result caching to prevent repeated wrong answers
            // Check cache first
            // var cachedResults = _cache.GetSearchResults(userInput);
            // if (cachedResults != null)
            // {
            //     return cachedResults.Take(maxResults).ToList();
            // }
            
            var results = new List<CommandSearchResult>();
            var inputLower = userInput.ToLower().Trim();
            var inputWords = ExtractKeywords(inputLower);
            
            foreach (var command in _allCommands)
            {
                // DEBUGGING: Skip commands with empty/null titles
                if (string.IsNullOrEmpty(command.Title))
                {
                    Console.WriteLine($"⚠️  Skipping command with empty title: ID={command.Id}");
                    continue;
                }
                
                var score = CalculateRelevanceScore(command, inputLower, inputWords);
                
                // MINIMAL DEBUG: Only show successful reactor matches
                if (inputLower.Contains("reactor") && score.Score > 50)
                {
                    // Only show in verbose mode to reduce output pollution
                    if (System.Diagnostics.Debugger.IsAttached)
                    {
                        Console.WriteLine($"   🔍 Found reactor command: {command.Title} (score: {score.Score:F1})");
                    }
                }
                
                if (score.Score > 0)
                {
                    results.Add(new CommandSearchResult
                    {
                        Command = command,
                        RelevanceScore = score.Score,
                        MatchReason = score.Reason,
                        MatchedTriggers = score.MatchedTriggers
                    });
                }
            }
            
            // Sort by relevance score descending
            results = results.OrderByDescending(r => r.RelevanceScore).Take(maxResults).ToList();
            
            // DISABLED: Result caching to prevent repeated wrong answers
            // Cache results
            // _cache.CacheSearchResults(userInput, results);
            
            return results;
        }
        
        /// <summary>
        /// Get commands by specific category
        /// </summary>
        /// <param name="category">Category name</param>
        /// <returns>Commands in the category</returns>
        public List<SECommand> GetCommandsByCategory(string category)
        {
            if (string.IsNullOrWhiteSpace(category))
                return new List<SECommand>();
            
            // Check cache first
            var cachedCommands = _cache.GetCommandsByCategory(category);
            if (cachedCommands != null)
                return cachedCommands;
            
            // Lookup in index
            if (_categoryIndex.TryGetValue(category.ToLower(), out var commands))
            {
                _cache.CacheCommandsByCategory(category, commands);
                return commands;
            }
            
            return new List<SECommand>();
        }
        
        /// <summary>
        /// Get command by exact ID
        /// </summary>
        /// <param name="commandId">Command ID</param>
        /// <returns>Command if found</returns>
        public SECommand GetCommandById(string commandId)
        {
            if (string.IsNullOrWhiteSpace(commandId))
                return null;
            
            // Check cache first
            var cachedCommand = _cache.GetCommand(commandId);
            if (cachedCommand != null)
                return cachedCommand;
            
            // Search in all commands
            var command = _allCommands.FirstOrDefault(c => 
                c.Id.Equals(commandId, StringComparison.OrdinalIgnoreCase));
            
            if (command != null)
            {
                _cache.CacheCommand(command);
            }
            
            return command;
        }
        
        /// <summary>
        /// Find commands most similar to a specific SE implementation pattern
        /// </summary>
        /// <param name="commandId">Reference command ID (like "battery_mode_recharge")</param>
        /// <returns>Related commands</returns>
        public List<SECommand> GetRelatedCommands(string commandId, int maxResults = 5)
        {
            var baseCommand = GetCommandById(commandId);
            if (baseCommand == null)
                return new List<SECommand>();
            
            var related = new List<(SECommand command, double similarity)>();
            
            foreach (var command in _allCommands)
            {
                if (command.Id == commandId) continue;
                
                var similarity = CalculateSimilarity(baseCommand, command);
                if (similarity > 0.3) // Threshold for relatedness
                {
                    related.Add((command, similarity));
                }
            }
            
            return related
                .OrderByDescending(x => x.similarity)
                .Take(maxResults)
                .Select(x => x.command)
                .ToList();
        }
        
        /// <summary>
        /// Get commands suitable for current ship configuration context
        /// Based on known working Step 9 commands: batteries, reactors, lights, oxygen
        /// </summary>
        /// <param name="availableBlocks">List of available block types on ship</param>
        /// <returns>Applicable commands</returns>
        public List<SECommand> GetApplicableCommands(List<string> availableBlocks = null)
        {
            // Default to known working block types from Step 9 testing
            var blockTypes = availableBlocks ?? new List<string> 
            { 
                "Battery", "Reactor", "InteriorLight", "OxygenGenerator", 
                "TimerBlock", "Assembler", "AirVent" 
            };
            
            var applicable = new List<SECommand>();
            
            foreach (var command in _allCommands)
            {
                if (command.Targets?.AllowedTypes != null)
                {
                    // Check if command can work with available blocks
                    var hasCompatibleBlocks = command.Targets.AllowedTypes
                        .Any(allowedType => blockTypes.Any(available => 
                            available.Contains(allowedType, StringComparison.OrdinalIgnoreCase) ||
                            allowedType.Contains(available, StringComparison.OrdinalIgnoreCase)
                        ));
                    
                    if (hasCompatibleBlocks)
                    {
                        applicable.Add(command);
                    }
                }
            }
            
            return applicable.OrderBy(c => c.Category).ThenBy(c => c.Title).ToList();
        }
        
        /// <summary>
        /// Get formatted command documentation for Claude context
        /// </summary>
        /// <param name="command">Command to format</param>
        /// <returns>Formatted documentation string</returns>
        public string FormatCommandDocumentation(SECommand command)
        {
            if (command == null) return "";
            
            var doc = $"Command: {command.Title} ({command.Id})\n";
            doc += $"Category: {command.Category}\n";
            
            if (command.NaturalLanguageTriggers?.Any() == true)
            {
                doc += $"Triggers: {string.Join(", ", command.NaturalLanguageTriggers.Take(3))}\n";
            }
            
            if (command.Targets?.AllowedTypes?.Any() == true)
            {
                doc += $"Block Types: {string.Join(", ", command.Targets.AllowedTypes)}\n";
            }
            
            if (command.Effects?.Any() == true)
            {
                doc += $"Effects: {string.Join("; ", command.Effects.Take(2))}\n";
            }
            
            if (command.SafetyClass != null)
            {
                doc += $"Safety: {command.SafetyClass}\n";
            }
            
            return doc;
        }
        
        /// <summary>
        /// Calculate relevance score for a command against user input
        /// </summary>
        private (double Score, string Reason, List<string> MatchedTriggers) CalculateRelevanceScore(
            SECommand command, string inputLower, List<string> inputWords)
        {
            double score = 0;
            var reasons = new List<string>();
            var matchedTriggers = new List<string>();
            
            // 1. Exact trigger match (highest priority)
            if (command.NaturalLanguageTriggers != null)
            {
                foreach (var trigger in command.NaturalLanguageTriggers)
                {
                    var triggerLower = trigger.ToLower();
                    if (inputLower.Contains(triggerLower))
                    {
                        score += 100;
                        reasons.Add($"trigger_match:{trigger}");
                        matchedTriggers.Add(trigger);
                    }
                    else if (triggerLower.Contains(inputLower))
                    {
                        score += 80;
                        reasons.Add($"partial_trigger:{trigger}");
                        matchedTriggers.Add(trigger);
                    }
                }
            }
            
            // 2. Title match
            if (command.Title != null)
            {
                var titleWords = ExtractKeywords(command.Title.ToLower());
                var commonWords = inputWords.Intersect(titleWords).Count();
                if (commonWords > 0)
                {
                    score += commonWords * 20;
                    reasons.Add($"title_match:{commonWords}");
                }
            }
            
            // 3. Synonym match
            if (command.Synonyms != null)
            {
                foreach (var synonym in command.Synonyms)
                {
                    if (inputLower.Contains(synonym.ToLower()))
                    {
                        score += 60;
                        reasons.Add($"synonym_match:{synonym}");
                    }
                }
            }
            
            // 4. Category match (BOOSTED for exact matches)
            if (command.Category != null && inputWords.Contains(command.Category.ToLower()))
            {
                score += 50; // Increased from 30
                reasons.Add("category_match");
            }
            
            // 4b. SPECIAL: Power management category boost for power queries
            if (command.Category == "power_management" && 
                (inputWords.Contains("reactor") || inputWords.Contains("battery") || inputWords.Contains("power")))
            {
                score += 150; // Major boost for power-related queries
                reasons.Add("power_category_boost");
            }
            
            // 5. Tag match
            if (command.Tags != null)
            {
                var tagMatches = command.Tags.Count(tag => inputWords.Contains(tag.ToLower()));
                if (tagMatches > 0)
                {
                    score += tagMatches * 15;
                    reasons.Add($"tag_match:{tagMatches}");
                }
            }
            
            // 6. Verb match
            if (command.Verb != null && inputWords.Contains(command.Verb.ToLower()))
            {
                score += 40;
                reasons.Add("verb_match");
            }
            
            // 7. SPECIAL: Block type priority for specific queries
            if (command.Targets?.AllowedTypes != null)
            {
                foreach (var blockType in command.Targets.AllowedTypes)
                {
                    var blockTypeLower = blockType.ToLower();
                    
                    // Reactor-specific boost
                    if (inputWords.Contains("reactor") && blockTypeLower.Contains("reactor"))
                    {
                        score += 200; // Major reactor command boost
                        reasons.Add($"reactor_block_match:{blockType}");
                    }
                    
                    // Battery-specific boost  
                    if (inputWords.Contains("battery") && blockTypeLower.Contains("battery"))
                    {
                        score += 200; // Major battery command boost
                        reasons.Add($"battery_block_match:{blockType}");
                    }
                }
            }
            
            return (score, string.Join("|", reasons), matchedTriggers);
        }
        
        /// <summary>
        /// Calculate similarity between two commands
        /// </summary>
        private double CalculateSimilarity(SECommand command1, SECommand command2)
        {
            double similarity = 0;
            
            // Category similarity
            if (command1.Category == command2.Category)
                similarity += 0.4;
            
            // Target type similarity
            if (command1.Targets?.AllowedTypes != null && command2.Targets?.AllowedTypes != null)
            {
                var commonTypes = command1.Targets.AllowedTypes.Intersect(command2.Targets.AllowedTypes).Count();
                var totalTypes = command1.Targets.AllowedTypes.Union(command2.Targets.AllowedTypes).Count();
                if (totalTypes > 0)
                    similarity += 0.3 * (double)commonTypes / totalTypes;
            }
            
            // Tag similarity
            if (command1.Tags != null && command2.Tags != null)
            {
                var commonTags = command1.Tags.Intersect(command2.Tags).Count();
                var totalTags = command1.Tags.Union(command2.Tags).Count();
                if (totalTags > 0)
                    similarity += 0.3 * (double)commonTags / totalTags;
            }
            
            return similarity;
        }
        
        /// <summary>
        /// Extract keywords from text for matching
        /// </summary>
        private List<string> ExtractKeywords(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return new List<string>();
            
            // Remove common words and split on non-letter characters
            var stopWords = new HashSet<string> 
            { 
                "the", "a", "an", "and", "or", "but", "in", "on", "at", "to", "for", 
                "of", "with", "by", "is", "are", "was", "were", "be", "been", "have", "has" 
            };
            
            var words = Regex.Split(text.ToLower(), @"[^\w]+")
                .Where(w => w.Length > 1 && !stopWords.Contains(w))
                .ToList();
            
            return words;
        }
        
        /// <summary>
        /// Build category index for fast category lookups
        /// </summary>
        private Dictionary<string, List<SECommand>> BuildCategoryIndex()
        {
            return _allCommands
                .GroupBy(c => c.Category?.ToLower() ?? "unknown")
                .ToDictionary(g => g.Key, g => g.ToList());
        }
        
        /// <summary>
        /// Build verb index for fast verb-based lookups
        /// </summary>
        private Dictionary<string, List<SECommand>> BuildVerbIndex()
        {
            return _allCommands
                .Where(c => !string.IsNullOrEmpty(c.Verb))
                .GroupBy(c => c.Verb.ToLower())
                .ToDictionary(g => g.Key, g => g.ToList());
        }
        
        /// <summary>
        /// Build trigger index for fast natural language matching
        /// </summary>
        private Dictionary<string, List<SECommand>> BuildTriggerIndex()
        {
            var triggerIndex = new Dictionary<string, List<SECommand>>();
            
            foreach (var command in _allCommands)
            {
                if (command.NaturalLanguageTriggers != null)
                {
                    foreach (var trigger in command.NaturalLanguageTriggers)
                    {
                        var key = trigger.ToLower();
                        if (!triggerIndex.ContainsKey(key))
                            triggerIndex[key] = new List<SECommand>();
                        
                        triggerIndex[key].Add(command);
                    }
                }
            }
            
            return triggerIndex;
        }
        
        /// <summary>
        /// Populate cache with all commands for initial performance
        /// </summary>
        private void PopulateCache()
        {
            foreach (var command in _allCommands)
            {
                _cache.CacheCommand(command);
            }
            
            // Cache categories
            foreach (var category in _categoryIndex)
            {
                _cache.CacheCommandsByCategory(category.Key, category.Value);
            }
        }
        
        /// <summary>
        /// Get cache performance statistics
        /// </summary>
        public CacheStatistics GetCacheStatistics()
        {
            return _cache.GetCacheStatistics();
        }
    }
}
