The purpose of this experiment was to get an intuition for a good baseline which ratio of blocks we need to make a flyable ship.

This is not the ship yet. We will start building the actual ship now!

Let's repeat our current plan:

*   We know we need a cockpit, power, gyroscope.
*   We _guess_ we need 2 large thrusters (forward and backward) and 16 small thrusters in the four remaining directions.
*   To specialise the ship for safe trading, we want a medium cargo, a connector, and two autocannons.
*   For life support, we want an O2/H2 Generator.
*   Maybe an antenna so we don't lose sight of it.

The latter few specialised blocks are less heavy, but you could also include them in the testing phase, if you want to be sure.

## Finalising the Ugly Ship

[![](https://spaceengineers.wiki.gg/images/thumb/4/40/Core-ship-exploded-view.png/320px-Core-ship-exploded-view.png?c86168)](https://spaceengineers.wiki.gg/wiki/File:Core-ship-exploded-view.png)

Showing both sides of the blocks so you can see how the conveyor ports line up. From left to right: Connector, Cargo, O2/H2 Generator, Cockpit

How to start building? If you want the cockpit and cargo to be conveyored (which is not a requirement, but helpful) that imposes constraints on your build. Constraints help decide what to do first: You want the conveyor ports to line up. The blocks with conveyor ports are Cockpit, O2/H2 Generator, Cargo container, and connector, so you build those first.

At this stage, no more slapping on blocks in random spots. We arrange these blocks carefully so all the ports match.

Okay, this is the core of the ship.

[![](https://spaceengineers.wiki.gg/images/thumb/4/48/Core-ship.png/320px-Core-ship.png?29ac9a)](https://spaceengineers.wiki.gg/wiki/File:Core-ship.png)

UglyShip: Conveyored core blocks

Let's add the remaining functional blocks, in order of largest to smallest: 2 large thrusters, 16 small thrusters, battery, autocannons, gyroscope, antenna.

[![](https://spaceengineers.wiki.gg/images/thumb/8/8d/Core-ship-plus-equipment.png/320px-Core-ship-plus-equipment.png?896487)](https://spaceengineers.wiki.gg/wiki/File:Core-ship-plus-equipment.png)

UglyShip: Adding the remaining functional blocks to the core

In this example, I aimed for symmetry. But know, if you build asymmetrically, it will fly just the same. (We would have better symmetry options for slightly larger ships with 2 forwards and 2 backwards Large Ion Thrusters)  
Okay, the functional blocks are in.

Lastly, let's give it a decorative hull and a paint job.

*   [![UglyShip with hull, front](https://spaceengineers.wiki.gg/images/thumb/3/35/Ugly-ship-with-hull-front.png/120px-Ugly-ship-with-hull-front.png?3535f7)](https://spaceengineers.wiki.gg/wiki/File:Ugly-ship-with-hull-front.png "UglyShip with hull, front")
    
    UglyShip with hull, front
    
*   [![UglyShip with hull, side](https://spaceengineers.wiki.gg/images/thumb/2/29/Ugly-ship-with-hull-side.png/120px-Ugly-ship-with-hull-side.png?a400be)](https://spaceengineers.wiki.gg/wiki/File:Ugly-ship-with-hull-side.png "UglyShip with hull, side")
    
    UglyShip with hull, side
    

This way, we have created a functional ship intuitively, without looking at any mass or force tables.

## How to proceed

In general, keep the heaviest blocks close the center, near the cockpit, because the center of mass is what the ship will rotate around.

*   If you add more power-hungry blocks later, and the power usage gage in the bottom right turns red, add more power producing blocks:
    *   Either (small/large) reactors,
    *   Or batteries,
    *   Or hydrogen engines if the ship is planned to carry hydrogen tanks anyway.
    *   Avoid solar panels and small batteries, they don't help in this situation. And wind turbines don't work on ships.

*   If you add heavier blocks later, and acceleration starts tanking, add more forwards thrusters. Every time you have ~6 or more small thrusters in the same direction, it's time to consider whether you should not replace them by one large truster. If you experience sluggish braking, increase the number of backwards thrusters. Same for moving sideways: you may have to increase the number of thrusters at least along the one other axis in which you move most often.

*   If turning (using the mouse, Q/E, or arrow keys) is sluggish, add another gyroscope. If turning is too twitchy, remove gyroscopes -- or decrease the power of the last one.

*   Don't forget to test with a full cargo.

Keep your ships specialised and don't cram every functionality into one grid, because its increasing mass will become more and more difficult to handle.

### How about atmospheric ships?

The approach for designing ships with atmospheric thrusters is the same, you just test on a planet using atmospheric thrusters. The big difference is, you need to fight the pull of gravity. During the test phase, design the ship to have a clear up and down side and include a large upwards thruster from the start.

You can even reduce or forgo downwards thrusters, to save mass, since gravity will pull you down anyway. Drones are an exception, they always needs thrust in six directions.

### How about hydrogen ships?

The approach for designing hydrogen ships is roughly similar. If it's a planetary hydrogen ship, the same rule regarding upwards thrust to fight gravity applies.

The biggest difference is that, already in the "slap on another block" test phase, must account for the volume and mass of hydrogen tanks and conveyor tubes. You won't be able to just stick everything together randomly. Hydrogen thrusters need to be properly piped, even in the experimental phase.