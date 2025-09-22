---
title: "Ownership"
url: "https://spaceengineers.wiki.gg/wiki/Ownership"
category: "Vehicles"
wiki_page: "Ownership"
includes_blocks: true
---

# Ownership - Official Space Engineers Wiki

**Ownership** is a feature introduced in [Update 01.037](https://spaceengineers.wiki.gg/wiki/Version/01.037 "Version/01.037"). Any block which includes [Computers](https://spaceengineers.wiki.gg/wiki/Computer "Computer") as [components](https://spaceengineers.wiki.gg/wiki/Component "Component") will have an ownership value assigned to it.

Ownership is relevant for the following game mechanics:

*   Ownership determines who has access to functional blocks (doors, buttons, [Control Panel Screen](https://spaceengineers.wiki.gg/wiki/Control_Panel_Screen "Control Panel Screen")) in [Survival Mode](https://spaceengineers.wiki.gg/wiki/Survival_Mode "Survival Mode").
*   Ownership determines whether a grid [signal](https://spaceengineers.wiki.gg/wiki/Signal "Signal") is identified as friend, neutral, or enemy.
    *   You want your turret AI to shoot enemies.
    *   You transfer ownership of captured enemy wrecks to yourself to prevent your turret AI from shooting it.
*   When building blocks on grids together in multiplayer, the game determines a majority owner of the grid. This affects for example who can paint a ship.
*   Ownership determines at which faction-owned survival kits you can respawn (in addition to unowned ones).
*   NPC owned ships automatically despawn after a while.

An essential related concept is [hacking](https://spaceengineers.wiki.gg/wiki/Hacking "Hacking"), and secondarily, [claiming PCU](https://spaceengineers.wiki.gg/wiki/Claim_NPC_Ship "Claim NPC Ship").

![](https://i.ytimg.com/vi/Kjv62h_BVs0/hqdefault.jpg)

Load video

## Who owns this station or ship?

[![Ownership-in-control-panel.jpg](https://spaceengineers.wiki.gg/images/thumb/Ownership-in-control-panel.jpg/320px-Ownership-in-control-panel.jpg?fee718)](https://spaceengineers.wiki.gg/wiki/File:Ownership-in-control-panel.jpg)

How do I find out who is the owner of a block? Equip a [Welder](https://spaceengineers.wiki.gg/wiki/Welder_\(Tool\) "Welder (Tool)") and simply point at the block, the [tooltip in the top right](https://spaceengineers.wiki.gg/wiki/HUD "HUD") contains an **Owner** line.

For grids (ships, stations, rovers) ownership is determined by who owns the majority of blocks. You can check details on the grid’s [Info Screen](https://spaceengineers.wiki.gg/wiki/Info_Screen "Info Screen"): If you can edit the grid name, you're the majority owner.

## What decides block ownership?

A block's owner is assigned when the [Computer](https://spaceengineers.wiki.gg/wiki/Computer "Computer") components that were added to the construction stockpile are welded and their stage of construction is completed.

*   If this is done with a [handheld Welder](https://spaceengineers.wiki.gg/wiki/Welder_\(Item\) "Welder (Item)"), the player constructing the block becomes the owner.
*   If this is done with a [Welder block](https://spaceengineers.wiki.gg/wiki/Welder_\(Block\) "Welder (Block)"), however, the owner of the welder block becomes the owner of the new block. This distinction becomes relevant if your faction shares a [3D Printer](https://spaceengineers.wiki.gg/wiki/3D_Printer "3D Printer"), the owner of the 3D printer has to assign ownership of the printed ships as well.

Blocks can belong to nobody, which means that everyone is treated as the owner, and anyone can transfer these blocks’ ownership to themselves.

Blocks can also belong to NPCs (non-player characters and their factions), which will equally deny access to non-ally players until [hacked](https://spaceengineers.wiki.gg/wiki/Hacking "Hacking").

The block's owner can change ownership or its sharing settings by accessing the ship's [control panel](https://spaceengineers.wiki.gg/wiki/Control_Panel_Screen "Control Panel Screen") (press [K key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings")).

*   If the block belongs to nobody, then anyone can transfer ownership to anyone.
*   If you own the block, you and the recipient see the [Block Transfers](https://spaceengineers.wiki.gg/wiki/Block_Transfers "Block Transfers") window.

Anyone who gains shared access can use the block normally, but cannot change ownership or sharing settings — only the owner can.

The owner can _share_ access to a block in several ways:

*   No Share - deny usage to all other players
*   Share with all
*   Share with Faction - share usage with members of the your faction. this is useful for survival kits of shared utility vehicles.

The owner can _transfer_ block ownership as follows:

*   give ownership to another player who is online
*   Only server admins can transfer blocks to "Nobody".

To quickly change the ownership of all your blocks in the [Control Panel Screen](https://spaceengineers.wiki.gg/wiki/Control_Panel_Screen "Control Panel Screen"), click one and press [CTRL key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings")+[A key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings") to select all blocks; then use the ownership menu on the right side like normal.

When taking over an enemy or neutral ship for your faction, first transfer ownership to yourself, and _then_ share it with your faction. After you give ownership to another player, you cannot control that grid nor change its ownership anymore.

## How do I take ownership? (Hacking)

Taking block ownership from another player or NPC faction “illegally” is called [Hacking](https://spaceengineers.wiki.gg/wiki/Hacking "Hacking").

When taking over or salvaging a grid owned by an enemy faction (players or NPCs), remember to hack all its blocks and also [claim its PCU](https://spaceengineers.wiki.gg/wiki/Claim_NPC_Ship "Claim NPC Ship"). Without hacking, your AI turrets will attack the captured enemy ship and also you will be unable to open doors and cargo containers, nor use the cockpit to change thruster or gyro settings, etc.
