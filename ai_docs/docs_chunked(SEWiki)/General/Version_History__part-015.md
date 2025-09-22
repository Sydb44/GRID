18/09/2018 Hotfix 1.187.207

*   fixed writing in multiline textboxes

21/09/2018 Hotfix 1.187.208

*   fixed crashes on extremely large worlds
*   fixed bug with newest NVIDIA drivers

28/09/2018 Hotfix 1.187.209

*   fixed access violation in large worlds
*   fixed binding IP issue for DS

### Version [1.187.1](https://spaceengineers.wiki.gg/wiki/Version/1.187.1 "Version/1.187.1") Minor

[Reference](https://forum.keenswh.com/threads/update-1-187-1-%E2%80%93-minor-improvements.7401707/)

Release Date: 6 August 2018

**Introduction:**

Hello, Engineers!

Today's minor update brings you more dedicated server GUI and Remote Client improvements, more descriptive tool tips for trash removal settings and lots of quality of life improvements and fixes. To name a few, we have addressed a rare issue with cars, which should prevent these vehicles from experiencing explosions. And we fixed slow loading times or issue with Game is already saving.

We are so happy that you are enjoying Space Engineers multiplayer, every stream, youtube video or game session we see is an absolute blast of fun. And that is the best outcome we could have hoped for.

But in case you are experiencing any issues, please visit our new support page: [https://support.keenswh.com/](https://support.keenswh.com/) We will try to help you as soon as possible. Have fun!

**Features:** New Features & Improvements

*   DS GUI – support for changing loading order of mods, mod info and mod removal with a button
*   DS GUI – support for properties in plugin configuration
*   Remote Client – lost connection notification
*   Remote Client – selecting notification shows server
*   Remote Client – support for opening all profiles with one click
*   More descriptive tool tips for trash removal settings in the game

**Fixes:** Fixes for following cases

*   Rare issue leading to exploding cars
*   Slow loading of mods
*   World can't be loaded – Exception occured: newEntity: VRage.Game.Entity.MyEntity
*   System.Net.Sockets.SocketException
*   System.NullReferenceException at Sandbox.Engine.Multiplayer.MyDedicatedServerBase.SendJoinResult
*   System.NullReferenceException at Sandbox.Game.Entities.MyCubeGrid.MoveBlocks
*   System.NullReferenceException at Sandbox.Game.Gui.MyGuiScreenMods.RefreshGameList
*   System.NullReferenceException at Sandbox.Game.World.Generator.MyProceduralWorldModule.GetCellDensityFunctionRemoved
*   System.NullReferenceException at Sandbox.Game.World.MyPrefabManager.CreateGridsData.OnGridsCreated
*   System.NullReferenceExceptionat Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorReplicable.OnDestroyClient
*   Crash at VRage.Steam.MySteamPeer2Peer.IsPacketAvailable(UInt32& msgSize, Int32 channel)
*   Crash when spectating around Europa
*   ParallelTasks.TaskException at Sandbox.Game.Weapons.MyLargeTurretBase.Closing
*   Leaking entities in EntityIdentifier
*   High velocity bodies freezing physics simulation/game (and ultimately servers)
*   Issue when loading worlds with invalid values freezing game
*   Super long loading of a world started as DS
*   Shield Mods cannot affect WarHead's inner circle damage
*   Issue with Game is already saving
*   Inviting a friend forces him to your MP without his input
*   Character standing on anything dynamic can lead to rubber-banding
*   Character standing on the surface of wheels can lead to rubber-banding
*   Character flying in jet-pack around a rotating grid can lead to rubber-banding when turning jet-pack off/on
*   Big grids interacting with smaller grids in high velocities can lead to clipping and rubber-banding on DS
*   Ore deposit markers stay in the world after removing ore detectors on DS
*   Ore deposits are shown even when out of range
*   Turning off "broadcast using antennas" in Ore detector turned off the deposit locations even for players in a cockpit on the same grid
*   Laser Antenna disconnects beyond 4km distance on DS
*   Remote Control through Antennas could become impossible and made the player stuck
*   Magnetic boots of other player not indicating on DS
*   Looking up and down with a tool is not fluent for other players on DS
*   Programmable block running on multiplayer clients
*   Programmable block runs twice per tick and can't be stopped
*   Random delays before ship's physics activates
*   Players should no longer be able to circumvent admin rights when making changes to factions
*   Specific block limits can be overcome by moving blocks between factions
*   Grids cannot be manipulated through Info screen with PCU limits set to None
*   Player cannot transfer authorship of a grid when Global PCU limits are reached
*   Trash Removal unsaved changes warning
*   Filtering by mods in Advanced does nothing in Join Game list
*   Invalid material warning in creative
*   Impact sounds of predicted grids are repeated multiple times
*   Moving selection in respawn screen by Up, Down arrows leads to not loading everything properly
*   Double placement sound in survival
*   Can't connect to a server through Direct connect
*   Inventory selection is not persistent after closing the screen

07/08/2018 Hotfix 1.187.101

*   Most frequent game crash: System.NullReferenceException\_Sandbox.Game.Entities.Character.MyCharacter.OnBootsStateChanged
*   Issue with missing emissive stripes on magboots

### Version [1.187.0](https://spaceengineers.wiki.gg/wiki/Version/1.187.0 "Version/1.187.0") Major

[Reference](https://forum.keenswh.com/threads/update-1-187-major-overhaul-of-multiplayer.7401427/)

Release Date: 19 July 2018

**Introduction:**

After six months, we are releasing the next major update, which is focusing on the complete overhaul of multiplayer in Space Engineers, and a number of new features and optimizations. This was a massive overhaul and that’s why it wasn’t possible to make this update in weekly increment - so thanks a lot for your patience!

We had to redo major parts of the engine and there was a lot of experimentation - for example changing the prediction protocol on client-server and observing if it’s better for user experience or worse, and many more. Space Engineers has many systems and special care had to be taken for each of them: player character, jetpack, ship, wheeled vehicles, voxels and planets, fast moving objects, deformable entities, antennas, player standing on a moving grid, colliding grids, rotors, pistons, wheels, and many many more.

But wait - that's not all! With this massive multiplayer update we are releasing optimizations and performance improvements, Safe Zones, Female Engineer and much more!

[Marek's blog post with detailed info](https://blog.marekrosa.org/2018/07/space-engineers-multiplayer-overhaul.html)

[Youtube: Space Engineers - Update 1.187 - Major Overhaul of Multiplayer](https://www.youtube.com/watch?v=dVPbVBLRBrY)

[Youtube: Space Engineers - Emergency Broadcast - Overview of Major Overhaul of Multiplayer](https://www.youtube.com/watch?v=RIMoIPKuAx4)

**Features:**

*   Improved multiplayer
*   Major optimizations and performance improvements for various blocks and systems
*   Safe Zones and global permissions
*   Player persistency in MP
*   Auto reconnect feature for client in MP
*   Female Engineer
*   PCU Limits - global, per faction or per player
*   Added Experimental Mode option
*   New support portal: [https://support.keenswh.com/](https://support.keenswh.com/) (more info at: [https://www.spaceengineersgame.com/support.html](https://www.spaceengineersgame.com/support.html) )

Dedicated Server Features

*   Special thanks goes to rexxar, Jimmacle, and Equinox for their great ideas about the server admin tool features.
*   Nicer and faster DS GUI
*   Server password feature
*   Auto Restart feature
*   Auto Update feature
*   Message of the Day, Message of the Day URL
*   Administrators slots, player reserved slots
*   DS GUI Steam client integration for easier setup
*   Remote Client in DS GUI and standalone VRage Remote Client
*   Email notifications
*   Server profiles
*   New +stop (server) command for administrators
*   New /report command for players (works with Remote Client)
*   Server side plugins API with management in DS GUI
*   Allows multiple plugins for DS
*   Wipe world feature - administrator can set save, which can be used to reset the world
*   DS GUI Actions - administrator can stop/restart with delay and message in the chat
*   Trash Removal changes and new features
*   Settings are part of the world now
*   Player inactivity threshold
*   Optimal grid count
*   Adaptive simulation quality feature
*   Updated dedicated server and Remote API guide: [https://www.spaceengineersgame.com/dedicated-servers.html](https://www.spaceengineersgame.com/dedicated-servers.html)

**Fixes:** Crash Fixes

*   Fixed voxel related crashes
*   Fixed crash when loading wrong mod
*   Fixed crash when copy-pasting certain grid
*   Fixed crash with looping Sound Block
*   Fixed crash when using illegal characters in the world name
*   Fixed crash when Content folder is missing
*   Fixed crash when changing Entity name using F11 menu

Functional Fixes and changes

*   Special thanks goes to Malware for his Programmable Block Additions: MyIni (instructions here) and MyCommandLine (instructions here)
*   Improved performance during collisions
*   Improved piston and merge block collisions
*   Improved performance of Ore Detector
*   Support for dependencies of mods
*   Steam Cloud support for blueprints (setting in Game Options)
*   Local blueprints folders support
*   Player can kick out other disconnected player from any seat/cockpit
*   Added General Data Protection Regulation dialog and setting in Game Options
*   Fixed desync issues with Refinery
*   Fixed desync issues with inventory of player
*   Fixed asteroid becoming desynced and not disappearing when removed through Entity list
*   Fixed Drills getting desynced when accessed with "Can use all terminals" rights
*   Fixed removed block leaves physically occupied space on DS
*   Fixed Star System being loaded instead of selected worlds on DS
*   Fixed Conveyor system not being functional after joining DS
*   Fixed asteroid disappearing after pasting another one on DS
*   Fixed voxel changes not being visible on pasted planet on DS after reconnect
*   Fixed falling through voxel when drilling on DS
*   Fixed ownership switching between entities on DS and MP
*   Fixed not being able to leave faction selection in Dead Drop Arena on DS
*   Fixed copy-pasting at large coordinates
*   Fixed grid exploding after turning of the merge block
*   Fixed despawning of the Respawn ships
*   Fixed dead body affecting ship's physics
*   Fixed exiting seats or cockpit sometimes kills the player
*   Fixed rifle shooting in a wrong direction
*   Fixed drones not spawning in Campaign Mission 5
*   Fixed ship not being controllable after unmerging
*   Fixed player being disconnected after pasting specific blueprint
*   Fixed deleting occupied Cockpit with right mouse button kills the player inside
*   Fixed sliding of player on rotating ship
*   Fixed player being disconnected after pasting Empty Voxel Map
*   Fixed engineer not being able to destroy block he stands on by Rifle
*   Fixed spectator pasting blueprints to 0,0,0 coordinates
*   Fixed exiting camera while using remote control
*   Fixed blocks not being affected by gravity in some cases
*   Fixed remembering angle of headlamp when entering Cockpit
*   Fixed Remote Control autopilot flying at 15m/s at planet
*   Fixed cars exploding when using inertia tensor
*   Fixed player being tilted after deactivating jetpack in the gravity
*   Fixed changing component mass does not affects block mass
*   Fixed Landing Gear unlocking when the grid is being updated
*   Fixed Turrets keep shooting even when the target does not meet conditions for a target anymore
*   Fixed player not being removed from the server after client crash
*   Fixed building mode focus info when sitting in small ship's Cockpit
*   Fixed Rocky ore deposits on planets providing exclusively iron