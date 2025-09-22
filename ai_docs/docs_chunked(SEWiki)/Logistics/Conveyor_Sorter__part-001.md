---
title: "Conveyor Sorter"
url: "https://spaceengineers.wiki.gg/wiki/Conveyor_Sorter"
category: "Logistics"
wiki_page: "Conveyor Sorter"
includes_blocks: true
---

# Conveyor Sorter - Official Space Engineers Wiki

| Conveyor Sorter |     |
| --- | --- |
| [![Icon Block Conveyor Sorter.png](https://spaceengineers.wiki.gg/images/d/db/Icon_Block_Conveyor_Sorter.png?b0bfc9)](https://spaceengineers.wiki.gg/wiki/File:Icon_Block_Conveyor_Sorter.png) |     |
| * * * |     |
| **Function:** | Use Conveyor sorters to let only specific items through |
| **DLC?** | Vanilla |
| * * * |     |
| **Fits small grid** |     |
| Mass: | 180.0 kg |
| Hitpoints: | 595 |
| PCU: | 25  |
| Size: | 3x3x1 |
| Time to Build: | 12 sec |
| * * * |     |
| **Fits large grid** |     |
| Mass: | 1362.0 kg |
| Hitpoints: | 5200 |
| PCU: | 25  |
| Size: | 1x1x1 |
| Time to Build: | 20 sec |
| * * * |     |
| _Data Controls:_ | \[[purge](https://spaceengineers.wiki.gg/wiki/Conveyor_Sorter?action=purge)\] ([?](https://spaceengineers.wiki.gg/wiki/Template:Info_Block))) |
|     |     |

The  [![Icon Block Conveyor Sorter.png](https://spaceengineers.wiki.gg/images/thumb/d/db/Icon_Block_Conveyor_Sorter.png/21px-Icon_Block_Conveyor_Sorter.png?b0bfc9)](https://spaceengineers.wiki.gg/wiki/Conveyor_Sorter "Conveyor Sorter") Conveyor Sorter is a block in Space Engineers that is used to control the directional flow of items in a [Conveyor system](https://spaceengineers.wiki.gg/wiki/Conveyor_system "Conveyor system"). Use it to filter, sort, or pump items using a blacklist or a whitelist, actively or passively. The block is often used together with [Connectors](https://spaceengineers.wiki.gg/wiki/Connector "Connector").

The paid [Heavy Industry Pack](https://spaceengineers.wiki.gg/wiki/Heavy_Industry_Pack "Heavy Industry Pack") DLC contains the Industrial Conveyor Sorter, a more rounded aesthetic variant of the sorter with the same recipe that is available for large grids only.

## Usage

Items can flow through the block only in the direction of the arrow painted on its side.

*   Filter Mode - Set up filters to passively allow/prevent items from going in or out of containers, in the direction where the arrow points. Use two Sorters to control both directions.
*   Drain All - Activate this mode to actively pull all whitelisted items (or all non-blacklisted items) from one side and push them into the conveyor system on the side where the arrow points.

Knowing how to use this vanilla block lowers the demand of [mods](https://spaceengineers.wiki.gg/wiki/Mods "Mods") and [scripts](https://spaceengineers.wiki.gg/wiki/Scripts "Scripts") to manage inventory.

### Usage Examples

[![Conveyor Sorters](https://spaceengineers.wiki.gg/images/thumb/f/f1/Conveyor_sorter.jpg/320px-Conveyor_sorter.jpg?99d444)](https://spaceengineers.wiki.gg/wiki/File:Conveyor_sorter.jpg)

Twin Conveyor Sorters on Junctions control what goes in and out of inventories.

For fine control of both directions of flow, you often combine Sorters with other Sorters on T Junctions (see below).

Example: Optimize the procesing queue instead of letting SE choose the order. Use Sorters to set up dedicated [Production](https://spaceengineers.wiki.gg/wiki/Production "Production") machines that focus on processing only one ore, or that mass produce certain components.

*   One dedicated Refinery can focus on Stone (or Cobalt) processing, while other Refineries process other, faster ores.
*   Actively pull and eject gravel or stone through a Connector/Ejector to not clog up inventories.

Example: Monitor your fill level of Ammunition or Metal Grids. Setting up dedicated [Small Cargo Containers](https://spaceengineers.wiki.gg/wiki/Small_Cargo_Container "Small Cargo Container") that pull and store one type of item is valuable when used together with an [Event Controller](https://spaceengineers.wiki.gg/wiki/Event_Controller "Event Controller"), set to monitor the container's fill level.

*   Raise an alarm when you are running low on a specific item.
*   Or switch off specialised production when it's full.

Example: To transfer items between ships, you often use Sorters together with [Connectors](https://spaceengineers.wiki.gg/wiki/Connector "Connector")/Ejectors.

*   A fighter that returns to a base connector can activate a sorter to quickly pull ammo.
*   An [Autopiloted](https://spaceengineers.wiki.gg/wiki/Autopilot "Autopilot") delivery drone uses Sorters to pull certain ores from cargo containers at the mines, and delivers ice at one base, and the remaining ores at another base.

Careful, if you insert a sorter in the conveyor chain after a drill, and blacklist stone, then the stone will clog up the drill's inventory and you'll lose the ores. Instead, use a cargo container as buffer first, followed by a Sorter and [Ejectors](https://spaceengineers.wiki.gg/wiki/Ejector "Ejector") to expel stone.

### How to set up passive filtering

For the **passive Filter Mode**, choose either a whitelist or blacklist.

*   If you select whitelist, only what is listed in the "active filters" list is allowed through. If the "active filters" list is empty, nothing is allowed through in that direction.
*   If you select blacklist, nothing that is listed in the "active filters" list is allowed through. If the "active filters" list is empty, everything is allowed through in that direction.

Note: In the UI, _Active_ filter means that the filter is in use, not that it _actively_ pulls or pushes items through the pipe!

How to manage the Active Filters list:

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
