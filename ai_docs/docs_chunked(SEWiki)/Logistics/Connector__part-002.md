You can build docking-only Connectors that have no conveyor system access--just make sure players know which Connector is used for what.

To lock and unlock:

*   Either assign the **Lock/Unlock** toggle action to the [Toolbar](https://spaceengineers.wiki.gg/wiki/Tool_Bar "Tool Bar") of your cockpit
*   or click the **Lock/Unlock** button in the Connector's [Control Panel Screen](https://spaceengineers.wiki.gg/wiki/Control_Panel_Screen "Control Panel Screen"),
*   or press [P key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings").

Important: On a carrier at a space station, when you press [P key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings") to undock the carrier itself, you _do not want_ to undock all carried ships! You must configure the [Cockpit Controls](https://spaceengineers.wiki.gg/wiki/Cockpit_Controls "Cockpit Controls") of the hangar Connectors on your carrier so that pressing [P key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings") is _not_ used for “parking”.

The owner of a Connector can also define an **Auto-unlock time** after which docked grids are disconnected.

Tip: After unlocking, the electromagnets are inactive for a few seconds to give you time to move out of range. If the magnets are too strong for a small ship, decrease the **strength** value on the control panel screen.

### How to transfer items between docked ships

To transfer items, you dock two ships (or a ship and a station) together using Connectors. Connectors do not actively pull or push items _into another inventory_ on their own, you need to combine them with other blocks!

To transfer items between two docked grids, you have the following options:

*   **Automatic transfer initiated by recipient**:
    1.  Add a [Sorter](https://spaceengineers.wiki.gg/wiki/Conveyor_Sorter "Conveyor Sorter") into the conveyor chain on the _receiving_ side.
    2.  Set up the Sorter's item filter.
    3.  Enable the Sorter's **Drain All** function.
    4.  Lock the two Connectors.
*   **From Connector/Ejector to Collector**: No faction permissions required.
    1.  Fly the sending ship's Connector close to the receiving ship/station's [Collector](https://spaceengineers.wiki.gg/wiki/Collector "Collector") but leave a small gap.
    2.  Jettison the items by activating the Connector's **Throw Out** option (=Ejector).
    3.  The Collector block catches any items in its inventory or (if full) the items float in space.
*   **Manual Drag & Drop**:
    1.  Lock the two connectors.
    2.  Open the [inventory screen](https://spaceengineers.wiki.gg/wiki/Inventory "Inventory").
    3.  Manually drag and drop items between the docked ships/station.

### Can blocks push or pull items through connectors?

Apart from manual drag&drop, items are only transferred if any block receives a pull-request from one side of the Connector link.

Some examples:

*   [Welders](https://spaceengineers.wiki.gg/wiki/Welder_\(Block\) "Welder (Block)") can pull needed components from containers over a connector link by sending a pull-request. For details how to pull, see [Build Planner](https://spaceengineers.wiki.gg/wiki/Build_Planner "Build Planner").
*   [Grinders](https://spaceengineers.wiki.gg/wiki/Grinder_\(Block\) "Grinder (Block)") cannot push gathered components or ores to containers over a connector link, and containers won't send pull-requests to Grinders through Connectors.
*   [Drills](https://spaceengineers.wiki.gg/wiki/Drill "Drill") push their inventories into refineries and secondarily to cargo containers, but only while their own inventory is full and overflowing.

This means in general, as already mentioned, you have to use [Conveyor Sorter](https://spaceengineers.wiki.gg/wiki/Conveyor_Sorter "Conveyor Sorter") blocks on the recipient's side to actively pull through Connectors.

### How to prevent theft using Trading Mode

All NPC [Trading Outposts](https://spaceengineers.wiki.gg/wiki/Trading_Outposts "Trading Outposts") use Trading Mode on their Connectors. Trading Mode allows only trading and prevents other Connector features that could be exploited.

The trade goods' volume often exceeds a character inventory's volume and a player cannot fulfil acquisition contracts at the [Store](https://spaceengineers.wiki.gg/wiki/Store "Store") block. Therefore, traders would have to allow strangers to dock and use the conveyor system for deliveries. However, this would open up the trader to all kinds of theft and griefing: Visitors could suck dry the trader's batteries and hydrogen tanks for free, they could steal items from the trader's cargo containers, clog the traders cargo with gravel, and so on.

Since the Economy update, you can enable **Trading Mode** on Connectors to prevent exploitable actions:

Trading mode allows docked strangers' grids only to:

*   [Dock](https://spaceengineers.wiki.gg/wiki/Docking "Docking") to a Connector.
*   Use the Conveyor system exclusively to trade through [Contracts blocks](https://spaceengineers.wiki.gg/wiki/Contracts_Block "Contracts Block") and [Store](https://spaceengineers.wiki.gg/wiki/Store "Store") blocks.

Trading Mode mode disallows docked grids certain actions:

*   No inventory access
*   No power transfer
*   No gas transfer

Traders can auto-unlock visitors after a chosen time. After disconnecting from a Connector in Trading Mode, there is an interval when the visiting ship cannot connect immediately again. These options prevent one player to occupy a connector permanently.

### What's the connectors status

The connector has a white ring that works as a status indicator.

*   red ring:
    *   Grid out of power (electromagnets are on, another powered grid could still actively dock).
    *   Connector disabled (connections are not possible, electromagnets are off).
*   white ring: ready to eject, not ready to dock.
*   yellow ring: Proximity to another connector detected. Indicates that it's ready to dock and not ready for ejecting.
*   blue ring: You have just undocked and the electromagnets are off for a few seconds. Indicates it's not ready to dock.
*   green ring: When one pilot locks their Connector, both yellow rims turn green and a conveyor connection is established.
*   X symbol on ring: Ejector is blocked by floating items.
