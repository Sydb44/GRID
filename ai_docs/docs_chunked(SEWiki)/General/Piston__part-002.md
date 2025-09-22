*   Set And Move - First enter the absolute distance to move in metres, must be a positive number within the length of the piston. Then enter the velocity in m/s. Then give this setting a named label, such as “Ext: 5” moves the piston to its 5m extension.

Even though you can add a piston head, you cannot re-attach a piston base to a piston head on another grid, as you can do with a [Rotor](https://spaceengineers.wiki.gg/wiki/Rotor "Rotor")/Rotor Head. It's somewhat possible (albeit fiddly) to reattach pistons using [Merge Blocks](https://spaceengineers.wiki.gg/wiki/Merge_Block "Merge Block").

### How to stabilise grids

Don’t connect two pistons to the same grids on both ends and then set the pistons to different speeds or different extensions, because that would cause an impossible situation and stress to which the simulation likely reacts with a [rapid unscheduled disassembly](https://en.wiktionary.org/wiki/rapid_unplanned_disassembly).

When connected one to another to form [subgrids](https://spaceengineers.wiki.gg/wiki/Grid "Grid"), pistons can bend or push subgrids into one another, and generate a lot of vibration and shake the grid apart (also known as [Clang](https://spaceengineers.wiki.gg/wiki/Clang "Clang")). In general, it's safest to use mechanical blocks on static grids.

On the [Control Panel Screen](https://spaceengineers.wiki.gg/wiki/Control_Panel_Screen "Control Panel Screen") ([Experimental mode](https://spaceengineers.wiki.gg/wiki/Experimental_mode "Experimental mode")), enable the **Share Inertia Tensor** setting of the subgrid pistons. Do not enable **Share Inertia Tensor** on the _first_ piston that’s attached to the main grid. This equalises the virtual masses to achieve more stable behaviour.

If you have to use mechanical blocks while flying/driving a mobile grid, it's recommended to set a  [![Icon Block Gyroscope.png](https://spaceengineers.wiki.gg/images/thumb/9/9c/Icon_Block_Gyroscope.png/21px-Icon_Block_Gyroscope.png?c8eb45)](https://spaceengineers.wiki.gg/wiki/Gyroscope "Gyroscope") [Gyroscope](https://spaceengineers.wiki.gg/wiki/Gyroscope "Gyroscope") on override with 0 RPM on all axes for stabilisation. Optimally, park, and lock the grid safely to the ground with  [![Icon Block Landing Gear.png](https://spaceengineers.wiki.gg/images/thumb/2/2d/Icon_Block_Landing_Gear.png/21px-Icon_Block_Landing_Gear.png?d381be)](https://spaceengineers.wiki.gg/wiki/Landing_Gear "Landing Gear") [Landing Gear](https://spaceengineers.wiki.gg/wiki/Landing_Gear "Landing Gear") while using mechanical blocks. This will help greatly to reduce shaking.

## Construction

Pistons exist for large and small grid. They are made up of two parts, the base and the head. After you place a piston base, the head is added automatically. You must weld up both parts for the piston to be functional.

They can attach to blocks on the base end and head end, but not on the cylindrical sides. The narrow sides of the piston head can also attach to blocks.

Pistons have inventory doors on their head and base, allowing items to be transferred through them using the [conveyor system](https://spaceengineers.wiki.gg/wiki/Conveyor_system "Conveyor system"). The small grid pistons interface with [Small Conveyors](https://spaceengineers.wiki.gg/wiki/Small_Conveyor "Small Conveyor") only, due to their hatch size, and are bound by the same item size restrictions as small conveyors are.

Tip: If you notice a disruption in your conveyor system, but all conveyor tubes indicate a green light, remember to also check the integrity of your pistons – especially check the piston heads for damage!

## Dimensions

### Offset Added By Each Piston

You might notice that even when a piston is fully retracted or extended, blocks placed on the piston head will be slightly offset from the original grid, in the direction the piston is facing. This can cause to a slight step when boarding and disembarking piston elevators, and could cause issues when using pistons along with other mechanical blocks for advanced geometric constructions. The exact offsets from the grid as as follows:[\[1\]](#cite_note-1)

|     |     |
| --- | --- |Piston Offset
| Block type | Offset (meters) |
| Large grid piston | 0.158463 |
| Small grid piston | 0.031542 |

### Total Lengths of Pistons

|     |     |     |     |
| --- | --- | --- | --- |Piston Size
| Size | Position | Length (blocks) | Length (meters) |
| Large Grid | Fully Retracted | 2.0633852 | 5.158463 |
| Fully Extended | 6.0633852 | 15.158463 |
| Small Grid | Fully Retracted | 2.063084 | 1.031542 |
| Fully Extended | 6.063084 | 3.031542 |

## Recipe

| [![Icon Block Piston.png](https://spaceengineers.wiki.gg/images/thumb/2/28/Icon_Block_Piston.png/21px-Icon_Block_Piston.png?8b1fda)](https://spaceengineers.wiki.gg/wiki/Piston "Piston") Piston |     |     |     |     |
| --- | --- | --- | --- | --- |
| Component | Large Ship/Station  <br>Required | Large Ship/Station  <br>Optional | Small Ship  <br>Required | Small Ship  <br>Optional |
| [![Icon Item Computer.png](https://spaceengineers.wiki.gg/images/thumb/7/72/Icon_Item_Computer.png/21px-Icon_Item_Computer.png?65c1a4)](https://spaceengineers.wiki.gg/wiki/Computer "Computer") [Computer](https://spaceengineers.wiki.gg/wiki/Computer "Computer") | 2   | —   | 1   | —   |
| [![Icon Item Motor.png](https://spaceengineers.wiki.gg/images/thumb/2/2c/Icon_Item_Motor.png/21px-Icon_Item_Motor.png?4a2f3f)](https://spaceengineers.wiki.gg/wiki/Motor "Motor") [Motor](https://spaceengineers.wiki.gg/wiki/Motor "Motor") | 4   | —   | 2   | —   |
| [![Icon Item Large Steel Tube.png](https://spaceengineers.wiki.gg/images/thumb/f/fe/Icon_Item_Large_Steel_Tube.png/21px-Icon_Item_Large_Steel_Tube.png?31c1e4)](https://spaceengineers.wiki.gg/wiki/Large_Steel_Tube "Large Steel Tube") [Large Steel Tube](https://spaceengineers.wiki.gg/wiki/Large_Steel_Tube "Large Steel Tube") | 4   | —   | 4   | —   |
| [![Icon Item Construction Comp..png](https://spaceengineers.wiki.gg/images/thumb/4/45/Icon_Item_Construction_Comp..png/21px-Icon_Item_Construction_Comp..png?cdc26f)](https://spaceengineers.wiki.gg/wiki/Construction_Comp. "Construction Comp.") [Construction Comp.](https://spaceengineers.wiki.gg/wiki/Construction_Comp. "Construction Comp.") | 10  | —   | 4   | —   |
| [![Icon Item Steel Plate.png](https://spaceengineers.wiki.gg/images/thumb/4/4c/Icon_Item_Steel_Plate.png/21px-Icon_Item_Steel_Plate.png?437e3a)](https://spaceengineers.wiki.gg/wiki/Steel_Plate "Steel Plate") [Steel Plate](https://spaceengineers.wiki.gg/wiki/Steel_Plate "Steel Plate") | 10  | 5   | 2   | 2   |
