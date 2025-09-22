
You set up actions that depend on a room being pressurised inside an Air Vent block, not in an [Event Controller](https://spaceengineers.wiki.gg/wiki/Event_Controller "Event Controller").

1.  Open the Air Vent's [Control Panel Screen](https://spaceengineers.wiki.gg/wiki/Control_Panel_Screen "Control Panel Screen").
2.  Click **Set up Actions**. You'll see two action slots:
    *   The first action is triggered once, when the room is full of oxygen.
    *   The second action is triggered once, when the room has no more oxygen in it.

"No oxygen" means either that the room is no longer airtight because a door has been opened or a wall block was destroyed; or that the room is still airtight but active depressurization has just completed.

Typical actions to set up with this button are air lock related. An air lock cycle may require opening and closing doors combined with audio-visual alerts, and so on. To start a whole series of air lock actions, build several [Timer Blocks](https://spaceengineers.wiki.gg/wiki/Timer_Block "Timer Block"), one that pressurises the room and closes doors, and one that depressurises the room and opens the doors. And make the action slots start the Timers.

For details, see [airtightness](https://spaceengineers.wiki.gg/wiki/Airtightness "Airtightness").

## Troubleshooting

When the vent slats face outside:

*   If you attempt to depressurise airless space or planets/moons without atmospheres, simply nothing happens.
*   If you attempt to depressurise a planet's atmosphere, the atmosphere is not affected but the tanks slowly fill with oxygen.
*   If you attempt to pressurise anything but an airtight room, nothing happens. You can't pressurise space nor airless planets/moons nor voxel-enclosed areas such as caves.

In the presence of an air leak or vacuum, an Air Vent will not function. In the simplest case, if the [Doors](https://spaceengineers.wiki.gg/wiki/Door "Door") are open, the vents will not pressurize the room until you close the doors again. Careful: A small number blocks display unintuitive airtightness behaviour. For example, certain window blocks allow the player to walk in their concave volume indoors; the block space registers as unpressurised as if outdoors, and at the same time, the room registers as properly airtight and pressurised...

As many blocks, the Air Vent block itself is an example of a not-full-sized block whose airtightness depends on its rotation and on whether it's flush with other blocks. See [Airtightness](https://spaceengineers.wiki.gg/wiki/Airtightness "Airtightness") for the definition of leaks so you can avoid them. There is also an [Air Vent Full](https://spaceengineers.wiki.gg/wiki/Air_Vent_Full "Air Vent Full") that is always airtight.

Tip: The Steam workshop also offers leak detection mods, such as [Digi's Leak Finder](https://steamcommunity.com/sharedfiles/filedetails/?id=3170315974)

## Construction

This functional block is available for large and small grid sizes. It needs power to function.

The Air Vent Block has ventilation slats in the front and one conveyor port in the back. This port must be attached to a [conveyor system](https://spaceengineers.wiki.gg/wiki/Conveyor_system "Conveyor system") for the Vent to work.

## Recipe

| [![Icon Block Air Vent.png](https://spaceengineers.wiki.gg/images/thumb/7/7a/Icon_Block_Air_Vent.png/21px-Icon_Block_Air_Vent.png?2f99e7)](https://spaceengineers.wiki.gg/wiki/Air_Vent "Air Vent") Air Vent |     |     |     |     |
| --- | --- | --- | --- | --- |
| Component | Large Ship/Station  <br>Required | Large Ship/Station  <br>Optional | Small Ship  <br>Required | Small Ship  <br>Optional |
| [![Icon Item Computer.png](https://spaceengineers.wiki.gg/images/thumb/7/72/Icon_Item_Computer.png/21px-Icon_Item_Computer.png?65c1a4)](https://spaceengineers.wiki.gg/wiki/Computer "Computer") [Computer](https://spaceengineers.wiki.gg/wiki/Computer "Computer") | 5   | —   | 5   | —   |
| [![Icon Item Motor.png](https://spaceengineers.wiki.gg/images/thumb/2/2c/Icon_Item_Motor.png/21px-Icon_Item_Motor.png?4a2f3f)](https://spaceengineers.wiki.gg/wiki/Motor "Motor") [Motor](https://spaceengineers.wiki.gg/wiki/Motor "Motor") | 10  | —   | 2   | —   |
| [![Icon Item Construction Comp..png](https://spaceengineers.wiki.gg/images/thumb/4/45/Icon_Item_Construction_Comp..png/21px-Icon_Item_Construction_Comp..png?cdc26f)](https://spaceengineers.wiki.gg/wiki/Construction_Comp. "Construction Comp.") [Construction Comp.](https://spaceengineers.wiki.gg/wiki/Construction_Comp. "Construction Comp.") | 20  | —   | 10  | —   |
| [![Icon Item Steel Plate.png](https://spaceengineers.wiki.gg/images/thumb/4/4c/Icon_Item_Steel_Plate.png/21px-Icon_Item_Steel_Plate.png?437e3a)](https://spaceengineers.wiki.gg/wiki/Steel_Plate "Steel Plate") [Steel Plate](https://spaceengineers.wiki.gg/wiki/Steel_Plate "Steel Plate") | 20  | 10  | 2   | 1   |

1.  [↑](#cite_ref-1 "Jump up") Oxygen on planets can be high or low. You can "depressurize planets" for an unlimited time and the atmosphere never runs out of oxygen.