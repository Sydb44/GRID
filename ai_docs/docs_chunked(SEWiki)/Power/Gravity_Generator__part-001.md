---
title: "Gravity Generator"
url: "https://spaceengineers.wiki.gg/wiki/Gravity_Generator"
category: "Power"
wiki_page: "Gravity Generator"
includes_blocks: true
---

# Gravity Generator - Official Space Engineers Wiki

| Gravity Generator |     |
| --- | --- |
| [![Icon Block Gravity Generator.png](https://spaceengineers.wiki.gg/images/f/f2/Icon_Block_Gravity_Generator.png?9a1cf8)](https://spaceengineers.wiki.gg/wiki/File:Icon_Block_Gravity_Generator.png) |     |
| * * * |     |
| **Function:** | Gravity generators create configurable artificial gravity fields th... |
| **DLC?** | Vanilla |
| * * * |     |
| **Fits large grid** |     |
| Mass: | 8532.0 kg |
| Hitpoints: | 20320 |
| Power: | \-0.56713 MW |
| PCU: | 185 |
| Size: | 1x1x1 |
| Time to Build: | 50 sec |
| * * * |     |
| _Data Controls:_ | \[[purge](https://spaceengineers.wiki.gg/wiki/Gravity_Generator?action=purge)\] ([?](https://spaceengineers.wiki.gg/wiki/Template:Info_Block))) |
|     |     |

The  [![Icon Block Gravity Generator.png](https://spaceengineers.wiki.gg/images/thumb/f/f2/Icon_Block_Gravity_Generator.png/21px-Icon_Block_Gravity_Generator.png?9a1cf8)](https://spaceengineers.wiki.gg/wiki/Gravity_Generator "Gravity Generator") Gravity Generator is an endgame [block](https://spaceengineers.wiki.gg/wiki/Block "Block") that you can add to large-grid ships and stations to provide artificial gravity, so that players can turn off their jetpacks in zero gravity and walk to conserve hydrogen fuel. Walking in artificial gravity is also more intuitive than walking with [Magnetic Boots](https://spaceengineers.wiki.gg/wiki/Magnetic_Boots "Magnetic Boots"). More creative advanced constructions enable you to push, pull, grapple, or accelerate floating items, or even whole ships!

## Usage

Using the [Control Panel Screen](https://spaceengineers.wiki.gg/wiki/Control_Panel_Screen "Control Panel Screen") from the [cockpit](https://spaceengineers.wiki.gg/wiki/Cockpit "Cockpit") of the ship or station, or through the control panel on the gravity generator itself, you adjust the strength and direction of the gravity effect and the size of its area of effect.

For inspiration, see also [Creative uses of Artificial Gravity](https://spaceengineers.wiki.gg/wiki/Creative_uses_of_Artificial_Gravity "Creative uses of Artificial Gravity").

### Conditions

Although termed a "Gravity Generator", the device has a number of properties that go against conventional terrestrial wisdom about [gravity](https://spaceengineers.wiki.gg/wiki/Gravity "Gravity") that the real-life physics-aware novice players would use.

Gravity Generators affect only:

*   Players who have their [jetpack](https://spaceengineers.wiki.gg/wiki/Jetpack "Jetpack") switched off
*   Floating items (mined ores, tools, dropped components, etc.)
*   Rovers and ships with [Artificial Mass](https://spaceengineers.wiki.gg/wiki/Artificial_Mass "Artificial Mass") blocks

Important Tip: This means, when using gravity generators to _accelerate_ something, make sure to keep your jetpack turned on before you enter the affected area, or you are in for a very fast trip to the respawn screen.

### How to set up direction and intensity?

Possible intensity values range from 0 G (no artificial gravity) up to 1 G, which is the same as Earth gravity at sea level. The generator can also be set to -1 G, pushing players and objects "up" instead, relative to the generator’s orientation.

The direction does not flip below the base of the block and (unintuitively) stays the same throughout the cuboid area of effect. Positive gravity is always applied towards the base of the generator (that’s "down" from the point of view of a walking player that is looking at a generator that’s sitting on the floor). Negative gravity is applied upwards.

Tip: If you want gravity to flip at a focal point and be _centered_ on the generator, use a [Spherical Gravity Generator](https://spaceengineers.wiki.gg/wiki/Spherical_Gravity_Generator "Spherical Gravity Generator") instead.

### How to set up the area of effect?

The Gravity Generator’s area of affect (AoE) is cuboid (see [Spherical Gravity Generator](https://spaceengineers.wiki.gg/wiki/Spherical_Gravity_Generator "Spherical Gravity Generator") for an alternative). To see the AoE highlighted on the [HUD](https://spaceengineers.wiki.gg/wiki/HUD "HUD"), enable the **Show on HUD** setting for the generator, and then enable **Show gravity range** on the [Info Screen](https://spaceengineers.wiki.gg/wiki/Info_Screen "Info Screen").

You can adjust the cuboid shape in three dimensions, that means that you can specifically target very flat or oblong areas as well.

The AoE is a squared cuboid measured in meters from the outside edges of the generator's collision box and can be set from 1 to 150m in width, height, and depth. A large ship/station block is 2.5m in all dimensions, so a gravity generator sitting in the middle of a 5x5 pad could be set to 5 meters to make the AoE match the pad exactly.

The width and depth are relative to which direction the control panel is facing; from the player's point of view standing in front of the control panel, width will be the left and right span of the AoE, and depth will be the front and back distance.

### What happens in Overlapping Areas of Effect?

The effects from several Gravity Generators adds up, and negative gravity values are subtracted and can even cancel each other out. Additional planetary [gravity](https://spaceengineers.wiki.gg/wiki/Gravity "Gravity") weakens the artifical effect, that's why Gravity Generators are mostly used only in space. When multiple AoEs overlap, game elements are subject to multiple forces at the same time. This effect can be purposefully exploited to create gravity-powered transportation, machinery, and even weaponry.

It’s equally important to adjust the areas of effect to a minimum so they don’t _accidentally_ overlap. For example when ships land on stations (or more generally, when a mobile grid with a gravity generator comes close to another grid with a gravity generator) and their AoEs inadvertently add up, players and objects will float or be pushed or pulled unexpectedly.

When the effects overlap, you obtain the vector that affects objects through [vector addition](https://en.wikipedia.org/wiki/Vector_addition#Addition_and_subtraction) ([Online Calculator](http://www.1728.org/vectors.htm)). The acceleration value can exceed 1.0 when they add up (or be lower than -1.0, respectively), and objects will be affected accordingly.
