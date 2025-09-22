---
title: "Fixing Download Corruption"
url: "https://spaceengineers.wiki.gg/wiki/Fixing_Download_Corruption"
category: "General"
wiki_page: "Fixing Download Corruption"
---

# Fixing Download Corruption - Official Space Engineers Wiki

If you're here for "World is corrupted" errors, this is not for that.  
That is usually fixable too but it depends what error causes it, ask for help in [KSH's discord server](https://discord.gg/keenswh).

If a working mod doesn't work for you in particular it's very possible the locally downloaded files either weren't updated or renamed/deleted files weren't removed. Complicated script-containing mods are particularly sensitive to this as they have multiple files and if any is left duplicated or missing then the whole thing can't compile.

## The Fix

This was written for Steam Workshop.  
Other platforms might not behave the same in regards to deleting mods.

1.  Exit game but leave Steam running
2.  Unsubscribe from the problematic mod (if not subscribed then: subscribe, go to step 3, unsub again)
3.  Wait for Steam to update SpaceEngineers (it will delete the mod)
4.  Grab the workshopId from the mod's link. Example link: `https://steamcommunity.com/sharedfiles/filedetails/?id=514062285&whatever=...`. The id there would be: 514062285
5.  Search for the number from step 4 in your `<Steam>/steamapps/workshop/` to find a folder with that exact name. Expected result is to not find anything, but if you do find something, delete the contents.
6.  Optional: subscribe to the mod again, this will make steam redownload it right then, otherwise it'll just be downloaded when you load/join a world with that mod, either way is fine.

All done, try the mod again!

If the problem persists, contact the author and provide your [game log](https://spaceengineers.wiki.gg/wiki/Support#Where_are_My_Log_Files? "Support"). Assuming you tried the mod in your last game session, otherwise you'll need to look in the other logs for the mod, or just zip'em and send'em all.