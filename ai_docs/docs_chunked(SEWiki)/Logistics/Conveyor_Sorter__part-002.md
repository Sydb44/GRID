*   Select an entry from the "add a new filter" list and click **Add** to define a criterion.
*   Or select an entry from the **Active Filter** list and click **Remove** to remove this filter.

Possible filters are:

*   Ammo
*   Components
*   Hand tools
*   Ingots
*   Ores
*   Or select specific items from the list, e.g.  [![Icon Item Ice.png](https://spaceengineers.wiki.gg/images/thumb/9/9a/Icon_Item_Ice.png/21px-Icon_Item_Ice.png?f8a728)](https://spaceengineers.wiki.gg/wiki/Ice "Ice") [Ice](https://spaceengineers.wiki.gg/wiki/Ice "Ice").

**Tip:** Ice is considered neither an ingot nor an ore, so remember to filter ice separately. Gases cannot be filtered, only [Hydrogen Bottles](https://spaceengineers.wiki.gg/wiki/Hydrogen_Bottle "Hydrogen Bottle") and [Oxygen Bottles](https://spaceengineers.wiki.gg/wiki/Oxygen_Bottle "Oxygen Bottle") as items.

### How to actively drain all

Think of conveyor sorters as either passive filters or active pumps.

Active:

*   **Drain All** continually moves whitelisted objects in the arrow direction.
*   **Drain All** continually moved _everything except_ the blacklisted objects in the arrow direction.

Passive:

If **Drain All** is switched off, items only move through the sorter

*   if allowed by the whitelist/blacklist _and_
*   if actively pulled by another block, such as parachute hatch, weapons, or production machines.

Exception: Conveyor Sorters will not attempt to drain ingots from [assemblers](https://spaceengineers.wiki.gg/wiki/Assembler "Assembler")' inventories.

### How to control both directions of flow

Remember that Space Engineers is modular, and in many cases, you achieve the desired filtering effect by branching the conveyor into multiple Sorters with different blacklists/whitelists in parallel.

For example, you have one conveyor line that uses a sorter to pull whitelisted cargo. This setup however prevents your parachute hatch from pulling canvas (and turrets from pulling ammo, etc.)! You don't want to _actively_ fill the cargo container with canvas (or ammo), you just want to _passively_ allow the hatches to pull as much canvas as they need through the same conveyor.

Use [Junctions and T-Junctions](https://spaceengineers.wiki.gg/wiki/Conveyor_Junction "Conveyor Junction") to build parallel conveyor branches:

*   branches pulling input items
*   branches pushing output items
*   branches passively filtering output items
*   branches passively filtering input items

Similarly, when you want to use both whitelists and blacklists on the same conveyor line (as in "push all ingots, except uranium ingots"), you'll also need two sorters.

…tube - junction -> sorter -> junction - tube…
           |                     |
            tube <- sorter <- tube

### How to filter gases?

Sorters can't influence gases, use **Stockpile** instead. Conveyor sorters allow the transfer of hydrogen and oxygen gas in any direction,

*   if a tank on the other side of the sorter pulls gas because it's set to Stockpile, or
*   if an O2/H2 Generator pushes gas into the system.

There are some irregular bugs that sometimes prevent Sorters from conveying gasses, though. For example, Survival Kits or Medical Rooms suddenly cannot pull gas through a Sorter to recharge your suit.

Oxygen and Hydrogen bottles _as items_ are treated separately from gases: You can set up blacklists and whitelists for gas bottles like for any items in Sorters.

## Power

The large grid variant of the Sorter requires 250W, and the small grid variant requires 100W. This power is drained all time while the block is enabled, whether it's currently sorting items or not.

## Inventory

The large grid variant of the Sorter has an internal inventory size of 1,000L while the small grid variant has an internal inventory size of 343L.

## Construction

The sorter is available for large and small grid.

*   The large grid variant of the **Conveyor Sorter** is 1x1x1 large blocks in size and has large ports on two opposite sides.
*   The small-grid variant of the **Conveyor Sorter** is 1x3x3 small blocks in size and also has large ports on the two opposite 3x3 sides.
*   The small-grid  [![Icon Block Small Conveyor Sorter.png](https://spaceengineers.wiki.gg/images/thumb/f/f7/Icon_Block_Small_Conveyor_Sorter.png/21px-Icon_Block_Small_Conveyor_Sorter.png?905995)](https://spaceengineers.wiki.gg/wiki/Small_Conveyor_Sorter "Small Conveyor Sorter") [Small Conveyor Sorter](https://spaceengineers.wiki.gg/wiki/Small_Conveyor_Sorter "Small Conveyor Sorter") is 1x1x1 small-grid blocks in size and has two small ports on opposite sides. It is limited to transfer only small items, like ores.

## Recipe

| [![Icon Block Conveyor Sorter.png](https://spaceengineers.wiki.gg/images/thumb/d/db/Icon_Block_Conveyor_Sorter.png/21px-Icon_Block_Conveyor_Sorter.png?b0bfc9)](https://spaceengineers.wiki.gg/wiki/Conveyor_Sorter "Conveyor Sorter") Conveyor Sorter |     |     |     |     |
| --- | --- | --- | --- | --- |
| Component | Large Ship/Station  <br>Required | Large Ship/Station  <br>Optional | Small Ship  <br>Required | Small Ship  <br>Optional |
| [![Icon Item Small Steel Tube.png](https://spaceengineers.wiki.gg/images/thumb/f/f7/Icon_Item_Small_Steel_Tube.png/21px-Icon_Item_Small_Steel_Tube.png?4fe418)](https://spaceengineers.wiki.gg/wiki/Small_Steel_Tube "Small Steel Tube") [Small Steel Tube](https://spaceengineers.wiki.gg/wiki/Small_Steel_Tube "Small Steel Tube") | 50  | —   | 5   | —   |
| [![Icon Item Motor.png](https://spaceengineers.wiki.gg/images/thumb/2/2c/Icon_Item_Motor.png/21px-Icon_Item_Motor.png?4a2f3f)](https://spaceengineers.wiki.gg/wiki/Motor "Motor") [Motor](https://spaceengineers.wiki.gg/wiki/Motor "Motor") | 2   | —   | 2   | —   |
| [![Icon Item Interior Plate.png](https://spaceengineers.wiki.gg/images/thumb/7/77/Icon_Item_Interior_Plate.png/21px-Icon_Item_Interior_Plate.png?d80f8e)](https://spaceengineers.wiki.gg/wiki/Interior_Plate "Interior Plate") [Interior Plate](https://spaceengineers.wiki.gg/wiki/Interior_Plate "Interior Plate") | 40  | 10  | 4   | 1   |
| [![Icon Item Construction Comp..png](https://spaceengineers.wiki.gg/images/thumb/4/45/Icon_Item_Construction_Comp..png/21px-Icon_Item_Construction_Comp..png?cdc26f)](https://spaceengineers.wiki.gg/wiki/Construction_Comp. "Construction Comp.") [Construction Comp.](https://spaceengineers.wiki.gg/wiki/Construction_Comp. "Construction Comp.") | 100 | 20  | 10  | 2   |
| [![Icon Item Computer.png](https://spaceengineers.wiki.gg/images/thumb/7/72/Icon_Item_Computer.png/21px-Icon_Item_Computer.png?65c1a4)](https://spaceengineers.wiki.gg/wiki/Computer "Computer") [Computer](https://spaceengineers.wiki.gg/wiki/Computer "Computer") | 20  | —   | 5   | —   |