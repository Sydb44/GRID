using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Threading;

namespace ClaudeBridge.Knowledge
{
    /// <summary>
    /// High-performance cache for SE command documentation with LRU eviction
    /// Optimized for rapid command lookups during Claude API calls
    /// </summary>
    public class DocumentationCache
    {
        private readonly ConcurrentDictionary<string, CachedCommand> _commandCache;
        private readonly ConcurrentDictionary<string, List<SECommand>> _categoryCache;
        private readonly ConcurrentDictionary<string, List<CommandSearchResult>> _searchCache;
        private readonly LinkedList<string> _accessOrder;
        private readonly object _accessOrderLock = new object();
        private readonly int _maxCacheSize;
        private readonly TimeSpan _cacheExpiry;
        
        // Cache hit statistics
        private long _cacheHits = 0;
        private long _cacheMisses = 0;
        private long _totalRequests = 0;
        
        /// <summary>
        /// Initialize documentation cache with specified limits
        /// </summary>
        /// <param name="maxCacheSize">Maximum number of cached items</param>
        /// <param name="cacheExpiryMinutes">Cache expiry in minutes</param>
        public DocumentationCache(int maxCacheSize = 1000, int cacheExpiryMinutes = 60)
        {
            _maxCacheSize = maxCacheSize;
            _cacheExpiry = TimeSpan.FromMinutes(cacheExpiryMinutes);
            _commandCache = new ConcurrentDictionary<string, CachedCommand>();
            _categoryCache = new ConcurrentDictionary<string, List<SECommand>>();
            _searchCache = new ConcurrentDictionary<string, List<CommandSearchResult>>();
            _accessOrder = new LinkedList<string>();
            
            Console.WriteLine($"📦 Documentation cache initialized: {maxCacheSize} items, {cacheExpiryMinutes}min expiry");
        }
        
        /// <summary>
        /// Cache a command with timestamp and access tracking
        /// </summary>
        /// <param name="command">Command to cache</param>
        public void CacheCommand(SECommand command)
        {
            if (command == null || string.IsNullOrEmpty(command.Id)) return;
            
            var cachedCommand = new CachedCommand
            {
                Command = command,
                CachedAt = DateTime.UtcNow,
                AccessCount = 1,
                LastAccessed = DateTime.UtcNow
            };
            
            _commandCache.AddOrUpdate(command.Id, cachedCommand, (key, existing) =>
            {
                existing.Command = command;
                existing.CachedAt = DateTime.UtcNow;
                return existing;
            });
            
            UpdateAccessOrder(command.Id);
            EvictOldEntries();
        }
        
        /// <summary>
        /// Get cached command by ID
        /// </summary>
        /// <param name="commandId">Command ID to lookup</param>
        /// <returns>Cached command if found and not expired</returns>
        public SECommand GetCommand(string commandId)
        {
            Interlocked.Increment(ref _totalRequests);
            
            if (_commandCache.TryGetValue(commandId, out var cachedCommand))
            {
                // Check expiry
                if (DateTime.UtcNow - cachedCommand.CachedAt < _cacheExpiry)
                {
                    // Update access tracking
                    cachedCommand.LastAccessed = DateTime.UtcNow;
                    cachedCommand.AccessCount++;
                    
                    UpdateAccessOrder(commandId);
                    Interlocked.Increment(ref _cacheHits);
                    
                    return cachedCommand.Command;
                }
                else
                {
                    // Remove expired entry
                    _commandCache.TryRemove(commandId, out _);
                }
            }
            
            Interlocked.Increment(ref _cacheMisses);
            return null;
        }
        
        /// <summary>
        /// Cache commands by category for fast category-based lookups
        /// </summary>
        /// <param name="category">Category name</param>
        /// <param name="commands">Commands in this category</param>
        public void CacheCommandsByCategory(string category, List<SECommand> commands)
        {
            if (string.IsNullOrEmpty(category) || commands == null) return;
            
            _categoryCache.AddOrUpdate(category.ToLower(), commands, (key, existing) => commands);
        }
        
        /// <summary>
        /// Get cached commands by category
        /// </summary>
        /// <param name="category">Category to lookup</param>
        /// <returns>Commands in category if cached</returns>
        public List<SECommand> GetCommandsByCategory(string category)
        {
            if (string.IsNullOrEmpty(category)) return null;
            
            Interlocked.Increment(ref _totalRequests);
            
            if (_categoryCache.TryGetValue(category.ToLower(), out var commands))
            {
                Interlocked.Increment(ref _cacheHits);
                return commands;
            }
            
            Interlocked.Increment(ref _cacheMisses);
            return null;
        }
        
        /// <summary>
        /// Cache search results for natural language queries
        /// </summary>
        /// <param name="query">Search query</param>
        /// <param name="results">Search results</param>
        public void CacheSearchResults(string query, List<CommandSearchResult> results)
        {
            if (string.IsNullOrEmpty(query) || results == null) return;
            
            var queryKey = query.ToLower().Trim();
            _searchCache.AddOrUpdate(queryKey, results, (key, existing) => results);
        }
        
        /// <summary>
        /// Get cached search results
        /// </summary>
        /// <param name="query">Search query</param>
        /// <returns>Cached search results if available</returns>
        public List<CommandSearchResult> GetSearchResults(string query)
        {
            if (string.IsNullOrEmpty(query)) return null;
            
            Interlocked.Increment(ref _totalRequests);
            
            var queryKey = query.ToLower().Trim();
            if (_searchCache.TryGetValue(queryKey, out var results))
            {
                Interlocked.Increment(ref _cacheHits);
                return results;
            }
            
            Interlocked.Increment(ref _cacheMisses);
            return null;
        }
        
        /// <summary>
        /// Update LRU access order for cache eviction
        /// </summary>
        /// <param name="key">Key that was accessed</param>
        private void UpdateAccessOrder(string key)
        {
            lock (_accessOrderLock)
            {
                // Remove existing entry
                var node = _accessOrder.Find(key);
                if (node != null)
                {
                    _accessOrder.Remove(node);
                }
                
                // Add to front (most recently used)
                _accessOrder.AddFirst(key);
            }
        }
        
        /// <summary>
        /// Evict old cache entries when cache size limit is reached
        /// </summary>
        private void EvictOldEntries()
        {
            if (_commandCache.Count <= _maxCacheSize) return;
            
            lock (_accessOrderLock)
            {
                while (_commandCache.Count > _maxCacheSize && _accessOrder.Count > 0)
                {
                    // Remove least recently used item
                    var lru = _accessOrder.Last?.Value;
                    if (lru != null)
                    {
                        _commandCache.TryRemove(lru, out _);
                        _accessOrder.RemoveLast();
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
        
        /// <summary>
        /// Clear all cached data
        /// </summary>
        public void ClearCache()
        {
            _commandCache.Clear();
            _categoryCache.Clear();
            _searchCache.Clear();
            
            lock (_accessOrderLock)
            {
                _accessOrder.Clear();
            }
            
            Interlocked.Exchange(ref _cacheHits, 0);
            Interlocked.Exchange(ref _cacheMisses, 0);
            Interlocked.Exchange(ref _totalRequests, 0);
            
            Console.WriteLine("🗑️  Documentation cache cleared");
        }
        
        /// <summary>
        /// Get cache performance statistics
        /// </summary>
        /// <returns>Cache performance metrics</returns>
        public CacheStatistics GetCacheStatistics()
        {
            var totalRequests = Interlocked.Read(ref _totalRequests);
            var cacheHits = Interlocked.Read(ref _cacheHits);
            var cacheMisses = Interlocked.Read(ref _cacheMisses);
            
            return new CacheStatistics
            {
                TotalRequests = totalRequests,
                CacheHits = cacheHits,
                CacheMisses = cacheMisses,
                HitRatio = totalRequests > 0 ? (double)cacheHits / totalRequests : 0,
                CachedCommands = _commandCache.Count,
                CachedCategories = _categoryCache.Count,
                CachedSearchResults = _searchCache.Count,
                MemoryUsageApprox = EstimateMemoryUsage()
            };
        }
        
        /// <summary>
        /// Estimate memory usage of cache (rough approximation)
        /// </summary>
        /// <returns>Estimated memory usage in bytes</returns>
        private long EstimateMemoryUsage()
        {
            // Rough estimate: each command ~5KB, search results ~2KB each
            return (_commandCache.Count * 5000) + 
                   (_categoryCache.Count * 1000) + 
                   (_searchCache.Count * 2000);
        }
        
        /// <summary>
        /// Get most frequently accessed commands
        /// </summary>
        /// <param name="topCount">Number of top commands to return</param>
        /// <returns>Most accessed cached commands</returns>
        public List<(string CommandId, long AccessCount)> GetMostAccessedCommands(int topCount = 10)
        {
            return _commandCache
                .Where(kvp => kvp.Value != null)
                .OrderByDescending(kvp => kvp.Value.AccessCount)
                .Take(topCount)
                .Select(kvp => (kvp.Key, kvp.Value.AccessCount))
                .ToList();
        }
    }
    
    /// <summary>
    /// Cached command with access tracking
    /// </summary>
    internal class CachedCommand
    {
        public SECommand Command { get; set; }
        public DateTime CachedAt { get; set; }
        public DateTime LastAccessed { get; set; }
        public long AccessCount { get; set; }
    }
    
    /// <summary>
    /// Cache performance statistics
    /// </summary>
    public class CacheStatistics
    {
        public long TotalRequests { get; set; }
        public long CacheHits { get; set; }
        public long CacheMisses { get; set; }
        public double HitRatio { get; set; }
        public int CachedCommands { get; set; }
        public int CachedCategories { get; set; }
        public int CachedSearchResults { get; set; }
        public long MemoryUsageApprox { get; set; }
    }
}
