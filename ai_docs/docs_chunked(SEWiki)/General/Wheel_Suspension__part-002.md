*   **Height offset** in centimetres -- The absolute vertical position of the wheel relative to the suspension.
    *   For an all-terrain vehicle, you want high clearance, so use a low wheel position from 0 to -32cm.
    *   For racecars or small utility vehicles, you want to be close to the ground, so you choose a high wheel position from 0 to +32cm.
*   **Friction** in percent -- How much traction (grip) the wheels have on the ground.
    *   Increase this value temporarily while going straight uphill or downhill to get grip, at the cost of turnability.
    *   Decrease this value slightly to be able to turn more smoothly.
    *   For "race drifting" on flat ground, or when using Overrides, or when you want to use (gyroscopic) mouse steering, lower wheel friction to have less turning resistance against the ground.
*   **Speed Limit** in km/h -- Helps you to not actively accelerate above the chosen value.
    *   For slow all-terrain and small utility vehicles, impose a low speed to prevent them from flipping.
    *   For race cars on flat ground, allow higher speeds.
    *   The vehicle can still exceed this speed when racing downhill, it's not a hard limit.
*   **Propulsion Override** in +/- percent -- Used for [Autopiloted](https://spaceengineers.wiki.gg/wiki/Autopilot "Autopilot") vehicles or for cruise control. Use a Timer Block to enable the Autopilot and its Overrides together.
*   **Steer Override** in +/- percent -- Used for [Autopiloted](https://spaceengineers.wiki.gg/wiki/Autopilot "Autopilot") vehicles or for cruise control. Use a Timer Block to enable the Autopilot and its Overrides together.

### Toolbar Actions for players

When you sit in the cockpit and press [G key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings"), then select your custom Wheel Suspensions groups, you have the option to assign the following helpful actions to your [quick toolbar slots](https://spaceengineers.wiki.gg/wiki/Tool_Bar "Tool Bar"). Tip: Assign "Set/Reset/Increase/Decrease" actions next to each other to smartly adjust settings on the fly while driving!

*   **Increase/Decrease Steering Angle** -- Lets you change the absolute steering angle on the fly.
    *   **Reset Steering Angle** -- Lets you reset the absolute steering angle on the fly.
*   **Increase/Decrease Power** -- Lets you adjust on the fly how fast you'll accelerate, for example, while going uphill.
*   **Increase/Decrease Strength** -- Lets you adjust on the fly how much the suspension travels, for example, when transitioning from flat to uneven terrain.
*   **Increase/Decrease Height Offset** -- Lets you adjust on the fly the wheel clearance, for example, to be able to reach a connector, to fit through a low door, or when transitioning from flat to uneven terrain.
    *   **Reset Height Offset** -- Lets you reset wheel clearance on the fly.
*   **Increase/Decrease Friction** -- Lets you adjust the traction on the fly, for example, while going uphill or while racing.
*   **Increase/Decrease Speed Limit** -- Lets you adjust the speed limit on the fly, for example, when transitioning from flat to uneven terrain.
*   **Increase/Decrease/Set Propulsion Override** -- Lets you set up accelerating/decelerating cruise control on the fly.
    *   **Reset Propulsion Override** -- Lets you switch off accelerating/decelerating cruise control on the fly.
*   **Increase/Decrease/Set Steer Override** -- Lets you set up the turning cruise control on the fly.
    *   **Reset Steer Override** -- Lets you switch off turning cruise control on the fly.

### Toolbar Actions for autopilot

You can add the following options to your [toolbar](https://spaceengineers.wiki.gg/wiki/Toolbar "Toolbar"), but typically you use them only in [Event Controllers](https://spaceengineers.wiki.gg/wiki/Event_Controller "Event Controller"), [Sensors](https://spaceengineers.wiki.gg/wiki/Sensor "Sensor"), and [Timer Blocks](https://spaceengineers.wiki.gg/wiki/Timer_Block "Timer Block"), in context with [Remote Controls](https://spaceengineers.wiki.gg/wiki/Remote_Control "Remote Control").

When you set up an [Autopilot](https://spaceengineers.wiki.gg/wiki/Autopilot "Autopilot") sequence, you will enable and disable combinations of the following suspension options using Timer blocks:

*   **Steering On/Off** -- Whether the driver can steer left and right with [A key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings") and [D key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings"). Deactivate when autopilot takes over.
*   **Propulsion On/Off** -- Whether the driver can accelerate and decelerate with [W key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings") and [S key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings"). Deactivate when autopilot takes over.
*   **Can Brake On/Off** -- Whether holding [SPACEBAR key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings") engages the handbrake. Deactivate if you need the Autopilot to overrule the pilot.
*   **Allow Parking Brake On/Off** -- Whether pressing [P key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings") engages the handbrake and other docking actions (see [Cockpit Controls](https://spaceengineers.wiki.gg/wiki/Cockpit_Controls "Cockpit Controls")).
*   **AirShock On/Off** -- Whether to enable automatic shock absorbers when catching air.
*   **Invert Steering on/off** -- Enable this only on the wheels on the right side while activating Steer Override.
*   **Invert Propulsion on/off** -- Enable this on the wheels on the right side while activating Propulsion Override.

### Can the Autopilot drive cars?

Wheeled vehicles cannot properly use the [Autopilot](https://spaceengineers.wiki.gg/wiki/Autopilot "Autopilot") function as spaceships do, because the Autopilot doesn't turn or propel the wheels. As a workaround, you will have to set up **Propulsion Overrides** to force the vehicle into a sort of waypoint-guided cruise control.

For details, see [How to use autopilot with wheeled vehicles](https://spaceengineers.wiki.gg/wiki/How_to_use_autopilot_with_wheeled_vehicles "How to use autopilot with wheeled vehicles").

The [Remote Control](https://spaceengineers.wiki.gg/wiki/Remote_Control "Remote Control")'s [Autopilot](https://spaceengineers.wiki.gg/wiki/Autopilot "Autopilot") may not be able to control wheels -- but a player can still remote-control a wheeled vehicle manually.
