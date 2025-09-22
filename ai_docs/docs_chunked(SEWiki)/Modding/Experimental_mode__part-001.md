---
title: "Experimental mode"
url: "https://spaceengineers.wiki.gg/wiki/Experimental_mode"
category: "Modding"
wiki_page: "Experimental mode"
includes_blocks: true
---

# Experimental mode - Official Space Engineers Wiki

By default, Space Engineers runs in **Safe Mode** with selected feature and limits. You can choose to enable **Experimental Mode** in the [Options](https://spaceengineers.wiki.gg/wiki/Options "Options") if you want to run [scripts](https://spaceengineers.wiki.gg/wiki/Scripting "Scripting"), play on a [Multiplayer](https://spaceengineers.wiki.gg/wiki/Multiplayer "Multiplayer") server that has experimental mode enabled, or use specific advanced features.

From Update 1.206 on, you can install mods without being in experimental mode.

## Why Enable Experimental Mode?

Experimental Mode enables experimental features that are out of scope of where [Keen Software House](https://spaceengineers.wiki.gg/wiki/Keen_Software_House "Keen Software House") guarantees flawless gameplay and tech support. These were features that Keen added to the game throughout its early-access development, but are now not considered to be officially part of the game. However, Keen didn’t want to remove them from the game because many players are used to them.

Experimental features include:

*   [World Settings](https://spaceengineers.wiki.gg/wiki/World_Settings "World Settings") for [Mechanical Blocks](https://spaceengineers.wiki.gg/wiki/Mechanical_Blocks "Mechanical Blocks") as a workaround to reduce [clanging](https://spaceengineers.wiki.gg/wiki/Clang "Clang").
    *   Enable Share Inertia Tensor
    *   Enable Unsafe Piston Impulses
    *   Enable Unsafe Rotor Impulses.
*   [Programmable Block](https://spaceengineers.wiki.gg/wiki/Programmable_Block "Programmable Block") for running [scripts](https://spaceengineers.wiki.gg/wiki/Scripting "Scripting")
*   [Block Placement Mode](https://spaceengineers.wiki.gg/wiki/Block_Placement_Mode "Block Placement Mode") (ctrl+G) availability also from cockpits
*   Changing of [advanced game settings](https://spaceengineers.wiki.gg/wiki/World_Settings "World Settings") such as in-game scripts
*   More players in multiplayer
*   Higher [PCU](https://spaceengineers.wiki.gg/wiki/PCU "PCU") counts allowed in multiplayer
*   Allow enabling Permanent Death mode.
*   Allow enabling [Spectator Mode](https://spaceengineers.wiki.gg/wiki/Spectator_Mode "Spectator Mode").
*   Console compatibility is automatically disabled in the dedicated server GUI if total mod size exceeds 3GB.
*   Console Compatibility is automatically disabled in the dedicated server GUI if PCU Block Limits are not set.
*   Experimental dedicated servers are not visible in the server browser on consoles while in safe mode. To be able to see them, you have to turn on Experimental Mode.

See also [Experimental mode FAQ) on Reddit](https://www.reddit.com/r/spaceengineers/wiki/experimental/).

## What Does “Unsafe” Mean?

The game refers to “Safe” and “Unsafe”/“Experimental” in [warnings](https://spaceengineers.wiki.gg/wiki/Warning_Options "Warning Options"). Many players wonder whether "unsafe" means it will break their saves or crash their machine -- no, at worst the game performance will grind to a halt, and you have to quit and restart and switch the mode off again.

The default “Safe” settings disallow [scripts](https://spaceengineers.wiki.gg/wiki/Scripts "Scripts") (whose fast precision comes at the cost of simspeed if not optimised), and they limit build sizes and player numbers to ensure equal fast performance everywhere including low-end platforms.

”Unsafe” features are also called “experimental” features. They do work fine if your PC and network can handle it, but they are not recommended for everyone because Keen Support cannot help you with their higher performance impact on slower platforms. Players have to make the decision to enable these features at their own risk of slow performance.[\[1\]](#cite_note-1)

### Is sharing inertia tensors safe?

Before Update 1.206, the share inertia tensor setting for [mechanical Blocks](https://spaceengineers.wiki.gg/wiki/Mechanical_Blocks "Mechanical Blocks") was deemed "unsafe" by the developers and only available in experimental mode. Since spring 2025, it is among the "safe" standard [World Settings](https://spaceengineers.wiki.gg/wiki/World_Settings "World Settings"), but off by default.

It can help certain builds to be stable without balancing and adding more mass, and it can help prevent certain grids from [clanging](https://spaceengineers.wiki.gg/wiki/Clang "Clang") themselves to oblivion, but when used on the wrong blocks, the setting can also _cause_ clang or prevent mechanical blocks from moving.

See [Mechanical Blocks - How to improve stability?](https://spaceengineers.wiki.gg/wiki/Mechanical_Blocks#How_to_Improve_Stability? "Mechanical Blocks") for more details.

## How to enable Experimental Mode?

On the main screen, go to **[Options](https://spaceengineers.wiki.gg/wiki/Options "Options") > Game > General** to enable **Experimental Mode** for all games. You cannot enable this mode for just one game. If the option is grayed out it means you have to save the running game and go to the main screen first, to change this setting.

You can switch experimental mode on and off as desired, but games that were created with experimental mode active will work _only_ in experimental mode.

A warning will appear in your games reminding you that experimental mode is on. You can disable this reminder in the [Warning Options](https://spaceengineers.wiki.gg/wiki/Warning_Options "Warning Options") screen.

## Experimental Mode on Consoles

On Xbox and Playstation, the Experimental mode gives console players the possibility to opt into high-performance physics features, such as the “shared inertia tensor” feature of [Mechanical Blocks](https://spaceengineers.wiki.gg/wiki/Mechanical_Blocks "Mechanical Blocks"), or allowing an increased number of players per game, or allowing higher PCU counts.

For example on Xbox, start Space Engineers, go to **Options > Game**, tick **Experimental mode**, and accept the warning.

Consoles do not have access to some features that PC has under Experimental mode, such as:

*   Unsupported stations (stations must be supported by voxels)
*   Sub-grid damage (it's always off),
*   Block limits (limits are always on),
*   [wolves](https://spaceengineers.wiki.gg/wiki/Cyberhounds "Cyberhounds")/[spiders](https://spaceengineers.wiki.gg/wiki/Sabiroids "Sabiroids") NPCs (they are always off),
*   Adaptive simulation quality (it's always on).
