5.  The new blueprint will appear on the F10 screen of the recipient, on the bttom of the Steam Workshop category list. The recipient can double-click to open it on the Workshop and choose to subscribe to it.

## How to view and spawn blueprints

After making a blueprint, press [F10 key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings") to open the Blueprint screen to view (and spawn in) your blueprinted grids. This works both in survival mode and creative mode, but there are important differences.

*   In creative games [with copy&paste enabled](https://spaceengineers.wiki.gg/wiki/World_Settings "World Settings"), you can copy blueprints directly from the blueprint screen and paste them into the world without any costs. Pasting includes connected grids and subgrids.
*   In survival games, you must build a [Projector](https://spaceengineers.wiki.gg/wiki/Projector "Projector") to make the blueprint visible in the world, and then you must spend components and time to weld it up. Projectors however do not support projecting [connected grids](https://spaceengineers.wiki.gg/wiki/Connector "Connector") or [subgrids](https://spaceengineers.wiki.gg/wiki/Grid "Grid") -- read about details on the respective pages.
*   [Admins](https://spaceengineers.wiki.gg/wiki/Admin_Screen "Admin Screen") with creative tools enabled can also allow themselves to copy and paste blueprints into a survival world.

If the blueprint contains DLC blocks or modded blocks that the player does not have access to, then they cannot paste/project the blueprint fully. If another player builds the DLC blocks for them, and transfers ownership of the grid to them, they can use it normally.

Required mods must always be installed to be able to paste/project blueprints that use them.

## How to make backups of blueprints

On Windows PCs, blueprints are saved locally in your _"%APPDATA%\\SpaceEngineers\\Blueprints\\Local\\"_ folder by default. Tip: If you cannot see this folder in Windows Explorer, search online for advice "How to show hidden files and folders in Windows <your version>". If you can see the folder %APPDATA%\\SpaceEngineers folder, but not local blueprints, switch off Steam cloud saving.

Remember to make backups of _"%appdata%\\SpaceEngineers_" blueprints and saves subfolders when you move to a new PC!

## How to rename blueprints

If you forgot to name something, it will have a default name like "large grid 123" or "small grid 321". Similarly, if a blueprint with the same name already exists, a number is added to the name automatically. If you want to clean up duplicates and remove the automatic numbering or rename it with proper versioning, press [F10 key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings"), find the grid in the Blueprint list, and click **Rename**.

## How to update local blueprints

Pressing [CTRL key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings")+[B key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings") and creating new blueprints of the same grid repeatedly, gets messy and fills up the local blueprints screen with annoying numbered copies that you will need to delete manually.

To replace a blueprint with a new version, you must be in Creative Mode.

1.  Copy the latest blueprint to your clipboard:
    *   If the grid is in the Creative world, copy the grid by aiming the crosshairs at it and pressing [CTRL key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings")+[C key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings").
    *   Or if you made an up-to-date blueprint in Survival, press [F10 key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings"), find the up-to-date one in the Blueprint screen, and click the **copy** button.
2.  On the Blueprint screen ([F10 key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings")), select the existing blueprint from the blueprint list.
3.  Click its **Replace**[\[4\]](#cite_note-4) button.  
    It will ask you whether you are sure that you want to replace the blueprint with the copy in the clipboard.

## How to update Workshop blueprints

If your blueprint is published to a [Workshop](https://spaceengineers.wiki.gg/wiki/Workshop "Workshop"), it is listed twice on the Blueprint screen, once with local/house icon and once with workshop icon.

Problem is you cannot paste ("Replace") an updated blueprint into the _workshop_ copy. So how to update it?

1.  Follow the instructions above for updating a _local_ blueprint (house icon).
2.  Then click **Publish** in the local copy.
3.  Fill in the basic meta data ("ship or station?") again.
4.  Choose the target workshop again.

It will detect the connected published blueprint and update it. Your existing workshop description and screenshots stay.

## Troubleshooting

### Steam Workshop troubleshooting

The **Steam Cloud** often interfers with saving Blueprints, most players switch it off.

1.  Open the **[Options](https://spaceengineers.wiki.gg/wiki/Options "Options") > Game** screen and disable "Steam Cloud".
2.  Make backups of _"%appdata%\\SpaceEngineers\\Blueprints\\_" because without the Steam Cloud, blueprints are saved locally.
3.  Enable the Steam Cloud feature only if you have more than one PC and want to transfer Saved Games from one PC to the other.

There is also a common UX issue that publishing blueprints on the Steam Workshop fails simply because it failed to upload the thumbnail screenshot, but the error message does not offer a solution. Try the following workaround:

1.  Open the hidden folder _"%appdata%\\SpaceEngineers\\Blueprints\\_" and find the folder containing your blueprint.
2.  Open the file named either thumb.png or thumb.jpg in MS Paint (or any other graphic editor of your liking) and simply resize it smaller.
3.  Resave the file and overwrite the old file so that it is less than 1 MB in size.
4.  Then try publishing again.

Find full version of this tip with all details here: [For anyone having issues with not being able to Upload Blueprints/Worlds or Mods to the Steam Workshop, Here's a workaround.](https://steamcommunity.com/app/244850/discussions/0/3192489172307109616/)
