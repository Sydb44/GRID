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

### Which Reactions can be triggered?

Similar to [Timer Blocks](https://spaceengineers.wiki.gg/wiki/Timer_Block "Timer Block") and [Sensors](https://spaceengineers.wiki.gg/wiki/Sensor "Sensor"), any action that is available on the [Tool Bar](https://spaceengineers.wiki.gg/wiki/Tool_Bar "Tool Bar") for blocks on the same or a [connected](https://spaceengineers.wiki.gg/wiki/Connector "Connector")[\[2\]](#cite_note-2) grid can be triggered.

Click **Select Actions** to define two actions that are triggered when the condition is (or is not) met.

*   Use the first action slot to react to the event.
*   Use the second action slot to "reset" to the normal state.
*   Press ctrl 1-9 to get nine first and second toolbar slots.

**Tip:** You want to trigger more than one action? Put all actions into a [Timer Block](https://spaceengineers.wiki.gg/wiki/Timer_Block "Timer Block"), and set the the Event Controller actions to Timer Block Start/Stop.

Some actions set a value (e.g. "unlock") while others toggle (invert) the current state (e.g. "switch lock"). The game sometimes runs triggers twice which can throw off your system if you use the EC to invert settings instead of setting a value. One workaround is to use the first EC to watch an event and then switch a light on or off, and then use a second EC to watch the light.

### How to React to Events

1.  Build an Event Controller and open its Control Panel Screen.
2.  Choose from the **Event** list which event you want to monitor.
3.  (If applicable) Select your **Condition** for the event.  
    Example: "value is equal or greater than the threshold value".
4.  (If applicable) Enter the **Threshold** value of your condition.  
    Example: 0-100% for percentages, -360 to 360 for rotation, and so on.
5.  (For Block Events only) Choose blocks:
    1.  Search the list of applicable blocks on the grid.
    2.  Select blocks to monitor under **Available Blocks** and click **Add Blocks**.
    3.  To remove a block from monitoring, select it under **Selected Blocks** and click **Remove Blocks**.
6.  Click **Select Actions**.
    *   Assign to the first slot the action how to _react_ to the event.
    *   Assign to the second slot the action how to _reset after_ the event is over.
7.  (For Block Events only) Choose how many of your selected blocks must fulfil the condition:
    *   If _all_ blocks must fulfil the condition, enable **AND Gate**.
    *   If at least _one_ block must fulfil the condition, disable **AND Gate**.

### How many ECs will I need?

Be prepared to need one or two ECs for basic automation, and more for more complex chains of actions. Each "If value higher than this then do this, else do that" statement corresponds to one EC block and one or two Timers. Give them descriptive names so you can distinguish them.

You will typically accompany the ECs with several Timer blocks to group triggered actions that should happen together. In the end, your bridge will look like a mainframe server room and your drone will have a big brain in its skull.

### What's the status?

The EC block shows its status by changing the color of the lights on its front panel, similar to Timers.

*   Red means it's switched off or has no power
*   Green means it is ready and has power but no event condition has been set up
*   Blue means it's monitoring a configured event but the condition was not yet met
*   Cyan means an event has triggered an action

### Should I watch ALL blocks or ANY blocks?

For many events, you can monitor several blocks. In this case you need to tell the EC what exactly you mean:

*   Switch on reactors when _any one_ tank/battery is empty, or only when _all_ of them are empty?
*   Sound an alarm when _any_ weapon block is damaged, or only when _all_ of them are damaged?
*   Repressurise the room when _any_ of its doors get closed or when _all_ its doors have been closed?

And similar. You see the difference in meaning!

How to choose:

*   If _any chosen block_ meets the condition, I want the first action.  
    If _no chosen block_ meets the condition, I want the second action.  
    <= You should disable **AND Gate**
*   If _all chosen blocks_ meet the condition, then I want the first action.  
    If _some or no chosen blocks_ meet the condition, I want the second action.  
    <= You should enable **AND Gate**.

### History

Before Update 1.203, there used to be unexpected AND Gate behaviour so you may need to adjust some older block set-ups.

With AND Gate disabled, the EC originally did not monitor "the state" of these blocks like a logical formula. It just reacted to _events_ in the moment they happen [\[3\]](#cite_note-3).

Example: You had been monitoring if any of two doors are being opened:

1.  both A and B closed -> EC slot 2 triggers
2.  door A is opened -> EC slot 1 triggers
3.  door B is opened -> EC slot 1 triggers
4.  door A is closed -> EC slot 2 triggers?!

In both situation 2 and 4, one door was open and one was closed, but the EC reacted differently. It did not react to the _state_ that they were in (how many are open/closed), it reacted to the _event_ (one is opening or closing).
