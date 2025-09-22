
In Space Engineers, the blocks that perform these motions are [Rotors](https://spaceengineers.wiki.gg/wiki/Rotor "Rotor") and [Hinges](https://spaceengineers.wiki.gg/wiki/Hinge "Hinge"), and they are essential parts of the custom turret. The simplest example is an [Advanced Rotor](https://spaceengineers.wiki.gg/wiki/Advanced_Rotor "Advanced Rotor") on the bottom, a Hinge on it, with a block weapon on top, and a Camera facing the same way as the weapon.

Whether you place the weapon upright or sideways on the hinge depends on where you want to aim:

*   On a rover or station, your priority is to also aim _down_ from your high ground to defend against ground attacks, so you attach the weapon orthogonally at a 90 degree angle.
*   On a spaceship in low gravity, your priority is to not shoot your own ship. Unlike a rover in gravity or a station, you can always turn the whole spaceship towards the attacker, so you attach the weapon block upright to get maximum range.
*   TODO: Describe solar panel

Putting a Hinge on a Rotor, and the weapon on rotor, is a good starting point because then the azimuth stays horizontal and the elevation stays vertical relative to the horizon, like your head, which makes it intuitive to control.

The game is not stopping you from putting a rotor on a hinge, or using two hinges, or two rotors! The mechanical blocks and the business end blocks don't even have to touch one another directly.  
Such turret variants also "work", but it makes turret control much less intuitive; these variants are not covered here. Depending on the purpose of your Custom Turret (e.g. a tall crane), feel free to experiment by yourself outside the tutorial.

## What is Azimuth? What is Elevation?

In the context of turret control,

*   _Azimuth_ means turning left and right horizontally, in a head-shaking motion, like a rotor.
*   _Elevation_ means turning up and down vertically, in a head-nodding motion, like a hinge.

## How to build the Custom Turret

You can build the main grid (the station, ship, rover, or what ever) and the subgrid turret (or crane, or robot leg, or what ever) out of any blocks, and the business end can be any [Block Tool](https://spaceengineers.wiki.gg/wiki/Block_Tools "Block Tools"), [Block Weapon](https://spaceengineers.wiki.gg/wiki/Block_Weapons "Block Weapons"), or functional block.

If you add Pistons and Magnetic Landing Gears etc., remember that you control them through the [toolbar](https://spaceengineers.wiki.gg/wiki/Tool_Bar "Tool Bar"), as usual.

If the Block Weapon needs to pull ammo, or if the Block Tool needs to convey components or ores, connect the turret to the grid's [conveyor system](https://spaceengineers.wiki.gg/wiki/Conveyor_system "Conveyor system") by using an _Advanced_ Rotor. Spotlight turrets or [magnetic](https://spaceengineers.wiki.gg/wiki/Magnetic_Plate "Magnetic Plate") cranes, on the other hand, obviously don't need conveyor access, and can use standard Rotors.

The following minimal example only mentions essential blocks:

1.  Sit in any cockpit on the grid; open the [Control Panel Screen](https://spaceengineers.wiki.gg/wiki/Control_Panel_Screen "Control Panel Screen") and make it the main cockpit.
2.  Consider whether you will need to connect the bottom end of the turret to the grid's conveyor system (for ammo etc.) and plan accordingly.
3.  Build your custom subgrid:
    *   Build a Rotor and a Hinge for the desired turning motion. (The two blocks don't need to touch each other, but often do.)
    *   Add desired tools on the moving "business end" of the turret:
        *   Block Weapons, or
        *   Block Tools, or
        *   Gyroscopes, or Magnetic Landing Gear, etc. ...
    *   Add a Camera with a suitable view direction for manual aiming or solar tracking.
4.  Build the Custom Turret Controller block.

Next, configure the CTC block.

## How to set up the controls

Open the Control Panel Screen of the Custom Turret Controller:

1.  Under **Assigned Azimuth Rotor**, select the Rotor (or Hinge) that turns left/right.
2.  Under **Assigned Elevation Rotor**, select the (Rotor or) Hinge that turns up/down.
3.  Under **Assigned Camera**, select the Camera.
4.  Add the manual mouse-click functionality, if desired:
    *   To add block functionality, select one or more entries from **Available Tools and Weapons** and click **Add Tool or Weapon**. It will appear under "Selected Tools and Weapons".
    *   To remove functionality, select the entry under **Selected Tools and Weapons** and click **Remove Tool or Weapon**.
5.  Add automatic block actions, if desired:
    *   Click **Set up Actions**.  
        You'll see two slots where you configure what happens if AI is enabled.
    *   To the first slot, assign a block action (or [Timer Block](https://spaceengineers.wiki.gg/wiki/Timer_Block "Timer Block") with actions) that triggers when the AI detects its target.
    *   To the second slot, assign the block action (or [Timer Block](https://spaceengineers.wiki.gg/wiki/Timer_Block "Timer Block") with actions) that triggers when the AI detects no target.
    *   (If Camera selected) Enable **always aim at sun** to make the turret auto-rotate to follow the sun. Used primarily for solar panels, and e.g. rotating custom radar dishes.
6.  Keep **Enable AI** switched off for manual control, or switch it on for automatic AI aiming behaviour.

## How to control turrets manually

[![](https://spaceengineers.wiki.gg/images/thumb/Custom-turret-controller-as-crane.png/320px-Custom-turret-controller-as-crane.png?b67a47)](https://spaceengineers.wiki.gg/wiki/File:Custom-turret-controller-as-crane.png)

A custom turret controller lets you mouse-control rotation (rotor) and inclination (hinge) of a simple crane. The business end is a [Magnetic Plate](https://spaceengineers.wiki.gg/wiki/Magnetic_Plate "Magnetic Plate") to lift things. (Image credit: Splitsie)

If you keep the AI disabled on the Custom Turret Controller's control panel, the turret only moves and shoots when player-controlled.

For manual control, sit in the main cockpit.

1.  Press [G key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings") to open the [Toolbar Configuration Screen](https://spaceengineers.wiki.gg/wiki/Tool_Bar "Tool Bar").
2.  Under **All Blocks**, [![Right](https://commons.wiki.gg/images/thumb/Keyboard_White_Mouse_Right.png/20px-Keyboard_White_Mouse_Right.png?3581de)](https://spaceengineers.wiki.gg/wiki/File:Keyboard_White_Mouse_Right.png "Right")\-click the "Custom Turret Controller" block, and select **Control** as function.  
    This adds manual control of the turret to toolbar slot 1.
3.  Under **All Blocks**, [![Right](https://commons.wiki.gg/images/thumb/Keyboard_White_Mouse_Right.png/20px-Keyboard_White_Mouse_Right.png?3581de)](https://spaceengineers.wiki.gg/wiki/File:Keyboard_White_Mouse_Right.png "Right")\-click the "Camera" block, and select **View** as function.  
    This adds viewing through the turret camera to toolbar slot 2.
4.  Press [ESCAPE key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings") to close the Toolbar Configuration Screen.

With the set-up done, now on to how to use it:

1.  Press your toolbar slot that controls the turret. In this example, press [1 key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings"). Your view changes to the view of the camera.
2.  Move the mouse left-right and forwards-backwards to control the turret.
3.  Click to shoot (or to activate the Block tool, respectively).
4.  Press [F key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings") to close the Camera view.  
    Note: You are still in turret control! If you want back to turret view, activate your Camera View toolbar slot. In this example, press [2 key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings").
5.  Press [F key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings") a second time to leave turret control.
6.  Press [F key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings") a third time to leave the cockpit.
