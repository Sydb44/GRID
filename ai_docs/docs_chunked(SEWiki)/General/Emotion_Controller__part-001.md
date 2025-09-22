---
title: "Emotion Controller"
url: "https://spaceengineers.wiki.gg/wiki/Emotion_Controller"
category: "General"
wiki_page: "Emotion Controller"
includes_blocks: true
---

# Emotion Controller - Official Space Engineers Wiki

| Emotion Controller |     |
| --- | --- |
| [![Icon Block Emotion Controller.png](https://spaceengineers.wiki.gg/images/f/f1/Icon_Block_Emotion_Controller.png?f7897f)](https://spaceengineers.wiki.gg/wiki/File:Icon_Block_Emotion_Controller.png) |     |
| * * * |     |
| **Function:** | The Emotion Controller displays emoticons and can copy those to oth... |
| **DLC?** | Automatons |
| * * * |     |
| **Fits small grid** |     |
| Mass: | 51.0 kg |
| Hitpoints: | 175 |
| Power: | \-0.0001 MW |
| PCU: | 50  |
| Size: | 1x1x1 |
| Time to Build: | 8 sec |
| * * * |     |
| **Fits large grid** |     |
| Mass: | 460.0 kg |
| Hitpoints: | 1490 |
| Power: | \-0.0001 MW |
| PCU: | 50  |
| Size: | 1x1x1 |
| Time to Build: | 20 sec |
| * * * |     |
| _Data Controls:_ | \[[purge](https://spaceengineers.wiki.gg/wiki/Emotion_Controller?action=purge)\] ([?](https://spaceengineers.wiki.gg/wiki/Template:Info_Block))) |
|     |     |

The Emotion Controller is a decorative LCD panel block in Space Engineers. You can build it only if you have purchased the [Automatons Pack](https://spaceengineers.wiki.gg/wiki/Automatons_Pack "Automatons Pack") DLC, but other players can use it after it has been built.

This LCD panel is able to display 16 pre-loaded smiley faces on its front display. The difference to a standard LCD panel is that switching between these 16 images is available as toolbar actions for automation.

## Usage

Problem is, unless you add some coloured lights or sound block actions, it is hard to tell whether an event has been detected by [Sensors](https://spaceengineers.wiki.gg/wiki/Sensor "Sensor"), [Automaton](https://spaceengineers.wiki.gg/wiki/Automaton "Automaton") Blocks, or [Event Controllers](https://spaceengineers.wiki.gg/wiki/Event_Controller "Event Controller"). For each detected event, you would maybe like to change text on an LCD, change a light colour from green to red, or play a different warning sound. Unfortunately, such fine-grained actions are not available for LCDs and light and sound blocks. (See also [How to build warning lights](https://spaceengineers.wiki.gg/wiki/How_to_build_warning_lights "How to build warning lights") for workarounds.)

In an Emotion Controller, however, each face can be triggered by a built-in action. This means you can use it as a simple status indicator LCD.

### Usage examples

*   If block integrity > 90% then "Happy", else "Cry".
*   For two linked airlocks, look "Suspicious Left" for the leftside airlock cycle, and look "Suspicious Right" for the rightside airlock cycle.
*   If enemy player in range then "Angry" (or "Evil"), else "Neutral" (or "Skeptical").
*   If cargo full then "Sad", else "Neutral".
*   If obstacle detected then "Annoyed", else "Happy".
*   If low on hydrogen/power then "Dead" (or "Sleepy"), else "Happy".

And so on.

### Available Actions

[![](https://spaceengineers.wiki.gg/images/thumb/0/06/Automaton-emotions.jpg/320px-Automaton-emotions.jpg?d49361)](https://spaceengineers.wiki.gg/wiki/File:Automaton-emotions.jpg)

Switch among sixteen expressions

The following faces are available as actions:

*   Angry >:-\[
*   Annoyed ◔\_◔
*   Confused :-/
*   Crying ;\_;
*   Dead x\_x
*   Evil >:-D
*   Happy :-)
*   Love ^\_^
*   Neutral :-|
*   Sad :-(
*   Shocked :-O
*   Skeptical ಠ\_o
*   Sleepy -\_-
*   Suspicious Left <\_<
*   Suspicious Right >\_>
*   Wink ;-)

For use as a standard LCD panel, you can still select the options described under [LCD Surface Options](https://spaceengineers.wiki.gg/wiki/LCD_Surface_Options "LCD Surface Options"): Text and Images, Scripts, or "no content".

### How to set a face manually

To set the LCD to display a face:

1.  Open the Emotion Controller's [Control Panel Screen](https://spaceengineers.wiki.gg/wiki/Control_Panel_Screen "Control Panel Screen").
2.  Select one or more of the available displays on the grid and click **Add**. It will show the same face on all selected displays.
3.  Select **Text and Images**.
4.  Then click one of the 16 buttons to display a smiley on the selected display.

Tip: Click **Edit Text** if you want to display static text or ASCII Art on top of the smiley face. Changing the _text_ is not possible through an action, so the same text will overlay all smiley images.

### How to accompany events with face changes automatically

Make your Sensor or Event Controller trigger multiple actions by starting different Timer blocks, as recommended. In each Timer block, simply add the specific smiley action as well. Now each detected event is accompanied by a change of displayed emotion on the monitor. The face lasts until the next event resets it, which makes it a status display.

## Gallery

*   [![Display the same face on other displays on the same grid.](https://spaceengineers.wiki.gg/images/thumb/4/49/Emotion_controller_configuring_displays.png/120px-Emotion_controller_configuring_displays.png?648dd5)](https://spaceengineers.wiki.gg/wiki/File:Emotion_controller_configuring_displays.png "Display the same face on other displays on the same grid.")
    
    Display the same face on other displays on the same grid.
    
*   [![You can still add static text on top of the smiley image.](https://spaceengineers.wiki.gg/images/thumb/8/87/Emotion_Controller_with_ascii_art.png/120px-Emotion_Controller_with_ascii_art.png?6df957)](https://spaceengineers.wiki.gg/wiki/File:Emotion_Controller_with_ascii_art.png "You can still add static text on top of the smiley image.")
    
    You can still add static text on top of the smiley image.
    

## Construction

The Emotion Controller exists for large grid and small grid and is 1x1x1 blocks in size. It has mount points on all sides. One side contains a [Control Panel](https://spaceengineers.wiki.gg/wiki/Control_Panel "Control Panel") so you can access it and configure it. The configuration consists of a list of 16 emotions, one of which will be displayed on the screen in front.

Tip: The front screen can still display text and images together with the smiley (for images, using the interval to alternate between smiley and another image).

The large grid block has two extra [configurable LCD panels](https://spaceengineers.wiki.gg/wiki/LCD_Surface_Options "LCD Surface Options") which can be independent of the Smiley functionality, a Small Screen and a Keyboard, which can display text and images as well as scripts.
