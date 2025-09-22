---
title: "Remote Access Screen"
url: "https://spaceengineers.wiki.gg/wiki/Remote_Access_Screen"
category: "Flight"
wiki_page: "Remote Access Screen"
includes_environment: true
includes_blocks: true
---

# Remote Access Screen - Official Space Engineers Wiki

Remote Access is a way for players to interact with owned _remote_ [grids](https://spaceengineers.wiki.gg/wiki/Grid "Grid"), such as drones or remote bases. Contrast this with owned _connected_ grids, docked to your base or carrier through [Merge Blocks](https://spaceengineers.wiki.gg/wiki/Merge_Block "Merge Block") or [Connectors](https://spaceengineers.wiki.gg/wiki/Connector "Connector"), with which you interact directly using the [Control Panel Screen](https://spaceengineers.wiki.gg/wiki/Control_Panel_Screen "Control Panel Screen").

Both the sending and the receiving grid must have a ([Laser](https://spaceengineers.wiki.gg/wiki/Laser_Antenna "Laser Antenna")) [Antenna](https://spaceengineers.wiki.gg/wiki/Antenna "Antenna") for Remote Access to work.

Remote Access cannot be automated through [Timer Block](https://spaceengineers.wiki.gg/wiki/Timer_Block "Timer Block") actions or the [Toolbar](https://spaceengineers.wiki.gg/wiki/Tool_Bar "Tool Bar").

![](https://i.ytimg.com/vi/GuK9X0FcgtU/hqdefault.jpg)

Load video

## Examples of Remote Connections

*   [Remotely control](https://spaceengineers.wiki.gg/wiki/Remote_Control "Remote Control") cockpit-less repair drones, spy drones, or defense drones.
*   Check in on the status of your asteroid facility inventory or a neighbouring base's terminal using a fixed [Laser Antenna](https://spaceengineers.wiki.gg/wiki/Laser_Antenna "Laser Antenna").
*   Access security [cameras](https://spaceengineers.wiki.gg/wiki/Camera "Camera") of outposts
*   Manually control turrets of outposts

## Remote Access Screen

You open the **Remote Access screen** through a separate button above the tabs in the [Terminal](https://spaceengineers.wiki.gg/wiki/Terminal "Terminal"). The [keyboard shortcut](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings") to open the Remote Access Screen is [SHIFT+K key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings").

[![The Remote Access button in the Terminal is separate from the tabs because it does neither apply to the grid nor the player, but to other grids.](https://spaceengineers.wiki.gg/images/Remote_Access_Screen_2024.png?4c06a0)](https://spaceengineers.wiki.gg/wiki/File:Remote_Access_Screen_2024.png "The Remote Access button in the Terminal is separate from the tabs because it does neither apply to the grid nor the player, but to other grids.")

To the right of the **Remote Access** button, there's a menu listing grids in range:

*   If no owned remote grid is in range, this menu contains your name (your suit antenna).
*   If remote grids qualify, they are listed here and you can access their Terminals.
*   If an owned remote grid has no antenna, or is out of power, or is out if range, or is docked to another grid, it is not listed.

At minimum, the menu contains the Terminal of the local grid you are seated in, and the player's own Terminal.

## Requirements

|     |     |     |
| --- | --- | --- |Remote Access Checklist
| Local Grid | Requirements | Remote Grid |
| ☑   | Owned by you or shared with you? | ☑   |
| ☑   | Has antenna? | ☑   |
| ☑   | Antenna is set to broadcast? | ☑   |
| ☑   | Antenna ranges reach each other? | ☑   |
| ☑   | Is powered? | ☑   |

Optional: If you want to use the **Control** action for steering, the remote grid must have a [Remote Control](https://spaceengineers.wiki.gg/wiki/Remote_Control "Remote Control") block.

Tip: Your [space engineer’s suit](https://spaceengineers.wiki.gg/wiki/Space_Engineer "Space Engineer") has a built-in 200m-range [antenna](https://spaceengineers.wiki.gg/wiki/Antenna "Antenna"); in emergencies and at close range, you can use Remote Access as the engineer, but it’s much more reliable while seated in a cockpit.

## How to Remotely Access Grids

[![The Remote Access screen in the Terminal](https://spaceengineers.wiki.gg/images/Remote_Access.png?884a75)](https://spaceengineers.wiki.gg/wiki/File:Remote_Access.png "The Remote Access screen in the Terminal")

In most cases, you will want to sit in a seat or cockpit. If you are within 200m, using the suit antenna also works.

1.  Enable broadcasting. Tip: Press [O key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings") to toggle.
2.  Press [K key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings") and open the **Remote Access Screen**.
3.  Select a remote grid.

In the **Remote Access Screen**, you can view the following information and access the following interactions:

*   **Name**  
    Hover the mouse pointer over a truncated name to see the full name in a tooltip.
*   **Distance**  
    How far away the grid is from you in metres.
*   **Status**  
    Shows three properties of remote grids that must be ready before you can remote control it:
    *   `Connection stable` or `Cannot establish connection to this grid`
    *   `Remote control ready` or `No Remote Control on grid`
    *   `Ownership Correct` or `Wrong ownership settings` (plus a list of affected blocks)
*   **Open Terminal** button  
    If two of the conditions are met (connection stable and ownership correct), click this to access the remote grid's Terminal.
*   **Take Control** button  
    If all three conditions are met, click this to remotely steer the grid.

Tip: Read more about how to steer and use remote [cameras](https://spaceengineers.wiki.gg/wiki/Camera "Camera") in the [Remote Control](https://spaceengineers.wiki.gg/wiki/Remote_Control "Remote Control") article.

## Troubleshooting

### How to find the grid in the list

Remember, you're looking for the grid name, not for the antenna name. Even if one grid has more than one antenna, it's still only listed _once_.

*   Problem: Is the remote grid that you are looking for docked via a [Merge Block](https://spaceengineers.wiki.gg/wiki/Merge_Block "Merge Block") or [Connector](https://spaceengineers.wiki.gg/wiki/Connector "Connector")? Connected grids' antennas do not show up separately in the list of remote grids!
*   Solution: Connect to the parent grid and use the terminal to unlock the child grid. This situation is one of the reasons why it's recommended to [prefix the names of blocks with their ship ID](https://spaceengineers.wiki.gg/wiki/Control_Panel_Screen "Control Panel Screen"), so you can orientate yourself in the remote terminal.

If you still cannot find the grid listed, try the following:

*   Did you actually name it or is it still called "Small Grid 1234"?
*   Open the [Info Screen](https://spaceengineers.wiki.gg/wiki/Info_Screen "Info Screen") to check the antenna ranges on both sides. Often the remote antenna can reach _you_, but your suit antenna can't reach _it_.
*   Ensure you have enough power to maintain a long-range broadcast on both sides. Optimally, be seated in a powered grid.
