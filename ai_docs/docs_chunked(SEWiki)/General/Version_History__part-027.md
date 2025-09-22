
What we are currently working on:

Fixes

*   Fix for "compound blocks"
*   Exploding doors
*   Clang with adv. rotor large and small adv. rotor head
*   Spotlights blinking
*   Some sounds are missing after reloading
*   Corner LCD panels are not emissive

[Lilbigmouth](https://spaceengineers.wiki.gg/wiki/User:Lilbigmouth "User:Lilbigmouth") (talk) 13:24, July 25, 2017 (UTC)

### Version [01.181.5](https://spaceengineers.wiki.gg/wiki/Version/01.181.5 "Version/01.181.5") {{{Type}}}

[Reference](https://forum.keenswh.com/threads/update-1-181-5-minor-beta-improvements.7395895/)

Release Date: 07 July 2017

**Introduction:**

Hello, Engineers!

This week’s minor is continuing the current run of general improvements as we near the release of the next major update. We know a lot of you really can’t wait for this but it’s crucial that we fix as many bugs as possible before going live with changes to code as significant as the ones in the upcoming major. The main issues fixed in today’s update include terminals taking you to the incorrect block in the control panel and automatic turrets shooting subgrids of their own grid. Additionally, corner and interior lights should no longer appear emissive when turned off or not supplied with power.

**Fixes:**

*   fixed FPS drain on highlighted objects
*   removed emissivity on corner light and interior lights when turned off
*   fixed issue with being forwarded to the wrong block when using control panel
*   fixed issue with choppy animation for turrets
*   fixed issue with turrets that are targeting enemy objects even though they are already destroyed
*   fixed issue with turrets that are shooting their own subgrids (for example: wheels)

### Version [01.181.4](https://spaceengineers.wiki.gg/wiki/Version/01.181.4 "Version/01.181.4") {{{Type}}}

[Reference](https://forum.keenswh.com/threads/update-1-181-4-minor-beta-improvements.7395776/)

Release Date: 29 June 2017

**Introduction:**

Hello, Engineers! It’s a new minor update this week containing more general improvements as we grow ever closer to the next major release, the changelog of which is growing bigger and bigger day! If you missed it, watch last week’s video to hear about some of the optimisations that will be going into that release. The main issues fixed in today’s update include safety locked rotor heads detaching after using a jump drive and grids being able to pass through closed hangar doors. Additionally, we resolved issues with block placement being offset when standing on moving grids.

**Fixes:**

*   raycast offset on moving grids
*   jump drives break safety locked rotors
*   jump drive particle effect shadow
*   jump drive causing death at full speed with dampeners turned off
*   objects can go through closed doors
*   turrets being able to shoot through doors
*   wrong highlight while welding projected object
*   various modding issues (broken emissivity, holo LCD textures, highlight on objects where are you aiming)
*   Hotfix: Dirty glass
*   Hotfix: Jump drive jumps into middle of the Earth
*   Hotfix: Oxygen and Hydrogen issue with auto refill option also Assembler cooperative mode is behaving the same

### Version [01.181.3](https://spaceengineers.wiki.gg/wiki/Version/01.181.3 "Version/01.181.3") {{{Type}}}

[Reference](https://forum.keenswh.com/threads/update-1-181-3-minor-beta-improvements.7395655/)

Release Date: 22 June 2017

**Introduction:**

Hello, Engineers! This week’s minor update is focused on addressing multiplayer desyncs. We fixed issues related to landing gears, autolock etc. Amount of crashes was also dramatically reduced.

**Fixes:**

*   fixed various sound crashes
*   fixed MP desyncs while using landing gears
*   fixed landing gear functionality

### Version [01.181.2](https://spaceengineers.wiki.gg/wiki/Version/01.181.2 "Version/01.181.2") {{{Type}}}

[Reference](https://forum.keenswh.com/threads/update-1-181-0-major-big-optimizations-multithreaded-physics-more.7395181/)

Release Date: 16 June 2017

**Introduction:**

Hello, Engineers! This week’s minor update is focused on addressing various crashes, the majority of which are related to multithreaded physics. This is also why you may have noticed multiple hotfixes being released during the last week as we are determined to fix them as soon as possible. Other issues fixed include the collect all option not working properly with large connectors and being unable to remove catwalks in certain situations.

Now here’s some community news for all the ship builders out there. I would like to remind everyone about the UESC monthly build contest which is being sponsored by us here at Keen Software House. With every new contest there is a different theme defining the type of builds for that month. This is a great opportunity to showcase your ship design talents and even win some game keys! You can find more information about the contest and how to enter [here](https://steamcommunity.com/app/244850/discussions/0/1291817837617422012/)!

**Fixes:**

*   fixed game crash caused by turrets behavior
*   fixed not working Collect all option for Large Connectors
*   fixed audio crash
*   fixed game crash when old models are imported
*   fixed game crash when copying grids

### Version [01.181.1](https://spaceengineers.wiki.gg/wiki/Version/01.181.1 "Version/01.181.1") {{{Type}}}

[Reference](https://forum.keenswh.com/threads/update-1-181-1-minor-beta-improvements.7395427/)

Release Date: 08 June 2017

**Introduction:**

Hello, Engineers! We’ve got a minor update for you this week after last week’s major update, and the team have been busy processing various issues reported by the community on our forums. For example we’ve fixed problems with connectors and block placement on dedicated servers. Small grid rotor displacement settings should now be saved in blueprints too. Additionally, a number of crashes were also resolved. It’s been great to read everyone’s feedback and to hear that many players have seen big performance gains in their worlds. Please do continue to let us know your thoughts and experiences with these weekly updates. In today’s work in progress section We would like to talk about the render optimizations showcased earlier this week. We demonstrated how a world with 16 red ships would run at around 45FPS on a system running the current version of game. In comparison, the exact same scenario was then loaded on a prototype version with the render optimizations included and ran at around 60FPS! One of the improvements which helped to achieve this was making the GPU be no longer limited by the CPU.

**Features:**

*   Added a counter of physical shapes to grid's info terminal screen.

If you reach 99% of the limit, a warning should start appearing. If you exceed the limit any added blocks will not have physics. This is a technical limitation even if block limits are off, but we are aware of this issue and we are looking into possibilities, how to improve this behaviour.

**Fixes:**

*   fixed game crash when exceeding the block limit
*   fixed blocks are not being placed
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
