### Don't expect group names to be unique

*   If you create a group called e.g. **thrusters** on several ships, it will trigger a mess of actions in _all_ docked ships with the same group name.
*   You can purposefully use the same-named groups to launch several missiles together.
*   If you plan to have multiple independent drones [3D printed](https://spaceengineers.wiki.gg/wiki/3D_Printer "3D Printer") from the same [blueprint](https://spaceengineers.wiki.gg/wiki/Blueprint "Blueprint") docked at the same station, use [Timers](https://spaceengineers.wiki.gg/wiki/Timer_Block "Timer Block") instead of groups to be able to control each drone's actions separately.

### Don't expect groups to update themselves

*   If you damage and repair a block, it stays in its groups.
*   If you destroy and re-add a block, or add new blocks of the same type, you must manually add them to the groups.
*   A broken block has a gray broken icon in the toolbar. A group, however, stays in the toolbar, and you can simply redefine which block is in it.
*   If you create a new group, verify and update Timers, Buttons, Sensors, Toolbars, etc. that may be using the outdated group.
*   Delete outdated groups to avoid confusion.

### Don't let overlapping on/off toggles confuse you

*   If you have groups for all blocks of a kind, and also for subsets, you can toggle the subsets on/off separately.
*   If you later toggle _all_ blocks on/off, it inverts their states. This results in a confusing mix of on and off blocks, and that's not necessarily what you expected! If this causes problems, use the explicit "switch on" and "switch off" actions instead to be sure.