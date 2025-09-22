---
title: "Setting up a Space Engineers Dedicated Server"
url: "https://spaceengineers.wiki.gg/wiki/Setting_up_a_Space_Engineers_Dedicated_Server"
category: "General"
wiki_page: "Setting up a Space Engineers Dedicated Server"
includes_blocks: true
---

# Setting up a Space Engineers Dedicated Server

Setting up a Space Engineers Dedicated Server (SE DS) lets you and friends connect to a third-party host running Space Engineers, rather than using a local player-host in a peer-to-peer set-up.

## What is a dedicated server?

In this context,

*   the **dedicated server** is a PC that runs nothing but the game
*   the **clients** are your and your friends' gaming PCs

DS are great for hosting long-time multiplayer games.

*   DS run game instances on a separate PC _that you must provide and keep running_!
*   DS run [without needing a graphics card](https://en.wikipedia.org/wiki/Headless_software) and without calculating visual/audio effects which results in a more fluent multiplayer performance with less lag.[\[1\]](#cite_note-1)
    *   Each client has to calculate their own graphics.
*   Both PC and Console players can connect to the same DS.
*   Remember to make regular backups
*   Enhance your server administration experience on PC by adding [Torch](http://torchapi.com/) to your DS to get live management tools and a plugin manager. More info on [getting started with Torch](https://wiki.torchapi.com/index.php?title=Basic_Getting_Started_Guide) here.

In order to _run_ a dedicated server, you technically don't require a licensed copy of the game. However to legally obtain the game server files, at least one Steam account needs to have a valid SE license to download it.

## Important: Server Mods Troubleshooting

The Steam download of mods using the button doesn't work anymore by default. This is because the Steam DLLs included with the dedicated server are out of date.

Fix this by copying the latest DLL versions from an up-to-date version of Steam or SteamCMD, e.g. \`C:\\Program Files (x86)\\Steam\`. Copy the following DLLs, and overwrite the DLLs in the **DedicatedServer64** folder of your server.

*   steamclient64.dll
*   tier0\_s64.dll
*   vstdlib\_s64.dll

## Comparison of alternatives

*   Peer-to-peer multiplayer: It's easy to use with no set-up needed to invite friends by opening your game to friends. The downsides are that the performance depends 100% on your (the host's) PC, which may struggle to be your client and a server at the same time. Other players can only join while you (the host) are online and playing. For many corps or families, this is an acceptable solution.
*   Dedicated Server (DS): For larger, long-running worlds, maybe with international team members, you want to avoid one player’s PC being a client and server at the same time. You want to "dedicate" one PC to do the physics calculations and store the game world for all players. As long as this DS is running, every one can join any time, it does not depend on one player being online. Downside is that one of you must have a second PC lying around that stays on all the time.
*   Paid hosting: If you don't have a second unused PC, you can pay GTXGaming or Nitrado etc. to provide it. See [official hosting providers](http://www.spaceengineersgame.com/official-dedicated-servers-hosts.html).

## Dedicated Server Guide

## Requirements

You need:

*   Windows PC (if you want to run the server as a "service" you need to use an administration account)
*   .NET Redistributable (version 4.6.1 or higher) from [microsoft.com](https://dotnet.microsoft.com/download/dotnet-framework)
*   Visual C++ (VC++) Redistributable packages 2013 and 2015-2019 64bit. (2017 version is included in the 2015-2019 package) from [microsoft.com](https://support.microsoft.com/en-us/topic/the-latest-supported-visual-c-downloads-2647da03-1eea-4433-9aff-95f26a218cc0)
*   Static IP address, if you intend to host the game publicly, so that anyone from the Internet can connect to it.
    *   Not required, but makes it easier for regular players to find your server in the Favourites or History tab.

DS Minimum:

*   CPU 3.2GHz, 3 logical cores
*   6G RAM

DS Recommended:

*   CPU 4.5GHz, 3 logical cores
*   10G RAM

## Installation

If you are logged into the Steam client, simply make a shortcut to SE DS on your desktop, and give it one of these location paths:

 steam://install/298740 [\[2\]](#cite_note-2)

 [https://steamdb.info/app/298740/](https://steamdb.info/app/298740/)[\[3\]](#cite_note-3)

(Many thanks to u/Jeiwyn and u/ElyrianVanguard on Reddit for this information.)

Alternatively, if you can’t download it through the Steam client, install the dedicated server using [SteamCMD](https://developer.valvesoftware.com/wiki/SteamCMD). The app ID for the SE DS is 298740.

Choose _somedirectorypath_ where you want to save it and enter the following on the command line:[\[4\]](#cite_note-4)

 steamcmd.exe +login anonymous +force\_install\_dir somedirectorypath +app\_update 298740 +quit

## Quick Server Setup

You have two options, foreground app or background service:

A foreground application is the easier method if you don’t have admin permissions. The game server runs normally as an active program, only one instance at a time. But when you restart the PC, all foreground apps are closed, and someone has to manually start the game server again.

A service keeps running in the background, even if you close its application window. You can run several services (= several game worlds) at the same time on one host PC — only limited by its memory and performance. After a reboot, a game server running as a service starts itself, and players can immediately log in again.

**Setup as a foreground process:**

1.  Run SpaceEngineersDedicated.exe.
2.  Choose “Local/Console” item in list of servers.
3.  Click “Continue to server configuration”.
4.  Here you can set variety of options. They work the same way as in the game.
5.  Give your server a name.
6.  Press “Save and start” and you are ready to play.

**Setup as a service:**

1.  Run SpaceEngineersDedicated.exe as Administrator.
2.  Press the “Add new instance” button.
3.  Give your service a name (must be unique system-wide).
4.  Choose the service you just created from the list of server instances.
5.  Set up your game the same way as when running it as a foreground process.
6.  Pay attention to ports in “Server settings” and make sure each port is only used by one server instance.
