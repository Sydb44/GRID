
**Fixes:**

*   Fixed a crash in Cutscene tool (2xF11) when trying to play a cutscene where camera position or rotation has invalid value
*   Fixed another crash in Cutscene tool when switching between tabs
*   Fixed a crash in Cutscene tool when closing the screen after the player was deleted via visualscripting
*   Fixed a crash in Visual scripting related to character trying to respawn inside a cockpit
*   Fixed a crash when multiple atennas or beacons on the same grid have Show on HUD enabled through ModAPI/Terminal/Toolbar
*   Fixed a crash when welding a projected wind turbine
*   Fixed a crash which occured when save with out of bounds values prompted multiple warning dialogs in DS configurator
*   Fixed dead engineers missing in campaign due to the fact that they were previously supergridded in as small blocks
*   Fixed problems due to ship drills starting to drill immediately after merging, ship drills now start to drill only after spinning up
*   Fixed trash removal evaluating block count with less or equal than instead of less than the set amount
*   Fixed the ability to place singular blocks in creative into space over the PCU limit
*   Fixed camera moving around when using the Celebrate emote
*   Fixed cryo chamber not updating emissivity when working with oxygen
*   Fixed cryo chamber never changing from green emissivity to yellow
*   Fixed voxel hand changes not being properly synchronised to other players
*   Fixed voxel hand changes not being synchronized to other player upon reconnect
*   Fixed inventory desynchronisations occuring after pasting stacks of unstackable items through item spawn screens directly into inventory on DS
*   Fixed a problem where a player actually connects to the server later than those who started joining later
*   Fixed block changing emissivity when recolored
*   Fixed local grid alignment placement mode enabling whenever a projector somewhere was turned off
*   Fixed the ability to weld a projected block without having energy in the suit
*   Fixed light reflections appearing on grid surfaces depending on the angle of the camera
*   Fixed texture on the bottom of small solar panel block being see-through
*   Fixed inability of making a renamed local copy of a workshop world as it was overwriting the original anyway
*   Fixed parts of blocks being black when shining flashlight on them at night on Low settings
*   Fixed shooting particles not being visible when the source (weapon) is too close to a voxel surface(planet, asteroid)
*   Fixed spectator from respawn screen (Shift+Esc) being available to everyone (Now have to have spectator rights, change to spectator is irreversible as you don't have character to get back to)
*   Fixed supergridding not being considered experimental
*   Fixed Solar panels and Wind turbines not turning back on correctly when previously turned off via connected grid
*   Fixed legacy values in old saves preventing the world from loading
*   Fixed Armory, Armory Locker and Locker blocks not having lower levels of detail
*   Fixed inability to finish Remote Control task in Learning to Survive scenario
*   Fixed LCD panels not synchronizing properly when crossing sync distance threshold or when streaming occurs
*   Fixed Safe values for Day duration/Sun rotation interval being incorrectly evaluated as Experimental
*   Fixed patterning for Slope 2x1x1 armor block textures - slope part
*   Fixed patterning for Slope 2x1x1 armor block textures - flat square sides
*   Fixed patterning for Slope armor block textures
*   Fixed round armor inverted corner missing one armor edge
*   Fixed patterning for Half armor block textures - square sides (rectangle sides Soon)

Solved Issues from Support Site

*   Fixed an exploit where player could shut down power on any grid by utilizing buttons from unknown signals
*   Fixed incorrect behaviour of IMyInventory.IsConnectedTo
*   Fixed female helmet skins not appearing when trying to render highest quality of the model
*   Fixed trash removal ignoring block count setting for respawn ships
*   Fixed showing damage particle effects for projected damaged blocks
*   Fixed disassemble repeat mode not keeping items in queue after disassembly
*   Fixed doors not opening visually when opened by a script
*   Fixed containers not dropping their inventory when deleted using mirror mode
*   Fixed projectors not respecting Keep projection setting in multiple cases
*   Fixed artificial mass blocks not working when switched on after save and reload
*   Fixed an issue where modded worlds would fail to load on DS due to asynchronously downloading mods from steam
*   Fixed Programmable block API GetInventory returning null for blocks with more than 1 type of inventory
*   Fixed tooltip on server password screen which suggested insertion of server IP instead
*   Fixed LCD with scripts not initializing when pasted on DS
*   Fixed rubber banding when walking and running on grids with high ping, trend timeout is now dynamically based on ping instead of a flat amount
*   Fixed sides of Armor Slope and Armor Corner 2x1x1 Base blocks getting transparent when combined
*   Fixed backpack inventory volume not being multiplied without character (Laying on the ground after player dies)
*   Fixed text memory issues and text character limit when being written through ModAPI WritePublicText
*   Fixed mods not having access to ownership when welding projections by exposing the builtBy parameter and IsWithinWorldLimits to modders
*   Fixed "Enable station grid with voxel" setting being misleading by renaming it to "Unsupported stations"
*   Fixed analog clock script small hand not moving gradually as the time passes
*   Fixed Small hydrogen engine changing materials for parts of its model on different levels of detail
*   Fixed the inability to type into the G-screen search box while holding Shift
*   Fixed the inability to change LCD textures via programmable block

### Version [1.190.1](https://spaceengineers.wiki.gg/wiki/Version/1.190.1 "Version/1.190.1") Minor

[Reference](https://forum.keenswh.com/threads/update-1-190-1-minor-improvements.7403109/)

Release Date: 29 April 2019

**Features:**

*   All players can now use any DLC blocks without owning the DLC, however, placement (place a block, spawn in a blueprint containing DLC blocks, initially weld projected DLC block) is still reserved for DLC owners only
*   Added warning messages about using DLC content without owning it
*   Changed survival spawning mechanics to not be easily exploitable
*   Spawning players are no longer tied to one particular player
*   Readded option to have respawn timers on drop pods
*   Spawn position can be custom through editing save files again
*   Added new billboard blend type called 'PostPP' in order to offer a solution for problems with post-processing affecting Text HUD API mod

**Fixes:**

*   Fixed undrillable and constantly respawning voxels
*   Fixed modded scripts not being able to be whitelisted even when meeting criteria
*   Fixed sliding door emissivity not being changed properly when using the block via Timer Blocks
*   Fixed DLC blocks missing from production screen blueprints
*   Fixed a couple of crashes when loading/exiting worlds
*   Fixed a couple of crashes including one in BP screen when trying to copy BP to clipboard when there is something already
*   Fixed a crash when reloading a scene with many engineer characters with different skins
*   Fixed a crash in production screen when displaying what components a blueprint needs
*   Fixed a crash when exiting a cryo chamber

Support Site Bugs

*   Fixed an issue with subparts being too slippery for walking
*   Fixed an issue where projected DLC blocks could not be welded on dedicated servers
*   Fixed an issue with terminal block groups from a blueprint not reappearing after re-welding the blueprint
*   Fixed multiple issues with artificial mass and space ball blocks not being affected by gravity generators
*   Fixed an issue where game froze up after canceling mod downloads during loading (The last batch approved by steam API is downloaded anyway)
*   Fixed block groups temporarily disappearing after merging/unmerging
*   Fixed DLC armory, armory lockers and lockers blocks accidentally being able to be used by conveyor systems
*   Fixed showing wrong reasons for experimental mode in console/log
