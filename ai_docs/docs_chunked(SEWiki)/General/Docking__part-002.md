If you detach and grind off the heads of Rotors and Hinges, and rebuild the head on another grid, you can move them together and click a button on the base part's [Control Panel Screen](https://spaceengineers.wiki.gg/wiki/Control_Panel_Screen "Control Panel Screen") to attach the new head. While this kind of docking is unidirectional (initiated by the side with the rotor/hinge base), once the pair is attached, you gain terminal access, allowing you to initiate undocking from either side of the connection.

Unlike connectors, rotors don't have a break force limit.

Pros:

*   [Advanced Rotors](https://spaceengineers.wiki.gg/wiki/Advanced_Rotor "Advanced Rotor") and Hinges also possess conveyor ports for inventory access.
*   Mechanical docking is flexible to bend at angles or to rotate like a truck hitch.
*   Mechanical docking also allows [docking of small and large grids](https://spaceengineers.wiki.gg/wiki/How_to_connect_small_and_large_grid_blocks "How to connect small and large grid blocks").

Cons:

*   The process of attaching through mechnical blocks is a bit fiddly and jerky.

## What to do after docking

After docking to a carrier, switch off [Inertial Dampers](https://spaceengineers.wiki.gg/wiki/Inertial_Dampers "Inertial Dampers") and thrusters, so the docked ship does not fight the carrier.

After docking a hydrogen ship, switch your hydrogen tanks to stockpile and batteries to recharge.

Consider automating your post docking actions using [Event Controllers](https://spaceengineers.wiki.gg/wiki/Event_Controller "Event Controller") and [Timers](https://spaceengineers.wiki.gg/wiki/Timer_Block "Timer Block").

## Docking Methods Comparison

For each docking block this table compares factors that may influence your choice.

*   To use this docking method, do you need ownership of the other grid or can it dock to anything?
*   Do you require power transfer?
*   Do you require inventory access?
*   Do you need to be able to pilot and control wheels and thrusters of the docked mobile grid, or will it be dead weight?
*   Do you require to dock large and small grids together or is this method limited to one grid size?
*   Do you require to pilot the ship in gravity while docked to the other and do you rely on inertial dampeners?[\[1\]](#cite_note-1)
*   Do you need either some leeway or perfect block alignment in your docking procedure?

|     |     |     |     |     |     |     |     |
| --- | --- | --- | --- | --- | --- | --- | --- |Docking Method Comparison
| Docking blocks | Permissions | Power transfer? | Inventory access? | Can I pilot the docked grid? | Large Grid + Small Grid? | Causes drifting in gravity? | Alignment |
| [Landing Gear](https://spaceengineers.wiki.gg/wiki/Landing_Gear "Landing Gear") | No ownership needed | no  | no  | no  | yes | yes | much leeway |
| [Connectors](https://spaceengineers.wiki.gg/wiki/Connector "Connector") | Neutral or ally | yes | yes | yes if ally | yes | yes | a bit of leeway |
| [Merge Blocks](https://spaceengineers.wiki.gg/wiki/Merge_Block "Merge Block") | Ownership needed | yes | no  | yes | no  | no  | no leeway |
| [Rotor or  <br>Hinge](https://spaceengineers.wiki.gg/wiki/Mechanical_Blocks "Mechanical Blocks") | Ownership needed | yes | yes (except Basic Rotor) | No, subgrid limitations[\[2\]](#cite_note-2) | yes | yes | rotated leeway |

## References

1.  [↑](#cite_ref-1 "Jump up") [Bug: Inertial dampeners cant cope with multiple grids/subgrids](https://support.keenswh.com/spaceengineers/pc/topic/inertial-dampeners-cant-cope-with-multiple-gridssubgrids)
2.  [↑](#cite_ref-2 "Jump up") Unless you are using a subgrid thruster or wheel control script