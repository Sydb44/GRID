---
title: "Startup Arguments"
url: "https://spaceengineers.wiki.gg/wiki/Startup_Arguments"
category: "General"
wiki_page: "Startup Arguments"
---

# Startup Arguments - Official Space Engineers Wiki

## Navigation menu

### Search

(#searchInput)

In the Steam version of SE, it is possible to set certain game startup behaviours and path settings as your default.

## Usage

1.  Open Steam.
2.  In the game list, right-click Space Engineers and select **Properties**.
3.  In the window that opens, go to the **General** tab.
4.  Find the **Launch Options** field and enter one or more arguments of your choice. Each argument starts with a hyphen. Separate several arguments by a space. For example: `-nosplash -skipintro`

Alternatively, if you start the game from the Windows commandline, enter your custom arguments right after the executable, for example:

`"C:\Program Files (x86)\Steam\steamapps\common\SpaceEngineers\Bin64\SpaceEngineers.exe" -nosplash -skipintro`

Important: In the following, when you see words in braces, such as _<param>_, it means you must replace them by a value of your choice. Don't include the _<_ and _\>_ characters. For more info on this, see [Command Line Interface: Command description syntax](https://en.wikipedia.org/wiki/Command-line_interface#Command_description_syntax).

## Startup arguments

Choose one or more of the following options:

*   `-skipintro` no longer plays the intro video with the loud harpsichord.
*   `-nosplash` no longer shows the splash image before the game window appears.
*   `-appdata <path>` sets the path to store game saves etc. in a folder of your choice. The [appdata folder](https://spaceengineers.wiki.gg/wiki/How_to_back_up_my_games_and_settings "How to back up my games and settings") is where SE saves logs and your settings, save games, blueprints, etc. It's _%APPDATA%/Space Engineers_ on your C drive by default. Use this argument if want to store your SE data on another drive or in another folder.
*   `-suppressLoadingDialogs` skips the warning popup when loading a world that has an outdated or non-existent binary cache for its .sbc (the cache is a file with .sbcB5 suffix).
*   `+connect <IP address>` immediately connects to the specified game server at the IP address.

For startup arguments specific to Dedicated Servers, visit [Setting up a DS: Command Line Tool](https://spaceengineers.wiki.gg/wiki/Setting_up_a_Space_Engineers_Dedicated_Server#Command_Line_Tool "Setting up a Space Engineers Dedicated Server")

### Unknown or not recommended

*   `-coldstart` precompiles the game for your CPU to avoid it being compiled in realtime (JIT). This is automatically done every time the game updates (you'll see the ngen.exe requesting to run) or if ColdStart.txt is missing from appdata. **You should not need to use this argument manually.**
*   `ms-xbl-multiplayer://` likely used by xbox live to connect to another player or a server.
*   `+connect_lobby <id>` likely used by steam to connect you to a player that you clicked "join game" on.
*   `-generateDx11MipCache` likely generates mip cache for all game textures, not something players should be using. The mip cache is used to show an approximate color while the texture streams in.
*   `-video_record` takes screenshots 60 times a second and stores them in the Recording folder in SE's appdata folder, and turns off some occlusion checks. Might require V-sync to be on to function.
*   `-verboseNetworkLogging` likely spams log with all sorts of details on sending or receiving packets
*   `-render_sync`
*   `-report <logpath>`
*   `-reporX <logpath>`
*   `+launch_scenario <path>` looks for a campaign at the path (unclear if it wants a folder or a file).
*   `+launch_scenario_instance <path>` has priority over +launch\_scenario, unclear what the instance part means.
*   `+launch_scenario_cross_platform` likely sets the created lobby as cross-platform.