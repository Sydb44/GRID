---
title: "An intuitive approach to ship building"
url: "https://spaceengineers.wiki.gg/wiki/An_intuitive_approach_to_ship_building"
category: "Vehicles"
wiki_page: "An intuitive approach to ship building"
includes_environment: true
includes_blocks: true
---

# An intuitive approach to ship building

You can calculate the perfect ship configuration -- but wouldn't it be fun to be able to build a "good-enough ship" intuitively?

Get into Creative Mode in space and let's make some experiments!

## Goal Setting

First, decide what you want to use the ship for so you can specialise it.

Example for this tutorial: Let's say you want to park your large-grid ship out of sight of the space station, and send a small-grid ship to do the trading.

Such a small-grid ship needs to

*   be able to fly in space (ion thrusters),
*   have a medium-sized cargo space and a connector,
*   be fast enough to escape pirates,
*   have some defenses against pirates.

## Build a baseline test grid

Every ship needs at least the following essentials:

*   cockpit,
*   [power](https://spaceengineers.wiki.gg/wiki/Power "Power"),
*   gyroscope,
*   thrusters in six directions.

How many thrusters, how many batteries? I don't know! I don't want to calculate it. We gotta find out!

### UglyShip 1

[![](https://spaceengineers.wiki.gg/images/thumb/0/0d/Ugly-ship-single-ions.png/320px-Ugly-ship-single-ions.png?415e65)](https://spaceengineers.wiki.gg/wiki/File:Ugly-ship-single-ions.png)

UglyShip 1: 6 small ion thrusters

Let's just slap these essential blocks together and see what happens.

From left to right: yellow: gyroscope, blue: cockpit, red: battery, gray: six ion thrusters just slapped on so they point in six different directions. Beautiful...

Does it fly? Jump in an press W. This ship can accelerate from 0 to 100 m/s in 22sec. Braking takes just as long. With a mass of only 3,300kg, at least it turns well.

Not a good ship, it barely flies. We can do better!  

### UglyShip 2

[![](https://spaceengineers.wiki.gg/images/thumb/f/ff/Ugly-ship-double-ions.png/320px-Ugly-ship-double-ions.png?9b2cd2)](https://spaceengineers.wiki.gg/wiki/File:Ugly-ship-double-ions.png)

UglyShip 2: 12 small ion thusters

Since it's too slow, we upgrade the thrusters: let's double them. With 12 thrusters, it accelerates from 0-100 in 13 sec. This 4,000 kg ship still turns well.

It's still slow, but better than before. We're making incremental progress.

Also, those blocks are just the essentials, it does not even have its specialised blocks yet -- it has no cargo, no antenna, no O2/H2 Generator, no landing gear.

The Cargo container will be very heavy, so let's do further testing with that.  

### UglyShip 3

[![](https://spaceengineers.wiki.gg/images/thumb/c/c6/Ugly-ship-double-ions-cargo.png/320px-Ugly-ship-double-ions-cargo.png?595f34)](https://spaceengineers.wiki.gg/wiki/File:Ugly-ship-double-ions-cargo.png)

UglyShip 3: 12 small ion thusters plus cargo

[![](https://spaceengineers.wiki.gg/images/thumb/a/a6/Build-experiment-fill-cargo.png/320px-Build-experiment-fill-cargo.png?d0f0b8)](https://spaceengineers.wiki.gg/wiki/File:Build-experiment-fill-cargo.png)

Press Shift+F10 to open the Spawn Menu

Let's just slap a medium cargo container on it. But we don't want to test empty cargo. Let's fill it with something heavy. Target the cargo container and press Shift+F10 to open the Spawn Menu. Select stone and enter a large number. I don't know, 10'000? 100'000? Then press "Spawn into selected container".

Jump into the cockpit and press W to do a test flight. With 12 small ion thruster and a full cargo container, it now takes 46 sec to accelerate from 0-100, and equally long to brake. Its mass is now 13,500 kg: It's turning and manoeuvering more sluggishly. Oof! What a horrible ship.  

### UglyShip 4

[![](https://spaceengineers.wiki.gg/images/thumb/e/e7/Ugly-ship-double-ions-cargo-large-thrusters.png/320px-Ugly-ship-double-ions-cargo-large-thrusters.png?b4cff9)](https://spaceengineers.wiki.gg/wiki/File:Ugly-ship-double-ions-cargo-large-thrusters.png)

UglyShip 4: 8 small ion thusters plus cargo plus 2 large thrusters

Definitely needs more thusters for acceleration. We could slap on more small thrusters. There's also large Ion thrusters - let's replace 2 forward and 2 backwards thrusters with 1 large thruster each. They're big. Just slap them on somewhere. For up/down, left/right we still only have two small thrusters each.

Our next test flight shows we can now accelerate from 0-100 in 9 sec! And we can brake equally fast. With a mass of 14,400 kg, moving left/right/up/down, however, feels really slow. Sluggish manoeuvring is not good for docking at space stations! We need better directional thrust.  

### UglyShip 5

[![](https://spaceengineers.wiki.gg/images/thumb/2/20/Ugly-ship-quad-ions-cargo-large-thrusters.png/320px-Ugly-ship-quad-ions-cargo-large-thrusters.png?62ceb6)](https://spaceengineers.wiki.gg/wiki/File:Ugly-ship-quad-ions-cargo-large-thrusters.png)

UglyShip 5: 16 small ion thrusters plus cargo plus 2 large thrusters

Same ship with full cargo and large booster and braking thruster; now with _four_ small thrusters in left/right/up/down directions.

Maybe we lost a second for acceleration, but now it handles better flying sideways which will make it easier to dock.

## But it's ugly :(

The purpose of this experiment was to get an intuition for a good baseline which ratio of blocks we need to make a flyable ship.

This is not the ship yet. We will start building the actual ship now!

Let's repeat our current plan:

*   We know we need a cockpit, power, gyroscope.
*   We _guess_ we need 2 large thrusters (forward and backward) and 16 small thrusters in the four remaining directions.
*   To specialise the ship for safe trading, we want a medium cargo, a connector, and two autocannons.
*   For life support, we want an O2/H2 Generator.
*   Maybe an antenna so we don't lose sight of it.

The latter few specialised blocks are less heavy, but you could also include them in the testing phase, if you want to be sure.
