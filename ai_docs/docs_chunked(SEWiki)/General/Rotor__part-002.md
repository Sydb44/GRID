*   **Add Rotor Head** - If the Rotor Head was _detached_, this restores the full Rotor with the default Rotor Head of its size.
*   **Add Medium Head** - (large-grid only) If the Rotor Head was _detached_, this restores the full Rotor with a 3x3 small-grid Rotor Head. For large grid, used to [connect small to large grids](https://spaceengineers.wiki.gg/wiki/How_to_connect_small_and_large_grid_blocks "How to connect small and large grid blocks").
*   **Add Small Head** - (large-grid only) If the Rotor Head was _detached_, this restores the full Rotor with a 1x1 small-grid Rotor Head. For large grid, used to [connect small to large grids](https://spaceengineers.wiki.gg/wiki/How_to_connect_small_and_large_grid_blocks "How to connect small and large grid blocks").
*   **Reverse** - Lets you quickly invert the velocity and makes the rotor turn the other way round.
*   **Attach** - After you manually make a Rotor Head block overlap the Stator, click this button to connect the two grids into one Rotor. E.g. to form a trailer hitch.
*   **Detach** - Drop the Rotor Head block off this stator. Used if you want to _add_ or _attach_ a different head.
*   **Rotor Lock** - Stops the rotor, even if the velocity is non-zero.
*   **Torque** - Sets the lifting strength of the rotor to overcome subgrid mass and external resistance when it's powered.
*   **Braking Torque** - Sets the resisting strength of the rotor to hold the mass of attached blocks when the rotor has been stopped or if there's a power outage. If this is zero, the Rotor swings freely.
*   **Velocity** - Sets the number of rotations per minute (RPM) that it should actively spin. Positive numbers spin clockwise, negative numbers spin counter clockwise. This RPM value is not precisely enforced like clockwork, in game it can be a bit faster/slower, especially with a heavy subgrid.
*   **Lower Limit** - Sets the farthest stop in degrees that the rotor rotates counter clockwise. Or set it to "361" to rotate freely.
*   **Upper Limit** - Sets the farthest stop in degrees that the rotor rotates clockwise. Or set it to "361" to rotate freely.
*   **Rotor Displacement** - Sets the distance of the rotor head to its base. Useful to position the attached subgrid precisely, for example, to fit a door frame or elevator shaft. Solves alignment issues. (Added in update 1.040.)

### Toolbar Actions

Assign these actions to your toolbar to control rotors. Labels allow you to define multiple settings of the same type:

*   **Switch Block On/Off** - A switched off Rotor without Rotor Lock spins passively, which is useful for secondary rotors that are used for stabilisation and not for lifting.
*   **Share Inertia Tensor** - See “Stability” section.
*   **Detach/Attach/Add Head** - You can connect two grids of the same or different block size by attaching a Rotor Head to a Stator. For usage, see also [how to connect small and large grids](https://spaceengineers.wiki.gg/wiki/How_to_connect_small_and_large_grid_blocks "How to connect small and large grid blocks").
*   **Set velocity** - Enter the velocity in rotations per minute, e.g. 1.0 RPM. Then give this setting a named label, such as “ vel: 1”.
*   **Rotate to angle** - Enter an angle between 0 and 360. Then Enter a velocity in rotations per minute. Then set the rotation direction: Either clockwise, counter-clockwise, or auto (shortest direction). Then give this setting a named label, such as “90 CW”.  
    Reset the speed to zero before controlling the limits manually.  
    This resets the lower and upper limits!
*   **Set Upper limit** - Enter the highest rotation value in degrees. Then give this setting a named label, such as “High: 180” or “Deployed“.
*   **Set Lower limit** - Enter a rotation value in degrees. Then give this setting a named label, such as “Low: 90” or “Stowed”.

## Stability

In general, it's safest to use mechanical blocks only on static grids. Rotors can push blocks into each other and generate vibrations that [shake a mobile grid apart](https://spaceengineers.wiki.gg/wiki/Clang "Clang") when connected one to another to form [subgrids](https://spaceengineers.wiki.gg/wiki/Grid "Grid").

On the [Control Panel Screen](https://spaceengineers.wiki.gg/wiki/Control_Panel_Screen "Control Panel Screen"), enable the **Share Inertia Tensor** setting of all subgrid rotors (except on the _first_ rotors that’s attached to the main grid) to equalise the virtual masses to achieve more stable behaviour.

If you use Rotors on mobile grids, setting  [![Icon Block Gyroscope.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Block_Gyroscope.png/21px-Icon_Block_Gyroscope.png?c8eb45)](https://spaceengineers.wiki.gg/wiki/Gyroscope "Gyroscope") [Gyroscope](https://spaceengineers.wiki.gg/wiki/Gyroscope "Gyroscope")s on override and locking down the grid safely with  [![Icon Block Landing Gear.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Block_Landing_Gear.png/21px-Icon_Block_Landing_Gear.png?d381be)](https://spaceengineers.wiki.gg/wiki/Landing_Gear "Landing Gear") [Landing Gear](https://spaceengineers.wiki.gg/wiki/Landing_Gear "Landing Gear") can help to reduce shaking.

## Trivia

While axially aligned, the two halves allow for some minor movement; if enough rotors are chained together, they can bend and even be forced to loop around.

## Construction

Rotors are composed of two halves: The larger external **Rotor** casing (technically called stator) and the **Rotor Head**, the spinning inner shaft with an attachment plate. Though created as one part when being placed from the [Toolbar](https://spaceengineers.wiki.gg/wiki/Toolbar "Toolbar"), you must weld the two halves separately. Forgetting this will cause the rotor plate to be non-functional.

You can also build the Rotor and Rotor Head on two separate grids, align the two grids so the rotor halves overlap, and click the **Detach/Attach Head** button in the [Control Panel Screen](https://spaceengineers.wiki.gg/wiki/Control_Panel_Screen "Control Panel Screen") to connect the two grids together.

Tip: If you are drifting and can't keep the Rotor halves in place and at the same time click the button, build a temporary [Timer Block](https://spaceengineers.wiki.gg/wiki/Timer_Block "Timer Block") that triggers **Attach** on the Rotor halves for you, and also triggers itself once per second, to repeatedly try to attach.
