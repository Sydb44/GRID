---
title: "Scenario Editor"
url: "https://spaceengineers.wiki.gg/wiki/Scenario_Editor"
category: "Game-Modes"
wiki_page: "Scenario Editor"
---

# Scenario Editor - Official Space Engineers Wiki

## Navigation menu

### Search

\- A wiki theme migration is in progress. If you notice any oddities, please reload the page a bit later, or ping us on the Keen Discord.

(#searchInput)

PC players can use the Visual Scripting Tool (VST) to create scenarios. Scenarios can then be published to the [Workshop](https://spaceengineers.wiki.gg/wiki/Workshop "Workshop").

Either you edit (a copy of) an existing scenario, or you create a [Sandbox Game](https://spaceengineers.wiki.gg/wiki/Sandbox_Game "Sandbox Game") and edit it to create a fully custom scenario.

## How to install the Scenario Editor

You can install this tool only on a PC. It is included as part of the Space Engineers game installation, and so steps 1 and 2 can be skipped if you already have it installed.

1.  In your Steam Library under Games, search for **“Space Engineers”**.
2.  **Install** the game.
3.  Right click the Space Engineers entry in your Steam library or select it and click the cog inside the library entry, go to the "Manage" menu, and then "Browse Local Files" to open up the game install in Windows Explorer.  
    <Your Steam Library>\\steamapps\\common\\SpaceEngineers
4.  Open the _SpaceEngineers\\Tools\\VRageEditor\\_ folder, then run **VisualScripting.bat**.
5.  If this is your first time running VST, select the content folder of the game: Navigate to the Steam installation folder on your computer and select:  
    <Your Steam Library>\\steamapps\\common\\SpaceEngineers\\Content\\

It is also available as part of the Space Engineers Mod SDK toolkit on Steam, and can be installed on PC as follows.

1.  In your Steam Library under Tools, search for **“Space Engineers – Mod SDK”**.
2.  **Install** the SDK tool.
3.  Click **Launch** in Steam to open the SpaceEngineersModSDK folder in Windows Explorer.  
    <Your Steam Library>\\steamapps\\common\\SpaceEngineersModSDK
4.  Open the _SpaceEngineersModSDK\\Tools\\VRageEditor\\_ folder, then run **VisualScripting.bat**.
5.  If this is your first time running VST, select the content folder of the game: Navigate to the Steam installation folder on your computer and select:  
    <Your Steam Library>\\steamapps\\common\\SpaceEngineers\\Content\\

## How to use the Scenario Editor

Run the **VisualScripting.bat** as mentioned above.

Once launched, you’ll be presented with the **Start** workspace, which shows options to start a New Scenario (based on a [Sandbox Game](https://spaceengineers.wiki.gg/wiki/Sandbox_Game "Sandbox Game")) or load an existing scenario.

## Learn More

*   [Official Visual Scripting Tool Guide](https://www.spaceengineersgame.com/visual-scripting-tool/)
*   [Visual Scripting recommended Tutorials](https://steamcommunity.com/sharedfiles/filedetails/?id=1705051163)

## Trivia

*   The scripts for VST are saved as `.vs` files which contain XML data. Then they are compiled into code on world load.
*   [C# mods](https://spaceengineers.wiki.gg/wiki/Modding/Introduction_to_Modding_Space_Engineers#Scripting "Modding/Introduction to Modding Space Engineers") can also access a section of what is available to VST through _Sandbox.Game.MyVisualScriptLogicProvider_.