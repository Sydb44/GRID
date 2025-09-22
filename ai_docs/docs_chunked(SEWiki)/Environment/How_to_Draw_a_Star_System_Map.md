---
title: "How to Draw a Star System Map"
url: "https://spaceengineers.wiki.gg/wiki/How_to_Draw_a_Star_System_Map"
category: "Environment"
wiki_page: "How to Draw a Star System Map"
includes_environment: true
includes_blocks: true
---

# How to Draw a Star System Map

You would like to consult a 3D map of your [star system](https://spaceengineers.wiki.gg/wiki/Star_System "Star System") so you can plan flight paths. But the game does not depict the positions of planetary bodies, even though they are known and static. This is how you create your own 3D map.

## Collect the coordinates

Collect the [GPS](https://spaceengineers.wiki.gg/wiki/GPS "GPS") values of the planetary bodies in a text file.

*   Either fly to each planet and moon and make a GPS waypoint there. Then use the "Copy to clipboard" function on the GPS screen. Admittedly, a surface GPS is not in the center of the planet, but in a scaled-down overview of the star system, you won't see the difference.
*   Or use the [GPS Locations of Planet/Moon Centers and Poles](https://steamcommunity.com/sharedfiles/filedetails/?id=2728454942) guide by Spaceman Spiff.
*   Or to get precise custom values, open your save file in a tool such as [Remaarn's SEToolbox](https://github.com/mmusu3/SEToolbox/releases/) and copy the coordinates of planets.

Note that the sun is never mentioned. It does not exist as an object in game, it's part of the skybox.

Tip: In your custom map, you can of course also include the waypoints of space stations or asteroid bases.

## Reformat the list

After copying waypoints from the GPS screen, Your list looks probably similar to this example:

*   GPS:Moon:1.0:2.0:3.0:
*   GPS:Planet:2.0:3.0:1.0:

You need this raw data in a certain format.

1.  Remove the front "GPS:" part.
2.  Remove the last colon ":".
3.  Replace the colon after the planet name with an equal sign "=".
4.  Verify that your list now looks similar to this:
    *   Moon=1.0:2.0:3.0
    *   Planet=2.0:3.0:1.0

1.  Replace the coordinate separators by commas.
2.  Wrap the coordinates in round parentheses.
3.  Verify that your final list now looks similar to this:
    *   Moon=(1.0,2.0,3.0)
    *   Planet=(2.0,3.0,1.0)
4.  Save the text file.

## Use a graphing calculator

[![](https://spaceengineers.wiki.gg/images/thumb/5/5d/GeoGebra.jpg/320px-GeoGebra.jpg?d57ea4)](https://spaceengineers.wiki.gg/wiki/File:GeoGebra.jpg)

a green planet and a gray moon in 3D space

1.  Go to [https://www.geogebra.org](https://www.geogebra.org/) and start the calculator.
2.  Select 3D Grapher.  
    It shows an empty coordinate system.
3.  Add a new line for each GPS.  
    In our example, we add these entries:
    *   Moon=(1.0,2.0,3.0)
    *   Planet=(2.0,3.0,1.0)
4.  The tool now displays a point for each entry.
5.  If needed, zoom out to see all the points.
6.  Click the three dots next to each entry and select Settings.
    *   Set Color: (Choose a color of your liking)
    *   Set Caption Style:Name
7.  Click the Gear and hide the coordinate plane etc., basically, make the screen look as you want it.
8.  Rotate the image so you see all planets well.
9.  Export it as an image or take a screenshot.
10.  Click Save/Share to save it as a file.

## Troubleshooting

In GeoGebra, it's important to start the point name with a capital letter to make it appear as a point! If you name it with small caps, the input turns into a vector arrow, so don't be surprised.

*   [How to build a 3D holographic map](https://spaceengineers.wiki.gg/wiki/How_to_build_a_3D_holographic_map "How to build a 3D holographic map")
*   [How to Spawn Planets and Moons Manually](https://spaceengineers.wiki.gg/wiki/How_to_Spawn_Planets_and_Moons_Manually "How to Spawn Planets and Moons Manually")
*   [How to move planets](https://spaceengineers.wiki.gg/wiki/How_to_move_planets "How to move planets")

## Alternative solution

SE-MAP: Universal Space Engineers Mapping Tool ([https://youtu.be/1Dc1jhDcPYU](https://youtu.be/1Dc1jhDcPYU))

This 15-minute tutorial video introduces SE-MAP, an innovative browser-based 3D mapping tool designed for Space Engineers players. Created by Volker Nemrod, the application provides interactive visualization of planetary systems with full 3D navigation, route planning capabilities, and hazard detection features.

The tool comes pre-configured with the Kepler-444 system but can be easily customized for any planetary setup through CSV file editing. Key features demonstrated include:

*   3D interactive navigation with zoom, rotation, and object selection
*   Route plotting between planets, moons, and custom coordinates with travel time calculations
*   Obstacle detection including gravity fields and danger zones
*   Mobile compatibility for on-the-go access
*   Customizable planet database with detailed descriptions and resource information

The video walks viewers through practical examples of plotting courses, avoiding gravitational hazards, and adapting the system for custom Space Engineers worlds. Particularly valuable for server administrators and players using Nexus-based multi-system setups, SE-MAP bridges the gap for comprehensive space navigation that the base game currently lacks.

A practical demonstration shows both desktop and mobile versions, making it accessible across devices for real-time mission planning and space exploration coordination.