You can adjust the cuboid shape in three dimensions, that means that you can specifically target very flat or oblong areas as well.

The AoE is a squared cuboid measured in meters from the outside edges of the generator's collision box and can be set from 1 to 150m in width, height, and depth. A large ship/station block is 2.5m in all dimensions, so a gravity generator sitting in the middle of a 5x5 pad could be set to 5 meters to make the AoE match the pad exactly.

The width and depth are relative to which direction the control panel is facing; from the player's point of view standing in front of the control panel, width will be the left and right span of the AoE, and depth will be the front and back distance.

### What happens in Overlapping Areas of Effect?

The effects from several Gravity Generators adds up, and negative gravity values are subtracted and can even cancel each other out. Additional planetary [gravity](https://spaceengineers.wiki.gg/wiki/Gravity "Gravity") weakens the artifical effect, that's why Gravity Generators are mostly used only in space. When multiple AoEs overlap, game elements are subject to multiple forces at the same time. This effect can be purposefully exploited to create gravity-powered transportation, machinery, and even weaponry.

It’s equally important to adjust the areas of effect to a minimum so they don’t _accidentally_ overlap. For example when ships land on stations (or more generally, when a mobile grid with a gravity generator comes close to another grid with a gravity generator) and their AoEs inadvertently add up, players and objects will float or be pushed or pulled unexpectedly.

When the effects overlap, you obtain the vector that affects objects through [vector addition](https://en.wikipedia.org/wiki/Vector_addition#Addition_and_subtraction) ([Online Calculator](http://www.1728.org/vectors.htm)). The acceleration value can exceed 1.0 when they add up (or be lower than -1.0, respectively), and objects will be affected accordingly.

### What if I pull my own ship...?

Congrats, space engineer, you have invented the gravity drive! Build [Artificial Mass](https://spaceengineers.wiki.gg/wiki/Artificial_Mass "Artificial Mass") blocks and Gravity Generators on the same ship see what happens...

## Construction

Gravity Generators are 1x1x1 blocks in size and exist for large grid only. Place it in the _center_ of the intended area of effect. The areas of effect of several can overlap and add up or complement each other to affect custom shaped fields. The block has mount points on the bottom side only and has one terminal on the front side. It also works when placed upside down on the ceiling, since you can invert the direction.

The block needs to be powered to function. The power consumed by a generator depends upon the size and strength of its gravitational field that you configure. To save power, make the area of effect as small as possible.

## Recipe

| [![Icon Block Gravity Generator.png](https://spaceengineers.wiki.gg/images/thumb/f/f2/Icon_Block_Gravity_Generator.png/21px-Icon_Block_Gravity_Generator.png?9a1cf8)](https://spaceengineers.wiki.gg/wiki/Gravity_Generator "Gravity Generator") Gravity Generator |     |     |     |     |
| --- | --- | --- | --- | --- |
| Component | Large Ship/Station  <br>Required | Large Ship/Station  <br>Optional | Small Ship  <br>Required | Small Ship  <br>Optional |
| [![Icon Item Steel Plate.png](https://spaceengineers.wiki.gg/images/thumb/4/4c/Icon_Item_Steel_Plate.png/21px-Icon_Item_Steel_Plate.png?437e3a)](https://spaceengineers.wiki.gg/wiki/Steel_Plate "Steel Plate") [Steel Plate](https://spaceengineers.wiki.gg/wiki/Steel_Plate "Steel Plate") | 54  | 40  | —   | —   |
| [![Icon Item Motor.png](https://spaceengineers.wiki.gg/images/thumb/2/2c/Icon_Item_Motor.png/21px-Icon_Item_Motor.png?4a2f3f)](https://spaceengineers.wiki.gg/wiki/Motor "Motor") [Motor](https://spaceengineers.wiki.gg/wiki/Motor "Motor") | 6   | —   | —   | —   |
| [![Icon Item Large Steel Tube.png](https://spaceengineers.wiki.gg/images/thumb/f/fe/Icon_Item_Large_Steel_Tube.png/21px-Icon_Item_Large_Steel_Tube.png?31c1e4)](https://spaceengineers.wiki.gg/wiki/Large_Steel_Tube "Large Steel Tube") [Large Steel Tube](https://spaceengineers.wiki.gg/wiki/Large_Steel_Tube "Large Steel Tube") | 4   | —   | —   | —   |
| [![Icon Item Gravity Comp..png](https://spaceengineers.wiki.gg/images/thumb/c/c7/Icon_Item_Gravity_Comp..png/21px-Icon_Item_Gravity_Comp..png?191808)](https://spaceengineers.wiki.gg/wiki/Gravity_Comp. "Gravity Comp.") [Gravity Comp.](https://spaceengineers.wiki.gg/wiki/Gravity_Comp. "Gravity Comp.") | 6   | —   | —   | —   |
| [![Icon Item Construction Comp..png](https://spaceengineers.wiki.gg/images/thumb/4/45/Icon_Item_Construction_Comp..png/21px-Icon_Item_Construction_Comp..png?cdc26f)](https://spaceengineers.wiki.gg/wiki/Construction_Comp. "Construction Comp.") [Construction Comp.](https://spaceengineers.wiki.gg/wiki/Construction_Comp. "Construction Comp.") | 60  | —   | —   | —   |
| [![Icon Item Computer.png](https://spaceengineers.wiki.gg/images/thumb/7/72/Icon_Item_Computer.png/21px-Icon_Item_Computer.png?65c1a4)](https://spaceengineers.wiki.gg/wiki/Computer "Computer") [Computer](https://spaceengineers.wiki.gg/wiki/Computer "Computer") | 40  | —   | —   | —   |