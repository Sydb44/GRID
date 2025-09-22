---
title: "Event Controller"
url: "https://spaceengineers.wiki.gg/wiki/Event_Controller"
category: "General"
wiki_page: "Event Controller"
includes_environment: true
includes_blocks: true
---

# Event Controller - Official Space Engineers Wiki

| Event Controller |     |
| --- | --- |
| [![Icon Block Event Controller.png](https://spaceengineers.wiki.gg/images/1/17/Icon_Block_Event_Controller.png?8d8e4e)](https://spaceengineers.wiki.gg/wiki/File:Icon_Block_Event_Controller.png) |     |
| * * * |     |
| **Function:** | Event Controllers trigger actions based on block or grid conditions... |
| **DLC?** | Vanilla |
| * * * |     |
| **Fits small grid** |     |
| Mass: | 38.4 kg |
| Hitpoints: | 127 |
| Power: | \-0.0005 MW |
| PCU: | 10  |
| Size: | 1x1x1 |
| Time to Build: | 5 sec |
| * * * |     |
| **Fits large grid** |     |
| Mass: | 304.0 kg |
| Hitpoints: | 1080 |
| Power: | \-0.0005 MW |
| PCU: | 10  |
| Size: | 1x1x1 |
| Time to Build: | 12 sec |
| * * * |     |
| _Data Controls:_ | \[[purge](https://spaceengineers.wiki.gg/wiki/Event_Controller?action=purge)\] ([?](https://spaceengineers.wiki.gg/wiki/Template:Info_Block))) |
|     |     |

The Event Controller is a functional automation block in Space Engineers that gives your grids "senses" for its own blocks.

## Usage

The Event Controller monitors the grid's block states for you, and when values change, it reacts by triggering your chosen [toolbar](https://spaceengineers.wiki.gg/wiki/Tool_Bar "Tool Bar") actions[\[1\]](#cite_note-1). Use this automation block in conjunction with other [Artificial Intelligence](https://spaceengineers.wiki.gg/wiki/Artificial_Intelligence "Artificial Intelligence") blocks to create logic systems.

[![Event-controller.png](https://spaceengineers.wiki.gg/images/thumb/3/3a/Event-controller.png/320px-Event-controller.png?ba0aa1)](https://spaceengineers.wiki.gg/wiki/File:Event-controller.png)

Picture "events" as a way to give drones commands in an if-this-then-that format. For example in case of a mining drone, “If your cargo is full, then return to base”. Or in case of base automation, "If the piston elevator reaches the middle floor, stop and open the doors", and many more.

### Examples

*   When someone passes through the airlock, automatically open the doors and preserve oxygen.
*   If essential blocks are destroyed, switch on self-projectors and welders for repairs.
*   If a fighter drone is out of ammo or has lost its weapons, retreat to connector in hangar.
*   If hydrogen runs low, then produce more and switch a tank to “stockpile”.
*   If intruders are detected, then switch on a labelled [beacon](https://spaceengineers.wiki.gg/wiki/Beacon "Beacon") to call faction mates for defence.
*   If the base is low on gas/fuel/power/ammo, then switch on a coloured warning light to warn faction members.
*   During ascent from planet at max speed, decrease thrust override to not waste hydrogen, and below min speed increase thrust override, and switch off the override when natural gravity is zero.

And more ...!

Tip: Use an [Emotion Controller](https://spaceengineers.wiki.gg/wiki/Emotion_Controller "Emotion Controller") LCD panel (DLC only) to display simple status changes along with these actions.

### What are the EC's advantages and differences?

The Event Controller exposes a lot of functionality to the vanilla game that was formerly accessible only through [scripting](https://spaceengineers.wiki.gg/wiki/Scripting "Scripting") and [modding](https://spaceengineers.wiki.gg/wiki/Modding "Modding"). Even players on consoles that disallow scripts, and any players who cannot write scripts, can use an Event Controller to do basic "programming".

How is the EC different?

*   [Automatons](https://spaceengineers.wiki.gg/wiki/Automaton "Automaton"), [weapon AI](https://spaceengineers.wiki.gg/wiki/Block_Weapons "Block Weapons") and [CTC AI](https://spaceengineers.wiki.gg/wiki/Custom_Turret_Controller "Custom Turret Controller") detect other grids up to 2-2.5km away -- while the Event Controller monitors only _its own grid_.
*   [Automatons](https://spaceengineers.wiki.gg/wiki/Automaton "Automaton"), [Sensors](https://spaceengineers.wiki.gg/wiki/Sensor "Sensor"), [weapon AI](https://spaceengineers.wiki.gg/wiki/Block_Weapons "Block Weapons") and [CTC AI](https://spaceengineers.wiki.gg/wiki/Custom_Turret_Controller "Custom Turret Controller") react to grids, [meteorites](https://spaceengineers.wiki.gg/wiki/Meteor "Meteor"), or players -- while the Event Controller watches only _blocks_.
*   The Event Controller can monitor a wider variety of state changes on its grid than a [Sensor](https://spaceengineers.wiki.gg/wiki/Sensor "Sensor") or an [Air Vent](https://spaceengineers.wiki.gg/wiki/Air_Vent "Air Vent") can.
*   In contrast to scripts and script mods, the Event Controller also works on consoles.

### Which Events Can Be Detected?

The EC monitors only blocks on the _same_ grid, or on a [connected](https://spaceengineers.wiki.gg/wiki/Connector "Connector") or [merged](https://spaceengineers.wiki.gg/wiki/Merge_Block "Merge Block")) grid!

|     |     |     |     |     |
| --- | --- | --- | --- | --- |What can the Event Controller detect?
| Event | Condition | Values | Examples | Blocks |
| Altitude | is equal or greater/less than | 1-50000 metres above ground | Hovercraft, elevators, foldable ramps | N/A |
| Rotor/Hinge Angle | is equal or greater/less than | \-360 to +360 degrees | Detect that a Hinge or Rotor has reached a specific orientation | Hinge, Rotor |
| Block Added/Removed | N/A | N/A | Detect boarders, detect damage to own grid | Any blocks. |
| Block Integrity Percentage | is equal or greater/less than | 0-100% | detect damage on same grid, detect [3D Printer](https://spaceengineers.wiki.gg/wiki/3D_Printer "3D Printer") completion | A set of functional blocks of your choice, excluding armor blocks |
| Block On/Off Switched | is  | (Select from the grid's blocks) | If on/off, then action. If H2 Generators are on, then also switch certain tanks to stockpile | A set of functional blocks of your choice, excluding armour blocks |
| Cargo Filled Percentage | is equal or greater/less than | 0-100% | make miner return to base if 80% full, produce ammo if running low, warn if running out of ice or uranium, ... | Any Inventory: [Cargo Containers](https://spaceengineers.wiki.gg/wiki/Cargo_Container "Cargo Container"), Block Weapons (ammo), Reactor (Uranium), Block Tools, Assembler, Refinery, Collector, Connector, Cockpits, Survival Kit, Cryo Chamber, bottles in Tanks, ice or bottles in O2/H2 Generator, parachutes in hatch, chips in Safe Zone, Store, Target Dummy, ... |
| Cockpit Occupied | is  | Yes/No | If player seated then toggle batteries off recharge, open hangar doors, etc. If driver's server connection drops, stop the ship. | Cockpit, Industrial Cockpit, Fighter Cockpit, any passenger Seats, Bathroom, Toilet Seat, (Corner) Couch, Cryo Chamber, Helm, ... |
| Connector Connected | is  | Yes/No | if docked ship detected then extend walkway, load ammo, offload cargo ... | Connectors |
| Connector Ready to Lock | is  | Yes/No | if proximity, then lock | Connectors |
| Distance to Locked target | is equal or greater/less than | 1 - 2500 metres | Ignite warheads; drop tactical [decoys](https://spaceengineers.wiki.gg/wiki/Decoy "Decoy"); launch [PBWs](https://spaceengineers.wiki.gg/wiki/Player_Built_Weapons "Player Built Weapons") | Cockpits and Control Seats that have target locking active |
| Door Opened | is  | Yes/No | Switch on/off lights, (de)pressurise the room or airlock, start 2 sec Timer that closes all doors | Door, Offset Door, Sliding Door, Airtight Hangar Door, ... |
| Gas Tank Filled Percentage | is equal or greater/less than | 0-100% | Switch O2/H2 Generator on/off, switch Tank Stockpile on/off | Oxygen Tanks, Hydrogen Tanks |
| Grid Speed Changed | is equal or greater/less than | 0 - 100 m/s | React to own [Inertial Dampers](https://spaceengineers.wiki.gg/wiki/Inertial_Dampers "Inertial Dampers"), save fuel by decreasing thrust override, prevent falling in [Gravity](https://spaceengineers.wiki.gg/wiki/Gravity "Gravity") | None |
| Landing Gear Locked | is  | Yes/No | rotate crane after it has picked up a block | Landing Gear, Magnetic Plate |
| Magnetic Gear Ready | is  | Yes/No | Lock Landing Gear when close enough | Landing Gear, Magnetic Plate |
| Merge Block merged | is  | Yes/No | [3D Printer](https://spaceengineers.wiki.gg/wiki/3D_Printer "3D Printer") automation | Merge blocks |
| Natural Gravity Changed | is equal or greater/less than | 0 - 10 g | Adjust speed or switch thrusters when leaving or reaching a planet | None |
| Piston Position Percentage | is equal or greater/less than | 0-100% | Stop the elevator at a floor. Percentage is within min/max of that piston! | Piston |
| Power Output Percentage | is equal or greater/less than | 0-100% | Switch off H2 engine while wind/solar is producing | Battery, Reactor, Solar Panel, Hydrogen Engine, Wind Turbine |
| Rotor/Hinge attached/detached | is  | Yes/No | [3D Printer](https://spaceengineers.wiki.gg/wiki/3D_Printer "3D Printer") automation, truck hitches | Rotors, Hinges |
| Stored Power Percentage | is equal or greater/less than | 0-100% | toggle battery discharge/recharge/hydrogen engines | Batteries |
| Thrust Percentage | is equal or greater/less than | 0-100% | Keep speed at a certain level | Thrusters |

For comparison:

|     |     |     |     |     |
| --- | --- | --- | --- | --- |What can other blocks detect and at which range?
| Event | Condition | Values | Examples | Detector Blocks |
| Adjacent room pressurised | is  | yes/no | Air Lock cycle | See [Air Vent](https://spaceengineers.wiki.gg/wiki/Air_Vent "Air Vent") |
| Subgrid proximity | is equal or greater/less than | 0.1 to 50m | [3D Printer](https://spaceengineers.wiki.gg/wiki/3D_Printer "3D Printer") | See [Sensor](https://spaceengineers.wiki.gg/wiki/Sensor "Sensor") |
| Players on foot | is equal or greater/less than | 0.1 to 50m | Airlocks, traps | See [Sensor](https://spaceengineers.wiki.gg/wiki/Sensor "Sensor") |
| Floating items | is equal or greater/less than | 0.1 to 50m | ore collectors, grid damage/debris detection | See [Sensor](https://spaceengineers.wiki.gg/wiki/Sensor "Sensor") |
| Asteroid proximity | is equal or greater/less than | 0.1 to 50m | Automatic asteroid miner | See [Sensor](https://spaceengineers.wiki.gg/wiki/Sensor "Sensor") and [AI Flight](https://spaceengineers.wiki.gg/wiki/AI_Flight "AI Flight")) |
