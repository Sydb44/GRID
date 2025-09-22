---
title: "Physics"
url: "https://spaceengineers.wiki.gg/wiki/Physics"
category: "Mechanics"
wiki_page: "Physics"
includes_blocks: true
---

# Physics - Official Space Engineers Wiki

![](https://commons.wiki.gg/images/Ambox_banner_content.svg?b0ca34)

No text provided.

[![Physics.jpg](https://spaceengineers.wiki.gg/images/thumb/Physics.jpg/320px-Physics.jpg?a0c461)](https://spaceengineers.wiki.gg/wiki/File:Physics.jpg)

The physics discussed in this section reflect the real world.

If you are looking for game mechanics, see the [game mechanics category](https://spaceengineers.wiki.gg/wiki/Category:Game_mechanics "Category:Game mechanics"). The [thruster mechanics](https://spaceengineers.wiki.gg/wiki/Thruster_mechanics "Thruster mechanics") and [Gyroscope](https://spaceengineers.wiki.gg/wiki/Gyroscope "Gyroscope") mechanics discuss the areas in which those components don't reflect real-world physics.

## Work in Progress

This page will contain a series of physics lessons designed to teach the basics of real-world physics. As the box above says, there should also be references made wherever the game physics do not properly reflect what is written here.

For more information on this project, please contact DocTanner.

As with anything on a wiki, feel free to contribute! Improve existing sections, fill in missing sections, or add new ones. Empty sections should be marked with the {{[Stub](https://spaceengineers.wiki.gg/wiki/Template:Stub "Template:Stub")}} tag.

## Mass and Inertia

"_Inertial **mass** is a quantitative measure of an object's resistance to changes in [velocity](#Velocity)_" — [Wikipedia](https://en.wikipedia.org/wiki/Mass)

Depending on the context, mass can refer to several things. For our purposes, though, we'll be discussing **inertial mass**. For other definitions of mass, see the Wikipedia link above.

On Earth, mass and weight are roughly equivalent terms: one kilogram of mass weighs one kilogram at 1G. (G being the unit symbol for "Gravity", a measure of [force](#Force) where 1G is equal to the force of gravity on earth.) However, while weight varies based on gravity, mass remains constant.

In space, the most accurate definition of mass is resistance to [acceleration](#Acceleration). Essentially, the more mass an object has, the more force is needed to change it's velocity by some fixed amount. This property is called inertia.

"_**Inertia** is the resistance of any physical object to any change in its motion (including a change in direction). In other words, it is the tendency of objects to keep moving in a straight line at constant linear velocity._" — [Wikipedia](https://en.wikipedia.org/wiki/Inertia)

As you can see, there's not much difference between the definitions of mass and inertia. In fact, you can think of mass as simply the measure of inertia. While this isn't entirely accurate in all contexts, it works well enough for the purposes of this discussion.

Mass is measured in grams (g) but equations in physics generally use kilograms (kg) as the base unit. As with all other [SI units](https://en.wikipedia.org/wiki/SI_Units), "kilo" means one-thousand. So 1kg = 1000g. On earth, 1kg weights roughly 2.2lbs. However, it is important to remember that pounds are a measure of weight, not mass, and are not a useful measure in space.

Since we know from Newton's second law that the sum of all external forces, F, is equal to the mass multiplied by the acceleration, mass can be thought of as a proportionality constant between force and acceleration.

## Velocity

"_**Velocity** is the rate of change of the position of an object, equivalent to a specification of its speed and direction of motion, e.g. 60 km/h to the north._" — [Wikipedia](https://en.wikipedia.org/wiki/Velocity)

As Wikipedia's definition says, velocity is a [vector](https://spaceengineers.wiki.gg/wiki/Glossary#vector "Glossary") that refers to an object's speed and direction. The magnitude (number) of the vector refers to the rate of change, or speed, while the sign refers to relative direction.

Velocity, relative to position on a line, is determined with the following formula:

|     |     |
| --- | --- |
| v\=Δdt |     |
| _Where:_ |     |
| v   | : Velocity (km/s) |
| Δd  | : Change in position (km) |
| t   | : Time (s) |

### Units

How we measure velocity depends on where we are and what we are measuring. In the US, we usually measure [terrestrial](https://spaceengineers.wiki.gg/wiki/Glossary#terrestrial "Glossary") objects such as cars in miles-per-hour (mph or m/h). In other countries, terrestrial objects are measured in kilometers-per-hour (kph or km/h). For faster objects, such as spacecraft, we usually measure in kilometers-per-seconds (km/s).

In all cases, velocity is measured as distance over time. Specifically, it is the distance the object will travel in the given amount of time. So a car travelling at 60mph will change its position by 60 miles in a one hour period.

In Space Engineers, all velocities are measured in meters-per-second.

### Direction

If you are driving on the highway, your velocity might be 60mph. However, if you were backing into a parking space, you might be travelling at -5mph. This is because we tend to define a car's velocity in relation to the direction the car is facing.

Since velocity is a one-dimensional vector, it is sometimes useful to measure an objects movement using two separate velocities. For example, the speed of a plane is often measured as a combination of its linear speed (how fast it moves parallel to the ground) and its vertical speed (how fast it climbs or descends). So on take-off, a plane might have a linear velocity of 500mph while climbing at 100 feet-per-minute (fpm). The linear velocity determines how long it will take you to travel between airports on the ground while your vertical velocity determines how high you will be while travelling. While you could also measure its actual net velocity, this value isn't particularly useful in reference to objects on the ground.

For objects moving in three-dimensional space, it can even be useful to measure speed as three separate velocity vectors. This is a specific case, however, and somewhat beyond the needs of this page.
