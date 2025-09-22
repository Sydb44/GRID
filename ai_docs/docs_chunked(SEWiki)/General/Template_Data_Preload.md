---
title: "Template:Data Preload"
url: "https://spaceengineers.wiki.gg/wiki/Template:Data_Preload"
category: "General"
wiki_page: "Template:Data Preload"
includes_blocks: true
---

# Template:Data Preload - Official Space Engineers Wiki

(#searchInput)

## See Also

For help with the item and block infobox or its controls, see the [Info Block documentation](https://spaceengineers.wiki.gg/wiki/Template:Info_Block "Template:Info Block").

## Description

This template is a preload for data pages. Use it to create all data pages, it includes all of the necessary variable declarations. Update existing data pages manually to reflect changes in the preload.

## Variables

Each variable is named "Data_<Variable>_" and is declared using `{{#vardefine:Data<Variable>|<value>}}`

Fill in the appropriate value, or leave the value blank. Do not delete unused variable declarations. This is to prevent overlap in cases where multiple data files are loaded in sequence. Blank variables ensure that the values for the previous item are erased instead of "bleeding through" to the new item.

All of the variables are listed as follows:

*   **Name**: The name of the item.
    *   This should match the item's page name as it is used to automatically general icon paths, etc.
    *   Do not use a magic word such as `{{BASEPAGENAME}}` as it will have unpredictable results depending on what page the data is loaded for.
*   **SortableName:**: The name of the item as it would appear in a sorted list.
    *   For example,  [![Icon Block Large Cargo Container.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Block_Large_Cargo_Container.png/21px-Icon_Block_Large_Cargo_Container.png?b155ac)](https://spaceengineers.wiki.gg/wiki/Large_Cargo_Container "Large Cargo Container") [Large Cargo Container](https://spaceengineers.wiki.gg/wiki/Large_Cargo_Container "Large Cargo Container") would be listed as "Cargo Container, Large".
*   **Icon**: Filepath for the icon to display.
    *   Only necessary for custom icons. The standard filepath should be generated automatically by most display templates.
    *   Do not include "File:" but do include the extension.
*   **Caption**: A caption to display under the icon, if necessary.
*   **Category**: Block category.
    *   Component - Items used to build blocks. Ex:  [![Icon Item Steel Plate.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Item_Steel_Plate.png/21px-Icon_Item_Steel_Plate.png?437e3a)](https://spaceengineers.wiki.gg/wiki/Steel_Plate "Steel Plate") [Steel Plate](https://spaceengineers.wiki.gg/wiki/Steel_Plate "Steel Plate").
    *   Decorative - Furniture and DLC blocks. Ex:  [![Icon Block Kitchen.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Block_Kitchen.png/21px-Icon_Block_Kitchen.png?3fcd8e)](https://spaceengineers.wiki.gg/wiki/Kitchen "Kitchen") [Kitchen](https://spaceengineers.wiki.gg/wiki/Kitchen "Kitchen").
    *   Defense - Weapons or defensive blocks. Ex:  [![Icon Block Gatling Gun.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Block_Gatling_Gun.png/21px-Icon_Block_Gatling_Gun.png?2a4fa4)](https://spaceengineers.wiki.gg/wiki/Gatling_Gun "Gatling Gun") [Gatling Gun](https://spaceengineers.wiki.gg/wiki/Gatling_Gun "Gatling Gun").
    *   Facility - Facilities and production blocks. Ex:  [![Icon Block Medical Room.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Block_Medical_Room.png/21px-Icon_Block_Medical_Room.png?a9d978)](https://spaceengineers.wiki.gg/wiki/Medical_Room "Medical Room") [Medical Room](https://spaceengineers.wiki.gg/wiki/Medical_Room "Medical Room").
    *   Functional - Blocks that keep the ship flying. Ex:  [![Icon Block Cockpit.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Block_Cockpit.png/21px-Icon_Block_Cockpit.png?c799da)](https://spaceengineers.wiki.gg/wiki/Cockpit "Cockpit") [Cockpit](https://spaceengineers.wiki.gg/wiki/Cockpit "Cockpit").
    *   Material - Items used to make Components and Tools. Ex:  [![Icon Item Iron Ingot.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Item_Iron_Ingot.png/21px-Icon_Item_Iron_Ingot.png?388ec0)](https://spaceengineers.wiki.gg/wiki/Iron_Ingot "Iron Ingot") [Iron Ingot](https://spaceengineers.wiki.gg/wiki/Iron_Ingot "Iron Ingot").
    *   Mobility - Blocks that apply thrust, propulsion, rotation. Ex:  [![Icon Block Gyroscope.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Block_Gyroscope.png/21px-Icon_Block_Gyroscope.png?c8eb45)](https://spaceengineers.wiki.gg/wiki/Gyroscope "Gyroscope") [Gyroscope](https://spaceengineers.wiki.gg/wiki/Gyroscope "Gyroscope").
    *   Ore - Items used to create Materials. Ex:  [![Icon Item Iron Ore.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Item_Iron_Ore.png/21px-Icon_Item_Iron_Ore.png?5a0907)](https://spaceengineers.wiki.gg/wiki/Iron_Ore "Iron Ore") [Iron Ore](https://spaceengineers.wiki.gg/wiki/Iron_Ore "Iron Ore").
    *   Power - Blocks that generate power. Ex:  [![Icon Block Small Reactor.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Block_Small_Reactor.png/21px-Icon_Block_Small_Reactor.png?64124d)](https://spaceengineers.wiki.gg/wiki/Small_Reactor "Small Reactor") [Small Reactor](https://spaceengineers.wiki.gg/wiki/Small_Reactor "Small Reactor").
    *   Storage - Blocks that hold items. Ex:  [![Icon Block Small Cargo Container.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Block_Small_Cargo_Container.png/21px-Icon_Block_Small_Cargo_Container.png?4af936)](https://spaceengineers.wiki.gg/wiki/Small_Cargo_Container "Small Cargo Container") [Small Cargo Container](https://spaceengineers.wiki.gg/wiki/Small_Cargo_Container "Small Cargo Container").
    *   Structural - Blocks that provide support. Ex:  [![Icon Block Light Armor Block.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Block_Light_Armor_Block.png/21px-Icon_Block_Light_Armor_Block.png?217f89)](https://spaceengineers.wiki.gg/wiki/Light_Armor_Block "Light Armor Block") [Light Armor Block](https://spaceengineers.wiki.gg/wiki/Light_Armor_Block "Light Armor Block").
    *   Tool - Handheld equipment, tool items. Ex:  [![Icon Item Hand Drill.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Item_Hand_Drill.png/21px-Icon_Item_Hand_Drill.png?3f75e3)](https://spaceengineers.wiki.gg/wiki/Hand_Drill "Hand Drill") [Hand Drill](https://spaceengineers.wiki.gg/wiki/Hand_Drill "Hand Drill").
*   **Function**: A description of what the item or block does.
*   **Per-size** details: Each of the following variables are defined for small grid and large grid. They use the form "Data<Variable><Small|Large>".
    *   Format all numbers with standard US style. e.g. #,###,###
    *   Do not include units (i.e. Do not include "kg" or "N")
    *   **Fits**: Can be installed/used on the given ship/station size.
        *   Enter either "yes", or keep empty for "no".
        *   All other values may be assumed as yes, so that should be avoided.
    *   **Mass**: Mass of the object at the given grid size in kilograms.
    *   **Power**: Energy generated/consumed in kilowatts.
        *   Negative number for power consumption, or positive number for power production.
        *   For items with variable energy draw (for example  [![Icon Block Ion Thruster.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Block_Ion_Thruster.png/21px-Icon_Block_Ion_Thruster.png?6357bf)](https://spaceengineers.wiki.gg/wiki/Ion_Thruster "Ion Thruster") [thrusters](https://spaceengineers.wiki.gg/wiki/Ion_Thruster "Ion Thruster")), include the maximum possible draw.
    *   **Force**: Force applied in Newtons.
    *   **Range**: Functional range in meters.
    *   **PCU**: Performance cost in units.
    *   **Size**: Height x Width x Depth.
    *   **Time**: Time to build in seconds.