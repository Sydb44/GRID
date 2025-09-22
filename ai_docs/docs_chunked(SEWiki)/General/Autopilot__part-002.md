*   The downside is that the shuttle will brake often and accelerate again, meaning the shuttle will waste power/fuel, and travel only very slowly even in open space.

When Precision Mode is off, the shuttle travels faster but sloppier. The autopilot aims for a general area of about 50 meters around the waypoint. Once the way point is deemed close enough, the autopilot will immediately turn and continue on to the next GPS waypoint, without braking.

*   The advantage is that the Autopilot will use the fastest means to reach each waypoint.
*   The downside is that it will overshoot waypoints, miss connectors, and bash into narrow hallway walls, because of its higher speed.

This faster mode works well for patrolling open space, but is not recommended for shuttle navigation inside bases or near obstacles.

The good news is that you can have both, you can toggle modes while flying, as needed for the situation.

The GPS coordinates of the waypoints are aligned with the position of the AI/RC block, not the center or any seat. Especially when you want to position a ship at a connector, park the drone on its docking connector before [creating the GPS waypoint](https://spaceengineers.wiki.gg/wiki/GPS "GPS") to get the exact spot.  
When the pilot [creates the GPS waypoint](https://spaceengineers.wiki.gg/wiki/GPS "GPS") while remotely piloting a grid, the waypoint is centered on the grid’s AI/RC block automatically. This makes it easier to create correct waypoints remotely — you don't need to fly there in person. Don't create waypoints in [Spectator Mode](https://spaceengineers.wiki.gg/wiki/Spectator_Mode "Spectator Mode"), the GPS will record the location _of the player character_ instead of the location of the Spectator, which is not useful!

## How Collision Avoidance affects speed and safety

Collision Avoidance enables a basic obstacle sensor when flying long distances autonomously. The autopilot will attempt to detect obvious obstacles, like base walls, asteroids, or mountains, and brake to avoid crashing. It will not detect nor avoid players though. The Autopilot sensor scans a spherical area to ensure the drone has room to rotate, this means even if the drone is built slender, the AI considers narrow gaps a full obstacle.

Before the Automaton update, the function of Collision Avoidance merely prevented drones from _totalling_ themselves by waiting in front of the obstacle for you to provide additional waypoints (manually on the RC's Control Panel Screen). Post-Automaton update, collision avoiding drones are expected to find a path around small obstacles autonomously (although only very slowly). Don't expect it to guide a drone through a "maze".

*   If you gave the autopiloted drone very precise, safe waypoints to describe its path, for example for a shuttle inside a base, then switch Collision Avoidance off.

*   If the autopiloted grid is a [player-built missile](https://spaceengineers.wiki.gg/wiki/Player_Built_Weapons "Player Built Weapons") which is meant to collide with targets, switch Collision Avoidance off.

*   If you only know the corner points of the path, or if it's a long path, and anything (defense, attack, [other events](https://spaceengineers.wiki.gg/wiki/Event_Controller "Event Controller")) could happen in between, switch Collision Avoidance on.

*   If the drone refuses to fly with Collision Avoidance on, some obstacle is too close to the Remote Control sensor. Place the RC block somewhere where it is not obstructed by the drone's own blocks either.

The good news is that you can have both, you can toggle modes while flying, as needed for the situation.

## How to not fly sideways/upside down

First, look at the text above the  [![Icon Block Camera.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Block_Camera.png/21px-Icon_Block_Camera.png?a42a5a)](https://spaceengineers.wiki.gg/wiki/Camera "Camera") [Camera](https://spaceengineers.wiki.gg/wiki/Camera "Camera") lens from the front to verify that the camera is right way up. A camera often easier to replace and turn around.

If you have built the remote control block (RC) the wrong way round, the shuttle will fly sideways, upside down, or even backwards. This poses an obstacle for docking or if your atmo thrusters need to point towards planetary gravity.

Grinding the RC down and rebuilding it may not be a choice if it’s squeezed into a small drone ship. Then correct it in the control panel "the software way": Select the new **Forward Direction** from the menu: backwards, left, right, up, or down. Default is forward.

## What's the speed limit good for?

Depending on how your waypoints are spaced, and if Precision mode is off, the shuttle’s behaviour can look like reckless flying. A shuttle that accelerates between waypoints can overshoot the target (and possibly damage itself) and will have to correct course a lot.

To prevent it from wasting time and energy with course corrections, use the **Speed Limit** slider to slow the drone down to a lower percentage of its maximum acceleration.

## How to perform automatic actions at waypoints

At each waypoint, the autopilot can optionally trigger any ship functions from the [G Menu](https://spaceengineers.wiki.gg/wiki/Toolbar_Configuration "Toolbar Configuration"), which makes your drones quite flexible and powerful.

For example at arrival, the drone can automatically [play sounds](https://spaceengineers.wiki.gg/wiki/Sound_Block "Sound Block"), toggle lights on/off, de-/repressurise a passenger cabin, lock/unlock landing gears, lock/unlock connectors (to recharge batteries and restock ammo), discharge/recharge connected batteries, close/open its doors, and so on.

To have more control and activate multiple events, put each set of actions into a [Timer Block](https://spaceengineers.wiki.gg/wiki/Timer_Block "Timer Block"), and make the Waypoint action start the Timer Block.

## How to perform automatic re-actions anywhere

A drone can react to sudden changes in its own grid (e.g. damage) or to objects in sensor range. To make the drone react to dynamic events other than reaching a waypoint, build an [Event Controller](https://spaceengineers.wiki.gg/wiki/Event_Controller "Event Controller") block or [Sensor](https://spaceengineers.wiki.gg/wiki/Sensor "Sensor") and set it up to detect situations and trigger actions.
