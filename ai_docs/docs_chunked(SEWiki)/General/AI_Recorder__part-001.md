---
title: "AI Recorder"
url: "https://spaceengineers.wiki.gg/wiki/AI_Recorder"
category: "General"
wiki_page: "AI Recorder"
includes_blocks: true
---

# AI Recorder - Official Space Engineers Wiki

| AI Recorder |     |
| --- | --- |
| [![Icon Block AI Recorder.png](https://spaceengineers.wiki.gg/images/Icon_Block_AI_Recorder.png?51324b)](https://spaceengineers.wiki.gg/wiki/File:Icon_Block_AI_Recorder.png) |     |
| * * * |     |
| **Function:** | Type: TaskThis can record a path and action sequence. This path can... |
| **DLC?** | Vanilla |
| * * * |     |
| **Fits small grid** |     |
| Mass: | 156.0 kg |
| Hitpoints: | 486 |
| Power: | \-0.01 MW |
| PCU: | 25  |
| Size: | 1x1x1 |
| Time to Build: | 10 sec |
| * * * |     |
| **Fits large grid** |     |
| Mass: | 900.0 kg |
| Hitpoints: | 3460 |
| Power: | \-0.01 MW |
| PCU: | 25  |
| Size: | 1x1x1 |
| Time to Build: | 24 sec |
| * * * |     |
| _Data Controls:_ | \[[purge](https://spaceengineers.wiki.gg/wiki/AI_Recorder?action=purge)\] ([?](https://spaceengineers.wiki.gg/wiki/Template:Info_Block))) |
|     |     |

The AI Recorder is a functional [Automaton](https://spaceengineers.wiki.gg/wiki/Automaton "Automaton") block in Space Engineers for autonomous short-distance flight. Steer your drone _once_ manually and use this block as a flight path recorder. The recorder can not only log and follow a recorded selection of waypoints, but it is also able to record and replay key presses and toolbar actions, and remembers to trigger them when replaying the path.

The recorded path is made up of a series of waypoints, which are [GPS](https://spaceengineers.wiki.gg/wiki/GPS "GPS") coordinates.

*   For the drone to fly to fixed locations on planets, asteroids, or bases, use _global_ waypoints.
*   For the drone to orbit and return to a moving mothership, use _relative_ waypoints.

This AI block is of Type "Task" and it provides waypoints to AI Blocks of type "Move". For other Task blocks, see [AI Basic](https://spaceengineers.wiki.gg/wiki/AI_Basic "AI Basic").

![](https://i.ytimg.com/vi/SqZrD9tmH_E/hqdefault.jpg)

Load video

## Gallery

*   [![Debugging - Selected waypoints are shown in blue on the HUD](https://spaceengineers.wiki.gg/images/thumb/AI_Recorder_show_Selected_Waypoints_on_HUD.png/120px-AI_Recorder_show_Selected_Waypoints_on_HUD.png?493c27)](https://spaceengineers.wiki.gg/wiki/File:AI_Recorder_show_Selected_Waypoints_on_HUD.png "Debugging - Selected waypoints are shown in blue on the HUD")
    
    Debugging - Selected waypoints are shown in blue on the HUD
    
*   [![Auto Shuttle - Recorded flight path and waypoints visible on HUD](https://spaceengineers.wiki.gg/images/thumb/AI_Recorder_Flight_Path_on_HUD.png/120px-AI_Recorder_Flight_Path_on_HUD.png?f3076c)](https://spaceengineers.wiki.gg/wiki/File:AI_Recorder_Flight_Path_on_HUD.png "Auto Shuttle - Recorded flight path and waypoints visible on HUD")
    
    Auto Shuttle - Recorded flight path and waypoints visible on HUD
    
*   [![Auto Miner - Recorded flight path and waypoints visible on HUD](https://spaceengineers.wiki.gg/images/thumb/Auto_miner_with_ai_recorder_beacon.png/120px-Auto_miner_with_ai_recorder_beacon.png?42850c)](https://spaceengineers.wiki.gg/wiki/File:Auto_miner_with_ai_recorder_beacon.png "Auto Miner - Recorded flight path and waypoints visible on HUD")
    
    Auto Miner - Recorded flight path and waypoints visible on HUD
    

## Usage

### How to set up the AI Recorder

1.  Add an AI Move block to the grid, such as [AI Flight](https://spaceengineers.wiki.gg/wiki/AI_Flight "AI Flight").
2.  Add the AI Recorder block to the grid.
3.  Open the Control Panel for the AI Recorder.
4.  Choose either a local **Reference Beacon** or use global coordinates:
    *   To record waypoints in _global_ absolute space coordinates, click **Clear Selection** to make sure _no_ Reference Beacon is selected.
    *   To record waypoints _relative_ to a moving ship, select a Reference Beacon. When the reference beacon moves, or if you select a new beacon, the waypoints will adjust automatically!
5.  Choose the **Record Interval** for recording a new waypoint: Set a value from 1.7 sec to 30 sec.
    *   For a slow, precise, zigzaggy navigation, a lower value is better.
    *   For an unprecise but faster flight, a large value is better.
6.  Choose the **Minimal Distance** for recording a new waypoint: Set a value from 1 metre to 300 metres.
    *   For precise navigation in narrow caves or hallways, a lower value is better.
    *   For a fast straight flight with no obstacles, a large value is better.

### How to record a path

After you have configured the AI Recorder, use it to record waypoints by flying the path once yourself. Tip: Start and stop the path in a secure location, such as docked at a connector or landing pad.

1.  Build a temporary cockpit on the drone.
2.  Press [G key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings") and put the AI Recorder's **Add Waypoint**, **Record on/off**, and **Play on/off** and other actions on your toolbar.
3.  Press **Record** and start flying.  
    Waypoints, toolbar actions, key presses, and the drone's orientation are now recorded every time you exceed the Minimal Distance or the Record Interval.
4.  Add important waypoints manually, such as the precise docking position or important corner turns: Fly to the exact spot and activate **Add Waypoint** manually.
5.  Press **Stop** to save the recording.

### How to review the path

After recording, the Waypoints list contains the recorded path as a series of GPS coordinates.

1.  Add an [Antenna](https://spaceengineers.wiki.gg/wiki/Antenna "Antenna") to the drone and set it to **broadcast**.
2.  On the Control Panel for the AI Recorder, switch on **Show on HUD** and either **Show Path on HUD** or **Show Selected Points**.
3.  On the [Info Screen](https://spaceengineers.wiki.gg/wiki/Info_Screen "Info Screen") for the AI Recorder, enable **Show AI Functions**. (!)

This makes the flight path and waypoints visible in mid air.

Reviewing waypoints on your HUD is easier in [Creative Mode](https://spaceengineers.wiki.gg/wiki/Creative_Mode "Creative Mode")/[Spectator Mode](https://spaceengineers.wiki.gg/wiki/Spectator_Mode "Spectator Mode"); in Survival Mode, make sure you have a good vantage point.

Some tips:

*   If the drone is very slow because it has too many waypoints, click **Delete all Waypoints** to reset, increase the **Distance** and **Interval** settings, and record the path again with fewer waypoints.
*   If the drone cuts corners dangerously, it may have too few waypoints. In this case, click **Delete all Waypoints** to reset, decrease the **Distance** and **Interval** settings, and record the path again with more waypoints.
*   Since you cannot later manually re-order or insert waypoints afterwards, it's better to record too many waypoints and delete some, than to record too few.
*   Add actions to waypoints, such as toggling the [AI Flight](https://spaceengineers.wiki.gg/wiki/AI_Flight "AI Flight") block's Collision Detection / Precision Mode (see there).

When going through the waypoints list and deleting non-essential waypoints, note that the numbers are not unique identifiers, but just reflect the order.

*   In slow narrow turns, keep three waypoints: coming in, central, and coming out.
*   In straight path segments, keep one waypoint at the beginning and one at the end.
*   Delete unnecessary waypoints in the middle of flightpaths.
*   If the orientation of your drone is important for your task, manually make controlled turns over several waypoints.

Next, slim down your waypoint list and select unnecessary waypoints and delete them.

1.  To not accidentally include waypoints in a selection, click **Clear Selection** before multiselecting.
2.  Click to select a waypoint. Or hold shift to multiselect consecutive waypoints. Or ctrl-click to add individual waypoints to the selection.
3.  To deselect a selected waypoint, ctrl-click it.
4.  Then click **Delete Selected** to clean them off the list.

After you are satisfied with the cleaned-up recording, switch off **Show Path on HUD**/**Show Selected Points** and **Show AI Functions**, and remove the temporary cockpit from the drone.
