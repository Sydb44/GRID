---
title: "Autopilot"
url: "https://spaceengineers.wiki.gg/wiki/Autopilot"
category: "General"
wiki_page: "Autopilot"
includes_blocks: true
---

# Autopilot - Official Space Engineers Wiki

Both the [Remote Control](https://spaceengineers.wiki.gg/wiki/Remote_Control "Remote Control") (short: RC) block and the [Automaton](https://spaceengineers.wiki.gg/wiki/Automaton "Automaton") blocks (short: AI) support an optional autopilot function. The Autopilot is used to make shuttles, trams, or patrolling defense drones travel on a predetermined track and perform automatic actions at waypoints.

A “drone”, “tram”, or “autonomous shuttle” in this article’s sense is a cockpit-less ship with a [Remote Control](https://spaceengineers.wiki.gg/wiki/Remote_Control "Remote Control") or [Automaton](https://spaceengineers.wiki.gg/wiki/Automaton "Automaton") block, [gyroscopes](https://spaceengineers.wiki.gg/wiki/Gyroscope "Gyroscope"), and thrusters, plus any specialised functionality of your choice — such as connectors, passenger cabin, turrets with AI targeting enabled, spotlights, cargo containers, etc.

For the Autopilot, antenna and cockpit are allowed but not required. You just need some port to access the [Control Panel Screen](https://spaceengineers.wiki.gg/wiki/Control_Panel_Screen "Control Panel Screen") to set everything up.

![](https://i.ytimg.com/vi/LHQC6JrJb2E/hqdefault.jpg)

Load video

![](https://i.ytimg.com/vi/EoXHqKlQPdE/hqdefault.jpg)

Load video

## Usage

In the [Control Panel Screen](https://spaceengineers.wiki.gg/wiki/Control_Panel_Screen "Control Panel Screen"), the following settings apply to the Autopilot. They are explained in this article.

*   Collision Avoidance
*   Precision Mode
*   Flight Mode
*   Forward Direction
*   Speed Limit
*   Waypoints
*   Set up Actions
*   GPS Locations, Add, Remove

## How to create waypoints

To configure the shuttle’s autopilot behaviour, you need to give it waypoints:

1.  Prepare a list of waypoints on your [GPS](https://spaceengineers.wiki.gg/wiki/GPS "GPS") screen.
2.  Open the AI Basic/Remote Control block’s [Control Panel Screen](https://spaceengineers.wiki.gg/wiki/Control_Panel_Screen "Control Panel Screen").
3.  Create a list of **Waypoints** for the Autopilot to follow in order:
    *   To add a location, select a coordinate from the "GPS Locations" list and click **Add**. It is added to the Waypoints.
    *   To make corrections, select a misplaced coordinate from the Waypoints list and click **Remove**.

The Autopilot will interpret the list as a queue, starting from the top and working its way to the bottom, travelling from one to the next.

The Autopilot can control thrusters and gyroscopes to reach the listed waypoints. The Autopilot cannot steer wheels though — the "Control Wheels" option that you see in the Remote Control Panel refers to the player-steered Remote Control, not to the Autopilot function. See also [How to use autopilot with wheeled vehicles](https://spaceengineers.wiki.gg/wiki/How_to_use_autopilot_with_wheeled_vehicles "How to use autopilot with wheeled vehicles").

## How to send a drone out on patrol using Flight modes

The autopilot operates in one of three flight modes:

*   **Patrol** - If the first and last waypoint lie far apart, you may want to choose Patrolling. The autopilot visits each waypoint, and then turns around and visits them in backwards order, and so on.  
    Example: ABC CBA ABC CBA…
*   **Circle** - If the first and last waypoint are close to each other, you may want to choose circling. The autopilot visits each waypoint, and then starts over from the beginning, and so on.  
    Example: ABC ABC ABC ABC…
*   **One Way** - The autopilot visits each waypoint, stops at the last waypoint, then toggles itself off.[\[1\]](#cite_note-1) This option is useful to send a ship somewhere, once, either on a kamikaze mission, or to automatically move one damaged ship to safety while the player pilot changes to another ship.  
    Example: ABC.

## How Precision Mode affects speed and safety

Toggle on **Precision Mode** for more accurate but slower shuttle navigation. In precision mode, the autopiloted shuttle aims to stop exactly on each GPS waypoint before it rotates towards the next waypoints, using the Remote Control/AI Basic block as the center point of the vessel.

*   The advantage of precision mode is that the shuttle can follow a path through a narrow base or tight mining tunnel, and it aligns itself perfectly with waypoints recorded for Connectors.
*   The downside is that the shuttle will brake often and accelerate again, meaning the shuttle will waste power/fuel, and travel only very slowly even in open space.

When Precision Mode is off, the shuttle travels faster but sloppier. The autopilot aims for a general area of about 50 meters around the waypoint. Once the way point is deemed close enough, the autopilot will immediately turn and continue on to the next GPS waypoint, without braking.

*   The advantage is that the Autopilot will use the fastest means to reach each waypoint.
*   The downside is that it will overshoot waypoints, miss connectors, and bash into narrow hallway walls, because of its higher speed.

This faster mode works well for patrolling open space, but is not recommended for shuttle navigation inside bases or near obstacles.

The good news is that you can have both, you can toggle modes while flying, as needed for the situation.

The GPS coordinates of the waypoints are aligned with the position of the AI/RC block, not the center or any seat. Especially when you want to position a ship at a connector, park the drone on its docking connector before [creating the GPS waypoint](https://spaceengineers.wiki.gg/wiki/GPS "GPS") to get the exact spot.  
When the pilot [creates the GPS waypoint](https://spaceengineers.wiki.gg/wiki/GPS "GPS") while remotely piloting a grid, the waypoint is centered on the grid’s AI/RC block automatically. This makes it easier to create correct waypoints remotely — you don't need to fly there in person. Don't create waypoints in [Spectator Mode](https://spaceengineers.wiki.gg/wiki/Spectator_Mode "Spectator Mode"), the GPS will record the location _of the player character_ instead of the location of the Spectator, which is not useful!
