*   fixed issue where grids that were cut off acted as if still connected
*   fixed trees grinded/drilled not falling down
*   fixed issue with corrupted world prompt message
*   fixed astronauts wiggly feet
*   fixed crash when two large moving ships crashed into the same voxel
*   fixed ore detector on top of piston/rotor not working properly
*   fixed assembler being unable to pull ingots from connected cargo
*   fixed IGC leak with radio antennas
*   fixed script diagnostics (error reporting) for Mods and Programmable blocks to show correct line numbers

Hotfixes 183.017:

*   fixed joining issue

### Version: 1.182.3

Version page for 1.182.3 does not exist yet. \[[Create](https://spaceengineers.wiki.gg/wiki/Version/1.182.3?action=edit&preload=Template:Version_Preload)\]

### Version: 1.182.2

Version page for 1.182.2 does not exist yet. \[[Create](https://spaceengineers.wiki.gg/wiki/Version/1.182.2?action=edit&preload=Template:Version_Preload)\]

### Version [1.182.1](https://spaceengineers.wiki.gg/wiki/Version/1.182.1 "Version/1.182.1") Minor

[Reference](https://forum.keenswh.com/threads/update-1-182-1-beta-improvements.7396303/)

Release Date: 27 July 2017

**Introduction:**

Hello, Engineers! It has been a week since our major update and we are still hard at work on the next one and fixing bugs as well.

The highlight of today's update is the advanced rotor head (small grid) and the advanced rotor part (large grid) causing clang and damaging surrounding grids. Thank you for your reports! We are still collecting a lot of useful information from you and fixing as many issues as we can. Enjoy this weeks video featuring our QA lead :)

**Fixes:**

*   fixed suicide not working with invulnerability ON
*   fixed Administrator page not appearing after ban
*   fixed decoy block purple texture in construction model
*   fixed small adv. head causing involuntary movement for large rotors
*   fixed emissives for corner LCD panels
*   fixed dead astronauts collision model in Campaign

**What we are currently working on:**

*   Game crash when loading broken mods (CSD Autocannon etc)
*   Game crash when welding projected laser antenna (Survival)
*   Compound blocks issue
*   Visual glitches on moving grids (Intel i7 issue)
*   Modded doors killing people
*   Exploding doors
*   Blinking lights
*   Merging ships together makes them blink
*   Unmerging big grid makes the game stuck
*   Some sounds are missing after reloading

### Version [1.182.0](https://spaceengineers.wiki.gg/wiki/Version/1.182.0 "Version/1.182.0") Major

[Reference](https://forum.keenswh.com/threads/update-1-182-0-major-optimizations-reduced-loading-times-more.7396128/)

Release Date: 20 July 2017

**Introduction:**

Hello, Engineers! We are extremely excited to announce that today we are releasing the next major update for the game which contains a huge batch of optimisations and improvements!

The biggest area of improvements is to render performance with textures and models now being loaded asynchronously. As a more specific example of an improvement area, CPU performance has been optimized to run Easy Start Earth and 16-ships flying scenario in 60fps on 3GHz Hyperthreaded Quad Core Processor. Meanwhile, GPU performance has been optimized to run the Easy Start Earth scenario at 60fps on 1080p High settings on nVidia 980 GTX. Please keep in mind that increased performance is not limited to only these scenarios but will positively impact most, if not all worlds and hardware configurations. We’ve also added new shader quality options in graphical settings which affects the quality of Atmosphere, Trees and Voxel rendering. Detection of GPU performance now occurs upon first startup of the game and shadows are now higher quality in general although tree shadows will now be disabled on low settings. Multi-threading as well as indirect lighting has been fixed on Intel GPUs and some compatibility issues with the Windows 10 creators update were resolved.

Other optimizations include loading times being massively reduced for both game worlds and the copying and pasting of grids. For those of you who are interested, this was achieved by using cached proto-buffer files.

Moving on to some smaller changes, we improved tool animations even more and increased the visibility of certain HUD elements. Additionally, there are many other general improvements in this update which should fix lots of issues that players have been experiencing.

The team would just like to once again remind you that as this is a major update, there has been many significant changes made to code so we will especially appreciate any bug reports sent in by the community. This will allow us to find issues quicker and get them fixed as soon as possible. It’s also worth pointing out that if necessary, you can always revert to a previous major version of the game via the betas tab in steam under game properties.

[Youtube: Space Engineers - Update 1.182.0 - Major Optimizations, Reduced Loading Times & More!](https://www.youtube.com/watch?v=qww6RNB0aPc)

**Features:** Render optimizations and fixes:

*   Textures and models are loaded asynchronously
*   CPU performance optimized to run Easy Start Earth and 16-ships flying scenario in 60fps on 3GHz 4-hyperthread CPU
*   Detection of GPU performance on first startup of the game
*   GPU performance optimized to run Easy Start Earth:
    *   60fps on 1080p High settings on nVidia 980 GTX
    *   60fps on 720p Medium settings on nVidia 750 GTX
    *   30fps on 720p Low settings on Intel GPUs
*   New shader quality settings introduced in Options, affecting quality of atmosphere, trees and voxel rendering (voxel texture emissives are now working, but only for High shade quality)
*   Better quality of shadows, disabled tree shadows on Low settings
*   Windows 10 creators update compatibility fixed
*   Dark side of glass occludes flares (IsFlareOccluder tag in TransparentMaterials.sbc)
*   Fixed multi-threading on Intel GPUs
*   Fixed indirect lighting on Intel GPUs
*   Fixed flare attenuation

Other optimizations:

*   Internal game worlds will deserialize faster now (using cached proto-buffer files)
*   Pasting of grids (cloning, preview mode and placing the entity)

NPC behavior changes:

*   Wolves and Sabiroids now only attack the character. They will not attack grids. Also wolf corpses are heavier now.

Art Changes:

*   Improved tool animations
*   Improved the visibility for HUD elements
*   New cryo chamber interior

**Fixes:**

*   Fixed not working height offset option for wheels with suspension block
*   Fixed "killer doors bug" edge case
*   Fixed issue with modded doors being walk through despite being closed
*   Fixed another block placement case
*   Fixed displaced selection of blocks with welder and grinder
*   Fixed dirty glass in cockpit and fighter cockpit block
*   Fixed crash when colliding into a asteroid with a grid
*   Fixed bullet holes not appearing on cockpit glass
*   Fixed case with camera clipping into character head while in 3rd person
*   Fixed case with camera switches from 3rd to 1st caused by spawned or dropped items
*   Fixed looping preview for blocks when aiming at edge of another block
*   Fixed assembler on realistic not producing any components
*   Fixed assembler draining power when not in use
*   Fixed timer block issue where it would not resume counting down its timer after being powered on and off
*   Fixed interior turrets shooting above wolves and spiders
*   Fixed problems with controlling ships not displaying the correct speed while in turret mode
*   Fixed muzzle effect while using gatling gun
*   Fixed emissivity issue for modules
*   Fixed the emissivity for mag boots when off to be completly non emissive
*   Fixed LCD panel shows Offline even when it is powered
*   Fixed issue with battery control panel and Battery block loosing emissivity after unmerging
*   Fixed landing gear block detaching from grids when merging
*   Fixed issue with lights not moving after unmerging a ship/vehicle
*   Fixed offset of interior lights when connectiong another blueprint to a grid
*   Fixed space ball block constantly broadcasting despite having the option turned off
*   Fixed jump drive particle missing for other players in MP
*   Fixed issue while in remote control the distance now relates to the Remote control block and not the player
*   Fixed issue with sealed hangar door not having oxygen near it
*   Fixed issue where depressurising and pressurising the room would generate oxygen (offset should be around 0,01 percent now)
*   Fixed issue where while invulnerable the player would die in cockpits without oxygen
*   Fixed reloadable rocket launcher not reloading
*   Fixed odd piloting issues with cargo ships
*   Fixed wheel suspension 1x1 still spinning in space small grid
*   Fixed meteors hitting voxel asteroids on the inside causing "square craters"
*   Fixed issue where animation for tools would play but nothing would happen to the block
*   Fixed buttons keeping its label after the action is removed
*   Fixed server parameters not reseting to default properly
*   Fixed HUD displaying in the respawn screen on DS

Hotfix 1.182.017:

*   Fixed various crashes
*   Fixed not working replace with clipboard function
*   Fixed missing character emissives
*   Fixed missing LCD panel emissive
*   Fixed Invulnerable function on DS

Hotfix 1.182.18

*   Fixed "paper blocks"
*   Fixed wild door collision on fast moving ship
*   Fixed render crash

Hotfix 1.182.19

*   Fixed campaign blocker
*   Fixed crash when saving or loading the scene
*   Fixed crash when attempting to display server details for server with different version
*   Fixed issue where doors would kill you if standing near them for a time
*   Fixed items in toolbar slots not showing when loading up a world
*   Fixed issue with gatling gun block not being placeable in Survival mode

What we are currently working on:

Fixes

*   Fix for "compound blocks"
*   Exploding doors
*   Clang with adv. rotor large and small adv. rotor head
*   Spotlights blinking
*   Some sounds are missing after reloading
*   Corner LCD panels are not emissive

[Lilbigmouth](https://spaceengineers.wiki.gg/wiki/User:Lilbigmouth "User:Lilbigmouth") (talk) 13:24, July 25, 2017 (UTC)
