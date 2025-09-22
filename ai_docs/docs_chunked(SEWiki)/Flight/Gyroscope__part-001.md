---
title: "Gyroscope"
url: "https://spaceengineers.wiki.gg/wiki/Gyroscope"
category: "Flight"
wiki_page: "Gyroscope"
includes_environment: true
includes_blocks: true
---

# Gyroscope - Official Space Engineers Wiki

| Gyroscope |     |
| --- | --- |
| [![Icon Block Gyroscope.png](https://spaceengineers.wiki.gg/images/Icon_Block_Gyroscope.png?c8eb45)](https://spaceengineers.wiki.gg/wiki/File:Icon_Block_Gyroscope.png) |     |
| * * * |     |
| **Function:** | Gyroscopes allow ships to orientate using the mouse movements and s... |
| **DLC?** | Vanilla |
| * * * |     |
| **Fits small grid** |     |
| Mass: | 613.6 kg |
| Hitpoints: | 2793 |
| Power: | \-0.002 MW |
| Force: | 448000 N |
| PCU: | 50  |
| Size: | 1x1x1 |
| Time to Build: | 14 sec |
| * * * |     |
| **Fits large grid** |     |
| Mass: | 12817.0 kg |
| Hitpoints: | 63105 |
| Power: | \-0.01 MW |
| Force: | 3.36E+07 N |
| PCU: | 50  |
| Size: | 1x1x1 |
| Time to Build: | 40 sec |
| * * * |     |
| _Data Controls:_ | \[[purge](https://spaceengineers.wiki.gg/wiki/Gyroscope?action=purge)\] ([?](https://spaceengineers.wiki.gg/wiki/Template:Info_Block))) |
|     |     |

Adding  [![Icon Block Gyroscope.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Block_Gyroscope.png/21px-Icon_Block_Gyroscope.png?c8eb45)](https://spaceengineers.wiki.gg/wiki/Gyroscope "Gyroscope") Gyroscopes to a mobile grid enables the player to control a [vessel](https://spaceengineers.wiki.gg/wiki/Grid "Grid")'s orientation (rotation). The rotation is called pitch, roll, or yaw. Gyroscopes add the ability to [control](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings") the grid’s pitch and yaw by:

*   by moving the **mouse**,
*   by pressing the **arrow keys** and [Q key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings") and [E key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings") to roll,
*   by moving the **sticks** on a controller.

The rotation is centered on the [Center of Mass](https://spaceengineers.wiki.gg/wiki/Center_of_Mass "Center of Mass"). Consider that, since Gyroscopes are heavy, adding gyroscopes also _shifts_ the centre of mass.

## Usage

Gyroscopes let you rotate and stabilise your ship (or rover, or [walker](https://spaceengineers.wiki.gg/wiki/Walker "Walker")), keeping it stable even when no one is manning the cockpit.

If you have the capacity to build several gyroscopes on a vehicle without it being too heavy for its size, you can configure them differently. Some examples:

*   On one or more gyroscopes, keep the override switched off, and use them to turn the vehicle manually with mouse/keyboard/controller.
*   On one additional gyroscope, switch the override on, and leave all RPM sliders at 0, which provides constant automatic stabilisation.
*   For a rover, switch an extra gyroscope off, and give it a low override on the “roll” axis. When ever the rover lands on its roof, switch this overridden gyroscope on _for a few seconds_ to force the rover to roll back onto its wheels.
*   In a miner, set up an [Event Controller](https://spaceengineers.wiki.gg/wiki/Event_Controller "Event Controller") to dynamically switch gyroscopes on when the cargo is full and some off when the cargo is empty.

### How to turn

Gyroscopes let the pilot rotate around three axes, a [grid](https://spaceengineers.wiki.gg/wiki/Grid "Grid")’s pitch, yaw, and roll.

*   When steering a rover, gyroscopes let you turn left/right, and correct roll/pitch when you catch air, with the mouse.
*   The [AI Flight](https://spaceengineers.wiki.gg/wiki/AI_Flight "AI Flight") and [Autopilot](https://spaceengineers.wiki.gg/wiki/Autopilot "Autopilot") functionality requires Gyroscopes.
*   A [Drop Pod](https://spaceengineers.wiki.gg/wiki/Drop_Pod "Drop Pod") or damaged ship that lacks thrust in some directions also lacks automatic [Inertial Dampers](https://spaceengineers.wiki.gg/wiki/Inertial_Dampers "Inertial Dampers"). Careful manual gyroscope rotation allows a skilled pilot to apply the remaining thrust in the desired direction.

| Yaw | Pitch | Roll |
| --- | --- | --- |
| [![Plane yaw.gif](https://spaceengineers.wiki.gg/images/Plane_yaw.gif?6f357e)](https://spaceengineers.wiki.gg/wiki/File:Plane_yaw.gif) | [![Plane pitch.gif](https://spaceengineers.wiki.gg/images/Plane_pitch.gif?870e76)](https://spaceengineers.wiki.gg/wiki/File:Plane_pitch.gif) | [![Plane roll.gif](https://spaceengineers.wiki.gg/images/Plane_roll.gif?fbe572)](https://spaceengineers.wiki.gg/wiki/File:Plane_roll.gif) |

### How to stablize a vehicle using Overrides

An overridden gyroscope will force the whole vehicle to spin around the chosen axis (centered on the center of mass), which is useful to right vehicles that have flipped over. Or if set to zero, respectively, prevent the whole vehicle from tilting (gyro lock), which is used for stabilization.

Typical usecases for Gyroscope Overrides are:

*   automatically stabilising rovers and racecars (constant braking torque)
*   stabilizing [walkers](https://spaceengineers.wiki.gg/wiki/Walker "Walker") (constant braking torque)
*   stopping a spaceship from spinning after a collision with an asteroid (constant braking torque)
*   rotating a flipped vehicle once (temporary rotational torque)
*   spinning a space station continuously (constant rotational torque)

In the [Control Panel Screen](https://spaceengineers.wiki.gg/wiki/Control_Panel_Screen "Control Panel Screen") under **Override Controls**, you can create a constant rotating or braking torque along an axis (pitch, yaw, or roll) of the gyroscope. Such an overridden gyroscope will force (or prevent) the vehicle to spin around the chosen axis, centered on the center of mass.

*   By default, **Override Controls** is switched off. This means the pilot can use this gyro to control the vehicle’s rotation through the mouse and keyboard.
*   If **Override Controls** is switched on, and RPM is set to zero, the Gyroscope applies a constant stabilising braking torque on that axis (gyro lock).
*   If **Override Controls** is switched on, and RPM is set to a non-zero value between +30 and -30 RPM, the Gyroscope applies constant rotational torque.

You can tell from the outside which gyroscopes are on override because they shine **lightblue**. It’s important to know for the pilot how many gyroscopes are on override, because overridden Gyroscopes are no longer available for mouse turning control.

The amount of the RPM value (rotations per minute) determines whether the gyroscope spins violently or gently. Increase the override values slowly, because sudden powerful overrides, or rather the resulting sudden spin, will slam the vehicle against the ground and damage it.
