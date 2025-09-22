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

## Beta Versions

### Version [1.188.1](https://spaceengineers.wiki.gg/wiki/Version/1.188.1 "Version/1.188.1") Minor

[Reference](https://forum.keenswh.com/threads/update-1-188-1-%E2%80%93-minor-improvements.7402160/)

Release Date: 19 November 2018

**Introduction:**

Hello, Engineers! Today's minor update brings you more improvements in Airtightness, UI and Scripts. There are also bunch of fixes for issues found by our community. Thanks for reporting them - it really helps us locate and fix everything!

If you want to help, please visit our new support page and make a report: [https://support.keenswh.com/](https://support.keenswh.com/)

**Features:** New features and changes from the support site

Airtightness

*   Added missing airtightness tags for blocks that did not have it defined

Blueprint screen

*   Added automatically selecting newly created blueprint

UI

*   Added navigation by arrow keys to blueprint screen
*   Improved color coding for block rotation hints cube

New features and changes

Security

*   Added security checking for distance and ownership
*   Added server-side checking for specific actions not being called by a client
*   Improved checking for player rights associated with player ranks
*   Improved kicking of banned players
*   Improved security when deciding whether player has access to block, grid

UI

*   Added thumbnails on mouse-over in blueprint screen when thumbnails are hidden in the list
*   Improved spawn menu screen

Voxels

*   Added new asteroid density setting (Lowest) to advanced world settings
*   Improved voxel deformations in head-on collisions

Workshop

*   Added NPC tag for mods

[Rank System Rules](https://docs.google.com/document/d/1TDI5AY343SALt5bJAnVeqALFR7VHGsMm-zOB_GgLXqY)

**Fixes:** Fixes from the support site

Airtightness

*   Fixed airtightness not being precise at supported far away coordinates
*   Fixed door being airtight while not fully closed/open

Multiplayer

*   Fixed antennas and beacons not being synced beyond sync distance
*   Fixed connector disconnecting on player reconnect
*   Fixed handbrake status not being properly synchronised to players

Render

*   Fixed ghosted texts on LCDs

Gameplay

*   Fixed connectors disconnecting when the grid lost power for one frame
*   Fixed connectors disconnecting on save/reload

Scripts

*   Fixed programmable block being compiled in preview or in projection

UI

*   Fixed control menu allowing access to admin screen without permission
*   Fixed block hints for previous block showing up when current block does not have a hint
*   Fixed connected inventories not remembering local/connected
*   Fixed HUD elements showing up after reload when they should be hidden
*   Fixed information not showing up about items that can be picked up when control hints are turned off
*   Fixed only small ship variant description appearing in G screen, regardless what size was selected
*   Fixed rotor angle not showing up at all times
*   Fixed typos in advance world settings tooltips
*   Fixed workshop screen unnecessarily refreshing content when sorting and a thumbnail issue
*   Fixed wrong world name of Easy start space when launched as a lobby from scenarios

Voxels

*   Fixed inconsistent sync and view distances for procedural asteroids on DS or Lobby
*   Fixed multiple types of ice not being detected by ore detector
*   Fixed ore detector not detecting ores in specific ranges

Workshop

*   Fixed mod workshop title getting renamed to folder name every time the mod was updated

Fixes

*   Airtightness
*   Fixed passenger seat being airtight
*   Camera
*   Fixed clipping with hand tools when crouching in first person view
*   Misc
*   Fixed suspension jump remaining charged when control of the vehicle was released
*   Multiplayer
*   Fixed procedural asteroids not being properly removed for all clients across the server
*   Physics
*   Fixed dynamic grid vs static grid deformation
*   Fixed grid deformation in head on collision with voxel
*   Render
*   Fixed shadows culling as if they were seen only from light source's point of view
*   Fixed solar panel bottom edges being rendered over everything
*   Security
*   Fixed admins of a lobby not being able to kick players
*   Fixed bulk changes to sharing access setting affecting even blocks you did not have access to
*   Skins
*   Fixed skin crafting for tokens actually requiring one token more than advertised
*   UI
*   Fixed autosave happening while attempting quick reload
*   Fixed blueprint screen readjusting the list after searching and selecting
*   Fixed character getting killed due to Yes being selected when trying to cancel cockpit removal by pressing Esc
*   Fixed double-click not doing intuitive actions in several UI screens
*   Fixed faces of block rotation hints cube changing layers when moving at higher speeds causes "stardust effect"
*   Fixed Good.bot hints not disappearing when disabling them
*   Fixed rotation hints cube being rendered in layer under safezone
*   Fixed tooltip for auto-healing not reflecting the new airtightness functionality

  
22/11/2018 Hotfix 1.188.104

*   Fixed various crashes
*   Fixed various security issues

14/12/2018 Hotfix 1.188.105

*   Fixed security issues with GPS and explosions

### Version [1.188.0](https://spaceengineers.wiki.gg/wiki/Version/1.188.0 "Version/1.188.0") Major

[Reference](https://forum.keenswh.com/threads/update-1-188-airtightness-in-game-help-relative-dampening.7402093/)

Release Date: 23 October 2018

**Introduction:**

Hello, Engineers!

It’s time for another major update! We are happy to share a lot of exciting news and updates about several things we’ve been working on during the past three months. This update is much bigger than we expected and is focusing on better player experience. It’s also addressing a lot of requests we received from you, our great community: Airtightness improvements, relative inertia dampeners, better in-game help and much more! Coincidentally, it’s also the fifth anniversary of Space Engineers being released in Early Access! A MASSIVE thank you to everyone who has supported us since we launched the game and welcome to all of the new Engineers.

Marek's blog post with detailed info: [https://blog.marekrosa.org/2018/10/space-engineers-airtightness\_23.html](https://blog.marekrosa.org/2018/10/space-engineers-airtightness_23.html)

[Youtube: Space Engineers - Update 1.188 - Airtightness & In-Game Help](https://www.youtube.com/watch?v=XWp2oVLMxyY)

**Features:** Main Features

*   Airtightness performance improvements and changes
*   New in-game help - contextual help and tutorial objectives
*   Asteroid clusters, added 51 new predefined asteroid shapes
*   New Relative inertia dampeners (thanks to Rexxar)
*   Render performance improvements - Occlusion Culling and optimizations
*   Good.bot chatbot
*   New Steam Workshop integration - faster and supports very large mods (>2 GB)
*   New Blueprint screen
*   New Script screen
*   Better rendering of grass
*   New Game screen changes

Features available without the experimental mode now

*   Hosted Multiplayer game
*   Advanced options for the world
*   Worlds from the Steam Workshop
*   Cargo ships
*   Random encounters
*   Airtightness
*   Realistic sound
*   FOV setting

New Features or changes

*   Added autoselect of created blueprint in the blueprint screen
*   Blueprint screen remembers filtering and sorting options
*   Added screenshots to cloud blueprints
*   Added functionality to always show Hidden blocks through which you are accessing the terminal
*   Changes in the control menu - added key bind and more options
*   All custom worlds have airtightness turned on by default now
*   Added in-game help
*   Changed downloading of mods to use Steam UGC API
*   Added information dialog when player can not use jump drive
*   Added programmable block feature to Mod API - same construct methods (by Malware)
*   Changed default setting for procedural density in the custom worlds to Normal (0.35 value)
*   Removed Flora density option. It was not used anymore.
*   Removed Start in respawn screen option. It was not used anymore.
*   Changed Good.bot, Rebel and Markus chat sound
*   Changed publishing of mods to use Steam UGC API
*   Added Teleport to safe zone feature for admins
*   Added warning when there is issue with 3rd party modification

**Fixes:** Gameplay Fixes

*   Fixed visual glitches (holes) in newly spawned procedural asteroids
*   Fixed visor status changes done inside medical room not being synchronized through server
*   Fixed sound of leaking oxygen in campaign being too quiet
*   Fixed predefined asteroids not streaming back after un-streaming
*   Fixed players with experimental mode being able to set unsafe values on safe servers
*   Fixed oxygen issue in the Mission 1 where you could run out of oxygen due to not enough ice
*   Fixed o2/h2 generator using power after running out of ice
*   Fixed loss of character control after merging grids that were remotely controlled
*   Fixed incorrect airtightness of open sliding doors
*   Fixed hand tools continuing to produce sounds and animations after energy has been depleted
*   Fixed gyroscopes actively trying to spin grids even after the input for doing so has been stopped
*   Fixed grids not updating airtight rooms after being merged
*   Fixed floating objects not producing sounds when falling onto surfaces
*   Fixed door wings misbehaving after merging two grids together
*   Fixed deleted procedural asteroids reappearing after save and reload
*   Fixed damaged connector changing indication to red instead of black for other player in the same session
*   Fixed damaged connector changing indication to red instead of black after save and reload
*   Fixed character walking on rotating surfaces
*   Fixed blueprint preview incorrectly showing up in Survival after double-click in a blueprint screen
*   Fixed aborted space jumps not being propagated to the server and subsequently other players

UI Fixes

*   Fixed some UI elements not being affected by UI opacity and UI background opacity settings
*   Fixed rotor detailed info about rotor lock appearing only for a fraction of a second
*   Fixed replacing blueprints from clipboard not working for blueprints in nested folders
*   Fixed HUD state (UI visibility status changed with Tab) not being saved between sessions
*   Fixed dead wolves and spiders showing icons as if they were disconnected players
*   Fixed caret moving too fast when editing text with arrows

Visual Fixes

*   Fixed holes in distant shadows

Performance Fixes

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