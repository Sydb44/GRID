---
title: "How to use autopilot with wheeled vehicles"
url: "https://spaceengineers.wiki.gg/wiki/How_to_use_autopilot_with_wheeled_vehicles"
category: "Vehicles"
wiki_page: "How to use autopilot with wheeled vehicles"
includes_blocks: true
---

# How to use autopilot with wheeled vehicles

You may want to use [autopilot](https://spaceengineers.wiki.gg/wiki/Autopilot "Autopilot") on a wheeled vehicle to transport cargo from the mines or ferry crew from the hangar to their quarters. You notice it doesn't work because the [Remote Control](https://spaceengineers.wiki.gg/wiki/Remote_Control "Remote Control")'s autopilot does not attempt to propel or turn wheels, it insists on using only gyroscopes and thrusters like a space ship.

As a workaround, (either give up and build a hovercraft, or) use the wheel suspensions' Overrides to put the vehicle into a custom-made cruise control!

You can use the same Autopilot features in the [Remote Control](https://spaceengineers.wiki.gg/wiki/Remote_Control "Remote Control") or in the [Automaton](https://spaceengineers.wiki.gg/wiki/Automaton "Automaton") [AI Recorder](https://spaceengineers.wiki.gg/wiki/AI_Recorder "AI Recorder") to create your cruise control.

## Add Gyroscopes

Tip: Add Gyroscopes to the vehicle to get the added benefit that the autopilot will use them to recover and level if the vehicle catches air during a jump.

Having the Autopilot turn a rover through gyroscopes somewhat works if you set the wheels to low friction and only drive on flat ground.

## Set up propulsion override

Without thrusters, an autopiloted rover needs a **Propulsion Override** on its wheels to be able move towards the next waypoint. Alas the autopilot does not switch it on and off as needed, you need to set this up yourself.

Important: Remember to **Invert Propulsion** on the _right side_ wheels while using the override.

Configure each waypoint to switch on/off the Propulsion Overrides and Brakes, or set up [timers](https://spaceengineers.wiki.gg/wiki/Timer_Block "Timer Block") or [sensors](https://spaceengineers.wiki.gg/wiki/Sensor "Sensor") to have more control over when to toggle the overrides at waypoints to not overshoot. This requires a lot of testing and depends on the planetary environment.

1.  Drive along the path and [record the waypoints](https://spaceengineers.wiki.gg/wiki/GPS "GPS") at the exact same height as the Remote Control block will be during the trip.
2.  Make a [control group](https://spaceengineers.wiki.gg/wiki/Groups "Groups") for the wheels _on the right side_.
3.  Make a [control group](https://spaceengineers.wiki.gg/wiki/Groups "Groups") for _all_ wheels.
4.  Build two [Timer Blocks](https://spaceengineers.wiki.gg/wiki/Timer_Block "Timer Block").
5.  Program the first Timer block to start driving:
    *   Enable **Set Propulsion Override** on all wheels, lower the friction on all wheels, enable **Invert Propulsion** on the _right_ side, release the brakes, and start the Autopilot.
6.  Program the second Timer block to stop driving:
    *   Enable **Reset Propulsion Override** on all wheels, increase the friction on all wheels, disable **Invert Propulsion** on the _right_ side, hit the brakes, and stop the Autopilot.

## Troubleshooting

To make waypoints visible, use the Show on HUD setting on the [GPS](https://spaceengineers.wiki.gg/wiki/GPS "GPS") screen for RC, or on the [Info Screen](https://spaceengineers.wiki.gg/wiki/Info_Screen "Info Screen") for Automatons.

If the vehicle is empty with high clearance on one leg of the trip, and full with low clearance on the way back, the Remote Control block cannot "reach" the same waypoints. In contrast to a flying craft, a rover cannot simply "fly a little bit higher" to reach a waypoint, and it will stall trying.

Therefore, make it part of the last waypoints' actions after loading cargo to adjust the suspension height so the remote control is on the waypoints' height again. If that doesn't help, you have to record separate waypoints in loaded and unloaded state.

Watch Halipatsui's video with some great tips: [Guide for using RC Block with Rovers](https://www.youtube.com/watch?v=WO6SkXJtTDo).

For advanced control, check out the [Driver Assist Script](https://steamcommunity.com/sharedfiles/filedetails/?id=1089115113) (doesn't work on consoles).