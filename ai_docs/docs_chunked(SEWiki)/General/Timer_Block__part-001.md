---
title: "Timer Block"
url: "https://spaceengineers.wiki.gg/wiki/Timer_Block"
category: "General"
wiki_page: "Timer Block"
includes_blocks: true
---

# Timer Block - Official Space Engineers Wiki

| Timer Block |     |
| --- | --- |
| [![Icon Block Timer Block.png](https://spaceengineers.wiki.gg/images/Icon_Block_Timer_Block.png?307e99)](https://spaceengineers.wiki.gg/wiki/File:Icon_Block_Timer_Block.png) |     |
| * * * |     |
| **Function:** | Timer blocks can be used to activate configured ship systems after ... |
| **DLC?** | Vanilla |
| * * * |     |
| **Fits small grid** |     |
| Mass: | 30.2 kg |
| Hitpoints: | 121 |
| PCU: | 25  |
| Size: | 1x1x1 |
| Time to Build: | 4 sec |
| * * * |     |
| **Fits large grid** |     |
| Mass: | 259.0 kg |
| Hitpoints: | 995 |
| PCU: | 25  |
| Size: | 1x1x1 |
| Time to Build: | 10 sec |
| * * * |     |
| _Data Controls:_ | \[[purge](https://spaceengineers.wiki.gg/wiki/Timer_Block?action=purge)\] ([?](https://spaceengineers.wiki.gg/wiki/Template:Info_Block))) |
|     |     |

The  [![Icon Block Timer Block.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Block_Timer_Block.png/21px-Icon_Block_Timer_Block.png?307e99)](https://spaceengineers.wiki.gg/wiki/Timer_Block "Timer Block") Timer Block is a block useful for automation of recurring actions, such as docking procedures or air lock cycles. Use the Block to remember a series of button pushes for you and replay them later. Timers are much easier to set up than a [Programmable Block](https://spaceengineers.wiki.gg/wiki/Programmable_Block "Programmable Block") because they require no [scripting](https://spaceengineers.wiki.gg/wiki/Scripting "Scripting") knowledge.

Tip: To understand timers, think of actions as "songs" and Timer blocks as "playlists". You make playlists for special occasions and choose to start, stop, pause, or loop songs.

## Usage

You set up the Delay time, looping behaviour, and actions using the grid's [Control Panel Screen](https://spaceengineers.wiki.gg/wiki/Control_Panel_Screen "Control Panel Screen"), or through the keypad on the front side of the large-grid Timer.

1.  Put your list of actions into the Timer block.
2.  Start the timer.
3.  The Timer waits a predetermined amount of time
4.  The Timer triggers the actions.

[![Different ways to use timer blocks](https://spaceengineers.wiki.gg/images/thumb/Timers.png/320px-Timers.png?451dc7)](https://spaceengineers.wiki.gg/wiki/File:Timers.png)

Automation: Timers can play, wait&play, and loop groups of block actions, similar to how playlists play songs.

### Possible Triggers

You start Timer blocks either manually by clicking a button in their [Control Panel Screen](https://spaceengineers.wiki.gg/wiki/Control_Panel_Screen "Control Panel Screen") or you set up certain other blocks to trigger the Timer:

*   For manual control, use [Tool Bar](https://spaceengineers.wiki.gg/wiki/Tool_Bar "Tool Bar") slots or a [Button Panel](https://spaceengineers.wiki.gg/wiki/Button_Panel "Button Panel") as triggers.
*   For autonomous automation, choose a [Sensor](https://spaceengineers.wiki.gg/wiki/Sensor "Sensor"), [AI Recorder](https://spaceengineers.wiki.gg/wiki/AI_Recorder "AI Recorder"), [Autopilot](https://spaceengineers.wiki.gg/wiki/Autopilot "Autopilot"), or [Event Controller](https://spaceengineers.wiki.gg/wiki/Event_Controller "Event Controller") as trigger.
*   For bulk automation, use another Timer block as trigger.
*   For loops, have the Timer restart itself.

### Possible Actions

Timers can trigger almost any block action the player can do through the [Tool Bar](https://spaceengineers.wiki.gg/wiki/Tool_Bar "Tool Bar").

Examples:

*   Extending or retracting pistons, turning rotors and hinges, opening or closing doors
*   Switching on or off lights / thrusters / power / beacon / handbrake / turrets...
*   Changing behaviours or targets of [Automaton](https://spaceengineers.wiki.gg/wiki/Automaton "Automaton") blocks, changing conditions of an [Event Controller](https://spaceengineers.wiki.gg/wiki/Event_Controller "Event Controller")
*   (Dis)arming a Warhead, (de)pressurizing a room's [Air Vent](https://spaceengineers.wiki.gg/wiki/Air_Vent "Air Vent"), (de)activating grinder/welder/drill blocks, (un)locking connectors or landing gear
*   Highlighting a block on the HUD (escape pods, emergency exits, block you are looking for to repair...)
*   Trigger a [Broadcast Controller](https://spaceengineers.wiki.gg/wiki/Broadcast_Controller "Broadcast Controller") to send a predefined status message or GPS in the chat.
*   Trigger an [Action Relay](https://spaceengineers.wiki.gg/wiki/Action_Relay "Action Relay") on a remote grid.

... and so on.

You can also select available actions from blocks on subgrids that are connected through a connector, and the respective actions are then only executed when the grid is connected.

### When NOT to use Timers

Timer blocks cannot perform any non-[Control Panel Screen](https://spaceengineers.wiki.gg/wiki/Control_Panel_Screen "Control Panel Screen") actions, this means:

*   Timers cannot steer vehicles or ships — use [Autopilot](https://spaceengineers.wiki.gg/wiki/Autopilot "Autopilot") or [Automatons](https://spaceengineers.wiki.gg/wiki/Automaton "Automaton") instead.
*   Timers cannot use handheld tools — use [block tools](https://spaceengineers.wiki.gg/wiki/Block_Tools "Block Tools") instead.
*   Timers cannot aim handheld weapons — use [Automatons](https://spaceengineers.wiki.gg/wiki/Automaton "Automaton") or [Custom Turret Controllers](https://spaceengineers.wiki.gg/wiki/Custom_Turret_Controller "Custom Turret Controller") with [block weapons](https://spaceengineers.wiki.gg/wiki/Block_Weapons "Block Weapons") instead.
*   Timers cannot place blocks — use a [projector](https://spaceengineers.wiki.gg/wiki/Projector "Projector") instead.
*   Timers are not precise by the millisecond — use [Scripting](https://spaceengineers.wiki.gg/wiki/Scripting "Scripting") instead.
*   Timers cannot connect through the [remote terminal](https://spaceengineers.wiki.gg/wiki/Remote_Access_Screen "Remote Access Screen") — use an [Action Relay](https://spaceengineers.wiki.gg/wiki/Action_Relay "Action Relay") or [Remote Timer mod](https://steamcommunity.com/sharedfiles/filedetails/?id=2441200245) instead.

Neither can Timers buy anything from a [Store](https://spaceengineers.wiki.gg/wiki/Store "Store"), nor trade, nor emote, nor push physical buttons, nor save [GPS](https://spaceengineers.wiki.gg/wiki/GPS "GPS") locations, nor perform similar player actions.
