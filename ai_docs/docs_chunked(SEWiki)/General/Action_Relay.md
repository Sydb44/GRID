---
title: "Action Relay"
url: "https://spaceengineers.wiki.gg/wiki/Action_Relay"
category: "General"
wiki_page: "Action Relay"
includes_environment: true
includes_blocks: true
---

# Action Relay - Official Space Engineers Wiki

| Action Relay |     |
| --- | --- |
| [![Icon Block Action Relay.png](https://spaceengineers.wiki.gg/images/f/f7/Icon_Block_Action_Relay.png?349d81)](https://spaceengineers.wiki.gg/wiki/File:Icon_Block_Action_Relay.png) |     |
| * * * |     |
| **Function:** | Action Relay blocks, in conjunction with Antennas, can trigger acti... |
| **DLC?** | Vanilla |
| * * * |     |
| **Fits small grid** |     |
| Mass: | 84.4 kg |
| Hitpoints: | 377 |
| Power: | \-0.0005 MW |
| PCU: | 25  |
| Size: | 1x1x1 |
| Time to Build: | 6 sec |
| * * * |     |
| **Fits large grid** |     |
| Mass: | 802.0 kg |
| Hitpoints: | 3685 |
| Power: | \-0.0005 MW |
| PCU: | 25  |
| Size: | 1x1x1 |
| Time to Build: | 16 sec |
| * * * |     |
| _Data Controls:_ | \[[purge](https://spaceengineers.wiki.gg/wiki/Action_Relay?action=purge)\] ([?](https://spaceengineers.wiki.gg/wiki/Template:Info_Block))) |
|     |     |

The Action Relay is a block that lets you trigger actions _in other grids_ through an antenna. Think of it like a garage door opener or TV remote control.

Before the introduction of the Action Relay in Update 1.204 in 2024, it was (save for scripts or glitches) possible to trigger actions only on the _same_ grid.

## Usage

The Action Relay can trigger block actions from the [toolbar](https://spaceengineers.wiki.gg/wiki/Toolbar "Toolbar") as a Timer or Sensor can. For example it can open/close doors, switch on/off base turrets, activate AI blocks to call or send a drone, and many more.

The Action Relay block can do two things:

*   Receive a signal from another Action Relay and trigger an action on its own grid.
*   Send a signal to another Action Relay and trigger an action on this other grid.

Each Action Relay block stores one set of actions, and can be set to listen to one channel. This means you need to build one Action Relay block for each set of actions. The actions can be stored in Timer blocks.

*   Set Up Actions  
    Define a block action on the local grid that you want triggered when a signal is received.
*   Accept Signal From  
    Select either owner, faction, or all. The Action Relay will only respond to signals from certain senders. The safest is only allowing yourself or your faction. Allowing all may be appropriate, for example, as part of a trading or negotiation comms system for non-allied factions.
*   Channel  
    Default 1. It accepts values from 1 to 100. The actions are triggered when a signal is received from another Action Relay on this selected channel.
*   Send Signal  
    Click this button to send a signal on the configured channel manually.

## Usage Examples

*   Send a signal to temporarily switch off turrets in your station or mothership before you bring a captured enemy wreck in.
*   Recall drones back to the dock.
*   Dispatch defense drones while your are away from the base.
*   Call a drone to help you.
*   Close or open the hangar doors from your ship.
*   Recall a solar array or laser antenna satelite into the mothership or asteroid hideout.

And much more!

## Trivia

The Action Relay's working title used to be Transponder[\[1\]](#cite_note-1) and it's still called that in the game files.

## Construction

The 1x1x1 sized Action Relay has four mount points, top, bottom, and two sides. It has two terminal access [ports](https://spaceengineers.wiki.gg/wiki/Port "Port"), one on the front and one on the back. You can build it on large and small grids and subgrids.

Make sure the grid also has an [antenna](https://spaceengineers.wiki.gg/wiki/Antenna "Antenna") with the necessary range for it to work.

## Recipe

| [![Icon Block Action Relay.png](https://spaceengineers.wiki.gg/images/thumb/f/f7/Icon_Block_Action_Relay.png/21px-Icon_Block_Action_Relay.png?349d81)](https://spaceengineers.wiki.gg/wiki/Action_Relay "Action Relay") Action Relay |     |     |     |     |
| --- | --- | --- | --- | --- |
| Component | Large Ship/Station  <br>Required | Large Ship/Station  <br>Optional | Small Ship  <br>Required | Small Ship  <br>Optional |
| [![Icon Item Steel Plate.png](https://spaceengineers.wiki.gg/images/thumb/4/4c/Icon_Item_Steel_Plate.png/21px-Icon_Item_Steel_Plate.png?437e3a)](https://spaceengineers.wiki.gg/wiki/Steel_Plate "Steel Plate") [Steel Plate](https://spaceengineers.wiki.gg/wiki/Steel_Plate "Steel Plate") | 20  | 10  | 2   | 1   |
| [![Icon Item Radio-comm Comp..png](https://spaceengineers.wiki.gg/images/thumb/8/8e/Icon_Item_Radio-comm_Comp..png/21px-Icon_Item_Radio-comm_Comp..png?d5a95f)](https://spaceengineers.wiki.gg/wiki/Radio-comm_Comp. "Radio-comm Comp.") [Radio-comm Comp.](https://spaceengineers.wiki.gg/wiki/Radio-comm_Comp. "Radio-comm Comp.") | 5   | —   | 1   | —   |
| [![Icon Item Construction Comp..png](https://spaceengineers.wiki.gg/images/thumb/4/45/Icon_Item_Construction_Comp..png/21px-Icon_Item_Construction_Comp..png?cdc26f)](https://spaceengineers.wiki.gg/wiki/Construction_Comp. "Construction Comp.") [Construction Comp.](https://spaceengineers.wiki.gg/wiki/Construction_Comp. "Construction Comp.") | 20  | —   | 2   | —   |
| [![Icon Item Computer.png](https://spaceengineers.wiki.gg/images/thumb/7/72/Icon_Item_Computer.png/21px-Icon_Item_Computer.png?65c1a4)](https://spaceengineers.wiki.gg/wiki/Computer "Computer") [Computer](https://spaceengineers.wiki.gg/wiki/Computer "Computer") | 10  | —   | 2   | —   |

## References

1.  [↑](#cite_ref-1 "Jump up") Source: [Space Engineers Update Sneak Peek by Splitsie](https://www.youtube.com/watch?v=42xiOTDlpQw)