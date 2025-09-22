---
title: "Rotor"
url: "https://spaceengineers.wiki.gg/wiki/Rotor"
category: "General"
wiki_page: "Rotor"
includes_blocks: true
---

# Rotor - Official Space Engineers Wiki

| Rotor |     |
| --- | --- |
| [![Icon Block Rotor.png](https://spaceengineers.wiki.gg/images/Icon_Block_Rotor.png?127e75)](https://spaceengineers.wiki.gg/wiki/File:Icon_Block_Rotor.png) |     |
| * * * |     |
| **Function:** | Rotors allows connected grids to rotate. ... |
| **DLC?** | Vanilla |
| * * * |     |
| **Fits small grid** |     |
| Mass: | 168.2 kg |
| Hitpoints: | 706 |
| Power: | \-0.0002 MW |
| PCU: | 100 |
| Size: | 1x2x1 |
| Time to Build: | 10 sec |
| * * * |     |
| **Fits large grid** |     |
| Mass: | 576.4 kg |
| Hitpoints: | 2202 |
| Power: | \-0.002 MW |
| PCU: | 100 |
| Size: | 1x2x1 |
| Time to Build: | 20 sec |
| * * * |     |
| _Data Controls:_ | \[[purge](https://spaceengineers.wiki.gg/wiki/Rotor?action=purge)\] ([?](https://spaceengineers.wiki.gg/wiki/Template:Info_Block))) |
|     |     |

The  [![Icon Block Rotor.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Block_Rotor.png/21px-Icon_Block_Rotor.png?127e75)](https://spaceengineers.wiki.gg/wiki/Rotor "Rotor") Rotor is one of the [Mechanical Blocks](https://spaceengineers.wiki.gg/wiki/Mechanical_Blocks "Mechanical Blocks") that acts as a swivel for rotating structures on stations and ships.

![](https://i.ytimg.com/vi/luZV711EZqU/hqdefault.jpg)

Load video

## Usage

Use rotors when building retractable landing feet, collapsible solar arrays, [custom turrets](https://spaceengineers.wiki.gg/wiki/Custom_Turret_Controller "Custom Turret Controller"), iris doors, turning cranes, [Mecha](https://spaceengineers.wiki.gg/wiki/Walker "Walker") legs, truck hitches, [Docking](https://spaceengineers.wiki.gg/wiki/Docking "Docking") systems, and much more.

The rotor will conduct power and terminal access from one subgrid to another. The [Advanced Rotor](https://spaceengineers.wiki.gg/wiki/Advanced_Rotor "Advanced Rotor") additionally connects the [Conveyor systems](https://spaceengineers.wiki.gg/wiki/Conveyor_system "Conveyor system") of the main grid and the subgrid.

The attached grid is referred to as [subgrid](https://spaceengineers.wiki.gg/wiki/Grid "Grid") and is treated differently as far as steering is concerned. Blocks connected by rotors will appear in different colors in the [Control Panel Screen](https://spaceengineers.wiki.gg/wiki/Control_Panel_Screen "Control Panel Screen").

See also [How to connect small and large grid blocks](https://spaceengineers.wiki.gg/wiki/How_to_connect_small_and_large_grid_blocks "How to connect small and large grid blocks") using rotors.

### How to synchronise two rotors

How to set two rotors to the same velocity but opposite direction:

1.  Switch both Rotors off.
2.  Select both together in the Control Panel Screen and set them both to the same velocity and same braking torque values. Tip: Ctrl-click on a slider to enter a numeric value.
3.  Select _one_ Rotor, and click **Reverse**.
4.  Switch both Rotors back on.

### How to set the rotor base offset

[![](https://spaceengineers.wiki.gg/images/thumb/Rotor_angles_by_kennet0805.png/320px-Rotor_angles_by_kennet0805.png?f8e67f)](https://spaceengineers.wiki.gg/wiki/File:Rotor_angles_by_kennet0805.png)

Creating angled grids using Rotors

The base offset of a large basic rotor is 0.420864 metres. To make it flush with the block grid, stack 5 of them and set their offsets to -0.0792 metres. Stacking 4 at max offsets comes 2 cm short.

The base offset of a small basic rotor is 0.03604 metres. To make it flush with the block grid, set the offset to -0.009 metres.

[Source: (Official Statement) Piston and Rotor Offsets](https://steamcommunity.com/sharedfiles/filedetails/?id=2965022823)

### Control Panel Screen

Rotors can be [grouped](https://spaceengineers.wiki.gg/wiki/Groups "Groups") to share some controls. Most Rotor settings apply also to [Hinges](https://spaceengineers.wiki.gg/wiki/Hinge "Hinge").

Access the Rotor through the [Control Panel Screen](https://spaceengineers.wiki.gg/wiki/Control_Panel_Screen "Control Panel Screen") to adjust its settings:

*   **Safety Detach** - (Rarely needed) When subgrid gets displaced, this setting prevents it from speeding up and damaging its own sub-grids. 10cm to 5 metres (default).
*   **Add Rotor Head** - If the Rotor Head was _detached_, this restores the full Rotor with the default Rotor Head of its size.
*   **Add Medium Head** - (large-grid only) If the Rotor Head was _detached_, this restores the full Rotor with a 3x3 small-grid Rotor Head. For large grid, used to [connect small to large grids](https://spaceengineers.wiki.gg/wiki/How_to_connect_small_and_large_grid_blocks "How to connect small and large grid blocks").
*   **Add Small Head** - (large-grid only) If the Rotor Head was _detached_, this restores the full Rotor with a 1x1 small-grid Rotor Head. For large grid, used to [connect small to large grids](https://spaceengineers.wiki.gg/wiki/How_to_connect_small_and_large_grid_blocks "How to connect small and large grid blocks").
*   **Reverse** - Lets you quickly invert the velocity and makes the rotor turn the other way round.
*   **Attach** - After you manually make a Rotor Head block overlap the Stator, click this button to connect the two grids into one Rotor. E.g. to form a trailer hitch.
*   **Detach** - Drop the Rotor Head block off this stator. Used if you want to _add_ or _attach_ a different head.
*   **Rotor Lock** - Stops the rotor, even if the velocity is non-zero.
*   **Torque** - Sets the lifting strength of the rotor to overcome subgrid mass and external resistance when it's powered.
*   **Braking Torque** - Sets the resisting strength of the rotor to hold the mass of attached blocks when the rotor has been stopped or if there's a power outage. If this is zero, the Rotor swings freely.
*   **Velocity** - Sets the number of rotations per minute (RPM) that it should actively spin. Positive numbers spin clockwise, negative numbers spin counter clockwise. This RPM value is not precisely enforced like clockwork, in game it can be a bit faster/slower, especially with a heavy subgrid.
*   **Lower Limit** - Sets the farthest stop in degrees that the rotor rotates counter clockwise. Or set it to "361" to rotate freely.
*   **Upper Limit** - Sets the farthest stop in degrees that the rotor rotates clockwise. Or set it to "361" to rotate freely.
*   **Rotor Displacement** - Sets the distance of the rotor head to its base. Useful to position the attached subgrid precisely, for example, to fit a door frame or elevator shaft. Solves alignment issues. (Added in update 1.040.)
