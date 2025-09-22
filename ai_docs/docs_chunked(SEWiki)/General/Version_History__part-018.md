*   recycling of new skins for the tools
*   fixed visible gaps in the Airtight Hangar Doors
*   fixed rotation hints cube being offset
*   fixed Sound Block looping
*   fixed block limits message and ownership transfer not being right
*   improved behavior when scrolling list inside another scroll-able list
*   optimized speed of text cursor moving using arrow keys
*   fixed control panel ignoring search string in some cases
*   fixed pressing of \[ and \] in K menu acting like K menu is not opened

Hotfixes 1.186.101

*   various crash fixes

### Version [1.186.0](https://spaceengineers.wiki.gg/wiki/Version/1.186.0 "Version/1.186.0") Major

[Reference](https://forum.keenswh.com/threads/update-1-186-major-overhaul-of-visuals-audio-and-wheels.7399609/)

Release Date: 2 February 2018

**Introduction:**

**Features:** Visual

*   Added high dynamic range rendering
*   Added eye adaptation
*   Added new post-processing effects
*   Added support for NVIDIA Ansel technology
*   Added depth-buffer clipping avoidance (when you get close to an obstacle, your tool or weapon won’t be clipping through it)
*   Added debris to explosions
*   Added block explosions
*   Added camera shake effects
*   Added extreme quality for voxels and models (not intended for real-time gameplay)
*   Reworked all particle effects from scratch
*   Improved tone mapping and bloom
*   Improved global illumination
*   Improved glass appearance(window blocks, cockpits)
*   Improved point and spot light attenuation
*   Improved and polished character animations, stabilized holding and using tools, movement cool down animation
*   Improved GPU particle system
*   Changed armor edges visual (small and large)
*   Added new Skybox (you can find the old skybox here: [https://steamcommunity.com/sharedfiles/filedetails/?id=1286315367](https://steamcommunity.com/sharedfiles/filedetails/?id=1286315367)
*   Changed suit headlight glare, dust cone, light settings
*   Fixed blocks coloring to work the same as in original Space Engineers
*   Fixed bullet hit decals/bullet holes
*   Fixed 3D Models: cockpit chairs, “under construction” blocks, driller head metal material, astronaut boots with proper stripe for magnetic effect and many more

Wheels

*   New wheel static friction simulation (wheels will maintain expected path in turns, no more sideways sliding)
*   Changes in Terminal Screen (removed number of unused/obsolete wheel/suspension settings - the game takes care of the details, tuned the default settings)
*   Modified contact point response for wheels (no more wild voxel bounce-off and sliding)
*   Adaptive steering (steering angle and speed are automatically adjusted based on car speed at the moment)
*   Dynamic center of mass for vehicles (virtual center of mass for Wheel-Suspension interaction is adjusted to further improve car behavior)
*   Air shock suspensions (jumping vehicles will extend and strengthen suspension in mid air to better absorb the shock impact upon landing and prevent damage of the chassis)
*   Added suspension jumping feature (when your off-road adventure gets you into rough terrain and your car can’t get out of it (wheels are spinning, the car sits on its belly) - press X and the car will make a small or large jump. Wheels need to be in contact with ground. The car is using the suspension springs to quickly push itself up.)
*   Tweaked acceleration/deceleration/stopping/braking
*   Mass of a vehicle influences its inertia - e.g. heavier vehicles continue moving forward with more energy than lighter ones when left unattended with no braking force applied to them
*   Physics surface materials (voxel materials now have real physical properties like friction and restitution based on surface type)
*   Fixed multiplayer support for wheels
*   Increased robustness and endurance of wheel and suspension blocks - so they don’t break after jumps

Gameplay

*   Faster walk/run/sprint for astronaut
*   Faster jetpack acceleration and deceleration
*   Rifle is more precise now
*   Changed gravity behavior for the character
*   Doors open/close faster
*   New conveyor system overload state - when your grid is in power overload, you will see new yellow color on conveyor tubes

Audio

*   Small and large ship sounds - emphasizing feel of accelerating by adding additional sounds
*   HUD voices re-enabled (e.g. “low energy” warning)
*   Footsteps tweaked for new speed of character movement. It also supports different ground materials (ice, rocks, metal, glass). Now you should hear and feel when you are running.
*   Footsteps sound also start sooner
*   Character landing/fall sounds are now more prominent, you should really feel it, this is very important for immersion and different surface materials
*   Polished where the sound listener object resides - before it was sometimes in the camera and sometimes in the center of a ship. Now it's always in the camera and the only exception is when you are piloting a large ship from the cockpit - listener is in camera, but you will also hear sound of the ship.
*   New sound when your character dies - very subtle, but giving you important feedback
*   Magnetic boots, on/off sound, different materials, you should really feel how they stick you to the surface
*   Character jumping sound - emphasizing the rubbing of textile, making the jumping more satisfying
*   Ships colliding and crashing (and sliding and scratching)
*   Small ship cockpit - enter/leave sound - now has heavier sound, feels rewarding. You just want to keep entering a leaving the ship.
*   Bullet impact on rocks has the standard wild west "pew" sound as it had in all our games. Must “hear” feature!
*   Max sound instances - The game is prioritizing sounds by distance and slowly turn off less relevant sounds. It is difficult to notice, but it helps with realism.
*   Distance to sound source - this is an older feature but it’s so awesome that I must mention it: when the distance between sound and listener increases over a certain threshold, you will hear it a bit muffled and with “long distance effect” applied on it. Awesome for gunshots, explosions, etc.
*   Jetpack sound tweaked
*   Tool sounds tweaked, better timing
*   Decreased default music volume to 50%, so you can hear the sound effects better - but you can also raise it back to 100% if you want
*   New sounds for doors
*   New destruction sounds for some blocks
*   New sound for brakes (key P)
*   New sound for antenna (key O)
*   Doppler effect changes - you can turn off doppler effect in options, Sound Block is ignoring doppler effect and overall it was toned down
*   New Sensor sound

Performance

*   New Voxel generation engine (faster loading times - about 60% faster, instant changes/damage to voxels - more than 400% faster)
*   Turrets performance changed and tweaked
*   Loading priority for textures and models
*   Ore detector performance changes with better multithreading
*   Added Sync Distance to Dedicated Server settings
*   Optimized simulation speed after splitting a grid
*   Optimized simulation speed with multiple missiles and Gatling gun turrets being used
*   Optimized updating of Upgrade Module

UI

*   Official Russian translation
*   Horizontal scrollbar for multiline text area
*   Changes to color palette UI (real HSV values, new design, help)
*   Time of the day slider in Admin tools (works in multiplayer too)
*   Auto focus for search input field in control panel
*   LCD highlight changes
*   New search box in load screen
*   Added alignment feature to LCD
*   Changes and fixes for the terminal UI

Modding/Scripting API Breaking Changes

*   IMyGasTank.FilledRatio was changed to double type
*   Terminal properties and actions for IMyMotorSuspension.Damping, SteerSpeed, SteerReturnSpeed, SuspensionTravel were removed (Corresponding C# interface properties were marked as obsolete and will be removed later)
*   Changes in particles for weapons and tools
*   Changes in glass shader can break some mods using transparent materials

Fixes

*   Fixed crash of DS when setting same block twice in block limits
*   Fixed a crash when joining a multiplayer game through Steam UI
*   Fixed a crash when joining a multiplayer game through Friends invite
*   Fixed an issue where newly created grids are sent to all players on server regardless their distance to the grid
*   Fixed Heavy Armor's durability during collisions
*   Fixed conveyor system updating
*   Fixed conveyor system becoming nonfunctional when joining a dedicated server
*   Fixed "T" key (automatic block rotation) state of persistence
*   Fixed changes done by Voxel hand propagating to newly added asteroids on DS
*   Reduced chance of drilled boulders rotating in gravity on DS
*   Fixed an issue where big grids pasted as subparts appeared out of position while pasting it
*   Fixed pasting of blueprints while moving
*   Fixed a possibility to build diagonally connected grids by copy/paste in high velocity
*   Fixed placement offset on moving grids causing overlapping of blocks
*   Fixed inability to weld projected blueprints at short distances
*   Fixed parts of blocks sometimes being visually present after their destruction
*   Fixed ships accidentally becoming stations by merging to and unmerging from stations
*   Fixed hand drill animation for secondary drilling mode (Right Mouse Button)
*   Fixed inconsistent behavior when joining a faction from inside and outside of a cockpit
*   Fixed assembler pulling more components than necessary
*   Fixed engineer floating above the seat inside the fighter cockpit
*   Fixed gameplay timer issue, timer is more precise now
*   Fixed forced first person view while drilling
*   Fixed misaligned third person view when moving on high velocity grids
*   Fixed missing windows when forced to first person view in cockpits
*   Fixed not zooming out when being forced out of ironsights by sprinting
*   Fixed camera clipping through the player character in tight spaces
*   Fixed clipping through planet voxel for player and grid
*   Fixed blinking grass
*   Fixed smoke clouds changing color
*   Fixed thruster effects persisting in the world after switching thrusters off
*   Fixed particles behaving erratically in high gravity
*   Fixed cone of light disappearing when source of light is out of view
*   Fixed an issue with space dust being rendered to close to the camera
*   Fixed muzzle flash of gatling turret disappearing at certain angles
*   Fixed centering of text on LCDs in campaign
*   Improved text wrapping at block’s detailed info
*   Fixed in-game screenshots to display all GUI elements properly
*   Fixed position of loading screen wheel
*   Fixed overflowing text in control panel
*   Fixed multiple textboxes not being able to be scrolled to right and added scroll-bar
*   Adjusted GUI formatting
*   Fixed border in server description text field
*   Fixed Curved Conveyor Tube LOD
*   Fixed Sensor LODs
*   Fixed Remote control visual for distant LOD
*   Fixed cracking sound when exiting game to main menu
*   Fixed an issue where some sounds were missing after reload
*   Fixed sounds of jumping and falling not being played every time
*   Fixed Jump Drive sound synchronization
*   Fixed lift made from piston, no more jumping on platform

Fixes (Player Reports)

*   Fixed applying moddable content file attribute to VoxelMapStorageDefinition
*   Fixed expanding pool for AddTriangleBillboard method
*   Fixed gamelogic updates on Programmable Block
*   Fixed turrets shooting already dead targets
*   Fixed updating of kinematic RB position for space ball causing unexpected behavior of space ball in some cases
*   Fixed O2/H2 Generators not pulling ice through conveyor system
*   Fixed wheels properties not being properly replicated for copy/pasted vehicles
*   Fixed resetting of friction when copying grid with suspension
*   Fixed an issue where wheel suspensions could caused grids to spin
*   Highly reduced unexpected forces affecting wheeled vehicles