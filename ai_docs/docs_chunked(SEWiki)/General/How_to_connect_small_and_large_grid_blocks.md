---
title: "How to connect small and large grid blocks"
url: "https://spaceengineers.wiki.gg/wiki/How_to_connect_small_and_large_grid_blocks"
category: "General"
wiki_page: "How to connect small and large grid blocks"
includes_blocks: true
---

# How to connect small and large grid blocks

One way of connecting a large grid and a small grid is of course docking through their [Connectors](https://spaceengineers.wiki.gg/wiki/Connector "Connector"), but what about more permanent solutions?

[![](https://spaceengineers.wiki.gg/images/thumb/Large-ore-detector-with-connector.png/320px-Large-ore-detector-with-connector.png?65c06d)](https://spaceengineers.wiki.gg/wiki/File:Large-ore-detector-with-connector.png)

A small-grid vehicle can temporarily dock to a functioning large-grid ore detector using Connectors

## Problem

For example, you want to build a large grid station, and you want to include an [Engineer Plushie](https://spaceengineers.wiki.gg/wiki/Engineer_Plushie "Engineer Plushie"), but it exists for small grid only.

Or you want to build a monitor with many [Event Controllers](https://spaceengineers.wiki.gg/wiki/Event_Controller "Event Controller"), [Timer Blocks](https://spaceengineers.wiki.gg/wiki/Timer_Block "Timer Block"), plus status lights and LCD labels for them; or a computer with Timers and Programmable Blocks. In large grid size, that would be 1) expensive to build and 2) extremely unwieldy.

If you could build this in small grid and attach the construct to the large grid, it would be much more compact. Here are some tricks how to combine grids of two sizes.

## Solution

It’s an interesting fact that _small grid_ rotor heads also fit on _large grid_ rotor stators; and _small grid_ hinge parts also fit on _large grid_ hinges. This means that you can create grids that are a mix of large and small grid blocks.

In this usecase, we don't actually want the rotor/hinge to spin, so we lock it.

For example, through a hybrid rotor, you can attach a large grid [Ore Detector](https://spaceengineers.wiki.gg/wiki/Ore_Detector "Ore Detector") to a small-grid ship permanently to benefit from the longer detection range, or you can [build a compact monitoring array](https://spaceengineers.wiki.gg/wiki/How_to_build_warning_lights "How to build warning lights") on a large-grid station.

[![Large-grid-rotor-small-grid-head.png](https://spaceengineers.wiki.gg/images/thumb/Large-grid-rotor-small-grid-head.png/320px-Large-grid-rotor-small-grid-head.png?fb5068)](https://spaceengineers.wiki.gg/wiki/File:Large-grid-rotor-small-grid-head.png)

The only disadvantage of this method is that the attached grid is considered a [subgrid](https://spaceengineers.wiki.gg/wiki/Grid "Grid") which has some limitations with steering and [Inertial Dampers](https://spaceengineers.wiki.gg/wiki/Inertial_Dampers "Inertial Dampers").

## How to build a small grid on an existing large grid

1.  Build a large-grid rotor.
2.  Open its [Control Panel Screen](https://spaceengineers.wiki.gg/wiki/Control_Panel_Screen "Control Panel Screen").
3.  Click **Detach** to drop the large Rotor Head and grind it to remove it.
4.  Click the **Add Small Head** button. Now continue building a small grid upon that.

In [Creative Mode](https://spaceengineers.wiki.gg/wiki/Creative_Mode "Creative Mode") or with Creative Tools enabled, you can also use [CTRL key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings")+[X key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings") and [CTRL key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings")+[V key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings") to cut and paste (existing small grids with) Rotor Heads to achieve the same goal.

## Hitch up two existing grids

Usually when you place a Rotor block, the large-grid Rotor Head and its Stator are placed together. But you can also build the two halves separately and use them as a hitch.

1.  Build a large-grid Rotor.
2.  Open the Rotor's [Control Panel Screen](https://spaceengineers.wiki.gg/wiki/Control_Panel_Screen "Control Panel Screen").
3.  Click **Detach** to drop the large Rotor Head. Grind it down to get it out of the way.
4.  Like any building block, you can add a small Rotor Head to your [toolbar](https://spaceengineers.wiki.gg/wiki/Toolbar "Toolbar") and build it on another mobile grid.
5.  Move the two grids close together so the two halves of the rotors overlap.
6.  Press the **Attach** button to make the game acknowledge the connection.

Careful: When handling large masses, damage may ensue when two rotors attach if blocks are too close and [clang](https://spaceengineers.wiki.gg/wiki/Clang "Clang") out.

The same also works with Hinges and Hinge Parts.

## How to attach automatically

If its too fiddly to align the large and small grid and click the Attach button in the right moment, automate this action. Build a [Timer Block](https://spaceengineers.wiki.gg/wiki/Timer_Block "Timer Block") that, first, triggers the attach action and, second, restarts itself. The effect will be as if you are clicking the attach button repeatedly. Then concentrate on aligning the grids and let the timer do the clicking. Afterwards switch off the Timer again.