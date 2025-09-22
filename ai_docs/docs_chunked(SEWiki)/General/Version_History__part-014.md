
*   Fixed voxel rendering performance on planets

Fixes from the Support site

*   Fixed crash when replacing large script with a small one
*   Fixed rotor not showing correct angle info in terminal
*   Fixed missing send/submit buttons for blueprints and other workshop items
*   Fixed Friends only game lobbies under Games between public ones
*   Fixed background videos in Main menu not respecting aspect ratio on wide screen resolutions
*   Fixed wolf and spider AI (path finding)
*   Fixed thrusters trying to dampen after connecting to a static grid
*   Fixed thruster flame disappearing after thruster is recolored
*   Fixed small air vent getting incorrect readings of planetary oxygen levels
*   Fixed pressurization effects appearing during projection welding
*   Fixed LCD content being cut off when playing on lower resolutions
*   Fixed conveyor sorter not wanting to pull full bottles

Mod API Changes

Interfaces

*   Added IMyDoor.OnDoorStateChanged
*   Added IMyTerminalBlock.IsInSameLogicalGroupAs
*   Added IMyTerminalBlock.IsSameConstructAs
*   Added IMyInventory.CanAddItemAmount
*   Added IMyInventory.RemoveItemAmount
*   Added IMyInventory.TransferItemFrom
*   Added IMySlimBlock.Min
*   Added IMyCharacter.OxygenLevel
*   Added IMyConfig.HudState
*   Added IMyPhysics.CastRayParallel

Please, use CastRayParallel method if you are casting ray from another thread.

SBC Files

*   Characters.sbc
*   Added OxygenSuitRefillTime
*   Added MinOxygenLevelForSuitRefill
*   CubeBlocks.sbc
*   Change for IsAirTight
*   True = is always airtight
*   False = is never airtight
*   Null = airtightness is calculated from mount points
*   VoxelMapStorages.sbc
*   Added UseForProceduralRemovals
*   Added UseForProceduralAdditions
*   Added UseAsPrimaryProceduralAdditionShape
*   Added SpawnProbability
*   VoxelMaterials\_asteroids.sbc
*   Added AsteroidGeneratorSpawnProbabilityMultiplier

24/10/2018 Hotfix 1.188.023

*   Fixed crash at Sandbox.Game.Weapons.MyGunBase.AddMissile
*   Fixed crash at System.Collections.Generic.HashSetExtensions.TryGetValue
*   Fixed crash at Sandbox.Game.GameSystems.MyGridGasSystem.GetOxygenAmount
*   Fixed crash at Sandbox.Game.Gui.MyGuiBlueprintScreen\_Reworked.ExtractWorkshopItem
*   Fixed crashing ice clusters when there is no suitable ice material
*   Fixed issue with subscribed ingame scripts not appearing in scripts screen
*   Fixed issue with hidden blocks in terminal not respecting the state of Show hidden filter
*   Fixed missing Space Ball description in G screen

30/10/2018 Hotfix 1.188.024

*   Fixed crash at Sandbox.Game.Entities.Cube.MyAssembler.CheckInventoryCapacity(MyInventory inventory, Item\[\] items, MyFixedPoint amountMultiplier)
*   Fixed crash that occurred due to daylight savings time change
*   Fixed crash at Sandbox.Game.Gui.MyGuiBlueprintScreen\_Reworked.ExtractWorkshopItem
*   Fixed crash when setting minimum drop container time bigger than maximum on DS
*   Fixed server watcher interrupting save on exit when it is taking too long (>30s)
*   Fixed grid update performance when Airtightness is turned on

05/11/2018 Hotfix 1.188.025

*   Fixed crash in large worlds
*   Fixed missing elite welder description

### Version [1.187.2](https://spaceengineers.wiki.gg/wiki/Version/1.187.2 "Version/1.187.2") Minor

[Reference](https://forum.keenswh.com/threads/update-1-187-2-more-improvements.7401833/)

Release Date: 23 August 2018

**Introduction:**

**Fixes:**

*   \[Player Report\] Europa is not editable by voxel hand
*   \[UseResponse\] Assembler's cooperative check-box doesn't work
*   \[UseResponse\] Broken control for grids traveling over 200 m/s
*   \[UseResponse\] Cars speed artificially capped at 52.5 m/s
*   \[UseResponse\] Crash when activating timer block for specific BP
*   \[UseResponse\] F1 screen link update
*   \[UseResponse\] Graphic settings forced to medium
*   \[UseResponse\] Invisible players on DS when using cockpit or cryo and restarting server
*   \[UseResponse\] Limited random range for projectiles, so they hit close to maximum range
*   \[UseResponse\] MotD substitutions missing
*   \[UseResponse\] Ore GPS markers stay on screen on DS
*   \[UseResponse\] Part of the Light Armor Inv. Corner 2x1x1 TIP is walkthrough
*   \[UseResponse\] Remote API – wrong name for resource
*   \[UseResponse\] SDK bin64\_profile does not have profiling or dev menu
*   \[UseResponse\] Welding/Grinding interrupted during DS saving
*   \[UseResponse\] Wheels cannot be placed if you have fenders around it
*   32bit version of VRageEditor not built in ModSDK
*   Add detection of .net framework to DS and DSGUI, fail gracefully
*   Admin feature – AI not targeting
*   Change character orientation with ship rotation change
*   Character falling in a loop on client but standing on server
*   Character parenting to surface of specific objects can lead to rubber-banding
*   Crash at Sandbox.Game.Entities.Cube.MyGridClipboard.UpdatePreviewBBo
*   Ctrl + Del combination deletes without asking
*   Default language only official
*   Desynchronisation issue with Big grid parenting
*   DS Mod Dependencies disable feature
*   Enable admin to assign ownership to offline players
*   Game almost freeze when throwing red ship to planet ground
*   Hovering ship in planet's gravity is being tilted by subgrids
*   Joining a lobby via Steam shows confirmation dialog about inviting yourself
*   Jumping on surface of flying grid rubber-bands in the direction of flight
*   Lower minimum CPU freq for DS to 3.2GHz
*   Make buttons for experimental just greyed
*   Make game remember all admin check-boxes after restart of the server
*   Mod-Crash screen polishing
*   Modded Respawn Ship icon is not working
*   One of the predefined asteroids disappears when drilling the asteroid and reconnecting
*   Outdated czech translation
*   Respawning on an already rotating grid
*   Save not blocking main thread when saving Voxels
*   Simple grid with rotor shaking on DS
*   Small ship welder and small ship grinder have small effective radius
*   Tutorials for first time players
*   Voxel changes are not synchronized (on spawned planets) on DS
*   Voxel destruction not synchronized to client when throwing Red Ship, leads to rubber-banding
*   Wheels are jumping off the surface

25/08/2018 Hotfix 1.187.204

*   fixed crash when grid is being merged to a station
*   fixed crash after collision with asteroid
*   fixed crash in respawn screen with modded respawn ships

04/09/2018 Hotfix 1.187.205

*   fixed issue with lander sinking into the planet ground on DS
*   fixed shadow flickering on AMD Vega

17/09/2018 Hotfix 1.187.206

*   added GTX gaming banner to Join Game screen
*   fixed forming of larger than normal physics clusters causing slowdowns
*   fixed lobby for friends not being joinable
*   fixed host of a Lobby game hearing others placing blocks
*   fixed hydrogen bottles not updating on HUD
*   fixed light offset not persisting through reload / reconnect / restart
*   fixed safe zone shapes being drawn incorrectly after reload

18/09/2018 Hotfix 1.187.207

*   fixed writing in multiline textboxes

21/09/2018 Hotfix 1.187.208

*   fixed crashes on extremely large worlds
*   fixed bug with newest NVIDIA drivers

28/09/2018 Hotfix 1.187.209

*   fixed access violation in large worlds
*   fixed binding IP issue for DS
