**Caveats:** Players inside [cockpit](https://spaceengineers.wiki.gg/wiki/Cockpit "Cockpit") blocks or cryopods or (control or toilet) seats are _not detected_ as players! Sensors only detect players on foot or jetpacking. Sitting down will disrupt the detection.[\[1\]](#cite_note-1) See also the related [SEAT mod](https://steamcommunity.com/sharedfiles/filedetails/?id=2668367298&searchtext=).

#### How to detect ship damage

To detect damage to or grinding of specific functional blocks, use an [Event Controller](https://spaceengineers.wiki.gg/wiki/Event_Controller "Event Controller") instead.

To detect weapon or collision damage to armor: When blocks are destroyed, they drop floating  [![Icon Item Scrap Metal.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Item_Scrap_Metal.png/21px-Icon_Item_Scrap_Metal.png?9b5187)](https://spaceengineers.wiki.gg/wiki/Scrap_Metal "Scrap Metal") [Scrap Metal](https://spaceengineers.wiki.gg/wiki/Scrap_Metal "Scrap Metal"), which is an indicator of damage even after the blocks are gone.

Build several sensors and make their ranges cover sections of your ship that can be quickly inspected by an engineer in one go (e.g. one room, one hallway), including walls, floors, ceilings, overlaps with walls of neighbouring rooms are possible.

Set the sensors up to detect "floating objects" and set up the trigger to switch on a labelled red warning light. If one or more warnings light up, you know there is damage in that room, or between these two rooms.

See also [How to build warning lights](https://spaceengineers.wiki.gg/wiki/How_to_build_warning_lights "How to build warning lights").

#### How to detect oxygen levels

If you need a sensor that triggers actions based on oxygen levels in a closed room, use an [Air Vent](https://spaceengineers.wiki.gg/wiki/Air_Vent "Air Vent") instead.

#### How to detect gunshots

If you need a sensor that detects if it was hit by weapon fire to trigger an action, use a [Target Dummy](https://spaceengineers.wiki.gg/wiki/Target_Dummy "Target Dummy") instead.

#### How to detect other events

To detect a broader variety of events, such as mechanical block positions or cargo fill levels and more, use an [Event Controller](https://spaceengineers.wiki.gg/wiki/Event_Controller "Event Controller") instead.

### How to set up actions

#### How to set up proximity alerts

The simplest sensor action is to enable the checkbox for "audible proximity alert". The sensor will audibly tick three times when it is triggered.

This option is helpful while testing (assuming you are in audible range) or to purposely alert players of the sensor's presence -- so they know its an automatic airlock, for example.

To mute the audible proximity alert, for example for a trap, disable this setting.

#### How to set up the sensor's actions

An action can be anything available for blocks in the [Control Panel Screen](https://spaceengineers.wiki.gg/wiki/Control_Panel_Screen "Control Panel Screen") of the same grid.

To define actions, click the **Set up Actions** button of the sensor.

A sensor has two action slots:

1.  In the left slot, assign the action to trigger when the target _enters_ the range.
2.  In the right slot, assign the action to trigger when the target _leaves_ the range.

To set up an action for a slot, search for the block, [![Right](https://commons.wiki.gg/images/thumb/Keyboard_White_Mouse_Right.png/20px-Keyboard_White_Mouse_Right.png?3581de)](https://spaceengineers.wiki.gg/wiki/File:Keyboard_White_Mouse_Right.png "Right")\-click the block icon, and select the action from the menu.

To change the action to trigger, but keep the selected block, [![Right](https://commons.wiki.gg/images/thumb/Keyboard_White_Mouse_Right.png/20px-Keyboard_White_Mouse_Right.png?3581de)](https://spaceengineers.wiki.gg/wiki/File:Keyboard_White_Mouse_Right.png "Right")\-click the slot and select a new action from the menu.

To reset the action and the block, [![Right](https://commons.wiki.gg/images/thumb/Keyboard_White_Mouse_Right.png/20px-Keyboard_White_Mouse_Right.png?3581de)](https://spaceengineers.wiki.gg/wiki/File:Keyboard_White_Mouse_Right.png "Right")\-click the slot and select **Remove from Toolbar**.

You can assign actions to either one or both slots, or leave them empty. But you cannot assign the same action to both slots.

#### How to trigger up to 9 actions

To trigger up to nine actions, click **Set up actions**, press [CTRL key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings")+[1 key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings") to [9 key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings") to select one of nine toolbars with two slots each, and assign actions to these nine slots.

#### How to trigger 10 or more actions

Timer blocks can trigger up to 99 actions each, including triggering another timer.

To trigger more than nine actions:

1.  Build two [Timer Blocks](https://spaceengineers.wiki.gg/wiki/Timer_Block "Timer Block") (TB)
2.  Define up to 99 actions for when the target enters the range in one TB.
3.  Define up to 99 actions for when the target leaves the range in the other TB.
4.  Assign the respective Timer Start actions to one of the two sensor action slots.

#### How to repeat actions

The actions are triggered _once_ by the first detected target that enters or leaves, respectively. The action does not automatically repeat _while_ the condition is met.

To repeat actions:

1.  Build and set up Timers as just described.
2.  To create the loop, make the last action of one timer block re-start _itself_.
3.  To end the loop, make another sensor or another timer's last action stop the first timer.

### Is this thing on?

The sensor has a status indicator light:

*   When the Sensor light is red, the Sensor is switched off or unpowered, and does not detect anything.
*   When the light is green, the sensor is powered and ready to detect something (if anything was configured).
*   When the light is blue, it is detecting something and it has triggered actions (if any were set up).
