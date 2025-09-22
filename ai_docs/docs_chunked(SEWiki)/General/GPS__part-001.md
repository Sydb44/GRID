---
title: "GPS"
url: "https://spaceengineers.wiki.gg/wiki/GPS"
category: "General"
wiki_page: "GPS"
includes_environment: true
includes_blocks: true
---

# GPS - Official Space Engineers Wiki

[![](https://spaceengineers.wiki.gg/images/Own-HUD-Signals.jpg?3ab762)](https://spaceengineers.wiki.gg/wiki/File:Own-HUD-Signals.jpg)

Custom GPS markers on your HUD

As a pilot it's easy to get lost in the featureless black of space. The [HUD](https://spaceengineers.wiki.gg/wiki/HUD "HUD") in your helmet can beam location [signals](https://spaceengineers.wiki.gg/wiki/Signal "Signal") into your eyes to help you get orientated.

The **GPS** tab in the [Terminal](https://spaceengineers.wiki.gg/wiki/Terminal "Terminal") is where you manage these waypoints. Each waypoint is defined by X, Y, and Z coordinates in 3D space.

## What do the numbers mean?

[![](https://spaceengineers.wiki.gg/images/thumb/Coordinate-system.jpg/320px-Coordinate-system.jpg?5eb08f)](https://spaceengineers.wiki.gg/wiki/File:Coordinate-system.jpg)

The onlooker in the centre wants to fly to location P. X shows how far to look forwards, Y how far to look left, and Z how far to look up, in order to look at target location P.

The three numbers of a waypoint are X/Y/Z coordinates that describe a location in 3-dimensional space. If you know how far to fly forwards, to the side, and up, then you can pinpoint any location and its distance in space.

Coordinates can be written as negative and positive numbers, depending on in which [octant](https://en.wikipedia.org/wiki/Octant_\(solid_geometry\)) (direction relative to the center) they are. Basically, a negative number means "backwards" instead forwards, or "down" instead of up, etc.

A target waypoint alone does not describe the _path_ how to get somewhere, you still have to find your way around obstacles yourself. Leave yourself several waypoints in between to mark the best path.

For example coordinates see [GPS Locations of Planet/Moon Centers and Poles](https://steamcommunity.com/sharedfiles/filedetails/?id=2728454942) by Spaceman Spiff.

## Coordinate System

In Space Engineers, when looking at the solar system perpendicularly to the X axis, with -X being left and +X being right, the coordinate system has the Y axis going top to bottom (that is, with -Y being North and +Y being South), and the Z axis going from the observer to forward (that is, -Z being back and +Z being forward).

Here is a diagram showing the solar system: [![Se solar system iso.svg](https://spaceengineers.wiki.gg/images/Se_solar_system_iso.svg?c70c3a)](https://spaceengineers.wiki.gg/wiki/File:Se_solar_system_iso.svg)

_Tip: You can click on this image to show the meta info, and then click again to view the raw image, and zoom in to view more details, as this is a scalable vector graphic image._

The sun is going clockwise along the Y axis, infinitely far away in the skybox. You can also see that many planets/moons lies on very similar Y coordinates, giving rise to regular solar eclipses on many solar bodies

Note: The sun azimuth/elevation depicted here is the one you get when starting a Solar System survival game. That azimuth/elevation can be different per save game, and is stored in the SANDBOX\_0\_0\_0.sbs save file.

## How to create or delete waypoints

The **GPS** tab in the [Terminal](https://spaceengineers.wiki.gg/wiki/Terminal "Terminal") has the following buttons:

*   **New From Current Position** -- Creates a waypoint and fills in the player's current X/Y/Z coordinates automatically.
*   **New** -- Creates an empty waypoint and lets you type in the X/Y/Z coordinates manually.
*   **Delete** -- Delete the selected waypoint
*   **Search** -- Enter text to filter the list of waypoints.

You can create new waypoints right after someone else pastes coordinates in the chat, or right after you click the "Create GPS Marker" button in a [Data Pad](https://spaceengineers.wiki.gg/wiki/Data_Pads "Data Pads"): These shared coordinates first appear in your waypoint list in gray for a short while. Double-click them to store them permanently and make them visible in your HUD. Otherwise they are not saved.

### Can RC drones create waypoints?

When you create a GPS waypoint using the /gps command while remotely piloting a grid, the waypoint is centered on the _drone's_ [AI](https://spaceengineers.wiki.gg/wiki/Automaton "Automaton") or [RC](https://spaceengineers.wiki.gg/wiki/Remote_Control "Remote Control") block.

For an [autopiloted](https://spaceengineers.wiki.gg/wiki/Autopilot "Autopilot") drone to be able to create new waypoints, it needs a [Broadcast Controller](https://spaceengineers.wiki.gg/wiki/Broadcast_Controller "Broadcast Controller"). This block has a triggerable action to send its own GPS position on a chat channel.

The recipients have to manually save the coordinates on their GPS screen — this step cannot be automated.

### Can the Spectator create waypoints?

Not really. If you create a GPS waypoints while in [Spectator Mode](https://spaceengineers.wiki.gg/wiki/Spectator_Mode "Spectator Mode"), the GPS screen records the location _of the player character_ and not the location of the Spectator camera!

## How to distinguish waypoints

Sometimes you wonder, is this ore deposit mined already, was it a surface depot or especially deep? What does this Trading Outpost offer again? Was this ledge the only way to get across this mountain pass?

You can make your waypoints look different and add more information.

*   **Name**: The default waypoint name is the player name and a number, so always edit the name to something meaningful. The name must not contain the ":" character.
*   **Description**: Optionally, leave yourself a helpful message why you need this waypoint. This text is not included when you copy and paste the entry.
*   **Color**: You can colourise a series of waypoints in gradient colours to make it easier to follow them in the right direction. Or you can colour-code different types, such as bases green, ores yellow, factions orange, etc. Either set a colour using the slider, or enter hexadecimal or HSV colour values.
*   **Show on HUD**: Whether this waypoint signal is visible to you. Disable less relevant signals to decrease visual clutter on your screen, and only show the ones that you need right now.  
    Tip: Double-click an entry in the waypoints list to toggle the visibility on/off quickly.
*   **Always Visible**: If "Show on HUD" is active, optionally enable this option for important waypoints that should remain visible as signals on your [HUD](https://spaceengineers.wiki.gg/wiki/HUD "HUD") even if they are behind you.

These settings are per player.
