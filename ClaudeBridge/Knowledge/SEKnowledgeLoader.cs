using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Diagnostics;
using Newtonsoft.Json;

namespace ClaudeBridge.Knowledge
{
    /// <summary>
    /// Loads Space Engineers knowledge base from se_knowledge folder structure
    /// Processes all JSONL files containing 393+ SE commands with full metadata
    /// </summary>
    public static class SEKnowledgeLoader
    {
        private const string SE_KNOWLEDGE_FOLDER = "se_knowledge";
        private const string COMMANDS_FOLDER = "commands";
        private const string INDEX_FILE = "INDEX.json";
        
        /// <summary>
        /// Load complete SE knowledge base from folder structure
        /// </summary>
        /// <param name="basePath">Base path containing se_knowledge folder</param>
        /// <returns>All loaded commands with loading statistics</returns>
        public static (List<SECommand> commands, KnowledgeLoadingStats stats) LoadKnowledgeBase(string basePath = null)
        {
            var stopwatch = Stopwatch.StartNew();
            var stats = new KnowledgeLoadingStats();
            var allCommands = new List<SECommand>();
            
            try
            {
                // Determine se_knowledge path
                var seKnowledgePath = basePath != null 
                    ? Path.Combine(basePath, SE_KNOWLEDGE_FOLDER)
                    : Path.Combine("..", SE_KNOWLEDGE_FOLDER); // ClaudeBridge is in subfolder
                    
                if (!Directory.Exists(seKnowledgePath))
                {
                    throw new DirectoryNotFoundException($"SE knowledge folder not found at: {seKnowledgePath}");
                }
                
                Console.WriteLine($"📂 Loading SE knowledge from: {seKnowledgePath}");
                
                // Load index file for validation
                var indexPath = Path.Combine(seKnowledgePath, COMMANDS_FOLDER, INDEX_FILE);
                SEKnowledgeIndex index = null;
                if (File.Exists(indexPath))
                {
                    var indexJson = File.ReadAllText(indexPath);
                    index = JsonConvert.DeserializeObject<SEKnowledgeIndex>(indexJson);
                    Console.WriteLine($"📋 Index: Expected {index?.CommandLibraryInfo?.TotalCommands} commands");
                }
                
                // Load commands from all JSONL files
                var commandsPath = Path.Combine(seKnowledgePath, COMMANDS_FOLDER);
                var jsonlFiles = GetAllJsonlFiles(commandsPath);
                
                Console.WriteLine($"📁 Found {jsonlFiles.Count} JSONL files to process");
                
                foreach (var filePath in jsonlFiles)
                {
                    try
                    {
                        // FILTER: Skip metadata files that contain empty title commands
                        var fileName = Path.GetFileName(filePath).ToLower();
                        if (fileName == "normalization.v1.jsonl" || 
                            fileName == "selectors.v1.jsonl" || 
                            fileName == "verbs.v1.jsonl" ||
                            fileName == "parameters.v1.jsonl")
                        {
                            Console.WriteLine($"⏭️  Skipping metadata file: {fileName}");
                            stats.TotalFilesProcessed++;
                            continue;
                        }
                        
                        var commands = LoadCommandsFromJsonlFile(filePath);
                        
                        // FILTER: Only add commands with valid titles and categories
                        var validCommands = commands.Where(c => 
                            !string.IsNullOrEmpty(c.Title) && 
                            !string.IsNullOrEmpty(c.Category) &&
                            !c.Id.StartsWith("normalize.") &&
                            !c.Id.StartsWith("selector.") &&
                            !c.Id.StartsWith("verb.")).ToList();
                        
                        allCommands.AddRange(validCommands);
                        
                        stats.TotalFilesProcessed++;
                        
                        // Track commands per category (use valid commands only)
                        foreach (var command in validCommands)
                        {
                            if (!stats.CategoryCounts.ContainsKey(command.Category))
                                stats.CategoryCounts[command.Category] = 0;
                            stats.CategoryCounts[command.Category]++;
                        }
                        
                        // REDUCED DEBUG: Only show loading summary, not every file
                        // Console.WriteLine($"✅ Loaded {validCommands.Count} valid commands from {Path.GetFileName(filePath)}");
                    }
                    catch (Exception ex)
                    {
                        stats.LoadingErrors++;
                        Console.WriteLine($"❌ Error loading {Path.GetFileName(filePath)}: {ex.Message}");
                    }
                }
                
                stats.CommandsLoaded = allCommands.Count;
                stats.LoadingTime = stopwatch.Elapsed;
                
                // Validation
                if (index != null && stats.CommandsLoaded != index.CommandLibraryInfo.TotalCommands)
                {
                    Console.WriteLine($"⚠️  Command count mismatch: Expected {index.CommandLibraryInfo.TotalCommands}, loaded {stats.CommandsLoaded}");
                }
                else
                {
                    Console.WriteLine($"✅ Successfully loaded {stats.CommandsLoaded} SE commands");
                }
                
                // Display category breakdown
                Console.WriteLine("📊 Commands by category:");
                foreach (var category in stats.CategoryCounts.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"   {category.Key}: {category.Value} commands");
                }
                
                Console.WriteLine($"⏱️  Loading completed in {stats.LoadingTime.TotalMilliseconds:F0}ms");
                
                return (allCommands, stats);
            }
            catch (Exception ex)
            {
                stats.LoadingErrors++;
                stats.LoadingTime = stopwatch.Elapsed;
                Console.WriteLine($"❌ Knowledge loading failed: {ex.Message}");
                throw;
            }
        }
        
        /// <summary>
        /// Load commands from a single JSONL file
        /// </summary>
        /// <param name="filePath">Path to JSONL file</param>
        /// <returns>List of parsed commands</returns>
        private static List<SECommand> LoadCommandsFromJsonlFile(string filePath)
        {
            var commands = new List<SECommand>();
            var lines = File.ReadAllLines(filePath);
            
            for (int lineNumber = 0; lineNumber < lines.Length; lineNumber++)
            {
                var line = lines[lineNumber].Trim();
                if (string.IsNullOrEmpty(line)) continue;
                
                try
                {
                    var command = JsonConvert.DeserializeObject<SECommand>(line);
                    if (command != null && !string.IsNullOrEmpty(command.Id))
                    {
                        // DEBUGGING: Check for critical missing fields
                        if (string.IsNullOrEmpty(command.Title))
                        {
                            Console.WriteLine($"⚠️  Command {command.Id} has empty title in {Path.GetFileName(filePath)}");
                        }
                        if (string.IsNullOrEmpty(command.Category))
                        {
                            Console.WriteLine($"⚠️  Command {command.Id} has empty category in {Path.GetFileName(filePath)}");
                        }
                        
                        commands.Add(command);
                    }
                    else
                    {
                        Console.WriteLine($"⚠️  Invalid command in {Path.GetFileName(filePath)} line {lineNumber + 1}: missing ID or null");
                    }
                }
                catch (JsonException ex)
                {
                    Console.WriteLine($"⚠️  JSON error in {Path.GetFileName(filePath)} line {lineNumber + 1}: {ex.Message}");
                }
            }
            
            return commands;
        }
        
        /// <summary>
        /// Recursively find all JSONL files in commands folder
        /// </summary>
        /// <param name="rootPath">Root commands folder path</param>
        /// <returns>List of all JSONL file paths</returns>
        private static List<string> GetAllJsonlFiles(string rootPath)
        {
            var jsonlFiles = new List<string>();
            
            if (!Directory.Exists(rootPath))
            {
                throw new DirectoryNotFoundException($"Commands folder not found: {rootPath}");
            }
            
            // Get all .jsonl files recursively
            var files = Directory.GetFiles(rootPath, "*.jsonl", SearchOption.AllDirectories);
            jsonlFiles.AddRange(files);
            
            // Sort by path for consistent loading order
            jsonlFiles.Sort();
            
            return jsonlFiles;
        }
        
        /// <summary>
        /// Load specific command by ID for testing/debugging
        /// </summary>
        /// <param name="commandId">Command ID to search for</param>
        /// <param name="basePath">Base path containing se_knowledge folder</param>
        /// <returns>Command if found, null otherwise</returns>
        public static SECommand LoadCommandById(string commandId, string basePath = null)
        {
            var (commands, _) = LoadKnowledgeBase(basePath);
            return commands.FirstOrDefault(c => c.Id == commandId);
        }
        
        /// <summary>
        /// Load all commands matching a specific category
        /// </summary>
        /// <param name="category">Category to filter by</param>
        /// <param name="basePath">Base path containing se_knowledge folder</param>
        /// <returns>Commands in the specified category</returns>
        public static List<SECommand> LoadCommandsByCategory(string category, string basePath = null)
        {
            var (commands, _) = LoadKnowledgeBase(basePath);
            return commands.Where(c => c.Category.Equals(category, StringComparison.OrdinalIgnoreCase)).ToList();
        }
        
        /// <summary>
        /// Load commands that match natural language triggers
        /// </summary>
        /// <param name="userInput">User input to match against triggers</param>
        /// <param name="basePath">Base path containing se_knowledge folder</param>
        /// <returns>Commands with matching triggers</returns>
        public static List<SECommand> FindCommandsByNaturalLanguage(string userInput, string basePath = null)
        {
            var (commands, _) = LoadKnowledgeBase(basePath);
            var inputLower = userInput.ToLower();
            
            return commands.Where(c => 
                c.NaturalLanguageTriggers != null &&
                c.NaturalLanguageTriggers.Any(trigger => 
                    inputLower.Contains(trigger.ToLower()) || 
                    trigger.ToLower().Contains(inputLower)
                )
            ).ToList();
        }
        
        /// <summary>
        /// Get loading statistics for the knowledge base
        /// </summary>
        /// <param name="basePath">Base path containing se_knowledge folder</param>
        /// <returns>Loading statistics</returns>
        public static KnowledgeLoadingStats GetKnowledgeStats(string basePath = null)
        {
            var (_, stats) = LoadKnowledgeBase(basePath);
            return stats;
        }
    }
}
