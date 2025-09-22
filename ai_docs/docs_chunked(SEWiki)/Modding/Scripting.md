---
title: "Ingame Scripting"
url: "https://spaceengineers.wiki.gg/wiki/Scripting"
category: "Modding"
wiki_page: "Scripting"
includes_blocks: true
---

# Ingame Scripting - Official Space Engineers Wiki

[![pseudo script screenshot](https://spaceengineers.wiki.gg/images/thumb/Fake_pseudo_script.png/320px-Fake_pseudo_script.png?99c4f1)](https://spaceengineers.wiki.gg/wiki/File:Fake_pseudo_script.png)

Fake pseudo script for illustration, don't use :-)

[Programmable Blocks](https://spaceengineers.wiki.gg/wiki/Programmable_Block "Programmable Block") (PBs) execute your in-game scripts that can interact with any block in the game. On PCs, PB scripts can, for example, control block actions or read and write settings that you normally change manually through the [terminal](https://spaceengineers.wiki.gg/wiki/Terminal "Terminal").

This page is about _writing_ in-game scripts. See [Scripts](https://spaceengineers.wiki.gg/wiki/Scripts "Scripts") to learn about their requirements or how to use them.

  
Even though both are found on the workshop, you need to distinguish PB scripts from [mods](https://spaceengineers.wiki.gg/wiki/Mods "Mods"). When searching the Steam [Workshop](https://spaceengineers.wiki.gg/wiki/Workshop "Workshop") for sample PB scripts to learn from, select the filter “Type: IngameScript”, and not “Mod category: Script”!

## Quick Introduction to Space Engineers Ingame Scripts

*   **[Quick Introduction to Space Engineers Ingame Scripts](https://spaceengineers.wiki.gg/wiki/Scripting/Quick_Introduction_to_Space_Engineers_Ingame_Scripts "Scripting/Quick Introduction to Space Engineers Ingame Scripts")**
    *   [The Anatomy of a Script](https://spaceengineers.wiki.gg/wiki/Scripting/The_Anatomy_of_a_Script "Scripting/The Anatomy of a Script")
    *   [Your First Script](https://spaceengineers.wiki.gg/wiki/Scripting/Your_First_Script "Scripting/Your First Script")
    *   [Continuous Running No Timers Needed](https://spaceengineers.wiki.gg/wiki/Scripting/Continuous_Running_No_Timers_Needed "Scripting/Continuous Running No Timers Needed")
    *   [The Grid Terminal System](https://spaceengineers.wiki.gg/wiki/Scripting/The_Grid_Terminal_System "Scripting/The Grid Terminal System") (getting blocks)
        *   [Block Groups](https://spaceengineers.wiki.gg/wiki/Scripting/Block_Groups "Scripting/Block Groups")
    *   [Terminal Properties And Actions](https://spaceengineers.wiki.gg/wiki/Scripting/Terminal_Properties_And_Actions "Scripting/Terminal Properties And Actions")
        *   [List of Available Properties and Actions](https://github.com/malware-dev/MDK-SE/wiki/List-Of-Terminal-Properties-and-Actions)
    *   [Handling Script Arguments](https://spaceengineers.wiki.gg/wiki/Scripting/Handling_Script_Arguments "Scripting/Handling Script Arguments")
    *   [Handling Configuration and Storage](https://spaceengineers.wiki.gg/wiki/Scripting/Handling_Configuration_and_Storage "Scripting/Handling Configuration and Storage")
    *   [The Runtime](https://spaceengineers.wiki.gg/wiki/Scripting/The_Runtime "Scripting/The Runtime")
    *   [The Storage String](https://spaceengineers.wiki.gg/wiki/Scripting/The_Storage_String "Scripting/The Storage String")
    *   [Get The Running Programmable Block](https://spaceengineers.wiki.gg/wiki/Scripting/The_Running_Programmable_Block "Scripting/The Running Programmable Block")
    *   [Do's and Don'ts](https://spaceengineers.wiki.gg/wiki/Scripting/Do%27s_and_Don%27ts "Scripting/Do's and Don'ts")
    *   [MDK: Malware's Development Kit - Write scripts in Visual Studio](https://spaceengineers.wiki.gg/wiki/Scripting/MDK "Scripting/MDK")
*   **Advanced Techniques**
    *   [Text Panels and Drawing Sprites](https://spaceengineers.wiki.gg/wiki/Scripting/Text_Panels_and_Drawing_Sprites "Scripting/Text Panels and Drawing Sprites")
        *   [Sprite Listing](https://github.com/malware-dev/MDK-SE/wiki/Sprite-Listing)
    *   [Antenna Communication (IGC)](https://spaceengineers.wiki.gg/wiki/Scripting/Antenna_Communication_\(IGC\) "Scripting/Antenna Communication (IGC)")
        *   [List of allowed types in IGC messages](https://spaceengineers.wiki.gg/wiki/Scripting/IGC_Allowed_Message_Types "Scripting/IGC Allowed Message Types")
    *   [Displaying Things](https://spaceengineers.wiki.gg/wiki/Scripting/Displaying_Things "Scripting/Displaying Things")
    *   [Detecting Things](https://spaceengineers.wiki.gg/wiki/Scripting/Detecting_Things "Scripting/Detecting Things")
    *   [Entity Components](https://spaceengineers.wiki.gg/wiki/Scripting/Entity_Components "Scripting/Entity Components")
    *   [The EntityId](https://spaceengineers.wiki.gg/wiki/Scripting/The_EntityId "Scripting/The EntityId")
    *   [Debugging Your Scripts](https://spaceengineers.wiki.gg/wiki/Scripting/Debugging_Your_Scripts "Scripting/Debugging Your Scripts")
        *   [Visual debug with a mod](https://spaceengineers.wiki.gg/wiki/Scripting/Visual_debug_with_a_mod "Scripting/Visual debug with a mod")
        *   [Debugging with dnSpy](https://spaceengineers.wiki.gg/wiki/Scripting/Debugging_with_dnSpy "Scripting/Debugging with dnSpy")
        *   [dnSpy tips and tricks](https://spaceengineers.wiki.gg/wiki/Scripting/dnSpy_tips_and_tricks "Scripting/dnSpy tips and tricks")
        *   [Profiling the Game](https://spaceengineers.wiki.gg/wiki/Scripting/Profiling_the_Game "Scripting/Profiling the Game")
    *   [Coroutines - Run operations over multiple ticks](https://spaceengineers.wiki.gg/wiki/Scripting/Coroutines_-_Run_operations_over_multiple_ticks "Scripting/Coroutines - Run operations over multiple ticks")
*   **API**
    *   [API Index](https://github.com/malware-dev/MDK-SE/wiki/Api-Index)
    *   [Whitelist Overview](https://github.com/malware-dev/MDK-SE/wiki/Whitelist-Overview)
    *   [API Changes in Game Updates](https://spaceengineers.wiki.gg/wiki/Modding/Reference/Overview_of_Modding-Relevant_Changes_in_Game_Patches "Modding/Reference/Overview of Modding-Relevant Changes in Game Patches")
    *   [List of Definition IDs](https://github.com/malware-dev/MDK-SE/wiki/Type-Definition-Listing) (blocks, items, blueprints, etc)
*   **Miscellaneous**
    *   [Tools](https://spaceengineers.wiki.gg/wiki/Scripting/Tools "Scripting/Tools")
    *   [PID Controllers](https://spaceengineers.wiki.gg/wiki/Scripting/PID_Controllers "Scripting/PID Controllers")
    *   [Vector Transformations with World Matrices](https://spaceengineers.wiki.gg/wiki/Scripting/Vector_Transformations_with_World_Matrices "Scripting/Vector Transformations with World Matrices")
    *   [Finding a block's orientation](https://spaceengineers.wiki.gg/wiki/Scripting/Finding_a_block%27s_orientation "Scripting/Finding a block's orientation")