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

### How to get varied comms chitchat

Seeing the same "Welcome back!" chat message every day gets boring fast. You can provide a variety of comms chitchat for each event and play them in a random order.

1.  Build one BC per topic or event.
2.  Enter up to eight paraphrases of one topic in each BC.  
    For example, one block with 8 different greetings, one with 8 different "enemy detected" warnings, one with 8 different trade offers.
3.  Then set up the Event Controller to trigger the "Send Random Message" action when the event is detected.

## How to mute a BC

It can be annoying if a BC triggers too often and "spams" chat. To silence all BCs fast, open the [Options](https://spaceengineers.wiki.gg/wiki/Options "Options"), go to the Game settings, and enable the **Mute Broadcast Controllers** option.

To selectively mute only certain BCs, first identify the BC's owner:

1.  Look at the chat, the BC messages are prefixed with the owner name, here, Red Engineer:  
    `(Red Engineers) Buddy Bot: Don't leave me!`
2.  To mute all messages from this player, press [RETURN key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings") to open the chat and enter:  
    `/m "Red Engineer"`
3.  To unmute the player, press [RETURN key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings") to open the chat and enter:  
    `/u "Red Engineer"`

![](https://i.ytimg.com/vi/1eRbIUndiFs/hqdefault.jpg)

Load video

### Troubleshooting

*   Error: No messages stored.  
    Using this block makes sense only if you enter at least one message.
*   Error: No antenna found.  
    If Use Antenna is enabled, you must have an antenna on the same grid.

### Official tutorial

[https://www.spaceengineersgame.com/new-players/broadcast-controller-action-relay-guide/](https://www.spaceengineersgame.com/new-players/broadcast-controller-action-relay-guide/)

## Construction

This block has a compact 1x1x1-blocks size on large and small grid and has mount points on all six sides. The components needed are readily available in early game using a Basic Assembler, or you loot the needed [Radio-comm Components](https://spaceengineers.wiki.gg/wiki/Radio-comm_Comp. "Radio-comm Comp.") from [Unknown Signals](https://spaceengineers.wiki.gg/wiki/Unknown_Signals "Unknown Signals"). Decide whether you need an antenna on the same grid, or whether the messages are only relevant to seated players.

## Recipe

| [![Icon Block Broadcast Controller.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Block_Broadcast_Controller.png/21px-Icon_Block_Broadcast_Controller.png?d351d9)](https://spaceengineers.wiki.gg/wiki/Broadcast_Controller "Broadcast Controller") Broadcast Controller |     |     |     |     |
| --- | --- | --- | --- | --- |
| Component | Large Ship/Station  <br>Required | Large Ship/Station  <br>Optional | Small Ship  <br>Required | Small Ship  <br>Optional |
| [![Icon Item Radio-comm Comp..png](https://spaceengineers.wiki.gg/images/thumb/Icon_Item_Radio-comm_Comp..png/21px-Icon_Item_Radio-comm_Comp..png?d5a95f)](https://spaceengineers.wiki.gg/wiki/Radio-comm_Comp. "Radio-comm Comp.") [Radio-comm Comp.](https://spaceengineers.wiki.gg/wiki/Radio-comm_Comp. "Radio-comm Comp.") | 5   | —   | 1   | —   |
| [![Icon Item Interior Plate.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Item_Interior_Plate.png/21px-Icon_Item_Interior_Plate.png?d80f8e)](https://spaceengineers.wiki.gg/wiki/Interior_Plate "Interior Plate") [Interior Plate](https://spaceengineers.wiki.gg/wiki/Interior_Plate "Interior Plate") | 10  | —   | 2   | —   |
| [![Icon Item Display.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Item_Display.png/21px-Icon_Item_Display.png?a444bc)](https://spaceengineers.wiki.gg/wiki/Display "Display") [Display](https://spaceengineers.wiki.gg/wiki/Display "Display") | 4   | —   | 1   | —   |
| [![Icon Item Construction Comp..png](https://spaceengineers.wiki.gg/images/thumb/Icon_Item_Construction_Comp..png/21px-Icon_Item_Construction_Comp..png?cdc26f)](https://spaceengineers.wiki.gg/wiki/Construction_Comp. "Construction Comp.") [Construction Comp.](https://spaceengineers.wiki.gg/wiki/Construction_Comp. "Construction Comp.") | 20  | 10  | 2   | 1   |
| [![Icon Item Computer.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Item_Computer.png/21px-Icon_Item_Computer.png?65c1a4)](https://spaceengineers.wiki.gg/wiki/Computer "Computer") [Computer](https://spaceengineers.wiki.gg/wiki/Computer "Computer") | 10  | —   | 2   | —   |