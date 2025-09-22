C:\\Program Files (x86)\\Steam\\steamapps\\common\\SpaceEngineers\\

In this directory, go into the Data subdirectory and look at existing SBC files to learn how game rules, sounds, planets, images, models, etc. are defined.

C:\\Program Files (x86)\\Steam\\steamapps\\common\\SpaceEngineers\\Content\\Data\\

For example, you can find LCD image definitions in this file:

C:\\Program Files (x86)\\Steam\\steamapps\\common\\SpaceEngineers\\Content\\Data\\LCDTextures.sbc

You recognise the list of LCD images that are included in the game. To create a mod, you mirror the structure and create a copy along the same pattern, with new IDs and paths inserted (as described here). Of course it's not always so simple -- sometimes you don't know what values to enter, which ones are optional and which ones mandatory, and so on... But after you have found a related file, you can at least start asking questions about it in [Keen's modding Discord](https://discord.com/channels/125011928711036928/126460115204308993).

**Tip:** To search keywords in XML files fast, open the Data directoy as [workspace](https://npp-user-manual.org/docs/session/#folder-as-workspace) in NotePad++, right-click it, and use the [Find in Files](https://npp-user-manual.org/docs/searching/) option to search the whole directory.

## References

*   The default LCD images are defined in XML here: `C:\Program Files (x86)\Steam\steamapps\common\SpaceEngineers\Content\Data\LCDTextures.sbc`
*   The default LCD images in DDS format are here:  
    `C:\Program Files (x86)\Steam\steamapps\common\SpaceEngineers\Content\Textures\Models`
*   Your installed Space Engineers mods are here:  
    `C:\Program Files (x86)\Steam\steamapps\workshop\content\244850`
    *   For example, if you have ImpossibleImages installed from the Workshop, it's here:  
        `C:\Program Files (x86)\Steam\steamapps\workshop\content\244850\2183745839`