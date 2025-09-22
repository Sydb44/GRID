---
title: "How to set up more than two rotor stops"
url: "https://spaceengineers.wiki.gg/wiki/How_to_set_up_more_than_two_rotor_stops"
category: "Resources"
wiki_page: "How to set up more than two rotor stops"
includes_blocks: true
---

# How to set up more than two rotor stops

This tutorial was made mostly redundant by the [Rotor](https://spaceengineers.wiki.gg/wiki/Rotor "Rotor")'s **Rotate to Angle** setting added in the Contact update (205).

  
When you look at the  [![Icon Block Rotor.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Block_Rotor.png/21px-Icon_Block_Rotor.png?127e75)](https://spaceengineers.wiki.gg/wiki/Rotor "Rotor") [Rotor](https://spaceengineers.wiki.gg/wiki/Rotor "Rotor") Control Panel, you notice that you can only set one upper and one lower limit. The rotor reverses between these two angles and stops only there. What if you want the rotation to stop in middle positions (90, 180, 270 degrees) as well?

One solution would be custom [scripting](https://spaceengineers.wiki.gg/wiki/Scripting "Scripting"), but that's not an option for everyone. Here are some vanilla solutions.

## Multiple Rotor Stop Locations tutorial by BlackArmor

A very precise scriptless _Vanilla_ solution is to force the rotating subgrid to come to a halt by "[docking](https://spaceengineers.wiki.gg/wiki/Docking "Docking")" it to the main grid. This method works no matter in which direction the rotor turns (positive or negative velocity).

The following video shows details from minute 17 on:

![](https://i.ytimg.com/vi/FTIQHxE132U/hqdefault.jpg)

Load video

First, build your rotating grid and make it rotate between its upper and lower limit.

1.  Identify the positions where you want it to stop in between.
2.  Build an aligned, matching pair of [docking](https://spaceengineers.wiki.gg/wiki/Docking "Docking") blocks, one on the rotor subgrid and one on the main grid.
3.  When the subgrid rotates past the spot, make it stop by "docking" it to the main grid.

For "docking" at stops, you have several block pairs to choose from:

|     |     |     |     |
| --- | --- | --- | --- |How to choose docking blocks
| Docking blocks | Alignment requirements | Grid Sizes | Docking |
| Pair of Connectors | a bit of leeway in alignment | large and small | Autolock on/off |
| Pair of Merge blocks | no leeway in alignment | either large, or small | switch on/off |
| Hinge + Hinge Part | still docks at a pitched/yawed angle | large and small | start/stop Timer block loop that triggers Attach action |
| Rotor + Rotor Head | still docks at rotated angle | large and small | start/stop Timer block loop that triggers Attach action |
| Magnetic Plate + voxels or blocks | a lot of leeway | large and small | Autolock on/off |

Switch the docking pair off, switch the next pair on, and unlock the rotor to continue. And so on.

## Event Controller

Another "Vanilla" approach is using [Event Controllers](https://spaceengineers.wiki.gg/wiki/Event_Controller "Event Controller") (EC). For example, we use the EC to watch whether the rotor angle is larger than 90, larger than 180, larger than 270 degrees. The EC method works only if the rotor goes in one direction (positive velocity). For two directions, you'd need twice as many ECs, to trigger before and after a stop, which is annoying to set up.

Luckily in our case, ECs do not trigger constantly "while" the event is ongoing. After the rotor passes 90 and continues spinning towards 180, the current angle is of course still greater than 90. But ECs react only once, in the moment when the event happens (e.g. when the rotor angle passes from 90 to 91).

1.  Build your rotor construction. Pay attention to how you place the rotor and remember which degree markings point at your stops.
2.  Build two Timers for each stop:
    *   one action timer that triggers actions at the stop
    *   one reset timer that resets the system after the stop
3.  Set up the rotor rotate between 0-360 limits (positive velocity).
4.  Build an Event Controller for each stop.
5.  Set up each EC:
    *   Select Event: Angle Changed
    *   Select Condition: "is equal or greater".
    *   Enter the degree number between -360 to +360 degrees for each stop.
6.  Click **Add Blocks** and select the Rotor.
7.  Click **Select Action**.
    *   In the first slot, start the action timer for that stop.
    *   In the second slot, start the reset timer for that stop.