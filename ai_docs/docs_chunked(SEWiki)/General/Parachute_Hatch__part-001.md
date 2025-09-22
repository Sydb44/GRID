---
title: "Parachute Hatch"
url: "https://spaceengineers.wiki.gg/wiki/Parachute_Hatch"
category: "General"
wiki_page: "Parachute Hatch"
includes_environment: true
includes_blocks: true
---

# Parachute Hatch - Official Space Engineers Wiki

| Parachute Hatch |     |
| --- | --- |
| [![Icon Block Parachute Hatch.png](https://spaceengineers.wiki.gg/images/5/59/Icon_Block_Parachute_Hatch.png?73c703)](https://spaceengineers.wiki.gg/wiki/File:Icon_Block_Parachute_Hatch.png) |     |
| * * * |     |
| **Function:** | Parachute hatches deploy parachutes to slow down the descent of shi... |
| **DLC?** | Vanilla |
| * * * |     |
| **Fits small grid** |     |
| Mass: | 84.2 kg |
| Hitpoints: | 316 |
| PCU: | 50  |
| Size: | 1x1x1 |
| Time to Build: | 10 sec |
| * * * |     |
| **Fits large grid** |     |
| Mass: | 472.4 kg |
| Hitpoints: | 1847 |
| PCU: | 50  |
| Size: | 1x1x1 |
| Time to Build: | 22 sec |
| * * * |     |
| _Data Controls:_ | \[[purge](https://spaceengineers.wiki.gg/wiki/Parachute_Hatch?action=purge)\] ([?](https://spaceengineers.wiki.gg/wiki/Template:Info_Block))) |
|     |     |

The Parachute Hatch is a functional block used to gradually slow the trajectory of a mobile grid in gravity and atmosphere to a safe velocity. You must load the hatches with  [![Icon Item Canvas.png](https://spaceengineers.wiki.gg/images/thumb/8/84/Icon_Item_Canvas.png/21px-Icon_Item_Canvas.png?88f865)](https://spaceengineers.wiki.gg/wiki/Canvas "Canvas") [Canvas](https://spaceengineers.wiki.gg/wiki/Canvas "Canvas") before each use.

If you suddenly see a floating parachute in game, see [Unknown Signals](https://spaceengineers.wiki.gg/wiki/Unknown_Signals "Unknown Signals") for more info.

![](https://i.ytimg.com/vi/37CLgox9-k8/hqdefault.jpg)

Load video

![](https://i.ytimg.com/vi/HxGaF-iHfH8/hqdefault.jpg)

Load video

## Usage

Compared to slowing down manually using atmospheric or hydrogen braking thrusters, parachutes only use a fraction of the power/hydrogen. At the same time, deployed parachutes prevent you from being able to steer or adjust your heading.

Typically you install Parachute Hatches on shuttles, rescue pods, or cargo drops that land vertically on atmospheric planets. Also a car racing can deploy a horizontal drogue chute to perform braking manoeuvres that are faster than any other means of deceleration.

### Conditions

The parachute behaviour can be a bit counter-intuitive since the actual atmospheric pressure is ignored. The auto deployment conditions are simply that parachutes work on planets with atmosphere and planetary gravity. This means:

*   If you create an artificial airtight and pressurized room with artificial gravity on an asteroid, the Parachute _will not_ deploy.
*   If you create an artificial airtight and _de_pressurized room on a planet, the Parachute _will_ deploy.

### How to open the parachute

Typically, you group your parachutes, and define an auto-deploy height for them. Then assign the group's **Open** action, as well as the group's **Auto Deploy On/Off** toggle to [toolbar slots](https://spaceengineers.wiki.gg/wiki/Tool_Bar "Tool Bar") to be able to trigger them.

The Parachute Hatch comes with several settings in its [Control Panel Screen](https://spaceengineers.wiki.gg/wiki/Control_Panel_Screen "Control Panel Screen"):

*   Open - Click this button to manually deploy the parachute (or parachute group).
*   Closed - Click this button to manually cut the parachutes.
*   Auto deploy - Choose whether the parachute should auto deploy at a certain height.
    *   Auto deploy height -- Move the slider to define a height in metres above "sea level".

Conditions for the parachute hatch to open:

*   Must be in dense atmosphere
*   Must be loaded with one set of canvas
*   Must be in natural gravity

In thin atmospheres, the parachute looks oblong, that means it does not have its full effect.

### How many are "one set" of canvas?

Deploying the Parachute Hatch uses up one set of cavas.

*   On small grid each hatch uses up 1 piece of canvas
*   On large grid each hatch uses up five pieces of canvas.

### What if blocks are in the way of the parachute?

When the hatch opens, the parachute unfurls. It does not matter whether the hatch doors are covered by other blocks, the parachute will deploy even through the hull.

### How to reload Canvas

Every Parachute Hatch, whether large grid or small grid, has only one conveyor door which is the only place where canvas can be inserted. The inventory holds 8 litres on small grid and 40L on large grid. The inventory can hold nothing but one set of  [![Icon Item Canvas.png](https://spaceengineers.wiki.gg/images/thumb/8/84/Icon_Item_Canvas.png/21px-Icon_Item_Canvas.png?88f865)](https://spaceengineers.wiki.gg/wiki/Canvas "Canvas") [Canvas](https://spaceengineers.wiki.gg/wiki/Canvas "Canvas") items.

*   On small grid, one set is _one_ canvas.
*   On large grid, one set is _five_ canvases.

You cannot pre-load several sets of canvas in advance. Attaching the blocks to your conveyor system is recommended to be able to reload all hatches quickly and automatically. Otherwise, you must keep the ports accessible for manual reload — and face the risk of forgetting to reload it (and crashing).

### What is the auto-deploy height?

The parachute auto deploy height is defined above global _sea level_. Note that the display in your cockpit is height above local _ground level_!

Also make sure to avoid mountain tops and high plains: When parachutes auto-deploy in a thin atmosphere above the highest mountain, they may not be able to slow you down enough before you reach the ground.

### How to get rid of the parachute

Parachutes despawn when inertia and velocity are 0 m/sec. When the ship rests on the planet surface, the parachutes cut automatically.

Careful:

*   If you accidentally slow down, maybe because your inertial dampers engaged the thrusters, the parachute will auto-cut and likely be expended earlier than expected.
*   If you cannot come to a rest, maybe because your ship is slowly sliding down a cliff, the parachutes will remain open, and prevent you from actively steering or accelerating.
*   It’s safer to disable auto-deploy when there’s a chance of abrupt velocity changes ahead -- for example, before a ship is copied and pasted using Creative tools in a Survival game, or when sliding down the side of a mountain.

Manually closing deployed parachutes does not return the canvas, it is used up!
