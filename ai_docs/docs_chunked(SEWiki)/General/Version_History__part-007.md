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

### Version [1.192.0](https://spaceengineers.wiki.gg/wiki/Version/1.192.0 "Version/1.192.0") Major

[Reference](https://forum.keenswh.com/threads/update-1-192-economy.7403364/)

Release Date: 22 August 2019

**Introduction:**

Hello, Engineers!

The last couple of months were busy in Keen. We were working on another major update, which we are releasing today. Many of you have participated on our public tests, so you probably know that the update is about the new economy system we are bringing into the game.

Regarding existing feature polish, we have addressed a record amount of long term issues and bugs, so many thanks to our incredible community for their continuous support and patience. There really is something for everyone in this update!

All new game features related to the economy are free of charge. The free update includes the economy code updates, the safe zones, all the contract features and long term fixes. For players who wish to support the further development of Space Engineers, we have created a Pack which consists of cosmetic items designed to enrich your game. The price of the Economy Deluxe pack is $3.99USD, or your regional Steam equivalent. So if you wish to support us, check out the [Economy Deluxe Pack on Steam](https://store.steampowered.com/app/1135960).

[Youtube: Space Engineers: Economy Update, Economy Deluxe Pack & Free Additions to Previous DLCs](https://www.youtube.com/watch?v=iz9JdUfmQO4)

[Marek's blog post](https://blog.marekrosa.org/2019/08/space-engineers-economy-update.html)

**Features:** Main features

*   NPC Trading Stations - AI controlled store and contracts
*   Contracts - generated and player made
*   New Blocks - Store, Contracts, and Safe Zone
*   New items - Datapad, Zone Chip
*   Faction Reputation
*   Ingame Currency - Space Credits
*   Player to Player Trading
*   New Admin Tools Features - for trash cleaner and for economy
*   Consumables - Medkit and Powerkit

Economy Deluxe Pack

*   Vending Machine - a variation of the Store block supporting new direct UI
*   ATM - a variation of Store block supporting only withdraw/deposit of Space Credits
*   Miner suit
*   Soldier suit
*   Disco armor skin
*   Glamour armor skin
*   Silver armor skin
*   14 Safe Zone skins
*   32 faction logos

Free Additions to existing DLCs

Our community is very important to us and as we were working on this release we’ve decided to surprise you by one decision: we are adding new things to already existing DLCs. Everyone who owns particular DLC will get the following things for free:

Additions to [Space Engineers Deluxe Edition](https://store.steampowered.com/app/573160/Space_Engineers_Deluxe/)

*   Golden armor skin
*   [New track from Karel Antonin](https://www.youtube.com/watch?v=OA38YkepdfA&feature=youtu.be)
*   Comic concept art

Additions to [Decorative Pack](https://store.steampowered.com/app/1049790/Space_Engineers__Decorative_Pack/)

*   Corner couch
*   Toilet version with the door entrance
*   Desk without chair (straight and corner)

Additions to [Style pack](https://store.steampowered.com/app/1084680/Space_Engineers__Style_Pack/)

*   Retro suit
*   Ghillie suit
*   Wood armor skin
*   Moss armor skin

New Features and Changes

*   Economy
    *   Star System custom world with turned on economy and changed the settings for that gameplay.
    *   If you want to play it in an older world, you have to turn it on in the world settings (Advances Settings in game, Dedicated Server UI for multiplayer).
*   Store block
    *   AI generated store content for NPC Store block
    *   Player can buy items, gas or ships from the NPC Store
    *   Player can sell items
    *   Support for player created store items
    *   Cashback feature for withdraw/deposit ingame currency as physical item
*   Contracts block
    *   AI generated contracts for NPC Contracts block
    *   Support for player created contracts
*   Contracts
    *   Hauling contract
    *   Acquisition contract
    *   Escort contract
    *   Search contract
    *   Repair contract
    *   Bounty contract
*   Generated contracts for every NPC Contracts block
*   Safe Zone block
*   Safe Zone coloring and support for new visualisation of the safe area
*   Added more Safe Zone features
    *   Allow convert to station
    *   Allow landing gear lock
*   Space Credits - new ingame currency
*   Medkit consumable - gives health when used
*   Powerkit consumable - gives suit energy when used
*   Zone Chip - item for Safe Zone block
*   Datapad - content item
*   Package item for Hauling contract
*   Faction reputation
*   Player to player trading
*   Added factions filter
*   NPC trading stations
*   Generated NPC Factions
*   Faction logo
    *   New UI for selecting faction logo
    *   Client side script for the LCDs to show your faction logo.
*   Faction background and icon colors
*   Faction bank account
*   Cargo ships changes
    *   They can spawn as one of the NPC factions
*   Support for multi grids (cars etc.) for Console block
*   Added terminal panel anyone can use checkbox for Doors, Store and Contract block
*   Trade mode for Connector
    *   This allows you a safe way to access other grids and disables power/gas transfer. Also connected grid can not manipulate items through that Connector.
    *   After disconnecting there is an interval when player can not connect again.
*   Timeout feature for Connector
    *   Player can set timeout when connector auto-disconnects connected grid.
*   Ore deposit HUD icon color was changed to khaki to be more visible with several beacon/antenna icons at the same time.
*   Trash cleaner new features
    *   AFK Disconnect - disconnects player after a certain amount of time when player is inactive.
    *   Stop grids after a certain amount of time when player is not connected.
    *   Remove Old Identities feature.
*   Admin features
    *   Ignore PCU feature
    *   Ignore Safe Zone feature
*   New world session settings for dedicated servers
    *   For ore deposit - amount and size on asteroids
    *   For drills - new harvesting ratio multiplier
    *   For economy - you can turn off Bounty Contracts, change economy tick, set station generator ranges
*   Added reset Good.bot hints button in the options.
*   Added two new achievements - Millionaire Club, Friend of the Factions
*   Updated Russian, Chinese, French and Turkish localization.

**Fixes:**

*   Fixed Air Vent displaying yellow error lights when depressurizing in open air.
*   Fixed assigning ownership of any block.
*   Fixed mods failing to create terminal controls (error included).
*   Fixed highlighted inventory item loses selection when mouse moves to blank area.
*   Fixed NPC behavior that attached to remote control is not reset after built in projector.
*   Fixed rare cases of inventory desynchronization.
*   Fixed large amount of hydrogen thrusters causing simulation speed drop.
*   Fixed an ALT key issue when looking around in first person and messing up camera.
*   Fixed issue when controlling non moving ship and jumping around when ejecting floating objects.
*   Fixed Interior/Corner light with high offset causing flickering.
*   Fixed Build Planner reporting "## component(s) could not be deposited" incorrectly.
*   Fixed removing voxel mod breaks the world.
*   Fixed issue when player is unable to weld/grind Cargo ship's block in multiplayer.
*   Fixed issue when checking Add to Favorites joined server.
*   Fixed issue when Alt-Tab changed the HUD mode.
*   Fixed armor slope 2x1x1 pattern.
*   Fixed astronaut position changing after save/reload and switching view.
*   Fixed autopilot on huge ships in atmosphere failing to reach a single GPS waypoint.
*   Fixed camera not resetting when pressing V.
*   Fixed issue when admin could not change sharing of the enemy block with turned on Access to all terminals feature.
*   Fixed issue when character on ladder was being moved around with the grid.
*   Fixed character status while climbing ladder is desynced after reconnect.
*   Fixed client desynchronization after merging grid.
*   Fixed crash when using Jump Drive with a grid with connector in yellow state.
*   Fixed damaged small armor LOD1 holes.
*   Fixed deformed interior wall visually detaching from surrounding armor.
*   Fixed FPS drop when pasting ship with scripts.
*   Fixed Good.Bot AI oxygen alert.
*   Fixed half armor blocks texture pattern.
*   Fixed half armor slope shifted UVs.
*   Fixed issue with hands keeps shaking when grinder stops for other players view.
*   Fixed icons for air vent actions are not being saved in multiplayer.
*   Fixed issue that player could not die due to suffocation in a Safe Zone area.
*   Fixed issue in Learning to Survive scenario that Good.bot task disappears after save / reload.
*   Fixed issue when merging can stop atmo-thruster animation.
*   Fixed missing thumbnail when creating new blueprint from clipboard.
*   Fixed issue when multiple pasted asteroids could not be edited by voxel hand.
*   Fixed multiplayer desync issue with ore boulders.
*   Fixed missing warning when using disabled voxel hand.
*   Fixed issue when PCUs in Info tab of Terminal screen were not updating properly.
*   Fixed planet yellow filter switching on and off.
*   Fixed Round Armor Slope texture pattern.
*   Fixed issue with rubber banding when jumping.
*   Fixed issue when activation of activated ship drill would stop animation.
*   Fixed ship drill not moving after /save command.
*   Fixed small landing gear and small decoy LODs.
*   Fixed issue of some armors having wrong texture scale.
*   Fixed issue of some block inventories not updating grid mass.
*   Fixed issue when turret does not target grid in range after reload in multiplayer.
*   Fixed issue when unpowered or turned off Programmable block LCD was still on.
*   Fixed issue when using CTRL+V with empty clipboard in survival changes your viewpoint.
*   Fixed vulture drone behavior.
*   Fixed wrong armor skin being highlighted upon returning to color picker screen.
*   Fixed several AI issues when controlling ships.
*   Fixed desync when switching landing gear status through toolbar while it is attached by autolock.
*   Fixed missing settings for 1x1 small battery - PCU, particle effects, sounds.
*   Fixed C# language regression from the last Major update. Supported language is C# 6 or lower again.
*   Fixed issue with #pragma warning. This directive is prohibited to use now.
*   Fixed various English language bugs.

23/08/2019 Hotfix 1.192.020

*   Fixed a crash caused by Mod Pipe Conveyor Extension
*   Fixed a crash in voice chat
*   Fixed a crash related to Trash removal admin feature
*   Fixed a crash when image of a banner and of a highlighted banner were the same
*   Fixed inability to start drilling with Hand drill when clicking too fast
*   Fixed Light Armor Slope not being skinnable with Moss Armor Skin
*   Fixed missing emissivity on displays of Economy blocks
*   Fixed new Corner couch still having mount points of original couch
*   Fixed ship not reacting on Y-axis when controlling it from a turret
*   Fixed turrets not shooting at neutrals when they were supposed to

27/08/2019 Hotfix 1.192.021

*   Fixed issue with possibility to enable Safe Zone on dynamic grid
*   Fixed issue with tools working without energy
*   Fixed crash at Sandbox.Game.GUI.HudViewers.MyHudMarkerRender.DrawLocationMarkers
*   Fixed crash at Sandbox.Game.Gui.MyTerminalInventoryController.RefreshSelectedInventoryItem