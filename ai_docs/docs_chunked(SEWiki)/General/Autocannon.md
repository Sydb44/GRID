---
title: "Autocannon"
url: "https://spaceengineers.wiki.gg/wiki/Autocannon"
category: "General"
wiki_page: "Autocannon"
includes_blocks: true
---

# Autocannon - Official Space Engineers Wiki

## Navigation menu

### Search

\- A wiki theme migration is in progress. If you notice any oddities, please reload the page a bit later, or ping us on the Keen Discord.

(#searchInput)

| Autocannon |     |
| --- | --- |
| [![Icon Block Autocannon.png](https://spaceengineers.wiki.gg/images/5/53/Icon_Block_Autocannon.png?3a6d29)](https://spaceengineers.wiki.gg/wiki/File:Icon_Block_Autocannon.png) |     |
| * * * |     |
| **Function:** | Medium rate of fire, with a good punch. Uses Autocannon Magazines.M... |
| **DLC?** | Vanilla |
| * * * |     |
| **Fits small grid** |     |
| Mass: | 180.2 kg |
| Hitpoints: | 791 |
| PCU: | 80  |
| Size: | 1x1x5 |
| Time to Build: | 14 sec |
| * * * |     |
| _Data Controls:_ | \[[purge](https://spaceengineers.wiki.gg/wiki/Autocannon?action=purge)\] ([?](https://spaceengineers.wiki.gg/wiki/Template:Info_Block))) |
|     |     |

The Autocannon is a powerful static small-grid [block weapon](https://spaceengineers.wiki.gg/wiki/Block_Weapons "Block Weapons") that is cheap to build en masse.

## Usage

> _Extremely effective against small grids such as fighters and rovers. The telltale sound of an Autocannon firing gives even the most staunch soldier a reason to pause._

It is also a good choice when you arm up a small grid to attack a large grid.

## Damage

*   500 [impact damage](https://spaceengineers.wiki.gg/wiki/Damage_Mechanics "Damage Mechanics") to blocks; 85 damage to characters or 120 damage if hitting the character's head.
*   Precision: 0.52m group at 100m (up to 0.15 degrees random offset from aiming line).
*   Fires as long as it has ammo without any reload time.
*   150 RPM fire rate.
*   Projectile travels at 400m/s, vanishes after travelling anywhere between 640m and 800m (randomly chosen per shot[\[1\]](#cite_note-1)) and it is affected by [natural gravity](https://spaceengineers.wiki.gg/wiki/Gravity "Gravity").
*   60 kN of recoil force (shooter).

## Inventory

The cannon’s inventory can only hold 72L, which corresponds to three [Autocannon Magazines](https://spaceengineers.wiki.gg/wiki/Autocannon_Magazine "Autocannon Magazine"). That is 48 shots, 64 with a magazine already loaded into the gun.

## Power

The Autocannon consumes 200 W of power all the time while turned on. Firing does not affect power usage.

## Construction

The Autocannon's size is 1x1x5, which makes it a light-weight and almost compact choice for any small-grid fighter. It has two small conveyor ports to reload ammunition from the conveyor system.

This weapon is _very_ cheap compared to other, heavier weapons! Mounting autocannons on [Custom Turret Controllers](https://spaceengineers.wiki.gg/wiki/Custom_Turret_Controller "Custom Turret Controller") is a very good idea, both as a point-defence and as an assault weapon.

## Recipe

| [![Icon Block Autocannon.png](https://spaceengineers.wiki.gg/images/thumb/5/53/Icon_Block_Autocannon.png/21px-Icon_Block_Autocannon.png?3a6d29)](https://spaceengineers.wiki.gg/wiki/Autocannon "Autocannon") Autocannon |     |     |     |     |
| --- | --- | --- | --- | --- |
| Component | Large Ship/Station  <br>Required | Large Ship/Station  <br>Optional | Small Ship  <br>Required | Small Ship  <br>Optional |
| [![Icon Item Steel Plate.png](https://spaceengineers.wiki.gg/images/thumb/4/4c/Icon_Item_Steel_Plate.png/21px-Icon_Item_Steel_Plate.png?437e3a)](https://spaceengineers.wiki.gg/wiki/Steel_Plate "Steel Plate") [Steel Plate](https://spaceengineers.wiki.gg/wiki/Steel_Plate "Steel Plate") | —   | —   | 2   | 4   |
| [![Icon Item Small Steel Tube.png](https://spaceengineers.wiki.gg/images/thumb/f/f7/Icon_Item_Small_Steel_Tube.png/21px-Icon_Item_Small_Steel_Tube.png?4fe418)](https://spaceengineers.wiki.gg/wiki/Small_Steel_Tube "Small Steel Tube") [Small Steel Tube](https://spaceengineers.wiki.gg/wiki/Small_Steel_Tube "Small Steel Tube") | —   | —   | 2   | —   |
| [![Icon Item Motor.png](https://spaceengineers.wiki.gg/images/thumb/2/2c/Icon_Item_Motor.png/21px-Icon_Item_Motor.png?4a2f3f)](https://spaceengineers.wiki.gg/wiki/Motor "Motor") [Motor](https://spaceengineers.wiki.gg/wiki/Motor "Motor") | —   | —   | 1   | —   |
| [![Icon Item Metal Grid.png](https://spaceengineers.wiki.gg/images/thumb/1/16/Icon_Item_Metal_Grid.png/21px-Icon_Item_Metal_Grid.png?c674cf)](https://spaceengineers.wiki.gg/wiki/Metal_Grid "Metal Grid") [Metal Grid](https://spaceengineers.wiki.gg/wiki/Metal_Grid "Metal Grid") | —   | —   | 2   | —   |
| [![Icon Item Construction Comp..png](https://spaceengineers.wiki.gg/images/thumb/4/45/Icon_Item_Construction_Comp..png/21px-Icon_Item_Construction_Comp..png?cdc26f)](https://spaceengineers.wiki.gg/wiki/Construction_Comp. "Construction Comp.") [Construction Comp.](https://spaceengineers.wiki.gg/wiki/Construction_Comp. "Construction Comp.") | —   | —   | 2   | —   |
| [![Icon Item Computer.png](https://spaceengineers.wiki.gg/images/thumb/7/72/Icon_Item_Computer.png/21px-Icon_Item_Computer.png?65c1a4)](https://spaceengineers.wiki.gg/wiki/Computer "Computer") [Computer](https://spaceengineers.wiki.gg/wiki/Computer "Computer") | —   | —   | 1   | —   |

1.  [↑](#cite_ref-1 "Jump up") in `MyProjectile.Start()` it does `m_maxTrajectory *= MyUtils.GetRandomFloat(0.8f, 1f);`