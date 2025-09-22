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

## Mod Troubleshooting

If mods are trying to modify the same SBC file, and you may see error messages in the log file. Identify mods with potentially overlapping effects and re-order them in the Mods list under [World Settings](https://spaceengineers.wiki.gg/wiki/World_Settings "World Settings")\>Mods before loading the world again. Sometimes it's possible to find a load order that is compatible, but not always. Also, read the notes by the mod creator who may be recommending load orders that are known to work.

If it says you cannot join a server because of a "version conflict", either your game or the mod versions are outdated. If mods do not auto update, try unsubscribing and resubscribing to the mod or mod collection in the workshop.

To find the path were your mods are stored by Steam on the hard drive, see [Modding](https://spaceengineers.wiki.gg/wiki/Modding "Modding").

If you get crashes or errors, there's a list of [known solutions to crashes or errors](https://spaceengineers.wiki.gg/wiki/Modding/Reference/Known_Solutions_to_crashes_or_errors "Modding/Reference/Known Solutions to crashes or errors").

## Differences Between Mods on PC and Console

Microsoft and Sony do not allow executing any kind of [scripts](https://spaceengineers.wiki.gg/wiki/Modding/Introduction_to_Modding_Space_Engineers#Scripting "Modding/Introduction to Modding Space Engineers") on their Xbox and PlayStation consoles.

If the script mod is installed on a [dedicated server](https://spaceengineers.wiki.gg/wiki/Setting_up_a_Space_Engineers_Dedicated_Server "Setting up a Space Engineers Dedicated Server") then console users can join as long as the mod scripts only compile [server-side](https://mod.io/g/spaceengineers?tags-in=Mod,ServerScripts).

Beyond that, console players can install only [SBC mods](https://spaceengineers.wiki.gg/wiki/SBC_File_Mods "SBC File Mods") in their own worlds. SBC mods, much like other non-core game files, are written in an human-readable XML format by Keen. They contain game rules, and do not contain any C# scripts that would run on the console itself.  
An example of an SBC mod that works on consoles is [Reddit Custom Encounters](https://mod.io/g/spaceengineers/m/reddit-custom-encounters-legacy) by Meridius\_IX/Lucas. Other SBC-only mods can be found with the [NoScripts](https://mod.io/g/spaceengineers?tags-in=Mod,NoScripts) tag.

[List of platform differences](https://spaceengineers.wiki.gg/wiki/Features#Platform_Differences "Features")