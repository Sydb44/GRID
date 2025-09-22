
A ship with a built-in projector that projects its own blueprint onto itself flies into a welder wall for repairs (2014)

Enable one or more of the following Projector settings:

*   Mark Missing Blocks
*   Mark Unfinished Blocks

While you are 150 m close to the grid, the projector will highlight the blocks with a HUD signal in red or yellow. In multiplayer, it's possible that players don't see the same signals and need to toggle the setting off and on themselves.

[![](https://spaceengineers.wiki.gg/images/thumb/Projector-unfinished-or-missing-block.png/320px-Projector-unfinished-or-missing-block.png?738e14)](https://spaceengineers.wiki.gg/wiki/File:Projector-unfinished-or-missing-block.png)

Unfinished blocks marked in yellow, missing blocks marked in red

### How to restore the projected ship's groups and toolbar

The toolbar of a ship can have [Control groups](https://spaceengineers.wiki.gg/wiki/Groups "Groups") defined and block actions assigned that reference blocks on the same or connected grids. When you blueprint the ship, the groups and toolbar settings are stored and also exist in the projection. Groups are recreated from the blueprint correctly, but there's the issue that group names are not unique. If you have built several ships from the same blueprint, and the ships are [docked](https://spaceengineers.wiki.gg/wiki/Docking "Docking") to the same station, then group actions on one ship trigger the docked sister ships' blocks as well! Which can have negative consequences if you inadvertently toggle refuelling or recharging off.

So if you maintain a fleet of mass-produced drones / fighters / [PBWs](https://spaceengineers.wiki.gg/wiki/Player_Built_Weapons "Player Built Weapons") from the same blueprint, the safest method is to use  [![Icon Block Timer Block.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Block_Timer_Block.png/21px-Icon_Block_Timer_Block.png?307e99)](https://spaceengineers.wiki.gg/wiki/Timer_Block "Timer Block") [Timers](https://spaceengineers.wiki.gg/wiki/Timer_Block "Timer Block") to group actions.

Another problem is, if the cockpit is among the first blocks welded up, and the cockpit toolbar references projected blocks that have not been built yet, they can appear as a broken symbol on the cockpit toolbar. If this happens to you, build the cockpit last (that is, rotate the projection).

### How to not drop it

For mobile grids, position the projection somewhere where the resulting grid stands safely after it's finished.

*   Don't project a ship floating in mid-air in high gravity if the blueprint was taken with thrusters and [Inertial Dampers](https://spaceengineers.wiki.gg/wiki/Inertial_Dampers "Inertial Dampers") off.
*   If your projection is near another grid that has a free connector in the right orientation for the projection's connectors, align the connectors, so your newly built grid can auto-lock and recharge there.
*   Or, if the projection has a free merge block, project it to align with a merge block on the projector's grid.
*   If the projection is a rover, project it so the wheels are an inch above flat ground.

### How to optimise mass production

If you designed the blueprinted grid in zero gravity, it's possible that the projection ends up upside down when loaded into the projector. For optimal mass production, the projection must be positioned well right away relative to the Welder Wall or [3D Printer](https://spaceengineers.wiki.gg/wiki/3D_Printer "3D Printer"), requiring the least amount of manual adjustments. Also, think of community members downloading your blueprint from the workshop, each of them will have to align the projection to their 3D printer as well.

The point around which the projection rotates when you fine-tune the position is called Grid Pivot. By default, the [Grid Pivot](https://spaceengineers.wiki.gg/wiki/Grid_Pivot "Grid Pivot") of the blueprint is on top of the projector when you load the blueprint.

If an asymmetrical Pivot is hampering smooth production, you need to move the Grid Pivot before blueprinting; see [Grid\_Pivot](https://spaceengineers.wiki.gg/wiki/Grid_Pivot "Grid Pivot") for how to do that.

### Multigrid Projection Limitations

Projectors cannot project [Subgrids](https://spaceengineers.wiki.gg/wiki/Grid "Grid"). If the blueprint contains subgrids, only the largest grid is projected. It's as if it assumes that the largest grid is the vehicle, and the subgrids are "just wheels" that can be easily added later...

If you use [Subgrids](https://spaceengineers.wiki.gg/wiki/Grid "Grid") for any constructions that are more complex than a wheel, the grid projection will be incomplete. The subgrids won't be projected and are unweldable.

There are two solutions for this:

*   **Single Grid Blueprint method:**
    1.  Return to the actual grid and move all subgrids into positions where they do not touch any other subgrid.
    2.  Temporarily [merge](https://spaceengineers.wiki.gg/wiki/Merge_Block "Merge Block") the subgrids to the main grid.
    3.  Take a new full blueprint, project it, and weld it up.
    4.  Finally, unmerge and grind off the temporary merge blocks to restore the subgrids' mobility.
*   **Separate Grids Blueprints method**
    1.  Return to the actual grid and make separate blueprints of each subgrid, using the [ctrl-shift-B](https://spaceengineers.wiki.gg/wiki/Blueprint "Blueprint") shortcut.
    2.  Project and weld up the main grid.
    3.  Add projectors on the main grid that contain the subgrid projections. Project each subgrid into its exact spot on the main grid, and weld it up.
    4.  Finally, attach the subgrid Heads.  
        Read the articles about [Rotors](https://spaceengineers.wiki.gg/wiki/Rotor "Rotor")/[Pistons](https://spaceengineers.wiki.gg/wiki/Piston "Piston")/[Hinges](https://spaceengineers.wiki.gg/wiki/Hinge "Hinge") for details on how to re-attach Heads.

In this video, Kelevra explains how to project separate subgrids in detail:

![](https://i.ytimg.com/vi/UM5wYs1DbNA/hqdefault.jpg)

Load video
