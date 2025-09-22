An admin can **configure filters** which players, factions, grids, and floating objects are allowed into the safe zone (whitelist), or are blocked from entering (blacklist).

Tip: In the filter settings, click **Add Contained** to quickly add all players/grids/etc that are currently present in the zone to either a black- or whitelist. Be careful, adding containd players/grid to a blacklist will eject them quite forcefully.

How to manage your existing Safe Zones:

*   Select a Safe Zone and click the "Move To Safe Zone" button to teleport yourself into its center.
*   Select a Safe Zone and click "Change Position" to move the center of the selected Safe Zone to where you are standing right now.
*   Select a Safe Zone to rename it, or to remove it.

Remember to enable the zone to make it work, or disable it if no longer needed.

Note: If players have created their own safe zones (using [safe zone](https://spaceengineers.wiki.gg/wiki/Safe_Zone "Safe Zone") blocks), these do not appear in the list here and are not meant to be controlled from here.

## Global Permissions

Choose what you want to allow players to do in this game in general. The following is allowed by default in Survival games:

*   Damage, shooting,
*   drilling, welding, grinding,
*   building, building projections, voxel hands,
*   landing gear lock, conversion to station.

For example, for a race track you could deactivate "damage" if too many cars get disqualified due to lag-related crashes.

## Replay Tool

A cinematographic tool that's typically used in Creative Mode. See [Replay Tool](https://spaceengineers.wiki.gg/wiki/Replay_Tool "Replay Tool").

## Weather

See [Weather](https://spaceengineers.wiki.gg/wiki/Weather "Weather") for general info how it appears in game. Weather must be enabled in the [world settings](https://spaceengineers.wiki.gg/wiki/World_Settings "World Settings") for this world for the following Admin commands to work:

*   **Force Random Weather**
*   **Create Lightning**
*   **Modify weather:**
    1.  Select a weather type: Alien fog, Alien rain, Alien thunderstorm, Dust, Electric Storm, Fog, Mars Snow, Mars Storm, Rain, SandStorm, Snow, Thunderstorm. — With exception of Dust, Mars Snow, and Electric Storm, they all exist in heavy and light variants.
    2.  Then choose an action: Either **Create weather**, **Replace current weather with selected weather**, or **Remove this weather**.

This window also shows you the current weather at the location, and its intensity and temperature.

The last line is the weather forecast and it shows incoming weather.

## Spectator Tool

An administrative or cinematographic tool. See [Spectator Tool](https://spaceengineers.wiki.gg/wiki/Spectator_Tool "Spectator Tool"). Admins can use it to "leave their bodies" and move freely through the world, even through voxels and grids.

## Economy

If Economy is enabled in the [world settings](https://spaceengineers.wiki.gg/wiki/World_Settings "World Settings"), an admin can control how many [space credits](https://spaceengineers.wiki.gg/wiki/Space_credits "Space credits") each player owns and what their reputation among NPC traders is.

*   To change the account balance how much "money" another player possesses, an admin can select a player name; you will see their current balance. Enter an amount of space credits to add, and click "Change". A positive number will be added and a negative number will be subtracted. You can preview what the final balance will be as well.

*   To change a player's reputation, first select a player name, then a [faction](https://spaceengineers.wiki.gg/wiki/Factions "Factions"). You will see the current standing that this player has with that faction. Enter an amount of reputation to add, and click "Change". A positive number will be added and a negative number will be subtracted. You can check what the final reputation will be. The worst is -1500 and the best is 1500.

*   You can choose to propagate the reputation to friends and enemies of the faction. Warning: Propagation of positive and negative reputation is not symmetric. Propagating +1000 and then -1000 won't have a zero sum for friends and foes of the faction, so don't expect cascading changes to be undone easily.

## Match

This menu can be used to track rounds in timed races. The display is in Hours:Minutes:Seconds and it counts down. Every time the admin changes the state (pushes a button) a chat message informs other players, e.g. whether the match was (re)started.

TODO: Usage example

*   Start -- This button starts or restarts a match's timer.
*   Pause/Unpause -- Pauses the timer, and when you click this button again, the counting continues.
*   Advance -- Advanced to the next stage. (?)
*   Set -- Enter a positive number in minutes into the input field, and click **Set** to set the maximum time of the match.
*   Add -- Enter a postive or negative number in minutes into the input, field and click **Add** to add or subtract time from the maximum time of the match.

Stages:

*   The inital state is PreMatch.
*   The intermediate stages are Running or Not Running (paused).
*   The final state ist Finished.

## Cheaters

This menu only exists on servers. It's supposed to list players who run malicious scripts but it also flags false positives. Mouse over the player name to see more details about the suspicious event. If the player has really done something that is disallowed, you can select them and then kick or ban them from here.

## References

1.  [↑](#cite_ref-1 "Jump up") [Space Engineers Update 01.107 video](https://youtu.be/b7_j80uIyIo)