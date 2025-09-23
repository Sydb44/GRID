using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ClaudeBridge.Knowledge
{
    /// <summary>
    /// Builds comprehensive searchable indexes for SE command documentation
    /// Enables fast full-text search, faceted search, and intelligent recommendations
    /// </summary>
    public class DocumentationIndex
    {
        private readonly List<SECommand> _allCommands;
        
        // Core indexes
        private readonly Dictionary<string, HashSet<string>> _wordToCommandIds = new Dictionary<string, HashSet<string>>();
        private readonly Dictionary<string, List<SECommand>> _categoryIndex = new Dictionary<string, List<SECommand>>();
        private readonly Dictionary<string, List<SECommand>> _safetyClassIndex = new Dictionary<string, List<SECommand>>();
        private readonly Dictionary<string, List<SECommand>> _blockTypeIndex = new Dictionary<string, List<SECommand>>();
        
        // Advanced indexes
        private readonly Dictionary<string, List<SECommand>> _effectsIndex = new Dictionary<string, List<SECommand>>();
        private readonly Dictionary<string, List<SECommand>> _preconditionsIndex = new Dictionary<string, List<SECommand>>();
        private readonly Dictionary<string, List<SECommand>> _modApiIndex = new Dictionary<string, List<SECommand>>();
        private readonly Dictionary<string, int> _commandPopularity = new Dictionary<string, int>();
        
        // Search optimization
        private readonly Dictionary<string, double> _wordIdf = new Dictionary<string, double>(); // Inverse Document Frequency
        private readonly int _totalDocuments;
        
        /// <summary>
        /// Build comprehensive search index from SE commands
        /// </summary>
        /// <param name="commands">All SE commands to index</param>
        public DocumentationIndex(List<SECommand> commands)
        {
            _allCommands = commands ?? throw new ArgumentNullException(nameof(commands));
            _totalDocuments = _allCommands.Count;
            
            Console.WriteLine($"🏗️  Building documentation index for {_totalDocuments} commands...");
            
            // Build all indexes
            BuildWordIndex();
            BuildCategoryIndex();
            BuildSafetyClassIndex();
            BuildBlockTypeIndex();
            BuildEffectsIndex();
            BuildPreconditionsIndex();
            BuildModApiIndex();
            CalculatePopularityScores();
            CalculateIdfScores();
            
            Console.WriteLine($"✅ Documentation index built:");
            Console.WriteLine($"   - {_wordToCommandIds.Count} indexed words");
            Console.WriteLine($"   - {_categoryIndex.Count} categories");
            Console.WriteLine($"   - {_safetyClassIndex.Count} safety classes");
            Console.WriteLine($"   - {_blockTypeIndex.Count} block types");
        }
        
        /// <summary>
        /// Perform full-text search with TF-IDF scoring
        /// </summary>
        /// <param name="query">Search query</param>
        /// <param name="maxResults">Maximum results to return</param>
        /// <returns>Ranked search results</returns>
        public List<CommandSearchResult> Search(string query, int maxResults = 20)
        {
            if (string.IsNullOrWhiteSpace(query))
                return new List<CommandSearchResult>();
            
            var queryWords = ExtractWords(query.ToLower());
            var commandScores = new Dictionary<string, double>();
            
            // Calculate TF-IDF scores for each command
            foreach (var word in queryWords.Distinct())
            {
                if (_wordToCommandIds.ContainsKey(word))
                {
                    var idf = _wordIdf.ContainsKey(word) ? _wordIdf[word] : 0;
                    
                    foreach (var commandId in _wordToCommandIds[word])
                    {
                        if (!commandScores.ContainsKey(commandId))
                            commandScores[commandId] = 0;
                        
                        // TF-IDF: term frequency * inverse document frequency
                        var tf = CalculateTermFrequency(commandId, word);
                        commandScores[commandId] += tf * idf;
                    }
                }
            }
            
            // Apply popularity boost
            foreach (var commandId in commandScores.Keys.ToList())
            {
                if (_commandPopularity.ContainsKey(commandId))
                {
                    commandScores[commandId] *= (1 + _commandPopularity[commandId] * 0.1);
                }
            }
            
            // Convert to search results
            var results = new List<CommandSearchResult>();
            foreach (var kvp in commandScores.OrderByDescending(x => x.Value).Take(maxResults))
            {
                var command = _allCommands.FirstOrDefault(c => c.Id == kvp.Key);
                if (command != null)
                {
                    results.Add(new CommandSearchResult
                    {
                        Command = command,
                        RelevanceScore = kvp.Value,
                        MatchReason = $"text_search_score:{kvp.Value:F2}",
                        MatchedTriggers = FindMatchedTriggers(command, queryWords)
                    });
                }
            }
            
            return results;
        }
        
        /// <summary>
        /// Search within a specific category
        /// </summary>
        /// <param name="category">Category to search within</param>
        /// <param name="query">Search query (optional)</param>
        /// <returns>Commands in category matching query</returns>
        public List<SECommand> SearchByCategory(string category, string query = null)
        {
            if (string.IsNullOrWhiteSpace(category))
                return new List<SECommand>();
            
            var categoryKey = category.ToLower();
            if (!_categoryIndex.ContainsKey(categoryKey))
                return new List<SECommand>();
            
            var categoryCommands = _categoryIndex[categoryKey];
            
            // If no query, return all commands in category
            if (string.IsNullOrWhiteSpace(query))
                return categoryCommands;
            
            // Filter by query
            var queryWords = ExtractWords(query.ToLower());
            return categoryCommands.Where(cmd => 
                ContainsAnyWord(cmd, queryWords)
            ).ToList();
        }
        
        /// <summary>
        /// Get commands by safety classification
        /// </summary>
        /// <param name="safetyClass">Safety class (safe, caution, dangerous, etc.)</param>
        /// <returns>Commands with specified safety class</returns>
        public List<SECommand> GetCommandsBySafetyClass(string safetyClass)
        {
            if (string.IsNullOrWhiteSpace(safetyClass))
                return new List<SECommand>();
            
            var key = safetyClass.ToLower();
            return _safetyClassIndex.ContainsKey(key) ? _safetyClassIndex[key] : new List<SECommand>();
        }
        
        /// <summary>
        /// Get commands applicable to specific block types
        /// </summary>
        /// <param name="blockTypes">List of block types</param>
        /// <returns>Commands that work with these block types</returns>
        public List<SECommand> GetCommandsForBlockTypes(List<string> blockTypes)
        {
            if (blockTypes == null || !blockTypes.Any())
                return new List<SECommand>();
            
            var applicableCommands = new HashSet<SECommand>();
            
            foreach (var blockType in blockTypes)
            {
                var key = blockType.ToLower();
                if (_blockTypeIndex.ContainsKey(key))
                {
                    foreach (var command in _blockTypeIndex[key])
                    {
                        applicableCommands.Add(command);
                    }
                }
            }
            
            return applicableCommands.OrderBy(c => c.Category).ThenBy(c => c.Title).ToList();
        }
        
        /// <summary>
        /// Get command recommendations based on current context
        /// </summary>
        /// <param name="recentCommands">Recently used command IDs</param>
        /// <param name="currentCategory">Current category context</param>
        /// <param name="maxRecommendations">Maximum recommendations to return</param>
        /// <returns>Recommended commands</returns>
        public List<SECommand> GetRecommendations(List<string> recentCommands = null, 
            string currentCategory = null, int maxRecommendations = 10)
        {
            var recommendations = new Dictionary<string, double>();
            
            // Category-based recommendations
            if (!string.IsNullOrWhiteSpace(currentCategory))
            {
                var categoryCommands = SearchByCategory(currentCategory);
                foreach (var cmd in categoryCommands.Take(5))
                {
                    recommendations[cmd.Id] = 10.0; // Base category score
                }
            }
            
            // Popularity-based recommendations
            foreach (var kvp in _commandPopularity.OrderByDescending(x => x.Value).Take(15))
            {
                if (!recommendations.ContainsKey(kvp.Key))
                    recommendations[kvp.Key] = 0;
                recommendations[kvp.Key] += kvp.Value * 2.0;
            }
            
            // Related command recommendations
            if (recentCommands != null)
            {
                foreach (var recentCommandId in recentCommands.Take(3))
                {
                    var relatedCommands = GetRelatedCommands(recentCommandId, 5);
                    foreach (var related in relatedCommands)
                    {
                        if (!recommendations.ContainsKey(related.Id))
                            recommendations[related.Id] = 0;
                        recommendations[related.Id] += 5.0;
                    }
                }
            }
            
            // Convert to command list
            var recommendedCommands = new List<SECommand>();
            foreach (var commandId in recommendations.OrderByDescending(x => x.Value).Take(maxRecommendations).Select(x => x.Key))
            {
                var command = _allCommands.FirstOrDefault(c => c.Id == commandId);
                if (command != null)
                {
                    recommendedCommands.Add(command);
                }
            }
            
            return recommendedCommands;
        }
        
        /// <summary>
        /// Get commands related to a specific command
        /// </summary>
        /// <param name="commandId">Base command ID</param>
        /// <param name="maxResults">Maximum related commands to return</param>
        /// <returns>Related commands</returns>
        public List<SECommand> GetRelatedCommands(string commandId, int maxResults = 10)
        {
            var baseCommand = _allCommands.FirstOrDefault(c => c.Id == commandId);
            if (baseCommand == null)
                return new List<SECommand>();
            
            var related = new List<(SECommand command, double score)>();
            
            foreach (var command in _allCommands)
            {
                if (command.Id == commandId) continue;
                
                double score = 0;
                
                // Same category
                if (command.Category == baseCommand.Category)
                    score += 5;
                
                // Shared block types
                if (baseCommand.Targets?.AllowedTypes != null && command.Targets?.AllowedTypes != null)
                {
                    var sharedTypes = baseCommand.Targets.AllowedTypes.Intersect(command.Targets.AllowedTypes).Count();
                    score += sharedTypes * 3;
                }
                
                // Shared tags
                if (baseCommand.Tags != null && command.Tags != null)
                {
                    var sharedTags = baseCommand.Tags.Intersect(command.Tags).Count();
                    score += sharedTags * 2;
                }
                
                // Same safety class
                if (command.SafetyClass == baseCommand.SafetyClass)
                    score += 1;
                
                if (score > 0)
                {
                    related.Add((command, score));
                }
            }
            
            return related
                .OrderByDescending(x => x.score)
                .Take(maxResults)
                .Select(x => x.command)
                .ToList();
        }
        
        /// <summary>
        /// Get search suggestions/autocomplete for partial queries
        /// </summary>
        /// <param name="partialQuery">Partial search query</param>
        /// <param name="maxSuggestions">Maximum suggestions to return</param>
        /// <returns>Search suggestions</returns>
        public List<string> GetSearchSuggestions(string partialQuery, int maxSuggestions = 10)
        {
            if (string.IsNullOrWhiteSpace(partialQuery) || partialQuery.Length < 2)
                return new List<string>();
            
            var suggestions = new HashSet<string>();
            var partialLower = partialQuery.ToLower();
            
            // Find matching natural language triggers
            foreach (var command in _allCommands)
            {
                if (command.NaturalLanguageTriggers != null)
                {
                    foreach (var trigger in command.NaturalLanguageTriggers)
                    {
                        if (trigger.ToLower().StartsWith(partialLower))
                        {
                            suggestions.Add(trigger);
                        }
                    }
                }
                
                // Command titles
                if (command.Title != null && command.Title.ToLower().StartsWith(partialLower))
                {
                    suggestions.Add(command.Title);
                }
            }
            
            return suggestions.Take(maxSuggestions).OrderBy(s => s.Length).ToList();
        }
        
        /// <summary>
        /// Build word-to-command index for full-text search
        /// </summary>
        private void BuildWordIndex()
        {
            foreach (var command in _allCommands)
            {
                var words = new HashSet<string>();
                
                // Index natural language triggers
                if (command.NaturalLanguageTriggers != null)
                {
                    foreach (var trigger in command.NaturalLanguageTriggers)
                    {
                        words.UnionWith(ExtractWords(trigger.ToLower()));
                    }
                }
                
                // Index title, synonyms, tags, etc.
                if (command.Title != null)
                    words.UnionWith(ExtractWords(command.Title.ToLower()));
                
                if (command.Synonyms != null)
                {
                    foreach (var synonym in command.Synonyms)
                        words.UnionWith(ExtractWords(synonym.ToLower()));
                }
                
                if (command.Tags != null)
                {
                    foreach (var tag in command.Tags)
                        words.UnionWith(ExtractWords(tag.ToLower()));
                }
                
                // Add words to index
                foreach (var word in words)
                {
                    if (!_wordToCommandIds.ContainsKey(word))
                        _wordToCommandIds[word] = new HashSet<string>();
                    
                    _wordToCommandIds[word].Add(command.Id);
                }
            }
        }
        
        /// <summary>
        /// Build other specialized indexes
        /// </summary>
        private void BuildCategoryIndex()
        {
            foreach (var command in _allCommands)
            {
                var category = (command.Category ?? "unknown").ToLower();
                if (!_categoryIndex.ContainsKey(category))
                    _categoryIndex[category] = new List<SECommand>();
                
                _categoryIndex[category].Add(command);
            }
        }
        
        private void BuildSafetyClassIndex()
        {
            foreach (var command in _allCommands)
            {
                var safetyClass = (command.SafetyClass ?? "unknown").ToLower();
                if (!_safetyClassIndex.ContainsKey(safetyClass))
                    _safetyClassIndex[safetyClass] = new List<SECommand>();
                
                _safetyClassIndex[safetyClass].Add(command);
            }
        }
        
        private void BuildBlockTypeIndex()
        {
            foreach (var command in _allCommands)
            {
                if (command.Targets?.AllowedTypes != null)
                {
                    foreach (var blockType in command.Targets.AllowedTypes)
                    {
                        var key = blockType.ToLower();
                        if (!_blockTypeIndex.ContainsKey(key))
                            _blockTypeIndex[key] = new List<SECommand>();
                        
                        _blockTypeIndex[key].Add(command);
                    }
                }
            }
        }
        
        private void BuildEffectsIndex()
        {
            foreach (var command in _allCommands)
            {
                if (command.Effects != null)
                {
                    foreach (var effect in command.Effects)
                    {
                        var words = ExtractWords(effect.ToLower());
                        foreach (var word in words)
                        {
                            if (!_effectsIndex.ContainsKey(word))
                                _effectsIndex[word] = new List<SECommand>();
                            
                            _effectsIndex[word].Add(command);
                        }
                    }
                }
            }
        }
        
        private void BuildPreconditionsIndex()
        {
            foreach (var command in _allCommands)
            {
                if (command.Preconditions != null)
                {
                    foreach (var precondition in command.Preconditions)
                    {
                        var words = ExtractWords(precondition.ToLower());
                        foreach (var word in words)
                        {
                            if (!_preconditionsIndex.ContainsKey(word))
                                _preconditionsIndex[word] = new List<SECommand>();
                            
                            _preconditionsIndex[word].Add(command);
                        }
                    }
                }
            }
        }
        
        private void BuildModApiIndex()
        {
            foreach (var command in _allCommands)
            {
                if (command.Implementation?.ModAPICalls != null)
                {
                    foreach (var apiCall in command.Implementation.ModAPICalls)
                    {
                        if (apiCall.Interface != null)
                        {
                            var key = apiCall.Interface.ToLower();
                            if (!_modApiIndex.ContainsKey(key))
                                _modApiIndex[key] = new List<SECommand>();
                            
                            _modApiIndex[key].Add(command);
                        }
                    }
                }
            }
        }
        
        private void CalculatePopularityScores()
        {
            // Assign popularity scores based on various factors
            foreach (var command in _allCommands)
            {
                int popularity = 0;
                
                // More triggers = more popular
                if (command.NaturalLanguageTriggers != null)
                    popularity += command.NaturalLanguageTriggers.Count;
                
                // Safety class affects popularity
                switch (command.SafetyClass?.ToLower())
                {
                    case "safe": popularity += 10; break;
                    case "caution": popularity += 5; break;
                    case "dangerous": popularity += 1; break;
                }
                
                // More examples = more popular
                if (command.Examples != null)
                    popularity += command.Examples.Count * 2;
                
                _commandPopularity[command.Id] = popularity;
            }
        }
        
        private void CalculateIdfScores()
        {
            foreach (var word in _wordToCommandIds.Keys)
            {
                var documentFrequency = _wordToCommandIds[word].Count;
                var idf = Math.Log((double)_totalDocuments / documentFrequency);
                _wordIdf[word] = idf;
            }
        }
        
        private double CalculateTermFrequency(string commandId, string word)
        {
            var command = _allCommands.FirstOrDefault(c => c.Id == commandId);
            if (command == null) return 0;
            
            int termCount = 0;
            int totalWords = 0;
            
            // Count occurrences in all searchable text
            var searchableText = new List<string>();
            
            if (command.NaturalLanguageTriggers != null)
                searchableText.AddRange(command.NaturalLanguageTriggers);
            
            if (command.Title != null)
                searchableText.Add(command.Title);
            
            if (command.Synonyms != null)
                searchableText.AddRange(command.Synonyms);
            
            foreach (var text in searchableText)
            {
                var words = ExtractWords(text.ToLower());
                totalWords += words.Count;
                termCount += words.Count(w => w == word);
            }
            
            return totalWords > 0 ? (double)termCount / totalWords : 0;
        }
        
        private List<string> ExtractWords(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return new List<string>();
            
            return Regex.Split(text.ToLower(), @"[^\w]+")
                .Where(w => w.Length > 1)
                .ToList();
        }
        
        private bool ContainsAnyWord(SECommand command, List<string> words)
        {
            var commandWords = new List<string>();
            
            if (command.Title != null)
                commandWords.AddRange(ExtractWords(command.Title.ToLower()));
            
            if (command.NaturalLanguageTriggers != null)
            {
                foreach (var trigger in command.NaturalLanguageTriggers)
                    commandWords.AddRange(ExtractWords(trigger.ToLower()));
            }
            
            return words.Any(w => commandWords.Contains(w));
        }
        
        private List<string> FindMatchedTriggers(SECommand command, List<string> queryWords)
        {
            var matchedTriggers = new List<string>();
            
            if (command.NaturalLanguageTriggers != null)
            {
                foreach (var trigger in command.NaturalLanguageTriggers)
                {
                    var triggerWords = ExtractWords(trigger.ToLower());
                    if (queryWords.Any(qw => triggerWords.Contains(qw)))
                    {
                        matchedTriggers.Add(trigger);
                    }
                }
            }
            
            return matchedTriggers;
        }
    }
}
