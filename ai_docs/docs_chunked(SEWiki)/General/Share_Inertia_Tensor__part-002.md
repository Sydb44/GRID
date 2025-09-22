## How to control Mechanical Blocks?

Assign Reverse/Extend actions to your toolbat, and also increase/decrease mininum maximum. By combining these actions, you can control the movement of mechanical blocks.

You may have a situation where you want to save several min and max values. E.g. a custom extending welder arm is either folded up and stowed for transport, or it’s unfolded and extending between it’s minimum and maximum. A ship ramp may be closed to form sealed door, or unfolded to be horizontal footbridge, or to be a sloped ramp. In short, mechanical device may have a closed/stowed position and a working range. You can set up a minimum and a maximum range for rotors, hinges and pistons, but that does not leave room anymore to set up the stowed position. From version 205 on, you can predefine multiple target values and save them under a named label. When you then set another value, you can give it a separate label. This way, several set-value actions can co-exist on the toolbar, and you can switch between stowed min/max or working min/max.

## How to Improve Stability?

### Anchoring

In general, it's safest to use the mechanical blocks on static grids, such as cranes on your base.

Especially for mobile grids, lock the main grid to the ground with  [![Icon Block Landing Gear.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Block_Landing_Gear.png/21px-Icon_Block_Landing_Gear.png?d381be)](https://spaceengineers.wiki.gg/wiki/Landing_Gear "Landing Gear") [Landing Gear](https://spaceengineers.wiki.gg/wiki/Landing_Gear "Landing Gear") while subgrids (such as drill arms) are moving mechanically. Magnetic Landing Gear will temporarily turn a mobile main grid static. If immobilisation is not an option, setting  [![Icon Block Gyroscope.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Block_Gyroscope.png/21px-Icon_Block_Gyroscope.png?c8eb45)](https://spaceengineers.wiki.gg/wiki/Gyroscope "Gyroscope") [Gyroscopes](https://spaceengineers.wiki.gg/wiki/Gyroscope "Gyroscope") on a zero RPM override helps reduce shaking.

### More mass for in-between grids

When you have a chain of connected mechanical blocks, the mass of the in-between grids will determine how rigid the physical link is.

The solution to that is to add more mass to the in-between grids. You can use artificial mass or gyros as they're very heavy and small (and can also be turned off, their function is not important for this).

For example, when building a custom turret, it generally has 3 grids involved: **Ship+Rotor** -> **RotorTop+Hinge** -> **HingeTop+Guns**.  
If rotating it around (using a  [![Icon Block Custom Turret Controller.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Block_Custom_Turret_Controller.png/21px-Icon_Block_Custom_Turret_Controller.png?49af70)](https://spaceengineers.wiki.gg/wiki/Custom_Turret_Controller "Custom Turret Controller") [Custom Turret Controller](https://spaceengineers.wiki.gg/wiki/Custom_Turret_Controller "Custom Turret Controller") or whatever else) makes it wobble about, you need to make the in-between grids (in this case it's the **RotorTop+Hinge**) as close as possible to the mass of the **HingeTop+Guns** grid, or even heavier if possible. This will result in a very rigid turret, which means more accuracy.

### Sharing inertia tensor

First, to understand what the _inertia tensor_ is in a physics simulation: This property defines how the mass is distributed when rotating. For example, a long ship can roll fast, but pitch and yaw are slow by comparison. [More details on the inertia tensor](https://en.wikipedia.org/wiki/Moment_of_inertia#Inertia_tensor).

The **Share Inertia Tensor** setting on mechanical blocks can possibly stabilize a grid's rotation. This option is only available in [Experimental mode](https://spaceengineers.wiki.gg/wiki/Experimental_mode "Experimental mode") and requires enabling in [World Settings](https://spaceengineers.wiki.gg/wiki/World_Settings "World Settings") too as of SE v1.206.

On the [Control Panel Screen](https://spaceengineers.wiki.gg/wiki/Control_Panel_Screen "Control Panel Screen"), enable the **Share Inertia Tensor** option on a chain of wobbly moving mechanical blocks to stabilise them.

*   Do **not** enable this option on the _first_ mechanical block that’s _directly attached_ to a static or heavy grid (e.g. to a base or spaceship).
*   Only enable this option on mechanical blocks that are attached in between to other mechanical blocks, and on non-heavy blocks (e.g. a block tool or block weapon).

Sharing the inertia of a heavy or static grid will weigh down the whole mechanical construction and render it sluggish or immobile!

This combination of settings equalises the virtual masses of the moving parts to achieve more stable (albeit a physically unrealistic) behaviour of the physics simulation.

[![](https://spaceengineers.wiki.gg/images/thumb/Share-inertia-tensor.png/320px-Share-inertia-tensor.png?6dda31)](https://spaceengineers.wiki.gg/wiki/File:Share-inertia-tensor.png)

Do not enable "Share inertia tensor" on the mechanical blocks that touch a static grid

## How Does Cross Bracing Stabilise Mechanical Grids?

Space Engineers doesn’t care about tensile strength in static grids, but bending and vibrations become noticeable in mobile grids and mechanical blocks. Or, sometimes you struggle with hinges and rotors being to weak to lift heavy subgrids. How to fix this wobbliness?

[![](https://spaceengineers.wiki.gg/images/thumb/Pistons-as-cross-braces.jpg/320px-Pistons-as-cross-braces.jpg?152e28)](https://spaceengineers.wiki.gg/wiki/File:Pistons-as-cross-braces.jpg)

A strong crane arm stabilised by two extra pistons on rotors used as cross braces. (Image credit: Splitsie)

Stabilise weak Hinges by adding a flexible diagonal support: The most common cross brace is a piston attached by two rotors.

*   If you use cross bracing pistons, you must actively extend and retract the pistons to control the movement; and you must make the neighbouring rotors and hinges passive by setting a low braking value, no velocity, and no rotor/hinge lock.
*   Do not attempt to actively turn the cross-braced hinges and rotors, because pistons are stiff and cannot be pushed or pulled like spring suspensions in real life.
