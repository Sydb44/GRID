[Reference](https://forum.keenswh.com/threads/update-1-183-2-beta-improvements.7396955/)

Release Date: 31 August 2017

**Introduction:**

Hello, Engineers! While we are fully focused on next major update, in this week's minor we are bringing bunch of fixes likes not spawning containers, small advance rotor head clipping through rotor body. This update is bringing a lot of crash fixes with various UI cases, resource distribution, copy and pasting of drones in MP and others. Perhaps the most noteworthy fix this update is concerning the visual bug for moving grids that was encountered by RYZEN and I7 users.

Unfortunately there is no video for this week (greetings to Xoc).

While we have no pun to end on this week, from Xoc, and I (I23I7) am not good at puns. Let us end on one of my favorite quotes:

„Well, the thing about a black hole - it's main distinguishing feature - is it's black. And the thing about space, the color of space, your basic space color - is it's black. So how are you supposed to see them?“ - Holly

### Version [1.183.1](https://spaceengineers.wiki.gg/wiki/Version/1.183.1 "Version/1.183.1") Minor

[Reference](https://forum.keenswh.com/threads/update-1-183-1-chinese-translation-beta-improvements.7396809/)

Release Date: 24 August 2017

**Introduction:**

Hello, Engineers! This week's minor release is primarily focusing on the Chinese translation of the game, but also on other minor fixes such as parachute fixes, container spawning, block fixes and many others.

During 5 month period, We have been working on Chinese translation for Space Engineers with the great help from Chinese community! Now we are happy to announce, that we have finished the translation and releasing it today.

工程师们，大家好！很高兴今天要宣布一个重大的消息：“中文版正式发布”借此机会感谢社区的一些朋友，五个月来对我们翻译工作的支持，可能翻译有些不足的地方，请大家给出宝贵的意见！另外我们还发布了降落伞，装备箱和方块的一些修复。请关注。谢谢！

[Youtube:Space Engineers - Update 183.1 - Chinese Translation & Beta Improvements](https://www.youtube.com/watch?v=kVpdCh0G65U)

**Features:**

*   Chinese language
*   added access rights checking for block painting

Fixes:

*   fixed crash while clicking join game in main menu
*   fixed a bug where ship become dynamic with locked landing gears to voxel
*   fixed character stuck in med bay after receiving item from market
*   fixed not being able to control enemy turret with admin tool "can use all terminals" activated
*   fixed gatling gun sound and particles keep looping
*   fixed LOD of Light and Heavy Round Inv. Corner blocks not displaying properly
*   fixed parachute not working with conveyor system
*   fixed parachute does not render in some cases
*   fixed a bug where more than one personal container could be spawned
*   increased spawn time of container drops to 10 - 45 minutes (this does not lower amount of items you get, there is just less empty containers)

Hotfixes 1.183.101:

*   fixed crash screen always in Chinese
*   fixed game crash when convert the grid to dynamic (temporary crash fix)

Hotfixes 1.183.102:

*   spawn time for container drops to 5–20 minutes (looking for best values)
*   fixed game crash when convert the grid to dynamic (final crash fix)

Hotfixes 1.183.103:

*   fixed "ghost blocks" issue when grinding or removing blocks

### Version [1.183.0](https://spaceengineers.wiki.gg/wiki/Version/1.183.0 "Version/1.183.0") Major

[Reference](https://forum.keenswh.com/threads/update-1-183-0-skins-parachutes-player-feedback.7396639/)

Release Date: 17 August 2017

**Introduction:**

Hello, Engineers! With today's major release we are bringing you some amazing additions to the game! From now on, you will be able to personalize your engineer with a broad range of new items! We are introducing 33 customizable skin sets for your engineer, your tools and your weapons. It’s time to show off! On top of that, another brand-new block makes its debut in Space Engineers: A reloadable parachute block for both small and large grid!

We encourage you to provide us your feedback about introduced changes. We've created a new platform for players to submit feedback to the development team. The feedback.keenswh.com page provides the possibility to let your voice be heard, or to vote for an idea that the team needs to look at and consider implementing. For more instructions, click [here](http://www.spaceengineersgame.com/feedback.html%7C).

This week we've also added mod profiling, which will show a warning to players when mods are running slowly and causing the game to lag. The goal of this tool is to help players understand the problems which are causing poor performance in their game. Sometimes modders aren't aware of performance issues, sometimes they are. Either way, this tool can help you identify what's causing your game to run slow and gives you a chance to report it at appropriate places. As part of this update, we were also able to implement granular, per method, profiling for mods.

To help modders make their code perform better, we've improved multithreading support and prepared a guide which explains some multithreading basics: [https://forum.keenswh.com/threads/parallel-modding-guide.7396636/](https://forum.keenswh.com/threads/parallel-modding-guide.7396636/)

**Features:**

*   added 33 astronaut and tool skin sets
*   added persistent character appearance
*   added mysterious containers in Survival mode
*   added reloadable parachute block (Special thanks to Draygo)
*   added canvas component
*   added mod profiling

**Fixes:**

*   fixed emissivity issue with mag boots
*   fixed conversion rate for small grid O2 Generator
*   fixed GPU warning popping when FPS was above 100
*   fixed projectors not syncing with other players on DS
*   fixed issue with voxel rendering when travelling great distances
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
