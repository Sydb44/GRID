Blocks can have _conveyor ports_ and _inventory ports_. Conveyor ports mark mount points on blocks where you can attach conveyor tubes to integrate inventories into the conveyor system.

All inventory ports are also conveyor ports, but conveyor ports are not inventory ports. This means Engineers can't directly interact with conveyor ports to access the inventory.

Both [ports](https://spaceengineers.wiki.gg/wiki/Port "Port") look like yellow squares. Conveyor ports look flat, whereas inventory ports have two parallel bars in the middle that look like physical bar handles to pull an imagined cargo hatch open.

## How can I transfer items manually?

[![A large Conveyor Block with ports in six directions](https://spaceengineers.wiki.gg/images/thumb/5/50/Conveyor_Block_.png/320px-Conveyor_Block_.png?870f6d)](https://spaceengineers.wiki.gg/wiki/File:Conveyor_Block_.png "File:Conveyor Block .png")

A Conveyor Junction with visible conveyor ports

Access connected inventories from any [inventory screen](https://spaceengineers.wiki.gg/wiki/Inventory "Inventory") on the grid. Once two conveyor [ports](https://spaceengineers.wiki.gg/wiki/Port "Port") touch directly or have been connected by conveyor tubes, you can drag items directly from one inventory to another without having to physically carry the items.

## How can blocks transfer items automatically?

When connected in a conveyor network, some blocks will automatically pull items from other inventories, or send their own items for storage elsewhere. When their inventories are full, production blocks push items from their output into any connected inventories that have capacities. If everything is full, factories are temporarily clogged and stop producing. Blocks with inventories either accept or decline items, depending on their type, e.g. some only accept ores, or only components.

Chain the following blocks (if you are using them) through conveyors, so that one block pushes what the next one pulls, for example, "drill -> refinery -> assembler -> welder".

| Block | Pulls What? | Pushes What? | Accepts Only? |
| --- | --- | --- | --- |
| [![Icon Block Drill.png](https://spaceengineers.wiki.gg/images/thumb/3/32/Icon_Block_Drill.png/21px-Icon_Block_Drill.png?a1b524)](https://spaceengineers.wiki.gg/wiki/Drill "Drill") [Ship Drills](https://spaceengineers.wiki.gg/wiki/Drill "Drill") | \-  | [Ores](https://spaceengineers.wiki.gg/wiki/Ores "Ores") | Ores |
| [![Icon Block Refinery.png](https://spaceengineers.wiki.gg/images/thumb/6/6a/Icon_Block_Refinery.png/21px-Icon_Block_Refinery.png?a9b68a)](https://spaceengineers.wiki.gg/wiki/Refinery "Refinery") [Refinery](https://spaceengineers.wiki.gg/wiki/Refinery "Refinery") | [Ores](https://spaceengineers.wiki.gg/wiki/Ores "Ores") | [Materials](https://spaceengineers.wiki.gg/wiki/Material "Material") | Ores, Materials |
| [![Icon Block Assembler.png](https://spaceengineers.wiki.gg/images/thumb/c/cd/Icon_Block_Assembler.png/21px-Icon_Block_Assembler.png?ceefab)](https://spaceengineers.wiki.gg/wiki/Assembler "Assembler") [Assembler](https://spaceengineers.wiki.gg/wiki/Assembler "Assembler") | [Materials](https://spaceengineers.wiki.gg/wiki/Material "Material") | [Components](https://spaceengineers.wiki.gg/wiki/Component "Component") | Any |
| [![Icon Block Grinder Block.png](https://spaceengineers.wiki.gg/images/thumb/7/73/Icon_Block_Grinder_Block.png/21px-Icon_Block_Grinder_Block.png?88a55d)](https://spaceengineers.wiki.gg/wiki/Grinder "Grinder") [Ship Grinders](https://spaceengineers.wiki.gg/wiki/Grinder "Grinder") | \-  | [Components](https://spaceengineers.wiki.gg/wiki/Component "Component") | Any |
| [![Icon Block Welder Block.png](https://spaceengineers.wiki.gg/images/thumb/4/41/Icon_Block_Welder_Block.png/21px-Icon_Block_Welder_Block.png?2e0da4)](https://spaceengineers.wiki.gg/wiki/Welder "Welder") [Ship Welder](https://spaceengineers.wiki.gg/wiki/Welder "Welder") | [Components](https://spaceengineers.wiki.gg/wiki/Component "Component") | \-  | Any |
| [![Icon Block Large Reactor.png](https://spaceengineers.wiki.gg/images/thumb/1/1c/Icon_Block_Large_Reactor.png/21px-Icon_Block_Large_Reactor.png?f77bf9)](https://spaceengineers.wiki.gg/wiki/Large_Reactor "Large Reactor") [Large](https://spaceengineers.wiki.gg/wiki/Large_Reactor "Large Reactor") and  [![Icon Block Small Reactor.png](https://spaceengineers.wiki.gg/images/thumb/2/23/Icon_Block_Small_Reactor.png/21px-Icon_Block_Small_Reactor.png?64124d)](https://spaceengineers.wiki.gg/wiki/Small_Reactor "Small Reactor") [Small Reactors](https://spaceengineers.wiki.gg/wiki/Small_Reactor "Small Reactor") | [![Icon Item Uranium Ingot.png](https://spaceengineers.wiki.gg/images/thumb/d/dd/Icon_Item_Uranium_Ingot.png/21px-Icon_Item_Uranium_Ingot.png?750d14)](https://spaceengineers.wiki.gg/wiki/Uranium_Ingot "Uranium Ingot") [Uranium Ingot](https://spaceengineers.wiki.gg/wiki/Uranium_Ingot "Uranium Ingot") | \-  | Uranium ingots |
| [![Icon Block O2 H2 Generator.png](https://spaceengineers.wiki.gg/images/thumb/7/7e/Icon_Block_O2_H2_Generator.png/21px-Icon_Block_O2_H2_Generator.png?60936f)](https://spaceengineers.wiki.gg/wiki/O2_H2_Generator "O2 H2 Generator") [O2/H2 Generator](https://spaceengineers.wiki.gg/wiki/O2_H2_Generator "O2 H2 Generator") | [![Icon Item Ice.png](https://spaceengineers.wiki.gg/images/thumb/9/9a/Icon_Item_Ice.png/21px-Icon_Item_Ice.png?f8a728)](https://spaceengineers.wiki.gg/wiki/Ice "Ice") [Ice](https://spaceengineers.wiki.gg/wiki/Ice "Ice"), bottles | \-  | Ice, bottles |
| [Block Weapons](https://spaceengineers.wiki.gg/wiki/Block_Weapons "Block Weapons") | [Ammunition](https://spaceengineers.wiki.gg/wiki/Ammunition "Ammunition") | \-  | Ammunition |
| [Parachute Hatch](https://spaceengineers.wiki.gg/wiki/Parachute_Hatch "Parachute Hatch") | [![Icon Item Canvas.png](https://spaceengineers.wiki.gg/images/thumb/8/84/Icon_Item_Canvas.png/21px-Icon_Item_Canvas.png?88f865)](https://spaceengineers.wiki.gg/wiki/Canvas "Canvas") [Canvas](https://spaceengineers.wiki.gg/wiki/Canvas "Canvas") | \-  | Canvas |
