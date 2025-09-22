How we measure velocity depends on where we are and what we are measuring. In the US, we usually measure [terrestrial](https://spaceengineers.wiki.gg/wiki/Glossary#terrestrial "Glossary") objects such as cars in miles-per-hour (mph or m/h). In other countries, terrestrial objects are measured in kilometers-per-hour (kph or km/h). For faster objects, such as spacecraft, we usually measure in kilometers-per-seconds (km/s).

In all cases, velocity is measured as distance over time. Specifically, it is the distance the object will travel in the given amount of time. So a car travelling at 60mph will change its position by 60 miles in a one hour period.

In Space Engineers, all velocities are measured in meters-per-second.

### Direction

If you are driving on the highway, your velocity might be 60mph. However, if you were backing into a parking space, you might be travelling at -5mph. This is because we tend to define a car's velocity in relation to the direction the car is facing.

Since velocity is a one-dimensional vector, it is sometimes useful to measure an objects movement using two separate velocities. For example, the speed of a plane is often measured as a combination of its linear speed (how fast it moves parallel to the ground) and its vertical speed (how fast it climbs or descends). So on take-off, a plane might have a linear velocity of 500mph while climbing at 100 feet-per-minute (fpm). The linear velocity determines how long it will take you to travel between airports on the ground while your vertical velocity determines how high you will be while travelling. While you could also measure its actual net velocity, this value isn't particularly useful in reference to objects on the ground.

For objects moving in three-dimensional space, it can even be useful to measure speed as three separate velocity vectors. This is a specific case, however, and somewhat beyond the needs of this page.

### Combining multiple vectors

![](https://spaceengineers.wiki.gg/images/thumb/Loading.png/48px-Loading.png?7bc3a9)

This article or section is a [stub](https://spaceengineers.wiki.gg/wiki/Category:Article_stubs "Category:Article stubs").

It needs more content. You can help Space Engineers Wiki by [expanding it](https://spaceengineers.wiki.gg/wiki/Physics?action=edit).

//missing: How to calculate results / interpret numbers. Pictures for clarification of the drawing process.

A vector contains two informations: a scalar (normal 1 dimensional number) and a direction. A scalar can be completely described by its value. The direction points somewhere without having a size. For example if you're running with 20km/h towards free beer the scalar would have the value of 20km/h while the direction would be towards the beer. Note that a vector only has a value and a direction. It does NOT have a positon. If you draw a coordinate system you can put it wherever you want as long as you keep its orientation and length. To draw a vector we can randomly choose a starting point. Now we look at the direction the vector is supposed to go and draw a straight line in that direction. Choose a scale (like 1cm on the paper equals the force of 100N). It must stay the same for all vectors within the same sheet. You now can calculate your vectors length. Cap the drawn line at that length.

So now we have multiple vectors, what do we do with them? First of we name them so we always now what vector we are dealing with. So the first vector becomes "vector a", the second "vector b" and so on. Second we will name the point a vector starts "base" and the point it ends "tip" just to make explaining easier. (Hint: It often is a good idea to put the base of one vector at (0,0) coordinates.) Now we have to figure out what kind of calculation we need to do. Thruster forces are normally added or substracted for example. We'll keep with those two operations, multiplikation and division with more than one vector is difficult if you didn't learn how to do it in school. If you need to multiply or divide with no more than one vector and one or more numbers you can take the length of your vector and treat it like any other number. The direction stays the same.

Addition: Vector a + vector b = vector c. Draw vector a on a coordinate system. Now take vector b and draw it in a way that the base of vector b is at the position of the tip of vector a. Then draw vector c, your result, from the base of vector a to the tip of vector b.

Substraction: Vector a - vector b = vector c. Draw the bases of vector a and b on the same point. Now draw vector c from the tip of vector b to the tip of vector a.

## Acceleration

"_Acceleration is the rate at which the velocity of a body changes with time._" — [Wikipedia](https://en.wikipedia.org/wiki/Acceleration)

Just as velocity is a change in position over time, acceleration is a change in velocity over time. Like velocity, it is also a vector. The equation for acceleration is very similar to the equation for velocity:

|     |     |
| --- | --- |
| a\=Δvt |     |
| Δv\=vf−fi |     |
| _Where:_ |     |
| a   | : Acceleration (km/s2) |
| Δv  | : Change in velocity (km/s) |
| t   | : Time (s) |
| vf  | : Final velocity (km/s) |
| vi  | : Initial velocity (km/s) |

### Units

Acceleration is always measured with the same time unit as the velocity it's based on. For example, if the object's velocity is measured in km/s, its acceleration would be measured in km/s2.

### Direction

The direction of acceleration is relative to the direction of the velocity. In laymans terms: if the velocity is increasing, the acceleration is positive; If the velocity is decreasing, the acceleration is negative.

For example, if your ship is travelling forwards, it's velocity is positive. So if you are speeding up, the acceleration is positive. If you are slowing down, the acceleration is negative. Similarly, if your ship is travelling backwards, the velocity is negative. So if you are speeding up, the acceleration is negative. If you are slowing down, the acceleration is positive.

If this sounds confusing, think about it this way: assume we're measuring velocity in km/s. So, acceleration is measured in km/s2. Every second, you should be able to add your velocity and the acceleration together to get your new velocity. If you know you're speeding up, but adding your velocity and acceleration and velocity together results in a smaller velocity, then you've got one of your signs wrong. (Keep in mind that "smaller" refers to magnitude, not value. For example, -10km/s is smaller than -20km/s.)
