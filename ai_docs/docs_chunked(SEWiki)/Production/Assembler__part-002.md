
When you have several Assemblers, you need a way to access their control panel quickly: On the Assembler's [Production](https://spaceengineers.wiki.gg/wiki/Production "Production") tab, click **Control Panel** in the bottom right to go directly to its [Control Panel Screen](https://spaceengineers.wiki.gg/wiki/Control_Panel_Screen "Control Panel Screen").

### How to mass produce items

If you are doing mass production (or mass recycling), configure your assembler on the [Production](https://spaceengineers.wiki.gg/wiki/Production "Production") screen to run in **Repeat Mode**. This mode automatically repeats the current queue when ever it can pull the items needed.

Usage example: Automatic recycling

1.  Set aside one Assembler in the Conveyor system.
2.  Disable **Cooperative Mode** on it.
3.  Enable **Repeat Mode** on it.
4.  Queue up disassembling recipes for all items that you always want to get rid of when ever they enter the conveyor system.

### How to make the assembler faster and save power

Upgrade modules let you improve the capabilities of the Assembler.

*   Each [Speed Module](https://spaceengineers.wiki.gg/wiki/Speed_Module "Speed Module") that you attach to the assembler increases your production speed and power consumption as would building one extra Cooperative Assembler.
    *   Pros are that speed modules takes less space and cost fewer components than a whole Assembler.
    *   Cons are that for each Speed Module, you lose a possible slot for a Power Efficiency Module.
*   Each [Power Efficiency Module](https://spaceengineers.wiki.gg/wiki/Power_Efficiency_Module "Power Efficiency Module") reduces the power usage of the Assembler.

Find your balance between component cost, power consumption, and speed.

### How to queue up a thousand items

Use the [Build Planner](https://spaceengineers.wiki.gg/wiki/Build_Planner "Build Planner") to speed things up!

*   [CTRL key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings")+clicking an item adds 10 items to the queue.
*   [SHIFT key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings")+clicking an item adds 100 items to the queue.
*   [CTRL key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings")+[SHIFT key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings")+clicking an item adds 1000 items to the queue.

These shortcuts work on the icons in the [Production](https://spaceengineers.wiki.gg/wiki/Production "Production") tab, as well as in [Block Placement Mode](https://spaceengineers.wiki.gg/wiki/Block_Placement_Mode "Block Placement Mode") when clicking a connected inventory port with a block selected from the toolbar in hand.

Note: If you have several Assemblers in **Cooperative Mode**, queue up the components in the _primary_ Assembler!

Tip: If you have only one Assembler, verify that it is set to 'Assembly_, and not to_ Disassembly_, for the [Build Planner](https://spaceengineers.wiki.gg/wiki/Build_Planner "Build Planner") to work._

### Troubleshooting

**Q: Why does my Assembler not assemble anything?**  
A: Set at least one Assembler to _Assembly_. Make sure that it is not still set to _Disassembly_ on the [Production](https://spaceengineers.wiki.gg/wiki/Production "Production") screen. Each Assembler can only process one queue at a time, either assembly or disassembly.

**Q: I have the necessary materials in my conveyor system, why is the Assembler ignoring them?**  
A: Check its [Inventory](https://spaceengineers.wiki.gg/wiki/Inventory "Inventory") tab: Is the Assembler full of one material which prevents it from pulling the variety of materials that it needs? If your Refinery is overflowing common materials like  [![Icon Item Gravel.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Item_Gravel.png/21px-Icon_Item_Gravel.png?a39670)](https://spaceengineers.wiki.gg/wiki/Gravel "Gravel") [Gravel](https://spaceengineers.wiki.gg/wiki/Gravel "Gravel") into your Assemblers, try adding a cargo container in between. Use [sorters](https://spaceengineers.wiki.gg/wiki/Conveyor_Sorter "Conveyor Sorter") and [ejectors](https://spaceengineers.wiki.gg/wiki/Connector "Connector") to handle the gravel.

## Inventory

With Realistic settings, the Assembler has two inventories, both with a capacity of 1,000L.

*   The input inventory accepts only [material](https://spaceengineers.wiki.gg/wiki/Material "Material") type items.
*   The output inventory accepts only [component](https://spaceengineers.wiki.gg/wiki/Component "Component") type items, typically ones that have been assembled or the player places there for disassembly.

If attached to a [conveyor system](https://spaceengineers.wiki.gg/wiki/Conveyor_system "Conveyor system"), the input inventory can receive pushed items from other inventories, such as Refineries. The input inventory pulls materials from conveyored containers if it has an active job and is low on materials. An Assembler cannot push materials to other Assemblers, meaning it can clog up.

The output inventory sends items to other blocks when they are pulled. If the output inventory is full, it will push items to connected cargo containers.[\[1\]](http://forums.keenswh.com/post/show_single_post?pid=1282594029&postcount=1)

## Power Usage

This block needs power to work. The Assembler will consume a maximum of 560 kW when running at full speed. It will function on less power, but will work at a proportionately slower rate.

## Construction

If [Progression](https://spaceengineers.wiki.gg/wiki/Progression "Progression") is on, unlock the Assembler by building a [Basic Assembler](https://spaceengineers.wiki.gg/wiki/Basic_Assembler "Basic Assembler") first.

The entry point for building the first Assembler is obtaining [Metal Grids](https://spaceengineers.wiki.gg/wiki/Metal_Grid "Metal Grid"). Either you assemble Metal Grids from [Cobalt Ingots](https://spaceengineers.wiki.gg/wiki/Cobalt_Ingot "Cobalt Ingot") in the [Basic Assembler](https://spaceengineers.wiki.gg/wiki/Basic_Assembler "Basic Assembler"), or alternatively, you salvage them by grinding down e.g. heavy armor.

The Assembler is available only for large grid, where it takes up 1x1x2 blocks of space. The block has four [conveyor ports](https://spaceengineers.wiki.gg/wiki/Conveyor_system "Conveyor system"), one on either end, and two more on an opposing pair of the tall sides.

The four tall sides are additionally covered with eight module mount points (two on each side) where you can optionally place [Upgrade Modules](https://spaceengineers.wiki.gg/wiki/Upgrade_Modules "Upgrade Modules"). This means that two of the conveyor [ports](https://spaceengineers.wiki.gg/wiki/Port "Port") double as module attachment points. If you intend to benefit from modules, plan ahead and consider the extra surrounding space needed, and don't cover up the dual-use conveyor ports.
