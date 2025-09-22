Hotfix 1.185.015

*   fixed sim speed issue caused by mass query on larger grids

Hotfix 1.185.016

*   fixed crash when ship collides/explodes
*   fixed crash when adding actions for Impulse Axis/NonAxis
*   fixed crash with Phoenix Laser Drill mod

Hotfix 1.185.017

*   fixed crash caused by wrong connector behavior

### Version [1.184.8](https://spaceengineers.wiki.gg/wiki/Version/1.184.8 "Version/1.184.8") Minor

[Reference](https://forum.keenswh.com/threads/update-1-184-8-beta-improvements.7398165/)

Release Date: 9 November 2017

**Introduction:**

Hello, Engineers! We are getting extremely close to the next major release with the team reviewing the last few remaining details before we can let it loose on the community. We truly appreciate your patience with us as we prepare this update as we really want it to blow your minds!

This week's update contains sorting options for the blueprints screen and a selection of fixes for issues reported by players. These issues now resolved include a crash when spawning on dedicated servers, strange behavior when shooting a rifle on a moving grid and missing mountpoints on advanced rotor blocks.

**Important note for modders and scripters!**

The API overhaul is nearly done, and we think you'll be excited by all the changes! Some modders were given a preview and preliminary feedback was very encouraging. However, some changes will break existing scripts! Rexxar has posted a comprehensive list of all API changes coming in the next major update, including breaking changes, and some tips on how to get your mods and scripts ready for the new API. [Check out the forum post here](https://forum.keenswh.com/threads/7398158).

**Features:**

*   sorting options in blueprints screen

Fixes

*   fixed crash when spawning on DS
*   fixed shooting from rifle while on a moving grid
*   fixed wolf attack range
*   fixed wolf particles when using grinder on them
*   fixed cockpit not highlighting properly
*   fixed issue with missing advanced rotor mountpoints

8 fixed projectile hit sound not playing properly

*   fixed gatling gun sound playing constantly when using SHOOT ONCE option

Hotfix 1.184.801

*   fixed random crashes

### Version [1.184.7](https://spaceengineers.wiki.gg/wiki/Version/1.184.7 "Version/1.184.7") Minor

[Reference](https://forum.keenswh.com/threads/update-1-184-7-beta-improvements.7398012/)

Release Date: 2 November 2017

**Introduction:**

Hello, Engineers! The team continues to mainly focus on the next major release but in today's update we still have some nice improvements for you. Character backpacks, which could decrease the performance on highly populated servers, can now be removed from the world via the "Remove Floating Objects" function in the Space Master screen.

Due to the feedback received from last week's update, we decided to tweak thruster damage so now the "damage shape" strictly follows the visual representation of the thruster flame.

Additionally, the in-game Chinese translation was updated and other minor issues and crashes were resolved.

**Rexxar's Dev Blog**

Hey guys, given the amount of discussion about thruster damage, I thought this would be a good time to explain what exactly has been going on.

The original problem was that thruster damage simply didn't work in lots of cases. It ignored some kinds of blocks, certain configurations disabled damage on the entire grid, it didn't work on servers, on and on. On top of that, the damage volume was a cylinder implemented in a bad way, which was taking a lot more CPU time than it really should have.

Over the past few weeks, we've been working on rewriting the thruster damage system from scratch. The result is that the damage system actually works. Instead of a cylinder, we used a rectangular bounding box for the damage volume. This is because our engine is designed with several very fast methods to get entities which intersect a bounding box. However, the box only checked for the entire cube volume of blocks, instead of physics intersections, which caused it to behave unexpectedly.

So we have a new solution which combines the best of both worlds. It uses the bounding box to get a rough list of entities, then a capsule shape to check for physics intersections. This isn't as performance friendly as just the box, but it's better than the original solution. The cost of the physics check is a tradeoff to make it behave realistically, but it's well worth it.

The end result is thruster damage with the same volume as before, but performs better and actually works.

We really do appreciate all the feedback you've given us over the last week :)

**Fixes:**

*   tweaked thruster damage area/range: damage shape now strictly follows visual representation of thruster flame
*   Backpacks can be now removed by Remove floating objects function in space master screen
*   fixed issue with inventory desync when moving items (wrong items position)
*   fixed crash when unplugging USB headset
*   increased maximum number of CPU particles/billboards
*   fixed held items not dropping on death on DS
*   fixed unfinished Cryo Chamber draining power
*   fixed flickering background screen in Character scene
*   fixed scrolling issue in LCDs
*   updated Chinese translation

### Version [1.184.6](https://spaceengineers.wiki.gg/wiki/Version/1.184.6 "Version/1.184.6") Major

[Reference](https://forum.keenswh.com/threads/halloween-update-1-184-6-skin-crafting-ghost-skin.7397896/)

Release Date: 26 October 2017

**Introduction:**

Hello, Engineers! Today’s update comes with an exciting new addition - the Skin Recycler! With this, you can recycle your unwanted or duplicate skins and upgrade them to a new Badger skin! The recycler will give you recycle tokens for your old skin pieces, which you can trade in for new items of your choice. All of this is done in the character customization screen.

Space Engineer's fourth anniversary was this Sunday, and there's been a lot of speculation and excitement about it. However, today's update is not the anniversary update. We have been working very hard on the next major update which was originally scheduled to release today, but we decided to delay it for a few more weeks to give our team more time to perfect all the changes. This next update is seriously exciting, with some pretty huge changes. We want to make sure it's as good as it can possibly be before we release it, so please stay patient and start up the major update hype train :)

Another notable announcement is that for a limited time only you will be able to pick up a spooky new Halloween themed skin set for your Engineer. The Ghost skin will be available throughout the next week on the Steam Marketplace until the next update drops. If you’re interested, please see the link below. The funds raised from this will go back into development, speeding up the progress of our internal roadmap and helping to expand the talent in our team.

[Workshop: Ghost skin:](https://store.steampowered.com/itemstore/244850)

[Youtube: Space Engineers - Halloween Update 1.184.6 - Skin Crafting & Ghost Skin](https://www.youtube.com/watch?v=L1zMIFnItXY)

  
**Rexxar's Dev Blog**

Hi everyone! This week I worked on some more projector issues. There were two issues relating to the projection not updating correctly.

The first issue was that when the projector was turned on and off rapidly, the projection would be stuck showing all blocks as buildable for a few seconds. This was a side effect of the parallelization of the projector that I did earlier this year. The problem was that when projections are first spawned, they show as 100% buildable, and since the projector only tries to update the projection every few seconds, it just stays like that until the worker thread notices something has changed. The solution was pretty simple, just hide the entire projection on first spawn, then force the worker thread to start processing the new projection as soon as possible. Additionally, projections now disappear as soon as you turn off the block, instead of sticking for a few milliseconds. The overall effect is a lot smoother now.

The second problem was trickier, and players to make automatic weapon factories may have noticed it. When a projection's only attachment point is a merge block, sometimes the projected merge block shows as buildable or not buildable depending on whether it's 'real' partner on the other grid is enabled. This is because when a merge block is disabled, the mount point on the front is also disabled. So you could get into a situation where the projected block looks like it's buildable, but isn't. I had to create a new event for merge blocks to alert other code when the mount point changes, then when the projector detects this event, it very politely asks its worker thread to update the projection immediately.

**Fixes:** What is new

*   added Halloween skin
*   added recycle and craft feature

Improvements

*   reworked thruster damage

Now all blocks in thruster range are damaged at the same time. Thruster damage area is no longer cylinder but it is rectangular (faster computation, slightly larger volume of effect).

Important fixes

*   optimized performance issues related to particles
*   fixed sim speed drop when cargo ship spawns
*   fixed inventory desync (wrong values) when reconnecting during converting Ore into Ingot

Other fixes

*   fixed issue with friendly and faction players are flagged as enemies
*   fixed components requirements for half block in Survival
*   fixed LODs for half blocks
*   fixed issue with projector not working properly with merge block
*   fixed modded LG not working when welded
*   fixed issue with modded turrets not stopping to fire
*   fixed collisions of modded advanced doors
*   fixed custom animations for cockpits
*   fixed tree reappearing after reload
*   fixed thruster damage not working on DS
*   fixed jump drive issue that it was able to jump farther than indicated
*   removed delay of camera from forced first person view
*   fixed sound block not working correctly in realistic sound mode

Hotfix 1.184.602

*   fixed Jump drive on DS
*   fixed Nanite Control Factory crash
*   fixed Industrial Cockpits crash

Hotfix 1.184.603

*   fixed crash when starting the game

Hotfix 1.184.604

*   fixed DS crash after joining
