
*   The player's suit antenna has a range of 200 metres.
*   There are friendly antennas with overlapping ranges, set to broadcast (relay).
*   Within these antennas’ ranges, there are friendly remote grids equipped with antennas, not set to broadcast. Some of them additionally have Remote Control blocks.

In such a situation, expect the following:

*   Further than 200m away, the players can passively see the stronger antennas and receive from them, but cannot actively connect to them.
*   If you are seated in range of the antenna relay, you can use the terminals of friendly remote grids.
*   If you are standing within 200 m of an antenna that’s part of the relay, you can use the terminals of the friendly remote grids.
*   If you can remotely use a grid’s terminal, and the grid has a built-in Remote Control, you can additionally actively transmit steering commands to it.

For long-term use it's best to [access friendly remote grids](https://spaceengineers.wiki.gg/wiki/Remote_Access_Screen "Remote Access Screen") from a seat in a base or ship, don't rely on your suit antenna's range and power reserves.

### How to locate functional blocks in your grid

Think of a situation where an important functional block, such as a Thruster, Turret, or Gyroscope, shows up as damaged in your [Control Panel Screen](https://spaceengineers.wiki.gg/wiki/Control_Panel_Screen "Control Panel Screen"). You want to urgently weld it back up, but you cannot find it! Or, you are lost in the base and want to find the exit. Or, you want to [group](https://spaceengineers.wiki.gg/wiki/Groups "Groups") your wheels, but you can't remember, was "Wheel Suspension 15" the left-front wheel or the right-rear wheel -- how do you find out...?

An antenna set to **broadcast** can help: Each functional block on a grid has a **Show on HUD** setting. If you enable that checkbox for the lost block in the grid’s [Control Panel Screen](https://spaceengineers.wiki.gg/wiki/Control_Panel_Screen "Control Panel Screen"), the block’s position and name will be marked on your HUD. This feature works only if there is an antenna on the same grid to relay the information.

### How to broadcast detected ores

If a grid has an [Ore Detector](https://spaceengineers.wiki.gg/wiki/Ore_Detector "Ore Detector") and an Antenna that is set to **broadcast**, and faction members or faction grids with antennas are within its broadcast range, then they will passively see the detected ores marked on their [HUDs](https://spaceengineers.wiki.gg/wiki/HUD "HUD") as well. Note that the _detector's range_ stays the same, just the _signal visibility range_ is temporarily increased.

Faction members travelling in a mining rover kilometres away can use this feature to alert their allies back at the base to the presence of a found ore.

### How to relay proximity voice chat

The built-in [proximity voice chat](https://spaceengineers.wiki.gg/wiki/Chat "Chat") has a range of 200m (which corresponds to the suit antenna range). When Engineers are within range of shared or owned antennas that are set to broadcast at a larger range, the voice chat is also broadcast the same distance.

## Control Panel Settings

The Antenna has the following controls in the [Control Panel Screen](https://spaceengineers.wiki.gg/wiki/Control_Panel_Screen "Control Panel Screen"):

*   On/Off - Switching the block on allows you to use its send and receive features at the cost of power and radar visibility; switching it off makes you lose remote access, hides you on the radar, and saves power.
*   Name - If you leave the default name, the antenna remains easily findable when searching the control panel for "antenna".
*   HUD text - By default this field is empty and the HUD [signal](https://spaceengineers.wiki.gg/wiki/Signal "Signal") shows neutrally as "FCTN.Antenna". Optionally, enter a message that you want to broadcast together with your faction prefix, for example "FCTN.come at me bro" or "FCTN.free railgun sabots here".
*   Broadcast Radius - Set the range between 0-50000 metres. A longer range uses more power and makes you more easily visible to other players.
*   Show ship name - When switched off, the [signal](https://spaceengineers.wiki.gg/wiki/Signal "Signal") shows merely "FCTN.Antenna" (or the HUD Text, if provided). If switched on, the signal will show the grid name defined on the [Info Screen](https://spaceengineers.wiki.gg/wiki/Info_Screen "Info Screen"), e.g. "FCTN.Super Secret Spy Satellite". In a PvE setting, it can be valuable to inform co-op players which ship this is, whereas in a PvP setting, you may want to hide such details.
*   Broadcast On/Off - Enables or disable the relay functionality.

## Power

Consumption in kilowatts is the range (in meters) divided by 250.

Both sizes have a max range of 50km, therefore their max power usage is 200 kW.

## Construction

The Antenna block exists for large and small grid. The dimensions of the large block are 1 x 2 x 6 with a mount point on the blunt end, and the dimensions of the small-grid block are 1 x 1 x 2 with 5 mount points on one end, which makes its placement a bit unwieldy.

## Recipe

| [![Icon Block Antenna.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Block_Antenna.png/21px-Icon_Block_Antenna.png?35ae0b)](https://spaceengineers.wiki.gg/wiki/Antenna "Antenna") Antenna |     |     |     |     |
| --- | --- | --- | --- | --- |
| Component | Large Ship/Station  <br>Required | Large Ship/Station  <br>Optional | Small Ship  <br>Required | Small Ship  <br>Optional |
| [![Icon Item Steel Plate.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Item_Steel_Plate.png/21px-Icon_Item_Steel_Plate.png?437e3a)](https://spaceengineers.wiki.gg/wiki/Steel_Plate "Steel Plate") [Steel Plate](https://spaceengineers.wiki.gg/wiki/Steel_Plate "Steel Plate") | 60  | 20  | 1   | —   |
| [![Icon Item Small Steel Tube.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Item_Small_Steel_Tube.png/21px-Icon_Item_Small_Steel_Tube.png?4fe418)](https://spaceengineers.wiki.gg/wiki/Small_Steel_Tube "Small Steel Tube") [Small Steel Tube](https://spaceengineers.wiki.gg/wiki/Small_Steel_Tube "Small Steel Tube") | 60  | —   | 1   | —   |
| [![Icon Item Radio-comm Comp..png](https://spaceengineers.wiki.gg/images/thumb/Icon_Item_Radio-comm_Comp..png/21px-Icon_Item_Radio-comm_Comp..png?d5a95f)](https://spaceengineers.wiki.gg/wiki/Radio-comm_Comp. "Radio-comm Comp.") [Radio-comm Comp.](https://spaceengineers.wiki.gg/wiki/Radio-comm_Comp. "Radio-comm Comp.") | 40  | —   | 4   | —   |
| [![Icon Item Large Steel Tube.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Item_Large_Steel_Tube.png/21px-Icon_Item_Large_Steel_Tube.png?31c1e4)](https://spaceengineers.wiki.gg/wiki/Large_Steel_Tube "Large Steel Tube") [Large Steel Tube](https://spaceengineers.wiki.gg/wiki/Large_Steel_Tube "Large Steel Tube") | 40  | —   | —   | —   |
| [![Icon Item Construction Comp..png](https://spaceengineers.wiki.gg/images/thumb/Icon_Item_Construction_Comp..png/21px-Icon_Item_Construction_Comp..png?cdc26f)](https://spaceengineers.wiki.gg/wiki/Construction_Comp. "Construction Comp.") [Construction Comp.](https://spaceengineers.wiki.gg/wiki/Construction_Comp. "Construction Comp.") | 30  | —   | 1   | 1   |
| [![Icon Item Computer.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Item_Computer.png/21px-Icon_Item_Computer.png?65c1a4)](https://spaceengineers.wiki.gg/wiki/Computer "Computer") [Computer](https://spaceengineers.wiki.gg/wiki/Computer "Computer") | 8   | —   | 1   | —   |