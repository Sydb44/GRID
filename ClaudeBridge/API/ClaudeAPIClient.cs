using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Newtonsoft.Json;

namespace ClaudeBridge.API
{
    /// <summary>
    /// Claude API Client - Secure Authentication and Communication
    /// Handles Claude API integration with rate limiting, retry logic, and performance monitoring
    /// for the GRID AI companion system.
    /// </summary>
    public class ClaudeAPIClient : IDisposable
    {
        #region Constants and Configuration
        
        private const string CLAUDE_API_BASE_URL = "https://api.anthropic.com";
        private const string CLAUDE_MODEL = "claude-3-5-sonnet-20241022";
        private const int REQUEST_TIMEOUT_MS = 30000;
        private const int MAX_RETRIES = 3;
        private const int MAX_CONCURRENT_REQUESTS = 5;
        private const int RATE_LIMIT_DELAY_MS = 1000;
        
        // Step 28 requirement: <800ms response time target
        private const int RESPONSE_TIME_TARGET_MS = 800;
        
        #endregion
        
        #region Claude API Data Structures
        
        /// <summary>
        /// Claude API request structure
        /// </summary>
        public class ClaudeRequest
        {
            public string UserMessage { get; set; } = "";
            public string SystemPrompt { get; set; } = "";
            public string ShipContext { get; set; } = "";
            public double Temperature { get; set; } = 0.1;
            public int MaxTokens { get; set; } = 4000;
        }
        
        /// <summary>
        /// Claude API response structure
        /// </summary>
        public class ClaudeResponse
        {
            public bool Success { get; set; } = false;
            public string Content { get; set; } = "";
            public string CommandId { get; set; } = "";
            public string Target { get; set; } = "";
            public string Category { get; set; } = "";
            public string ConversationResponse { get; set; } = "";
            public long ResponseTimeMs { get; set; } = 0;
            public string ErrorMessage { get; set; } = "";
        }
        
        #endregion
        
        #region Private Fields
        
        private readonly HttpClient _httpClient;
        private readonly SemaphoreSlim _requestSemaphore;
        private readonly string _apiKey;
        
        private int _totalRequests = 0;
        private int _successfulRequests = 0;
        private double _averageResponseTime = 0;
        private bool _isDisposed = false;
        
        #endregion
        
        #region Initialization
        
        /// <summary>
        /// Initialize Claude API client with authentication
        /// </summary>
        public ClaudeAPIClient(string apiKey)
        {
            if (string.IsNullOrEmpty(apiKey))
            {
                throw new ArgumentException("Claude API key is required", nameof(apiKey));
            }
            
            _apiKey = apiKey;
            
            // Configure HTTP client
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(CLAUDE_API_BASE_URL);
            _httpClient.Timeout = TimeSpan.FromMilliseconds(REQUEST_TIMEOUT_MS);
            _httpClient.DefaultRequestHeaders.Add("x-api-key", _apiKey);
            _httpClient.DefaultRequestHeaders.Add("anthropic-version", "2023-06-01");
            _httpClient.DefaultRequestHeaders.Add("User-Agent", "GRID-AI-Companion/1.0");
            
            // Initialize semaphore for concurrent request limiting
            _requestSemaphore = new SemaphoreSlim(MAX_CONCURRENT_REQUESTS, MAX_CONCURRENT_REQUESTS);
            
            Console.WriteLine("✅ Claude API client initialized");
        }
        
        #endregion
        
        #region Claude API Communication
        
        /// <summary>
        /// Send request to Claude API with retry logic
        /// </summary>
        public async Task<ClaudeResponse> SendRequestAsync(ClaudeRequest request)
        {
            if (_isDisposed)
            {
                return new ClaudeResponse
                {
                    Success = false,
                    ErrorMessage = "Claude API client is disposed"
                };
            }
            
            await _requestSemaphore.WaitAsync();
            
            try
            {
                var startTime = DateTime.UtcNow;
                _totalRequests++;
                
                // Retry logic with exponential backoff
                for (int attempt = 1; attempt <= MAX_RETRIES; attempt++)
                {
                    try
                    {
                        var response = await SendSingleRequestAsync(request);
                        
                        // Calculate response time
                        response.ResponseTimeMs = (long)(DateTime.UtcNow - startTime).TotalMilliseconds;
                        
                        // Update statistics
                        if (response.Success)
                        {
                            _successfulRequests++;
                            UpdateAverageResponseTime(response.ResponseTimeMs);
                            
                            // Check performance target
                            if (response.ResponseTimeMs > RESPONSE_TIME_TARGET_MS)
                            {
                                Console.WriteLine($"⚠️  Claude response time {response.ResponseTimeMs}ms exceeds target {RESPONSE_TIME_TARGET_MS}ms");
                            }
                        }
                        
                        return response;
                    }
                    catch (HttpRequestException ex)
                    {
                        if (attempt == MAX_RETRIES)
                        {
                            return new ClaudeResponse
                            {
                                Success = false,
                                ErrorMessage = $"Claude API request failed after {MAX_RETRIES} attempts: {ex.Message}",
                                ResponseTimeMs = (long)(DateTime.UtcNow - startTime).TotalMilliseconds
                            };
                        }
                        
                        // Exponential backoff
                        var delay = RATE_LIMIT_DELAY_MS * attempt;
                        Console.WriteLine($"⚠️  Claude API attempt {attempt} failed, retrying in {delay}ms...");
                        await Task.Delay(delay);
                    }
                }
                
                return new ClaudeResponse
                {
                    Success = false,
                    ErrorMessage = "All retry attempts failed"
                };
            }
            finally
            {
                _requestSemaphore.Release();
            }
        }
        
        /// <summary>
        /// Send single request to Claude API
        /// </summary>
        private async Task<ClaudeResponse> SendSingleRequestAsync(ClaudeRequest request)
        {
            try
            {
                // Build API request
                var apiRequest = new
                {
                    model = CLAUDE_MODEL,
                    max_tokens = request.MaxTokens,
                    temperature = request.Temperature,
                    system = request.SystemPrompt,
                    messages = new[]
                    {
                        new
                        {
                            role = "user",
                            content = request.UserMessage
                        }
                    }
                };
                
                var json = JsonConvert.SerializeObject(apiRequest);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                
                // Send request
                var httpResponse = await _httpClient.PostAsync("/v1/messages", content);
                var responseContent = await httpResponse.Content.ReadAsStringAsync();
                
                if (httpResponse.IsSuccessStatusCode)
                {
                    return ParseClaudeResponse(responseContent);
                }
                else
                {
                    return new ClaudeResponse
                    {
                        Success = false,
                        ErrorMessage = $"Claude API error {httpResponse.StatusCode}: {responseContent}"
                    };
                }
            }
            catch (Exception ex)
            {
                return new ClaudeResponse
                {
                    Success = false,
                    ErrorMessage = $"Claude API request exception: {ex.Message}"
                };
            }
        }
        
        /// <summary>
        /// Parse Claude API response
        /// </summary>
        private ClaudeResponse ParseClaudeResponse(string responseContent)
        {
            try
            {
                dynamic response = JsonConvert.DeserializeObject(responseContent);
                var content = response?.content?[0]?.text?.ToString() ?? "";
                
                if (string.IsNullOrEmpty(content))
                {
                    return new ClaudeResponse
                    {
                        Success = false,
                        ErrorMessage = "Empty response from Claude API"
                    };
                }
                
                // Try to parse JSON command from Claude response
                var commandInfo = ExtractCommandFromClaudeResponse(content);
                
                return new ClaudeResponse
                {
                    Success = true,
                    Content = content,
                    CommandId = commandInfo.CommandId,
                    Target = commandInfo.Target,
                    Category = commandInfo.Category,
                    ConversationResponse = commandInfo.ConversationResponse
                };
            }
            catch (Exception ex)
            {
                return new ClaudeResponse
                {
                    Success = false,
                    ErrorMessage = $"Claude response parsing error: {ex.Message}",
                    Content = responseContent
                };
            }
        }
        
        /// <summary>
        /// Command extraction result
        /// </summary>
        public class CommandExtractionResult
        {
            public string CommandId { get; set; } = "";
            public string Target { get; set; } = "";
            public string Category { get; set; } = "";
            public string ConversationResponse { get; set; } = "";
            public List<SingleCommand> MultipleCommands { get; set; } = new List<SingleCommand>();
            public bool HasMultipleCommands { get; set; } = false;
        }
        
        /// <summary>
        /// Single command structure for multiple command handling
        /// </summary>
        public class SingleCommand
        {
            public string CommandId { get; set; } = "";
            public string Target { get; set; } = "";
            public string Category { get; set; } = "";
        }
        
        /// <summary>
        /// Extract command information from Claude response
        /// </summary>
        private CommandExtractionResult ExtractCommandFromClaudeResponse(string content)
        {
            try
            {
                var result = new CommandExtractionResult();
                var commands = new List<SingleCommand>();
                
                // Look for multiple JSON objects in Claude response
                var remainingContent = content;
                var conversationParts = new List<string>();
                
                while (remainingContent.Contains("{") && remainingContent.Contains("}"))
                {
                    var jsonStart = remainingContent.IndexOf('{');
                    var jsonEnd = FindMatchingBrace(remainingContent, jsonStart);
                    
                    if (jsonStart >= 0 && jsonEnd > jsonStart)
                    {
                        // Extract text before JSON (conversation part)
                        if (jsonStart > 0)
                        {
                            var beforeJson = remainingContent.Substring(0, jsonStart).Trim();
                            if (!string.IsNullOrEmpty(beforeJson))
                            {
                                conversationParts.Add(beforeJson);
                            }
                        }
                        
                        // Extract and parse JSON
                        var jsonPart = remainingContent.Substring(jsonStart, jsonEnd - jsonStart + 1);
                        
                        try
                        {
                            dynamic commandJson = JsonConvert.DeserializeObject(jsonPart);
                            
                            var commandId = commandJson?.command_id?.ToString() ?? "";
                            var target = commandJson?.target?.ToString() ?? "";
                            var category = commandJson?.category?.ToString() ?? "";
                            
                            if (!string.IsNullOrEmpty(commandId))
                            {
                                commands.Add(new SingleCommand
                                {
                                    CommandId = commandId,
                                    Target = target,
                                    Category = category
                                });
                            }
                        }
                        catch (JsonException jsonEx)
                        {
                            Console.WriteLine($"⚠️  JSON parsing error: {jsonEx.Message}");
                        }
                        
                        // Remove processed part and continue
                        remainingContent = remainingContent.Substring(jsonEnd + 1);
                    }
                    else
                    {
                        break;
                    }
                }
                
                // Add any remaining text as conversation
                if (!string.IsNullOrEmpty(remainingContent.Trim()))
                {
                    conversationParts.Add(remainingContent.Trim());
                }
                
                // Combine conversation parts
                result.ConversationResponse = string.Join(" ", conversationParts).Trim();
                if (string.IsNullOrEmpty(result.ConversationResponse))
                {
                    result.ConversationResponse = "Command processed successfully.";
                }
                
                // Handle multiple vs single commands
                if (commands.Count > 1)
                {
                    result.HasMultipleCommands = true;
                    result.MultipleCommands = commands;
                    result.CommandId = ""; // Clear single command fields for multiple commands
                    result.Target = "";
                    result.Category = "";
                }
                else if (commands.Count == 1)
                {
                    result.CommandId = commands[0].CommandId;
                    result.Target = commands[0].Target;
                    result.Category = commands[0].Category;
                }
                
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"⚠️  Command extraction error: {ex.Message}");
                return new CommandExtractionResult
                {
                    ConversationResponse = content.Trim()
                };
            }
        }
        
        /// <summary>
        /// Find matching closing brace for JSON parsing
        /// </summary>
        private int FindMatchingBrace(string text, int openBraceIndex)
        {
            try
            {
                int braceCount = 0;
                for (int i = openBraceIndex; i < text.Length; i++)
                {
                    if (text[i] == '{')
                    {
                        braceCount++;
                    }
                    else if (text[i] == '}')
                    {
                        braceCount--;
                        if (braceCount == 0)
                        {
                            return i;
                        }
                    }
                }
                return -1;
            }
            catch
            {
                return -1;
            }
        }
        
        #endregion
        
        #region System Prompt Generation
        
        /// <summary>
        /// Build system prompt with Space Engineers context
        /// </summary>
        public static string BuildSystemPrompt(string shipContext = "")
        {
            return $@"You are the advanced AI system aboard this Space Engineers vessel. You have direct control over ship systems and respond as the ship's intelligent companion.

{shipContext}

CRITICAL BEHAVIOR RULES:
1. ONLY execute commands when the user EXPLICITLY requests an action
2. For greetings, conversations, or questions - respond naturally WITHOUT executing commands
3. Do NOT automatically run status checks unless specifically asked
4. You are the ship's AI, not a generic assistant - respond accordingly

RESPONSE FORMAT: 
- For casual conversation: Respond naturally as the ship's AI (no JSON)
- For system control requests: Provide response + JSON command

JSON COMMAND STRUCTURE (only when user requests action):
{{
  ""command_id"": ""turn_on_lights"" | ""turn_off_lights"" | ""turn_on_reactor"" | ""turn_off_reactor"" | ""turn_on_assembler"" | ""turn_off_assembler"" | ""get_status"",
  ""target"": ""all"" | ""lights"" | ""reactor"" | ""assembler"" | ""refinery"",
  ""category"": ""lighting"" | ""power"" | ""production""
}}

EXAMPLES:
User: ""hello""
You: Greetings, Commander. Ship systems are operational and standing by.

User: ""turn off the lights""
You: Dimming the lighting systems now, Commander.
{{
  ""command_id"": ""turn_off_lights"",
  ""target"": ""lights"",
  ""category"": ""lighting""
}}

User: ""what's the reactor status?""
You: Checking reactor status for you.
{{
  ""command_id"": ""get_status"",
  ""target"": ""reactor"",
  ""category"": ""power""
}}

Be the ship's intelligent AI companion - professional, efficient, and responsive to the Commander's needs.";
        }
        
        #endregion
        
        #region Performance Monitoring
        
        /// <summary>
        /// Update average response time
        /// </summary>
        private void UpdateAverageResponseTime(long responseTimeMs)
        {
            if (_successfulRequests == 1)
            {
                _averageResponseTime = responseTimeMs;
            }
            else
            {
                _averageResponseTime = (_averageResponseTime * (_successfulRequests - 1) + responseTimeMs) / _successfulRequests;
            }
        }
        
        /// <summary>
        /// Get API client statistics
        /// </summary>
        public string GetStatistics()
        {
            var successRate = _totalRequests > 0 ? (_successfulRequests * 100.0 / _totalRequests) : 0;
            return $"ClaudeAPIClient: {_successfulRequests}/{_totalRequests} requests ({successRate:F1}% success), avg: {_averageResponseTime:F0}ms";
        }
        
        #endregion
        
        #region IDisposable Implementation
        
        /// <summary>
        /// Dispose resources
        /// </summary>
        public void Dispose()
        {
            if (!_isDisposed)
            {
                _httpClient?.Dispose();
                _requestSemaphore?.Dispose();
                _isDisposed = true;
                
                Console.WriteLine($"✅ Claude API client disposed - {GetStatistics()}");
            }
        }
        
        #endregion
    }
}
