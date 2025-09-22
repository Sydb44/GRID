3.  If the description asks you to customise some lines, do that now.
4.  Click **Check Code** and a dialog will say "Compilation successful" (or give an error message about what you'll need to fix). Click OK.
5.  Click **OK** to save the script.
6.  If you are using a script that needs custom data:
    1.  Click **Custom Data**.
    2.  Enter your values and click OK.
    3.  Click **Recompile**.
7.  Optional/If applicable: Enter an **argument** in the Argument field.
8.  Click **Run**.

You will see helpful info in the bottom right corner.

Some scripts run in a loop. For others, you must set up a trigger (button, sensor, timer) that executes the Run action.

### How to start the script

There are many ways to start a script, some require you to build additional blocks on the grid. Refer to the script's workshop page description for proper usage.

The following triggers are not mutually exclusive, you can activate the same PB in many ways:

*   Scripts can run themselves if programmed that way.
*   Manually using the Run button on the [Control Panel Screen](https://spaceengineers.wiki.gg/wiki/Control_Panel_Screen "Control Panel Screen").
*   Assign the PB Run action to a [Toolbar slot](https://spaceengineers.wiki.gg/wiki/Tool_Bar "Tool Bar").
*   Assign the PB Run action to any [Button Panel](https://spaceengineers.wiki.gg/wiki/Button_Panel "Button Panel") so players can push the buttons in game.
*   If the tasks depends on the proximity of someone/something, use a [Sensor](https://spaceengineers.wiki.gg/wiki/Sensor "Sensor") to trigger the PB Run action.
*   If you want to run it together with other actions, set up a [Timer Block](https://spaceengineers.wiki.gg/wiki/Timer_Block "Timer Block") to trigger the PB Run action and the others.
*   If you have a drone or shuttle that is controlled by the [Remote Control Autopilot](https://spaceengineers.wiki.gg/wiki/Autopilot "Autopilot"), any waypoint can trigger the PB Run action.

Tip: Assign a custom label for the Programmable Block "Run" action to be able to add several to your toolbar.

### Troubleshooting

*   If the Programmable Block editor is stuck and you cannot close the window, nor click any buttons, click _both_ mouse buttons to get unstuck.[\[1\]](#cite_note-1)
*   If your cursor is stuck in the Edit window and none of the buttons on the bottom work, try right-clicking the button _while_ holding left-click. This is a workaround for a rare bug that can happen.[\[2\]](#cite_note-2)
*   If you don't see an **Edit** button, save and close the game, open its Advanced [World Settings](https://spaceengineers.wiki.gg/wiki/World_Settings "World Settings"), and enable **In-Game Scripts**.
*   If you have made any changes that affect the script, such as renaming blocks or changing Custom Data, always click **Recompile**.

> When you click **Help** inside the Code editor, it will open an old guide on Steam that has old-looking screenshots — don't let that scare you off scripting. Bookmark and read this new in-game Script guide by Malware instead: [Scripting](https://spaceengineers.wiki.gg/wiki/Scripting "Scripting").

### When NOT to use PBs?

*   A PB obviously only helps you accomplish your task if a SE API exists that performs the tasks that you want. Also, you or somebody must write the script. Don't expect the PB itself to help you with the programming.
*   If you want to steer a drone ship, consider first whether the standard [Autopilot](https://spaceengineers.wiki.gg/wiki/Autopilot "Autopilot"), [Event Controller](https://spaceengineers.wiki.gg/wiki/Event_Controller "Event Controller"), or [Automaton](https://spaceengineers.wiki.gg/wiki/Automaton "Automaton") can do what you need in a simpler way.
*   Badly written scripts are very performance intensive when they loop unnecessarily fast. If millisecond speed and precise calculation and setting of values is not essential, PBs are overkill, use other less resource-heavy methods first.
*   On multiplayer servers, an admin may disallow the use of all or certain scripts, so don’t rely on them too much outside your singleplayer games.

## Gallery

[![](https://spaceengineers.wiki.gg/images/thumb/Programmable-block-small.png/320px-Programmable-block-small.png?b1144f)](https://spaceengineers.wiki.gg/wiki/File:Programmable-block-small.png)

The small-grid variant of a PB looks like a wall-mounted laptop. Small battery in the background.

## Construction

You must build one Programmable block per script. They are cheap to build but take up 1x1x1 space, both on large and small grids.

The large-grid block has mount points on the bottom side. It has one side with a decorative screen interface that you may want to keep accessible, but that's not a requirement. The small grid block has one mount point on the backside.

Its LCD surfaces are [configurable](https://spaceengineers.wiki.gg/wiki/LCD_Surface_Options "LCD Surface Options"): Unless the script itself uses them to display its status, you can put any content on them, including built-in LCD scripts or text or images.

Visually, the large grid block looks like a fridge-sized mainframe with a built-in LCD display and keyboard. The small-grid variant looks like a small wall-mounted tablet with a small keyboard hanging under it. You can use PBs decoratively without loading an actual script, for example, if you build a chair in front of the large-grid variant, it looks like a workstation or bridge officer’s seat.

## Recipe

| [![Icon Block Programmable Block.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Block_Programmable_Block.png/21px-Icon_Block_Programmable_Block.png?9d067f)](https://spaceengineers.wiki.gg/wiki/Programmable_Block "Programmable Block") Programmable Block |     |     |     |     |
| --- | --- | --- | --- | --- |
| Component | Large Ship/Station  <br>Required | Large Ship/Station  <br>Optional | Small Ship  <br>Required | Small Ship  <br>Optional |
| [![Icon Item Steel Plate.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Item_Steel_Plate.png/21px-Icon_Item_Steel_Plate.png?437e3a)](https://spaceengineers.wiki.gg/wiki/Steel_Plate "Steel Plate") [Steel Plate](https://spaceengineers.wiki.gg/wiki/Steel_Plate "Steel Plate") | 11  | 10  | 1   | 1   |
| [![Icon Item Motor.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Item_Motor.png/21px-Icon_Item_Motor.png?4a2f3f)](https://spaceengineers.wiki.gg/wiki/Motor "Motor") [Motor](https://spaceengineers.wiki.gg/wiki/Motor "Motor") | 1   | —   | 1   | —   |
| [![Icon Item Large Steel Tube.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Item_Large_Steel_Tube.png/21px-Icon_Item_Large_Steel_Tube.png?31c1e4)](https://spaceengineers.wiki.gg/wiki/Large_Steel_Tube "Large Steel Tube") [Large Steel Tube](https://spaceengineers.wiki.gg/wiki/Large_Steel_Tube "Large Steel Tube") | 2   | —   | 2   | —   |
| [![Icon Item Display.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Item_Display.png/21px-Icon_Item_Display.png?a444bc)](https://spaceengineers.wiki.gg/wiki/Display "Display") [Display](https://spaceengineers.wiki.gg/wiki/Display "Display") | 1   | —   | 1   | —   |
| [![Icon Item Construction Comp..png](https://spaceengineers.wiki.gg/images/thumb/Icon_Item_Construction_Comp..png/21px-Icon_Item_Construction_Comp..png?cdc26f)](https://spaceengineers.wiki.gg/wiki/Construction_Comp. "Construction Comp.") [Construction Comp.](https://spaceengineers.wiki.gg/wiki/Construction_Comp. "Construction Comp.") | 4   | —   | 2   | —   |
| [![Icon Item Computer.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Item_Computer.png/21px-Icon_Item_Computer.png?65c1a4)](https://spaceengineers.wiki.gg/wiki/Computer "Computer") [Computer](https://spaceengineers.wiki.gg/wiki/Computer "Computer") | 2   | —   | 2   | —   |
