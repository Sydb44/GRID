---
title: "Ad Astra: Designing a Spacecraft for Launch"
url: "https://spaceengineers.wiki.gg/wiki/Ad_Astra:_Designing_a_Spacecraft_for_Launch"
category: "Vehicles"
wiki_page: "Ad Astra: Designing a Spacecraft for Launch"
includes_environment: true
includes_blocks: true
---

# Ad Astra: Designing a Spacecraft for Launch

By Vaisaius8

## Introduction

This page details the steps in launching a spacecraft with a payload sufficient to establish a permanent orbital presence from a moon or planetary body (hereafter referred to as "planets" or "the surface") into space. It assumes that the player in question has an established and well-supplied base with access to every ore except for platinum and uranium (although silver is not strictly speaking required - just a very good idea). While some math is involved, it should not be challenging to anyone with a basic grasp of algebra, scratch paper, and a calculator; a spreadsheet editor can make the process much faster, but is not required.

## Physics Involved

In space, an object in motion stays in motion and a body at rest stays at rest, both until a force is applied to the object. Force, measured in kg/(m/s2) or newtons (N), will cause a mass to accelerate in a given direction according to the following equation:

F = m \* a

where:

*   F: the force applied to the object, measured in newtons
*   m: the mass of the object, measured in kilograms
*   a: the object's acceleration, measured in m/s2

This equation allows us to calculate how much thrust the thrusters of a spacecraft with a given mass need to generate to achieve a target acceleration. Conversely, by rearranging the equation, we can calculate the acceleration the thrusters of a spacecraft of a given weight can provide:

a = F / m

Of course, on planets, the force of gravity imparts objects with a constant acceleration toward the surface until the object crashes. This gravitational force, also referred to as "weight", can be calculated by the following equation:

W = m \* (g \* 9.81 (m/s2)/g)

where:

*   W: the gravitational force, or weight, pulling the spacecraft to the surface, measured in newtons
*   m: the mass of the spacecraft, measured in kilograms
*   g: the intensity of the planet's gravity, measured in multiples of Earth's gravity

Gravity imparts the same acceleration on all objects regardless of size, so the force of gravity on an object is proportional to its mass. For a spacecraft to even budge from the surface at all, its thrusters must generate enough force to counteract the spacecraft's weight, then additional force to accelerate the spacecraft upwards. A spacecraft's ability (or inability) to do this is referred to as the spacecraft's "thrust-to-weight ratio", calculated as follows:

T:W = F / W

If the thrust-to-weight ratio is less than 1, the spacecraft will expend a great deal of force to go nowhere, and if it is precisely equal to one, then the spacecraft will hover on the launch pad until it eventually pitches over and crashes. However, if the thrust-to-weight ratio is greater than 1 (even by the smallest amount!), then the spacecraft will climb (or at least crawl) to the skies.

This makes our design objective both clear and measurable: create a spacecraft with a high enough thrust-to-weight ratio to lift itself off of the planet and into space.

## Gameplay Considerations

All of the above leaves out a very important question: a spacecraft with a thrust-to-weight ratio greater than 1 can make it to space, but how do we know when it actually gets there?

Fortunately, unlike real life, Space Engineers provides very simple answers to these questions: rather than meeting requirements for periapsis altitude and velocity, the game simply requires that you reach a certain altitude above a planet's surface. The specifics vary from planet to planet, but in general, the intensity of the planet's gravity field remains the same as on the planet's surface only up to a certain altitude above the planet's "sea level". Above that altitude, the gravity undergoes a rapid exponential decay until it tapers down to 0.05g. If the spacecraft continues above this altitude further, then rather than the gravity dropping to 0.04g, it disappears completely. The artificial horizon disappears, the altimeter blanks out, and the spacecraft is officially in space.

This has dramatic ramifications for a spacecraft's launch profile: if the gravity incident on a spacecraft decreases as it ascends, then its thrust-to-weight ratio increases with altitude. Moreover, since Space Engineers enforces a maximum speed on spacecraft, there will be time periods when it is possible, indeed preferable, to coast using inertia to conserve power or hydrogen. As gravity decreases, the spacecraft can spend less time using its thrusters and more time coasting, making its flight more efficient!

How high above the surface do these phenomena occur? This is a complicated question: giving a precise answer would involve digging into the planet files for each planet, and the altimeter reads altitude above a planet's surface, not above sea level. But if all an aspiring designer needs is a ballpark estimate, on the Earthlike planet (hereafter referred to as simply "Earth"), gravity disappears completely just shy of the 50 km altitude marker.

## Spacecraft Design

There are many ways to divide up the functional portions of a spacecraft when designing one, but the one used most often divides the spacecraft into three sections: the thrust section, which moves the spacecraft to where it needs to go; the payload section, which allows the spacecraft to perform its mission when it arrives at its destionation; and the structural section, which provides stability and protection to the spacecraft. To illustrate the concepts in designing a spacecraft, we will build a large grid spacecraft as an example, the _Sagittarius_, and launch it from Earth.

**Thrust Section**

While many clever designs have been made for all-electric spacecraft using a combination of atmospheric and ion thrusters (and at least one which added a gravity engine into the mix as well), the fact remains that for players trying to reach space for the first time, the only viable option is hydrogen thrusters. This is for several reasons:

*   From a thrust-to-weight perspective, hydrogen thrusters provide the greatest amount of thrust per kilogram of mass added to the spacecraft - from 7 to 10 times the newtons per kilogram provided by electric thrusters.
*   Atmospheric and ion engines are designed for use in specific environments, in a planet's atmosphere and in space respectively; using these engines in the wrong environment can either dramatically reduce their effectiveness in the case of ion engines, or cause them to stop working entirely in the case of atmospheric engines. Hydrogen engines, on the other hand, work effectively in both environments, generating the same thrust from launch to orbit.
*   Ion engines require thruster components to be built. These require platinum to be manufactured, which does not spawn on planets.

_Example:_

With the above in mind, we will build our thrust section around hydrogen. The _Sagittarius_'s thrust section will include two large hydrogen tanks, one large hydrogen thruster to lift the spacecraft into orbit, and five small hydrogen thrusters to allow us to stop and maneuver as needed once we get into orbit.

*   1 Large Hydrogen Tank
*   1 Large Hydrogen Thruster
*   5 Small Hydrogen Thrusters

Total mass: 22,201.6 kg

A big question is whether one large hydrogen thruster will provide enough thrust to lift the _Sagittarus_ off the launch pad, but since we're still building it, we don't have enough information to answer that question just yet. To find our answer, we'll simply note that a large hydrogen thruster generates up to 7,200,000 newtons of thrust, check that this is enough to lift the thrust section:

T:W = 7,200,000 N / (22,201.6 kg \* 1.00g \* 9.81 (m/s2)/g) = 7,200,000 N / 217,797.7 N = **33.1**

and move onto the next section.

**Payload Section**

If the goal was simply to launch the player themselves into space, we could simply strap a passenger seat to a stack of tanks and thrusters and lift off. However, that would be a very expensive endeavor which would accomplish next to nothing in gameplay terms. We want to go to space and we want to stay there, so our payload design must reflect that.

The bare minimum for a sustainable payload would allow the player to control the spacecraft, respawn in space, process stone to create building materials, and process ice to refill their suit's oxygen and hydrogen bottles, while also generating enough power to run all of these components. Most of these functions can be performed with a Survival Kit, which brings up a tip for new players: silver is very useful for making the medical components for a new survival kit if the launch goes badly, but if circumstances require an immediate launch, it is not strictly speaking vital. If the base is about to be overrun by enemies, it is occasionally smarter to dismantle the survival kit in your base and rebuild it on your ship. It means you only get one shot at doing the launch right, but sometimes that's better than no shot at all.

_Example:_

We could create a barebones payload that forces us to rebuild in space under the same austere conditions we experienced back on Earth, but why? If we're going into space, why not bring enough spare productive capacity to ensure we can immediately take advantage of the resources up there?

To that end, the _Sagittarius_ payload will include blocks which allow us to perform the minimum requirements stated above, and a bit more:

*   1 Cockpit
*   1 Gyroscope
*   1 Survival Kit
*   1 Oxygen Generator
*   1 Oxygen Tank
*   1 Small Cargo Container
*   2 Batteries
*   2 Solar Panels
*   1 Small Reactor
*   1 Refinery, no upgrades
*   1 Assembler, no upgrades
*   1 Connector
*   1 Beacon
*   1 Ore Detector

Total mass: 72,860.6 kg

By adding the full-sized refinery and assembler, we can refine platinum as soon as we find it and use it to make thruster components for ion engines. That would cut hydrogen consumption down dramatically, allowing the _Sagittarius_ to save its hydrogen for high-acceleration maneuvers or - if it is called for - planetary re-entry. It also allows us to immediately refine uranium, which will give the _Sagittarius_ plenty of power for those sunless nights when our solar panels shut down.

More ambitious players might swap out the cockpit for a custom-made bridge, well-lit and pressurized with an airlock to keep precious oxygen in. This makes sense on multiplayer servers, but for a single-player game, a cockpit provides the same functions for lower mass.

Since items in the small cargo container also contribute to the _Sagittarius_'s overall weight, we will also add in the following:

*   1 Oxygen Bottle
*   1 Hydrogen Bottle
*   1 Enhanced Welder
*   1 Enhanced Grinder
*   1 Enhanced Hand Drill
*   1 Precision Automatic Rifle
*   5 5.56mmx45mm NATO Magazines
*   1000 kg iron ingots
*   500 kg nickel ingots
*   500 kg ice
*   200 kg silicon wafers

Total mass: 2,295.25 kg

**Structure Section**

In real-world spacecraft, the structural section mostly refers to the trusses that hold components in place relative to one another. In Space Engineers, however, this also includes conveyor systems which allow gasses, minerals, ingots, and components to move from block to block. Crafty players can minimize the number of conveyor tubes by placing each block's conveyor port agains that of its neighbor, but less-experienced players or those with a certain aesthetic in mind might need to add a conveyor junction or a tube to connect everything in the ship together.

_Example:_

While we were able to connect the components of the payload and the thrust section together without using conveyor components, a bright idea occured to us as we were placing the connector: by adding a conveyor tube, we could lift the connector from the ship's hull, making it easier to dock with stations for trade without colliding: