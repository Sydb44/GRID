
### When NOT to use Timers

Timer blocks cannot perform any non-[Control Panel Screen](https://spaceengineers.wiki.gg/wiki/Control_Panel_Screen "Control Panel Screen") actions, this means:

*   Timers cannot steer vehicles or ships — use [Autopilot](https://spaceengineers.wiki.gg/wiki/Autopilot "Autopilot") or [Automatons](https://spaceengineers.wiki.gg/wiki/Automaton "Automaton") instead.
*   Timers cannot use handheld tools — use [block tools](https://spaceengineers.wiki.gg/wiki/Block_Tools "Block Tools") instead.
*   Timers cannot aim handheld weapons — use [Automatons](https://spaceengineers.wiki.gg/wiki/Automaton "Automaton") or [Custom Turret Controllers](https://spaceengineers.wiki.gg/wiki/Custom_Turret_Controller "Custom Turret Controller") with [block weapons](https://spaceengineers.wiki.gg/wiki/Block_Weapons "Block Weapons") instead.
*   Timers cannot place blocks — use a [projector](https://spaceengineers.wiki.gg/wiki/Projector "Projector") instead.
*   Timers are not precise by the millisecond — use [Scripting](https://spaceengineers.wiki.gg/wiki/Scripting "Scripting") instead.
*   Timers cannot connect through the [remote terminal](https://spaceengineers.wiki.gg/wiki/Remote_Access_Screen "Remote Access Screen") — use an [Action Relay](https://spaceengineers.wiki.gg/wiki/Action_Relay "Action Relay") or [Remote Timer mod](https://steamcommunity.com/sharedfiles/filedetails/?id=2441200245) instead.

Neither can Timers buy anything from a [Store](https://spaceengineers.wiki.gg/wiki/Store "Store"), nor trade, nor emote, nor push physical buttons, nor save [GPS](https://spaceengineers.wiki.gg/wiki/GPS "GPS") locations, nor perform similar player actions.

## Usage: Play a group of actions

First, decide on a trigger (e.g. build a button panel), and build your Timer block. Each Timer block executes a group of actions that belong together and should always happen together.

### How many timer blocks will I need?

Answer: Lots. :-) One for each set of actions that happen together. If sets of actions are mutually exclusive, or if they only happen together some of the time, or if they must have pauses between them, or if one action must wait for another to complete, then you must build separate Timer blocks for them!

1.  Open the [Control Panel Screen](https://spaceengineers.wiki.gg/wiki/Control_Panel_Screen "Control Panel Screen").
2.  Go to the Trigger (the Sensor, Event Controller, Button Panel, etc.) controls and click **Set up Actions**.
3.  Click the Timer block and select “Start” from the action menu.
4.  Press [ESCAPE key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings") to return to the Control Panel Screen.
5.  Go to the Timer block controls and click **Set up Actions**.
6.  Click block icons to select actions, and assign them to slots. You can assign each action only once per toolbar.

### What if I want to add several of the same action?

I want to 3X "increase propulsion override", but it doesn't let me add it three times?

Answer: Remember that each Timer block can store 81 (nine times nine) actions! Press ctrl+1 to ctrl+9 to select another one of the nine toolbars. You can assign the same "increase propulsion override" action once to each of the nine toolbars. All toolbars will be triggered together. And if you create multiple [groups](https://spaceengineers.wiki.gg/wiki/Groups "Groups") containing the same block, you can even add actions for each group.

### When to use a Group and when a Timer?

I can [group](https://spaceengineers.wiki.gg/wiki/Groups "Groups") blocks in the [Control Panel Screen](https://spaceengineers.wiki.gg/wiki/Control_Panel_Screen "Control Panel Screen") and trigger an action on the group, or I can list these actions in a Timer. What's the difference?

This is relevant when you have [massproduced](https://spaceengineers.wiki.gg/wiki/3D_Printer "3D Printer") multiple ships from the same [blueprint](https://spaceengineers.wiki.gg/wiki/Blueprint "Blueprint") (same ship name, same group names, same block names) and they are docked in the same hangar: [Group names](https://spaceengineers.wiki.gg/wiki/Groups "Groups") are not unique. Group actions will trigger in all docked ships that are referencing the same group name.

So for non-unique ships (such as drones or [PBW](https://spaceengineers.wiki.gg/wiki/Player_Built_Weapons "Player Built Weapons")) that are docked at the same time, build a Timer in each drone to group its undock actions safely.

## Usage: Pause and Play actions

All the actions run inside a timer don't wait for each other's completion. If you are automating a _sequence_ of longer actions, you must enforce pauses in between. Examples: Playing two sound alerts one after the other without overlapping; or a docking sequence that waits for the hangar door to open; or an airlock cycle that waits for the room to depressurise.

1.  Split up the time-sensitive actions and put them into separate Timer blocks.
2.  Configure the **Delay** of the second timer to wait for the first timer to finish.
3.  Make the first timer start the second timer.
4.  Make the second timer start the third, and so on.

The Delay format is read as hours:minutes:seconds. The start-up delay of a timer block can be set to any value between 1 second (0:00:01) and 1 hour (1:00:00).

Note that Timers are not accurate with the timings of delays, so rather add a little extra time. When you control something very time sensitive (like the joints of a [walker](https://spaceengineers.wiki.gg/wiki/Walker "Walker")), don't trust Timer Blocks to coordinate punctually by the second, and they certainly cannot handle any timings of less than a second. A script in a [Programmable Block](https://spaceengineers.wiki.gg/wiki/Programmable_Block "Programmable Block") is more suitable when you need precision.

Also, Timers just literally wait the number of seconds you tell them, they don't confirm whether the previous action has truly completed or not -- e.g. if a door is blocked instead of closed, or a room cannot be pressurised because your tanks are empty, a Timer sequence may get messed up if you don't add checks.
