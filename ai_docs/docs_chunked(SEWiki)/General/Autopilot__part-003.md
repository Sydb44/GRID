To prevent it from wasting time and energy with course corrections, use the **Speed Limit** slider to slow the drone down to a lower percentage of its maximum acceleration.

## How to perform automatic actions at waypoints

At each waypoint, the autopilot can optionally trigger any ship functions from the [G Menu](https://spaceengineers.wiki.gg/wiki/Toolbar_Configuration "Toolbar Configuration"), which makes your drones quite flexible and powerful.

For example at arrival, the drone can automatically [play sounds](https://spaceengineers.wiki.gg/wiki/Sound_Block "Sound Block"), toggle lights on/off, de-/repressurise a passenger cabin, lock/unlock landing gears, lock/unlock connectors (to recharge batteries and restock ammo), discharge/recharge connected batteries, close/open its doors, and so on.

To have more control and activate multiple events, put each set of actions into a [Timer Block](https://spaceengineers.wiki.gg/wiki/Timer_Block "Timer Block"), and make the Waypoint action start the Timer Block.

## How to perform automatic re-actions anywhere

A drone can react to sudden changes in its own grid (e.g. damage) or to objects in sensor range. To make the drone react to dynamic events other than reaching a waypoint, build an [Event Controller](https://spaceengineers.wiki.gg/wiki/Event_Controller "Event Controller") block or [Sensor](https://spaceengineers.wiki.gg/wiki/Sensor "Sensor") and set it up to detect situations and trigger actions.

## Can the Autopilot steer rovers?

Be warned that for wheeled vehicles, waypoint detection is unreliable, because, in contrast to spacecraft, a rover in gravity cannot freely move in 6 directions to align with the target coordinates. If the suspension is higher or lower (simply because the cargo is full or empty), the autopilot struggles to "reach" the waypoint.

On top of that, **collision avoidance** and **precision mode** are not available for wheeled vehicles at all.

The vanilla workaround to combine slidy wheels with a propulsion override is only viable on flat terrain, the autopilot cannot handle driving uphill with low friction wheels.

If you want to learn more advanced non-vanilla methods, see [How to use autopilot with wheeled vehicles](https://spaceengineers.wiki.gg/wiki/How_to_use_autopilot_with_wheeled_vehicles "How to use autopilot with wheeled vehicles").

## Steam Workshop Scripts

For autopiloted space flight, see [Rdav‘s Fleet Command](https://steamcommunity.com/sharedfiles/filedetails/?id=1162841676) script; and for reliable autopiloted land vehicles, see [Wanderer\_308’s Driver Assisting System](https://steamcommunity.com/sharedfiles/filedetails/?id=1089115113) on the Steam Workshop.

## References

1.  [↑](#cite_ref-1 "Jump up") [https://support.keenswh.com/spaceengineers/pc/topic/28156-1-202-remote-control-block-loses-autopilot-waypoints-after-flying-them-repro-save-included](https://support.keenswh.com/spaceengineers/pc/topic/28156-1-202-remote-control-block-loses-autopilot-waypoints-after-flying-them-repro-save-included)