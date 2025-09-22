---
title: "Programmable Block"
url: "https://spaceengineers.wiki.gg/wiki/Programmable_Block"
category: "General"
wiki_page: "Programmable Block"
includes_blocks: true
---

# Programmable Block - Official Space Engineers Wiki

| Programmable Block |     |
| --- | --- |
| [![Icon Block Programmable Block.png](https://spaceengineers.wiki.gg/images/Icon_Block_Programmable_Block.png?9d067f)](https://spaceengineers.wiki.gg/wiki/File:Icon_Block_Programmable_Block.png) |     |
| * * * |     |
| **Function:** | A Programmable Block is a computer that runs scripts to manage ship... |
| **DLC?** | Vanilla |
| * * * |     |
| **Fits small grid** |     |
| Mass: | 138.4 kg |
| Hitpoints: | 427 |
| PCU: | 100 |
| Size: | 1x1x1 |
| Time to Build: | 8 sec |
| * * * |     |
| **Fits large grid** |     |
| Mass: | 534.4 kg |
| Hitpoints: | 2387 |
| PCU: | 100 |
| Size: | 1x1x1 |
| Time to Build: | 20 sec |
| * * * |     |
| _Data Controls:_ | \[[purge](https://spaceengineers.wiki.gg/wiki/Programmable_Block?action=purge)\] ([?](https://spaceengineers.wiki.gg/wiki/Template:Info_Block))) |
|     |     |

 **[![Icon Block Programmable Block.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Block_Programmable_Block.png/21px-Icon_Block_Programmable_Block.png?9d067f)](https://spaceengineers.wiki.gg/wiki/Programmable_Block "Programmable Block") Programmable Blocks** (short: PB) can execute C# scripts in game to automatically perform a multitude of game functions. If a [Timer Block](https://spaceengineers.wiki.gg/wiki/Timer_Block "Timer Block") or [Sensor](https://spaceengineers.wiki.gg/wiki/Sensor "Sensor") can't handle your task, a PB likely can. For a simpler, more user-friendly alternative, see also [Event Controller](https://spaceengineers.wiki.gg/wiki/Event_Controller "Event Controller"). The block’s secondary use is decorative.

## Usage

On PC, no mods are required to run programs. You either subscribe to [Scripts](https://spaceengineers.wiki.gg/wiki/Scripts "Scripts") on the [Workshop](https://spaceengineers.wiki.gg/wiki/Workshop "Workshop") or [write them yourself](https://spaceengineers.wiki.gg/wiki/Scripting "Scripting"). The script can run in a loop or can be triggered by a game event.

### Requirements

Before you can use  [![Icon Block Programmable Block.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Block_Programmable_Block.png/21px-Icon_Block_Programmable_Block.png?9d067f)](https://spaceengineers.wiki.gg/wiki/Programmable_Block "Programmable Block") Programmable Blocks, check the following requirements:

*   Scripts run only on PC (Steam, Microsoft Store) and Dedicated Servers, not on consoles.
*   Scripts run only if [Experimental mode](https://spaceengineers.wiki.gg/wiki/Experimental_mode "Experimental mode") is enabled in the [Options](https://spaceengineers.wiki.gg/wiki/Options "Options").
*   Scripts run only if **in-game scripts** are enabled in the [World Settings](https://spaceengineers.wiki.gg/wiki/World_Settings "World Settings").
*   PBs run scripts only while they have power in game.

To get suitable scripts, you must [subscribe to scripts from the Workshop](https://spaceengineers.wiki.gg/wiki/Workshop "Workshop") or know how to write C# scripts using [the Space Engineers API](https://github.com/malware-dev/MDK-SE/wiki/Api-Index).

Important: Read up on the scripts that you subscribe to on the workshop, they come with different instructions, such as, "edit certain lines in the script", "enter certain arguments", "rename certain blocks in the grid", or "enter certain keywords as custom data", and similar.

> **Warning : Many multiplayer server admins will punish or outright ban you for running performance-intensive scripts!** Be considerate of the other players on the server when running scripts!

### What can scripts do?

For comparison, Timer Blocks can only switch blocks on and off (such as lights), and increase and decrease a few values (such as wheel suspension height, rotor/piston/hinge reverse, or thruster override) in fixed intervals. In contrast, PB scripts can read, calculate, and write any value. For example, you could dim the light colour from white to red, or turn a rotor/piston/hinge to any position, or set the thruster to any speed.

Sensors can only detect proximity, whereas PB scripts can read any state information of a block or grid and react to it. For example, the script can look at the content of inventories, wheel steering settings, damage state, positions, speed, ownership, ...

[Event Controllers](https://spaceengineers.wiki.gg/wiki/Event_Controller "Event Controller") lie inbetween Timers/Sensors and PBs: They are easier to use than Scripts, but only support a subset of in-game Script functions.

In simpler use cases, you may use in-game scripts to change light color patterns, or to control a crane. In advanced use cases, you may want to direct auto-mining drones, fly with vector-thrust, control wheel propulsion on subgrids, display the ship’s damage status on a floor plan, detail current power usage, auto-manage inventories or production, get a radar view of your interplanetary surroundings, draw a planetary map, activate timer blocks remotely, and much more…!

**Tip:** Go to the Steam [Workshop](https://spaceengineers.wiki.gg/wiki/Workshop "Workshop") and filter the search by “last year” and (important) select **Type: InGameScript** to browse fantastic scripts shared by the community!

### How to write a script

> For more information, see the [main article on scripting](https://spaceengineers.wiki.gg/wiki/Scripting "Scripting").

[![Right](https://commons.wiki.gg/images/thumb/Keyboard_White_Mouse_Right.png/20px-Keyboard_White_Mouse_Right.png?3581de)](https://spaceengineers.wiki.gg/wiki/File:Keyboard_White_Mouse_Right.png "Right")\-click (or press [F key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings") while facing) the PB's interface in-world to interact with the block directly, or open the grid’s [Terminal](https://spaceengineers.wiki.gg/wiki/Terminal "Terminal") as usual.

1.  On the [Control Panel Screen](https://spaceengineers.wiki.gg/wiki/Control_Panel_Screen "Control Panel Screen"), click **Edit** to open the script editor.  
    It will open with an empty default script that has [basic hooks for you to fill in](https://spaceengineers.wiki.gg/wiki/Scripting "Scripting").
2.  Enter your script in one of these ways:
    *   Either click **Browse Scripts**, select a subscribed script from the [Workshop](https://spaceengineers.wiki.gg/wiki/Workshop "Workshop"), then click **Copy to Editor**.
    *   Or type the script manually — or rather, paste it from your Visual Studio application.
3.  If the description asks you to customise some lines, do that now.
4.  Click **Check Code** and a dialog will say "Compilation successful" (or give an error message about what you'll need to fix). Click OK.
5.  Click **OK** to save the script.
6.  If you are using a script that needs custom data:
    1.  Click **Custom Data**.
    2.  Enter your values and click OK.
    3.  Click **Recompile**.
7.  Optional/If applicable: Enter an **argument** in the Argument field.
8.  Click **Run**.

You will see helpful info in the bottom right corner.

Some scripts run in a loop. For others, you must set up a trigger (button, sensor, timer) that executes the Run action.
