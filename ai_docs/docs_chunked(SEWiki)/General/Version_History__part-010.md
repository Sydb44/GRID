*   Fixed a crash in production screen when displaying what components a blueprint needs
*   Fixed a crash when exiting a cryo chamber

Support Site Bugs

*   Fixed an issue with subparts being too slippery for walking
*   Fixed an issue where projected DLC blocks could not be welded on dedicated servers
*   Fixed an issue with terminal block groups from a blueprint not reappearing after re-welding the blueprint
*   Fixed multiple issues with artificial mass and space ball blocks not being affected by gravity generators
*   Fixed an issue where game froze up after canceling mod downloads during loading (The last batch approved by steam API is downloaded anyway)
*   Fixed block groups temporarily disappearing after merging/unmerging
*   Fixed DLC armory, armory lockers and lockers blocks accidentally being able to be used by conveyor systems
*   Fixed showing wrong reasons for experimental mode in console/log

### Version [1.190.009](https://spaceengineers.wiki.gg/wiki/Version/1.190.009 "Version/1.190.009") Minor

[Reference](https://forum.keenswh.com/threads/update-190-009-minor-improvements.7402981/)

Release Date: 9 April 2019

**Fixes:**

*   Fixed crash with some mods not containing definitions for DLC
*   Fixed crash when the client was started without steam
*   Fixed crash in terminal when changing settings for multiple batteries at once
*   Fixed crash in drone spawning
*   Fixed crash where it tried to load a non-existent texture out of view
*   Fixed crash in voxels and added logging for the future
*   Fixed heavy armor being too scratched up due to different approach to generating coloring

### Version [1.190.0](https://spaceengineers.wiki.gg/wiki/Version/1.190.0 "Version/1.190.0") Major

[Reference](https://forum.keenswh.com/threads/update-1-190-customizable-lcd-screens-replay-tool-and-decorative-pack.7402960/)

Release Date: 8 April 2019

**Introduction:**

Hello, Engineers!

It’s time for another exciting update for Space Engineers. The most obvious change is the fact that with this release we are bringing both free and premium content to the game. This gives you the opportunity to enjoy new things, but also the chance to support the further development of Space Engineers, if you are willing to do so.

All players will get new functional cockpit LCDs with customizable screens, replay tool, which can be used for setting up various animated scenes, brand new random Encounters, Steam trading cards, badges and backgrounds, and all bug fixes, optimizations, and smaller improvements for free.

Players who already own the [Deluxe Edition](https://store.steampowered.com/app/573160/Space_Engineers_Deluxe/) will also get three new music tracks based on the music from our trailers.

For players who wish to support further development of Space Engineers, we have created a bulk of Decorative Blocks, which you can use for various decorations on your spaceships, vehicles and space stations. The price is $3.99 USD, or your regional Steam equivalent. You can [purchase the Decorative Pack here](https://store.steampowered.com/app/1049790/).

If you decide not to purchase the Decorative Pack, but you want to play with friends or other players who did buy the Decorative Pack, you will still be able to join a multiplayer game or server with them and enjoy the game. In this case, you will be able to view these new blocks, but you won’t be able to build or interact with them.

Note to modders: When modding the decorative blocks, copy the current settings and then do the change on top of that. The mod will also include the DLC tag: < DLC >DecorativeBlocks</DLC>

[Blog post](https://blog.marekrosa.org/2019/04/space-engineers-customizable-lcd.htmlMarek's) [Youtube: Space Engineers: Customizable LCD Screens, Replay Tool & Decorative Pack](https://www.youtube.com/watch?v=3CH7bojdooo)

FAQ

Q: Are all future updates going to be paid?  
A: Actually, even this update isn’t paid. The major part of this update (LCD screens, Replay Tool, new music tracks, smaller improvements) is free for everyone. Only the smaller and not mandatory part is paid - Decorative Pack.

Q: Aren’t you going to split the community - people who don’t own the Decorative Pack won’t be able to play with people who own it?  
A: The way we designed this is that even people who don’t purchase the Decorative Pack can play on servers with people who own the Decorative Pack. Players who don’t own the Decorative Pack won’t be able to build with these new blocks, nor interact with them, but they will be able to view them in-game.

Q: Where is all this money going?  
A: To support future development of Space Engineers and other leading-edge projects we plan to work on at Keen Software House. Players kept asking us for something they could buy to support the development of Space Engineers, and the Decorative Pack is a great option for them.

Q: When did you start working on Decorative Pack?  
A: Right after Space Engineers left early access and all hot issues were resolved. Most of the work was done by the Art team, the rest of the developers is working on other long-term updates.

Q: Why haven’t you increased the price of Space Engineers and include the Decorative Pack in it, or why it’s not part of the Deluxe Edition?  
A: We want more people to play Space Engineers, which means we must lower the barrier of entry. When the Space Engineers community grows, everyone benefits from this - more content on Workshop, more mods, more new ideas, more people to play with. This means that all non-mandatory features should be optional, so only those who really want them can pay for them. That’s why we decreased the price of Space Engineers, and made the Decorative Pack an optional purchase.

Q: We asked you for volumetric water, compound blocks, new goals, more optimizations, etc, and instead you are giving us a toilet block?  
A: Hehe, if you put it this way, it sounds kind of funny. :) But the reality is that decorative blocks are low-hanging fruit, not a bottleneck towards those other mentioned future features. Additionally, the decorative pack can bring added profit and make the mentioned things happen.

**Features:** Main Features

*   New encounters
*   Added Replay tool
*   Ability to disable Supergridding in world settings, set as experimental feature
*   Programmable Block timing Improvements
*   Optimized particles
*   Adjusted cockpit and LCD PCUs

LCDs

*   Introduced internal scripts (Artificial Horizon, Velocity, Gravity, Energy&Hydrogen, Analogue and Digital clock)
*   Support for displaying Text with background texture
*   Background coloring
*   Ability to set Border for Text content
*   Sprites rendering from Programmable Blocks and Mods (synchronized in multiplayer)
*   Better LCD ModAPI
*   Added 1st person view to Control Station block, since the LCD can now display useful stuff

**Fixes:**

*   Fixed a crash and many other issues related to hierarchy in scripting tools by removing the option to set hierarchy
*   Fixed a crash when opening F11 screen twice in a row
*   Fixed a crash when the windows could not find or could not create a directory
*   Fixed a crash when trying to access a windows directory with insufficient rights
*   Fixed above ground ore deposits not spawning on planets
*   Fixed Cryo Chamber having misaligned textures when being viewed from a distance
*   Fixed Cryo Chamber not indicating red when unpowered
*   Fixed desynchronized movement of an astronaut who mounted a ladder that was not directly attached to a non-ladder block
*   Fixed emissivity accidentally being enabled on parts of our cockpits
*   Fixed flight seat not registering pressurized environment around it in some cases
*   Fixed hydrogen engine emissivity indicating yellow when turned off
*   Fixed inconsistencies in camera being automatically switched from 3rd person to 1st person after respawning on a dedicated server
*   Fixed inconsistent emissivity on O2/H2 Generator
*   Fixed laser antennas not being able to establish and keep permanent connections
*   Fixed not resolving invalid piston setting correctly upon copy&paste (When minimum was set higher than maximum)
*   Fixed possible physics crash/freeze when trying to interact with the special dead astronaut block
*   Fixed Share inertia tensor for piston and rotor setting being accessible and settable without experimental mode
*   Fixed two issues with main cockpit brake setting not being respected by other cockpits on the grid which are not main cockpits
*   Fixed voxel hand placing only stone when using painting mode (Middle Mouse Button/ Scroll Wheel click)

Solved Issues from Support Site

*   Added autorespawn setting for existing worlds
*   Added function which removes old respawn ship whenever player tries to spawn a new one
*   Fixed block groups created by players disappearing when those players disconnect from the Lobby
*   Fixed LCDs not syncing displayed contents to other players in vicinity and after clients reconnect
*   Fixed refinery not being able to remove minuscule amounts of stone from its inventory
*   Fixed solar panels updating too slowly
*   Fixed the ability to propose peace to a faction again through ModAPI even after the peace was already established
