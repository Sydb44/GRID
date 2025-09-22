
Use this panel to define auto trash detection in game terms. For example, you may decide to allow garbage collection of any grid that is debris, which you define as "either stationary or linearly moving or accelerating, but not powered and not being controlled by a player, and has fewer blocks than 20", and so on.

You can choose from the following criteria for which items and grids are "trash":

*   fixed planetary or space stations (default: off), stationary floating grids (default: on), linearly moving grids (default: on), accelerating grids (default: on)
*   powered grids (default: off), player- controlled grids (default: off),
*   grids with production (default: off), grids with respawn point (default: off),
*   grids with fewer than x blocks (default: 20 blocks), grids with over x metres distance from players (default 500?), time since logout of owner in hours (default 0 = rule inactive).

To ignore all these criteria, and forbid the game any automatic garbage collection, click **Suspend**.

Or to accept and enable the new definition of trash, click **Submit Changes**. Or click **Cancel Changes** to discard any changes to "Trash Removal: General".

### Voxels:

Voxel modifications can be automatically cleaned up as well, this means, holes are filled in and the terrain resets to how it was when the game was started.

Multiplayer server admins revert voxels to improve performance on their servers if, say, the aftermath of a ground battle or meteor storm has degraded the sim speed. If players have built underground bases, don’t set the protection distance too low or it will fill in their tunnels.

Voxel reset is switched off by default. Here multiplayer server admins can define the criteria for when and where voxel resets will happen. Typically you don’t reset voxel while players, their grids, or wrecks are in a certain radius around the craters, because they may intend to return.

*   Choose whether to revert asteroids, voxel terrain, and/or boulders. For boulders reverting, the minimum player distance is 2000m.
*   Revert with floating objects or NPC grids present (default: off)
*   The distance from players at which voxels are protected from being cleaned up: default 5000metres
*   The distance from grids at which voxels are protected from being cleaned up: default 5000metres
*   This much time has to pass before changes to voxels are cleaned up in minutes: default 24

Click **Enable** to reset voxels that fulfil these criteria. If you made any edits, click **Submit Changes**, or click **Cancel Changes** to discard any changes to "Trash Removal: Voxels".

### Other:

Here are some more criteria for automatic deletion and garbage collection. Most of them are only relevant to Multiplayer.

*   Enforce a radical **Optimal grid count**: Prevents players from building an excessive amount of grids. Warning, enabling this criterion ignores the "powered" and "fixed" flags, ignores "block count" limits, and lowers the protection distance from players. Set to zero to disable, zero is also the recommended default.
*   **Delete offline character after m minutes**: When a player disconnects, the character is removed after this many minutes. They can come back any time. Set to zero to disable, default 15 mins.
*   **AFK timeout**: When a player is inactive / idle / away from keyboard, the character is kicked after this many minutes. They can come back any time. Set to zero to disable (default).
*   **Stop grid period (minutes)**: If grids move too far from any players, their drifting will be stopped after this many minutes. Set to zero to disable. Default is 15 minutes.
*   **Remove old identities (hours)**: Inactive player identities who do not own any grids are removed after that many hours. Set to zero to disable, this is also the default. Note that if you allow players to join without participating, they can [sell their PCU allowance](https://spaceengineers.wiki.gg/wiki/Player_Trading "Player Trading") to other players, so switch this option on if you have this issue.

Click "Stop all entities" if items/wrecks are drifting right now to have a chance to catch them. Or, click "Remove floating objects" to draconically get rid of all debris — at the risk of also deleting players’ grids that might still be in use!

If you made any edits, click **Submit Changes**, or click **Cancel Changes** to discard any changes to "Trash Removal: Other".

## Entity List

Here an admin can view the list of all entities on this server, such as grids or players, and teleport to them, control them, or select and delete them.

1.  Select the type of entity to view: Grids (any, small, large), characters, floating objects (items), planets, asteroids, replicated, not replicated.
2.  Sort entities by: Display name, block count, mass, owner name, distance from center, speed, distance from players, owner last logout, PCU
3.  Then view the list of entities and

*   Choose an action that you want to apply to the entity, as applicable:
    *   player control
    *   teleport here
    *   stop
    *   depower
    *   remove
    *   refresh
    *   remove inactive owner and his grids

## Safe Zones

This menu manages admin-owned safe zones, which are useful, for example, to protect a spawn point on a multiplayer server. In contrast to [player-built Safe Zones](https://spaceengineers.wiki.gg/wiki/Safe_Zone "Safe Zone"), admin-owned safe zones don't need an in-world safe zone block, use no power, and do not use up [zone chips](https://spaceengineers.wiki.gg/wiki/Zone_Chip "Zone Chip").

If there is no admin controlled safe zone yet, first click "New Safe Zone" to create a safe zone at your current position.

Then select a Safe Zone from the list and configure it:

*   Define its shape (cube or sphere) and size (cuboid axes lengths or radius) in metres.
*   Choose what you want to allow players to do inside the zone. By default, the following actions are all disallowed in the zone:
    *   Damage, shooting
    *   Drilling, welding, grinding
    *   Building, building projections, voxel hands
    *   Landing gear lock, conversion to station
*   Choose a texture and color for the force field around the zone.

An admin can **configure filters** which players, factions, grids, and floating objects are allowed into the safe zone (whitelist), or are blocked from entering (blacklist).

Tip: In the filter settings, click **Add Contained** to quickly add all players/grids/etc that are currently present in the zone to either a black- or whitelist. Be careful, adding containd players/grid to a blacklist will eject them quite forcefully.

How to manage your existing Safe Zones:

*   Select a Safe Zone and click the "Move To Safe Zone" button to teleport yourself into its center.
*   Select a Safe Zone and click "Change Position" to move the center of the selected Safe Zone to where you are standing right now.
*   Select a Safe Zone to rename it, or to remove it.

Remember to enable the zone to make it work, or disable it if no longer needed.

Note: If players have created their own safe zones (using [safe zone](https://spaceengineers.wiki.gg/wiki/Safe_Zone "Safe Zone") blocks), these do not appear in the list here and are not meant to be controlled from here.
