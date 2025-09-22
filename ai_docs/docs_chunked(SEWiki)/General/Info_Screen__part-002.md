
When you add blocks to a grid, the pivot point stays on the first block, but the center of mass shifts.

The following view options are valid for all grids, not just the one you are interacting with, until you switch them off or restart the game. The physics markers only appear when you are close (~40m) to the grid, they are sometimes hard to see on large grid ships. Also, the center of mass and pivot markers can be in the same spot, especially if you are looking at one single block.

*   **Show center of mass** -- The calculated center of the grid is used for gyroscope rotation. The marker looks like a red dot with six yellow rays sticking out.  
    See also [Center of Mass](https://spaceengineers.wiki.gg/wiki/Center_of_Mass "Center of Mass").
*   **Show grid pivot** -- The first built block point around which the grid rotates when being projected or pasted. The marker looks like a red dot with three coloured coordinate axes sticking out.  
    See also [Grid Pivot](https://spaceengineers.wiki.gg/wiki/Grid_Pivot "Grid Pivot").
*   **Show gravity range** -- Shows the cuboid/spherical area of effect around a gravity generator. You must enable "Show on [HUD](https://spaceengineers.wiki.gg/wiki/HUD "HUD")" on the Gravity Generator's Control panel for this to work.  
    See also [Gravity](https://spaceengineers.wiki.gg/wiki/Gravity "Gravity").

You don't need an antenna to see these markers.

## Which grids do I own?

If your engineer is not seated and you open the [Terminal](https://spaceengineers.wiki.gg/wiki/Terminal "Terminal"), then you access _your own_ personal Info tab. On the left side, you can now view the list of all your owned grids and review their [PCU](https://spaceengineers.wiki.gg/wiki/PCU "PCU") cost. On [multiplayer](https://spaceengineers.wiki.gg/wiki/Multiplayer "Multiplayer") servers, keep an eye on your PCU limits, and remove debris that you own to save on PCU cost.

Listed grids with a default name (e.g. "Small Grid 123") that are only 1 block with 25 PCU usage are wheel suspensions, they are listed separately.

[![personal Info tab](https://spaceengineers.wiki.gg/images/thumb/Terminal-personal-info-tab.png/320px-Terminal-personal-info-tab.png?e5cc7f)](https://spaceengineers.wiki.gg/wiki/File:Terminal-personal-info-tab.png)

The engineer's personal Info tab in the Terminal, listing owned blocks and used PCU

Note that you cannot see the Info list of your _owned grids_ while you are seated in a cockpit or interacting with a grid.

## How Do I convert a grid to a ship or station?

The "Convert to Ship/Station" conversion button is available on the Info screen large-grid ships/rovers and stations only.

Space stations and moon bases are examples of static grids. Rovers, mechas, and space ships are examples of mobile grids.

*   Grid conversion from mobile to static can be useful because static grids are much more performance friendly, especially on multiplayer servers.
*   Grid conversion from static to mobile means that you can make a station mobile in Survival Mode, just add thrusters or wheels to it, and move it to a new location.

*   **Converting static to mobile**: Be careful to rid the station thouroughly of any remaining [voxel material](https://spaceengineers.wiki.gg/wiki/Voxels "Voxels") (using [drills](https://spaceengineers.wiki.gg/wiki/Drill "Drill") or [Voxel Hands](https://spaceengineers.wiki.gg/wiki/Voxel_Hands "Voxel Hands")). If there is a basement, you have to grind it off or dig it out completely. Because, after it turns into a mobile grid, being embedded in voxels counts as collision and will do severe block damage.
*   **Converting mobile to static**: Park a large grid safely near an asteroid or on a planet's suface. Make sure that the grid is truly stationary and not drifting, before you convert it to a station. If "unsupported stations" is enabled in the [World Settings](https://spaceengineers.wiki.gg/wiki/World_Settings "World Settings"), you can even park it in mid-air/mid-space.

## Which blocks is a grid made out of?

If the engineer is seated or interacting with a grid, and opens the Terminal's Info tab, then you are accessing _the grid's_ Info. On the left side, you can now view the list of blocks used in this grid and check its total [PCU](https://spaceengineers.wiki.gg/wiki/PCU "PCU"). Keep an eye on your PCU limits on multiplayer servers to not negatively impact performance.

  
On the Info tab you see the total number of blocks and how many of them are non-armour blocks (that is, [Functional Blocks](https://spaceengineers.wiki.gg/wiki/Functional_Blocks "Functional Blocks")). Here you can also quickly check how many Conveyors, Thrusters, Lights/Spotlights, Gravity Generators, Artifical Masses are used in this grid.

This info helps when assessing damage: For example, if your hauler suddenly has an odd number of thrusters, or your fighter suddenly has fewer conveyors, or you suddenly have only very few non-armor blocks left, and other surprising changes, then you know what has been destroyed even before getting out and looking.

  
For mobile grids, here you can see the "Dry mass" and "Total mass". For static grids, mass is not calculated. The dry mass is the mass of the blocks, without cargo.  
Since SE v205 the total mass shown here is the mass used by the physics engine, therefore it can be used to calculate thrust needed regardless of inventory multiplier settings.  
The Ship Inventory Multiplier world setting will scale down item mass inside ships so that a ship with full cargo flies mostly the same regardless of that setting.

  
The Triangles value is a very rough estimate of how complex the grid is to render.  
Models in this game have Level of Detail versions which have less triangles and are shown the further you are from it (distances are set on a per-model basis by the artist).  
Model Detail setting in graphics options, render resolution and camera Field-Of-View all affect this distance, and mods can also affect it too!  
Knowing all that, the value from this screen shows the triangles of the second Level of Detail (LOD1) from all blocks.

  
The Physics Shapes value is shown because it has a limit of 65536 (16 bits) per entity which is imposed by the Havok physics engine. Once you hit that limit some parts of some blocks will simply not be physical anymore and that can change as you add/remove blocks and even after changing nothing and saving&reloading world.  
Blocks can add up to 10 physics shapes each and some blocks do not have any physics shapes at all (e.g. Interior light, Sensor, Camera; which they also do not add any mass to the ship). Deformable armor cubes can merge their physics shapes into bigger cuboids but can also be easily split by newly added armor cubes next to that because the algorithm isn't perfect.  
A lot of physical shapes on a moving ship will also affect the simulation performance.