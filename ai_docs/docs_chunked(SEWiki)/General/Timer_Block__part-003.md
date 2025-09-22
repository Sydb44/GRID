
All the actions run inside a timer don't wait for each other's completion. If you are automating a _sequence_ of longer actions, you must enforce pauses in between. Examples: Playing two sound alerts one after the other without overlapping; or a docking sequence that waits for the hangar door to open; or an airlock cycle that waits for the room to depressurise.

1.  Split up the time-sensitive actions and put them into separate Timer blocks.
2.  Configure the **Delay** of the second timer to wait for the first timer to finish.
3.  Make the first timer start the second timer.
4.  Make the second timer start the third, and so on.

The Delay format is read as hours:minutes:seconds. The start-up delay of a timer block can be set to any value between 1 second (0:00:01) and 1 hour (1:00:00).

Note that Timers are not accurate with the timings of delays, so rather add a little extra time. When you control something very time sensitive (like the joints of a [walker](https://spaceengineers.wiki.gg/wiki/Walker "Walker")), don't trust Timer Blocks to coordinate punctually by the second, and they certainly cannot handle any timings of less than a second. A script in a [Programmable Block](https://spaceengineers.wiki.gg/wiki/Programmable_Block "Programmable Block") is more suitable when you need precision.

Also, Timers just literally wait the number of seconds you tell them, they don't confirm whether the previous action has truly completed or not -- e.g. if a door is blocked instead of closed, or a room cannot be pressurised because your tanks are empty, a Timer sequence may get messed up if you don't add checks.

## Usage: Loop actions

Do you manually perform actions that always repeat in the same way, for example, automated shuttle (un)docking sequences, restocking various ammo on patrolling drones, progressing or resetting the [3D Printer](https://spaceengineers.wiki.gg/wiki/3D_Printer "3D Printer"), walking sequences of [Mecha](https://spaceengineers.wiki.gg/wiki/Walker "Walker") legs? Are you building mini-games with continuously moving obstacles or traps, or similar?

Just like any other action, you can set up a Timer to start (or stop!) another Timer -- even itself. That causes a repeating loop. For each set of actions that you want to repeat, set up one separate Timer and its Delay. Then you set up the last action of the last Timer to start the first Timer again, and the actions will loop.

### Can I loop the loops?

You can also build complex loops: Use one conductor Timer solely to start and stop several other Timers, add a long Delay, and as its last action, make it re-start itself.

When ever the timings start feeling too complicated to keep track of, it's recommended to simply draw some boxes with arrows to get your head around the delays, order, and groupings.

Tip: Trigger the **Stop** action on _all_ looping blocks when you want to end a loop.

### Should I Reuse Triggers and Actions?

You are not restricted to one trigger per one set of actions!

One Trigger can start multiple Timers, even though there is only one trigger slot: Just build a “conductor” Timer that starts all the other Timers, and make the trigger start the conductor!

Similarly, one Timer can be started by several triggers. For example, in a timed airlock cycle, you can have a manual button panel that starts the Timer, and also an automatic sensor that starts the same Timer.

## Usage: Reset Button

It is very helpful to set up one Timer that runs a reset sequence. This is essential for autonomous [drones](https://spaceengineers.wiki.gg/wiki/Drone "Drone"), [walkers](https://spaceengineers.wiki.gg/wiki/Walker "Walker"), or automated shuttles. Such grids can be a variety of on/off states: propulsion, RC directions, precision mode, collision avoidance, battery mode, rotation of mechanical blocks, waiting for an event, ...

When such a grid starts out in the wrong state, it may get lost, stall, or total itself. When their cycle is disrupted or while you're debugging, or when you're printing off old long-forgotten blueprints, you need a reliable way to send them into their start state.

*   Consistently name this one Timer something like RESET or RESTART, so you recognise it.
*   Don't define complex actions in the distributed action slots in random sensors, ECs, buttons, etc. Better set their two action slots to trigger specialised named timers, then you have to maintain only timers.
*   If the RC/AI blocks triggered rely on custom waypoints or named antennas/beacons, set them before starting the reset. Leave yourself a note on a small LCD.

Consider:

*   Reset mechanical blocks, including upper/lower extend, starting angle, lock, velocity and direction
*   Make it return to a save docking location
*   Reset propulsion including thrusters, dampers, gyroscopes, AI Flight, RC

## Usage: Randomizer

In this scenario, you want an event to trigger in only 50% of the time. The dice-roll is initiated by a player pressing a button (you can replace that by any block that detects a player doing anything).

1.  Build a Timer and name it e.g. SurpriseTimer.
    1.  Click Set up Actions and configure the random event here (e.g. arm and ignite a warhead).
2.  Build a Timer and name it e.g. ToggleTimer.
    1.  Set its Delay to e.g. 3 sec.
    2.  Click Set up Action. As first action, configure ToggleTimer to switch the SurpriseTimer block **on/off**.
    3.  As second action, make the ToggleTimer **Run** itself. (loop)
3.  Build a Sensor that detects a random event, e.g. a player entering this room.
    1.  Configure its action to switch off ToggleTimer.  
        You now have a 50/50 chance that SurpriseTimer is on or off.
4.  Build a button labelled Surprise...
    1.  Configure its action to Run SurpriseTimer.
        *   If SurpriseTimer was on, the "surprise" happens.
        *   If SurpriseTimer was off, nothing happens.

## Troubleshooting

### Auditory Troubleshooting: Beeps

A Timer Block has a setting to run either silently or to beep every time when triggered. Additionally, if you have set up a **Delay**, a non-**silent** Timer beeps for every second of the countdown. The sound is only audible in close proximity.

Which setting should you choose?

*   A silent timer is less annoying when it loops often. Silence is also preferred when actions are supposed to happen without attracting the attention of players.
*   Deactivating the **Silent** option can be useful, on the other hand, while setting it up or while troubleshooting, to get feedback. You can also use auditory feedback when you purposely want to alert other players to expect an automated action — reminds them to wait, for example, for an airlock sequence or a docking manoeuvre to complete.
