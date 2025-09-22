Hotfix 1.184.602

*   fixed Jump drive on DS
*   fixed Nanite Control Factory crash
*   fixed Industrial Cockpits crash

Hotfix 1.184.603

*   fixed crash when starting the game

Hotfix 1.184.604

*   fixed DS crash after joining

### Version [1.184.5](https://spaceengineers.wiki.gg/wiki/Version/1.184.5 "Version/1.184.5") Minor

[Reference](https://forum.keenswh.com/threads/update-1-184-5-minor-beta-improvements.7397811/)

Release Date: 19 October 2017

**Introduction:**

Hello, Engineers! We’ve heard your feedback for the last few minor updates, and since so many of you are missing the weekly update videos, we’ve decided to post some new, different content! This week we have the first video in a series we’re calling Catchin’ Clang. In this series, everyone’s favorite developer, Rexxar ( ͡° ͜ʖ ͡°), will give you a behind the scenes look at the process of finding and fixing bugs in Space Engineers!

Additionally, Rexxar will start providing a sort of mini dev blog on minor updates talking about one or two features or fixes in the update.

We hope you will enjoy this new style of update post, please let us know what you think!

[Youtube: Catchin' Clang: Episode 1 (Pilot)](https://www.youtube.com/watch?v=bekAAF25Owk)

**An important note for modders and ingame scripters!**

We’re planning some large changes to the APIs, and we need your help! If you have any issues with the API, or any feature requests, please post in these forum threads!

[https://forum.keenswh.com/threads/modapi-issues.7397671/](https://forum.keenswh.com/threads/modapi-issues.7397671/)

[https://forum.keenswh.com/threads/ingame-api-issues.7397673/](https://forum.keenswh.com/threads/ingame-api-issues.7397673/)

Some of these changes will break the API, but we will give you more information about these changes as soon as we can, so you can get your mods ready to go before the update comes out. Stay tuned!

**Dev Blog:**

One of the issues I worked on this week was a mysterious crash that happened when downloading mods. We received a few reports of this through our crash log reporter, and since I have been working on the mod download code recently, the ticket was put on my desk.

I looked into the section of code reported by the crash log, and couldn’t find anything that would produce the error. So I looked closer at the log, and noticed a ton of errors indicating that the user somehow lost connection to Steam at exactly the wrong time, which was resulting in some sort of corrupted state causing invalid data to be fed into the code.

I eventually managed to reproduce the problem by disconnecting my ethernet cable at exactly the right moment :D I found some unsafe code and rewrote it to not crash if given invalid input. The code is also now slightly faster as a result, so loading mods should take a little less time.

**Features:** Fixes:

*   fixed crash in Steam Service when exiting game
*   fixed crash with loading multiple modded blocks
*   fixed crash with LCD modded blocks being dragged into the toolbar
*   fixed atmospheric thrusters turbines being displaced when moving
*   fixed scrollbar not updating properly in entity list
*   fixed bad highlighting on arc furnance block
*   fixed button panel LOD making it invisible
*   fixed battery recharching in unbuilt state

### Version [1.184.4](https://spaceengineers.wiki.gg/wiki/Version/1.184.4 "Version/1.184.4") Minor

[Reference](https://forum.keenswh.com/threads/update-1-184-4-minor-beta-improvements.7397708/)

Release Date: 12 October 2017

**Introduction:**

Hello, Engineers! Today's minor release comes with a sizeable batch of general improvements. The team has been working hard on both fixes and features of upcoming updates and are looking forward to seeing in the hands of our players. Issues fixed in this week's update include the dampeners HUD icon showing the incorrect state, controls being inverted when two players pilot a single grid and inventory scrolling not working properly. Additionally there's more sound improvements. For example, you will notice a new sound when walking with activated magnetic boots and footstep sounds should now be in sync with animation.

Also, changing the UI Opacity will no longer make text in the control panel unreadable.

**Features:** Fixes:

*   fixed players being unable to spawn on Rival Platform scenario
*   fixed turned off projector displaying a projection after removing a block
*   fixed Easy Start Space miner exploding when editing its grid
*   fixed controls getting inverted with two players piloting grid
*   fixed scrolling inventory not working properly
*   fixed shaking off camera when shooting and in spec. camera
*   fixed issue with modded LCD Textures shown as Blank
*   fixed emissivity issues on skins
*   fixed faulty Sensor block showing negative number on range sliders
*   fixed wrong mount point on Corner LCD flat block
*   changed design for Stairs model block
*   fixed issue with dampener icon no displaying the correct state
*   fixed UI Opacity making texts in control panel unreadeable
*   fixed out of sync footsteps
*   fixed no start/idle/moving sounds playing for ships
*   fixed ship Drill sounds not playing when turned on
*   fixed deconstructing blocks playing constructing block sounds
*   changed sound when walking with magnetic boots
*   fixed Airtight hangar doors playing the wrong footstep sound cue

Regarding decreased sim speed: this problem was already in the game for some time but was not visible due to other things. We are still working hard on a fix but due to the difficulty of it we would like to ask players to be patient as the issue will be solved in the next Major update.

Hotfixes 1.184.401:

*   Fixed big sim speed drop when building

### Version [1.184.3](https://spaceengineers.wiki.gg/wiki/Version/1.184.3 "Version/1.184.3") Minor

[Reference](https://forum.keenswh.com/threads/update-1-184-3-minor-beta-improvements.7397585/)

Release Date: 5 October 2017

**Introduction:**

Hello, Engineers! This week's minor release comes with some important general improvements. Issues fixed include a number of audio issues like wheel sounds playing even when a vehicle is not moving and choking sounds being heard by all players. Also, the Doppler Effect should now be heard correctly through your sound device of choice. Additionally, there’s some modding improvements; mods can now use WAV format audio instead of WXM.

Also, the game will now pause when you open the steam overlay, and will properly ignore keyboard input while the overlay is open.

Behind the scenes, the team is busy working towards some exciting major updates for the game as we approach the fourth year anniversary of Space Engineers. Stay tuned...

**Features:** Fixes:

*   fixed crash when players were attempting to render and fast moving ship with respawn station
*   fixed crash when modifiying their save .sbc files and attempting to go into setting in-game
*   fixed crash when certain Mech blueprints being destroyed would cause crash
*   removed certain ships from random encounters that cause sim speed drop
*   changed the large tube component model size
*   fixed loading screen background not scaling properly for all resolutions
*   fixed ESC button being registered when entering the steam overlay
*   fixed hitbox on astronaut being larger than intended
*   fixed GPS staying after looting the body before changing to a backpack
*   fixed blocks staying selected on DS when entering cockpit
*   fixed doppler effect not working for audio
*   fixed odd behavior for audio of first gatling shot not respecting distance
*   fixed grinder sound playing after grinding down block
*   fixed choking sounds being heard by all players
*   fixed wheel sounds playing despite the vehicle not moving
*   fixed audio files not being located for modded blocks

Regarding decreased sim speed when using tools: This problem was already in the game for some time but was not visible due to other things. We are working hard on a fix but due to the difficulty of it we would like to ask players to be patient as the issue will be solved in the next Major update.
