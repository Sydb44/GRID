*   fixed not working artificial mass
*   fixed not working connectors
*   fixed game crash when using connectors
*   fixed turrets view
*   fixed rotor (small grid) displacement not saved in blueprints
*   fixed respawning in medical room with the clone
*   fixed thrusters keep their lighting even after being turned off

We are aware of crash with ship explosions and trying to resolve it. It should be pushed as a hotfix as soon as it will be fixed.

Hotfixes:

*   fixed crash when mergin/unmerging grids

### Version [01.181.0](https://spaceengineers.wiki.gg/wiki/Version/01.181.0 "Version/01.181.0") Major

[Reference](https://forum.keenswh.com/threads/update-1-181-0-major-big-optimizations-multithreaded-physics-more.7395181/)

Release Date: 01 June 2017

**Introduction:**

Hello, Engineers! Today’s release is a major one bringing you some of the biggest optimizations in the game’s history. For example, the 16 players and 16 red ships multiplayer scenario ran at a sim speed of 0.25 before optimizations and now it runs at 1.0! We achieved this by reducing blocks per frame updates, reducing world matrix calculations per frame, and by enabling multithreaded physics. The team still plans to continue with further optimizations in areas like ship collisions, explosions, loading times, planets, memory usage and more! Additionally, We are also pleased to announce that the multiplayer synchronization code has been optimized further.

Moving on, there’s a bunch of camera improvements including much better 3rd person camera behavior with creations that have subs-grids so there’s less snapping to 1st person when rotating the camera around the main grid. We have a new glass rendering technique which means that windows should no longer glow in darkness and look more realistic. On top of all this, there’s a huge amount of bug fixes, art fixes, crash fixes and general improvements in this update so thank you for your patience with some of these issues.

Just as a heads up for the modders out there; due to many blocks being optimized, some older block mods may need updating. See the forum thread linked in the description for more information: [https://forums.keenswh.com/threads/warning-for-block-mods.7395156/](https://forums.keenswh.com/threads/warning-for-block-mods.7395156/) Among the many changes this week, we've added asynchronous entity creation to the ModAPI, which allows a mod like ServerLink to operate much faster. This release was thoroughly tested but as there has been so many changes in the code we will especially appreciate it if you report bugs that you find. Although many of you do this already!

**Features:**

*   implemented optimizations + multithreaded HAVOK physics
*   implemented glass shader with reflections

**Fixes:**

*   fixed various 1st and 3rd person camera issues
*   fixed various desync issues in multiplayer
*   fixed spotlight effects
*   removed redundant geometry from fourth mission in campaign
*   fixed crash with programmable block antenna communication

Hotfix:

*   fixed multiple cases where crashing ship against voxel would crash the game
*   fixed Artificial Mass block misbehaving in artificial gravity

![](https://i.ytimg.com/vi/w7YCE7PWU0A/hqdefault.jpg)

Load video

### Version [01.180.6](https://spaceengineers.wiki.gg/wiki/Version/01.180.6 "Version/01.180.6") {{{Type}}}

[Reference](https://forum.keenswh.com/threads/update-1-180-6-minor-beta-improvements.7395089/)

Release Date: 25 May 2017

**Introduction:**

Hello, Engineers! Once again, we’ve got a minor update for you today with more crash fixes and a couple of improvements as the team battles with the last few remaining issues in the next major update.

This particular upcoming major update has many changes to the code so it also requires a huge amount of additional testing which of course adds to production time. The majority of our programmers and testers are working on this which is why the recent minor updates have only contained a small amount of improvements. The image shown here is a good example of what searching for and trying to reproduce a crash in the game can look like. But we are expecting significant increases in performance from these changes so it’s still definitely something you can look forward to and we appreciate your patience with this.

Next Tuesday we will be streaming at 8PM CEST on the Keen Community Network over on Twitch. This stream with Marek will be focusing on the vision for Space Engineers as well as giving a more detailed update on the progress of performance improvements.

**Fixes:**

*   fixed Campaign crashes
*   fixed MyProgrammableBlock crash
*   fixed welder radius
*   fixed missing rotation cube arrows
*   replaced NaN value on HUD for 0.0

### Version [01.180.5](https://spaceengineers.wiki.gg/wiki/Version/01.180.5 "Version/01.180.5") {{{Type}}}

[Reference](https://forum.keenswh.com/threads/update-1-180-5-minor-beta-improvements.7394943/)

Release Date: 18 May 2017

**Introduction:**

Hello Engineers! There’s a batch of art and animation fixes in today’s minor update as the team moves ever closer to the next major update which will contain significant improvements to performance and multiplayer. Issues with model fixed this week include incorrect LODs on a number of blocks like the small grid merge block and small grid camera but also missing textures on blocks such as wheel suspension and the large ship welder. Moving on now to a couple of the notable animation issues that were fixed, using hand tools will no longer stretch the engineer’s arms and rifles should now aim where the crosshair is pointing.

In other news, next Monday we will be streaming at 8PM CEST on the Keen Community Network over on Twitch. During the stream, together with Marek and Deepflame, we’ll be talking more about things being worked on and also taking a look at Medieval Engineers and it’s future plans. Marek will even be suiting up for the occasion in his personalized Roman armor!

**Fixes:**

*   fixed models showing LOD1s instead of LOD0s
*   fixed wrong LODs on several blocks
*   fixed highlight of missile turret's control panel
*   fixed old icons displayed in inventories and production tabs
*   fixed crystal clear glass
*   fixed rifle doesn't aim where the crosshair is pointing
*   fixed too big hitboxes of blast doors and atmospheric thrusters
*   fixed missing textures on large ship welder and wheel suspensions
*   fixed small grid camera model and LOD
*   fixed emissivity color missing on several blocks
*   fixed tools making arms long

For older releases notes, see Pre-beta [Patch Notes](https://spaceengineers.wiki.gg/wiki/Patch_Notes "Patch Notes").
