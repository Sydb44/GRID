---
title: "How to build runway lights"
url: "https://spaceengineers.wiki.gg/wiki/How_to_build_runway_lights"
category: "Utility"
wiki_page: "How to build runway lights"
includes_blocks: true
---

# How to build runway lights

## Navigation menu

### Search

(#searchInput)

Have you ever build a landing platform and noticed that it is hard to see in the dark? You need blinking runway lights!

## Requirements

To build this you obviously need to build a flat/long platform that is [powered](https://spaceengineers.wiki.gg/wiki/Power "Power"). Build a series of  [![Icon Block Interior Light.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Block_Interior_Light.png/21px-Icon_Block_Interior_Light.png?1abc4b)](https://spaceengineers.wiki.gg/wiki/Interior_Light "Interior Light") [Interior Light](https://spaceengineers.wiki.gg/wiki/Interior_Light "Interior Light")s on it to mark the landing strip.

## Set up the lights

Next, coordinate the blink settings on the series of [Interior Lights](https://spaceengineers.wiki.gg/wiki/Interior_Light "Interior Light") to blink one after the other.

1.  Build a series of lights, in this example, we build five.
2.  Set the **Blink Interval** to the _same_ value for all lights:
    *   We want the loop to last, for example, 2.5 seconds.
3.  Set the **Blink Length** to the _same_ percentage for all lights:
    *   For 5 lights, 100% divided by 5 equals 20%. So set them all to 20%.
    *   For _x_ lights, calculate 100/_x_.
4.  Set the **Blink Offset** to a _different_ percentage for each runway light:
    *   For 5 lights, set them to 20, 40, 60, 80, 100.
    *   For _x_ lights, set the _n_th light's value to _n_\*100/_x_.

## Example

|     |     |     |     |     |     |
| --- | --- | --- | --- | --- | --- |Example values for a series of 5 lights:
|     | Light 1 | Light 2 | Light 3 | Light 4 | Light 5 |
| Blink Interval | 2.5 sec | 2.5 sec | 2.5 sec | 2.5 sec | 2.5 sec |
| Blink Length | 20% | 20% | 20% | 20% | 20% |
| Blink Offset | 20% | 40% | 60% | 80% | 100% |

Tip: [CTRL key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings")\-click sliders to enter a specific value!

## How to continue from here

As long as you don't change the number of lights, leave the **Blink Offset** and **Blink Length** as it is from now on.

*   If the blinking is too slow, decrease the **Blink Interval** for all lights to the same value.
*   If the blinking is too fast, increase the **Blink Interval** for all lights to the same value.

If you change the number of lights, leave the **Blink Interval**, and update all **Blink Offset**s and **Blink Length**s according to the formulae given above.