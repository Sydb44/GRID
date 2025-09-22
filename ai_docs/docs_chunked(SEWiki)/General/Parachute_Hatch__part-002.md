Also make sure to avoid mountain tops and high plains: When parachutes auto-deploy in a thin atmosphere above the highest mountain, they may not be able to slow you down enough before you reach the ground.

### How to get rid of the parachute

Parachutes despawn when inertia and velocity are 0 m/sec. When the ship rests on the planet surface, the parachutes cut automatically.

Careful:

*   If you accidentally slow down, maybe because your inertial dampers engaged the thrusters, the parachute will auto-cut and likely be expended earlier than expected.
*   If you cannot come to a rest, maybe because your ship is slowly sliding down a cliff, the parachutes will remain open, and prevent you from actively steering or accelerating.
*   It’s safer to disable auto-deploy when there’s a chance of abrupt velocity changes ahead -- for example, before a ship is copied and pasted using Creative tools in a Survival game, or when sliding down the side of a mountain.

Manually closing deployed parachutes does not return the canvas, it is used up!

### "But I tested it in Creative Mode..."

Parachute Hatches work differently in [Survival Mode](https://spaceengineers.wiki.gg/wiki/Survival_Mode "Survival Mode") and [Creative Mode](https://spaceengineers.wiki.gg/wiki/Creative_Mode "Creative Mode"):

*   In creative mode, Parachute Hatches can deploy and cut (Open and Close button) an infinite number of times.
*   In survival mode, Parachute Hatches will only deploy if a set of  [![Icon Item Canvas.png](https://spaceengineers.wiki.gg/images/thumb/8/84/Icon_Item_Canvas.png/21px-Icon_Item_Canvas.png?88f865)](https://spaceengineers.wiki.gg/wiki/Canvas "Canvas") [Canvas](https://spaceengineers.wiki.gg/wiki/Canvas "Canvas") has been loaded in the Parachute Hatches' inventory; each time the hatch is deployed, one set of canvas items is consumed.

Even if your ship lands well during a test in Creative Mode, you still need to verify whether Canvas is conveyored properly in Survival Mode.

### How many parachutes are enough?

That depends on how heavy your ship is, how dense the atmosphere is, whether it's large or small grid, and exactly how much you want it to slow down. Deceleration with parachutes is quite fast, but not instant, so you also want to bear in mind how fast you're going when they deploy, and how much room you have between yourself and the ground.

You could just use a creative world for trial and error. Or you could apply _**maths**_. Here's a [desmos calculator](https://www.desmos.com/calculator/kushoykgus) to help you with that.

## Damage

The Parachute Hatch can be damaged and become non-functional. But after deployment, the parachute itself is impervious to damage, shots, or collisions.

## Inventory

The inventory holds 8 litres on small grid and 40L on large grid. The inventory can hold nothing but one size-dependent set of  [![Icon Item Canvas.png](https://spaceengineers.wiki.gg/images/thumb/8/84/Icon_Item_Canvas.png/21px-Icon_Item_Canvas.png?88f865)](https://spaceengineers.wiki.gg/wiki/Canvas "Canvas") [Canvas](https://spaceengineers.wiki.gg/wiki/Canvas "Canvas") items.

## Construction

[![](https://spaceengineers.wiki.gg/images/thumb/d/db/Opened_parachute.png/320px-Opened_parachute.png?fcf046)](https://spaceengineers.wiki.gg/wiki/File:Opened_parachute.png)

A cargo drop falling with an opened parachute

The Parachute Hatch exists for large and small grids and is 1x1x1 blocks in size. It has mount points on all sides and it has one conveyor port on its bottom face. The act of opening and closing parachutes requires power; having them open or closed does not require power.

For the parachutes' functionality, it makes no difference which way up the block is rotated. The parachute will open "upwards" even if other blocks appear to be in the way. Rotation is only relevant for how you want to access the conveyor port. The Parachute Hatch has only one conveyor [port](https://spaceengineers.wiki.gg/wiki/Port "Port"), which is the only place where canvas can be inserted.

[![](https://spaceengineers.wiki.gg/images/thumb/9/9f/Parachute_Hatch_small.jpg/320px-Parachute_Hatch_small.jpg?e34644)](https://spaceengineers.wiki.gg/wiki/File:Parachute_Hatch_small.jpg)

A parachute hatch block has one conveyor port

The hatches' position on the ship is, however, critical for a smooth landing. If not placed symmetrically around the [Center of Mass](https://spaceengineers.wiki.gg/wiki/Center_of_Mass "Center of Mass"), parachutes can tilt your ship and cause an uncontrolled (albeit slowed) landing. The parachutes' location on the ship body relative to its [Center of Mass](https://spaceengineers.wiki.gg/wiki/Center_of_Mass "Center of Mass") (CoM) affect how the vessel lands: If more parachutes are on one side of the CoM than the other, one end will be pulled up and the opposing end will droop down, which results in the ship not landing horizontally on its landing gear, but possibly hit the ground sideways or get stuck on blocks that could get damaged. To see your centre of gravity, enable the visualisation on the ship's [Info Screen](https://spaceengineers.wiki.gg/wiki/Info_Screen "Info Screen").

Additionally, you need to build a suitable number of Parachute Hatch blocks for the mass you want to slow down. One small grid Parachute Hatch can slow about 10,000 kg of grid mass. For large-grid Hatches it's about 100,000 kg. The general rule of thumb for safe landing speeds is < 8 meters per second for small ships and even less for massive large grid ships.

## Recipe

| [![Icon Block Parachute Hatch.png](https://spaceengineers.wiki.gg/images/thumb/5/59/Icon_Block_Parachute_Hatch.png/21px-Icon_Block_Parachute_Hatch.png?73c703)](https://spaceengineers.wiki.gg/wiki/Parachute_Hatch "Parachute Hatch") Parachute Hatch |     |     |     |     |
| --- | --- | --- | --- | --- |
| Component | Large Ship/Station  <br>Required | Large Ship/Station  <br>Optional | Small Ship  <br>Required | Small Ship  <br>Optional |
| [![Icon Item Steel Plate.png](https://spaceengineers.wiki.gg/images/thumb/4/4c/Icon_Item_Steel_Plate.png/21px-Icon_Item_Steel_Plate.png?437e3a)](https://spaceengineers.wiki.gg/wiki/Steel_Plate "Steel Plate") [Steel Plate](https://spaceengineers.wiki.gg/wiki/Steel_Plate "Steel Plate") | 5   | 4   | 1   | 1   |
| [![Icon Item Small Steel Tube.png](https://spaceengineers.wiki.gg/images/thumb/f/f7/Icon_Item_Small_Steel_Tube.png/21px-Icon_Item_Small_Steel_Tube.png?4fe418)](https://spaceengineers.wiki.gg/wiki/Small_Steel_Tube "Small Steel Tube") [Small Steel Tube](https://spaceengineers.wiki.gg/wiki/Small_Steel_Tube "Small Steel Tube") | 5   | —   | 1   | —   |
| [![Icon Item Motor.png](https://spaceengineers.wiki.gg/images/thumb/2/2c/Icon_Item_Motor.png/21px-Icon_Item_Motor.png?4a2f3f)](https://spaceengineers.wiki.gg/wiki/Motor "Motor") [Motor](https://spaceengineers.wiki.gg/wiki/Motor "Motor") | 3   | —   | 1   | —   |
| [![Icon Item Construction Comp..png](https://spaceengineers.wiki.gg/images/thumb/4/45/Icon_Item_Construction_Comp..png/21px-Icon_Item_Construction_Comp..png?cdc26f)](https://spaceengineers.wiki.gg/wiki/Construction_Comp. "Construction Comp.") [Construction Comp.](https://spaceengineers.wiki.gg/wiki/Construction_Comp. "Construction Comp.") | 25  | —   | 2   | —   |
| [![Icon Item Computer.png](https://spaceengineers.wiki.gg/images/thumb/7/72/Icon_Item_Computer.png/21px-Icon_Item_Computer.png?65c1a4)](https://spaceengineers.wiki.gg/wiki/Computer "Computer") [Computer](https://spaceengineers.wiki.gg/wiki/Computer "Computer") | 2   | —   | 1   | —   |