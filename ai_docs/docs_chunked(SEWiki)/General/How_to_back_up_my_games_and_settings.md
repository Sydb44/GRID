---
title: "How to back up my games and settings"
url: "https://spaceengineers.wiki.gg/wiki/How_to_back_up_my_games_and_settings"
category: "General"
wiki_page: "How to back up my games and settings"
---

# How to back up my games and settings

Whether you are moving to another PC, making regular backups of your favourite worlds, or sending a broken save game to Keen [Support](https://spaceengineers.wiki.gg/wiki/Support "Support"), you need to know where the files are.

If you know how to do this for missing other platforms, please add the paths!

## Where does SE save all my game data?

By default in Windows, the AppData folder contains all your save games, backups, settings, and blueprints. This folder can grow quite large and you may want to move it to another drive or back it up selectively.

**For Steam installations:** Open Windows Explorer and find SE's appdata under this path:

%APPDATA%\\SpaceEngineers\\

This path expands to

c:\\Users\\YOUR WINDOWS USERNAME\\AppData\\Roaming\\SpaceEngineers\\

If you have permanently moved this folder to another drive, use a [startup argument](https://spaceengineers.wiki.gg/wiki/Startup_Arguments "Startup Arguments") to reconnect it to the game!

## How Do I Back up World Save Files?

When transferring save files (individual worlds) to Keen Support or other players, note that the game save folders can grow quite large. Don’t send the whole folder, but identify the one relevant save file, and then use a file compression tool such as Zip!

**For Steam installations:** Open Windows Explorer and find your Saves under this path:

%APPDATA%\\SpaceEngineers\\Saves\\

This path expands to

c:\\Users\\YOUR WINDOWS USERNAME\\AppData\\Roaming\\SpaceEngineers\\Saves\\

## How Do I Back up Blueprints?

The easiest way to backup your blueprints is to publish them on one of the [Workshop](https://spaceengineers.wiki.gg/wiki/Workshop "Workshop").

Alternatively you can make local backups of this folder:

**For Steam installations:** Open Windows Explorer and find your Saves under this path:

%APPDATA%\\SpaceEngineers\\blueprints\\Local

This path expands to

c:\\Users\\YOUR WINDOWS USERNAME\\AppData\\Roaming\\SpaceEngineers\\blueprints\\Local

## How Do I Back Up My Game Options?

The [Options](https://spaceengineers.wiki.gg/wiki/Options "Options") that you set on the main screen are stored in a file. The location is good to know when you want to make backups, or reset your options to the default by deleting or renaming the file.

**For Steam:** Open Windows Explorer and find your Options under:

%APPDATA%\\SpaceEngineers\\SpaceEngineers.cfg

This path expands to

c:\\Users\\YOUR WINDOWS USERNAME\\AppData\\Roaming\\SpaceEngineers\\SpaceEngineers.cfg

The options file is plain text, you can open it (and carefully edit it) in Notepad or Notepad++.

## Where Are These User Files on a Dedicated Server?

On a dedicated multiplayer server, the equivalent folder that contains game saves and options is here:

%APPDATA%\\SpaceEngineersDedicated