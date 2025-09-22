---
title: "3D Printer"
url: "https://spaceengineers.wiki.gg/wiki/3D_Printer"
category: "General"
wiki_page: "3D Printer"
includes_blocks: true
---

# 3D Printer - Official Space Engineers Wiki

A 3D printer is not a block that exists in Space Engineers, but an advanced construction that you can choose to [build](https://spaceengineers.wiki.gg/wiki/Building "Building") to mass-produce grids.

## Definition

You may know that you can use a  [![Icon Block Projector.png](https://spaceengineers.wiki.gg/images/thumb/b/b5/Icon_Block_Projector.png/21px-Icon_Block_Projector.png?98a7c1)](https://spaceengineers.wiki.gg/wiki/Projector "Projector") [Projector](https://spaceengineers.wiki.gg/wiki/Projector "Projector") and weld up a [blueprint](https://spaceengineers.wiki.gg/wiki/Blueprint "Blueprint"), either with hand-held tools, or by controlling a welder drone. In any case, with this standard approach, production is slow and you have to move the welders manually.

In contrast, a 3D Printer is a purpose-built [construction](https://spaceengineers.wiki.gg/wiki/Building "Building") that quickly auto-welds projected grids. Setting up such a tool is useful for mass-producing small grids such as [drones](https://spaceengineers.wiki.gg/wiki/Category:Drones "Category:Drones"), mobile defense turrets, [Player Built Weapons](https://spaceengineers.wiki.gg/wiki/Player_Built_Weapons "Player Built Weapons"), or whatever you need.

[![](https://spaceengineers.wiki.gg/images/thumb/1/16/3d-printer-by-spite.png/320px-3d-printer-by-spite.png?ebbb50)](https://spaceengineers.wiki.gg/wiki/File:3d-printer-by-spite.png)

Spite's small ship printer pulls block welders (left) past the projection (right).

The goal of a 3D Printer is that you merely supply "suitable" (see below) blueprints and components, and push the start button, and the printer welds up the blueprint quickly and efficiently without your supervision or manual interference. Don't expect to be mass-printing battle cruisers though; the larger and the more expensive and the more complex the 3D printer gets, the more it defeats its purpose of saving you time and effort. It works best for smaller grids.

## Requirements

To build a 3D printer, you need:

## Construction

There are as many different solutions for how to build a 3D Printer as there are grid shapes. Assuming you already have the necessary components stored and [conveyored](https://spaceengineers.wiki.gg/wiki/Conveyor_system "Conveyor system") to the welders, your main challenge is to have block welders automatically _reach all the blocks_ that must be welded.

If the welders cannot reach the whole projection, you need to either

*   move the projection across the welders, or
*   move the welders across the projection.

[![Tarius' Kebab printer](https://spaceengineers.wiki.gg/images/thumb/2/2f/3D-printer.png/320px-3D-printer.png?5961cc)](https://spaceengineers.wiki.gg/wiki/File:3D-printer.png)

Tarius' Kebab printer: The projection rotates in the center. The four welders on pistons use subgrid detection sensors and auto-retract to not collide with the welded blocks.

The trivial solution would be to build a "welder wall" as big as the projection itself, put the projector on pistons, and move the projection past the wall. But large welder walls are costly, inefficient, and cause lag.

It's better for server performance to use as few welders as possible. To achieve a 3D printer-like _scan-line_ motion, where few welders move to cover a large area, you use [pistons and rotors](https://spaceengineers.wiki.gg/wiki/Mechanical_Blocks "Mechanical Blocks") controlled by timer blocks and sensors.

Depending on the size and shape of the blueprint and available space, there are many different approaches. In all cases, you move either the projector on a piston, or the welders.

### Examples

For inspiration, here some examples what a 3D printer can look like:

*   [Tarius' Kebab Printer](https://youtu.be/NV2qfLYsU7o)  
    A Kebab printer is best for oblong ships. The projector spins on a rotor that is on pistons that move the projection past four welders. The four welders surround the projection orthogonally. The welders are also on pistons and face a central point on the projection’s path. The welders use sensors to detect subgrids and automatically extend and retract the pistons to not collide with finished blocks.

*   [From drop pod to full base in 35 seconds (Reddit)](https://www.reddit.com/r/spaceengineers/comments/s7w8c2/from_drop_pod_to_full_base_in_35_seconds_still_a/)  
    A Record Player printer is best for flat and wide structures. Place a rotor in the middle, and place the welder facing down on the end of a horizontal piston. Spin the arm and slowly extend the welder outward in a spiral shape so it reaches every spot.
*   [ISL - Small Ship Printer Basic MK 3](https://steamcommunity.com/sharedfiles/filedetails/?id=1967085548)  
    Spite's small ship printer pulls a small welder wall past the static projection. This is a simple rotor-less starter printer that everyone can build.

## What are Suitable Blueprints?

What do we mean by blueprints being _suitable_ for 3D printing? Not all blueprints are suitable for 3D printing, you will need to test them.

In the worst case, a badly 3D-printed ship will be missing blocks or will even fall apart. This happens if the welders could not reach all blocks, or could not reach them in the right order, or ran low on components half way through.

After the first test print, verify whether all blocks are there. If some are incomplete, try different projection rotations, angles, or slower welding speeds. If that doesn't fix it, you'll have to build the affected area differently and retake the blueprint.

Example: A gyroscope has only one mount point on one side. When the welder approaches from the opposite side, the gyroscope is not buildable yet because its mounting block is out of reach. If the welder passes too fast, it misses the window where the gyroscope's mount block is already welded _and_ the gyroscope is in range to be built -- which results in the gyroscope never getting welded.
