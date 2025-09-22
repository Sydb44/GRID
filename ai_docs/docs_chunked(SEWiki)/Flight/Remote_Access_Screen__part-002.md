
### How to find the grid in the list

Remember, you're looking for the grid name, not for the antenna name. Even if one grid has more than one antenna, it's still only listed _once_.

*   Problem: Is the remote grid that you are looking for docked via a [Merge Block](https://spaceengineers.wiki.gg/wiki/Merge_Block "Merge Block") or [Connector](https://spaceengineers.wiki.gg/wiki/Connector "Connector")? Connected grids' antennas do not show up separately in the list of remote grids!
*   Solution: Connect to the parent grid and use the terminal to unlock the child grid. This situation is one of the reasons why it's recommended to [prefix the names of blocks with their ship ID](https://spaceengineers.wiki.gg/wiki/Control_Panel_Screen "Control Panel Screen"), so you can orientate yourself in the remote terminal.

If you still cannot find the grid listed, try the following:

*   Did you actually name it or is it still called "Small Grid 1234"?
*   Open the [Info Screen](https://spaceengineers.wiki.gg/wiki/Info_Screen "Info Screen") to check the antenna ranges on both sides. Often the remote antenna can reach _you_, but your suit antenna can't reach _it_.
*   Ensure you have enough power to maintain a long-range broadcast on both sides. Optimally, be seated in a powered grid.

### How to check the broadcast range

You make antenna ranges visible on the [HUD](https://spaceengineers.wiki.gg/wiki/HUD "HUD") by enabling the options on the game-wide [Info Screen](https://spaceengineers.wiki.gg/wiki/Info_Screen "Info Screen"). Similarly, you can also verify your own broadcasting status and the target's [signal](https://spaceengineers.wiki.gg/wiki/Signal "Signal") on your HUD.

### How to reconnect

After you have lost connection to a flying drone, it will be hard to reconnect long enough to change settings in the Terminal, and it's even harder to find and recover a drifting drone. Most troubleshooting tips require that the owner can physically reach the remote grid.

If a remote grid is suddenly grayed out (not available) in the list, that's because it is no longer broadcasting. Check whether the antenna is intact and broadcasting, that it's not going out of range, and that it has enough power to maintain the broadcast.

If you steer a grid remotely, it must have a functioning [Remote Control](https://spaceengineers.wiki.gg/wiki/Remote_Control "Remote Control") block. If the Remote Control block was destroyed, you can maybe still access the grid's [Terminal](https://spaceengineers.wiki.gg/wiki/Terminal "Terminal") remotely. Try to access its camera, activate its [self repair](https://spaceengineers.wiki.gg/wiki/Projector "Projector") welders, or with a bit of luck, attempt to slow down a drifting drone by setting manual thruster overrides.

### What does "Wrong ownership" mean?

You cannot access or control a remote grid if the owner does not give you (or your faction) [permission](https://spaceengineers.wiki.gg/wiki/Ownership "Ownership"). If the screen says that the ownership is “wrong”, find out who (which [faction](https://spaceengineers.wiki.gg/wiki/Faction "Faction")) owns the remote grid and ask them. If they agree, remind them to share permissions to use _all_ relevant functional blocks as well. If the Antenna, Remote Control block, Camera, Thrusters, Gyro, etc. are not shared with you (for example, because you are an enemy!), you won't be able to remote control the grid.

### Why is the Control button disabled?

Make sure the remote grid has a Remote Control block.

### Why do I keep getting disconnected?

*   When you fly the grid, does the power usage gauge turn red? Then the grid is maxing out its power intermittently. Reduce its power usage or add a battery.
*   Ensure that the grids are not moving out of antenna range. E.g. check whether the laser antenna has lost line of sight.
*   Have you disconnected this drone from a larger grid, e.g. using merge blocks? Unmerging resets grid state and resets the remote connection of the smaller of the pair. Try inserting an even smaller subgrid (e.g. a locked Hinge) between the small and large grids' Merge Blocks, so the drone becomes the main grid of the pair.

### What if there are several Remote Controls?

It's possible that you can reach the grid (meaning the **Terminal** button is active) but the grid has several Remote Control blocks, and you cannot click the **Control** button because it's not clear which RC you mean. You will see a tooltip over the **Control** button: Multiple Remote Contorls on grid. Set one as main. In this case, click **Terminal** first, find the Remote Controls in the terminal, and make sure to set exactly one as main. Then take control of the RC as usual.