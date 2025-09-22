---
title: "Piston"
url: "https://spaceengineers.wiki.gg/wiki/Piston"
category: "General"
wiki_page: "Piston"
includes_blocks: true
---

# Piston - Official Space Engineers Wiki

| Piston |     |
| --- | --- |
| [![Icon Block Piston.png](https://spaceengineers.wiki.gg/images/2/28/Icon_Block_Piston.png?8b1fda)](https://spaceengineers.wiki.gg/wiki/File:Icon_Block_Piston.png) |     |
| * * * |     |
| **Function:** | The piston is an expandable block that allows the transfer of power... |
| **DLC?** | Vanilla |
| * * * |     |
| **Fits small grid** |     |
| Mass: | 176.2 kg |
| Hitpoints: | 661 |
| Power: | \-0.0002 MW |
| PCU: | 100 |
| Size: | 1x3x1 |
| Time to Build: | 12 sec |
| * * * |     |
| **Fits large grid** |     |
| Mass: | 576.4 kg |
| Hitpoints: | 2202 |
| Power: | \-0.002 MW |
| PCU: | 100 |
| Size: | 1x3x1 |
| Time to Build: | 20 sec |
| * * * |     |
| _Data Controls:_ | \[[purge](https://spaceengineers.wiki.gg/wiki/Piston?action=purge)\] ([?](https://spaceengineers.wiki.gg/wiki/Template:Info_Block))) |
|     |     |

The  [![Icon Block Piston.png](https://spaceengineers.wiki.gg/images/thumb/2/28/Icon_Block_Piston.png/21px-Icon_Block_Piston.png?8b1fda)](https://spaceengineers.wiki.gg/wiki/Piston "Piston") Piston is a [Mechanical Block](https://spaceengineers.wiki.gg/wiki/Mechanical_Blocks "Mechanical Blocks") that can extend to a multiple of its length in one direction and pull attached blocks with it, thereby adding a push/pull mechanism to the game.

The standard piston looks octagonal, if you want a sturdier looking variant, see [Square Piston](https://spaceengineers.wiki.gg/wiki/Square_Piston "Square Piston").

## Usage

Pistons are used when building retractable landing feet, collapsible solar arrays, hidden turrets, extendable cranes and drill rigs, forklifts, large sliding doors, [Mecha](https://spaceengineers.wiki.gg/wiki/Walker "Walker") legs, lifting jacks for flipped vehicles, and much more.

The piston will convey power to the subgrids and can extend the conveyor system (see below). Pistons can actively push and pull. In contrast to hinges and rotors, you cannot set the braking torque of pistons to zero, which means that pistons cannot be moved passively like suspensions.

[![](https://spaceengineers.wiki.gg/images/thumb/f/fd/Pistons-as-cross-braces.jpg/320px-Pistons-as-cross-braces.jpg?152e28)](https://spaceengineers.wiki.gg/wiki/File:Pistons-as-cross-braces.jpg)

A crane arm stabilised by two extra pistons on rotors used as cross braces

Examples:

*   **Drill Rigs:** [Drills](https://spaceengineers.wiki.gg/wiki/Drill "Drill") on pistons can reach farther and dig wider and deeper mines.
*   **Connectors:** The piston's conveyor ports are useful when building retractable base [Connectors](https://spaceengineers.wiki.gg/wiki/Connector "Connector"): They extend to connect and (un)load landed ships, and then disconnect and move out of the way before take-off, either manually or using Timer Blocks.
*   **Cranes:** Crane joints supported by cross-bracing pistons are much more stable and can lift heavier grids than cranes built out of hinges or rotors alone.

> Blocks connected by pistons will appear in different colors in the [Control Panel Screen](https://spaceengineers.wiki.gg/wiki/Control_Panel_Screen "Control Panel Screen"). The piston-attached grid is referred to as [subgrid](https://spaceengineers.wiki.gg/wiki/Grid "Grid") and is treated differently as far as steering is concerned.

### Control Panel

Pistons can be [grouped](https://spaceengineers.wiki.gg/wiki/Groups "Groups") to share some controls.

To control pistons, use the [control panel](https://spaceengineers.wiki.gg/wiki/Control_Panel_Screen "Control Panel Screen") or assign the actions to [toolbar slots](https://spaceengineers.wiki.gg/wiki/Tool_Bar "Tool Bar"):

1.  First set the piston's **minimum and maximum extend distance**.
    *   For large pistons, it ranges from 0 to 10m (total length 5m-15m)
    *   For small pistons, it ranges from 0 to 2m (total length 1-3m).
2.  Then set the speed of extending and retraction with the **Velocity** slider, maxing out at 5m/s in either direction.
3.  Click the **Reverse** button to extend and retract the piston.

### Toolbar Actions

If you give actions labes, you can define multiple values of the same type.

*   Block on/off
*   Reverse - Switch movement direction between extend or retract
*   Reset Velocity - Sets Velocity of all blocks to 0 = stop
*   Increase Velocity - Gradually increase speed by 0.5 m/s
*   Decrease Velocity - Gradually decrease speed by 0.5 m/s
*   Increase Maximum Distance - Adjustable distance, extend longer, 0.1 m increments
*   Decrease Maximum Distance - Adjustable distance, extend shorter, 0.1 m decrements
*   Increase Minimum Distance - Adjustable distance, retract less, 0.1 m increments
*   Decrease Minimum Distance - Adjustable distance, retract more, 0.1 m decrements
*   Add Piston Head - Restores the subgrid attachment part if the head was destroyed.
*   Set Velocity - Enter the velocity in m/s. Then give this setting a named label, such as “ vel: 5”.
*   Set And Move - First enter the absolute distance to move in metres, must be a positive number within the length of the piston. Then enter the velocity in m/s. Then give this setting a named label, such as “Ext: 5” moves the piston to its 5m extension.

Even though you can add a piston head, you cannot re-attach a piston base to a piston head on another grid, as you can do with a [Rotor](https://spaceengineers.wiki.gg/wiki/Rotor "Rotor")/Rotor Head. It's somewhat possible (albeit fiddly) to reattach pistons using [Merge Blocks](https://spaceengineers.wiki.gg/wiki/Merge_Block "Merge Block").

### How to stabilise grids

Don’t connect two pistons to the same grids on both ends and then set the pistons to different speeds or different extensions, because that would cause an impossible situation and stress to which the simulation likely reacts with a [rapid unscheduled disassembly](https://en.wiktionary.org/wiki/rapid_unplanned_disassembly).

When connected one to another to form [subgrids](https://spaceengineers.wiki.gg/wiki/Grid "Grid"), pistons can bend or push subgrids into one another, and generate a lot of vibration and shake the grid apart (also known as [Clang](https://spaceengineers.wiki.gg/wiki/Clang "Clang")). In general, it's safest to use mechanical blocks on static grids.

On the [Control Panel Screen](https://spaceengineers.wiki.gg/wiki/Control_Panel_Screen "Control Panel Screen") ([Experimental mode](https://spaceengineers.wiki.gg/wiki/Experimental_mode "Experimental mode")), enable the **Share Inertia Tensor** setting of the subgrid pistons. Do not enable **Share Inertia Tensor** on the _first_ piston that’s attached to the main grid. This equalises the virtual masses to achieve more stable behaviour.

If you have to use mechanical blocks while flying/driving a mobile grid, it's recommended to set a  [![Icon Block Gyroscope.png](https://spaceengineers.wiki.gg/images/thumb/9/9c/Icon_Block_Gyroscope.png/21px-Icon_Block_Gyroscope.png?c8eb45)](https://spaceengineers.wiki.gg/wiki/Gyroscope "Gyroscope") [Gyroscope](https://spaceengineers.wiki.gg/wiki/Gyroscope "Gyroscope") on override with 0 RPM on all axes for stabilisation. Optimally, park, and lock the grid safely to the ground with  [![Icon Block Landing Gear.png](https://spaceengineers.wiki.gg/images/thumb/2/2d/Icon_Block_Landing_Gear.png/21px-Icon_Block_Landing_Gear.png?d381be)](https://spaceengineers.wiki.gg/wiki/Landing_Gear "Landing Gear") [Landing Gear](https://spaceengineers.wiki.gg/wiki/Landing_Gear "Landing Gear") while using mechanical blocks. This will help greatly to reduce shaking.
