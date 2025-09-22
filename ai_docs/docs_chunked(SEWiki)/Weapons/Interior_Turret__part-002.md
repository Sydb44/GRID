
Interior Turrets have an inventory with a volume of 384L (with Realistic [settings](https://spaceengineers.wiki.gg/wiki/World_Settings "World Settings")).  
It will only accept [MR-50A Magazines](https://spaceengineers.wiki.gg/wiki/MR-50A_Magazine "MR-50A Magazine"), or legacy [5.56x45mm NATO magazines](https://spaceengineers.wiki.gg/wiki/5.56x45mm_NATO_magazine "5.56x45mm NATO magazine"), of which it can hold up to 768 or 1919 respectively.

## Power

The Interior Turret consumes 2 kW of power all the time while turned on. Firing or different ranges do not affect power usage.

## Construction

If [progression](https://spaceengineers.wiki.gg/wiki/Progression "Progression") is enabled, build a Basic Assembler first to unlock this block. It is much more affordable, lightweight, and compact than other turrets and easy to conceal.

This large-grid weapon has only one mount point at the bottom. It has **no conveyor ports**, so remember to keep its inventory [port](https://spaceengineers.wiki.gg/wiki/Port "Port") accessible and reload it manually.

## Recipe

| [![Icon Block Interior Turret.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Block_Interior_Turret.png/21px-Icon_Block_Interior_Turret.png?a22e06)](https://spaceengineers.wiki.gg/wiki/Interior_Turret "Interior Turret") Interior Turret |     |     |     |     |
| --- | --- | --- | --- | --- |
| Component | Large Ship/Station  <br>Required | Large Ship/Station  <br>Optional | Small Ship  <br>Required | Small Ship  <br>Optional |
| [![Icon Item Steel Plate.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Item_Steel_Plate.png/21px-Icon_Item_Steel_Plate.png?437e3a)](https://spaceengineers.wiki.gg/wiki/Steel_Plate "Steel Plate") [Steel Plate](https://spaceengineers.wiki.gg/wiki/Steel_Plate "Steel Plate") | 4   | —   | —   | —   |
| [![Icon Item Small Steel Tube.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Item_Small_Steel_Tube.png/21px-Icon_Item_Small_Steel_Tube.png?4fe418)](https://spaceengineers.wiki.gg/wiki/Small_Steel_Tube "Small Steel Tube") [Small Steel Tube](https://spaceengineers.wiki.gg/wiki/Small_Steel_Tube "Small Steel Tube") | 1   | —   | —   | —   |
| [![Icon Item Motor.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Item_Motor.png/21px-Icon_Item_Motor.png?4a2f3f)](https://spaceengineers.wiki.gg/wiki/Motor "Motor") [Motor](https://spaceengineers.wiki.gg/wiki/Motor "Motor") | 2   | —   | —   | —   |
| [![Icon Item Interior Plate.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Item_Interior_Plate.png/21px-Icon_Item_Interior_Plate.png?d80f8e)](https://spaceengineers.wiki.gg/wiki/Interior_Plate "Interior Plate") [Interior Plate](https://spaceengineers.wiki.gg/wiki/Interior_Plate "Interior Plate") | 6   | —   | —   | —   |
| [![Icon Item Construction Comp..png](https://spaceengineers.wiki.gg/images/thumb/Icon_Item_Construction_Comp..png/21px-Icon_Item_Construction_Comp..png?cdc26f)](https://spaceengineers.wiki.gg/wiki/Construction_Comp. "Construction Comp.") [Construction Comp.](https://spaceengineers.wiki.gg/wiki/Construction_Comp. "Construction Comp.") | 15  | 5   | —   | —   |
| [![Icon Item Computer.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Item_Computer.png/21px-Icon_Item_Computer.png?65c1a4)](https://spaceengineers.wiki.gg/wiki/Computer "Computer") [Computer](https://spaceengineers.wiki.gg/wiki/Computer "Computer") | 5   | —   | —   | —   |

1.  [↑](#cite_ref-1 "Jump up") in `MyProjectile.Start()` it does `m_maxTrajectory *= MyUtils.GetRandomFloat(0.8f, 1f);`