using System;

namespace ClaudeBridge.Foundation
{
    /// <summary>
    /// Debug Output Management System
    /// Controls debug verbosity levels and filters output for better user experience
    /// </summary>
    public static class DebugOutputManager
    {
        #region Configuration
        
        public enum VerbosityLevel
        {
            Silent = 0,     // No debug output
            Essential = 1,  // Only critical information
            Normal = 2,     // Standard operation info
            Detailed = 3,   // All debug information
            Verbose = 4     // Everything including internal state
        }
        
        private static VerbosityLevel _currentLevel = VerbosityLevel.Essential;
        
        #endregion
        
        #region Verbosity Control
        
        /// <summary>
        /// Set debug verbosity level
        /// </summary>
        public static void SetVerbosity(VerbosityLevel level)
        {
            _currentLevel = level;
        }
        
        /// <summary>
        /// Get current verbosity level
        /// </summary>
        public static VerbosityLevel GetVerbosity()
        {
            return _currentLevel;
        }
        
        #endregion
        
        #region Debug Output Methods
        
        /// <summary>
        /// Essential information - always shown unless Silent
        /// </summary>
        public static void Essential(string message)
        {
            if (_currentLevel >= VerbosityLevel.Essential)
            {
                Console.WriteLine(message);
            }
        }
        
        /// <summary>
        /// Normal operation information
        /// </summary>
        public static void Normal(string message)
        {
            if (_currentLevel >= VerbosityLevel.Normal)
            {
                Console.WriteLine(message);
            }
        }
        
        /// <summary>
        /// Detailed debugging information
        /// </summary>
        public static void Detailed(string message)
        {
            if (_currentLevel >= VerbosityLevel.Detailed)
            {
                Console.WriteLine(message);
            }
        }
        
        /// <summary>
        /// Verbose internal state information
        /// </summary>
        public static void Verbose(string message)
        {
            if (_currentLevel >= VerbosityLevel.Verbose)
            {
                Console.WriteLine(message);
            }
        }
        
        /// <summary>
        /// Knowledge system debugging (can be noisy)
        /// </summary>
        public static void KnowledgeDebug(string message)
        {
            if (_currentLevel >= VerbosityLevel.Verbose)
            {
                Console.WriteLine(message);
            }
        }
        
        /// <summary>
        /// Performance timing information
        /// </summary>
        public static void Performance(string message)
        {
            if (_currentLevel >= VerbosityLevel.Normal)
            {
                Console.WriteLine(message);
            }
        }
        
        #endregion
        
        #region Utility Methods
        
        /// <summary>
        /// Show current debug settings
        /// </summary>
        public static void ShowSettings()
        {
            Console.WriteLine($"🔧 Debug Settings:");
            Console.WriteLine($"   Current Level: {_currentLevel}");
            Console.WriteLine($"   Available Levels:");
            Console.WriteLine($"     Silent (0)   - No debug output");
            Console.WriteLine($"     Essential (1) - Critical info only");
            Console.WriteLine($"     Normal (2)    - Standard operation");
            Console.WriteLine($"     Detailed (3)  - All debug info");
            Console.WriteLine($"     Verbose (4)   - Everything");
        }
        
        #endregion
    }
}
