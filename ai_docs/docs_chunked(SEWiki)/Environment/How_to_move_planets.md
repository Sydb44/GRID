---
title: "How to move planets"
url: "https://spaceengineers.wiki.gg/wiki/How_to_move_planets"
category: "Environment"
wiki_page: "How to move planets"
includes_environment: true
includes_blocks: true
---

# How to move planets - Official Space Engineers Wiki

Summary of an advanced tip from u/MarkoffChaneyIII:

You can change the position of an already [spawned in](https://spaceengineers.wiki.gg/wiki/Spawn_Menu "Spawn Menu") [planet](https://spaceengineers.wiki.gg/wiki/Planets "Planets") to given [GPS](https://spaceengineers.wiki.gg/wiki/GPS "GPS") coordinates. In this example, we want to move planet that was pasted at a random position into its default location. But you can place it at any coordinate, as long as you use the same format.

To obtain valid planet coordinates, copy the x,y,z values from a a default game.

1.  Create a new temporary game based off the default "Star System" and save it.
2.  In Windows Explorer, go to %APPDATA%\\SpaceEngineers\\Saves, open your numeric-named directory, then open the saved game directory in it.
3.  Open the game's SANDBOX\_0\_0\_0\_.sbs file in NotePad++.
4.  Search for the name of the planet at the desired location and copy the x, y, z values into a text editor page.
5.  Close the game file without saving any changes. You can delete the temporary world now.

Tip: Find a setting in the .sbc file called "ShowGPS", which is set to false by default. Replace false by true and restart the game to see a planet's GPS in game.

To move a spawned in planet:

1.  Go to %APPDATA%\\SpaceEngineers\\Saves, open your numeric-named directory, then open the saved target game directory in it.
2.  Make a backup of the SANDBOX\_0\_0\_0\_.sbs file in Windows Explorer.
3.  Open the SANDBOX\_0\_0\_0\_.sbs file in NotePad++ (it will take a while to open this file).
4.  Find the planet you wish to edit and change the x, y, and z values to the ones you recorded earlier.
5.  Save the .sbs file.
6.  In the same directory in Windows Explorer, find a temporary file called SANDBOX\_0\_0\_0 \_.sbsB5 and delete it.

When you now load the edited save, you'll get a warning message about some files being out of sync, just click OK and it should rebuild the .sbcB5 and load. The first time loading will take longer than usual, but that's normal after such a big change.

For console players to have a drop-pod spawn option for spawned planets, make sure to enable the respawn ship in your advanced settings. Then load and save the world and exit, reload, and force respawn. Now there should be an option for the drop-pod spawn on those planets.

For default coordinates, see also [GPS Locations of Planet/Moon Centers and Poles](https://steamcommunity.com/sharedfiles/filedetails/?id=2728454942) by Spaceman Spiff.