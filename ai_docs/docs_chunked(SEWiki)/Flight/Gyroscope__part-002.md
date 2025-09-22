*   stopping a spaceship from spinning after a collision with an asteroid (constant braking torque)
*   rotating a flipped vehicle once (temporary rotational torque)
*   spinning a space station continuously (constant rotational torque)

In the [Control Panel Screen](https://spaceengineers.wiki.gg/wiki/Control_Panel_Screen "Control Panel Screen") under **Override Controls**, you can create a constant rotating or braking torque along an axis (pitch, yaw, or roll) of the gyroscope. Such an overridden gyroscope will force (or prevent) the vehicle to spin around the chosen axis, centered on the center of mass.

*   By default, **Override Controls** is switched off. This means the pilot can use this gyro to control the vehicle’s rotation through the mouse and keyboard.
*   If **Override Controls** is switched on, and RPM is set to zero, the Gyroscope applies a constant stabilising braking torque on that axis (gyro lock).
*   If **Override Controls** is switched on, and RPM is set to a non-zero value between +30 and -30 RPM, the Gyroscope applies constant rotational torque.

You can tell from the outside which gyroscopes are on override because they shine **lightblue**. It’s important to know for the pilot how many gyroscopes are on override, because overridden Gyroscopes are no longer available for mouse turning control.

The amount of the RPM value (rotations per minute) determines whether the gyroscope spins violently or gently. Increase the override values slowly, because sudden powerful overrides, or rather the resulting sudden spin, will slam the vehicle against the ground and damage it.

### How to balance speed and mass

The more mass a ship has, the more Gyroscopes are needed to achieve the same amount of turning sensitivity. 

The gyroscopes' effectiveness is proportional to the number of working gyroscopes onboard, and inversely proportional to the vessel's mass. This means that constructing additional gyroscopes on a vessel will make it yaw, pitch, and roll quicker. However, when you increase the mass which the gyroscopes will have to move (by adding gyroscopes, thrusters, machinery, structural armour, etc.), the ship's responsiveness will decrease again.

On the [Control Panel Screen](https://spaceengineers.wiki.gg/wiki/Control_Panel_Screen "Control Panel Screen") under Power, you can adjust the rotational sensitivity of a gyro from 100% to 0% (off). Well tuned gyroscope settings allow for very small ships to react to input with precise turning, rather than violent, jerky spinning.

### Troubleshooting

For Gyro axis configuration to be user-friendly in the Control Panel Screen, it is recommended to build all Gyroscopes facing the same way, so their axes end up being labelled the same. Sometimes your ship interior forces you to build them in different orientations. Then remember you can't select them all and apply the same override settings. Label and [group](https://spaceengineers.wiki.gg/wiki/Groups "Groups") them and then find the right axis for each group.

Be aware that, if you set two gyroscopes' overrides along the same axis to opposing values (for example, one gyro to +10 RPM yaw and the other -10 RPM yaw), they cancel each other out and nothing will happen and you don't see why. You can get into this situation accidentally if one of the gyroscopes faces the other way round, so if two overrides together don't do anything, try them separately.

Gyroscopes on a zero-RPM override don’t keep the ship/rover _level_. They just resist rotation wherever it is. If you are already tipped over, overrides will prevent you from turning right side up, so switch them off then.

Having too many Gyroscopes can make a ship twitchy and difficult to turn, as they increase the control sensitivity due to the increased turning power. This effect can be mitigated by either reducing the number of Gyroscopes installed, or by adjusting the Gyroscopes' sensitivity in their control panels.

## Power Usage

Gyroscopes use only a tiny amount of power, regardless of whether the ship is at rest or being made to roll. The large ship version uses approximately 30 W at full power, while the small ship version uses only 0.6 W - 1/50th the power. It is difficult to estimate the exact figures, due to reliance upon power usage outputs while piloting the ship.

## Gallery

*   [![Small and large gyroscope.](https://spaceengineers.wiki.gg/images/thumb/GyroscopeMechanics.png/120px-GyroscopeMechanics.png?304b45)](https://spaceengineers.wiki.gg/wiki/File:GyroscopeMechanics.png "Small and large gyroscope.")
    
    Small and large gyroscope.
    
*   [![Gyroscope for large ships.](https://spaceengineers.wiki.gg/images/thumb/Gyroscope_grid_large.png/120px-Gyroscope_grid_large.png?4d3bb3)](https://spaceengineers.wiki.gg/wiki/File:Gyroscope_grid_large.png "Gyroscope for large ships.")
    
    Gyroscope for large ships.
    
*   [![Gyroscope for small ships.](https://spaceengineers.wiki.gg/images/thumb/Gyroscope_grid_small.png/120px-Gyroscope_grid_small.png?2428c3)](https://spaceengineers.wiki.gg/wiki/File:Gyroscope_grid_small.png "Gyroscope for small ships.")
    
    Gyroscope for small ships.
    

## Construction

If [progression](https://spaceengineers.wiki.gg/wiki/Progression "Progression") is on and you don't see Gyroscopes in your G-menu, build any cockpit first to unlock it.

Gyroscopes need power to function and are very heavy. When placing them, a space engineer needs to find an effective balance between mass and turning speed for each ship.

A Gyroscope takes up a 1x1x1 block space on both small and large ships. It has mount points only on its _bottom_ face. This means that gyroscopes are relatively vulnerable to breaking off when their one mounted blocks gets destroyed, which may suddenly rob a ship of its manoeuvrability. For a less vulnerable alternative, see [Prototech Gyroscope](https://spaceengineers.wiki.gg/wiki/Prototech_Gyroscope "Prototech Gyroscope").

Large-grid gyroscopes feature a control panel on their front side; Small-grid gyroscopes lack this control panel, and they are also too small to carry a [Control Panel](https://spaceengineers.wiki.gg/wiki/Control_Panel "Control Panel"), so their settings can only be accessed from a [cockpit](https://spaceengineers.wiki.gg/wiki/Cockpit "Cockpit")'s or [Remote Control](https://spaceengineers.wiki.gg/wiki/Remote_Control "Remote Control")'s [Control Panel Screen](https://spaceengineers.wiki.gg/wiki/Control_Panel_Screen "Control Panel Screen").

The _front_ of the gyroscope (for large grid, where the control panel is) determines where which rotational axis will be, not the cockpit orientation. If you place it "the wrong way round", it will still work, but the axes will seem mislabelled. Gyroscope Overrides are easier to configure if you place the gyroscope to face the same way as the cockpit.
