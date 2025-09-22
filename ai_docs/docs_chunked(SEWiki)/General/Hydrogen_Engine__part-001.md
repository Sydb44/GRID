---
title: "Hydrogen Engine"
url: "https://spaceengineers.wiki.gg/wiki/Hydrogen_Engine"
category: "General"
wiki_page: "Hydrogen Engine"
includes_blocks: true
---

# Hydrogen Engine - Official Space Engineers Wiki

| Hydrogen Engine |     |
| --- | --- |
| [![Icon Block Hydrogen Engine.png](https://spaceengineers.wiki.gg/images/3/34/Icon_Block_Hydrogen_Engine.png?7bc9a7)](https://spaceengineers.wiki.gg/wiki/File:Icon_Block_Hydrogen_Engine.png) |     |
| * * * |     |
| **Function:** | The hydrogen engine converts hydrogen into power and has its own in... |
| **DLC?** | Vanilla |
| * * * |     |
| **Fits small grid** |     |
| Mass: | 1005.2 kg |
| Hitpoints: | 4141 |
| Power: | +0.5 MW |
| PCU: | 25  |
| Size: | 3x2x2 |
| Time to Build: | 40 sec |
| * * * |     |
| **Fits large grid** |     |
| Mass: | 3253.8 kg |
| Hitpoints: | 13654 |
| Power: | +5 MW |
| PCU: | 25  |
| Size: | 1x1x2 |
| Time to Build: | 60 sec |
| * * * |     |
| _Data Controls:_ | \[[purge](https://spaceengineers.wiki.gg/wiki/Hydrogen_Engine?action=purge)\] ([?](https://spaceengineers.wiki.gg/wiki/Template:Info_Block))) |
|     |     |

The Hydrogen Engine is a functional [power](https://spaceengineers.wiki.gg/wiki/Power "Power") source that uses hydrogen fuel. It is commonly employed on ships, vehicles, factories, and stations.

## Usage

Use the Hydrogen Engine to power [grids](https://spaceengineers.wiki.gg/wiki/Grid "Grid") at the cost of consuming [hydrogen](https://spaceengineers.wiki.gg/wiki/Hydrogen "Hydrogen") gas. The Hydrogen Engine is a fast and reliable power source that is independent of sunlight or wind. It works on any spacecraft, aircraft, land vehicle, drone, or base, even underground.

### What are the requirements?

You must connect the Hydrogen Engine to a powered conveyor system for it to be able to pull [hydrogen](https://spaceengineers.wiki.gg/wiki/Hydrogen "Hydrogen") fuel. It cannot be the sole source of power since it needs a tiny charge to jump start itself.

The second requirement is the presence of hydrogen. Use one of the following options:

### Are there pros and cons?

In contrast to renewable [power](https://spaceengineers.wiki.gg/wiki/Power "Power") production, the engine is independent of sunlight or wind. Its advantage is that  [![Icon Item Ice.png](https://spaceengineers.wiki.gg/images/thumb/9/9a/Icon_Item_Ice.png/21px-Icon_Item_Ice.png?f8a728)](https://spaceengineers.wiki.gg/wiki/Ice "Ice") [Ice](https://spaceengineers.wiki.gg/wiki/Ice "Ice") (and therefor hydrogen) is readily available on many planets and asteroids. It's an affordable power source and no rare end-game materials (such as Platinum or Uranium) are needed to use hydrogen power.

A disadvantage is that hydrogen tanks and their conveyor lines increase the ship's volume and mass dramatically. The use of hydrogen also introduces many weak points: Conveyor tubes can break and damaged hydrogen tanks are explosive.

If you have already added hydrogen tanks or generators, or both, to the ship because its main means of propulsion is hydrogen thrust, then adding hydrogen engines comes natural and brings no further disadvantage.

### How to troubleshoot a broken engine?

If the Hydrogen Engine does not produce any power:

1.  Make sure it is conveyored to filled hydrogen tanks or active [O2/H2 Generators](https://spaceengineers.wiki.gg/wiki/O2_H2_Generator "O2 H2 Generator") filled with ice.
2.  Make sure any hydrogen tanks are _not_ set to **stockpile**.
3.  Make sure that the [conveyor](https://spaceengineers.wiki.gg/wiki/Conveyor_system "Conveyor system") line between the engine and the hydrogen fuel is intact.
4.  If the engine does not show any hydrogen in it, despite being connected to tanks or generators, make sure that the Hydrogen Engine is not the sole source of power on the grid. Conveyors require power to function (though only trivial amounts of it), so if the grid has no power, the engine cannot receive the hydrogen from the tanks. Add a Small Battery, Solar Panel, or other source of power, or connect the grid to another powered grid to jumpstart the conveyor system to pull hydrogen into the engine.
5.  Lastly, try switching it off and on again.

## Inventory

The large-grid Hydrogen Engine can hold 100,000 liters of fuel (200 seconds of usage). The small-grid engine can hold 5,000 liters (100 seconds of usage). It cannot hold any items such as ice or bottles.

## Power

The Hydrogen Engine works similarly to a  [![Icon Block Small Reactor.png](https://spaceengineers.wiki.gg/images/thumb/2/23/Icon_Block_Small_Reactor.png/21px-Icon_Block_Small_Reactor.png?64124d)](https://spaceengineers.wiki.gg/wiki/Small_Reactor "Small Reactor") [Reactor](https://spaceengineers.wiki.gg/wiki/Small_Reactor "Small Reactor") in the sense that, if the grid requires less power than it can produce, the engine will reduce both its power output and fuel consumption to match that need. However, solar and wind power do _not_ have priority over hydrogen generators, so if built on a grid with other sources of power, the Hydrogen Engine will burn fuel and produce power even if such infinite sources of power could sufficiently supply the grid. In such situations, it may be beneficial to use a script or  [![Icon Block Event Controller.png](https://spaceengineers.wiki.gg/images/thumb/1/17/Icon_Block_Event_Controller.png/21px-Icon_Block_Event_Controller.png?8d8e4e)](https://spaceengineers.wiki.gg/wiki/Event_Controller "Event Controller") [Event Controller](https://spaceengineers.wiki.gg/wiki/Event_Controller "Event Controller") to only enable the Hydrogen Engines when the grid batteries are under a certain percentage threshold.

| Grid | Power Output | Fuel Consumption |
| --- | --- | --- |
| Small | 500 kW | 50 L/s[\[1\]](#cite_note-1.197.064-1) |
| Large | 5 MW | 500 L/s[\[1\]](#cite_note-1.197.064-1) |

  
The Hydrogen Engine produces:

*   **1 kWh** per 360 liters of hydrogen
*   **1 MWh**[\[2\]](#cite_note-Fuel_Consumption-2) per 360,000 liters of hydrogen
