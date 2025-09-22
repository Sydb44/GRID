---
title: "AI Basic"
url: "https://spaceengineers.wiki.gg/wiki/AI_Basic"
category: "General"
wiki_page: "AI Basic"
includes_blocks: true
---

# AI Basic - Official Space Engineers Wiki

| AI Basic |     |
| --- | --- |
| [![Icon Block AI Basic.png](https://spaceengineers.wiki.gg/images/8/8b/Icon_Block_AI_Basic.png?da8697)](https://spaceengineers.wiki.gg/wiki/File:Icon_Block_AI_Basic.png) |     |
| * * * |     |
| **Function:** | Type: TaskThis can be used for basic, customizable AI tasks. It can... |
| **DLC?** | Vanilla |
| * * * |     |
| **Fits small grid** |     |
| Mass: | 156.0 kg |
| Hitpoints: | 486 |
| Power: | \-0.01 MW |
| PCU: | 15  |
| Size: | 1x1x1 |
| Time to Build: | 10 sec |
| * * * |     |
| **Fits large grid** |     |
| Mass: | 900.0 kg |
| Hitpoints: | 3460 |
| Power: | \-0.01 MW |
| PCU: | 15  |
| Size: | 1x1x1 |
| Time to Build: | 24 sec |
| * * * |     |
| _Data Controls:_ | \[[purge](https://spaceengineers.wiki.gg/wiki/AI_Basic?action=purge)\] ([?](https://spaceengineers.wiki.gg/wiki/Template:Info_Block))) |
|     |     |

The AI Basic block is a functional [Automaton](https://spaceengineers.wiki.gg/wiki/Automaton "Automaton") block in Space Engineers used for long-duration/long-distance autonomous flight. It's an extended version of the [Remote Control](https://spaceengineers.wiki.gg/wiki/Remote_Control "Remote Control") block that can follow a moving player or a moving ship, navigate to a destination, or perform the standard [Autopilot](https://spaceengineers.wiki.gg/wiki/Autopilot "Autopilot") functionality.

This AI Block is of type "Task" and calculates and provides waypoints to other AI blocks of type "Move". For other Task blocks, see [AI Recorder](https://spaceengineers.wiki.gg/wiki/AI_Recorder "AI Recorder").

![](https://i.ytimg.com/vi/SqZrD9tmH_E/hqdefault.jpg)

Load video

## Usage

### Requirements

In addition to the AI Basic block, build an [AI Flight](https://spaceengineers.wiki.gg/wiki/AI_Flight "AI Flight") block and configure it.

### How to teach a drone a flight path

1.  Switch off **AI Behavior**.
2.  Select one target towards which this drone should fly:
    *   Either **Follow Home**:
        1.  Select a GPS waypoint, or a base/ship's Antenna or Beacon, from the Home list.
        2.  Or click **Set Grid position** to create a GPS coordinate of the grid's location that can be used as the drone's home.
        3.  Or click **Set Player Position** to create a GPS coordinate of the player's location that can be used as the drone's home.
        4.  Set **Min. Range from Home** between 1 and 2500m. The drone will come at most this close to the base (good for avoiding towers).
        5.  Set **Max. Range from Home** between 1 and 2500m. The drone will not venture further away than this.
        6.  Enable **Wander while idle** to have the drone patrol autonomously within this range. To send the drone to a specific connector or dock waypoint, disable wandering.
    *   Or **Follow Player**:
        1.  Choose a **Follow Distance** between 0-500 metres. If the player moves away further than that, the drone will catch up. If the player approaches the drone to closer than that, the drone waits in place.
        2.  Click **Follow Me** to make it follow you (the player who clicked the button).
        3.  Or click **Stop Following** to make the drone stop following you.
    *   Or **Autopilot**:  
        It supports the same [Autopilot](https://spaceengineers.wiki.gg/wiki/Autopilot "Autopilot") features as the [RC](https://spaceengineers.wiki.gg/wiki/Remote_Control "Remote Control") block, so see there:
        *   [Flight Mode](https://spaceengineers.wiki.gg/wiki/Autopilot#Flight_modes "Autopilot")
        *   [Collision Avoidance](https://spaceengineers.wiki.gg/wiki/Autopilot#Collision_Avoidance "Autopilot")
        *   [Precision Mode](https://spaceengineers.wiki.gg/wiki/Autopilot#Precision_Mode "Autopilot")
3.  Switch on **AI Behavior** on the AI Basic block to start the autopilot.
4.  Switch on **AI Behavior** on the [AI Flight](https://spaceengineers.wiki.gg/wiki/AI_Flight "AI Flight") block.

### How to give commands quickly

For a low flying cargo or defense drone that follows the player close by, consider adding reachable buttons on the drone's hull so you can give it commands quickly, such as start/stop following. You second option is using the [Remote Access Screen](https://spaceengineers.wiki.gg/wiki/Remote_Access_Screen "Remote Access Screen") and an antenna.

## Construction

If [Progression](https://spaceengineers.wiki.gg/wiki/Progression "Progression") is on, build a Basic Assembler and some lighting block first to unlock this block.

The block is 1x1x1 blocks in size and it exists for small and large grid. It can attach to other blocks on all sides. Before placing it, look at the arrows on the sides and rotate correctly; R faces right, L faces left, F faces front, "rear panel" faces bckwards, and the icon faces up.

All AI Blocks require 10 kW of power to work. The block is not expensive and can be built in early game, similar to an ore detector.

## Recipe

| [![Icon Block AI Basic.png](https://spaceengineers.wiki.gg/images/thumb/8/8b/Icon_Block_AI_Basic.png/21px-Icon_Block_AI_Basic.png?da8697)](https://spaceengineers.wiki.gg/wiki/AI_Basic "AI Basic") AI Basic |     |     |     |     |
| --- | --- | --- | --- | --- |
| Component | Large Ship/Station  <br>Required | Large Ship/Station  <br>Optional | Small Ship  <br>Required | Small Ship  <br>Optional |
| [![Icon Item Steel Plate.png](https://spaceengineers.wiki.gg/images/thumb/4/4c/Icon_Item_Steel_Plate.png/21px-Icon_Item_Steel_Plate.png?437e3a)](https://spaceengineers.wiki.gg/wiki/Steel_Plate "Steel Plate") [Steel Plate](https://spaceengineers.wiki.gg/wiki/Steel_Plate "Steel Plate") | 20  | —   | 2   | —   |
| [![Icon Item Motor.png](https://spaceengineers.wiki.gg/images/thumb/2/2c/Icon_Item_Motor.png/21px-Icon_Item_Motor.png?4a2f3f)](https://spaceengineers.wiki.gg/wiki/Motor "Motor") [Motor](https://spaceengineers.wiki.gg/wiki/Motor "Motor") | 4   | —   | 2   | —   |
| [![Icon Item Interior Plate.png](https://spaceengineers.wiki.gg/images/thumb/7/77/Icon_Item_Interior_Plate.png/21px-Icon_Item_Interior_Plate.png?d80f8e)](https://spaceengineers.wiki.gg/wiki/Interior_Plate "Interior Plate") [Interior Plate](https://spaceengineers.wiki.gg/wiki/Interior_Plate "Interior Plate") | 20  | —   | 2   | —   |
| [![Icon Item Detector Components.png](https://spaceengineers.wiki.gg/images/thumb/e/e8/Icon_Item_Detector_Components.png/21px-Icon_Item_Detector_Components.png?ec13ed)](https://spaceengineers.wiki.gg/wiki/Detector_Components "Detector Components") [Detector Components](https://spaceengineers.wiki.gg/wiki/Detector_Components "Detector Components") | 20  | —   | 4   | —   |
| [![Icon Item Construction Comp..png](https://spaceengineers.wiki.gg/images/thumb/4/45/Icon_Item_Construction_Comp..png/21px-Icon_Item_Construction_Comp..png?cdc26f)](https://spaceengineers.wiki.gg/wiki/Construction_Comp. "Construction Comp.") [Construction Comp.](https://spaceengineers.wiki.gg/wiki/Construction_Comp. "Construction Comp.") | 30  | —   | 5   | —   |
| [![Icon Item Computer.png](https://spaceengineers.wiki.gg/images/thumb/7/72/Icon_Item_Computer.png/21px-Icon_Item_Computer.png?65c1a4)](https://spaceengineers.wiki.gg/wiki/Computer "Computer") [Computer](https://spaceengineers.wiki.gg/wiki/Computer "Computer") | 20  | —   | 10  | —   |