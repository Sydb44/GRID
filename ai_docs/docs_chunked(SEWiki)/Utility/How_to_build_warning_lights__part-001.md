---
title: "How to build warning lights"
url: "https://spaceengineers.wiki.gg/wiki/How_to_build_warning_lights"
category: "Utility"
wiki_page: "How to build warning lights"
includes_blocks: true
---

# How to build warning lights

In your ship bridge, you may want a monitor with visual warnings that alert you when something important changes: Power is low, fuel is low, the ore cargo is full, an enemy approaches, the ammo cargo is empty, and many similar situations.

From release 1.206 on, you don't need two separate lights blocks for red and green, you can also build just one light block and use the **Set Color** action instead, if you want to save space.

## Example Build

The following screenshot shows a simple small-grid cargo warning monitor built on a locked large-grid rotor:

*   Left image: Low cargo = green light
*   Right image: Full cargo = red light

[![](https://spaceengineers.wiki.gg/images/thumb/Warning-monitor-lights.png/320px-Warning-monitor-lights.png?fe566e)](https://spaceengineers.wiki.gg/wiki/File:Warning-monitor-lights.png)

Small-grid monitor built on large-grid rotor.

Blocks used from left to right: Timer Block, Interior Light green, Interior Light red, Text Panel LCD, Event Controller.

Additionally needed blocks: Battery, a locked Rotor, Cargo Container (or which ever thing you want to monitor in your case).

## Additional steps for large grid only

If it's a small grid ship, skip this and continue with the building steps.

If you need a warning monitor _on a large-grid ship or station_, it's best to build the monitor in small-grid size and attach it to the large grid using a locked [Rotor](https://spaceengineers.wiki.gg/wiki/Rotor "Rotor"). We don't want this Rotor to rotate, we just use it as fixed "monitor stand."

Find a suitable spot for your "monitor stand" in your large-grid build, either embedded in the floor, the wall, or ceiling.

1.  Build a large grid [Rotor](https://spaceengineers.wiki.gg/wiki/Rotor "Rotor"). This is your monitor stand.
2.  In the Rotor's Control Panel, enable **Rotor Lock**.
3.  In the Rotor's Control Panel, click **Detach**.
4.  Make sure to grind down the large rotor head so it's out of the way.
5.  In the Rotor's Control Panel, click **Add Small Head** or **Add Medium Head**.

Now continue and _build the small-grid blocks_ on top of the small-grid rotor head!

[![](https://spaceengineers.wiki.gg/images/thumb/Large-grid-rotor-small-grid-head.png/320px-Large-grid-rotor-small-grid-head.png?fb5068)](https://spaceengineers.wiki.gg/wiki/File:Large-grid-rotor-small-grid-head.png)

You can build small-grid blocks on a small head of a large-grid rotor

## How to build a warning monitor

In the following example, we look at the "ore cargo full" case, but the same method also works for other events that the [Event Controller](https://spaceengineers.wiki.gg/wiki/Event_Controller "Event Controller") detects.

Tip: Since you may build several rows of monitors, name each block after its purpose! Otherwise you will have difficulty telling them all apart.

1.  Build two [Interior Lights](https://spaceengineers.wiki.gg/wiki/Interior_Light "Interior Light").
    1.  Set one light to green for "status okay" and one to red for "warning".
    2.  Name the lights by adding "ore monitor red" or "green" to the name.
    3.  Switch one light on and one off.
2.  Build a [Timer Block](https://spaceengineers.wiki.gg/wiki/Timer_Block "Timer Block").
    1.  Name the timer by adding "ore monitor" to its name.
    2.  Click **Set Up Actions** and, for both Interior lights, add their "Toggle Block on/off" action. Press [ESC key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings") to close the actions window.
    3.  Set the **Delay** to 00:00:01.
    4.  Press **Trigger Now** and verify that, when red is on, green is off, and vice versa.
    5.  Leave it so green is on and red is off.
3.  Build a [Text Panel](https://spaceengineers.wiki.gg/wiki/Text_Panel "Text Panel") or [Corner LCD](https://spaceengineers.wiki.gg/wiki/Corner_LCD "Corner LCD") as a label so you remember what these lights are for.
    1.  Name the LCD by adding "ore monitor" to the name.
    2.  Set the LCD to **Content: Text and Images**.
    3.  Click **Edit Text** and enter "ore cargo fill level"☆.
4.  Build an [Event Controller](https://spaceengineers.wiki.gg/wiki/Event_Controller "Event Controller") to monitor the block's status and name it.
    1.  Name the EC by adding "ore monitor" to the name.
    2.  Set **Event** to **Cargo Filled %**☆.
    3.  Set **Condition** to **Equal or greater than**☆.
    4.  Set **Threshold** to **90%**☆.
    5.  Under **Available Blocks**, select the ore cargo container☆ to monitor, and click **Add Blocks**.
    6.  Click **Select Actions**. Select the Timer and add its "trigger now" and "Run" actions to the two slots.

☆ The steps marked with a star depend on what you want to monitor, here, an ore container. But for example, if you wanted to monitor whether a tank is running dry, you'd choose **Gas tank filled**, **equal or lower than**, and add a tank in the EC.

## How does it work?

The EC now monitors the cargo fill level of this container.

*   If it exceeds 90%, the EC performs the first action, which is to toggle the lights, so green is off and red is on.
*   If it falls below 90%, the EC performs the second action, which is ALSO to toggle the lights, and now red is off and green is on.

Trivia: Usually the EC action is to run two separate Timer blocks: One to switch the light on and do something, and one to switch it off and do something else. But we merely want to toggle a light, so we simplify and use only one timer block that toggles both lights. The EC however does not accept the same block action twice, so we cannot set up Timer>Run for both slots. That's why we use Timer>Trigger Now for the second (which also runs the block, the outcome being the same).

## Are there better/further visible lights?

Do you find it hard to distinguish whether the [Interior Lights](https://spaceengineers.wiki.gg/wiki/Interior_Light "Interior Light") are on or off in a lit room?

*   Replace the interior lights with [Text Panels](https://spaceengineers.wiki.gg/wiki/Text_Panel "Text Panel") with a red or green background colour, and toggle them on and off.
*   Or if you have the DLC, replace the interior lights with one red and one green [Light Panel](https://spaceengineers.wiki.gg/wiki/Light_Panel "Light Panel"); they are black when off and show their bright colour when on.
*   Or if you have the DLC, and you want to depict two or more states in one block space, use  [![Icon Block Emotion Controller.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Block_Emotion_Controller.png/21px-Icon_Block_Emotion_Controller.png?f7897f)](https://spaceengineers.wiki.gg/wiki/Emotion_Controller "Emotion Controller") [Emotion Controller](https://spaceengineers.wiki.gg/wiki/Emotion_Controller "Emotion Controller")s.

If you need the warning lights to be visible very far, or even through walls, consider using named [Beacons](https://spaceengineers.wiki.gg/wiki/Beacon "Beacon") instead.
