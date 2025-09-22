---
title: "Custom Turret Controller"
url: "https://spaceengineers.wiki.gg/wiki/Custom_Turret_Controller"
category: "Weapons"
wiki_page: "Custom Turret Controller"
includes_blocks: true
---

# Custom Turret Controller - Official Space Engineers Wiki

| Custom Turret Controller |     |
| --- | --- |
| [![Icon Block Custom Turret Controller.png](https://spaceengineers.wiki.gg/images/7/70/Icon_Block_Custom_Turret_Controller.png?49af70)](https://spaceengineers.wiki.gg/wiki/File:Icon_Block_Custom_Turret_Controller.png) |     |
| * * * |     |
| **Function:** | The Custom Turret Controller is capable of providing AI behavior to... |
| **DLC?** | Vanilla |
| * * * |     |
| **Fits small grid** |     |
| Mass: | 250.0 kg |
| Hitpoints: | 871 |
| Range: | 600 m |
| PCU: | 100 |
| Size: | 1x1x2 |
| Time to Build: | 10 sec |
| * * * |     |
| **Fits large grid** |     |
| Mass: | 948.0 kg |
| Hitpoints: | 3490 |
| Range: | 800 m |
| PCU: | 100 |
| Size: | 1x1x1 |
| Time to Build: | 24 sec |
| * * * |     |
| _Data Controls:_ | \[[purge](https://spaceengineers.wiki.gg/wiki/Custom_Turret_Controller?action=purge)\] ([?](https://spaceengineers.wiki.gg/wiki/Template:Info_Block))) |
|     |     |

The Custom Turret Controller (CTC) lets you aim custom turrets and control robot arms or cranes with your mouse. Secondarily, it can automatically aim custom turrets and align solar panels for you. The CTC only makes sense used together with a custom turret: a weapon/tool block on a hinge on a rotor.

![](https://i.ytimg.com/vi/q25AVvbDcsE/hqdefault.jpg)

Load video

## Usage

[![](https://spaceengineers.wiki.gg/images/thumb/1/1b/Station_defense_using_custom_turret_controllers.png/320px-Station_defense_using_custom_turret_controllers.png?be7fd5)](https://spaceengineers.wiki.gg/wiki/File:Station_defense_using_custom_turret_controllers.png)

Example of custom turret: Block weapons on a hinge on a rotor on a station

You can control the custom turret or arm manually, or use the game's built-in automatic AI ("artificially intelligent") targeting.

### Manual versus automatic

When used manually:

*   The Controller lets you control a [wrist-like movement of a custom subgrid "arm"](https://spaceengineers.wiki.gg/wiki/Mechanical_Blocks "Mechanical Blocks") with your mouse.
*   The Controller lets you activate blocks by mouse click:
    *   Any static [Block Weapons](https://spaceengineers.wiki.gg/wiki/Block_Weapons "Block Weapons")
    *   Any [Block Tools](https://spaceengineers.wiki.gg/wiki/Block_Tools "Block Tools") such as [drills](https://spaceengineers.wiki.gg/wiki/Drill "Drill"), [welders](https://spaceengineers.wiki.gg/wiki/Welder_Block "Welder Block"), [grinders](https://spaceengineers.wiki.gg/wiki/Grinder_Block "Grinder Block")
    *   Searchlights (spotlights)
    *   Observation [cameras](https://spaceengineers.wiki.gg/wiki/Camera "Camera")
    *   Magnetic [Landing Gear](https://spaceengineers.wiki.gg/wiki/Landing_Gear "Landing Gear"), [Collectors](https://spaceengineers.wiki.gg/wiki/Collector "Collector"), [Connectors](https://spaceengineers.wiki.gg/wiki/Connector "Connector") and more...

In automatic mode:

*   The AI can aim block tools at chosen targets (stations, ships, players)
*   The AI can lock block weapons on to specific subsystems (weapons, propulsion, or power).

From the Automaton update on, while flying/driving, the pilot is able to take manual control of a Custom Turret with the mouse, and still steer the ship/rover with the WASD keys, just as when controlling [Block Weapons](https://spaceengineers.wiki.gg/wiki/Block_Weapons "Block Weapons").

### Pros and cons

Advantages of CTC:

*   You can build a custom turret out of any blocks (weapons or tools) you like, even multiple together.
*   A CTC is best for performing wrist-like movements with one hinge and one rotor.

Disadvantages of CTC:

*   Custom turrets are bulkier and have more weak points than vanilla block weapons.
*   Custom turrets are much slower to build and repair, because projectors and [3D Printers](https://spaceengineers.wiki.gg/wiki/3D_Printer "3D Printer") cannot project grids with rotor/hinge subgrids.
*   If you want to combine more than two mechanical blocks, or pistons, you still need to either configure the [Tool Bar](https://spaceengineers.wiki.gg/wiki/Tool_Bar "Tool Bar") or use a script.

### Control Panel Screen

**LCD Panels**

*   The large-grid block has 4 [configurable](https://spaceengineers.wiki.gg/wiki/LCD_Surface_Options "LCD Surface Options") displays built in that you can optionally configure. Three are quite small and one is big. Select the LCD that you want to configure.
*   **Content** - For each LCD, select either **No content**, **Apps**, or **Text and Images**. For details, see [LCD Surface Options](https://spaceengineers.wiki.gg/wiki/LCD_Surface_Options "LCD Surface Options").  
    For example, set the large screen to Apps > Target Information.

Configure the CTC movement:

1.  **Assigned Azimuth Rotor** - Select the Rotor that turns left/right.
2.  **Assigned Elevation Rotor** - Select the Hinge that turns up/down.
3.  **Assigned Camera** - Select the Camera, e.g. for solar tracking.
4.  **Available Tools and Weapons** - (Optional) Select a tool or weapon and click **Add Tool or Weapon** to make the CTC control it.
5.  **Selected Tools and Weapons** - (Optional) Select a tool or weapon and click **Remove Tool or Weapon** to make the CTC stop controlling it.
6.  **Azimuth velocity multiplier** -- How fast the turret turns (rotor). Default is 9.0.
7.  **Elevation velocity multiplier** -- How fast turret tilts (hinge). Default is 9.0.
8.  **Angle deviation** -- How tolerant the automatic aiming should be. Default is 5.0.  
    
9.  **Enable AI** - Keep AI switched off for manual control, or switch it on for automatic AI aiming behaviour.

Only if **Enable AI** is active:

1.  Click **Set up Actions**.
    *   To the first slot, assign the actions that triggers when the AI detects its target.
    *   To the second slot, assign the actions that triggers when the AI detects no target.
2.  **Enable Target Locking** - Enable this if you want to coordinate several AI turrets. For details, see [Target Locking](https://spaceengineers.wiki.gg/wiki/Target_Locking "Target Locking").
3.  **Focus Locked Target** - Prioritize locked target. For details, see [Target Locking](https://spaceengineers.wiki.gg/wiki/Target_Locking "Target Locking").

Select either a camera or a block weapon or block tool if you want to use automatic (AI) aiming.

Only for solar tracking:

1.  **Assigned Camera** - Select the Camera used for aiming.
2.  **Always aim at sun** - Enable this to make the turret's camera (and attached solar panels) follow the sun.

Only for Weapons ond Tools:

1.  **Available Tools and Weapons** - To let the turret AI control a tool or weapon, or to activate them manually by clicking: Select a tool or weapon and click **Add Tool or Weapon**. They now appear on the **Selected Tools and Weapons** list.
    *   If you add more than one manual tool or weapon, add their on/off action to your toolbar as well.
2.  **Selected Tools and Weapons** - To remove a tool or weapon, select it in this list, and click **Remove Tool and Weapon**.
3.  **Target Options** - The CTC has the same AI aiming settings as a [Block Weapon](https://spaceengineers.wiki.gg/wiki/Block_Weapons "Block Weapons"), so see there for details. Choose one block type to attack:
    *   Default
    *   Weapons
    *   Propulsion
    *   Power systems
