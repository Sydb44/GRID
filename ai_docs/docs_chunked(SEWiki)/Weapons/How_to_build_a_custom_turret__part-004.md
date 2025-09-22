
In general, Turrets work most reliably on static grids (stations), and on mobile grids that are locked down (using landing gear, connectors, etc.) to the ground or to an asteroid. For a moving mobile grid, use gyroscopes to stabilise the turret. Heavy turrets on fast moving mobile grids have the worst automatic aim.

*   If the AI controls a slow precise weapon (railgun or missile launcher) on a fixed station, decrease the Angle Deviation to make the AI shoot only at targets that are truly right in front of it. It will shoot less often, but with much higher precision.

*   If the AI controls fast spray-and-pray gatling-style weapons on a mobile grid, it has to constantly re-aim to compensate. If the Angle Deviation is too low, the AI will never shoot, because the target is never "in front" of it long enough. Increase the Angle Deviation a bit to make the AI more tolerant to motion, at the cost of precision.

*   Very massive Turrets need higher Velocity Multipliers to even get into gear, and may not be able to rotate themselves towards the target very precisely, so increase the allowed Deviation a bit. Light-weight turrets need lower Velocity Multipliers to be able to aim precisely, otherwise they over-/undershoot.

The same holds for civilian custom turrets used to control Block Tools:

*   Drills, Welders, and Grinders are heavy and need higher velocity multipliers. Tools have a wide area of effect and can handle a much higher Angle Deviation than weapons.
*   Spotlights and Cameras are light-weight, so lower the Velocity Multiplier. Lower the Angle Deviation to keep a much closer eye on the target.

## Troubleshooting Tips

**Q: Why is my manual mouse steering inverted?** -- A: Likely you placed the Hinge or Rotor the "wrong" way round, which accidentally inverted your manual controls. You don't always need to dismantle everything, first try a negative value such as -9.0 for the Velocity Multiplier of the affected axis.

**Q: I set the turret up on a base, why does the turret not move? / Why does the turret move my spaceship?** A: In this case, make sure in the [Control Panel Screen](https://spaceengineers.wiki.gg/wiki/Control_Panel_Screen "Control Panel Screen") that you disable **Share Inertia Tensor** for the [mechanical block](https://spaceengineers.wiki.gg/wiki/Mechanical_Blocks "Mechanical Blocks") that is directly attached to the station or ship. You do not want the turret to share the inertia of the whole base or ship!

**Q: How do I tell whether a Turret is set up properly?** -- A: Open the Control Panel Screen of the Custom Turret Controller and look at the info area on the bottom right side. It contains status information and helpful error messages, such as:

*   ERROR: Missing elevation or azimuth Rotor/Hinge
*   ERROR: Must have a linked Weapon tool or camera
*   If it says "NOMINAL", that means you're good.

Run the ["Targeting Info" script on an LCD panel](https://spaceengineers.wiki.gg/wiki/LCD_Surface_Options "LCD Surface Options") for more information. It gives you helpful messages such as:

*   Main Cockpit not set
*   No locked target

**Q: How do I test the turret AI without setting it to destroy my own grids?** -- A: Click **Add new enemy Identity** in the Control Panel Screen of the Custom Turret Controller. It adds a virtual NPC to the game that you can make the owner of any [dummy grid](https://spaceengineers.wiki.gg/wiki/Target_Dummy "Target Dummy") or [decoy](https://spaceengineers.wiki.gg/wiki/Decoy "Decoy") that you can use for target practice.

## Tutorial Videos

*   Splitsie's tutorial

![](https://i.ytimg.com/vi/8yA1dgX3Jl8/hqdefault.jpg)

Load video

*   [Scriptless Vanilla Auto Tracking Attack Drone](https://steamcommunity.com/sharedfiles/filedetails/?id=2746227117) (custom turret controller demo blueprint)

*   How to make drones using the turret controller video by DaddyDamo

![](https://i.ytimg.com/vi/1VCr6DDjPRM/hqdefault.jpg)

Load video

*   Rover Drone Guide by Halipatsui

![](https://i.ytimg.com/vi/BfO7c0eggEE/hqdefault.jpg)

Load video

*   Turret controller guided missile for vanilla space engineers by Evan

![](https://i.ytimg.com/vi/62L5E_9fiV8/hqdefault.jpg)

Load video

The [PARK script by Trekker](https://steamcommunity.com/sharedfiles/filedetails/?id=1933151026) provides similar but more advanced functionality: Instead of mouse control for two mechanical blocks, it lets you assign custom WASD keybinds to whole groups of pistons and rotors.

[MArmOS (Mechanical Arm Operating System)](https://steamcommunity.com/sharedfiles/filedetails/?id=767595187) is an advanced script with even more control features.