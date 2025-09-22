    A Record Player printer is best for flat and wide structures. Place a rotor in the middle, and place the welder facing down on the end of a horizontal piston. Spin the arm and slowly extend the welder outward in a spiral shape so it reaches every spot.
*   [ISL - Small Ship Printer Basic MK 3](https://steamcommunity.com/sharedfiles/filedetails/?id=1967085548)  
    Spite's small ship printer pulls a small welder wall past the static projection. This is a simple rotor-less starter printer that everyone can build.

## What are Suitable Blueprints?

What do we mean by blueprints being _suitable_ for 3D printing? Not all blueprints are suitable for 3D printing, you will need to test them.

In the worst case, a badly 3D-printed ship will be missing blocks or will even fall apart. This happens if the welders could not reach all blocks, or could not reach them in the right order, or ran low on components half way through.

After the first test print, verify whether all blocks are there. If some are incomplete, try different projection rotations, angles, or slower welding speeds. If that doesn't fix it, you'll have to build the affected area differently and retake the blueprint.

Example: A gyroscope has only one mount point on one side. When the welder approaches from the opposite side, the gyroscope is not buildable yet because its mounting block is out of reach. If the welder passes too fast, it misses the window where the gyroscope's mount block is already welded _and_ the gyroscope is in range to be built -- which results in the gyroscope never getting welded.

## Best Practices

### Detachment

For drones, you may want to be able to automatically detach the finished grid from the printer using timer blocks. Using the old trick of attaching the initial projection with a stalk of armor blocks will however prevent a finished drone from lifting off.

For such cases, plan ahead in the blueprint how to attach and detach the new grid safely from the projector:

*   One solution is to add an extra [Merge Block](https://spaceengineers.wiki.gg/wiki/Merge_Block "Merge Block") to the blueprint, and to attach a second merge block somewhere on the grid where the projector is. Align both merge blocks so that the 3D Printer welds the merge block _first_.
*   Another solution is to make the stalk weak enough that you can let it be grinded off to detach it. The grinder needs to be on a separate subgrid because grinders don't grind their own grid.
    *   Especially cool kids _shoot_ the attachment block off with a static gatling gun using a [timer](https://spaceengineers.wiki.gg/wiki/Timer_Block "Timer Block"). ;-)

[![](https://spaceengineers.wiki.gg/images/thumb/8/88/Projector-merge-block-welder-3d-printer.gif/320px-Projector-merge-block-welder-3d-printer.gif?9c1fa3)](https://spaceengineers.wiki.gg/wiki/File:Projector-merge-block-welder-3d-printer.gif)

After the piston brings the merge block in range, the projected merge block becomes buildable, which activates the welders.

### Component Supply

The welders must be supplied with a steady stream of components. If components run low mid-way and the welder cannot complete a block, and the piston moves on, some blocks remain unarmored or non-functional. Therefore it's recommended to [conveyor](https://spaceengineers.wiki.gg/wiki/Conveyor_system "Conveyor system") the [Block Welders](https://spaceengineers.wiki.gg/wiki/Welder_Block "Welder Block") to filled cargo containers. Keep an eye on the contents and assemble more parts to prevent running low on something. The Assembler offers production shortcuts for all blocks.

### Preparing the blueprint

Blueprints also save the state of the grid, its [groups](https://spaceengineers.wiki.gg/wiki/Groups "Groups"), and its toolbar.

For example, if the thrusters were _off_ when you created the blueprint, then the finished grid's thrusters will also be off. If thrusters were _on_ in the blueprint, the welded thrusters will also be on. Consider what is best in your situation: Will the burning thrusters of the newly built ship keep the ship stable but burn holes in the 3D printer? Or will the finished ship drop like a rock because you forgot to switch the thrusters on before detaching?

Important: If the grid contains Timers or [AI Blocks](https://spaceengineers.wiki.gg/wiki/Artificial_Intelligence "Artificial Intelligence") that reference blocks, reference [Groups](https://spaceengineers.wiki.gg/wiki/Groups "Groups"), and not the blocks directly.

### Auto-Retracting Welders

Piston based scan-line welding contraptions are elegant, but also run a risk of getting stuck on the projected grid. Add [Sensors](https://spaceengineers.wiki.gg/wiki/Sensor "Sensor") to the welder blocks to detect and react to obstacles such as subgrids: When a welder comes too close to the welded grid, retract the welder's piston; and when the welder detects it is free of obstacles, extend the piston again.