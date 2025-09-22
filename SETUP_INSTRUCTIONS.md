# 🚀 GRID AI Companion - Quick Setup Guide

## What You Get
Your Space Engineers ship will respond to natural language commands through an AI companion interface.

## Quick Setup (5 minutes)

### 1. Install GRID SE Mod
- Copy `GRID/` folder to your Space Engineers mods directory
- OR create junction: `mklink /J "%APPDATA%\SpaceEngineers\Mods\GRID" "path\to\GRID"`

### 2. Configure ClaudeBridge
- Get Claude API key from Anthropic Console
- Create `ClaudeBridge/api_key.txt` with your API key
- OR set environment variable: `set CLAUDE_API_KEY=your_key_here`

### 3. Run AI Companion
1. **Start Space Engineers** with GRID mod enabled
2. **Load any world** (GRID initializes automatically)
3. **Run ClaudeBridge**: `cd ClaudeBridge && dotnet run`
4. **Chat with your ship**: Type `lights off`, `reactor on`, etc.

## Example Commands
- `lights off` → Turns off ship lights
- `reactor on` → Turns on ship reactor  
- `assembler enable` → Enables assembler
- `get status lights` → Shows light status

## How It Works
```
You: "turn off the reactor"
↓
ClaudeBridge: Processes with AI → Sends command to SE mod
↓  
SE Mod: Safely executes → Reactor turns off in game
↓
ClaudeBridge: "✅ Reactor turned off successfully"
```

**Your ship becomes an intelligent AI companion!** 🤖✨
