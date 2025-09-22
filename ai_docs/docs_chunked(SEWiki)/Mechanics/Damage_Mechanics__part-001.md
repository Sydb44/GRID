---
title: "Damage Mechanics"
url: "https://spaceengineers.wiki.gg/wiki/Damage_Mechanics"
category: "Mechanics"
wiki_page: "Damage Mechanics"
includes_environment: true
includes_blocks: true
---

# Damage Mechanics - Official Space Engineers Wiki

[![](https://spaceengineers.wiki.gg/images/thumb/3/32/Damage.jpg/320px-Damage.jpg?24ffd4)](https://spaceengineers.wiki.gg/wiki/File:Damage.jpg)

Construction and destruction physics were among the first features implemented in the alpha

In [Survival Mode](https://spaceengineers.wiki.gg/wiki/Survival_Mode "Survival Mode"), every block has hitpoints that represent its physical integrity, and players have hitpoints that represent their health.

In singleplayer, or if you are the server admin, you can enable or disable individual Damage Mechanics in the [World Settings](https://spaceengineers.wiki.gg/wiki/World_Settings "World Settings") on a per game basis.

## Damage levels

| Damage level | Players | Blocks |
| --- | --- | --- |
| Full hitpoints | The players are healthy | A functional block is fully functional, an armor block is intact. |
| Loss of hitpoints | Collisions, explosions, exposure, or [weapons](https://spaceengineers.wiki.gg/wiki/Weapon "Weapon") have subtracted hitpoints and the players are wounded. They can still act normally. They can heal themselves using [Life Support](https://spaceengineers.wiki.gg/wiki/Life_Support "Life Support"). | Collisions, explosions, or weapons have caused damage to blocks. Damaged above "the functional line", they still function. Blocks damaged below "the functional line" stop providing their functionality. Damaged armor blocks deform and allow damage to neighbouring blocks; dropped components turn into [Scrap Metal](https://spaceengineers.wiki.gg/wiki/Scrap_Metal "Scrap Metal"). Damaged blocks can still be [repaired](https://spaceengineers.wiki.gg/wiki/Welder "Welder"). |
| Zero hitpoints | [Dead](https://spaceengineers.wiki.gg/wiki/Death "Death") players drop their [backpack](https://spaceengineers.wiki.gg/wiki/Inventory "Inventory") and respawn at an allied [Medical Room](https://spaceengineers.wiki.gg/wiki/Medical_Room "Medical Room") or [Survival kit](https://spaceengineers.wiki.gg/wiki/Survival_kit "Survival kit"). | If a block's hitpoints reach zero, the block breaks beyond repair. Its components turn into [Scrap Metal](https://spaceengineers.wiki.gg/wiki/Scrap_Metal "Scrap Metal"). It stops providing its functionality; attached neighbouring blocks start coming loose. |

## Voxel Damage

[Voxels](https://spaceengineers.wiki.gg/wiki/Voxels "Voxels") can be destroyed by [hand drills](https://spaceengineers.wiki.gg/wiki/Hand_Drill "Hand Drill"), [ship drills](https://spaceengineers.wiki.gg/wiki/Drill "Drill"), [meteors](https://spaceengineers.wiki.gg/wiki/Meteor "Meteor"), [explosions](#Explosive_Damage) and [collisions](#Collision/Impact_Damage).

Tip: Depending on graphic settings, voxel changes on planet surfaces can be seen from orbit which can give away a player’s position in multiplayer.

Most voxels are generated mathematically or from a heightmap, any voxel changes will have to be stored in memory and save file which can eventually impact performance.

In creative or as an admin, to a certain degree you can “repair” smaller holes using [Voxel Hands](https://spaceengineers.wiki.gg/wiki/Voxel_Hands "Voxel Hands") or even [reset an entire chunk](https://spaceengineers.wiki.gg/wiki/Voxel_Hands#Reset_Voxels "Voxel Hands"). To reset entire voxel maps, configure [Trash Removal](https://spaceengineers.wiki.gg/wiki/Admin_Screen#Voxels: "Admin Screen").

## Collision/Impact Damage

[![](https://spaceengineers.wiki.gg/images/5/56/Tooltip_for_a_damaged_block.png?1d1e8a)](https://spaceengineers.wiki.gg/wiki/File:Tooltip_for_a_damaged_block.png)

The HUD shows a block's state when you point at it holding a grinder or welder. This block is damaged "below the functional line".

Collisions and impacts are equally devastating to ships, rovers, voxels, and player characters.

Examples of what counts as collision for ships and rovers ([grids](https://spaceengineers.wiki.gg/wiki/Grid "Grid")):

*   Hitting voxels (mountains, asteroids, ice lakes, boulders) or grids when flying a ship or when catching air in a rover
*   Free-falling from a height
*   Being hit by flying block debris
*   Intersecting with suddenly spawning loose Ores after a filled container bursts (This is less of an issue due to the addition of the [Temporary Container](https://spaceengineers.wiki.gg/wiki/Temporary_Container "Temporary Container"))

Examples for sources of collision damage for player characters:

*   Hitting voxels (planet surface, boulders, ice lakes, asteroids) or grids when jetpacking
*   Free-falling from a height with disabled jetpack
*   Bumping into blocks or other players when not seated in a moving vehicle, e.g. due to abrupt rover/ship manoeuvres
*   Being crushed by falling block debris, e.g. while salvaging wrecks in gravity
*   Being hit by loose Ores, especially in tight mining tunnels

Colliding with trees and bushes doesn’t do much damage, but trees slow vehicles down and can make vehicles rebound into neighbouring voxels.

Grids made of only unfinished blocks will deal no impact damage, even though their mass is that of a fully built block.

## Projectile Weapon Damage

Certain weapons that fire projectiles will deal damage on hit to grids/blocks, characters and loose items.

Some of these projectiles can have [penetration damage](#Penetration_Damage) or [explosive damage](#Explosive_Damage), and some can even [ricochet](#Ricochet) off blocks.

List of weapons dealing this kind of damage can found at [Block Weapons](https://spaceengineers.wiki.gg/wiki/Block_Weapons "Block Weapons") and [Character Weapons](https://spaceengineers.wiki.gg/wiki/Character_Weapons "Character Weapons").

## Explosive Damage

Explosions affect grids/blocks, characters, loose items and carve out voxels.

Grids are the only ones affected in a volumetric way, meaning blocks or grids can shield other blocks or grids from explosion damage with enough hitpoints. However other entities (characters, items, etc) will _not_ be shielded.

Sources of explosive damage:

*   Any block that contains [explosives](https://spaceengineers.wiki.gg/wiki/Explosives "Explosives") or [ammunition](https://spaceengineers.wiki.gg/wiki/Ammunition "Ammunition") in its inventory will explode when destroyed by taking damage. The explosion radius is based on the amount and type of munitions that were inside the inventory.
*   Destroyed [Hydrogen Tank](https://spaceengineers.wiki.gg/wiki/Hydrogen_Tank "Hydrogen Tank") and [Oxygen Tank](https://spaceengineers.wiki.gg/wiki/Oxygen_Tank "Oxygen Tank") explode and deal damage based on the amount of fuel left inside at the time of their destruction.
*   Dropped [Explosives](https://spaceengineers.wiki.gg/wiki/Explosives "Explosives") detonated with weapon shots deal damage to blocks in a (1cm\*number of explosives in stack) blast radius.
*   [Rockets](https://spaceengineers.wiki.gg/wiki/Rocket "Rocket") have a 4m blast radius on impact, doing damage to blocks proportionally to their distance from the center of the blast.
*   [Warheads](https://spaceengineers.wiki.gg/wiki/Warhead "Warhead") explode when shot (when armed), or after a countdown, or after manual detonation.

For more details see respective item's page.

List of weapons dealing explosive damage can be found at [Block Weapons](https://spaceengineers.wiki.gg/wiki/Block_Weapons "Block Weapons") and [Character Weapons](https://spaceengineers.wiki.gg/wiki/Character_Weapons "Character Weapons").

Also, the modding section's [Explosions](https://spaceengineers.wiki.gg/wiki/Modding/Reference/Explosions "Modding/Reference/Explosions") page has all the little details about explosion behaviors.
