---
title: "Cockpit Controls"
url: "https://spaceengineers.wiki.gg/wiki/Cockpit_Controls"
category: "Flight"
wiki_page: "Cockpit Controls"
includes_blocks: true
---

# Cockpit Controls - Official Space Engineers Wiki

While seated in a [control seat](https://spaceengineers.wiki.gg/wiki/Flight_Seat "Flight Seat") or [cockpit](https://spaceengineers.wiki.gg/wiki/Cockpit "Cockpit"), there are default keyboard shortcuts to quickly toggle common functionality such as light, power, antenna, and parking behaviour. "Parking" means locking [Connectors](https://spaceengineers.wiki.gg/wiki/Connector "Connector") and [Landing Gears](https://spaceengineers.wiki.gg/wiki/Landing_Gear "Landing Gear"), and for land vehicles also locking the [wheels’ handbrakes](https://spaceengineers.wiki.gg/wiki/Wheel_Suspension "Wheel Suspension").

**The “Parking” behaviour is configurable — and it’s strongly recommended[\[1\]](#cite_note-1) that you do not leave the defaults on carriers.**

*   [P key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings") = Toggle parking
*   [O key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings") = Toggle broadcasting
*   [L key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings") = Toggle lights
*   [Y key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings") = Toggle power

If handbrakes or connector power transfer don't work as expected, check additional settings in their control panel.

## Parking Toggle (P)

While in a cockpit of a rover or ship, press [P key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings") to toggle Parking on and off. This key is configurable to do exactly what you need your specific grid to do when parking.

To configure it, sit in the grid and press [K key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings") to open the Control Panel. For each newly added **connector, landing gear, or wheel (its handbrake)**, decide whether you want it to be locked when [P key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings") is pressed, or whether this block should be ignored when parking.

*   [P key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings") can lock or unlock a connector -- Toggle the connector setting named **Used for Parking.**  
    \=> Disable this option for connectors in carrier hangars!
*   [P key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings") can lock or unlock Landing Gear and Magnetic Plates -- Toggle the gear’s setting named **Used for Parking**.  
    \=> Disable this for landing gears of carrier hangars that hold ships, and in tugs and cranes that use the magnetic gear to hold debris or wrecks!
*   [P key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings") can switch a rover's handbrake on or off -- Toggle on each wheel suspension’s setting named **Allow Parking Brake**.  
    \=> If your vehicle tips over forward when braking, disable this setting on the front wheels.

### Tip: How not to lose docked ships

While piloting a smaller ship, you use [P key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings") to undock your own Landing Gear or Connector from the carrier. While piloting a carrier, you want to press [P key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings") to undock the carrier from a large station -- and not undock all the carried ships on connectors inside its hangar!

So either, never use [P key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings") when piloting carriers... or better, get into the habit of switching off “Used for Parking” on all hangar-side connectors where carried ships are docked.

## Power Toggle (Y)

While in a cockpit of a rover or ship, press [Y key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings") to switch all power blocks (Batteries, etc.) of the current grid on or off. The lack of power stops all conveyors and production, prevents engines and reactors from using up fuel, but also prevents batteries from recharging.

You can also press [CTRL+Y key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings") (RB+dpadleft) in case you want to really toggle the power of _all_ connected grids and sub-grids on or off.

By default, [connectors](https://spaceengineers.wiki.gg/wiki/Connector "Connector") on the current grid stay magnetically locked but do not transfer any power when power has been toggled off with Y. A connector's power transfer can be configured with a setting in the connector.

(Note: Before release 1.99, the power keyboard shortcut Y affected all connected grids and subgrids. This used to cause unexpected behaviour, for example, other grids docked at bases or in carriers would be inadvertently switched off as well, which undocked them and exposed them to "garbage collection" on multiplayer servers.)

## Light Toggle (L)

While in a cockpit of a rover or ship that has [Spotlights](https://spaceengineers.wiki.gg/wiki/Spotlight "Spotlight"), press 'L' to toggle these lights on and off. You cannot toggle your suit lights when seated because they use the same shortcut.

## Broadcast Toggle (O)

If the grid has an [antenna](https://spaceengineers.wiki.gg/wiki/Antenna "Antenna"), press 'O' to toggle between passive listening, or actively broadcasting your location. This shortcut is the same as for the player's suit antenna and you cannot switch off your suit antenna while seated in a cockpit.

## And how do I activate anything else?

There are many other custom actions that you may want to control from a cockpit: Enabling overrides on directional thrusters, switching interior or exterior lights, switching locked turret targets, running emergency generators, recharging batteries, starting the jump drive, opening and closing grouped ramps and doors, activating static weapons and tools, and many more.

To assign keyboard shortcuts (the numbers keys) to such actions, configure your cockpit [Toolbar](https://spaceengineers.wiki.gg/wiki/Tool_Bar "Tool Bar") -- details see there.

Tip: To control any other multi-block sequence of actions that is not listed here, create groups on the [Control Panel Screen](https://spaceengineers.wiki.gg/wiki/Control_Panel_Screen "Control Panel Screen") and set up sets of actions inside [Timer Blocks](https://spaceengineers.wiki.gg/wiki/Timer_Block "Timer Block"). Then toggle the Timer Blocks from the cockpit [Toolbar](https://spaceengineers.wiki.gg/wiki/Tool_Bar "Tool Bar").

To learn how to specifically control Grid Weapons from a cockpit, see [Block Weapons](https://spaceengineers.wiki.gg/wiki/Block_Weapons "Block Weapons").
