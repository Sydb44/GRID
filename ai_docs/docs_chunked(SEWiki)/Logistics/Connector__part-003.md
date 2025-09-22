
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

### Control Panel Screen

*   Throw Out - Turns the Connector into an Ejector and dumps its inventory. Combine with [Sorters](https://spaceengineers.wiki.gg/wiki/Conveyor_Sorter "Conveyor Sorter").
*   Collect All - Pull all available items into inventories behind. Used to control loading and unloading. Combine with [Sorters](https://spaceengineers.wiki.gg/wiki/Conveyor_Sorter "Conveyor Sorter").
*   Trading Mode - Allows docking, disallows inventory access and recharging gas or power.
*   Override Power Transfer - When enabled, it allows docking but not recharging power. The two connected grids are power-isolated.
*   Auto-Unlock Time - Prevents players to occupy a dock permanently.
*   Lock button - Docks the connector to another connector in proximity, recharges gas and power, grants allies inventory access.
*   Unlock button - Undocks and disconnects from the conveyor system.
*   Used for Parking - Whether this Connector locks/unlocks whenever someone presses [P key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings"). See also [Cockpit Controls](https://spaceengineers.wiki.gg/wiki/Cockpit_Controls "Cockpit Controls"). For a hangar connector inside a carrier or base, disable this. For a ship not carrying other grids, enable it.
*   Strength - How violently the electromagnet pulls the docked ship. Decrease for small ships. The lowest value of any two connectors in proximity is used.

## Inventory

With [Realistic settings](https://spaceengineers.wiki.gg/wiki/World_Settings "World Settings"), the Connector has a small inventory with a capacity of 1,152L on small ships, and 8,000L on large ships and stations. The inventory accepts all items, allowing the transfer and short-term storage of all manner of goods.

If attached to a [conveyor system](https://spaceengineers.wiki.gg/wiki/Conveyor_system "Conveyor system"), the conveyor inventory accepts pushed items from other blocks. It can pull items from any directly-attached inventories while actively ejecting.[\[1\]](#cite_note-1)

## Power Usage

From SE v1.199 onwards, Connectors no longer require any power to function. This lets players for example connect a rescue vehicle to a rover that ran out of battery power, which aids in recovery and salvage operations.

## Construction

The Connector block exists both for large grid where it is 1x1x1, and small grid where it is 3x3x2.

If you want your connector to be able to transfer cargo between your ships, make sure its conveyor ports are piped up. It had a large conveyor port on the back of it, and it also has four small conveyor ports on its sides when built in small grid (which can only transfer small items such as ores).

To allow the connector to connect to other connectors or eject items, make sure leave the magnetic ring on the front of the block exposed with enough space: any blocks sticking out in front of it may block other ships from connecting to it, or cause there to not be enough space to eject items. It is possible however to place thin blocks such as catwalks and glass directly on connectors, and still have them still connect to other connectors and transfer items.

This block is not [airtight](https://spaceengineers.wiki.gg/wiki/Airtightness "Airtightness"). If you want to place a connector adjacent to or inside a room that you want to be airtight, consider placing it on a  [![Icon Block Conveyor Junction.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Block_Conveyor_Junction.png/21px-Icon_Block_Conveyor_Junction.png?500970)](https://spaceengineers.wiki.gg/wiki/Conveyor_Junction "Conveyor Junction") [Conveyor Junction](https://spaceengineers.wiki.gg/wiki/Conveyor_Junction "Conveyor Junction"), or using an  [![Icon Block Inset Connector.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Block_Inset_Connector.png/21px-Icon_Block_Inset_Connector.png?6e5dae)](https://spaceengineers.wiki.gg/wiki/Inset_Connector "Inset Connector") [Inset Connector](https://spaceengineers.wiki.gg/wiki/Inset_Connector "Inset Connector") instead.

By default, pressing the [park brake key](https://spaceengineers.wiki.gg/wiki/Cockpit_Controls "Cockpit Controls") [P key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings") will cause connectors on the grid to switch lock, which means anything attached to your ship/rover by connectors will fall off. Every time you build a connector, consider opening its control panel to configure it, if this is not the behavior you want.

## Recipe

| [![Icon Block Connector.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Block_Connector.png/21px-Icon_Block_Connector.png?30a126)](https://spaceengineers.wiki.gg/wiki/Connector "Connector") Connector |     |     |     |     |
| --- | --- | --- | --- | --- |
| Component | Large Ship/Station  <br>Required | Large Ship/Station  <br>Optional | Small Ship  <br>Required | Small Ship  <br>Optional |
| [![Icon Item Steel Plate.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Item_Steel_Plate.png/21px-Icon_Item_Steel_Plate.png?437e3a)](https://spaceengineers.wiki.gg/wiki/Steel_Plate "Steel Plate") [Steel Plate](https://spaceengineers.wiki.gg/wiki/Steel_Plate "Steel Plate") | 130 | 20  | 15  | 6   |
| [![Icon Item Small Steel Tube.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Item_Small_Steel_Tube.png/21px-Icon_Item_Small_Steel_Tube.png?4fe418)](https://spaceengineers.wiki.gg/wiki/Small_Steel_Tube "Small Steel Tube") [Small Steel Tube](https://spaceengineers.wiki.gg/wiki/Small_Steel_Tube "Small Steel Tube") | 12  | —   | 6   | —   |
| [![Icon Item Motor.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Item_Motor.png/21px-Icon_Item_Motor.png?4a2f3f)](https://spaceengineers.wiki.gg/wiki/Motor "Motor") [Motor](https://spaceengineers.wiki.gg/wiki/Motor "Motor") | 8   | —   | 6   | —   |
| [![Icon Item Construction Comp..png](https://spaceengineers.wiki.gg/images/thumb/Icon_Item_Construction_Comp..png/21px-Icon_Item_Construction_Comp..png?cdc26f)](https://spaceengineers.wiki.gg/wiki/Construction_Comp. "Construction Comp.") [Construction Comp.](https://spaceengineers.wiki.gg/wiki/Construction_Comp. "Construction Comp.") | 40  | —   | 12  | —   |
| [![Icon Item Computer.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Item_Computer.png/21px-Icon_Item_Computer.png?65c1a4)](https://spaceengineers.wiki.gg/wiki/Computer "Computer") [Computer](https://spaceengineers.wiki.gg/wiki/Computer "Computer") | 20  | —   | 6   | —   |
