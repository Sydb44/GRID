[![Airtightness.jpg](https://spaceengineers.wiki.gg/images/thumb/c/c5/Airtightness.jpg/320px-Airtightness.jpg?43404e)](https://spaceengineers.wiki.gg/wiki/File:Airtightness.jpg)

From simplistic O2 wasting builds to the highly complex oxygen conserving multi-part airlock, many variations exist and they can get very complex, very quickly.

*   [Better Airlock](https://steamcommunity.com/sharedfiles/filedetails/?id=2961049014) Aragath has designed an airlock using the [Event Controller](https://spaceengineers.wiki.gg/wiki/Event_Controller "Event Controller"). Subscribe to the blueprint on Steam.
*   ["Auto Airlock - The basics in 2022" guide](https://steamcommunity.com/sharedfiles/filedetails/?id=2712914860) by Dan2D3D
*   [Automatic Airlock build](https://imgur.com/a/n52P8): screenshots on imgur

## Blocks That Are Airtight

*   Interior walls, full armor cubes, 1x1x1 cargo containers, conveyor junctions, conveyor sorters, blast door block, ...
*   Both assemblers, large O2/H2 generator, jump drives, merge blocks, timers, parachute hatch, small artificial mass, collector, batteries, small hydrogen tank, ...
*   Doors form an airtight seal when closed; the  [![Icon Block Sliding Door.png](https://spaceengineers.wiki.gg/images/thumb/0/0a/Icon_Block_Sliding_Door.png/21px-Icon_Block_Sliding_Door.png?364c7b)](https://spaceengineers.wiki.gg/wiki/Sliding_Door "Sliding Door") [Sliding Doors](https://spaceengineers.wiki.gg/wiki/Sliding_Door "Sliding Door") bring their own airtight side walls with them, other doors don’t.

## Blocks That Can Be Rotated to Be Airtight

Airtight on at least one side, if rotated to the side with a full face:

*   Sloped armor corners and half blocks, some windows, catwalks, [air vents](https://spaceengineers.wiki.gg/wiki/Air_Vent "Air Vent"), non-grated stairs, window walls, survival kit, safe zone, both refineries, remote control, small O2/H2 generator, small oxygen tank
*   The backside blocks of: thrusters, wheels suspensions, laser antennas, oxygen farms, ore detectors, most cockpits, small ship tools, small gatling gun, autocannon, ship-based rocket launchers.
*   Certain furniture blocks such as bed, bathroom, toilet, shower, armory, locker, passages, contracts block, dispensers, store
*    [![Icon Block Airtight Hangar Door.png](https://spaceengineers.wiki.gg/images/thumb/a/a0/Icon_Block_Airtight_Hangar_Door.png/21px-Icon_Block_Airtight_Hangar_Door.png?f69327)](https://spaceengineers.wiki.gg/wiki/Airtight_Hangar_Door "Airtight Hangar Door") [Airtight Hangar Door](https://spaceengineers.wiki.gg/wiki/Airtight_Hangar_Door "Airtight Hangar Door"): A non-airtight 1x1x1 block that can extend and become an airtight 1x3x1 block when closed; place several in a line to build large airlocks with custom widths.
*   Offset Doors must be closed and surounded by airtight walls. Somewhat buggy as far as airtightness is concerned.
*   Gates and  [![Icon Block Sliding Door.png](https://spaceengineers.wiki.gg/images/thumb/0/0a/Icon_Block_Sliding_Door.png/21px-Icon_Block_Sliding_Door.png?364c7b)](https://spaceengineers.wiki.gg/wiki/Sliding_Door "Sliding Door") [Sliding Doors](https://spaceengineers.wiki.gg/wiki/Sliding_Door "Sliding Door") must be closed and directly touching airtight walls.

## Blocks That Cause Leaks

Many blocks are considered leaky and cannot be used in the outside wall of airtight rooms. They can still be used _inside_ the rooms without any problems. In general you can tell if blocks do not form a contiguous surface — because they are rounded, because they don't fill a solid block-face, or because they have visible holes along the edges — these blocks will cause leaks.

*   unwelded blocks are not airtight
*   any obvious gaps or missing blocks cause leaks
*   open doors, curved and straight conveyors, 5 sides of connectors/small connectors, blast door corners and edges
*   gyroscopes, all reactors, both gravity generators, hydrogen engine, cryo chamber, survival kit, medical room, programmable block, solar panels, wind mills, antennas, decoys, war head, upgrade modules, small hydrogen thrusters, large artificial mass(?).
*   piston, rotor, large hinge
*   vertical and diagonal windows, barred windows, grated stairs, railings, cover walls  
    E.g. a triangular window pane against the standard 45 degree slope armor is not airtight.
*   all ship weapons and large tool blocks, landing gears, tanks, wheels.
*   all non-full blocks: thin or round armor corners/slopes/tips; button and control panels; sensors, cameras, sound blocks; all seats; control stations; medical station, beacon, vending machines, ATM
*   furniture: lights, couches, desks, passenger seats, kitchen, LCDs, console block, planter, ladders, pillars

## How to tell which blocks are airtight?

Unfortunately there's no built-in way to do this in the game. You have to either use a mod or guess based on how it looks and through trial and error.

Some mods that will help:

*   [Leak Finder](https://steamcommunity.com/sharedfiles/filedetails/?id=3170315974) - Pathfinds from airvent to exterior of the ship, pointing out all the leaking blocks on the way.
*   [BuildInfo](https://steamcommunity.com/sharedfiles/filedetails/?id=514062285) - While holding or aiming at a block you can cycle overlay mode (`ctrl +`) to see airtightness faces for it.

## How airtightness works internally

First some definitions:

*   "Cell" is a 1x1x1 cube slot on a grid where a block or part of a block can exist. Blocks larger than 1x1x1 cover multiple cells.
*   "Cell face" being one of the 6 sides of the cell cube.

The airtightness rules:

*   Independent per [Grid](https://spaceengineers.wiki.gg/wiki/Grid "Grid"), meaning other grids or [Voxels](https://spaceengineers.wiki.gg/wiki/Voxels "Voxels") cannot seal an otherwise open-sided grid.
    *   Example: A small-grid ship parked inside a large-grid hangar does not know that it is inside a pressurised room, it only adheres to its own internal pressurization status.
*   Blocks in construction stage are never airtight.
*   Each cell face can only be either airtight or not.
*   Only block's exterior cell faces can be airtight, the inner ones cannot.

For example, half blocks placed in this configuration will still allow air to pass left/right because their independent sealing on that axis is not airtight.

[![Half blocks airtight example.jpg](https://spaceengineers.wiki.gg/images/thumb/4/4c/Half_blocks_airtight_example.jpg/360px-Half_blocks_airtight_example.jpg?87421c)](https://spaceengineers.wiki.gg/wiki/File:Half_blocks_airtight_example.jpg)

*   [https://support.keenswh.com/spaceengineers/pc/topic/offset-door-has-wrong-airtight-behavior](https://support.keenswh.com/spaceengineers/pc/topic/offset-door-has-wrong-airtight-behavior)
*   [https://support.keenswh.com/spaceengineers/pc/topic/23777-pressurization-discrepancies-in-block-behaviors-as-part-of-a-pressure-boundary](https://support.keenswh.com/spaceengineers/pc/topic/23777-pressurization-discrepancies-in-block-behaviors-as-part-of-a-pressure-boundary)
*   [https://support.keenswh.com/spaceengineers/pc/topic/airtightness-around-gates-and-hangar-doors-when-running-programmable-block-script](https://support.keenswh.com/spaceengineers/pc/topic/airtightness-around-gates-and-hangar-doors-when-running-programmable-block-script)

*   [https://support.keenswh.com/spaceengineers/pc/topic/23220-pressurisation-problem-with-new-half-sliding-door-with-steps-to-repeat](https://support.keenswh.com/spaceengineers/pc/topic/23220-pressurisation-problem-with-new-half-sliding-door-with-steps-to-repeat)