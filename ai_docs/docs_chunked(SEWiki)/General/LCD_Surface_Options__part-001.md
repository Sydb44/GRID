---
title: "LCD Surface Options"
url: "https://spaceengineers.wiki.gg/wiki/LCD_Surface_Options"
category: "General"
wiki_page: "LCD Surface Options"
includes_blocks: true
---

# LCD Surface Options - Official Space Engineers Wiki

[![](https://spaceengineers.wiki.gg/images/thumb/Cockpit-LCDs-with-scripts.png/320px-Cockpit-LCDs-with-scripts.png?8886a5)](https://spaceengineers.wiki.gg/wiki/File:Cockpit-LCDs-with-scripts.png)

Fighter cockpit with customized built-in LCD surfaces

[LCD Panel blocks](https://spaceengineers.wiki.gg/wiki/LCD_Panels "LCD Panels") have only one built-in LCD Surface, but some cockpits have several. All LCD surfaces work the same way, and have the same settings as the freestanding LCD Panel blocks.

## LCD Surfaces

Some functional blocks have several LCD surfaces built in, for example [Cockpits](https://spaceengineers.wiki.gg/wiki/Cockpit_block "Cockpit block"), [Programmable Blocks](https://spaceengineers.wiki.gg/wiki/Programmable_Block "Programmable Block"), [Custom Turret Controllers](https://spaceengineers.wiki.gg/wiki/Custom_Turret_Controller "Custom Turret Controller"), [Sci-Fi Button Panels](https://spaceengineers.wiki.gg/wiki/Button_Panel "Button Panel"), and so on.

In constrast to the LCD block variants, built-in LCD surfaces are fixed to their block "as is" and you cannot reposition them. The advantage of the built-in surfaces is that they do not take up extra block space.

## Usage

To configure LCD surfaces:

1.  Access the [Control Panel Screen](https://spaceengineers.wiki.gg/wiki/Control_Panel_Screen "Control Panel Screen") of the block.
2.  If the block has more than 1 built-in LCD Surface, select one from the "LCD Panels" list.
3.  Choose which type of content to display:
    *   No Content (Default)
    *   Text and Images
    *   Apps (formerly Scripts)
4.  Select an app or configure text/image color (if applicable).

### How to Display Ship Status

[![](https://spaceengineers.wiki.gg/images/Analog-clock-lcd-script.png?6b6b10)](https://spaceengineers.wiki.gg/wiki/File:Analog-clock-lcd-script.png)

Analog Clock app running on an LCD surface

If you've selected **Content: Apps**, choose one of the following built-in apps:

*   [Artificial Horizon](https://spaceengineers.wiki.gg/wiki/Cockpit "Cockpit") -- Cockpit instruments that include an AGL Altimeter in the bottom right, current angular momentum in the bottom left, and Attitude Indicator (angled lines in unit degrees) in the center. Typically only used on mobile grids, not stations.
*   [Weather Forecast](https://spaceengineers.wiki.gg/wiki/Weather "Weather") for planets with an atmosphere.
*   [Planetary](https://spaceengineers.wiki.gg/wiki/Planets "Planets") and [artificial](https://spaceengineers.wiki.gg/wiki/Gravity_Generator "Gravity Generator") gravity
*   [Locked Target info](https://spaceengineers.wiki.gg/wiki/Target_Locking "Target Locking") -- Enemy Faction Name, Owner Name, Grid Name, Distance, Relative Velocity, Approach Velocity, Mass in Kilograms.
*   Velocity -- Current speed in metres per second. Typically only used on mobile grids.
*   [Hydrogen fuel](https://spaceengineers.wiki.gg/wiki/Hydrogen_Tank "Hydrogen Tank") -- "100%" means full tanks.
*   [Power usage levels](https://spaceengineers.wiki.gg/wiki/Power "Power") -- "100%" means you are maxing out available power and you should add more batteries or reactors.
*   Clock - The time of the day in real life, either as an analog or a digital 12-hour clock.
*   [Faction icon](https://spaceengineers.wiki.gg/wiki/Faction "Faction") -- Dynamically displays the icon of the ship's owning faction.
*   ([Vending Machine GUI](https://spaceengineers.wiki.gg/wiki/Vending_Machine "Vending Machine") and [Jukebox GUI](https://spaceengineers.wiki.gg/wiki/Jukebox "Jukebox")) -- Don't select these on LCDs, these only work on their respective blocks.

### How to Display Text and Images

If you've selected **Content: Text and Images**, configure which content you want to display.

*   Title -- Provide the public line of text that is shown when any players click the panel with an empty hand.
*   Rotation -- Optionally, turn the text and/or image sideways or upside down in steps of 90 degrees. (Since update 1.195)

### Text Options

[![](https://spaceengineers.wiki.gg/images/thumb/Lcd-fonts.png/320px-Lcd-fonts.png?7474ff)](https://spaceengineers.wiki.gg/wiki/File:Lcd-fonts.png)

Left-aligned Monospace font versus centered DEBUG font on an LCD panel

*   Edit Text -- Click this button to enter or paste text to display. Lines don't wrap automatically, so enter line breaks where necessary to make it fit.
*   Font -- Choose DEBUG or Monospace.
    *   The default variable-width font is called DEBUG.
    *   Choose the Monospace font if you want to use whitespace to align columns, or for ASCII art!
    *   The other fonts are not very useful. If you choose one of the colored fonts, the color mixes oddly with your font color choices below.
*   Font Size -- Scale the text between 0.1 and 10.0 to make it fit various panel sizes. Default size is 1.0.
*   Color -- Choose the text color.
*   Alignment -- Text can be left, center, or right aligned.
*   Text Padding -- The padding shifts the whole block of text relative to its Alignment. Use this to center text.
*   Background -- Choose a background color.

### Image options

[![](https://spaceengineers.wiki.gg/images/thumb/Sci-Fi_Button_Panel_DLC.png/320px-Sci-Fi_Button_Panel_DLC.png?ebdac5)](https://spaceengineers.wiki.gg/wiki/File:Sci-Fi_Button_Panel_DLC.png)

Sci-Fi Button Panels from the Sparks of the Future DLC

Using default images from the bult-in list ensures that all players can see them without issues even without loading mods. See below for alternatives how to set up custom images.

*   Loaded Textures -- Select from the list of default images, then click **Add to Selection** to display it. You can add more than one image and cycle, but you can only see one at a time.
*   Selected Textures -- Lists the images to be displayed. To stop using an image, select it here and click **Remove Selected**.
*   Image Change Interval -- Enter a delay in seconds. If you have selected several images, they are displayed one after the other with this delay in between. This allows for simple slideshow-like animations. Set it to zero to disable the slideshow.
*   Preserve Aspect Ratio -- Toggle this if an image comes out distorted. When using the built-in posters, also try the "H" and "V" variants to see whether their aspect ratios look better.
