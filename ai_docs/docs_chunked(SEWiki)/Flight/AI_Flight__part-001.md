---
title: "AI Flight"
url: "https://spaceengineers.wiki.gg/wiki/AI_Flight"
category: "Flight"
wiki_page: "AI Flight"
includes_environment: true
includes_blocks: true
---

# AI Flight - Official Space Engineers Wiki

| AI Flight |     |
| --- | --- |
| [![Icon Block AI Flight.png](https://spaceengineers.wiki.gg/images/c/c0/Icon_Block_AI_Flight.png?40cc07)](https://spaceengineers.wiki.gg/wiki/File:Icon_Block_AI_Flight.png) |     |
| * * * |     |
| **Function:** | This Move block controls the movement of an AI drone |
| **DLC?** | Vanilla |
| * * * |     |
| **Fits small grid** |     |
| Mass: | 156.0 kg |
| Hitpoints: | 486 |
| Power: | \-0.01 MW |
| PCU: | 25  |
| Size: | 1x1x1 |
| Time to Build: | 10 sec |
| * * * |     |
| **Fits large grid** |     |
| Mass: | 900.0 kg |
| Hitpoints: | 3460 |
| Power: | \-0.01 MW |
| PCU: | 25  |
| Size: | 1x1x1 |
| Time to Build: | 24 sec |
| * * * |     |
| _Data Controls:_ | \[[purge](https://spaceengineers.wiki.gg/wiki/AI_Flight?action=purge)\] ([?](https://spaceengineers.wiki.gg/wiki/Template:Info_Block))) |
|     |     |

The AI Flight block is a functional [Automaton](https://spaceengineers.wiki.gg/wiki/Automaton "Automaton") block in Space Engineers. The block provides automatic flight control to drone ships in both space and atmosphere. The AI Flight block enables complex flight behaviors as well as detailed control of how your grid will move.

This AI Block is of type "Move".

## Usage

### Requirements

The AI Flight block depends on the presence of other AI Blocks to supply it with waypoints! First, build an AI task block ([AI Basic](https://spaceengineers.wiki.gg/wiki/AI_Basic "AI Basic") or [AI Recorder](https://spaceengineers.wiki.gg/wiki/AI_Recorder "AI Recorder")) or an AI Combat block ([AI Defensive](https://spaceengineers.wiki.gg/wiki/AI_Defensive "AI Defensive") or [AI Offensive](https://spaceengineers.wiki.gg/wiki/AI_Offensive "AI Offensive")), and configure it to provide waypoints to the AI Flight block.

The rotation of the placed AI blocks is relevant for determining the forward direction and alignment to planetary gravity.

To fly, the AI Flight-controlled drone must have [thrusters](https://spaceengineers.wiki.gg/wiki/Thruster "Thruster") in all six directions, using thrusters that are suitable for its target environment (atmospheric or space flight). Equip the drone with at least one gyroscope.

### How to teach a drone to fly

With the AI behavior switched off, configure the following settings:

1.  **Collision Avoidance**: See also [Collision Avoidance](https://spaceengineers.wiki.gg/wiki/Autopilot#Collision_Avoidance "Autopilot")
    *   Enable this on long autonomous trips to prevent the drone from totalling itself against terrain or grids.
    *   If the drone refuses to fly in tight quarters or to dock to a connector, or if this is a [PBW](https://spaceengineers.wiki.gg/wiki/Player_Built_Weapons "Player Built Weapons"), disable this option.
2.  **Precision Mode**: See also [Precision Mode](https://spaceengineers.wiki.gg/wiki/Autopilot#Precision_Mode "Autopilot")
    *   To make the drone fly carefully and decelerate and turn exactly on each GPS waypoint, enable **Precision Mode**.
    *   To fly carelessly and fast in space or anywhere without obstacles, disable this setting.
3.  **Speed Limit**: To set the maximum speed, input a value between 0-100 m/s. Default is 10 m/s.
    *   For missiles/[PBWs](https://spaceengineers.wiki.gg/wiki/Player_Built_Weapons "Player Built Weapons") use high values.
    *   For utility drones, stick with low values.
4.  **Align to P.Gravity**: To make the drone fly with its AI Move block aligned horizontally to planetary gravity, enable this option.
    *   On planets, if your strongest thrusters are your ventral thrusters, and precise drone rotation is irrelevant to your task, enable it.
    *   On planets, if you have strong thrust in all directions and want to precisely control and record the drone's rotation, disable it!
    *   For a space drone, disable it.
5.  **Min. Altitude**: Set how high the drone should fly in planetary gravity. Choose a value between 0 and 500 metres. Not used in space.
    *   To allow docking or landing on the ground, set it to 0m.
    *   To simulate hovercraft behaviour, set it to ~2m, and so on.
6.  **Max. Pitch Angle**: Set at which angle the drone is allowed to pitch up or down when approaching a waypoint in planetary gravity. This is relevant to prevent a fully loaded cargo drone to shift too much weight onto weaker aft or fore thrusters. Not used in space.
7.  **Max. Roll Angle**: Set at which angle the drone is allowed to roll left or right when approaching a waypoint in planetary gravity. This is relevant to prevent a fully loaded cargo drone to shift too much weight onto weaker lateral thrusters. Not used in space.

Switch **AI Behavior** on to make this the active block of its type and start the autopilot.

To steer the drone manually using a Cockpit or RC block, switch AI Behavior off.

### Troubleshooting

If the drone cannot reach its waypoints, there are several things you ought to check:

*   Use a [Remote Control](https://spaceengineers.wiki.gg/wiki/Remote_Control "Remote Control") set up and make a manual test whether the drone is flight-worthy at all.
    *   Does it have thrust in all 6 directions?
    *   For combat drones, ensure that they are able to turn, accelerate, and decelerate fast.
    *   For cargo drones, test their lifting, acceleration, and braking ability under full load.
    *   For planetary flight, add extra ventral thrusters to counteract gravity, and lower the roll and pitch angles.
*   If the drone overshoots the waypoints, first try decreasing the speed limit to under 10 m/s.
*   If it flies slow stop-and-go in open space, then switch [Precision Mode](https://spaceengineers.wiki.gg/wiki/Autopilot#Precision_Mode "Autopilot") off.
*   If it approaches waypoints too sloppily, then switch [Precision Mode](https://spaceengineers.wiki.gg/wiki/Autopilot#Precision_Mode "Autopilot") on.
*   If it hesitates in front of hangar doors, connectors, asteroid caves, etc., then switch [Collision Avoidance](https://spaceengineers.wiki.gg/wiki/Autopilot#Collision_Avoidance "Autopilot") off.
*   If it crashes into bases and asteroids, then switch [Collision Avoidance](https://spaceengineers.wiki.gg/wiki/Autopilot#Collision_Avoidance "Autopilot") on.

If only one set of settings does not cover your situation, you can be flexible:

*   When used together with [Autopilot](https://spaceengineers.wiki.gg/wiki/Autopilot "Autopilot"), toggle Collision Avoidance or Precision Mode on/off at waypoints as part of the recording.
*   Build two AI Flight blocks with different settings, and use an [Event Controller](https://spaceengineers.wiki.gg/wiki/Event_Controller "Event Controller") to switch one on and one off. Optimise one configuration for fast open-space flight and the other for a slow careful docking approach.

Note: If your drone uses thrusters or gyroscopes on override, the AI Flight block switches these off and takes control when it activates.
