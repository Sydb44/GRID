---
title: "Walker"
url: "https://spaceengineers.wiki.gg/wiki/Walker"
category: "General"
wiki_page: "Walker"
includes_blocks: true
---

# Walker - Official Space Engineers Wiki

A Walker is a large terrestrial robot with humanoid or animal features that is controlled by a player from a cockpit inside. Walkers are also known as Mech, Mecha, Zoids, or Mobile Suits.

Next to [wheeled vehicles](https://spaceengineers.wiki.gg/wiki/Wheel_Suspension "Wheel Suspension") and [thruster-propelled spaceships](https://spaceengineers.wiki.gg/wiki/Thruster "Thruster"), Walkers make up a third category of mobile [grids](https://spaceengineers.wiki.gg/wiki/Grid "Grid") that can be built and steered in Space Engineers.

## Gallery

*   [![Sasquatch mobile suit with wheels as shock absorbers and locomoting gorilla arms, by physdick](https://spaceengineers.wiki.gg/images/thumb/5/5a/Monke-by-physdick.jpg/120px-Monke-by-physdick.jpg?273498)](https://spaceengineers.wiki.gg/wiki/File:Monke-by-physdick.jpg "Sasquatch mobile suit with wheels as shock absorbers and locomoting gorilla arms, by physdick")
    
    Sasquatch mobile suit with wheels as shock absorbers and locomoting gorilla arms, by physdick
    
*   [![Simple Chameleon walker, by AdaRynin](https://spaceengineers.wiki.gg/images/thumb/d/df/Chameleon-walker-by-AdaRynin.gif/120px-Chameleon-walker-by-AdaRynin.gif?3465c4)](https://spaceengineers.wiki.gg/wiki/File:Chameleon-walker-by-AdaRynin.gif "Simple Chameleon walker, by AdaRynin")
    
    Simple Chameleon walker, by AdaRynin
    

## General Definition

[![green bean's mechs](https://spaceengineers.wiki.gg/images/thumb/6/6b/Animal-mechs-by-green-bean.png/320px-Animal-mechs-by-green-bean.png?891286)](https://spaceengineers.wiki.gg/wiki/File:Animal-mechs-by-green-bean.png)

Examples of mechs by green bean

There are many types of Mechas with any number of legs —biped, tripod, quadrupedal, pentapedal (kangaroo-like), hexapod, octoped— depending on the desired style and purpose.

*   Humanoid walkers typically feature a head and body with two legs and two arms.
*   Animallikes, dragonlikes, avianoids etc. have two to four legs, possibly with claws, and animated wings or tails.
*   Arachnids and Insectoids walk on 6-8 legs for stability.
*   There are different knee and hip joint configurations to choose from.

And so on.

In contrast to wheeled vehicles, walkers use walking locomotion. In contrast to spaceships, walkers are only used in [planetary or artificial gravity](https://spaceengineers.wiki.gg/wiki/Gravity_Generator "Gravity Generator"). In contrast to other robots and drones, mechas are controlled by players from a [cockpit](https://spaceengineers.wiki.gg/wiki/Cockpit "Cockpit") inside. Non-walker drones are flying [Automatons](https://spaceengineers.wiki.gg/wiki/Automaton "Automaton") steered by [Autopilot](https://spaceengineers.wiki.gg/wiki/Autopilot "Autopilot")/[Remote Control](https://spaceengineers.wiki.gg/wiki/Remote_Control "Remote Control"), which does not support walking locomotion.

## Space Engineers Considerations

[![BlackArmor mechs](https://spaceengineers.wiki.gg/images/thumb/e/e8/BlackArmor-mechs.png/320px-BlackArmor-mechs.png?eb418d)](https://spaceengineers.wiki.gg/wiki/File:BlackArmor-mechs.png)

Examples of mechs by BlackArmor

Walkers don't typically use wheels, but in Space Engineers, passive wheels[\[1\]](#cite_note-1) are often used as shock absorbers on the soles of their feet. Feet made out of blocks are very fragile when they hit the ground repeatedly.

Walkers can have atmospheric thrusters on their backs to stabilise jumps, but should not use the thruster as their main propulsion (because then they would just be creature-shaped spaceships).

While designing the legs and configuring the locomotion, use scaffolding at first to fixate the Walker and keep its feet off the ground (or to prevent it from floating off in low gravity, respectively).

Walker legs must provide forward motion AND lift motion for the foot. In Space Engineers, you have three [Mechanical Blocks](https://spaceengineers.wiki.gg/wiki/Mechanical_Blocks "Mechanical Blocks") at your disposal to build leg joints:

*   [rotors](https://spaceengineers.wiki.gg/wiki/Rotor "Rotor")
*   [hinges](https://spaceengineers.wiki.gg/wiki/Hinge "Hinge")
*   [pistons](https://spaceengineers.wiki.gg/wiki/Piston "Piston")

Rotors can be shoulder and hip joints for the forward motion; hinges can be knee and ankle joints; and pistons can also perform a lifting motion. These are not hard rules -- be creative and use whichever mechanical block is best to achieve the locomotion you are aiming for!

*   **Inline motion:** Bipedal walkers' legs rotate around the hip joint in the direction of travel. Legs using inline motion can achieve higher forward running speeds, but require gyroscopes to turn.  
    Example: Running humans.
*   **Sweeping motion:** Arthropod legs move pairwise sideways in a swimmer-like motion. Legs using sweeping motion run more slowly, but can turn on the spot quickly like a tank.  
    Example: Crocodile, insects, spiders
*   You can of course also combine different motions.

A challenging part of the development process is to coordinate the locomotion of all joints so their timings work together. In Space Engineers, you use [Timer Blocks](https://spaceengineers.wiki.gg/wiki/Timer_Block "Timer Block") for simple walkers, and [Programmable Blocks](https://spaceengineers.wiki.gg/wiki/Programmable_Block "Programmable Block") with custom [scripts](https://spaceengineers.wiki.gg/wiki/Scripting "Scripting") for advanced walkers.

Lastly, in Space Engineers, all walkers also rely heavily on [Gyroscope](https://spaceengineers.wiki.gg/wiki/Gyroscope "Gyroscope") overrides (see there) to keep their balance.

## The Development Process

This is a summary of the process. For all details, watch BlackArmor's tutorials and play his scenarios!

1.  Decide on a design and leg layout.
2.  Start building core functional blocks such as cockpit, power, gyroscopes. Then add hips, legs, and feet.  
    Tip: Use [Symmetry](https://spaceengineers.wiki.gg/wiki/Symmetry "Symmetry") Mode (see there).
3.  Set up hip and ankle rotors:
    1.  Determine the upper and lower limits that achieve the best _forward_ motion.
    2.  Make sure the legs don't bump into each other.
    3.  Position the pairs of legs in _mirrored_ positions for stability.
    4.  Set up a block group that you control by triggering the Reverse actions of the joints.
    5.  Adjust the joint rotation speeds where necessary.
4.  Set up knee hinges/pistons:
    1.  Determine the upper and lower limits that achieve the best _lifting_ motion.
    2.  _Synchronize_ the extends of the legs for stability.
    3.  Set up a second block group that you control by triggering the Reverse action of these joints.
    4.  Adjust the extension speeds, if necessary.
5.  Next, test both groups together and coordinate.
6.  Set up Timers to trigger both groups in a coordinated way.
7.  Enable the Override of one extra gyroscope and leave its RPM values set to zero. This provides stability.
