---
title: "Groups"
url: "https://spaceengineers.wiki.gg/wiki/Groups"
category: "General"
wiki_page: "Groups"
includes_blocks: true
---

# Groups - Official Space Engineers Wiki

If you want to control several functional blocks of a [grid](https://spaceengineers.wiki.gg/wiki/Grid "Grid") together, _group_ them in the [Control Panel](https://spaceengineers.wiki.gg/wiki/Control_Panel_Screen "Control Panel Screen"). You can trigger a group's actions through the [Grid Toolbar](https://spaceengineers.wiki.gg/wiki/Tool_Bar "Tool Bar"), through [buttons](https://spaceengineers.wiki.gg/wiki/Button_Panel "Button Panel"), [AI blocks](https://spaceengineers.wiki.gg/wiki/Artificial_Intelligence "Artificial Intelligence"), or through [Timer Blocks](https://spaceengineers.wiki.gg/wiki/Timer_Block "Timer Block")!

![](https://i.ytimg.com/vi/KE0-eyZPO5g/hqdefault.jpg)

Load video

## Benefits of Using Groups

*   Each grid remembers its groups, even in its [blueprint](https://spaceengineers.wiki.gg/wiki/Blueprint "Blueprint"), and after [3D printing](https://spaceengineers.wiki.gg/wiki/3D_Printer "3D Printer").
*   [Timers](https://spaceengineers.wiki.gg/wiki/Timer_Block "Timer Block"), [buttons](https://spaceengineers.wiki.gg/wiki/Button_Panel "Button Panel"), and [AI blocks](https://spaceengineers.wiki.gg/wiki/Artificial_Intelligence "Artificial Intelligence") can trigger actions on groups.
*   Other players can trigger group actions if they have (faction) access to the blocks.
*   You can trigger group actions from the [toolbar](https://spaceengineers.wiki.gg/wiki/Toolbar "Toolbar") while seated in a cockpit.
*   If all blocks in the group are of the same type and have the same controls, grouping also gives you access to all control actions they have in common.
*   At minimum, grouping lets you switch all members on/off in one step.
*   Each block can be a member of many different groups.

## Usage Examples

You create a group containing all doors and name it `*MyShipName All Doors*`. This group gives you access to the `Open` and `Close` actions for all members of the `*MyShipName All Doors*` group, because they are all of type door, and all doors can open and close. Additionally, you can toggle the grouped blocks on and off.

If you make a group that mixes e.g. pistons and rotors, then you can reverse them and change their velocity, because they have these actions in common. Additionally, you can toggle the grouped blocks on and off. But you _cannot_ use the mixed group to change the braking force setting, because pistons don't have a braking force setting, only rotors do. You need a separate group for just the rotors.

## How to Create Groups

You group blocks on the [Control Panel Screen](https://spaceengineers.wiki.gg/wiki/Control_Panel_Screen "Control Panel Screen"):

1.  On the left side, use the search filter if needed to find specific blocks.
2.  Hold [CTRL key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings") and [![Left](https://commons.wiki.gg/images/thumb/Keyboard_White_Mouse_Left.png/20px-Keyboard_White_Mouse_Left.png?c1a406)](https://spaceengineers.wiki.gg/wiki/File:Keyboard_White_Mouse_Left.png "Left")\-click every block to include in the group.  
    Or [![Left](https://commons.wiki.gg/images/thumb/Keyboard_White_Mouse_Left.png/20px-Keyboard_White_Mouse_Left.png?c1a406)](https://spaceengineers.wiki.gg/wiki/File:Keyboard_White_Mouse_Left.png "Left")\-click the first block in the list, hold [SHIFT key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings") and [![Left](https://commons.wiki.gg/images/thumb/Keyboard_White_Mouse_Left.png/20px-Keyboard_White_Mouse_Left.png?c1a406)](https://spaceengineers.wiki.gg/wiki/File:Keyboard_White_Mouse_Left.png "Left")\-click the last block in the list to select a range.  
    Or press [CTRL+A key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings") to select all (filtered) blocks.
3.  In the text box in the top right, type a unique group name, then click **Save**.

In the control panel's block list on the left side, your groups are listed first. You can recognise them because group names are surrounded with asterisks, e.g. `*All Doors*`.

## Important Warnings When Using Groups

Messy thrusters groups cause crashes! Messy turret groups waste ammo! Messy wheel groups flip rovers! Messy door groups unseal airlocks! And so on.

### Let me tell you a story...

For example, you have created a group for "all thrusters" and another group for only "braking thrusters". After the groups' creation, you have built additional lifting thrusters.

1.  You toggle "all" thrusters on and start flying as usual.
2.  You toggle "all braking thrusters" off in order to "coast".
3.  You suddenly notice you are lacking lifting thrust!
    *   ⚠️ The newly built lifting thrusters are still off, because you forgot to add them to the "all" group.
4.  You panic, and toggle "all" thrusters again.
    *   ⚠️ Now, your braking thrusters are _on_, your lifting thrusters are still off, and the remaining thrusters are also off... Congrats, you're crashing.
5.  And now imagine the added confusion when a fleet of docked ships with the same group names toggle off _each other's_ thruster groups while docked in the hangar...

### Don't expect group names to be unique

*   If you create a group called e.g. **thrusters** on several ships, it will trigger a mess of actions in _all_ docked ships with the same group name.
*   You can purposefully use the same-named groups to launch several missiles together.
*   If you plan to have multiple independent drones [3D printed](https://spaceengineers.wiki.gg/wiki/3D_Printer "3D Printer") from the same [blueprint](https://spaceengineers.wiki.gg/wiki/Blueprint "Blueprint") docked at the same station, use [Timers](https://spaceengineers.wiki.gg/wiki/Timer_Block "Timer Block") instead of groups to be able to control each drone's actions separately.

### Don't expect groups to update themselves

*   If you damage and repair a block, it stays in its groups.
*   If you destroy and re-add a block, or add new blocks of the same type, you must manually add them to the groups.
*   A broken block has a gray broken icon in the toolbar. A group, however, stays in the toolbar, and you can simply redefine which block is in it.
*   If you create a new group, verify and update Timers, Buttons, Sensors, Toolbars, etc. that may be using the outdated group.
*   Delete outdated groups to avoid confusion.
