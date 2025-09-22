---
title: "Multiplayer Screen"
url: "https://spaceengineers.wiki.gg/wiki/Multiplayer_Screen"
category: "Server-Config"
wiki_page: "Multiplayer Screen"
---

# Multiplayer Screen - Official Space Engineers Wiki

[![](https://spaceengineers.wiki.gg/images/thumb/Multiplayer.png/400px-Multiplayer.png?11c240)](https://spaceengineers.wiki.gg/wiki/File:Multiplayer.png)

The multiplayer screen in a dedicated server, without lobby type or player number slider (source: Xocliw showcase)

[![](https://spaceengineers.wiki.gg/images/thumb/F3_multiplayer_screen_offline.png/400px-F3_multiplayer_screen_offline.png?305899)](https://spaceengineers.wiki.gg/wiki/File:F3_multiplayer_screen_offline.png)

The multiplayer screen on localhost with only the owner logged in

The Multiplayer screen lists information about players that are online in a hosted game. To open the Multiplayer screen, press [F3 key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings").

*   As the host, you perform [multiplayer](https://spaceengineers.wiki.gg/wiki/Multiplayer "Multiplayer") related actions here, such as setting how many can join and what they are allowed to do, down to banning individual players.
*   As a player, you can see who is online from which faction, what ping and permissions rank they have, and you can initiate [trading](https://spaceengineers.wiki.gg/wiki/Player_Trading "Player Trading").

## Where am I?

Anyone logged in can use this screen to see the server name and player number. On top, the screen will show you:

*   server name  
    If you've joined a public server, remember the name so you can find it again.
*   number of players online/max  
    How many slots are occupied of the maximum number of possible players. For example, if it indicates “4/4”, then the server is full.

## How to choose who can join

The hosts decide who can join their games. As the host, use the **Lobby Type** menu to select one of the following options:

*   **Private** - Only people whom you invite can join.
*   **Friends** - Only people on your friends list can join.
*   **Public** - Anybody can join. (careful!)

## How to limit the number of allowed players

The host can use the **Max Players** slider to allow more or fewer players to join. You can set it to a value between 1 and 16, up to 64. The actual maximum value is platform dependent and is typically higher on PC, and lower or console.

Note: For a [dedicated server](https://spaceengineers.wiki.gg/wiki/Setting_up_a_Space_Engineers_Dedicated_Server "Setting up a Space Engineers Dedicated Server"), this is controlled elsewhere.

## How to invite players

When using Steam, the host can click **Invite** to get a list of online players and invite them. Then click **Return to Game**.

Note that Steam also lists online friends that don't have Space Engineers installed and who cannot actually join.

## Who is here with me

On the multiplayer screen, anyone who is logged-on can see the following information about other logged-on players.

*   Player name - the Steam name of the player
*   Faction - The player's [faction name and tag](https://spaceengineers.wiki.gg/wiki/Factions "Factions"). The tag will be prefixed on their ships' names.
*   Rank - The player's permission rank on this server.
*   Ping - How fast in milliseconds the player's connection reacts. Smaller numbers (10-60ms) means very fast connection (probably local or on the same continent), anything from 60-100 ms is playable, but higher values will mean this player is impeded by lag.
*   Muted - A speaker symbol indicating whether this player has voice [chat](https://spaceengineers.wiki.gg/wiki/Chat "Chat") enabled or not.

Click **Profile** to see your own Steam gamer profile.

## How to allocate rank permissions

To change a player's rank inside the faction, the host can select a player name and then click **Demote** (give fewer permissions) or **Promote** (give more permissions).

The rank is indicated by 1 to 5 stars, from lowest to highest:

1.  Scripter (\*)
    *   Only if the Scripter role is enabled
    *   Can edit scripts while normal players cannot
2.  Moderator (\*\*)
    *   Scripter permissions plus
    *   Can kick/ban players
    *   Has access to "Show All Players" admin setting
3.  Space Master (\*\*\*)
    *   Has Moderator permissions plus
    *   Has Access to [entity cycling and cleanup](https://spaceengineers.wiki.gg/wiki/Admin_Screen "Admin Screen")
4.  Admin (\*\*\*\*)
    *   Space Master permissions plus
    *   Has access to [admin tools](https://spaceengineers.wiki.gg/wiki/Admin_Screen "Admin Screen")
    *   Has access to [entity list](https://spaceengineers.wiki.gg/wiki/Admin_Screen "Admin Screen")
5.  Owner (\*\*\*\*\*)
    *   Has Admin permissions plus
    *   Cannot be demoted

## How to trade

To trade with other players in game, your avatar needs to stand next to another engineer’s avatar. Then press [F3 key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings") and click **Trade** to open the [Player Trading](https://spaceengineers.wiki.gg/wiki/Player_Trading "Player Trading") window.

## How to uninvite players

To uninvite a player, an admin can select a player name and then:

*   Click **Kick** to force them to log out now, but they can come back.
*   Click **Ban** to force them to log out and not let them log back on.

## How to enable online mode

If you are in a singleplayer game and press [F3 key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings"), you will get the message "_You are in offline mode and multiplayer is disabled. You have to change the settings from the main menu._"

If you want to host your game to be online and findable in the **Join** list:

1.  Go to the main screen and click **Load Game**.
2.  Select the game save.
3.  Click [Edit Settings](https://spaceengineers.wiki.gg/wiki/World_Settings "World Settings").
4.  Under **Online Mode**, switch from **Offline** to either **Private**, **Friends**, or **Public** to enable multiplayer for this game.