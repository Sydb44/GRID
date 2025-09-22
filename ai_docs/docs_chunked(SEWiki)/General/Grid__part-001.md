---
title: "Grid"
url: "https://spaceengineers.wiki.gg/wiki/Grid"
category: "General"
wiki_page: "Grid"
includes_environment: true
includes_blocks: true
---

# Grid - Official Space Engineers Wiki

[![](https://spaceengineers.wiki.gg/images/thumb/2/22/Big_Red_2022_back.jpg/320px-Big_Red_2022_back.jpg?6a9914)](https://spaceengineers.wiki.gg/wiki/File:Big_Red_2022_back.jpg)

Big Red, an iconic spaceship, here seen next to a voxel asteroid, is an example of a "large grid"

Constructions that you [build](https://spaceengineers.wiki.gg/wiki/Building "Building") out of blocks in Space Engineers are known as **grids** -- in contrast to [voxel structures](https://spaceengineers.wiki.gg/wiki/Voxels "Voxels") such as asteroids and planets. Grids are made of blocks, blocks are made of components, components are made of materials, materials are made of ores.

## Examples

Grids include all forms of vehicles and player-made structures of any size, the smallest being singular blocks. Grids are either static (large [Stations](https://spaceengineers.wiki.gg/wiki/Station "Station")) or mobile; mobile grids can be either large ([Large Grids](https://spaceengineers.wiki.gg/wiki/Large_Grid "Large Grid")) or small ([Small Grids](https://spaceengineers.wiki.gg/wiki/Small_Grid "Small Grid")).

## Types

When players are talking about grids they are building, you will hear the following words used:

*   **Supergridding**: An old exploit where players edited block definitions in the save file and changed their grid size, resulting in a mix of large and small grid blocks within the same main grid.

## Advantages of multigrids

Subgrids allow you to build cool functional things, such as folding solar panels, large sliding or folding hangar doors, vehicle trailers on hitches, rotating VTOL thrusters, foldable mining rigs, walking [mechas](https://spaceengineers.wiki.gg/wiki/Walker "Walker") or robots, flapping wings, cranes, catapults, [rotating multi-turrets](https://spaceengineers.wiki.gg/wiki/Custom_Turret_Controller "Custom Turret Controller"), fold-out stairs, elevators, escalators, hull and wing shapes with arbitrary block angles, ... and many more functional contraptions or creative decorations!

Subgrids receive power from the main grid.

All mechanical blocks (except the basic Rotor) have [conveyor capabilities](https://spaceengineers.wiki.gg/wiki/Conveyor_system "Conveyor system") and you can pipe items through their inventory across subgrids.

By default, subgrids are excepted from a lot of the damage mechanics, because a lot of their movements next to other subgrids would be considered destructive collisions by the physics engine. In the [World Settings](https://spaceengineers.wiki.gg/wiki/World_Settings "World Settings"), you can re-**enable Sub-Grid damage** if you want to live dangerously.

## How to combine large and small grids?

Small grids have the same functionality as large grids but are cheaper and more compact. Alas, blocks of different grid sizes cannot be attached to one another directly. However, both [Rotors](https://spaceengineers.wiki.gg/wiki/Rotor "Rotor") and [Hinges](https://spaceengineers.wiki.gg/wiki/Hinge "Hinge") allow the attachment of a small grid rotor head to a large grid stator, which lets you indirectly attach grids of different sizes to one another.

How to build mixed-size grids:

*   Either, move a small grid with a rotor or hinge head on it close to a headless large grid stator of the corresponding type, then click the _Attach_ button in the control panel of the large stator.
*   Alternatively, construct the large rotor or hinge, grind off its automatically-generated large head, and then click the _Add Small Head_ button in the control panel of the large stator. A small grid may then be built out from the new small head.

The end result will be a semi-permanently attached small subgrid on the large main grid.

Read more under [How to connect small and large grid blocks](https://spaceengineers.wiki.gg/wiki/How_to_connect_small_and_large_grid_blocks "How to connect small and large grid blocks").

### Example: A Monitoring Dashboard

You can use [Event Controllers](https://spaceengineers.wiki.gg/wiki/Event_Controller "Event Controller") and coloured [lights](https://spaceengineers.wiki.gg/wiki/Interior_Light "Interior Light") and LCDs to build a dashboard that monitors the power/cargo/oxygen/fuel status of your base.

The problem is that on large grids, every tiny light etc. takes up one large grid cube, which makes building a monitoring dashboard unwieldy. Instead, you build a small grid dashboard and attach it through a Rotor.

Similarly, if your large grid ship is using a lot of unwieldy [Timers](https://spaceengineers.wiki.gg/wiki/Timer_Block "Timer Block") and [Event Controllers](https://spaceengineers.wiki.gg/wiki/Event_Controller "Event Controller"), you can build (some or all of) them together on a small grid and attach it.

[How to build warning lights](https://spaceengineers.wiki.gg/wiki/How_to_build_warning_lights "How to build warning lights")

## Disadvantages of Multigrids

Knowing what a subgrid is is relevant to an engineer because of its limitations:

### Why can't I steer the Subgrid?

The first disadvantage is that you cannot steer wheels, thrusters, or gyroscopes on subgrids from the main cockpit -- unless you use scripts (see below).

You will not be able to use the WASD keys to propel any subgrid wheels, nor fire the subgrid thrusters, nor will the mouse pitch/yaw/roll the subgrid gyroscopes. A wheel attached directly to the main grid through a [Wheel Suspension](https://spaceengineers.wiki.gg/wiki/Wheel_Suspension "Wheel Suspension") can be steered from the main cockpit, but not if the Wheel Suspension is attached to a subgrid on a rotor/piston/hinge. You can passively drag a wheeled subgrid along, but it will not help you with propulsion, and often its passiveness and extra mass may even hinder steering.

### Why is my Multigrid sinking?

The second disadvantage is that [Inertial Dampers](https://spaceengineers.wiki.gg/wiki/Inertial_Dampers "Inertial Dampers") do not account for the mass of subgrids.

This issue is most strongly noticeable on planetary ships flying in gravity when they use mechanical blocks in landing legs, nacelles, angled wings, vector thrusters, etc. If your ship has subgrids, it will sink[\[1\]](#cite_note-1)[\[2\]](#cite_note-2) or tilt in planetary gravity, and you will have to constantly fight that miscalculation manually.

While thrusters on the maingrid don't waste fuel while not actively flying, thrusters on subgrids fight the main grid and do waste fuel, so switch them off after landing or use a script.

Subgrids tilting can be counteracted by a [Gyroscope](https://spaceengineers.wiki.gg/wiki/Gyroscope "Gyroscope") override, but to fight the constant sinking, you’ll need extra thrusters and a subgrid control script (see workarounds below).
