*   Fixed planets failing to appear on loading a save
*   Fixed saves not loading with mods for removing Vanilla blocks

30/10/2019 Hotfix 193.020

Changes

*   Removed additional force from dispensing Clang Kola, it phased through grids and buyers could not find it
*   Moved Small Control Seat out of Decorative Pack II and into the base version of the game

Fixes

*   Fixed a crash when trying to view info for an undefined block group in G screen
*   Fixed character's legs clipping into surface when exiting toilet
*   Fixed SafeZoneBlock not being correctly accessible for programmable block

Fixes from our support site

*   Fixed a crash when editing GPS description
*   Fixed \[\] and {} switching tabs in terminal when trying to type them into text fields
*   Fixed being forced out of iron-sights when trying to move diagonally (W+A/D), also fixed caps-lock not limiting character speed
*   Fixed inability to select empty inventories for item transfer by clicking into them
*   Fixed items being transferred into previously selected inventory instead of the filtered one
*   Fixed filled inventory scrolling up/down upon interaction when the contents did not fit the screen
*   Fixed incorrect collision model for Toilet block above functional line
*   Fixed missing control panel option for rotation speed of rotating light

01/11/2019 Hotfix 193.021

Fixes

*   Fixed inventory focus not changing correctly when switching between character/interacted/connected inventories

Fixes from our support site

*   Fixed a crash due to trying to transfer items from a third unfocused inventory with two other focused inventories
*   Fixed inventory focus not switching away from hidden/filtered out inventories
*   Fixed freight blocks containing components after being welded from a projection

14/11/2019 Hotfix 193.022

Fixes

*   Fixed a crash when reloading the game while an ore detector is working
*   Fixed a crash when character was removed from scene (unloading a scene)
*   Fixed a crash at Sandbox.Game.Entities.MySkinnedEntity.UpdateAnimation
*   Fixed a crash when a surface under a character was removed (mainly by unloading a scene in a respawn screen)
*   Fixed missing/not updating detail info on specific blocks
*   Fixed armor skin not appearing on some blocks after save & reload
*   Fixed character crouching down even on a successful Ctrl+C
*   Fixed Replay tool replaying only Victory emotes

Fixes from our support site

*   Fixed game client occasionally being frozen when exiting back to main menu
*   Fixed Lost Colony datapads in inventories not being synchronised to clients in lobbies (their max character limit was too long)

### Version [1.192.1](https://spaceengineers.wiki.gg/wiki/Version/1.192.1 "Version/1.192.1") Minor

[Reference](https://forum.keenswh.com/threads/minor-update-1-192-1-is-live.7403438/)

Release Date: 19 September 2019

**Features:** Changes

*   Increased Safe Zone activation time to 120 seconds from 30 seconds
*   Increased min and max monetary reward for Escort contracts, but decreased their reputation changes for fail(10 7)/success(15 10)

**Fixes:** Crashes

*   Fixed a crash when players without faction initiated direct trade on PER\_FACTION worlds
*   Fixed a crash in new game menu when switching to custom game tab
*   Fixed a crash when exiting steam client while game was still running

Bugs

*   Fixed trash removal Other resetting itself when General was changed by a reconnecting admin
*   Fixed ability to use hand tools in short bursts when out of suit power
*   Fixed game starting a random SP scenario when mod download failed while joining an MP session
*   Fixed admin getting kicked when changing AFK timeout to 0 and then to a different number
*   Fixed PCU transaction results not being saved after server restart
*   Fixed inability to use Build Planner through hand welder secondary action on unfinished blocks when out of suit power
*   Fixed input validation in PCU trading text field
*   Fixed Mossy skin not being mossy on small Light armor Slope/Corner/Inv.Corner blocks variants
*   Fixed Wooden skin on large half armors sides being stretched
*   Fixed exclusively ore marker signal groups not being the new golden color (when at least one signal is not an ore marker it is other color)

Solved Issues From Support Site

*   Added RequestChangeBalance to IMyPlayerCollection interface to allow adjusting NPC credits in custom factions
*   Added access to MySafeZoneBlockDefinition and MyObjectBuilder\_SafeZoneBlock
*   Fixed research not working in Escape from Mars mod scenario
*   Fixed tools stopping double-click action when LMB was held
*   Fixed inability to buy ships from NPC factions in worlds with unlimited PCU
*   Fixed thrusters not consuming any power while overridden
*   Fixed grinders still deconstructing blocks even when character turns away on DS
*   Fixed timer block not checking for ownership of set up blocks, when executing actions on them
*   Fixed inability to see remote grids connected through laser antenna beyond sync distance
*   Fixed LCD scripts with sprites not working for clients on DS and in MP
*   Fixed replay tool clone shooting in inverse direction than intended
*   Fixed an exploit which allowed players to get the location of other players

23/09/2019 Hotfix 1.192.102

*   Fixed a crash in active contracts screen
*   Fixed Mossy and Wood armor skins having their DLC dependencies switched with Silver armor skin
*   Fixed inability to paste certain grids with Safe Zones on DS
*   Fixed Safe Zone blocks in projectors making grids invisible on DS due to never streaming in for clients

01/10/2019 Hotfix 1.192.103

*   Fixed a crash at MySessionComponentTrash.UpdateTrash
*   Fixed a crash on DS for UpdateConfiguration
*   Fixed a crash in audio system
*   Fixed a crash related to spawning prefab grids
*   Fixed a crash when trying to draw a bounding box for a blueprint preview on DS

03/10/2019 Hotfix 1.192.104

*   Fixed contract grids getting instantly removed due to trash removal (owner hasn't logged in for too long)
*   Fixed a crash at MyTerminalInventoryController.TransferToOppositeFirst
*   Fixed a crash at MyGuiScreenBase.GetExclusiveInputHandler
