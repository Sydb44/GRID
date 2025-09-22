---
title: "Broadcast Controller"
url: "https://spaceengineers.wiki.gg/wiki/Broadcast_Controller"
category: "General"
wiki_page: "Broadcast Controller"
includes_blocks: true
---

# Broadcast Controller - Official Space Engineers Wiki

| Broadcast Controller |     |
| --- | --- |
| [![Icon Block Broadcast Controller.png](https://spaceengineers.wiki.gg/images/Icon_Block_Broadcast_Controller.png?d351d9)](https://spaceengineers.wiki.gg/wiki/File:Icon_Block_Broadcast_Controller.png) |     |
| * * * |     |
| **Function:** | The Broadcast Controller transmits custom messages to players using... |
| **DLC?** | Vanilla |
| * * * |     |
| **Fits small grid** |     |
| Mass: | 46.4 kg |
| Hitpoints: | 142 |
| Power: | \-0.0001 MW |
| PCU: | 25  |
| Size: | 1x1x1 |
| Time to Build: | 6 sec |
| * * * |     |
| **Fits large grid** |     |
| Mass: | 344.0 kg |
| Hitpoints: | 1155 |
| Power: | \-0.0001 MW |
| PCU: | 25  |
| Size: | 1x1x1 |
| Time to Build: | 16 sec |
| * * * |     |
| _Data Controls:_ | \[[purge](https://spaceengineers.wiki.gg/wiki/Broadcast_Controller?action=purge)\] ([?](https://spaceengineers.wiki.gg/wiki/Template:Info_Block))) |
|     |     |

The Broadcast Controller (BC) can send text messages on the [Chat](https://spaceengineers.wiki.gg/wiki/Chat "Chat") channel like a player. No block could do that before the introduction of the Broadcast Controller in Update 1.204 in 2024. Trigger this block to notify players automatically of events that were detected by [Sensors](https://spaceengineers.wiki.gg/wiki/Sensor "Sensor"), [Event Controllers](https://spaceengineers.wiki.gg/wiki/Event_Controller "Event Controller"), Cockpit's [Target Lock](https://spaceengineers.wiki.gg/wiki/Target_Locking "Target Locking") detection, or trigger them through [Autopilot waypoints](https://spaceengineers.wiki.gg/wiki/Autopilot "Autopilot"), [buttons](https://spaceengineers.wiki.gg/wiki/Button_Panel "Button Panel"), or [timers](https://spaceengineers.wiki.gg/wiki/Timer_Block "Timer Block").

## Usage

Each Broadcast Controller can store and broadcast up to eight prerecorded text messages. It can send them either to its owner, to the owner's faction, or to the global channel.

Without an antenna on the same grid, only people _sitting_ in cockpits on the same grid can see the chat message. If you need to increase the range to include walking faction members or passers-by, tell the block to use an antenna on the grid.

### Usage Examples

*   Accompany every change detected by a Sensor or Event Controller with a status message in the chat: "Base low on fuel", "Ship batteries low", "Miner inventory full", etc.
*   Accompany drone AI status changes with a status message in chat: "I'm at the dock for repairs", "I'm charged and going on patrol", etc.
*   When AI Combat blocks or sensors detect incoming enemies, warn your faction quietly on the faction channel. Or advise them to not come closer on the global channel.
*   Detect incoming friendly or neutral ships and send them a welcome message on the global channel: "we are open for trade".
*   Triggering the emergency Jump Drive triggers a warning to all faction members to take a seat now.

### Control Panel Screen

To send messages to different recipients, you need to build separate BC blocks.

*   Broadcast target  
    Select one kind of recipient:
    *   Owner only
    *   Faction only
    *   Everyone
*   Use Antenna:
    *   To expand the broadcast range through an antenna on the grid, enable this option. Good for communicating with drones, faction scouts, or publicly with passers-by.
    *   To broadcast exclusively to players sitting in cockpits or control seats on the same grid, disable this option. Good for sharing strategic info internally only.
*   Custom Name:  
    The sender in chat is identified as the block owner plus this additional text. You cannot simply make it send messages under a stranger's name.
    *   Use this field to identify the grid that is reporting its status for context, for example, "Flight control", "Repair drone 17", "Fighter X7", "Station maintenance system", etc.
*   Message 1 to Message 8  
    Store between one and eight messages here to send. One-liners only.
*   Send Random Message  
    Makes the block send a random non-empty message. Use this to provide variety for one topic, e.g. eight different greetings.
*   Send GPS  
    Makes this block send a chat message containing the name of its owner, its own name, and its own GPS coordinates.
    *   Important: The configured recipients on the chat channel have to open their [GPS](https://spaceengineers.wiki.gg/wiki/GPS "GPS") window and double-click the new entry to save and name it!

### How a drone can report back its position

Build a drone with  [![Icon Block Broadcast Controller.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Block_Broadcast_Controller.png/21px-Icon_Block_Broadcast_Controller.png?d351d9)](https://spaceengineers.wiki.gg/wiki/Broadcast_Controller "Broadcast Controller") BC,  [![Icon Block Laser Antenna.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Block_Laser_Antenna.png/21px-Icon_Block_Laser_Antenna.png?ebf139)](https://spaceengineers.wiki.gg/wiki/Laser_Antenna "Laser Antenna") [Laser Antenna](https://spaceengineers.wiki.gg/wiki/Laser_Antenna "Laser Antenna"),  [![Icon Block Camera.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Block_Camera.png/21px-Icon_Block_Camera.png?a42a5a)](https://spaceengineers.wiki.gg/wiki/Camera "Camera") [Camera](https://spaceengineers.wiki.gg/wiki/Camera "Camera"), and  [![Icon Block Remote Control.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Block_Remote_Control.png/21px-Icon_Block_Remote_Control.png?e33c2d)](https://spaceengineers.wiki.gg/wiki/Remote_Control "Remote Control") [Remote Control](https://spaceengineers.wiki.gg/wiki/Remote_Control "Remote Control"). Set the BC to send messages only to its owner, through the paired laser antenna. Fly it into enemy territory to spy. When you find a good approach angle, trigger the drone's **Send GPS** action to mark the location for yourself.
