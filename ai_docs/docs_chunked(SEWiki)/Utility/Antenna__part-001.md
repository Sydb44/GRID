---
title: "Antenna"
url: "https://spaceengineers.wiki.gg/wiki/Antenna"
category: "Utility"
wiki_page: "Antenna"
includes_blocks: true
---

# Antenna - Official Space Engineers Wiki

| Antenna |     |
| --- | --- |
| [![Icon Block Antenna.png](https://spaceengineers.wiki.gg/images/Icon_Block_Antenna.png?35ae0b)](https://spaceengineers.wiki.gg/wiki/File:Icon_Block_Antenna.png) |     |
| * * * |     |
| **Function:** | Antennas can be used to broadcast positions, messages HUD markers a... |
| **DLC?** | Vanilla |
| * * * |     |
| **Fits small grid** |     |
| Mass: | 72.2 kg |
| Hitpoints: | 236 |
| Power: | \-0.2 MW |
| PCU: | 100 |
| Size: | 1x1x2 |
| Time to Build: | 16 sec |
| * * * |     |
| **Fits large grid** |     |
| Mass: | 3401.6 kg |
| Hitpoints: | 12808 |
| Power: | \-0.2 MW |
| PCU: | 100 |
| Size: | 1x6x2 |
| Time to Build: | 40 sec |
| * * * |     |
| _Data Controls:_ | \[[purge](https://spaceengineers.wiki.gg/wiki/Antenna?action=purge)\] ([?](https://spaceengineers.wiki.gg/wiki/Template:Info_Block))) |
|     |     |

The  [![Icon Block Antenna.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Block_Antenna.png/21px-Icon_Block_Antenna.png?35ae0b)](https://spaceengineers.wiki.gg/wiki/Antenna "Antenna") Antenna is a block that enables a grid to send and receive information from and to other ships with antennas. Communicated information includes HUD [signals](https://spaceengineers.wiki.gg/wiki/Signal "Signal"), [remote terminal access](https://spaceengineers.wiki.gg/wiki/Remote_Access_Screen "Remote Access Screen"), and access to [Remote Control](https://spaceengineers.wiki.gg/wiki/Remote_Control "Remote Control") blocks. Antennas have a range of up to 50km at maximum power.

The [Space Engineer](https://spaceengineers.wiki.gg/wiki/Space_Engineer "Space Engineer")’s suit also has a built-in antenna with a limited range of 200m. For other related blocks with similar functionality, see [Laser Antenna](https://spaceengineers.wiki.gg/wiki/Laser_Antenna "Laser Antenna"), [Beacon](https://spaceengineers.wiki.gg/wiki/Beacon "Beacon"), [Compact Antenna](https://spaceengineers.wiki.gg/wiki/Compact_Antenna "Compact Antenna"), [Parabolic Antenna](https://spaceengineers.wiki.gg/wiki/Parabolic_Antenna "Parabolic Antenna"), and [Antenna Dish](https://spaceengineers.wiki.gg/wiki/Antenna_Dish "Antenna Dish").

![](https://i.ytimg.com/vi/GuK9X0FcgtU/hqdefault.jpg)

Load video

## Usage

### Is the signal visible to other factions?

Access to antenna-relayed functions such as [Remote Access](https://spaceengineers.wiki.gg/wiki/Remote_Access_Screen "Remote Access Screen") is limited by antenna range, [ownership](https://spaceengineers.wiki.gg/wiki/Ownership "Ownership"), and [faction](https://spaceengineers.wiki.gg/wiki/Faction "Faction") sharing.

A _broadcasting_ antenna, however, transmits its own position [signal](https://spaceengineers.wiki.gg/wiki/Signal "Signal") to everyone in range, regardless of faction. Especially on PvP servers, turn down the range before switching on **Broadcasting**.

*   Enemy factions' antenna signals appear in Red.
*   Those in the same faction will see their own faction's antenna signals in Green.
*   If the antenna belongs to a neutral faction, the signal will appear as White.

### What the difference between sending and receiving?

The antenna that actively broadcasts needs to have a large range. An antenna that only passively receives a signal can be set to a very short range. This conserves the second grid's power and allows for some very stealthy drone builds.

If you however want the drone to actively respond or send anything back, it also needs a large range.

A [Laser Antenna](https://spaceengineers.wiki.gg/wiki/Laser_Antenna "Laser Antenna") is also stealthy, but would use too much power for long-term use on a drone.

### How to relay remote control

Broadcasting antennas relay communication they receive to friendly antennas (including friendly players) within their range. Relayable information includes not only passive HUD [signals](https://spaceengineers.wiki.gg/wiki/Signal "Signal"), but also active [remote terminal access](https://spaceengineers.wiki.gg/wiki/Remote_Access_Screen "Remote Access Screen"), [Action Relay](https://spaceengineers.wiki.gg/wiki/Action_Relay "Action Relay") signals, original voice chat, and [remote control](https://spaceengineers.wiki.gg/wiki/Remote_Control "Remote Control").

Enable Broadcasting in the antenna’s [Control Panel Screen](https://spaceengineers.wiki.gg/wiki/Control_Panel_Screen "Control Panel Screen"). Several broadcasting antennas of the same faction whose ranges overlap form a relay and extend the range.

Note: An antenna that is part of a relay does _not_ transitively reveal all its allied antennas' positions to all other players: Enemies and neutrals still only see the one antenna in whose range they are.

For the following examples, we assume that:

*   The player's suit antenna has a range of 200 metres.
*   There are friendly antennas with overlapping ranges, set to broadcast (relay).
*   Within these antennas’ ranges, there are friendly remote grids equipped with antennas, not set to broadcast. Some of them additionally have Remote Control blocks.

In such a situation, expect the following:

*   Further than 200m away, the players can passively see the stronger antennas and receive from them, but cannot actively connect to them.
*   If you are seated in range of the antenna relay, you can use the terminals of friendly remote grids.
*   If you are standing within 200 m of an antenna that’s part of the relay, you can use the terminals of the friendly remote grids.
*   If you can remotely use a grid’s terminal, and the grid has a built-in Remote Control, you can additionally actively transmit steering commands to it.

For long-term use it's best to [access friendly remote grids](https://spaceengineers.wiki.gg/wiki/Remote_Access_Screen "Remote Access Screen") from a seat in a base or ship, don't rely on your suit antenna's range and power reserves.
