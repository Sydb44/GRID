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

## How to set up automatic turret AI

If you activate **Enable AI**, your custom turret will shoot at chosen targets like a standard automatic turret. You can automatically aim at player characters, large ships, small ships, and so on. The AI cannot aim at individual blocks or ores. For detailed AI targeting options, see [How to configure automatic shooting](https://spaceengineers.wiki.gg/wiki/Block_Weapons#How_to_configure_automatic_shooting_\(AI\) "Block Weapons") -- block weapons use the same AI settings.

Custom Turrets can also use [Target Locking](https://spaceengineers.wiki.gg/wiki/Target_Locking "Target Locking") (see there) to benefit from an extended targeting range and autonomous tracking and firing.

## How to fix jittery or sluggish turrets?

Short version:

*   If aiming moves too sluggishly or too twitchy around one axis, change the _Velocity Multipliers_.
*   If an automatic turret is much too hesitant or too trigger-happy, adjust _Angle Deviation_.

Long version:

You find these settings in the Custom Turret Controller's control panel:

*   **Azimuth velocity multiplier** -- How fast it turns. Default is 9.0.
    *   Increase the value to make the rotor turn faster left/right.
    *   Decrease the value to between 1.0 and 0 to slow it down.
    *   Enter negative numbers to invert the turning direction.
*   **Elevation velocity multiplier** -- How fast it tilts up/down. Default is 9.0.
    *   Increase the value to make the Hinge tilt faster up/down.
    *   Decrease the value to between 1.0 and 0 to slow it down.
    *   Enter negative numbers to invert the nodding direction.
*   **Angle deviation** -- How tolerant the automatic aiming should be. Default is 5.0.
    *   Decrease it to aim precisely but slowly.
    *   Increase it to aim fast but sloppily.

## How to prevent wobbliness

In short there's two options:

1.  Increase mass of the in-between grid - preferred solution that does not involve enabling experimental world settings.
2.  Enable Share Inertia Tensor on the rotors that are **not** on the base/ship.

For more details visit the [Mechanical Blocks - How To Improve Stability?](https://spaceengineers.wiki.gg/wiki/Mechanical_Blocks#How_to_Improve_Stability? "Mechanical Blocks").

## What's the automatic aiming range

When set to automatic, the small-grid CTC has a maximum **AI Aiming Radius** of 600 metres and the large-grid CTC has 800 metres. The distance that the projectile travels can be longer than that, and if the turret is [locked on to the target](https://spaceengineers.wiki.gg/wiki/Target_Locking "Target Locking"), you have a chance of getting the full effective range of the turret weapon.

## How to build space drones and guided missiles

[![](https://spaceengineers.wiki.gg/images/thumb/Custom-turret-controller-with-gyroscope-stabilisers.jpg/320px-Custom-turret-controller-with-gyroscope-stabilisers.jpg?6eed37)](https://spaceengineers.wiki.gg/wiki/File:Custom-turret-controller-with-gyroscope-stabilisers.jpg)

Advanced player-built missile in space: Two orthogonal CTC-controlled rotors carry gyroscopes on zero-RPM override, static weapon for CTC aiming, forward thrusters on override. Credit: Evan

A grid floating in zero gravity without a cockpit/remote control, but equipped with a turret controller, can rotate itself:

1.  Give it a static weapon and an AI target for aiming.
2.  Attach two orthogonal rotors (doesn't matter where), and assign one to CTC elevation and one to CTC azimuth.
3.  Attach a [gyroscope](https://spaceengineers.wiki.gg/wiki/Gyroscope "Gyroscope") to each rotor, and turn on Share Inertia Tensor in the rotors!
4.  Set the gyroscopes to an override of zero RPM.

If the grid now additionally has forward thrusters set to override, it will turn and fly towards its AI target.

Use the **Set Up Action** button to tell the drone what to do when it detects the target (fly and shoot) or loses sight of it (wait and stop wasting ammo), respectively. To trigger close-range actions, use a [Sensor](https://spaceengineers.wiki.gg/wiki/Sensor "Sensor")!

This shows how using Gyroscope Overrides to stabilise an AI Turret Controlled grid is useful when

*   building guided missiles/[Player Built Weapons](https://spaceengineers.wiki.gg/wiki/Player_Built_Weapons "Player Built Weapons")
*   building seeker drones that follow players.

![](https://i.ytimg.com/vi/62L5E_9fiV8/hqdefault.jpg)

Load video

## Best Practices

In general, Turrets work most reliably on static grids (stations), and on mobile grids that are locked down (using landing gear, connectors, etc.) to the ground or to an asteroid. For a moving mobile grid, use gyroscopes to stabilise the turret. Heavy turrets on fast moving mobile grids have the worst automatic aim.

*   If the AI controls a slow precise weapon (railgun or missile launcher) on a fixed station, decrease the Angle Deviation to make the AI shoot only at targets that are truly right in front of it. It will shoot less often, but with much higher precision.

*   If the AI controls fast spray-and-pray gatling-style weapons on a mobile grid, it has to constantly re-aim to compensate. If the Angle Deviation is too low, the AI will never shoot, because the target is never "in front" of it long enough. Increase the Angle Deviation a bit to make the AI more tolerant to motion, at the cost of precision.

*   Very massive Turrets need higher Velocity Multipliers to even get into gear, and may not be able to rotate themselves towards the target very precisely, so increase the allowed Deviation a bit. Light-weight turrets need lower Velocity Multipliers to be able to aim precisely, otherwise they over-/undershoot.

The same holds for civilian custom turrets used to control Block Tools:

*   Drills, Welders, and Grinders are heavy and need higher velocity multipliers. Tools have a wide area of effect and can handle a much higher Angle Deviation than weapons.
*   Spotlights and Cameras are light-weight, so lower the Velocity Multiplier. Lower the Angle Deviation to keep a much closer eye on the target.
