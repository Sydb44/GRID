---
title: "Sensor"
url: "https://spaceengineers.wiki.gg/wiki/Sensor"
category: "Utility"
wiki_page: "Sensor"
includes_blocks: true
---

# Sensor - Official Space Engineers Wiki

| Sensor |     |
| --- | --- |
| [![Icon Block Sensor.png](https://spaceengineers.wiki.gg/images/Icon_Block_Sensor.png?b7e0be)](https://spaceengineers.wiki.gg/wiki/File:Icon_Block_Sensor.png) |     |
| * * * |     |
| **Function:** | Sensors can be set up to activate ship systems when they detects pl... |
| **DLC?** | Vanilla |
| * * * |     |
| **Fits small grid** |     |
| Mass: | 0 kg |
| Hitpoints: | 515 |
| PCU: | 25  |
| Size: | 1x1x1 |
| Time to Build: | 6 sec |
| * * * |     |
| **Fits large grid** |     |
| Mass: | 0 kg |
| Hitpoints: | 515 |
| PCU: | 25  |
| Size: | 1x1x1 |
| Time to Build: | 6 sec |
| * * * |     |
| _Data Controls:_ | \[[purge](https://spaceengineers.wiki.gg/wiki/Sensor?action=purge)\] ([?](https://spaceengineers.wiki.gg/wiki/Template:Info_Block))) |
|     |     |

A  [![Icon Block Sensor.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Block_Sensor.png/21px-Icon_Block_Sensor.png?b7e0be)](https://spaceengineers.wiki.gg/wiki/Sensor "Sensor") Sensor is a functional block designed to automatically detect proximity events and trigger actions in its grid.

To detect other grid events, see also [Event Controller](https://spaceengineers.wiki.gg/wiki/Event_Controller "Event Controller"). To trigger actions in other grids, see [Action Relay](https://spaceengineers.wiki.gg/wiki/Action_Relay "Action Relay").

The  [![Icon Block Automaton Sensor.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Block_Automaton_Sensor.png/21px-Icon_Block_Automaton_Sensor.png?6aac23)](https://spaceengineers.wiki.gg/wiki/Automaton_Sensor "Automaton Sensor") [Automaton Sensor](https://spaceengineers.wiki.gg/wiki/Automaton_Sensor "Automaton Sensor") is a variant with the same functionality and same recipe; you can build it only if you have purchased the [Automatons Pack](https://spaceengineers.wiki.gg/wiki/Automatons_Pack "Automatons Pack") DLC.

![](https://i.ytimg.com/vi/r29eQkru-F4/hqdefault.jpg)

Load video

## Usage

Sensors are useful for base automation: Use them to control autonomous drone behaviour, open and close airlocks and hangar doors, toggle motion detection lights, protect players from lethal grinders, and enforce security (proximity alerts, traps).

You can set the Sensor's detection range to up to 50 meters in any direction.

The short version of the usage is:

1.  Place the sensor.
2.  Open its [Control Panel Screen](https://spaceengineers.wiki.gg/wiki/Control_Panel_Screen "Control Panel Screen").
3.  Enter the detection range.
4.  Set up which targets to detect.
5.  Select which actions to trigger.

### Usage examples

*   Detect friendly players and automatically open doors.
*   Detect hostile players and spring a trap.
*   Automatically de- and re-pressurize the airlock to save oxygen.
*   Make a [PBW](https://spaceengineers.wiki.gg/wiki/Player_Built_Weapons "Player Built Weapons") detect the proximity of the enemy ships and ignite a warhead.
*   Make a station detect an approaching friendly drone and open the hangar doors.
*   Make a construction ship detect players in range of its lethal grinder/welder and automatically switch off.
*   Make a 3D printer welder detect the proximity of the grid being welded and withdraw the welder arms a bit to not collide when proceeding.

Sensors can also switch off and on other sensors, which is useful in a longer action sequence: Use them to prevent a sequence from starting too early while the first one is ongoing. This is relevant, for example, for automatic airlocks or docking sequences.

### How many sensors do I need?

*   To trigger _the same actions_ for different targets in the same range, you can use the same sensor.
*   To trigger _different actions_ for different targets in the same range, set up _separate_ sensors, one for each action.
*   To trigger actions for targets in _different ranges_, set up _separate_ sensors, one for each range.

### How to set up the range

You can place the sensor any way round you want and it will work. It's easier to configure facing forward, because then the directional labels make sense. Interpret the directional labels in the control panel relative to where the _sensor_ is facing, and not where _you_ are facing.

1.  To make the detection ranges visible, open the [Info Screen](https://spaceengineers.wiki.gg/wiki/Info_Screen "Info Screen") and enable **Show sensors field range**.
2.  Open the sensor's [Control Panel Screen](https://spaceengineers.wiki.gg/wiki/Control_Panel_Screen "Control Panel Screen") and enable **Show on [HUD](https://spaceengineers.wiki.gg/wiki/HUD "HUD")**.
3.  Define the extend of the detection range in six directions: left, right, top, bottom, back, front.

The minimum extend is a 0.1 metre cube around the sensor. The largest extend is 50m.

### Whose proximity can it detect?

You can set up sensors to detect any combination of the following:

*   [players](https://spaceengineers.wiki.gg/wiki/Space_Engineer "Space Engineer") (not seated!)
    *   owner, friendly, neutral, or enemy
*   small ships and small blocks
*   large ships and large blocks
*   floating objects (scrap, ores, tools, ammo, and materials)
*   stations and platforms
*   subgrids
*   asteroids (including voxel ground on planets)

**Caveats:** Players inside [cockpit](https://spaceengineers.wiki.gg/wiki/Cockpit "Cockpit") blocks or cryopods or (control or toilet) seats are _not detected_ as players! Sensors only detect players on foot or jetpacking. Sitting down will disrupt the detection.[\[1\]](#cite_note-1) See also the related [SEAT mod](https://steamcommunity.com/sharedfiles/filedetails/?id=2668367298&searchtext=).

#### How to detect ship damage

To detect damage to or grinding of specific functional blocks, use an [Event Controller](https://spaceengineers.wiki.gg/wiki/Event_Controller "Event Controller") instead.

To detect weapon or collision damage to armor: When blocks are destroyed, they drop floating  [![Icon Item Scrap Metal.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Item_Scrap_Metal.png/21px-Icon_Item_Scrap_Metal.png?9b5187)](https://spaceengineers.wiki.gg/wiki/Scrap_Metal "Scrap Metal") [Scrap Metal](https://spaceengineers.wiki.gg/wiki/Scrap_Metal "Scrap Metal"), which is an indicator of damage even after the blocks are gone.

Build several sensors and make their ranges cover sections of your ship that can be quickly inspected by an engineer in one go (e.g. one room, one hallway), including walls, floors, ceilings, overlaps with walls of neighbouring rooms are possible.

Set the sensors up to detect "floating objects" and set up the trigger to switch on a labelled red warning light. If one or more warnings light up, you know there is damage in that room, or between these two rooms.

See also [How to build warning lights](https://spaceengineers.wiki.gg/wiki/How_to_build_warning_lights "How to build warning lights").
