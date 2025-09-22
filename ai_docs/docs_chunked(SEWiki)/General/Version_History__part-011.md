*   Fixed Share inertia tensor for piston and rotor setting being accessible and settable without experimental mode
*   Fixed two issues with main cockpit brake setting not being respected by other cockpits on the grid which are not main cockpits
*   Fixed voxel hand placing only stone when using painting mode (Middle Mouse Button/ Scroll Wheel click)

Solved Issues from Support Site

*   Added autorespawn setting for existing worlds
*   Added function which removes old respawn ship whenever player tries to spawn a new one
*   Fixed block groups created by players disappearing when those players disconnect from the Lobby
*   Fixed LCDs not syncing displayed contents to other players in vicinity and after clients reconnect
*   Fixed refinery not being able to remove minuscule amounts of stone from its inventory
*   Fixed solar panels updating too slowly
*   Fixed the ability to propose peace to a faction again through ModAPI even after the peace was already established

### Version [1.189.044](https://spaceengineers.wiki.gg/wiki/Version/1.189.044 "Version/1.189.044") Minor

[Reference](https://forum.keenswh.com/threads/update-1-189-044-minor-improvements.7402823/)

Release Date: 20 March 2019

**Fixes:** 20/03/2019 Hotfix: 1.189.044

*   Fixed crash in voxel physics

### Version [1.189.043](https://spaceengineers.wiki.gg/wiki/Version/1.189.043 "Version/1.189.043") Minor

[Reference](https://forum.keenswh.com/threads/update-1-189-043-minor-improvements.7402822/)

Release Date: 19 March 2019

**Fixes:** 19/03/2019 Hotfix: 1.189.043

*   Fixed crash when drilling
*   Fixed crash in drop containers
*   Fixed crash when drills interacted with changed voxels
*   Fixed crash when exiting a game after using a large brush size of a voxel hand
*   Fixed crash in antennas on server reconnect
*   Fixed crash when there are invalid/missing sound drivers in the system
*   Fixed crash when grids with unsafe values caused the warnings on the screen to update at the same time
*   Fixed a few leaks as a result of better tracking
*   Fixed misbehaving physics, where collisions became increasingly offset over time
*   Worked on another iteration of attempting to fix disappearing physics
*   Added Havok statistics and memory tracking into the log

### Version [1.189.0](https://spaceengineers.wiki.gg/wiki/Version/1.189.0 "Version/1.189.0") Major

[Reference](https://forum.keenswh.com/threads/update-1-189-major-overhaul-of-survival-ladders-leaving-early-access.7402606/)

Release Date: 28 February 2019

**Introduction:**

Hello, Engineers!

February 28, 2019 is the day for all Space Engineers. Today, we are moving Space Engineers out of Early Access. Getting Space Engineers out of Early Access has been planned for a long time. We have worked on it basically since 2016/2017, [when the game entered beta](https://blog.marekrosa.org/2016/12/space-engineers-entering-beta_15.html). It was our goal to release the game in the state we consider to fulfill our [original vision](https://www.spaceengineersgame.com/about.html), including all planned features and core game components. Moreover, the game includes a lot of things that were not planned at the beginning of development (solar panels, planets, rotors, pistons, wheels, and many more features).

Space Engineers was one of the first Early Access games on Steam and one of the few titles to be successfully released after several years of passionate development. We keep our promises!

Space Engineers has been in Early Access for 5+ years, and during this period we developed the game from a [proof-of-concept](https://www.youtube.com/watch?v=R3b9e_KWO-I) to a feature complete space engineering sandbox. We sold more than 3 million copies and we have more than 200,000 monthly active players.

Because Space Engineers development was open, you were able to see what’s happening under the hood. Contrary to other products, where you see the final product, but don’t see how the project has been developed and changed over time, and what challenges the development team had to overcome.

With this update, we are also setting a new price for Space Engineers to $19.99. According to our analysis and tests, this price better suits the majority of Space Engineers fans. This change also brings all regional prices on Steam to match countries specifications and regional differences. [Space Engineers: Now out of Early Access!](https://www.youtube.com/watch?v=YWZQj-1oK8k)

[Marek's blog post](https://blog.marekrosa.org/2019/02/space-engineers-released.html)

**Features:** Main Features

*   New blocks - Ladder, Basic Assembler, Hydrogen Engine, Small Battery, Wind Turbine, Survival Kit
*   Survival gameplay improvements
*   Learning to Survive scenario
*   Never Surrender scenario
*   Progression Tree
*   Survival respawn mechanics
*   New chat features
*   New encounters

New Features

*   Ladder
*   Basic Assembler block
*   Hydrogen Engine block
*   Survival Kit block
*   Wind Turbine block
*   Small Battery 1x1x1
*   Responsive block’s LCD panels (cockpit, medical room, respawn kit..) have correct state based on the state of the block
*   LCD panels on all blocks have new pictures
*   Progression Tree and progress sharing in the faction
*   Progression UI in G-Screen with search and support for categories
*   Processing stone gives ingots (iron, nickel, silicon) and gravel
*   Improved chat with more features (channels, timestamp, gps, emotes)
*   Help for chat in F1 screen
*   Preloading voxel materials and textures when loading world
*   Veteran Mark 2 skin (Promoted Engineer achievement reward)
*   You can choose a faction before spawning
*   Temperature for environment
*   Voxel trash removal tool for administrators
*   Search in production tab
*   New tooltip info in respawn screen
*   Players spawn near each other, you can set optimal distance in the world settings
*   New Main Menu videos and overlay
*   Assembler skips item if there is not enough resources to finish it
*   New respawn pods, one for space, one for planets and one for the moon
*   Redesigned and added encounters
*   New visuals for trees
*   New textures for voxels
*   New achievements for Learning to Survive and Never Surrender scenarios
*   New inter-grid communication system for Programmable block. Allows broadcast or unicast communication for scripts
*   Added Current ship filter option to inventory screen
*   Added temporary ban feature for player hosted multiplayer
*   Added PCU pool for Space Pirates faction
*   Increased regeneration speed for Medical Room
*   Reintroduced character ragdoll
*   Pasted enemy grids do not automatically change ownership to you. This is new feature is for administrators
*   New survival tutorial video in F1 screen

Changes

*   Default toolbar changed to be up-to-date with new blocks and survival changes
*   Default inventory multipliers changed to 3x for astronaut and 1x for blocks. New blocks inventory multiplier added to the settings.
*   Wheels power requirements depends on the settings and speed
*   Unified state of emissive colors for all blocks
*   Changed explosion impulse force so it’s lower
*   PCU safe value changed from 100.000 to 600.000
*   Players spawn on the lit side of planets
*   Voxel hand is a safe feature now (removed from experimental)
*   Tuned jetpack so it’s harder to kill yourself
*   Larger inventories for Assemblers
*   No Uranium on planets and tweaks in distribution of ore on asteroids
*   Thrusters are 20% more powerful
*   Changed power usage for Air Vent block
*   Solar panels need less solar components
*   Blocks has default PCU cost of 1 on build and full PCU cost in functional state
*   Changes to ranks
*   Renamed Moderator to Observer
*   Added teleport to Space Master role
*   Replaced checkboxes in Battery block terminal panel with one combo box
*   Changed GPS name for body location to show death time instead of id
*   Renamed custom worlds
*   Performance changes to voxel streaming. Player can join server faster.
*   Changed lodding technique for voxel textures
*   Changed overlays for turret and camera
*   Changed initial power for batteries built from projection
*   Respawn pods are no longer deleted by default in survival
*   Landing gear assembly guidelines changed, no longer needs large steel tubes
*   Block placement modes:
*   Free
*   Gravity-aligned
*   Local-grid
*   Skin containers now have batteries instead of reactors
*   Custom names for Respawn points in respawn screen
*   Tweaked sunlight on planets
*   Arc Furnace renamed to Basic Refinery and changed parameters
*   All blocks have rebalanced components requirements
*   All blocks have rebalanced building times
*   Astronaut body is no longer lootable, only the backpack is
*   Removed drones and random encounters from experimental mode
*   Encounter drones use different AI now
*   Rebalanced production costs of tools and bottles
*   Batteries only have an initial charge on the first build now
*   Medical room recharges health and energy 5 times as fast as before
*   Reduced wolves and meteorites spawn times

**Fixes:** Gameplay Fixes

*   Fixed Rotor Head not triggering PCU limit reached message
*   Fixed The Harder They Fall Achievement
*   Fixed Crayon box Achievement
*   Fixed Going Green Achievement
*   Fixed Connector Throw out function at far away coordinates
*   Fixed Item spawning at far away coordinates
*   Fixed unpredictable grid behavior at far away coordinates
*   Fixed Warheads not detonating at distant coordinates
*   Fixed Drills not drilling blocks at distant coordinates
*   Fixed uncollected components dropping at incorrect position at distant coordinates
*   Fixed Jump Drive not being accurate at distant coordinates
*   Fixed obstacle detection when leaving Cockpit
*   Fixed Gatling turrets not shooting at targets
*   Fixed Gyroscopes not slowing grid rotation in certain cases
*   Fixed crash in Main Menu when opening Good.bot tips
*   Fixed Welder not welding anything when missing components for one of the welded blocks
*   Fixed Programmable blocks being able to cheat in items into Inventories
*   Fixed Remote Control Block respect of ownership settings
*   Fixed errors not appearing when really old worlds couldn’t be loaded
*   Fixed Programmable blocks having access to potentially dangerous types
*   Fixed bug where you could be a member in two factions at once
*   Fixed Remote control kicking player out when rotors on grid were detached
*   Fixed Rotor Heads causing negative PCU in certain cases
*   Fixed wrong PCU cost of Rotor head
*   Fixed bug in Programmable Block constructor
*   Fixed Missile Turret prediction overshooting targets
*   Fixed Solar Panels working on planets at night in certain cases
*   Fixed exploit where Programmable Block could turn off enemy grid
*   Fixed several issues happening when un/merging two grids
*   Fixed Small Collector collection phantom being on the wrong side
*   Fixed relative dampening parenting to parts of certain blocks instead of grids in some cases
*   Fixed Armor corner 2x1x1 missing one mountpoint
*   Fixed H2/O2 Generator producing oxygen even when oxygen is disabled in world settings
*   Fixed grid mass not being recomputed when inventory content changes
*   Fixed Seats/Cockpits not dropping inventory content when destroyed
*   Fixed Collectors collecting when they shouldn’t (unpowered or in construction stages)
*   Fixed rooms not depressurizing when all air vents have been removed
*   Fixed bug where blueprints can be pasted into voxels and other grids in certain cases
*   Fixed crash in Collectors
*   Fixed Missiles spawning at position where grid was one frame ago
*   Fixed not being able to turn power on for unowned grids even with "Can use all terminals" settings
*   Fixed initial Campaign mission autosaves not having working scripts after load

The First Jump Scenario Fixes

*   Fixed initial Cryo Chamber having oxygen for only 2 minutes
*   Fixed bug where dropping Oxygen Bottle at certain points would make it highlighted