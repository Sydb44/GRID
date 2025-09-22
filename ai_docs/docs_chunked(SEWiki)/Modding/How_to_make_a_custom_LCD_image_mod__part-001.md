---
title: "How to make a custom LCD image mod"
url: "https://spaceengineers.wiki.gg/wiki/How_to_make_a_custom_LCD_image_mod"
category: "Modding"
wiki_page: "How to make a custom LCD image mod"
includes_blocks: true
---

# How to make a custom LCD image mod

How to insert your own custom [LCD images](https://spaceengineers.wiki.gg/wiki/LCD_Surface_Options "LCD Surface Options") into the game like [Splitsie's Impossible Images](https://steamcommunity.com/sharedfiles/filedetails/?id=2183745839)?

To follow this tutorial, you will need basic knowledge how to edit XML files (for example in NotePad++) and how to create DDS image files (I used Paint.net).

## Source

![](https://i.ytimg.com/vi/ZdX7pR1UxKs/hqdefault.jpg)

Load video

## Create the folder structure

1.  Go to `%APPDATA%\SpaceEngineers\Mods`. If it doesn't exist, create that folder.
2.  Create a new folder under `Mods`, its name is the name of your mod, for example, `MyLCDMod`. `%APPDATA%\SpaceEngineers\Mods\MyLCDMod`
3.  In the `MyLCDMod` folder, create the following folder structure:
    *   `%APPDATA%\SpaceEngineers\Mods\MyLCDMod\Textures\Models`
    *   _`%APPDATA%\SpaceEngineers\Mods\MyLCDMod\Textures\Models\MyFirstImage.dds`_
    *   _`%APPDATA%\SpaceEngineers\Mods\MyLCDMod\Textures\Models\MySecondImage.dds`_...
    *   `%APPDATA%\SpaceEngineers\Mods\MyLCDMod\Data`
    *   `%APPDATA%\SpaceEngineers\Mods\MyLCDMod\Data\LCDTextures.sbc`
    *   `%APPDATA%\SpaceEngineers\Mods\MyLCDMod\thumb.jpg`

Next, we create the files:

## Create the thumbnail file

Take a screenshot and resize it, use an image editor to add title text if you like.

Save the thumbnail file as thumb.jpg or thumb.png. The mandatory requirement is that the thumbnail file size must be less than 1 MB.

## How to convert the images

1.  Open Paint.net.
2.  Use **Image > Resize** and resize the canvas to an LCD size, typically, 512x512 square, or 128x265, the important thing is that the side lengths must be a power of two!
3.  Paste or create your image on the canvas.
4.  Delete the white background to get transparency.
5.  If you want the image to be translucent on a transparent LCD in game, use **Layers>Layer Properties** to reduce the opacity a bit (e.g. 250 instead of 255).
6.  Then **File > Save As**:
    1.  Select DirectDrawSurface (DDS).
    2.  Enter a file name, e.g. "MyFirstImage.dds".
    3.  Select the `%APPDATA%\SpaceEngineers\Mods\MyLCDMod\Textures\Models` folder as location.
    4.  Click **Save**.
    5.  In the **Settings** dialog, select `R8G8B8A8` (mnemonic: RGBA with number 8 added).
    6.  Click OK.

## Create config files

Create a text file `%APPDATA%\SpaceEngineers\Mods\MyLCDMod\Data\LCDTextures.sbc` in e.g. NotePad++. Copy the following XML and edit it:

<?xml version="1.0"?>
<Definitions xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema"\>
  <LCDTextures>

   <LCDTextureDefinition>
     <Id>
       <TypeId>LCDTextureDefinition</TypeId>
       <SubtypeId>My First Image</SubtypeId>
     </Id>
    <TexturePath>Textures\\Models\\MyFirstImage.dds</TexturePath>
   </LCDTextureDefinition>
   
   <LCDTextureDefinition>
     <Id>
       <TypeId>LCDTextureDefinition</TypeId>
       <SubtypeId>My Second Image</SubtypeId>
     </Id>
    <TexturePath>Textures\\Models\\MySecondImage.dds</TexturePath>
   </LCDTextureDefinition>

  </LCDTextures>
</Definitions>

Each LCDTextureDefinition adds one image, this example has two. In each definition, edit two attributes:

1.  Enter the name of the image in the `<SubtypeID>` element. That's the name visible in game.
2.  Enter the relative path inside your `MyLCDMods` folder in the `<TexturePath>` element.

Leave the rest as is. To add more than two images, copy and paste another `<LCDTextureDefinition>` block and edit it.

## Install and test the mod

1.  Start Space Engineers and click **Load Game**.
2.  Select a save and click **Edit** to edit the World Settings.
3.  Click **Mods** to open the Mods window.
4.  Select your mod `MyLCDMod` on the left side, then click the single right arrow in the center to add it to the game. Click **OK**.
5.  Click **OK** again to close the World Settings screen.
6.  Click **Load**.

Now you should be able to select your custom images on an LCD or cockpit screen.

Tip: To share it with others, publish it to the Steam or mod.io workshop from the Mods window.

## Publish/Update the Mod

For each update:

1.  Start Space Engineers and click **Load Game**.
2.  Select a save and click **Edit** to edit the World Settings.
3.  Click **Mods** to open the Mods window.
4.  Select your mod `MyLCDMod` on the left side, and click **Publish**.
5.  Update the Type and edit the description etc. as needed. To update the thumbnail or data, edit the files directly.
6.  Click **OK** to close the World Settings screen.

## Aside: How do I know what to put into the SBC file?

The SBC file in your mod typically starts out as the copy of an existing SBC file from the base game that you copy and learn from.

The default location of your game directory is:

C:\\Program Files (x86)\\Steam\\steamapps\\common\\SpaceEngineers\\

In this directory, go into the Data subdirectory and look at existing SBC files to learn how game rules, sounds, planets, images, models, etc. are defined.

C:\\Program Files (x86)\\Steam\\steamapps\\common\\SpaceEngineers\\Content\\Data\\

For example, you can find LCD image definitions in this file:

C:\\Program Files (x86)\\Steam\\steamapps\\common\\SpaceEngineers\\Content\\Data\\LCDTextures.sbc

You recognise the list of LCD images that are included in the game. To create a mod, you mirror the structure and create a copy along the same pattern, with new IDs and paths inserted (as described here). Of course it's not always so simple -- sometimes you don't know what values to enter, which ones are optional and which ones mandatory, and so on... But after you have found a related file, you can at least start asking questions about it in [Keen's modding Discord](https://discord.com/channels/125011928711036928/126460115204308993).

**Tip:** To search keywords in XML files fast, open the Data directoy as [workspace](https://npp-user-manual.org/docs/session/#folder-as-workspace) in NotePad++, right-click it, and use the [Find in Files](https://npp-user-manual.org/docs/searching/) option to search the whole directory.
