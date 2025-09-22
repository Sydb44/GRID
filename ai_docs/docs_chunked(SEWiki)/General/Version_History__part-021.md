Check the details at Marek's blog post: [https://blog.marekrosa.org/2017/11/space-engineers-physics-engineering.html](https://blog.marekrosa.org/2017/11/space-engineers-physics-engineering.html) Because we are already in the process of switching to a new skybox, you can use it as well before it is officially released: [https://steamcommunity.com/sharedfiles/filedetails/?id=1208808693](https://steamcommunity.com/sharedfiles/filedetails/?id=1208808693)

**Features:**

*   added rotor lock (different from previous locking feature)

**Fixes:**

*   fixed various random crashes
*   fixed issue with wheels introduced by the previous update
*   fixed Steering Angle not saving for copy/pasted vehicles
*   fixed particle effect for moving objects staying static
*   fixed issue with blueprints that were pasted into other grids having no synchronization

### Version [1.185.1](https://spaceengineers.wiki.gg/wiki/Version/1.185.1 "Version/1.185.1") Minor

[Reference](https://forum.keenswh.com/threads/update-1-185-1-beta-improvements-physics-engineering-contest.7398454/)

Release Date: 23 November 2017

**Introduction:**

Hello, Engineers! Today's update is focused on addressing some of the issues and crashes occurring with last week's major update.

Now that the release of our Major Physics Overhaul is in the hands of the community, we’ve decided that it’s time to kick off a new contest with physics and engineering as the focus. It’s been great seeing what people have been able to achieve since this update released so now is your chance to really show everyone what you are capable of!

To go with the launch of this new contest, we have added a screenshot resolution modifer setting in the in-game options to allow users to take 4K and higher screenshots on lower end systems.

For those of you who couldn't watch the Major Physics Overhaul developer livestream, here's the recording:

[Major Physics Overhaul Livestream - 17th November 2017](https://www.youtube.com/watch?v=k4RZsdDoKAo)

**Physics & Engineering Contest**

Check the details at Marek's blog post: [space-engineers-physics-engineering](https://blog.marekrosa.org/2017/11/space-engineers-physics-engineering.html)

Because we are already in the process of switching to a new skybox, you can use it as well before it is officially released:

[Classic Skybox Remastered](https://steamcommunity.com/sharedfiles/filedetails/?id=1208808693)

**Features:**

*   screenshot resolution multiplier setting

**Fixes:**

*   fixed various crashes
*   changed drill efficiency against armor
*   fixed LG unlocking after reload on SP
*   fixed highlights going through characters

Hotfixes 1.185.101:

*   fixed crash after ship collision

If you have any questions or requests, please do not hesitate to contact us, we will do our best to solve your problems. We would be also very happy if you can submit your feedback at our Space Engineers Steam store page and encourage us to do better. We welcome both positive or negative comments, it helps us to create better game for you!

### Version [1.185.0](https://spaceengineers.wiki.gg/wiki/Version/1.185.0 "Version/1.185.0") Major

[Reference](https://forum.keenswh.com/threads/update-1-185-major-physics-overhaul.7398269/)

Release Date: 17 November 2017

**Introduction:**

With today’s major update we are releasing a large overhaul to the physics in Space Engineers. The update is primarily focusing on pistons, rotors, landing gears, and grid deformations. These mechanics have been a top priority for the SE team during the last year - to have these things be as robust, stable, and intuitive as possible. The game’s physics are now more stable and creations shouldn't break, explode or do uncontrollable things under normal conditions with default settings. You can read about the changes to physics in great technical detail on Marek Rosa’s blog: [physics.html](http://blog.marekrosa.org/2017/11/physics.html)

Additionally, the Mod API and Programmable Block API has received some massive updates in this release so be sure to check it out if you are a modder or a scripter!

[Space Engineers: Major Physics Overhaul](https://www.youtube.com/watch?v=-OL4PDGJMpQ)

**Features:**

*   new physical overhaul for pistons and rotor blocks
*   new deformation optimizations for armor blocks
*   asynchronous grids and voxels streaming on server: fixing server lagging while connecting new clients
*   added new check box in advanced settings for enabling Sub-grid damage (enabling or disabling sub-grids damaging main grid)
*   added new check box in advanced settings for enabling Turret Friendly Damage (friendly fire for turrets on/off)
*   added new warning for worlds with „Unsafe Grids"
*   increased Laser Antenna range to 200 km (making planet to moon communication possible)
*   major changes to the ModApi
*   changed tree LOD
*   ModAPI changes and guides: [https://forum.keenswh.com/threads/modapi-and-pb-api-changes-nov-2017.7398158/](https://forum.keenswh.com/threads/modapi-and-pb-api-changes-nov-2017.7398158/)

Art

*   tweaked Drill block texture on lower and medium settings
*   improved lodding for Armor
*   fixed Digital Camo skin not having emissive boots

Fixes

*   fixed Steam achievements
*   fixed crash when extending piston with a rotor on a fast moving grid
*   fixed crash when a piston head breaks on DS
*   fixed crash when disconnection antenna from a grid with a solar panel
*   fixed crash when merging or unmerging grids on a moving grid
*   fixed corner case crash when teleporting over large distance on DS
*   fixed corner case crash when attempting to join a friends game
*   fixed sim speed drop with large amount of blocks in constant velocity
*   fixed sim speed drop when shooting grids on DS
*   fixed sim speed drop when placing large amount of Sliding Doors
*   fixed memory leak when taking screenshot
*   fixed that attaching sub-grid to ships on planets makes them fall
*   fixed multiple issues with piston and piston heads causing clang on static or moving ships
*   fixed issues with rotor and piston heads were desynchronizing when attached to a fast moving grid
*   fixed piston clipping through grids when trying to push them away
*   fixed being able to place blocks inside of piston extended parts
*   fixed issue with shaking ships when rotors and pistons are unlocked
*   fixed issue with disappearing static pistons when connected with another piston and extended
*   fixed merge blocks not merging properly when attached to a grid on a rotor
*   fixed issue with multiple merge blocks attempting to merge with another grid using multiple pistons
*   fixed issue with merge block phasing through another merge block when on a extended piston
*   fixed being able to alter unclamped values in saves and blueprint files
*   fixed scripts being able to change ore types in cargo containers
*   fixed issues with blueprints from workshop not being pasted properly or at all
*   fixed shaking off ship after using Jump drive on DS with two players
*   fixed Gatling Gun block not doing any damage on DS
*   fixed invulnerability not working on DS
*   fixed disappearing items when using conveyor belts on DS
*   fixed stuttering on DS each 10 km when flying
*   fixed phasing through voxel material with LG
*   fixed LG making block invulnerable to thruster damage
*   fixed rotor „add rotor head/wheel“ exploit for steel plates
*   fixed issue with mirroring half-blocks
*   fixed issue with moving platform moves without moving the player
*   fixed fighter cockpit having clipping issue with the player model when accelerating
*   fixed model exporter
*   fixed issues with sensor

Fixes from player reports

*   fixed crash for modded blocks with custom GUI controls
*   fixed crash when building block through PB and Projector
*   fixed corner case crash when exiting the game
*   fixed desync issue on DS when using spectator camera
*   fixed Oxygen bottles not syncing on DS
*   fixed deformable blocks disappearing or being invulnerable
*   fixed shaking and clang issue with pistons and rotors for mods that go over 100 m/s limit
*   fixed unmerging causing rotor head to disconnect from rotor
*   fixed piston shaking when too much strain is put on it
*   fixed piston sound not stopping after being extended
*   fixed gatling gun block being able to shoot itself in certain cases
*   fixed scripts being unable to access blocks connected via rotors and pistons
*   fixed script compiler not handling sub folders properly when uploading to the Steam Workshop
*   fixed AI for Spiders not engaging when spawned via script

Hotfix 1.185.014

*   fixed crash when pasting pistons
*   fixed crash when mining

Hotfix 1.185.015

*   fixed sim speed issue caused by mass query on larger grids

Hotfix 1.185.016

*   fixed crash when ship collides/explodes
*   fixed crash when adding actions for Impulse Axis/NonAxis
*   fixed crash with Phoenix Laser Drill mod

Hotfix 1.185.017

*   fixed crash caused by wrong connector behavior
