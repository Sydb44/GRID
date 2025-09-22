
Before Update 1.203, there used to be unexpected AND Gate behaviour so you may need to adjust some older block set-ups.

With AND Gate disabled, the EC originally did not monitor "the state" of these blocks like a logical formula. It just reacted to _events_ in the moment they happen [\[3\]](#cite_note-3).

Example: You had been monitoring if any of two doors are being opened:

1.  both A and B closed -> EC slot 2 triggers
2.  door A is opened -> EC slot 1 triggers
3.  door B is opened -> EC slot 1 triggers
4.  door A is closed -> EC slot 2 triggers?!

In both situation 2 and 4, one door was open and one was closed, but the EC reacted differently. It did not react to the _state_ that they were in (how many are open/closed), it reacted to the _event_ (one is opening or closing).

### In-depth Tutorials

[Vanilla logic gate tutorial by Wolak](https://steamcommunity.com/sharedfiles/filedetails/?id=3008744122) uses no scripts and is well suited for people who like Minecraft Redstone.

## Construction

If [Progression](https://spaceengineers.wiki.gg/wiki/Progression "Progression") is on, build a basic Assembler and some lighting block first to unlock this block. The Event Controller is 1x1x1 blocks large and exists for small and large grid. It uses 500W power.

The Event Controller block is quite cheap to build and can be used in early game, but it's also very fragile and breaks easily when exposed in battle. The large grid version has a built-in Control Panel. To access the small grid variant, you need to add a [Control Panel](https://spaceengineers.wiki.gg/wiki/Control_Panel "Control Panel") or use a cockpit or any other block with terminal access.

Neither block variant has any [configurable LCDs](https://spaceengineers.wiki.gg/wiki/LCD_Surface_Options "LCD Surface Options"), but both have a very techy looking front panel that can also be used for decoration.

## Recipe

| [![Icon Block Event Controller.png](https://spaceengineers.wiki.gg/images/thumb/1/17/Icon_Block_Event_Controller.png/21px-Icon_Block_Event_Controller.png?8d8e4e)](https://spaceengineers.wiki.gg/wiki/Event_Controller "Event Controller") Event Controller |     |     |     |     |
| --- | --- | --- | --- | --- |
| Component | Large Ship/Station  <br>Required | Large Ship/Station  <br>Optional | Small Ship  <br>Required | Small Ship  <br>Optional |
| [![Icon Item Interior Plate.png](https://spaceengineers.wiki.gg/images/thumb/7/77/Icon_Item_Interior_Plate.png/21px-Icon_Item_Interior_Plate.png?d80f8e)](https://spaceengineers.wiki.gg/wiki/Interior_Plate "Interior Plate") [Interior Plate](https://spaceengineers.wiki.gg/wiki/Interior_Plate "Interior Plate") | 10  | —   | 2   | —   |
| [![Icon Item Display.png](https://spaceengineers.wiki.gg/images/thumb/4/44/Icon_Item_Display.png/21px-Icon_Item_Display.png?a444bc)](https://spaceengineers.wiki.gg/wiki/Display "Display") [Display](https://spaceengineers.wiki.gg/wiki/Display "Display") | 4   | —   | 1   | —   |
| [![Icon Item Computer.png](https://spaceengineers.wiki.gg/images/thumb/7/72/Icon_Item_Computer.png/21px-Icon_Item_Computer.png?65c1a4)](https://spaceengineers.wiki.gg/wiki/Computer "Computer") [Computer](https://spaceengineers.wiki.gg/wiki/Computer "Computer") | 10  | —   | 2   | —   |
| [![Icon Item Construction Comp..png](https://spaceengineers.wiki.gg/images/thumb/4/45/Icon_Item_Construction_Comp..png/21px-Icon_Item_Construction_Comp..png?cdc26f)](https://spaceengineers.wiki.gg/wiki/Construction_Comp. "Construction Comp.") [Construction Comp.](https://spaceengineers.wiki.gg/wiki/Construction_Comp. "Construction Comp.") | 20  | 10  | 2   | 1   |

## References

1.  [↑](#cite_ref-1 "Jump up") [https://twitter.com/SpaceEngineersG/status/1587483354391228416](https://twitter.com/SpaceEngineersG/status/1587483354391228416)
2.  [↑](#cite_ref-2 "Jump up") Through a Connector, you can even _remotely_ trigger an Event Controller. The trigger event can be as simple as toggling a light on. The trick is to have the event controller on the drone start watching a block (e.g. a light) on the carrier's grid when the drone is docked. Once undocked, the event controller still watches the block even though the grids are separate. Keen may change this though as it could be considered a bug. 🙂
3.  [↑](#cite_ref-3 "Jump up") [https://support.keenswh.com/spaceengineers/pc/topic/28005-event-controller-does-not-properly-track-block-states-in-normal-or-mode](https://support.keenswh.com/spaceengineers/pc/topic/28005-event-controller-does-not-properly-track-block-states-in-normal-or-mode)