---
title: "Safe Zone"
url: "https://spaceengineers.wiki.gg/wiki/Safe_Zone"
category: "General"
wiki_page: "Safe Zone"
includes_blocks: true
---

# Safe Zone - Official Space Engineers Wiki

| Safe Zone |     |
| --- | --- |
| [![Icon Block Safe Zone.png](https://spaceengineers.wiki.gg/images/4/41/Icon_Block_Safe_Zone.png?a32135)](https://spaceengineers.wiki.gg/wiki/File:Icon_Block_Safe_Zone.png) |     |
| * * * |     |
| **Function:** | Projects safe zone around itself. Safe zone can be used to protect ... |
| **DLC?** | Vanilla |
| * * * |     |
| **Fits large grid** |     |
| Mass: | 25945.25 kg |
| Hitpoints: | 92925 |
| PCU: | 50  |
| Size: | 2x2x3 |
| Time to Build: | 40 sec |
| * * * |     |
| _Data Controls:_ | \[[purge](https://spaceengineers.wiki.gg/wiki/Safe_Zone?action=purge)\] ([?](https://spaceengineers.wiki.gg/wiki/Template:Info_Block))) |
|     |     |

A Safe Zone is a defensive block that players use as protective force field on [multiplayer](https://spaceengineers.wiki.gg/wiki/Multiplayer "Multiplayer") PvP servers.

NPC [Trading Outposts](https://spaceengineers.wiki.gg/wiki/Trading_Outposts "Trading Outposts") are protected by Safe Zones as well. NPC Safe Zones automatically unlock docked players after a while, so nobody can hide there permanently.

Admins can also set up Admin Safe Zones to protect e.g. spawn areas on a multiplayer server. Admin Safe Zones are not covered in this article, but they are described under [Admin Screen](https://spaceengineers.wiki.gg/wiki/Admin_Screen "Admin Screen").

## Usage

On multiplayer servers, you can set up a protective force field around your [station](https://spaceengineers.wiki.gg/wiki/Station "Station") to help limit[\[1\]](#cite_note-1) offline raiding damage. In Singleplayer, you could employ Safe Zones to defend against PvE drone attacks.

The block takes two minutes to start up, so don't expect it to save your skin automatically.

### Who is allowed in and who is banned?

This is how to set it up. First, build the Safe Zone block on a station grid and power it and open the block's [control panel](https://spaceengineers.wiki.gg/wiki/Control_Panel_Screen "Control Panel Screen").

1.  Under **Enable**, click **On**.
2.  Choose the **Shape** of the force field: spherical or cubical
3.  Choose the **Range** of the force field. For spherical, enter a diameter. For cubical, enter height/width/length. Minimum dimension is 10 m and maximum is 1000m. Larger costs more power.
4.  Click **Configure Filter**:
5.  On the left side, choose a category icon: Players, factions, grids, or floating objects.
    *   For each category, choose a Mode:
        *   In Whitelist mode, you list what in this category is allowed.
        *   In Blacklist mode, you list what in this category is banned.
    *   For each category, select players/factions/grids/items, and then click the arrows in the center to add them to the list.  
        Do not add yourself to a blacklist or you'll lose physical access to the zone range.
6.  Finally, put a [Zone Chip](https://spaceengineers.wiki.gg/wiki/Zone_Chip "Zone Chip") into the Safe Zone's inventory to activate it.

**Tip:** While all members and ships of your faction are docked inside the zone, select the category "grids", select "Whitelist", then click **Add Contained**. This is a shortcut to quickly add all contained ships to the chosen list in one step.

### What are players allowed to do inside?

Next, regarding the players and grids and items that can come inside, specify what they are allowed to do. By default, all options are off and nothing is allowed.

*   Allow [damage](https://spaceengineers.wiki.gg/wiki/Damage_Mechanics "Damage Mechanics")
*   Allow [shooting](https://spaceengineers.wiki.gg/wiki/Weapon "Weapon")
*   Allow [drilling](https://spaceengineers.wiki.gg/wiki/Drill "Drill")
*   Allow [welding](https://spaceengineers.wiki.gg/wiki/Welder "Welder")
*   Allow [grinding](https://spaceengineers.wiki.gg/wiki/Grinder "Grinder")
*   Allow [building](https://spaceengineers.wiki.gg/wiki/Building "Building")
*   Allow [projections](https://spaceengineers.wiki.gg/wiki/Projector "Projector")
*   Allow [voxel hands](https://spaceengineers.wiki.gg/wiki/Voxel_Hands "Voxel Hands")
*   Allow [Landing Gear](https://spaceengineers.wiki.gg/wiki/Landing_Gear "Landing Gear")/[Magnetic Plate](https://spaceengineers.wiki.gg/wiki/Magnetic_Plate "Magnetic Plate") lock
*   Allow [conversion to station](https://spaceengineers.wiki.gg/wiki/Info_Screen "Info Screen")

**Tip:** To disallow [hacking](https://spaceengineers.wiki.gg/wiki/Hacking "Hacking"), disallow grinding+welding.

### What Are the Upkeep Costs?

The owning faction must power their Safe Zone and keep supplying its inventory with one  [![Icon Item Zone Chip.png](https://spaceengineers.wiki.gg/images/thumb/a/ae/Icon_Item_Zone_Chip.png/21px-Icon_Item_Zone_Chip.png?72a7b7)](https://spaceengineers.wiki.gg/wiki/Zone_Chip "Zone Chip") [Zone Chip](https://spaceengineers.wiki.gg/wiki/Zone_Chip "Zone Chip") per real-life hour. Zone Chips are also required as component to build the block.

The power drain of the Safe Zone is 5 to 300MW depending on its size which can be between 10 to 500 metres large.

In contrast to players in [Survival Mode](https://spaceengineers.wiki.gg/wiki/Survival_Mode "Survival Mode"), Admins and [NPCs](https://spaceengineers.wiki.gg/wiki/Trading_Outposts "Trading Outposts") do not have to pay Zone Chips for upkeep, their Safe Zones never expire.

### How to tell if the forcefield is on?

**Q:** Why is my force field transparent and colorless, marked with regular white plus-signs and dots?

**A:** This skin indicates that the force field is configured and powered, but inactive! You need to input zone chips to activate it.

### Safe Zone Best Practices

The upkeep costs are steep in Survival. If you leave the Safe Zone permanently active, you will run out of zone chips fast. The force field takes 120 secs to power up, so you cannot use it as a quick one-off defense, either. Devise ways to only switch on the safe zone in cases of emergency, for example, only run it when no defenders are at the base.

To limit attack vectors, build the Safe Zone block on its own static grid that has a separate power supply and is not connected to your outwards facing conveyor system!

In PvP multiplayer, be explicit whom and what you allow in.

*   Select the Whitelist filter and click **Add Contained** to quickly add all players, grids, and blocks that are currently present in the zone to the allowed list.
*   Maintain a proper whitelist and don’t just allow in every grid that’s shared with the faction.
*   Manually add other faction-shared grids and new members.
*   Remove lost or missing ships and members who have left.

Consider that a hostile player can easily capture ([using maglocks](https://spaceengineers.wiki.gg/wiki/Landing_Gear "Landing Gear")) a faction-shared grid (or wreck!) outside your safe zone. You do not want such lost grids to be automatically allowed into your force field and pose a Trojan Horse-like security risk.

If you offer [Connectors](https://spaceengineers.wiki.gg/wiki/Connector "Connector") for visitors, remember to configure **Trade Mode** and **Auto-Unlock** options on them. Keep them fully inside.

If you want to offer [contracts](https://spaceengineers.wiki.gg/wiki/Contracts "Contracts") in multiplayer, use a Safe Zone to help protect your trade post from hostile players.

*   Allow allied and neutral players to enter to reach the Store or Contracts blocks.
*   Don't allow non-faction members to use weapons and tools inside.
*   Don't allow grinding and welding to outsiders because that opens your safe zone up to being [hacked](https://spaceengineers.wiki.gg/wiki/Hacking "Hacking").
*   If the target of a repair contract is inside the safe zone, you must allow visitors to use a welder and build projections. (Not safe on PvP Servers.)

On multiplayers servers, players sometimes take temporary shelter in the weapon-free safe zones around [Trading Outposts](https://spaceengineers.wiki.gg/wiki/Trading_Outposts "Trading Outposts").
