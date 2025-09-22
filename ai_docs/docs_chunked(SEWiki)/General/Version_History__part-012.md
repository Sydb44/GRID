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
*   Fixed “crouch” subquest not being marked when character crouches
*   Fixed character being able to get stuck in ship and get carried away
*   Fixed “Report to Ship’s Bridge” quest not marking its subquests when completed
*   Fixed player having Flashlight enabled by default
*   Fixed player having broadcast enabled by default
*   Fixed warnings appearing during or immediately after Mission 1 cutscene
*   Fixed missions having “Remote block removal” option turned on
*   Fixed “Flashlight” step of quest “Locate excavation site”
*   Fixed Mission 3 ship not having enough hydrogen

UI Fixes

*   Fixed other characters blocking third person camera of player in cockpit and forcing him/her into first person camera
*   Fixed incorrect positioning of UI elements in resolution 4:3
*   Fixed missing names of blocks and controls in Gamepad hints
*   Fixed HUD not being hidden when terminal was open through Control Menu
*   Fixed Elevator button panel in Mission 2 missing highlight
*   Fixed Campaign highlights being visible even when quest is completed
*   Fixed button panel hints being offset from actual position
*   Fixed certain scrollable UI elements being clickable outside of their area
*   Fixed random crash in DS configurator
*   Fixed camera clipping through certain hand tools
*   Fixed GPSs being unremovable through Cycle object in admin menu
*   Fixed HUD not being hidden when opening terminal screen using Gamepad controls
*   Fixed HUD marker scale for 4K screens
*   Fixed control hints for Ladders for Xbox controller
*   Fixed crash in DS configurator when switching settings
*   Fixed third person camera being zoomed out after respawning
*   Fixed player being kicked out of terminal after selecting blueprint for terminal
*   Fixed GPSs created through chat command at distant coordinates having wrong position
*   Fixed Lock/Unlock button not being refreshed in Connector’s terminal
*   Fixed HUD being visible in Respawn Screen in certain cases
*   Fixed being put into spectator camera after being kicked from customization screen of Medbay by turning off the power
*   Fixed being put into spectator camera after being kicked from customization screen of Medbay by damaging it
*   Fixed camera movement in respawn screen when grid is located on far away coordinates
*   Fixed camera position in respawn screen when grid is located on far away coordinates

Visual Fixes

*   Fixed highlight being visible through character after reconnect on DS
*   Fixed Merge blocks being white in certain cases when they should be green
*   Fixed Spotlights turning emissivity on in certain cases after splitting grid
*   Fixed texture alignment of Heavy Rounded Armor Corner
*   Fixed texture alignment of Rounded Armor Corner
*   Fixed misplaced drill particles
*   Fixed persistence of Jetpack state after reconnection on DS
*   Fixed Turret subparts being misplaced when pasting blueprint while moving
*   Fixed ore deposits being visible on surface of planets
*   Fixed crash when cycling through objects in Cycle Object screen of Admin menu
*   Fixed vines not being transparent on projected Oxygen Farms
*   Fixed hole in Passenger seat
*   Fixed shadow of the Cockpit interior
*   Fixed distances on which Grid x Voxel collisions could be heard
*   Fixed random crash in render when spawning large amount of blocks
*   Fixed Armor Block color and normal maps not being aligned
*   Fixed Drill metal particles orientation
*   Fixed Grinder spin acceleration
*   Fixed Boots peeking out of Small Cockpit’s floor
*   Fixed emissivity of modules not entering black state when turned off and damaged
*   Fixed blinking spotlights not turning of Billboards (cones)
*   Fixed Solar Panels damaged particle effect
*   Fixed some voxel materials having incorrect LODs
*   Fixed Voxel hand creating voxels with holes
*   Fixed missing separation edges between light and heavy Armors
*   Fixed stone boulders changing color after reloading
*   Fixed Medbay emissivity after its placement
*   Fixed H2/O2 Generator to not have blue emissivity when only bottles, not ice, are inside
*   Fixed Fixed LODs of Refinery’s control panel
*   Fixed LODs of Rocket launcher (on high settings)
*   Fixed Fighter cockpit building stages
*   Fixed wrong LODs of small block Atmospheric thrusters
*   Fixed texture of Inverted armor corner
*   Fixed IceEuropa2 material icon
*   Fixed wrong emissivity of Modules
*   Fixed emissive parts of Space Ball LODs
*   Fixed spawning of dead body and its backpack on far away coordinates

Multiplayer Fixes

*   Fixed infinite “Waiting for server to respond” issue after unbanning player
*   Fixed synchronization issue for blue state of connector
*   Fixed relative dampener icon wrong state after reconnect
*   Fixed synchronization of Battery, Inventory and Reactor status
*   Fixed Antenna being still visible after remotely turning off broadcasting
*   Fixed trees not falling on client after server restart and client auto-join
*   Fixed position synchronization issue for grids
*   Fixed crash for entities with the same ID
*   Fixed hacking of the blocks
*   Fixed synchronization issue for character when standing on the server and falling on the client
*   Fixed building preview color synchronization
*   Fixed color emissivity synchronization of button panel
*   Fixed particle effect synchronization of collector
*   Fixed synchronization issue for Piston with Landing Gear
*   Fixed distant planets synchronization issue

Audio Fixes and Changes

*   Fixed sound of the Welder when player does not have enough components
*   Changed the sound for Good.bot in the scenario
*   Fixed sounds and particles when welding finished block
*   Fixed issue when turning off damage effects turned off sounds too
*   Fixed no sound and message issue for unsuccessful block placement

Mod API and Scripting Changes

*   New .sbc files for Progression Tree, ResearchBlocks.sbc and ResearchGroups.sbc
*   New version of Visual Scripting Tool with better UI and support for default scenario template
*   Added description to all Visual Scripting functions and events
*   Refactored inventory API
*   Changes to IMyBatteryBlocks to reflect removed bool states, replaced by enum ChargeMode
*   Added HudText to IMyRadioAntenna and IMyBeacon
*   Added in-game performance profiler for Programmable Block (Modding build)
*   Added PDB and source code loading for both Programmable Block and Modding scripts. Attach VS to SE process and debug your scripts live (Modding build)

Solved Issues from Support Site

*   Wrong tooltip on "Adaptive simulation quality" if you have experimental settings disabled
*   Turrets don't target Missiles
*   Fov slider shows 0
*   Toolbar cleared on reload
*   Random sounds looping constantly - coming from nowhere - Can be fixed by rejoining game
*   Inventory UI transfer bug
*   Cloud saved Blueprints don't have a preview image
*   Comms tab comms scroll viewport always jumps to top at new message
*   Activating sorters/ejectors on a mining ship causes ship mass to display as 0 kg
*   Rotor lock issues on reload
*   Interior Turret wrong model rotation
*   Button name stays on HUD after respawn
*   Gyroscope causes thruster sound
*   Menu/HUD does not show up in screenshots
*   Gatling Turrets damage own grids
*   Gravity on ships is calculated from the pivot point
*   LCD center alignment is not aligned
*   Can't see custom planets
*   Visual bug pistons
*   Wheels are randomly exploding at higher speeds (vanilla)
*   Physics begins to break down at a certain point on a world of mine
*   \[ModAPI\] Terminal Controls can no longer be attached to base IMyTerminalBlock
*   Screenshots are made with 50% transparency/alpha
*   Audio and Pressurization Bugs Far From Origin
*   Lights flashing randomly
*   Small-grid Rocket Launchers LODs are broken
*   Bullets have way too much momentum in creative
*   Turrets continue firing despite setting changes
*   Medical Bay stops providing health/O2/H/energy randomly
*   'Toolbar Config / All Blocks' gets reordered when clicking again on 'All Blocks' category
*   Remote Control disconnecting at docking/undocking
*   Memory leak when mining with ship mining drills
*   LOD model for Small Ship Battery covers up charge meter
*   Rotor Hitbox Issue
*   Sensor Block can't detect voxels
*   Player Report: SE: Some planets cannot be seen: Europa, Moon, Alien, and Titan moon
*   Third person camera view lock
*   Dropping 5000 stack of ice into small ship collector causes crash
*   Turret shooting neutral grids OFF by default
*   Multiplayer or dedicated server doesn't sync correctly Oo/off state for all blocks
*   Grids over world border do not get removed
*   Turret reticle still shows while using Spectator mode
*   Broken mirroring on various blocks
*   No tracers/sound on Modded Turret while MP client
*   Stuck as spider!!
*   Rotors Current angle doesn't update
*   Can't show grid pivot or centre of mass
*   Merge blocks disabling smaller large grids power
*   Performance Optimization on Disconnected Static Grids should be in Adaptive Simulation
