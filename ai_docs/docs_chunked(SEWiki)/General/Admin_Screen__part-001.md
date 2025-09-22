---
title: "Admin Screen"
url: "https://spaceengineers.wiki.gg/wiki/Admin_Screen"
category: "General"
wiki_page: "Admin Screen"
includes_environment: true
includes_blocks: true
---

# Admin Screen - Official Space Engineers Wiki

[![](https://spaceengineers.wiki.gg/images/thumb/Admin_Screen_dropdown.png/320px-Admin_Screen_dropdown.png?1103d4)](https://spaceengineers.wiki.gg/wiki/File:Admin_Screen_dropdown.png)

The Admin Screen, with the drop-down showing all of its sections open.

The Admin Screen used to be called **Space Master**[\[1\]](#cite_note-1). You open the Admin Screen by pressing [ALT key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings")+[F10 key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings") while a game is running. As a mnemonic, think A as in Admin uses AltKey.

This screen is very useful if you are the admin of a [multiplayer](https://spaceengineers.wiki.gg/wiki/Multiplayer "Multiplayer") server and you need "god mode" or "dungeon master" powers. Admins often combine its use with [Spectator Mode](https://spaceengineers.wiki.gg/wiki/Spectator_Mode "Spectator Mode"). Of course, you can also use these powers in your single-player games, in which you are the admin by default.

The settings and changes only apply to the current game. Remember that you need to click **Submit Changes** for automatic settings to become active.

Many of these settings are advanced and some can delete content from your current world, use it at your own risk.

## Admin Tools

This menu changes properties and permissions for the current player. It is useful if you are the admin of a server and need to help other players by cutting and pasting their stuck grids back in, and to fix performance intensive block settings for them.

*   **Enable creative mode tools** -- Enables you to place blocks for free without welding them, to destroy blocks without grinding them, weld up blocks without components, and to [spawn anything in](https://spaceengineers.wiki.gg/wiki/Spawn_Menu "Spawn Menu").
*   Make yourself **invulnerable**.
*   Make yourself **untargetable** by automatic weapons.
*   **Show all players** on the HUD so nobody can hide from you.
*   **Can use all terminals** lets you interact with all functional blocks, even if they are not owned by you or your allies.
*   **Keep original ownership on paste**. If you are helping other players by cutting and pasting their stuck grids, enable this.
*   **Ignore safe zones** means you cannot be stopped by [player-built force fields](https://spaceengineers.wiki.gg/wiki/Safe_Zone "Safe Zone").
*   **Ignore pcu limits** enables you to paste any grid, no matter the size and [PCU](https://spaceengineers.wiki.gg/wiki/PCU "PCU") limits.
*   **Time of day offset** lets you manually move the sun along its path on the skybox, so you can change whether it’s day or night.

## Cycle objects

This screen lets an Admin quickly find any extreme in the game by cycling through all objects sorted by specific criteria. This is useful when looking for the source of performance degradation on multiplayer servers.

A secondary function is the ability to teleport yourself to the identified GPS/planet/grid/player etc.

*   First, **sort** objects by type:
    *   Biggest grids, fastest, most wheels, biggest distance, most active drills/reactors/production/sensors/thrusters;
    *   static objects, floating objects;
    *   characters, [GPS](https://spaceengineers.wiki.gg/wiki/GPS "GPS") markers (distance), [planets](https://spaceengineers.wiki.gg/wiki/Planets "Planets"), owner login time.
*   If applicable, filter the sorted objects to focus only on small grid, or only large grids, or both.
*   Then click the **first**, **next**, or **previous** buttons to cycle through the list.  
    You can see the entity name (and, if applicable, the current value).

When you've found your target, you can remove, stop, or depower it.

Tip: When you are in [Spectator Mode](https://spaceengineers.wiki.gg/wiki/Spectator_Mode "Spectator Mode"), you can also teleport the spectator to the target's location, and then click "player control" to have your character travel there.

## Trash removal

If you notice wrecks and half-welded grids “disappearing”, check whether your automatic Trash Removal settings are too aggressive.

If your game runs well in Singleplayer, simply suspend automatic Trash Removal, and clean up any debris yourself manually! Go to the entity list, look for floating items and grids that are only debris, select them, and delete them.

  
After crashes or space battles, multiplayer servers end up with a lot of floating debris that has an impact on performance if it is not [ground](https://spaceengineers.wiki.gg/wiki/Grinder "Grinder") down or [collected](https://spaceengineers.wiki.gg/wiki/Collector "Collector"). Trash removal means here that such laggy debris is automatically deleted from the game. But the catch is, how do we define what "trash" is, while at the same time preventing the game from automatically removing, say, a half welded ship that you are still working on?

Tip: [Make backups](https://spaceengineers.wiki.gg/wiki/Support "Support") before changing these settings.

### General:

Use this panel to define auto trash detection in game terms. For example, you may decide to allow garbage collection of any grid that is debris, which you define as "either stationary or linearly moving or accelerating, but not powered and not being controlled by a player, and has fewer blocks than 20", and so on.

You can choose from the following criteria for which items and grids are "trash":

*   fixed planetary or space stations (default: off), stationary floating grids (default: on), linearly moving grids (default: on), accelerating grids (default: on)
*   powered grids (default: off), player- controlled grids (default: off),
*   grids with production (default: off), grids with respawn point (default: off),
*   grids with fewer than x blocks (default: 20 blocks), grids with over x metres distance from players (default 500?), time since logout of owner in hours (default 0 = rule inactive).

To ignore all these criteria, and forbid the game any automatic garbage collection, click **Suspend**.

Or to accept and enable the new definition of trash, click **Submit Changes**. Or click **Cancel Changes** to discard any changes to "Trash Removal: General".
