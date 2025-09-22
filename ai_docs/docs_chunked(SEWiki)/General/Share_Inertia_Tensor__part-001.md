---
title: "Mechanical Blocks"
url: "https://spaceengineers.wiki.gg/wiki/Share_Inertia_Tensor"
category: "General"
wiki_page: "Share Inertia Tensor"
includes_blocks: true
---

# Mechanical Blocks - Official Space Engineers Wiki

In Space Engineers, the mechanical blocks are:

*    [![Icon Block Piston.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Block_Piston.png/21px-Icon_Block_Piston.png?8b1fda)](https://spaceengineers.wiki.gg/wiki/Piston "Piston") [Pistons](https://spaceengineers.wiki.gg/wiki/Piston "Piston")
*    [![Icon Block Rotor.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Block_Rotor.png/21px-Icon_Block_Rotor.png?127e75)](https://spaceengineers.wiki.gg/wiki/Rotor "Rotor") [Rotors](https://spaceengineers.wiki.gg/wiki/Rotor "Rotor")
*    [![Icon Block Hinge.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Block_Hinge.png/21px-Icon_Block_Hinge.png?672bc9)](https://spaceengineers.wiki.gg/wiki/Hinge "Hinge") [Hinges](https://spaceengineers.wiki.gg/wiki/Hinge "Hinge")

In contrast to other blocks, mechanical blocks can move and pull attached [subgrids](https://spaceengineers.wiki.gg/wiki/Grid "Grid") with them. Use them to build parts that turn (rotor), tilt or fold (hinge), or extend and retract (pistons). Rotors and hinges can move actively, or passively, or be locked. Pistons can only move actively, they are neither coil springs nor suspensions.

Video: A beautiful example how to use mechanical blocks, by Squeegy Mackoy (2013/2023)

![](https://i.ytimg.com/vi/dX_H_gqNcK8/hqdefault.jpg)

Load video

## Usage

You can use mechanical blocks to build grids with extending drill/welder/grinder arms, crane arms, mecha "wings" and [walker](https://spaceengineers.wiki.gg/wiki/Walker "Walker") legs, large foldable hangar doors, collapsible landing legs, rotating vector thrusters, elevators, and much more. You can even use them to keep subgrids statically locked in an angled position for decorative purposes.

[![](https://spaceengineers.wiki.gg/images/thumb/Mechanical-blocks.jpg/320px-Mechanical-blocks.jpg?87c19a)](https://spaceengineers.wiki.gg/wiki/File:Mechanical-blocks.jpg)

Use rotors, pistons, and hinges to create angled, cross bracing, or moving subgrids. Image credit: BlackArmor.

## What Are Subgrids and why do I care?

Think of a spaceship with foldable landing gear and vector thrust: The blocks attached through mechanical blocks (here, the landing gear on hinges, and the thrusters on rotors) will appear in different colors in your ship's [Control Panel Screen](https://spaceengineers.wiki.gg/wiki/Control_Panel_Screen "Control Panel Screen"). These attached grids are referred to as [subgrids](https://spaceengineers.wiki.gg/wiki/Subgrid "Subgrid").

This is relevant, because subgrids are treated differently as far as steering is concerned, in a way that will have an impact on your flying/driving:

*   The [Inertial Dampers](https://spaceengineers.wiki.gg/wiki/Inertial_Dampeners "Inertial Dampeners") do not consider subgrid mass
*   Wheels and thrusters on subgrids are not controlled by cockpit input from the main grid

Read more about [subgrids](https://spaceengineers.wiki.gg/wiki/Subgrid "Subgrid") to understand the pros and cons, and learn about workarounds to fix these steering limitations, using scripts.

## What are Hitboxes and why do I care?

When connected to form [subgrids](https://spaceengineers.wiki.gg/wiki/Grid "Grid"), mechanical blocks can push blocks “into” one another; such physically impossible states generate vibrations that shake the grid apart violently (also known as [Clang](https://spaceengineers.wiki.gg/wiki/Clang "Clang")).

This is because the physics simulation uses an optimisation where it measures collisions only by looking at simplified invisible collision shapes called hitboxes. [Version/1.196](https://spaceengineers.wiki.gg/wiki/Version/1.196 "Version/1.196") released in 2020 decreased oversized hitboxes of blocks and armor to represent the shape of the blocks more appropriately, which resolved many clanging issues, and multiplied the possibilities of smoothly working mechanical constructions. Still, be careful and don't place any blocks inside the range of mechanical blocks, or your vehicle will shake itself apart.

## How to control Mechanical Blocks?

Assign Reverse/Extend actions to your toolbat, and also increase/decrease mininum maximum. By combining these actions, you can control the movement of mechanical blocks.

You may have a situation where you want to save several min and max values. E.g. a custom extending welder arm is either folded up and stowed for transport, or it’s unfolded and extending between it’s minimum and maximum. A ship ramp may be closed to form sealed door, or unfolded to be horizontal footbridge, or to be a sloped ramp. In short, mechanical device may have a closed/stowed position and a working range. You can set up a minimum and a maximum range for rotors, hinges and pistons, but that does not leave room anymore to set up the stowed position. From version 205 on, you can predefine multiple target values and save them under a named label. When you then set another value, you can give it a separate label. This way, several set-value actions can co-exist on the toolbar, and you can switch between stowed min/max or working min/max.

## How to Improve Stability?

### Anchoring

In general, it's safest to use the mechanical blocks on static grids, such as cranes on your base.

Especially for mobile grids, lock the main grid to the ground with  [![Icon Block Landing Gear.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Block_Landing_Gear.png/21px-Icon_Block_Landing_Gear.png?d381be)](https://spaceengineers.wiki.gg/wiki/Landing_Gear "Landing Gear") [Landing Gear](https://spaceengineers.wiki.gg/wiki/Landing_Gear "Landing Gear") while subgrids (such as drill arms) are moving mechanically. Magnetic Landing Gear will temporarily turn a mobile main grid static. If immobilisation is not an option, setting  [![Icon Block Gyroscope.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Block_Gyroscope.png/21px-Icon_Block_Gyroscope.png?c8eb45)](https://spaceengineers.wiki.gg/wiki/Gyroscope "Gyroscope") [Gyroscopes](https://spaceengineers.wiki.gg/wiki/Gyroscope "Gyroscope") on a zero RPM override helps reduce shaking.
