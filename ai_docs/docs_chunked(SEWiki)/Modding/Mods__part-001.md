---
title: "Mods"
url: "https://spaceengineers.wiki.gg/wiki/Mods"
category: "Modding"
wiki_page: "Mods"
includes_blocks: true
---

# Mods - Official Space Engineers Wiki

[![](https://spaceengineers.wiki.gg/images/thumb/SE-Mods.jpg/320px-SE-Mods.jpg?2f09a3)](https://spaceengineers.wiki.gg/wiki/File:SE-Mods.jpg)

A sample screenshot of a list of available mods

In Space Engineers, players can modify the game content by installing Mods. Mods are unofficial and free, and are different from official paid [DLC](https://spaceengineers.wiki.gg/wiki/DLC "DLC"). Mods add monolithic functionality and are easier to install and keep up-to-date than for example in-game [Scripts](https://spaceengineers.wiki.gg/wiki/Scripts "Scripts").

Typically, you download community-created mods from a public [Workshop](https://spaceengineers.wiki.gg/wiki/Workshop "Workshop"), but you can also learn to [write your own mods](https://spaceengineers.wiki.gg/wiki/Modding "Modding"). You enable mods for each saved world from its [World Settings](https://spaceengineers.wiki.gg/wiki/World_Settings "World Settings") screen.

## Should I install mods?

For new players, it is recommended to learn the base game (so called “vanilla”) first. Only if you need to fix a “quality of life” issue or want to modify blocks or game mechanics, then start looking into mods.

There is always a risk that an unmaintained mod will no longer load after an update. Some mods leave no trace when they are removed, and the impact on your save game will be low. Other mods will leave "gaping holes" when missing, or in the worst case, prevent a save from loading.

## How to install mods

Since you install mods into each game world individually, you can have several combinations of mods downloaded and play each modded world without having to quit and restart the whole game, like many other games require. This gives players much more control, especially when resolving mod conflicts.

Community mods are hosted on mod.io, or on the Steam workshop, or stored in local folders:

1.  Go to one of the [workshops](https://spaceengineers.wiki.gg/wiki/Workshop "Workshop") and search for interesting mods.  
    Tip: When searching the Steam Workshop, use the "**type:mod**" filter!
2.  Log on and subscribe to the mods of your choice.  
    Subscribing will download them into your local mods directory.
3.  Open Space Engineers and click **Load Game**.
4.  Select a game save and click **Edit**.
5.  On the [World Settings](https://spaceengineers.wiki.gg/wiki/World_Settings "World Settings") screen, click **Mods**.  
    A window opens that shows subscribed mods on the left and active mods on the right.
6.  Enable individual mods by moving them to the right side. Disable them by moving them to the left side.

### Load order

Mods added to a world in-game are loaded from bottom to top. This means the mods at the top of the list have priority, as their values will be used if multiple mods are overriding the same definition IDs (for details see [Things to know about SBC files](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC "Modding/Reference/SBC")).

The mod order is flipped for the [dedicated server GUI](https://spaceengineers.wiki.gg/wiki/Setting_up_a_Space_Engineers_Dedicated_Server "Setting up a Space Engineers Dedicated Server") and the save files (sandbox\_config.sbc), which show mods in the real load order from top to bottom.

### Dependencies

Mods can have other mods as dependencies, which are shown for steam on the right side under "REQUIRED ITEMS", and on mod.io under the "Dependencies" tab.

These dependencies will be **automatically added** to the world's mods list, therefore you do not need to manually add them to your mods list, and you don't need to subscribe to them eiher (even though Steam prompts you to do it, you can ignore it).

However, dependencies are loaded _after_ the mod which requested it, this is likely a bug. This is not an issue for mods referencing some things from the dependency mod, because definitions are loaded in ordered chunks, but it does become a problem when the mod wants to _override_ a definition from the dependency mod.

The mod dependencies feature can also be used to [create mod collections](https://spaceengineers.wiki.gg/wiki/Modding/Tutorials/Creating_Mod_Collections "Modding/Tutorials/Creating Mod Collections") without repacking any mods (which is generally frowned upon).

## How to update mods

When loaded from a Workshop subscription, enabled mods auto-update when you re-open a modded world.

Tip: In the Steam Workshop, mods that belong together can be grouped in a _Steam Collection_ for easier installation. Similarly, when joining a [Multiplayer](https://spaceengineers.wiki.gg/wiki/Multiplayer "Multiplayer") server that uses mods, all required mods are automatically identified and downloaded to your instance.

See also Troubleshooting below.

### How to identify deleted mods

Say for example a mod you used got deleted or made private, now you cannot load your world!  
To remove the missing mod you can go to the mods window and you'll see one or more mods with red text and a number.  
**However** the mod might be only temporarily unavailable for various reasons, some outside of author's control. It's recommended to do a manual backup (Save As) of your world before removing mods.

Find the name of the missing mod

If you want to know what the mod was called:

1.  First you need access to the file system (so only on PC)
2.  Write down the red number (or leave the game running)
3.  Navigate to `%appdata%\SpaceEngineers\Saves\` (you can paste this in explorer's address bar, it's a valid path)
4.  There the numbered folders are steam IDs for accounts, if there's more than one see [how to find your SteamId](https://help.steampowered.com/en/faqs/view/2816-BE67-5B69-0FEC).
5.  Next go into the specific world's folder and open `sandbox_config.sbc` with a text editor.
6.  Search for the red number inside this file and you should find the entry which might have a FriendlyName attribute to hint at what the mod was.
7.  Alternatively try searching for the red number online with steam workshop or mod.io as context, it might find a cached page of when it was public.
