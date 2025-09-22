The first disadvantage is that you cannot steer wheels, thrusters, or gyroscopes on subgrids from the main cockpit -- unless you use scripts (see below).

You will not be able to use the WASD keys to propel any subgrid wheels, nor fire the subgrid thrusters, nor will the mouse pitch/yaw/roll the subgrid gyroscopes. A wheel attached directly to the main grid through a [Wheel Suspension](https://spaceengineers.wiki.gg/wiki/Wheel_Suspension "Wheel Suspension") can be steered from the main cockpit, but not if the Wheel Suspension is attached to a subgrid on a rotor/piston/hinge. You can passively drag a wheeled subgrid along, but it will not help you with propulsion, and often its passiveness and extra mass may even hinder steering.

### Why is my Multigrid sinking?

The second disadvantage is that [Inertial Dampers](https://spaceengineers.wiki.gg/wiki/Inertial_Dampers "Inertial Dampers") do not account for the mass of subgrids.

This issue is most strongly noticeable on planetary ships flying in gravity when they use mechanical blocks in landing legs, nacelles, angled wings, vector thrusters, etc. If your ship has subgrids, it will sink[\[1\]](#cite_note-1)[\[2\]](#cite_note-2) or tilt in planetary gravity, and you will have to constantly fight that miscalculation manually.

While thrusters on the maingrid don't waste fuel while not actively flying, thrusters on subgrids fight the main grid and do waste fuel, so switch them off after landing or use a script.

Subgrids tilting can be counteracted by a [Gyroscope](https://spaceengineers.wiki.gg/wiki/Gyroscope "Gyroscope") override, but to fight the constant sinking, you’ll need extra thrusters and a subgrid control script (see workarounds below).

### Why is my Multigrid Clanging?

The third disadvantage is that subgrids can “clang”: Clanging means blocks get stuck in impossible positions and slowly shake themselves apart due to phantom forces. This happens, for example, when crane arms, elevators, or foldable doors push into other blocks.

Clang also happens when the physical collision shape (hitbox) of a block is not the same as the shape that we see rendered in game. While building, it looks as if e.g. piston-moved blocks just fit next to one another, but to the physics engine, they overlap and push into one another in impossible ways, which later causes destructive phantom forces. Many oversized hitboxes were fixed in [Version/1.196](https://spaceengineers.wiki.gg/wiki/Version/1.196 "Version/1.196"), allowing for more dynamic mechanical builds.

## Workarounds for subgrid limitations

If wheels or thrusters on a subgrid of your vehicle need to be fully functional, you will have to run a subgrid control [script](https://spaceengineers.wiki.gg/wiki/Scripting "Scripting") to be able to steer.

You can get helpful scripts from the Steam Community Workshop (currently, PC only), here are some examples:

*   [Whip's Subgrid Thruster Manager](https://steamcommunity.com/sharedfiles/filedetails/?id=757123653)
*   [Whip's Subgrid Wheel Control Script](https://steamcommunity.com/sharedfiles/filedetails/?id=1445055239)

To prevent subgrid clanging, leave wider gaps between subgrids, for example, by using only thin blocks such as hangar door blocks, armor slopes, or armor half-blocks near subgrids.

To prevent subgrid sinking, lock the subgrids down temporarily with landing gear (or merge blocks) to add their weight to the main grid.

To prevent subgrid tilting, add a gyroscope to the subgrid and set it to a 0 RPM override.

## How can I tell what is a subgrid or main grid?

You can tell the difference between main and subgrid (_relative_ to the block or cockpit that you are interacting with) by looking at the colours of the text in the user interface:

1.  Enter the main cockpit of the grid from which you want to steer.
2.  Then open the [Control Panel](https://spaceengineers.wiki.gg/wiki/Control_Panel_Screen "Control Panel Screen") of the [Terminal](https://spaceengineers.wiki.gg/wiki/Terminal "Terminal").
3.  When you look at the coloured names in the list of functional blocks, you see:
    *   **white**: Functional blocks on the main grid. Steering with WASD and mouse works for these out of the box.
    *   **orange**: Functional blocks with one mechanical block separating them from the main grid. They are on the first subgrid, steering them requires scripts.
    *   **yellow** to **green**: Functional blocks attached through additional mechanical blocks. The shade changes with each mechanical block separating it from the main grid. These are secondary, tertiary etc. subgrids, steering them requires scripts.

"Main grid" only means _on the same grid as the cockpit_ that you are using to view the control panel. If you build a cockpit on the subgrid and sit in it, its blocks show as white main grid. The game itself does not decide which the _main_ grid is and which the _sub_grid.

## References

1.  [↑](#cite_ref-1 "Jump up") [https://support.keenswh.com/spaceengineers/pc/topic/grids-with-attached-subgrids-sinking-while-in-natural-gravity](https://support.keenswh.com/spaceengineers/pc/topic/grids-with-attached-subgrids-sinking-while-in-natural-gravity)
2.  [↑](#cite_ref-2 "Jump up") [https://support.keenswh.com/spaceengineers/pc/topic/ships-with-subgrids-and-only-hydro-thrusters-drift-in-natural-gravity#comment-52066](https://support.keenswh.com/spaceengineers/pc/topic/ships-with-subgrids-and-only-hydro-thrusters-drift-in-natural-gravity#comment-52066)