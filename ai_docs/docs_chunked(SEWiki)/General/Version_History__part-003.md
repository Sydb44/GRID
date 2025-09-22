*   Fixed a crash when loading a world with larger planets
*   Fixed a crash and disappearance of local blueprints when renaming a BP with a "
*   Added functionality where admins with "Untargettable" enabled will not be struck by lightning
*   Updated lightning rod functionality for decoys (Range of protection 50m, changed info and good.bot)
*   Fixed lightning being too agressive and too damaging on DS
*   Fixed the Sun being dimmer and emitting less light when rotation is turned off
*   Fixed Neon Tubes not being emissive on sub-grids

13/07/2020 Hotfix 195.024

*   Fixed game freeze on AMD and Intel processors
*   Fixed UK#5 Server crash during load
*   Fixed a crash in weather when processing decoys

### Version [1.194](https://spaceengineers.wiki.gg/wiki/Version/1.194 "Version/1.194") Major

[Reference](https://forum.keenswh.com/threads/update-1-194-new-planet-triton-visual-scripting-tool-overhaul-frostbite-pack.7403728/)

Release Date: 19 March 2020

**Introduction:**

Hello, Engineers! Here we go with the first major update of 2020 - we hope you’ll enjoy it!

We added Small Hydrogen Tank and a handcrafted planet Triton, which features a breathtaking snowy and frozen landscape, that players can explore and build across.

We are very fortunate to have such a creative and driven modding community. We recently had the opportunity to work closely with a member of that community, the incredibly talented Jakaria. The result is Scripted Weather, which you can experience now, in the new Frostbite scenario!

Visual Scripting Tool has been reworked - it is provided to our players to allow them to create their own campaigns, stories and more complex experience than it is possible with modding and programmable blocks. This tool’s UI has been redone and major bugs in Visual Scripting Tool, as well as the scripting engine, have been fixed.

We also added full support for Gamepad, changed UI visuals, done more Simulation and Render optimizations and much more!

**Frostbite Pack DLC**

Similar to our previous major releases, we decided to give you an opportunity to support the further development of Space Engineers. We have created a pack which consists of cosmetic items and the Frostbite scenario designed to enrich your game visually. None of the things in the package brings any advantage to players who purchase this DLC. The price of the Frostbite Pack is $3.99 USD, or your regional Steam equivalent, so if you wish to support us, check out the [Frostbite Pack](https://store.steampowered.com/app/1241550/).

**Frostbite Scenario**

You are a member of a salvage crew, which has been tasked by a mysterious client to acquire something extremely valuable (yet unknown) on Triton. Play solo or with up to four players; explore this moon’s frigid landscape and remarkable architecture, and overcome numerous engineering challenges as you uncover this world’s secrets. The scenario gives you several hours of gameplay. We’d also like to thank several members of the Space Engineers community, who contributed voice-over recordings for the new Frostbite scenario: Naburine and DirectedEnergy of Ball&ChainGaming & Misfit Studios (creators of Protocol 51), Nathan "Silverbane" Steen, Skyler "Gorhamian" Gorham, Jacob "wearsglasses" Ruttenberg. [Youtube: Space Engineers: Update 1.194 - New Planet Triton, VST Overhaul & Frostbite Pack](https://store.steampowered.com/app/1241550/)

[Marek's Blog post](https://blog.marekrosa.org/2020/03/space-engineers-frostbite.html)

**Features:** Features & Improvements

*   Visual Scripting Tool overhaul; Guide: [https://www.spaceengineersgame.com/visual-scripting-tool.html](https://www.spaceengineersgame.com/visual-scripting-tool.html)
*   Small Hydrogen Tank (for both Large and Small Grid)
*   New Planet: Triton (spawnable through admin spawn menu)
*   Scripted Weather Effects
*   New Workshop Browser screen instead of Steam overlay
*   Added 3rd person zoom speed slider into Controls (0-100%)
*   Full support for Gamepad
*   Added Gamepad help and hints to the UI
*   Added Gamepad scheme feature. You can change Gamepad scheme in the Controls screen.
*   Added invert Y options (Controls screen) for controller
*   Crosshair can now be hidden with the UI (can be set in Game Options)
*   Control Stations block now switches view to 3rd person view by default
*   Shooting is now possible while sprinting, but slows down sprint to run speed
*   Servers should now be less likely in a state where they stop responding while connecting, downloading mods, etc.
*   Changed Reactor block description to better inform players about Uranium
*   UI visual changes
*   Color Picker screen has its own control binding now
*   Simulation and Render optimizations
*   CPU particles support removed
*   Controls changes to be more user friendly (the first screen)

The Frostbite Pack DLC

*   Frostbite Scenario (co-op, up to 4 online players)
*   Frozen Armor Skin
*   Antenna Dish Block
*   Gate Block
*   Offset Door Block
*   6 different Dead Astronaut Blocks (Freight Container alternatives)
*   Emotes: Check Wrist and Cold
*   7 LCD Posters

Visual Scripting Tool - Features & Changes

*   Added a node for setting saving to enabled/disabled
*   Added ability to add existing scripts
*   Added ability to rename triggers in-game
*   Added BlockAction event
*   Added color differentiation to connections
*   Added Delay node
*   Added function nodes into Toolbox
*   Added GetAdmins node
*   Added GetEntitiesInSphere node
*   Added keyboard shortcuts for spawning nodes
*   Added new List types
*   Added nodes GetPlayersID and GetPlayerCount
*   Added Object reference enumeration
*   Added OnBlockDamaged event
*   Added Parse nodes
*   Added possibility to spawn prefabs in gravity
*   Added scenario editor entity organizer
*   Added Search all / Find functionality to the editor
*   Added SetPlayerHelmetStatus node
*   Added StoreList and LoadList
*   Added support for opening older scripts
*   Content directory is now pre-selected by default
*   Improved in-game scripting tool (IST) gizmo to always keep relative size regardless of distance from camera
*   Improved scenario editor performance with large graphs
*   Increased usability of a comment node
*   Made multi-select more consistent
*   Scenarios can now be run directly from VST
*   Streamlined New scenario creation
*   Triggers can now be attached to blocks directly as opposed to whole grids

*   "Open in the browser" is more visible while focused in Help screen tutorials
*   Added a few full oxygen bottles to Frostbite to help players breathing in high altitude areas
*   Added ability to change ordering of saved games with gamepad
*   Added Area interaction to game options (ON by default)
*   Added gamepad help to Contract Administration screen
*   Added gamepad help to Server Details screen
*   Added gamepad hints to Contract administration screen
*   Added inventory filter info for gamepad
*   Added inventory items help in tooltip for gamepad
*   Added missing gamepad controls to Advanced gamepad help
*   Added more ammunition to certain heavy drones in Frostbite
*   Added paste GPS into chat feature for gamepad
*   Added Production help in tooltip for gamepad
*   Added tab gamepad help to Advanced Server search screen
*   Added tab gamepad help to Contract screen
*   Added tab gamepad help to New Game screen
*   Added tab gamepad help to Store block screen
*   Added Vertical thrust (Flight alternative) into help
*   Adjusted airtightness for Gate block and added front and back mount points
*   Adjusted font size on Archives trailer LCDs in Frostbite
*   Adjusted weather loop for Frostbite to not contain heavy fog and shortened heavy snow
*   Blueprints can be unequipped by Empty Hand in the Radial menu
*   Changed how objects in the world are highlighted by default to distance from crosshair based system (Currently on floating objects only)
*   Changed various controls (Dampeners, Car jump, Block size) for gamepad
*   Clarified in what units the duration is in Economy Contracts administration screen
*   Color picker now has only one correct shortcut: RB-DPadDown on gamepad
*   Help screen (fonts and icons) are bigger so it's easier to read on big screen
*   New help videos added for gamepad
*   Removed obsolete development Share with all groups from Frostbite
*   Removed the ability to grind down starting drop ship in Frostbite
*   Simplified Blueprint screen, Info and Edit merged into one tab
*   Updated Polish translation (including scenarios)
*   Updated Russian localization
*   Updated Spanish translation (including scenarios)

**Fixes:** Bugfixes

*   Fixed Dedicated Server auto-restart not working when the server was started as a service
*   Fixed a crash which could occur when opening control panel
*   Fixed a crash when an oxygen tank refils an oxygen bottle
*   Fixed a crash when clicking into a multi-line text field
*   Fixed a Programmable Block script crashing the game
*   Fixed a turret in second First Jump mission not rotating towards the character
*   Fixed sensor range not persisting through save/reload when set to values below 1
*   Fixed whisper conversations being visible to everyone in the Lobby
*   Fixed missing or not updating detail info on blocks
*   Fixed trash removal taking all connected grids when removing grids belonging to inactive players
*   Fixed infinite "Waiting for server to respond" for reconnecting unbanned players
*   Fixed wheeled vehicles controls getting stuck when opening UI while driving/braking
*   Fixed NPC station safezones not despawning correctly when there are no players/grids around
*   Fixed safezone whitelist not being propagated to others
*   Fixed production queue rearrangement also responding to dragging the items into inventory
*   Fixed emmisive colors on conveyor tubes
*   Fixed armor skins affecting LCDs
*   Fixed vending machine offers not being synced to players without access rights
*   Fixed Lost Colony being considered Experimental, therefore not loadable in Safe Mode
*   Fixed non-loopable Sound block sounds being loopable when they shouldn't
*   Fixed an exploit with inventories
*   Fixed getting disconnected from Terminal hwen accessing it through remote control
*   Fixed change of light intensity not being propagated to others when triggered by a programmable block
*   Fixed multi-line text fields not working with Home/End keys properly
*   Fixed medical room not updating its LCDs when turned on
*   Fixed multi-line text fields not responding to arrow keys properly
*   Fixed "Spawn into targeted container" not working on Freight containers
*   Fixed Artificial Mass block detail info not updating
*   Fixed LCDs not updating detail info (power usage)
*   Fixed O2/H2 Generator having "h2/o2" instead of O2/H2
*   Fixed unscrollable descriptions being scrolled by scrolling a different scrollable descriptions in G screen

Fixed issues from our Support site

*   Fixed a crash when pasting a blueprint with projections
*   Fixed a crash when clicking into a Datapad while editing it
*   Fixed Vending machines not keeping offers through save/reload
*   Fixed researched blocks not appearing in all relevant G screen categories
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