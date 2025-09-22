---
title: "Weather"
url: "https://spaceengineers.wiki.gg/wiki/Weather"
category: "General"
wiki_page: "Weather"
includes_environment: true
includes_blocks: true
---

# Weather - Official Space Engineers Wiki

The [Planets](https://spaceengineers.wiki.gg/wiki/Planets "Planets") in Space Engineers have different atmospheric conditions and weather that have an impact on players. For example, it can rain, snow, or storm, depending on which planet you are on.

You can enable or disable weather in the [World Settings](https://spaceengineers.wiki.gg/wiki/World_Settings "World Settings"). Admins can change the weather in-game from the [Admin Screen](https://spaceengineers.wiki.gg/wiki/Admin_Screen "Admin Screen"). ([Meteors](https://spaceengineers.wiki.gg/wiki/Meteor "Meteor") are handled separately.)

**Tip:** Set up an [LCD Panel screen](https://spaceengineers.wiki.gg/wiki/LCD_Panels "LCD Panels") to display the "Weather" script. The status will switch to the next incoming weather before players can detect it themselves, serving as a weather forecast.

For beginners, it is recommended to disable weather until they get the hang of the base game without being disrupted by lightning strikes.

## Weather Impact

Weather has an impact on various game elements:

*   **Player health** — Toxic fog and extreme storms drain the [life support systems](https://spaceengineers.wiki.gg/wiki/Life_Support "Life Support") of the engineer's spacesuit, which has to stabilize oxygen levels and temperature. Lightning can strike and lower the player's health as well.
*   **Visibility** — While traveling, sand and dust storms prevent you from seeing obstacles such as mountains or cliffs.
*   **[Power](https://spaceengineers.wiki.gg/wiki/Power "Power") production** — Wind mills produce more power during storms and less during fog. Solar panels produce more power when it's clear than during sandstorms.
*   **Damage** — Lightning damages functional blocks and the blocks around them. Without a [lightning rod](https://spaceengineers.wiki.gg/wiki/Decoy "Decoy"), functional blocks or non-Admin players will be struck, even underground.
*   **Oxygen** — Some types of weather will lower the amount of oxygen in the air. This can make it temporarily not possible to breathe on planets such as the [Alien planet](https://spaceengineers.wiki.gg/wiki/Alien_planet "Alien planet") and [Pertam](https://spaceengineers.wiki.gg/wiki/Pertam "Pertam") with your helmet open.

## Weather Types

There is rain, thunderstorm, snow, sandstorm, electrical storm, fog. Each weather can exist in a light and heavy variant. Otherwise, the default weather is "Clear".

Extreme weather types can damage players and [crops](https://spaceengineers.wiki.gg/wiki/Farming "Farming").

*   Sandstorms decrease breathability and cause heat damage and debris impacts.
*   Electric sandstorms on Pertam are the worst, with added lightning and radiation damage.
*   Hail storms causes freezing damage and debris impacts.
*   Storms on the Alien planet cause damage, especially caustic rain.
*   Toxic haze causes suffocation, radiation and cold damage, and in heavy haze there's even lightning.

Oxygen levels can be high or low in different areas of a planet: For example, Pertam and Triton have only a bit of oxygen in valleys and low plains, while the Moon has no atmosphere (and hence no weather) at all.

[![storm screenshot](https://spaceengineers.wiki.gg/images/thumb/Weather-ship-racing-a_-storm.png/500px-Weather-ship-racing-a_-storm.png?f4f71c)](https://spaceengineers.wiki.gg/wiki/File:Weather-ship-racing-a_-storm.png)

An atmo ship on a desert planet racing a storm

## Protecting yourself

You can protect yourself from damage by going into [airtight pressurised spaces](https://spaceengineers.wiki.gg/wiki/Airtightness "Airtightness"), such as cockpits, bases, rovers, space stations, or spaceships. Closing your helmet helps against the green fog.

Trees, [Decoys](https://spaceengineers.wiki.gg/wiki/Decoy "Decoy"), and [antennas](https://spaceengineers.wiki.gg/wiki/Antenna "Antenna") attract lightning. Trees protect a radius of 20m [\[1\]](#cite_note-1) but they get destroyed by it. Decoys protect a radius of 50m [\[2\]](#cite_note-2), and Antennas only protect a radius of less than 10 metres. Decoys on static main grids function as lightning rods (optimally paired with a [block welder](https://spaceengineers.wiki.gg/wiki/Welder_Block "Welder Block") to repair the lightning damage automatically).[\[3\]](#cite_note-3)

If the oxygen level is too low to breath,e but isn't none, use [Air Vents](https://spaceengineers.wiki.gg/wiki/Air_Vent "Air Vent") on depressurize mode to collect oxygen from the atmosphere into a tank or cockpit. This allows your survival kit to refill your suit oxygen supply without needing to use up ice in an O2/H2 Generator.

## Weather on Planets

The probability for various weather types depends on the planet. Weather also influences which source of power generation is best for a planet, and where you should build your base (hint: not in toxic fog).

|     |     |     |     |     |     |     |     |     |     |     |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |Weather on different planets
| Weather: | Rain<br><br>(harmless) | Thunderstorm<br><br>(lightning) | Snow<br><br>(low wind, cold) | Sandstorm / Dust<br><br>(low sun) | Electrical Storm<br><br>(low sun, lightning) | Fog<br><br>(low wind, sometimes toxic) | Extreme Heat / Heat Wave | High / Low Winds | Extreme Cold / Cold Front | Hailstorm |
| Earthlike | yes, except deserts and icy regions | yes, except deserts and icy regions | yes, on poles and mountains | yes, in deserts | no  | yes, except deserts<br><br>non-toxic | yes | yes | yes | yes |
| Mars | no  | rarely | rare, on poles | very common | no  | no  | no  | yes | yes | yes |
| Alien | yes, except icy regions | yes, except icy regions | rare, in icy regions | yes, in deserts | no  | yes, toxic fog | yes | yes |     | yes |
| Pertam | no  | no  | no  | yes | yes | no  | yes | yes | no  | no  |
| Triton | no  | no  | very common | no  | no  | yes, in plains<br><br>non-toxic | no  | yes | yes | yes |
| Europa | no  | no  | very common | no  | no  | no  | no  | no  | yes | no  |
| Titan | yes | yes | no  | yes, except lakes | no  | yes, toxic fog | no  | yes | no  | yes |
| Moon | no  | no  | no  | no  | no  | no  | no  | no  | no  | no  |

*   ["Rules of Nature! Advanced lightning guide (1.200.032)" by Merii](https://steamcommunity.com/sharedfiles/filedetails/?id=2455290181)
*   ["Official Survival Guide: Weather (1.195)" by Jakaria](https://steamcommunity.com/sharedfiles/filedetails/?id=2139821766)

1.  [↑](#cite_ref-1 "Jump up") Hardcoded in `MySectorWeatherComponent.ProcessDecoys()`
2.  [↑](#cite_ref-2 "Jump up") Minimum of 50m in `MySectorWeatherComponent.ProcessDecoys()`
3.  [↑](#cite_ref-3 "Jump up") [https://steamcommunity.com/sharedfiles/filedetails/?id=2455290181](https://steamcommunity.com/sharedfiles/filedetails/?id=2455290181)