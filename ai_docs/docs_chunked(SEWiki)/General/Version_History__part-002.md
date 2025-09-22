*   Assembler

  
07/08/2020 Hotfix 196.012

*   Fixed faction issues
    *   If you still experiencing issues with your faction, restart the faction. Remove all members including the leader so the faction is deleted and make it again.
*   Fixed various crashes on client and server
*   Rebalanced Lightning - Lightning happens less often now.

11/08/2020 Hotfix 1.196.013

*   Fixed several crashes
*   Fixed hydrogen thrusters performance issue (combination with conveyors)
*   Fixed advanced doors issue (mods use that)
*   Fixed backpack not disappearing
*   Turned off pathfinding for wolves and spiders on the grid. We are still investigating this issue.
*   We are aware of an issue with asteroids (missing or desync in MP) and working on the fix.

### Version [1.195](https://spaceengineers.wiki.gg/wiki/Version/1.195 "Version/1.195") Minor

[Reference](https://forum.keenswh.com/threads/update-1-195-sparks-of-the-future.7404133/)

Release Date: 24 June 2020

**Introduction:**

Hello, Engineers!

Sparks of the Future update explores our fascination with science and science fiction and delivers on that with a vision of hi-tech visuals in the Space Engineers universe. We are really excited about exploring all of the possibilities this genre opens to us. Whether it's a vibrant high-tech space station located among an asteroid cluster, a classic sci-fi themed space cafe, or just a cool looking spaceship bristling with Ion thrusters and neon armor - we hope all of this will add to your story in a world of high technology.

This update contains much requested Hinge Blocks, Small Grid Doors, new automated Weather System, 3D Letter Blocks and more!

[Youtube: Space Engineers: Update 1.195 - Sparks of the Future](https://www.youtube.com/watch?v=HnPlscfSS_Q)

  
[Marek's Blog post](https://blog.marekrosa.org/2020/06/space-engineers-sparks-of-future.html)

**Features:** Features & Improvements (Free update)

*   Hinge Blocks (large, small and medium)
*   Small Sliding Door (Small Grid Door)
*   3D Letters, Numbers and Signs (large and small grid)
*   New LCD Posters
*   Automatic Weather System
*   [Sparks of the Future Station: Extended Edition World](https://steamcommunity.com/sharedfiles/filedetails/?id=2140265076)
*   Rotate image function for LCDs
*   Added an option to reverse mouse scroll wheel direction when selecting block variants
*   Added support for replay tool NPCs to have different skins and colors

**Sparks of the Future DLC**

Similar to our previous major releases, we decided to give you an opportunity to support the further development of Space Engineers. We have created a pack which consists of cosmetic items to enrich your game visually. You can experience them in the free Sparks of the Future scenario. The price of the Sparks of the Future Pack is $3.99 USD, or your regional Steam equivalent, so if you wish to support us, check out the [Sparks of the Future Pack](https://store.steampowered.com/app/1307680/).

*   Sci-Fi LCDs
*   Neon Tubes
*   Sci-Fi Ion Thrusters (Reskin of vanilla Ion Thrusters)
*   Sci-Fi Atmospheric Thrusters (Reskin of vanilla Atmospheric Thrusters)
*   Sci-Fi Interior Wall (Reskin of vanilla Interior Wall)
*   Bar Counter, Bar Counter Corner
*   Control Panel (Reskin of vanilla Control Panel)
*   1-Button Panel (With customizable LCD)
*   4-Button Panel (With customizable LCDs)
*   Small Side Door (Reskin of the new vanilla Small Grid Door)
*   Sci-Fi Armor Skin
*   2 Neon Armor Skins
*   New Emotes (“Whatever”, “Yelling”, “Charge”, “Dance Disco 1”, “Dance Disco 2”, “Looking around”, “Stretching”, “Come here baby!”)

Many Thanks to the Modding Community!

We are always impressed by the innovation of our modding community! We would like to thank these members of the Space Engineers community for continuing to inspire us through their ideas, suggestions, and hard work.

*   Jakaria
*   Sektan
*   Shaostoul
*   Darth Biomech
*   Digi
*   IronHospital
*   Gwindalmir
*   SEModder4

**Fixes:** Bugfixes

*   Fixed a crash at Havok.HkUniformGridShape.HkUniformGridShape\_InvalidateRange
*   Fixed a crash at MyLargeTurretBase.StopAimingSound
*   Fixed a crash in Trash removal voxel revert
*   Fixed a crash when trying to read an invalid blueprint xml
*   Fixed a crash at Entities.MyThrust.ThrustDamageShapeCast
*   Fixed a crash at Game.Screens.Terminal.MyTerminalPropertiesController.PopulateMutuallyConnectedCubeGrids
*   Fixed a crash at Game.GUI.MyBlueprintUtils.SaveToCloudFile
*   Fixed a freeze when loading textures
*   Fixed memory use increasing while the game was minimized
*   Fixed a regression in how much damage ships receive from voxel collision (it was lower than it used to be)
*   Fixed landing gears locking to safezones or in mid-air while inside a safezone
*   Fixed Lost Colony scenario not being loadable or join-able without experimental mode enabled
*   Fixed unknown signals causing lag on populated servers
*   Fixed deleted saves appearing in Continue in main menu
*   Fixed quest markers not behaving correctly because of dependencies in the First Jump campaign
*   Fixed and re-enabled NPC pathfinding on grids
*   Fixed maximum grid name length to be 64 characters instead of 512 (caused an issue with cloud storage)
*   Fixed DSGUI remote client not keeping list of banned/kicked players through restarts, making lifting of bans/kicks difficult
*   Fixed grids having to be powered on through shortcut twice after restart on DS
*   Fixed multiple Frostbite respawn points failing to unlock and provide selectable spawn points
*   Fixed LCD sprites not getting clipped correctly
*   Fixed decals not being visible on ATM, Medical Station, and LCDs
*   Fixed astronaut emissivenes state being incorrectly saved/loaded
*   Fixed DSGUI blinking several times and being unresponsive when there are multiple existing saves listed
*   Fixed missile explosions, trails and meteor trail particles not being visible at greater distances
*   Fixed safezone size slider not updating when changing axis
*   Fixed voxel hand drawing grid bounding boxes incorrectly when "Show bounding box" is enabled
*   Fixed In-game help: Movement being incorrectly finishable in jet-pack
*   Fixed missing hints for First Jump 4th campaign mission in Spanish translation
*   Fixed an untranslated button name in First Jump 1st campaign mission in Spanish translation

Fixed issues from our Support site

*   Fixed particles not being disposed off correctly when unloading a session (memory leak)
*   Fixed Hydrogen not flowing from grid to grid through connectors in some cases
*   Fixed "look around" feature not being affected by Y axis inversion
*   Fixed the possibility to withdraw components from nonfunctional conveyor ports through Build Planner
*   Fixed incorrect blocks being deleted when aiming at specific types of blocks
*   Fixed consumable items being deposited along with ores and components via the Build Planner shortcut
*   Fixed the impossibility of adding servers to Favourites
*   Fixed the inability to right-click items in toolbars to change their settings
*   Fixed particles not freezing for Ansel
*   Fixed Programmable block compilation warnings being shown twice
*   Fixed Interior wall emissive parts not actually being emissive

25/06/2020 Hotfix 1.195.019

*   Fixed a crash at MyRenderComponent.TrySpawnParticle
*   Fixed a crash at MySectorWeatherComponent.GetSolarMultiplier
*   Fixed a crash at MySectorWeatherComponent.ResetParticles
*   Fixed a crash at MySectorWeatherComponent.UpdateAfterSimulation
*   Fixed a crash when adding emote to build-planner from block variant panel
*   Fixed an issue with client not being able to paste experimental grids in experimental world
*   Fixed an issue with vehicles not moving after disconnecting from connector

26/06/2020 Hotfix 195.020

*   Fixed GPS names being reset upon reconnect
*   Fixed false "No Fuel" warning and false "0 secs" indicator
*   Fixed "Invert mouse scroll" option status being reset on relaunch
*   Fixed LCD weather script showing raw strings as output
*   Fixed a crash at MyRenderComponent.TrySpawnParticle
*   Fixed a crash at MySectorWeatherComponent.ApplyParticle
*   Fixed a crash at MySectorWeatherComponent.UpdateAfterSimulation
*   Fixed lightning not doing damage on a dedicated server
*   Fixed lightning frequency during thunderstorm increasing each time the server (auto-)saved
*   Fixed NPC station not despawning correctly when admin teleports out
*   Added a notch to Small 1x1 Hinge to help with orientation

30/06/2020 Hotfix 195.021

*   Fixed a crash at MySectorWeatherComponent.UpdateAfterSimulationDelay
*   Fixed another crash at MySectorWeatherComponent.ApplyParticle
*   Adjusted how starts and ends of weathers look
*   Adjusted weather names to better represent them
*   Fixed some weathers lasting for up to 10 real life hours
*   Fixed weather never reaching Clear state
*   Fixed an issue with sounds creating static when being played over weather sounds
*   Optimized how often wind animation updates
*   Fixed an issue where drill yields were much lower
*   Fixed an assertion appearing when trying to save a blueprint to the Cloud
*   Fixed one of the Patrol.bots in Sparks of the Future scenario getting stuck
*   Fixed wrong formatting for some LCDs in Sparks of the Future scenario

02/07/2020 Hotfix 195.022

*   Fixed a crash at MySectorWeatherComponent.AdjustIntensity
*   Fixed a crash at MySectorWeatherComponent.IsPositionSafe
*   Fixed weather debug draw persisting through sessions
*   Fixed weather debug draw line being too long

09/07/2020 Hotfix 195.023

*   Fixed a crash at MySectorWeatherComponent.UpdateWeathersOnClients
*   Fixed a crash at MySectorWeatherComponent.EffectLightning
*   Fixed a crash at MySectorWeatherComponent.ApplySound
*   Fixed a crash at Entities.Blocks.MyPistonBase.UpdatePosition
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
