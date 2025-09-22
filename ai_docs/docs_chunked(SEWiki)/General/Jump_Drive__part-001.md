---
title: "Jump Drive"
url: "https://spaceengineers.wiki.gg/wiki/Jump_Drive"
category: "General"
wiki_page: "Jump Drive"
includes_environment: true
includes_blocks: true
---

# Jump Drive - Official Space Engineers Wiki

| Jump Drive |     |
| --- | --- |
| [![Icon Block Jump Drive.png](https://spaceengineers.wiki.gg/images/Icon_Block_Jump_Drive.png?c39dc2)](https://spaceengineers.wiki.gg/wiki/File:Icon_Block_Jump_Drive.png) |     |
| * * * |     |
| **Function:** | Jump drives allow ships to teleport over large distances.They requi... |
| **DLC?** | Vanilla |
| * * * |     |
| **Fits large grid** |     |
| Mass: | 35980.0 kg |
| Hitpoints: | 30080 |
| Power: | \-32 MW |
| PCU: | 100 |
| Size: | 3x3x2 |
| Time to Build: | 120 sec |
| * * * |     |
| _Data Controls:_ | \[[purge](https://spaceengineers.wiki.gg/wiki/Jump_Drive?action=purge)\] ([?](https://spaceengineers.wiki.gg/wiki/Template:Info_Block))) |
|     |     |

The Jump Drive is a block that allows a mobile large-grid vessel to teleport (that is, travel instantaneously) long distances in space at a speed faster than light.

Other means of mobility are  [![Icon Block Prototech Jump Drive.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Block_Prototech_Jump_Drive.png/21px-Icon_Block_Prototech_Jump_Drive.png?d9e55c)](https://spaceengineers.wiki.gg/wiki/Prototech_Jump_Drive "Prototech Jump Drive") [Prototech Jump Drive](https://spaceengineers.wiki.gg/wiki/Prototech_Jump_Drive "Prototech Jump Drive")s,  [![Icon Block Atmospheric Thruster.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Block_Atmospheric_Thruster.png/21px-Icon_Block_Atmospheric_Thruster.png?40659a)](https://spaceengineers.wiki.gg/wiki/Atmospheric_Thruster "Atmospheric Thruster") [Atmospheric Thruster](https://spaceengineers.wiki.gg/wiki/Atmospheric_Thruster "Atmospheric Thruster")s,  [![Icon Block Hydrogen Thruster.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Block_Hydrogen_Thruster.png/21px-Icon_Block_Hydrogen_Thruster.png?77ed1d)](https://spaceengineers.wiki.gg/wiki/Hydrogen_Thruster "Hydrogen Thruster") [Hydrogen Thruster](https://spaceengineers.wiki.gg/wiki/Hydrogen_Thruster "Hydrogen Thruster")s,  [![Icon Block Ion Thruster.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Block_Ion_Thruster.png/21px-Icon_Block_Ion_Thruster.png?6357bf)](https://spaceengineers.wiki.gg/wiki/Ion_Thruster "Ion Thruster") [Ion Thruster](https://spaceengineers.wiki.gg/wiki/Ion_Thruster "Ion Thruster")s, and [Wheel Suspensions](https://spaceengineers.wiki.gg/wiki/Wheel_Suspension "Wheel Suspension").

## Usage

Use jump drives to travel distances between 5km and 2000km instantaneously. Multiple Jump Drives increase the maximum distances to multiples of 2000km.

Only ships with total mass below 1'250'000 kg can achieve the maximum distance, meaning, you cannot simply add "infinite" Jump Drives to reach an "infinite" distance. Ships with mass greater than that threshold will have their maximum jump distance reduced proportionally (ie. a ship with twice as much mass as the threshold will have half as much maximum jump distance).

The energy consumed by a jump depends on the distance. Jumps shorter than the maximum available will consume proportionally less energy, only depleting the jump drive's stored energy by a percentage equal to the actual jump distance divided by the maximum achievable. Jump drives must still recharge back to 100% before jumping again, even if the desired jump distance would require less than the current charge percentage in the drive. Energy management is an important skill for optimising your jumps.

### How to Jump?

There are two ways to aim the jump:

*   Either target a specific location,
*   Or jump “blindly” in cockpit direction for a specific distance.

Either has its uses: Targeted jumps mean faster arrival at a known location. Short blind jumps come in handy to avoid sudden attacks or when approaching an unmapped location for the first time.

Pre-jump check:

*   Verify the Jump Drives are 100% charged.
*   If you have several Jump Drives:
    *   Decide which ones to _switch on_ to increase the jump distance.
    *   Decide which ones to _switch off_ to let them recharge and as emergency backup.
*   Verify that your jump ship is not docked to a station.
*   Verify you are out of any gravity well.
*   Verify that the crew is seated.
*   Verify that carried ships are docked.

How to jump:

1.  Sit in the _main_ cockpit and open the Jump Drive's [Control Panel Screen](https://spaceengineers.wiki.gg/wiki/Control_Panel_Screen "Control Panel Screen").
2.  Configure the jump target:
    *   To jump to a known location, select its [GPS](https://spaceengineers.wiki.gg/wiki/GPS "GPS") coordinates or [Beacon](https://spaceengineers.wiki.gg/wiki/Beacon "Beacon") from the list.
    *   Or to do a blind jump, click "Remove" to clear any previous target, then select a distance in km from the slider.
3.  If blind jump: Turn the ship so the main cockpit faces into the target direction.  
    When jumping to a selected location, the cockpit direction doesn't matter.
4.  Click "Jump". A dialog prompts you to click YES to jump or NO to abort.
5.  After clicking YES, expect a ten second countdown.

[![](https://spaceengineers.wiki.gg/images/thumb/Jump-drive-dialogs.png/320px-Jump-drive-dialogs.png?eeb608)](https://spaceengineers.wiki.gg/wiki/File:Jump-drive-dialogs.png)

Two examples of a Jump Drive’s pre-jump dialog showing the distance.

Ship movement is not required to jump. If the ship is moving, however, the momentum remains and the ship will continue moving after the jump. Consider this before crashing into an asteroid on arrival.

### How to configure multiple Jump Drives

Using multiple Jump Drives:

*   Either switch all on to achieve the maximum jump range.
*   Or switch one or some off to optimise for multiple short jumps.

You can pre-configure each jump drive to a different target, and instead of changing target settings every time, simply trigger the pre-configured jump drive. Name the pre-configured blocks accordingly, so you can recognise them quickly.

When you trigger the Jump action in Jump Drive _X_:

*   It jumps to the target/distance configured in Jump Drive _X_.
*   If you jump the maximum distance, it discharges Drive X and all other Drives that are switched on and fully charged.
*   If you jump less than maximum distance, it discharges one Drive after the other (instead of discharging all of them partially).

The "Jump" action is not available for [grouped](https://spaceengineers.wiki.gg/wiki/Groups "Groups") Jump Drives in the [Toolbar](https://spaceengineers.wiki.gg/wiki/Toolbar "Toolbar"). This is because each Jump Drive could be set to a different target or different distance and it wouldn't be clear which you mean. Additionally you cannot automate jumps. The "Jump" action can only be activated by a pilot, it cannot be invoked by a timer block, button panel or similar.

  
How to configure the [toolbar](https://spaceengineers.wiki.gg/wiki/Toolbar_Configuration "Toolbar Configuration"):

*   Add each _configured_ Drive's **Jump** action to the toolbar individually.
*   Add each Drive's **on/off** action to the toolbar.
*   Add each Drive's **Recharge on/off** action to the toolbar.

Remember, you have nine toolbars.
