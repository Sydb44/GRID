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

### How to fly the path

Tip: If the drone is docked at a connector, sit in another cockpit. Press G and put the drone's AI Blocks' **AI Behavior on/off** and **Block on/off** actions on your toolbar. Also put the drone's AI Recorder's **Play On/Off** and other actions on your toolbar.

1.  Enable **AI Behavior** on the AI Move block.
2.  Press **Play** on the AI Recorder block.

This switches the recorded AI behavior on. If the drone is not at waypoint 0, it will first fly towards waypoint 0, and then follow the waypoints.

Optional Settings:

*   Switch **Repeat** on to fly along the path in a loop, similar to the [Autopilot](https://spaceengineers.wiki.gg/wiki/Autopilot "Autopilot")'s "circle" flight mode.
*   Click **Reverse Order** to sort the waypoints backwards[\[1\]](#cite_note-1).

### Troubleshooting

If you need more control over how the drone travels through segments of the path, select a waypoint and click **Set up Action** to toggle the AI Flight block's **Collision Avoidance** on/off or **Precision Mode** on/off.

You can retroactively add any actions such as (un)locking Landing Gear/Connectors or thruster or gyroscope overrides. And don't forget you can use [Timers](https://spaceengineers.wiki.gg/wiki/Timer_Block "Timer Block") to group, loop, or delay actions.

The drone forgets its reference beacon when copied&pasted from a blueprint! In each new drone, select the beacon again.

## Construction

If [Progression](https://spaceengineers.wiki.gg/wiki/Progression "Progression") is on, build a basic Assembler and some lighting block first to unlock this block. The block is 1x1x1 blocks in size and it exists for small and large grid. It has mount points on all sides.

Before placing it, look at the arrows on the sides to rotate it correctly: R faces right, L faces left, F faces front, "rear panel" faces backwards, and the icon faces up.

AI Blocks require 10 kW of power to work. The block is not expensive and can be built in early game, similar to an ore detector.

## Recipe

| [![Icon Block AI Recorder.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Block_AI_Recorder.png/21px-Icon_Block_AI_Recorder.png?51324b)](https://spaceengineers.wiki.gg/wiki/AI_Recorder "AI Recorder") AI Recorder |     |     |     |     |
| --- | --- | --- | --- | --- |
| Component | Large Ship/Station  <br>Required | Large Ship/Station  <br>Optional | Small Ship  <br>Required | Small Ship  <br>Optional |
| [![Icon Item Interior Plate.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Item_Interior_Plate.png/21px-Icon_Item_Interior_Plate.png?d80f8e)](https://spaceengineers.wiki.gg/wiki/Interior_Plate "Interior Plate") [Interior Plate](https://spaceengineers.wiki.gg/wiki/Interior_Plate "Interior Plate") | 20  | —   | 2   | —   |
| [![Icon Item Computer.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Item_Computer.png/21px-Icon_Item_Computer.png?65c1a4)](https://spaceengineers.wiki.gg/wiki/Computer "Computer") [Computer](https://spaceengineers.wiki.gg/wiki/Computer "Computer") | 20  | —   | 10  | —   |
| [![Icon Item Motor.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Item_Motor.png/21px-Icon_Item_Motor.png?4a2f3f)](https://spaceengineers.wiki.gg/wiki/Motor "Motor") [Motor](https://spaceengineers.wiki.gg/wiki/Motor "Motor") | 4   | —   | 2   | —   |
| [![Icon Item Detector Components.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Item_Detector_Components.png/21px-Icon_Item_Detector_Components.png?ec13ed)](https://spaceengineers.wiki.gg/wiki/Detector_Components "Detector Components") [Detector Components](https://spaceengineers.wiki.gg/wiki/Detector_Components "Detector Components") | 20  | —   | 4   | —   |
| [![Icon Item Construction Comp..png](https://spaceengineers.wiki.gg/images/thumb/Icon_Item_Construction_Comp..png/21px-Icon_Item_Construction_Comp..png?cdc26f)](https://spaceengineers.wiki.gg/wiki/Construction_Comp. "Construction Comp.") [Construction Comp.](https://spaceengineers.wiki.gg/wiki/Construction_Comp. "Construction Comp.") | 30  | —   | 5   | —   |
| [![Icon Item Steel Plate.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Item_Steel_Plate.png/21px-Icon_Item_Steel_Plate.png?437e3a)](https://spaceengineers.wiki.gg/wiki/Steel_Plate "Steel Plate") [Steel Plate](https://spaceengineers.wiki.gg/wiki/Steel_Plate "Steel Plate") | —   | 20  | —   | 2   |

1.  [↑](#cite_ref-1 "Jump up") In the Automaton Beta, the drone also flies rotated backwards, not sure if this is intended behaviour.