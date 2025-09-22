*   Fixed detail info not updating for Pistons and Rotors
*   Fixed not being able to change focus/selection in Refinery inventories due to it updating constantly
*   Fixed certain worlds freezing upon load
*   Fixed grid power indicator status not persisting through save/reload or reconnect
*   Fixed loss of authorship for players kicked from factions on PER\_PLAYER servers
*   Fixed Safezone block using only 1W after game restart
*   Fixed Corner LCDs having misaligned surface areas (and therefore not working with scripts)
*   Fixed LCD background colors not updating in real time
*   Fixed not being able to get rid of the "Steam Offline" warning

20/03/2020 Hotfix 1.194.080

*   Fixed crash at MyRenderContextState.SetVertexBuffersFast
*   Fixed crash at Profiler.MyGpuProfiler.Join
*   Fixed errors in Model Viewer
*   Fixed propulsion and steer override not working
*   Fixed texture resolution of Corner LCDs
*   Temporarily hotfixed new Gate block being always airtight

24/03/2020 Hotfix 1.194.081

*   Added Triton to Star system and Never Surrender
*   Removed Uranium from Triton
*   Removed assertions logging, should help with microstutters and load times
*   Fixed fog in the tunnels
*   Fixed exhausted NPC PCUs
*   Fixed ability to press respawn twice (lead to being stuck on DS)
*   Additional fix for VST incorrect path error message
*   Fixed a crash at MyPhysics.ProcessCollisionFilterRefreshes
*   Fixed a crash at MyRenderComponentEngineerTool.DrawHighlight
*   Fixed a crash at MyFoliageManager.FoliageBufferAllocator
*   Fixed a crash at Havok.HkRigidBody.HkRigidBody\_AddGravityAction
*   Fixed a crash at MySectorWeatherComponent.ApplyParticle
*   Fixed a crash at MyXAudio2.Update3DCuePosition
*   Fixed a crash at EntityComponents.MyThrusterBlockThrustComponent.Schedule
*   Fixed a crash at Entities.MyCubeGrid.UpdatePredictionFlag
*   Fixed a crash at MyDirectInput.EnumerateJoystickNames
*   Fixed a crash at Screens.MyGuiScreenWorldSettings.StartNewSandbox
*   Fixed a crash in a Programmable Block
*   Fixed a crash in relative dampening

06/04/2020 Hotfix 1.194.082

*   Fixed a crash when searching for blocks in terminal
*   Fixed a crash at Game.World.MySession.UpdateComponents
*   Fixed a crash at Graphics.MyGuiManager.LoadContent
*   Fixed a crash at Engine.Physics.MyPhysicsBody.get\_LinearVelocity
*   Fixed a crash at Game.GameSystems.MyGridConveyorSystem.ComputeTransferData
*   Fixed a crash at Game.SessionComponents.MySectorWeatherComponent.ApplyParticle
*   Fixed a crash when procedural asteroid had an identity crisis (game was not sure about its existence)
*   Fixed DSGUI freezing when using the Configuration buttons in the lower left corner
*   Fixed remote client not showing used up PCU when world is in PerPlayer mode

14/04/2020 Hotfix 1.194.083

*   Fixed invisible character on older GPUs

23/04/2020 Minor update 1.194.207

*   Fixed a another crash in Frostbite weather
*   Fixed a couple crashes with modded turrets
*   Fixed a crash if a scene is unloaded faster than all voxel updates finish
*   Fixed a crash in Frostbite weather while switching respawn points too fast
*   Fixed a crash in VST treating Longs as Ints
*   Fixed a crash on a ladder while remote controlling a grid
*   Fixed a crash when client loses connection while in terminal
*   Fixed a crash when teleporting while on a ladder
*   Fixed a crash when trying to replace cloud blueprint with empty clipboard
*   Fixed crash at System.Text.StringBuilder.ToString
*   Fixed crash at VRage.Render11.Resources.MyDeferredRenderContextManager.AcquireRC
*   Fixed crash at VrTailor.VrTailor\_Sew
*   Fixed being stuck in control panel by switching from production screen with a gamepad
*   Fixed being unable to scroll news using gamepad
*   Fixed blueprint screen always showing some blueprint description, even with no blueprints being shown due to filters
*   Fixed blueprint size info in blueprint screen to correct units (MB)
*   Fixed cloud blueprints not being possible to replace
*   Fixed Contextual music not playing after turning it Off/On in Options
*   Fixed Control seat near reactor being accessible to players
*   Fixed Convert to Station being enabled for small grids in some cases
*   Fixed Engineer's ragdoll on far away coordinates
*   Fixed focus highlights in control panel persisting and accumulating when closing and opening terminal
*   Fixed formating of Air vent detail info when oxygen is disabled
*   Fixed Frostbite archive drone falling down due to incorrect sensor ownership
*   Fixed Frostbite medical room quest to complete successfully
*   Fixed game incorrectly claiming mod size being 18 exabytes when downloading big mods (over Int32 max size in bytes)
*   Fixed hand tools tooltips not showing gamepad shortcuts
*   Fixed hidden items in terminal influencing navigation via arrows/gamepad
*   Fixed highlights in Frostbite remaining when they should disappear
*   Fixed in-game workshop browser not being optimized for 4:3 ratio resolutions
*   Fixed incorrect shortcut being displayed for Voxel hand settings
*   Fixed Ion thrusters effect if cut off from power
*   Fixed Lost Colony max player count being changeable while the scenario is running already
*   Fixed memory leak in in-game help
*   Fixed missing gamepad hints in Star System Respawn screen
*   Fixed missing gamepad icons in gamepad help
*   Fixed missing LT/RT hints in character screen
*   Fixed Mission 1 cutscene switching to 1st person view for a moment
*   Fixed not being possible to focus and scroll description of the BP with gamepad
*   Fixed overlapping elements in Voxel hand settings
*   Fixed production screen queue resetting the scrollbar whenever a new item is being produced
*   Fixed production screen recipes/blueprints not showing resources needed when using gamepad
*   Fixed Rename blueprint screen not being gamepad friendly
*   Fixed Respawn screen and character GUI overlapping in Never Surrender
*   Fixed shading on Armory block
*   Fixed sliders not being responsive to keyboard and gamepad inputs
*   Fixed small rocket launcher having see through textures in the front
*   Fixed triggers not being deleted with entities in scenarios
*   Fixed typo "Maintainance" in Frostbite landing site
*   Fixed typo in Frostbite "Section B Gargo Bay"
*   Fixed voxel hand sliders not being settable to 100
*   Fixed Voxel hand terrain auto-level tool not working properly with gamepads
*   Fixed Voxel hand terrain auto-level tool setting overlap
*   Fixed VST disallowing String variables on arithmetic nodes
*   Fixed world size info in Load game screen to correct units (MB)
*   Fixed Yield module having broken textures on the pipes

Fixed issues from our Support site

*   Fixed a crash when trying to load a certain world
*   Fixed a crash when using scripts to manually find targets for turrets
*   Fixed Admin Panel Scroll List
*   Fixed an issue in Remote Control screen preventing remote control of grids
*   Fixed camera control hint visible with disabled control hints
*   Fixed characters falling through the ground
*   Fixed Frostbite drones emitting clicking sounds when using actions on their remote control toolbar
*   Fixed placement alignment not changing top text correctly
*   Fixed projections wobbling around when far away from world center
*   Fixed ship toolbar not being saved for client upon reload
*   Fixed Small grid control seat not having access to pressurised oxygen in the environment
*   Fixed Turrets visually shooting in previews/projections

27/04/2020 Hotfix 1.194.208

*   Fixed Hydrogen engine incorrectly updating its Detail info
*   \[ModAPI\] Added Visual Scripting \_Local copies of receiver-side methods for client-side use
*   Fixed a crash at Gui.MyGuiBlueprintScreen\_Reworked.UpdateNameAndDescription
*   Fixed a crash at Entities.MyEntity3DSoundEmitter.CanHearSound
*   Fixed players being unable to grind blocks in worlds with Block destruction disabled

29/04/2020 Hotfix 1.194.209

*   Fixed a Dedicated server crash which corrupted saves
*   Fixed a crash at VRage.Render11.GeometryStage2.Model.MyModelFactory

05/05/2020 Hotfix 1.194.210

*   Better handling of crash when world is corrupted on DS
*   Fixed a crash at MyTerminalInventoryController
*   Fixed a crash at MyTerminalInventoryController.RefreshSelectedInventoryItem
*   Fixed a crash at PerformanceCounterLib.GetStringTable

08/05/2020 Hotfix 1.194.211

*   Fixed a crash at MyTerminalPropertiesController.PopulateMutuallyConnectedCubeGrids
*   Fixed a crash at Sandbox.Graphics.GUI.MyGuiControlBase.HandleInputElements
*   Fixed a crash at Sandbox.Graphics.GUI.MyGuiControlListbox.HandleNewMousePress
*   Fixed a crash at MyNeutralShipSpawner

Known issues:

*   Crash on older Windows 7 machines – Please ensure that you are running the most recent Windows 7 build.
*   Problems on AMD Ryzen (we are investigating it).
