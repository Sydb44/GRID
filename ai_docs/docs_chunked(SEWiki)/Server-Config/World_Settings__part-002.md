*   Offline: Single-player. The game is run offline and "max players" option is disabled.  
    Note: Steam still requires an online connection for your Steam client to let you use mods and DLCs.
*   Private: Multiplayer. No one can see and join the game unless you invite them.
*   Friends: Multiplayer. Only the host's friends can see and join the game.
*   Public: Multiplayer. Anyone player can see and join the game. Likely attracts griefers.

### Max players

This option is only enabled when not playing in offline mode. It lets you set the maximum number of players allowed to be in the world at once. The host can choose to allow any number of players between 4 and practically 32, and theoretically 1024. Actual performance depends on the host’s hardware, internet bandwidth, and complexity of the loaded world.

### Auto-save

If enabled, the world will be periodically saved. To open a backup from the load screen, double-click the game save as if it were a directory, and select an auto-save.

### Max Backup Saves

If automatic backups (see: Auto-Save) are enabled, this setting controls how many backups will be kept in the save game folder. When you set this to zero, existing backups will be deleted.

## Optional: Mods

Opens an optional screen where you enable or disable [Mods](https://spaceengineers.wiki.gg/wiki/Mods "Mods") for this world.

> Tip: If you’re a beginner, don’t worry about Mods yet and skip this button. Better learn the “vanilla” game first. You can always add Mods later after you have an idea of the base gameplay.

*   If there are no mods listed, subscribe to some on any of the [Workshops](https://spaceengineers.wiki.gg/wiki/Workshop "Workshop") first.
*   The left side lists subscribed mods.
*   The right side lists Mods that are currently active in this world.
*   Select a mod and click the arrow buttons in the middle to add or remove them.

Read the mods’ descriptions to understand their compatibilities!

## Optional: Advanced Settings

If your game performance is fine and you want to play by the default game rules, just leave the advanced settings as is.

*   If your game has low FPS, you can try to improve performance by limiting some features.
*   If you find the default game to grindy, or too easy, you can change rules regarding the speed of progression here.
*   Admins and creative builders come here to enable Spectator mode and multiplayer options.
*   Experienced players give themselves an extra challenge by disabling third-person view or jetpacks, or by enabling permadeath, or in-game scripting.

### Global Multipliers

#### Assembler efficiency

This option determines both the production speed of [Assemblers](https://spaceengineers.wiki.gg/wiki/Assembler "Assembler") in the world and the amount of resources they take to produce items. There are three options to choose from:

*   Realistic: Assemblers work at the normal speed and take the amount of resources listed on this wiki.
*   x3: Assemblers work at three times the normal speed and use one third of the normal resources.
*   x10: Assemblers work at ten times the normal speed and use one tenth of the normal resources.

#### Refinery speed

This option determines the production speed of [Refineries](https://spaceengineers.wiki.gg/wiki/Refinery "Refinery") in the world. There are three options to choose from:

*   Realistic: Refineries work at the normal speed listed on this wiki.
*   x3: Refineries work at three times the normal speed.
*   x10: Refineries work at ten times the normal speed.

#### Block inventory size / Characters inventory size

This option determines the capacity of the player's own inventory and of blocks with inventories, but not the capacity of gas in tanks.

There are four options to choose from:

*   Realistic: The player can hold up to 400 L of items. The inventory capacity of blocks is the same as listed in their respective articles on this wiki.
*   x3: Player / block inventories are three times their realistic size.
*   x5: Player / block inventories are five times their realistic size.
*   x10: Player / block inventories are ten times their realistic size.

Warning: If you retroactively decrease these values for an existing world, excess content of inventories will be truncated and lost.

Blocks inventory size will automatically reduce the mass of items in ships so that a full ship flies similar regardless of the setting. This can of course lead to other issues, like the mass display on the HUD and info tab being inflated because it does not show the real mass of the ship.

#### Grinding speed

This option determines the speed at which blocks are salvaged using [grinding tools](https://spaceengineers.wiki.gg/wiki/Grinder "Grinder"). There are four options:

*   Realistic: The normal speed setting.
*   x0.5: Grinding reduced to half speed.
*   x2 / x5: Grinding increased by a factor of two/five.

#### Welding speed

This option determines the speed at which blocks are built using [welding tools](https://spaceengineers.wiki.gg/wiki/Welder "Welder"). There are four options:

*   Realistic: The normal speed setting.
*   x0.5: Welding reduced to half speed.
*   x2 / x5: Welding increased by a factor of two/five.

#### View Distance

Larger view distances can cause performance issues depending on how many objects are in the world. Large view distances are also not recommended in worlds with high asteroid density. The performance-friendly recommendation for low-end machines is 5-10 km, whereas 30-50km is only recommended for high-end machines. The default distance is 15 km.

#### Floating Object Limit

This option determines how many items are allowed to float freely in space or lie on the ground. Objects include space ship debris, dropped items like components and ingots, and mined rocks and ores. The host can set the maximum number of floating objects between 16 and 1024. Default is 100.

Warning: Having extremely large number of objects floating freely can slow down the game significantly. If the chosen maximum value is exceeded, the oldest objects (those that have been loose the longest) are automatically deleted from the world. The automatic deletion of debris is colloquially called **garbage collection** or **trash clean-up** and its behaviour can be configured or suspended on the [Admin Screen](https://spaceengineers.wiki.gg/wiki/Admin_Screen "Admin Screen") in a running game.
