*   Fixed a crash at PerformanceCounterLib.GetStringTable

08/05/2020 Hotfix 1.194.211

*   Fixed a crash at MyTerminalPropertiesController.PopulateMutuallyConnectedCubeGrids
*   Fixed a crash at Sandbox.Graphics.GUI.MyGuiControlBase.HandleInputElements
*   Fixed a crash at Sandbox.Graphics.GUI.MyGuiControlListbox.HandleNewMousePress
*   Fixed a crash at MyNeutralShipSpawner

Known issues:

*   Crash on older Windows 7 machines – Please ensure that you are running the most recent Windows 7 build.
*   Problems on AMD Ryzen (we are investigating it).

### Version [1.193.1](https://spaceengineers.wiki.gg/wiki/Version/1.193.1 "Version/1.193.1") Minor

[Reference](https://forum.keenswh.com/threads/update-1-193-1-%E2%80%93-happy-holidays.7403562/)

Release Date: 19 December 2019

**Introduction:**

Hello, Engineers!

We would like to celebrate the Holidays with all of you, our players, whether you celebrate Christmas, Hanukkah, Kwanza or any other holiday during this festive season.

Today’s release is a special one, because we are bringing you a number of “presents”. The first one, the Small Window blocks have been requested by many players, so we decided to add them to the game. There are 20 small window block variations in total, so I’m sure you’ll unleash your creativity even more now.

Another one is the Large Open Cockpit, which has also been super popular with our community. This cockpit is an addition to already existing seats, but again, we listened to our community and we decided to give it to you as a Christmas present. Finally, we are adding additional Catwalk variants into the Deco Pack 2 DLC so they look good in even more situations. This upgrade is free for everyone who already owns the Deco Pack 2.

Thank you for being such an awesome community! We hope you’ll enjoy this update and that you’ll have a great time playing Space Engineers during the holiday season.

[Youtube: Space Engineers: Holiday Update - Small Grid Windows & Large Grid Open Cockpit](https://www.youtube.com/watch?v=GGTQegnjkyI)

**Features:**

*   Added small grid versions for all 20 vanilla Window blocks
*   Added large grid version of Control Seat block
*   Added Half Stairs (Mirrored version), Grated Catwalk End, Half Left, Half Right and Railing Half Left, Half Right to Deco pack 2
*   Added festive Skybox for the holidays
*   [Space Engineers Comic](https://www.spaceengineersgame.com/comic.html)
*   Added warning for running the game with offline Steam
*   Lowered the minimum sensor range from 1 to 0.1

**Fixes:**

*   Fixed another crash at Character.MyCharacter.UpdateAnimation
*   Fixed a crash when trying to start the game with an outdated config file
*   Fixed damaged wind turbine refusing to stop spinning
*   Fixed Remote Access screen not working when the player tried to access grid from which the remote access was initiated
*   Fixed DLC requirements icons stacking diagonally in blueprint screen (Now stack horizontally)
*   Fixed rivets on blocks not changing with skin properly
*   Fixed Hydrogen Engines not burning when damaged
*   Fixed textures of clip decals on various blocks (See freight blocks)

Fixed issues from our Support site

*   Fixed server not synchronizing missiles from turrets when idle movement was turned off
*   Fixed inability to crouch when crouch was rebound to Ctrl
*   Fixed not being able to open terminal through remote control
*   Fixed inability to unlock Personality Crisis achievement
*   Fixed thruster components being incorrectly added to welding stockpile upon save/reload
*   Fixed players getting stuck in respawn screen by character dying with an open chat (Can now press enter to get rid of it)
*   Fixed mount points for Grated stairs and Half Stairs
*   Fixed inability to finish task near "Drone Waypoint" in Learning to Survive
*   Fixed mount points for Steel Catwalk Plate

23/12/2019 Hotfix 193.103

Fixes

*   Fixed crashes when scrolling through the grated catwalk versions on a mirrored grid
*   Fixed amounts of ice and possibly other stacks going into negatives in inventories on DS

### Version [1.193](https://spaceengineers.wiki.gg/wiki/Version/1.193 "Version/1.193") Major

[Reference](https://forum.keenswh.com/threads/update-1-193-6th-anniversary-decorative-pack-ii.7403489/)

Release Date: 24 October 2019

**Introduction:**

Hello, Engineers!

It’s hard to believe, but Space Engineers was released six years ago. It seems like yesterday, but I think the time always runs very fast with the things you love. It would take the entire blog post to mention all names and people who contributed to the success of Space Engineers. But it were not only my colleagues who I’d like to thank, it’s also you, our players and modders, who helped us to shape the game, gave us great ideas and who constantly provided us with feedback.

This update is full of new things, improvements and surprises. We combined the things which were inspired by you, with the things we think you will like. With this release, we are also releasing the Xbox optimizations and improved controller support.

Similar to our previous major releases, we decided to give you an opportunity to support the further development of Space Engineers. We have created a pack which consists of cosmetic items designed to enrich your game visually. The package is the second edition of [the Decorative Pack](https://store.steampowered.com/app/1049790/Space_Engineers__Decorative_Pack/), which was released back in April this year. None of the things in the package brings any advantage to players who purchase this DLC. The price of [the Decorative Pack II](https://store.steampowered.com/app/1167910/) is $3.99 USD, or your regional Steam equivalent, so if you wish to support us, check out the Decorative Pack II on Steam.

[Youtube: Space Engineers: 6th Anniversary Update & Decorative Pack II](https://www.youtube.com/watch?v=6vIX9xpUhMA)

[Youtube: Space Engineers: Anniversary Compilation](https://www.youtube.com/watch?v=HwFuCRC_HtE)

[Marek's blog post](https://blog.marekrosa.org/2019/10/space-engineers-6th-anniversary.html)

**Features:** Main Features & Changes

*   Added Small Ladder Block
*   Added New World Scenario: Lost Colony
*   Added New Armor Skins:
    *   Battered Armor Skin
    *   Rusty Armor Skin
*   Improved Controller Support (still work in progress)
*   A newly added GPS is now automatically selected in the GPS list
*   Added Control Gyros checkbox to cockpits to allow/disallow control of gyroscopes from that cockpit
*   Any player can now use Store and Contract blocks which are owned by other players and set to Anyone Can Use (NPC owned blocks cannot be used this way for gameplay reasons)
*   Deleting a GPS from the list now automatically selects another GPS if there is any
*   It is now possible to manage Store block orders/offers by Programmable Blocks
*   Made "MyStoreItemData" events "OnTransaction", "OnCancel" ModAPI only (previously were available to Programmable block)
*   Moved Enable sun rotation advanced world setting above the Day duration slider
*   Reputation notifications now aggregate
*   Language updates
    *   Updated Portuguese BR-PT localization
    *   Updated Spanish localization

Decorative Pack II

*   Dispenser
*   Jukebox
*   Small Control Seat
*   Lab Equipment
*   Shower
*   Window Walls
*   Medical Station
*   Transparent LCD
*   Grated Catwalks
*   Grated Stairs and Half Stairs
*   Railings
*   Rotating Light
*   Freight

**Fixes:**

*   Fixed connectors staying connected when damaged
*   Fixed a crash at Sandbox.Game.AI.MyAiTargetBase.GetRandomDirectedPosition
*   Fixed a crash at VRage.Audio.MyCueBank.Update
*   Fixed a crash when removing old identities
*   Fixed a crash in OnControlAcquired in ship welders
*   Fixed a crash in physics that allowed players to jump away with an asteroid or part of a planet surface
*   Fixed server incorrectly computing the center of rotation for merged grids, thus confusing client prediction
*   Fixed Autopilot not activating in Campaign Mission 3
*   Fixed character trash removal setting for offline players activating immediately when set to 0 (Zero now means Disabled again)
*   Fixed game still accepting inputs after player tabbed to some other application during starting up SE
*   Fixed stone appearing in inventories where it should not be appearing
*   Fixed the strength of the gyroscope of the surveillance camera in the Campaign Mission 4 Hangar
*   Fixed show current ship inventories filter not switching back to show all inventories
*   Fixed ship inventory volume not updating when buying Hydrogen from NPC stations
*   Fixed PCUs not being correctly transferred when traded via Player to Player trading
*   Fixed character getting stuck in no gravity in Campaign Mission 1 by jumping near a Medical room
*   Fixed display component texture
*   Fixed LCDs for powered blocks not updating when those blocks are damaged below functional
*   Fixed spotlights casting incorrect or offset shadows after switching between graphical settings
*   Fixed incorrect message showing up when trying to accept an invite into a game which no longer exists
*   Fixed another instance of a black octagon appearing on the screen
*   Fixed Ultrawide screen resolutions allowing to see around respawn screen cover
*   Fixed incorrect help screen keybinds for color picker
*   Fixed the ability to see NPCs listed in ownership drop-down menu without creative (tools)
*   Fixed Contract block emissivity not being visible from larger distance
*   Fixed missiles teleporting through ship armor layers
*   Fixed a crash when trying to deposit credits into faction using arrow keys
*   Fixed "Smile and Wave" achievement not working
*   Fixed spotlights flickering lights through grids
*   Fixed an inventory exploit
*   Fixed servers not starting with specific GPS names
*   Fixed a crash when trying to access an empty waypoint. Invalid waypoint will now return MyWaypointInfo.Empty when calling IsEmpty() method
*   Fixed item mass not being counted towards grids which have been split
*   Fixed landing gear connection making connected grids count as one entity in entity list
*   Fixed getting two achievements just by creating a faction as a new player
*   Fixed shadow quality not refreshing when changing only it in the options
*   Fixed connectors disconnecting all at once when trying to dock to a complex base
*   Fixed ship welder not being able to show which block is targeted (what is the percentage and what components are missing)
*   Fixed "Tool shake" advanced world setting tooltip being inaccurate
*   Fixed block preview not showing selected armor skin in the preview
*   Fixed passage levels of detail not blending correctly
*   Fixed armor locker mirroring
*   Fixed spectator flashlight being vertical instead of horizontal
*   Fixed MyFactionDefinition "DefaultRelation" to accept Neutral as a valid relation (Friends works partially)

25/10/2019 Hotfix 193.019

*   Fixed a crash when selecting a block from toolbar caused by old version of .NET Framework (Runtime) installation
*   Fixed a crash when trying to select non-existent block size/variant for a modded block
*   Fixed a crash when trying to load a world with a modded HUD
*   Fixed a crash when loading the game with Chinese translation
*   Fixed a crash when manipulating tracks for Jukeboxes and Soundblocks
*   Fixed a crash when changing character model to non-humans
*   Fixed PlanetGeneratorDefinitions.sbc making all planets strictly spherical
*   Fixed planets failing to appear on loading a save
*   Fixed saves not loading with mods for removing Vanilla blocks

30/10/2019 Hotfix 193.020

Changes

*   Removed additional force from dispensing Clang Kola, it phased through grids and buyers could not find it
*   Moved Small Control Seat out of Decorative Pack II and into the base version of the game

Fixes

*   Fixed a crash when trying to view info for an undefined block group in G screen
*   Fixed character's legs clipping into surface when exiting toilet