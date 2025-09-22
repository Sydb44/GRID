
Sometimes you wonder, is this ore deposit mined already, was it a surface depot or especially deep? What does this Trading Outpost offer again? Was this ledge the only way to get across this mountain pass?

You can make your waypoints look different and add more information.

*   **Name**: The default waypoint name is the player name and a number, so always edit the name to something meaningful. The name must not contain the ":" character.
*   **Description**: Optionally, leave yourself a helpful message why you need this waypoint. This text is not included when you copy and paste the entry.
*   **Color**: You can colourise a series of waypoints in gradient colours to make it easier to follow them in the right direction. Or you can colour-code different types, such as bases green, ores yellow, factions orange, etc. Either set a colour using the slider, or enter hexadecimal or HSV colour values.
*   **Show on HUD**: Whether this waypoint signal is visible to you. Disable less relevant signals to decrease visual clutter on your screen, and only show the ones that you need right now.  
    Tip: Double-click an entry in the waypoints list to toggle the visibility on/off quickly.
*   **Always Visible**: If "Show on HUD" is active, optionally enable this option for important waypoints that should remain visible as signals on your [HUD](https://spaceengineers.wiki.gg/wiki/HUD "HUD") even if they are behind you.

These settings are per player.

## How to copy and back up waypoints

Waypoints are normal text a specific format that is automatically recognised by the game.

*   **Copy to Clipboard**: Copies the selected waypoint (minus your personal settings) as text into the clipboard.  
    You can paste this copied waypoint in the chat to share it with other players.
*   **New From Clipboard**: If you have one or multiple text lines of waypoints in your clipboard in the Space Engineers GPS format, turn the list into waypoints in game. For example with `GPS:_name of my waypoint_:0.0:0.0:0.0:`" in the clipboard, pressing this button creates a new waypoint at coordinates 0/0/0 and names it "name of my waypoint".

This format does not contain the description or visibility settings. It can optionally contain the colour code after the last colon.

Copying and pasting text are ways how you make a text backup of important waypoints, or transfer waypoints to another save (which works if the planets are in the same location there).

Press [TAB key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings") to hide or show the whole [HUD](https://spaceengineers.wiki.gg/wiki/HUD "HUD"), including the waypoint signals.

Press [H key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings") to cycle through seeing detailed signals, short signals, or no signals on your HUD.

Press [ENTER key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings") to open the [chat](https://spaceengineers.wiki.gg/wiki/Chat "Chat") console, and enter `/gps` to create a new waypoint quickly:

*   `/gps`  
    Creates a new waypoint from your current position. Will only be visible to yourself.
*   `/gps _<name>_`  
    Creates a new waypoint from your current position and names it. Will only be visible to yourself. Name can include spaces but no colons.
*   `/gps faction`  
    Creates a new waypoint from your current position and shares it with other players in your faction.
*   `/gps share`  
    Creates a new waypoint from your current position and shares it with everyone globally.

## Tips

Waypoint coordinates are sorted by name. There is no sorting by distance, so you have to use custom naming patterns to filter the list: For example, use planet names as prefixes to roughly sort coordinates by distance on a large scale. This way, when you search for a certain ore on a certain planet, you won't have to go through the ore markers from other planets, and you can focus on waypoints in local distance.

Don't share the coordinates of your base(s) on public multiplayer servers, it attracts griefers.

The colon is used as data separator so don't use colons in the GPS name. This includes not using smilies like :-).

To be able to categorise GPS markers, consider the [GPS Folders](https://github.com/StarCpt/SE-GpsFolders) [plugin](https://spaceengineers.wiki.gg/wiki/Plugins "Plugins").