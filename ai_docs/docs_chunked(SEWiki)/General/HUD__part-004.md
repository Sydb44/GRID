### Ship/Vehicle Information

[![Hud-ship.png](https://spaceengineers.wiki.gg/images/Hud-ship.png?9917d3)](https://spaceengineers.wiki.gg/wiki/File:Hud-ship.png)

| GUI Element | Description |
| --- | --- |
| Parking Brake / Handbrake (1) | The icon indicates whether the parking brake is on. Toggle the handbrake and the lock states of [Landing Gear](https://spaceengineers.wiki.gg/wiki/Landing_Gear "Landing Gear") or [Connector](https://spaceengineers.wiki.gg/wiki/Connector "Connector") blocks by pressing [P key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings"). Configure [Cockpit Controls](https://spaceengineers.wiki.gg/wiki/Cockpit_Controls "Cockpit Controls") before using this to dock! |
| Broadcasting (2) | The icon indicates whether the ship is broadcasting a signal or listening only. Requires an [Antenna](https://spaceengineers.wiki.gg/wiki/Antenna "Antenna") block. Toggle ship broadcasting/listening by pressing [O key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings"). |
| Power (3) | The icon indicates whether batteries and power producing blocks are on or off. [Toggle this grid's power](https://spaceengineers.wiki.gg/wiki/Cockpit_Controls "Cockpit Controls") on or off by pressing [Y key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings"). |
| Mass (4) | The number indicates the mass of the ship in kg, including cargo.  <br>Since SE v205 it's the physics engine mass therefore can be used to calculate how much thrust one needs. |
| Remaining power (5) | The number indicates the real-life time remaining before the grid runs out of power if you were to continue doing what you are doing right now. |
| Power usage percentage (6) | This bar indicates the percentage of available power currently being used. If it indicates medium to low values, your power production is good. If this bar is 100% full and turns red, the ship needs more power than available (and you need add e.g. more batteries). |
| Hydrogen percentage (7) | This bar indicates the percentage of Hydrogen available in the ship's tanks. If the bar is 100% full, then all tanks are full. Useful as fuel gauge for ships with Hydrogen Thrusters. Check whether the tanks are set to stockpile or provide hydrogen! |

## Crosshairs

[![](https://spaceengineers.wiki.gg/images/thumb/Aiming-reticle.png/320px-Aiming-reticle.png?a67aeb)](https://spaceengineers.wiki.gg/wiki/File:Aiming-reticle.png)

The aiming reticle seen from a tank's turret

The crosshairs help you aim when interacting or shooting, but they don’t look good on screenshots. You can select the option to show/hide the crosshairs on the HUD through the [Options > Game](https://spaceengineers.wiki.gg/wiki/Options "Options") menu.

The crosshair is separate from the aiming reticle while using [Block Weapons](https://spaceengineers.wiki.gg/wiki/Block_Weapons "Block Weapons"). For information on the aiming reticle, see [Target Locking](https://spaceengineers.wiki.gg/wiki/Target_Locking "Target Locking").

## Chat

Main article: [Chat](https://spaceengineers.wiki.gg/wiki/Chat "Chat")

Text chat appears on the bottom left side of the HUD. Open the chat box by pressing [ENTER key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings"), then type your message, and press [ENTER key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings") again to send the message, or to close the chat after typing nothing.

## Rotation Hints Cube

[![Rotation hints cube.jpg](https://spaceengineers.wiki.gg/images/thumb/Rotation_hints_cube.jpg/200px-Rotation_hints_cube.jpg?3ec363)](https://spaceengineers.wiki.gg/wiki/File:Rotation_hints_cube.jpg)

Shows the primary binds for rotating the block as well as the block's internal orientation.  
Only visible when placing blocks with the [full HUD mode](#Cycling_HUD_Visibility). Can be fully turned off in [Options > Game > Show Rotation Hints](https://spaceengineers.wiki.gg/wiki/Options "Options").

You may have noticed some sides of the cube are different colors. The red, green and dark blue faces represent +X, +Y and +Z which translate into Right, Up, Back.

One way to remember the directions happens to be hinted by the RGB matching the direction names: **R**ight, **G**roundnt, **B**ack.

## Block Info

[![Block info.jpg](https://spaceengineers.wiki.gg/images/thumb/Block_info.jpg/300px-Block_info.jpg?47b19c)](https://spaceengineers.wiki.gg/wiki/File:Block_info.jpg)

Shown on the right side of the screen when equipping a block or aiming at an existing block with a hand welder or grinder.

From the top:

*   Block icon and original block name (does not change here if renamed in terminal).
*   "Built by" indicates who claims the [PCU](https://spaceengineers.wiki.gg/wiki/PCU "PCU") for this block.
*   The little square followed by bigger square indicate grid size, the highlighted one is the current.
*   A description of the block, only seen in [full HUD mode](#Cycling_HUD_Visibility).
*   The [PCU](https://spaceengineers.wiki.gg/wiki/PCU "PCU") amount that this block consumes when fully built.

Next is the component stack.

The vertical bar indicates the integrity (health) percentage of the block.

*   The red "functional" line indicates how much it has to be built in order to [function](https://spaceengineers.wiki.gg/wiki/Functional_Blocks "Functional Blocks") and to be [airtight](https://spaceengineers.wiki.gg/wiki/Airtightness "Airtightness") (if it can be at all).
*   The blue "hack" line indicates where you have to grind in order to [hack](https://spaceengineers.wiki.gg/wiki/Hacking "Hacking") the block. The position of this is determined by the  [![Icon Item Computer.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Item_Computer.png/21px-Icon_Item_Computer.png?65c1a4)](https://spaceengineers.wiki.gg/wiki/Computer "Computer") [Computer](https://spaceengineers.wiki.gg/wiki/Computer "Computer") components.

Then there's the list of components required to fully build the block.  
The component at the bottom is required to place the construction stage of the block.  
The numbers before the `/` (slash) indicate how many components are stockpiled ready to be welded, then the numbers to the right of the slash are how many it requires.

A permanently red highlighted component name will only show up when using a grinder on a block which will **lose** that component if grinded, usually returned as [Scrap Metal](https://spaceengineers.wiki.gg/wiki/Scrap_Metal "Scrap Metal").

When the block is missing a component in order to be welded then said component will be temporarily highlighted red when attempting to weld.
