### Yield and conversion rate

The block produces Oxygen and Hydrogen independently of each other, that means the ice consumption from the table below **adds up** if it produces both. This means that ice is never "wasted", as the ratio of ice consumed to each gas produced is the same regardless of whether it is producing only one or both of the gases at once. However, the active power consumption of the unit is the same regardless of whether it is producing one or both gases, so running it to produce only one of the gases is somewhat less power efficient.

Each gas is only produced if there is a consumer for that gas, which includes gas tanks.

|     |     |     |
| --- | --- | --- |Production per second
| Size | Oxygen | Hydrogen |
| SmallGrid | 50L for 5kg of ice | 100L for 5kg of ice |
| LargeGrid | 250L for 25kg of ice | 500L for 25kg of ice |

The block however consumes ice every 5 seconds and there is a bug that gives the same amount of gas for lower amounts of ice: [Bug report](https://support.keenswh.com/spaceengineers/pc/topic/1kg-of-ice-produces-excessive-amounts-of-hydrogen-and-oxygen).

### Energy Use

The block converts  [![Icon Item Ice.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Item_Ice.png/21px-Icon_Item_Ice.png?f8a728)](https://spaceengineers.wiki.gg/wiki/Ice "Ice") [Ice](https://spaceengineers.wiki.gg/wiki/Ice "Ice") into [oxygen](https://spaceengineers.wiki.gg/wiki/Oxygen "Oxygen") and [hydrogen](https://spaceengineers.wiki.gg/wiki/Hydrogen "Hydrogen") gas while drawing electrical energy at 100 kW for the small-grid, or 500 kW for the large-grid variant, respectively, regardless of actual conversion rate.

When idle, both the large-grid and the small-grid variant draw energy at 1 kW.[\[1\]](#cite_note-1.197.064-1)

### Use in airtight rooms

If you have connected up an [Air Vent](https://spaceengineers.wiki.gg/wiki/Air_Vent "Air Vent") <-> [Oxygen Tank](https://spaceengineers.wiki.gg/wiki/Oxygen_Tank "Oxygen Tank") <-> [Conveyor system](https://spaceengineers.wiki.gg/wiki/Conveyor_system "Conveyor system") <-> O2/H2 Generator, the Generator will electrolyse ice until all [airtight rooms](https://spaceengineers.wiki.gg/wiki/Airtightness "Airtightness") are pressurized and all tanks are filled. If a [Hydrogen Tank](https://spaceengineers.wiki.gg/wiki/Hydrogen_Tank "Hydrogen Tank") is conveyored to the same Generator, ice will be electrolysed until the Hydrogen Tank is full as well. Hydrogen Tanks require vast amounts of Ice to fill completely (a large grid Small Hydrogen Tank requires 50'000 kg of ice to fill, and large tank requires 750'000 of ice), and filling them will use up Ice, even after all Oxygen Tanks have already been filled.

So if you're short on ice, it may be wise to keep the oxygen conveyor system and its generator separate from the hydrogen conveyor system and its generator, to ensure you always have ice available for pressurizing and refilling tanks, though efficient air lock design and buffer tanks can reduce the need for this substantially. The actual ice usage for oxygen is typically very small, as a single engineer requires a bit less oxygen per _hour_ than is produced by 23 kg of ice. A single filled large grid Small Oxygen Tank has enough oxygen in it (100'000 L) for a single engineer to survive for approximately 441 hours of gameplay, provided none of the oxygen is vented to space or otherwise lost.

### Use with Hydrogen Engines and Thrusters

Large grids:

*   The output of one O2/H2 Generator is enough to fully supply one [Hydrogen Engine](https://spaceengineers.wiki.gg/wiki/Hydrogen_Engine "Hydrogen Engine").
*   One [Large Hydrogen Thruster](https://spaceengineers.wiki.gg/wiki/Hydrogen_Thruster "Hydrogen Thruster") consumes 4820 L/s, requiring _ten_ O2/H2 Generators to run at full power.[\[2\]](#cite_note-1.198.027-2)
*   One regular Hydrogen Thruster consumes 803.31 L/s, requiring _two_ O2/H2 Generators.[\[2\]](#cite_note-1.198.027-2)

Small grids:

*   The output of one O2/H2 Generator is enough to fully supply _two_ Hydrogen Engines.[\[1\]](#cite_note-1.197.064-1)
*   One Large Hydrogen Thruster consumes 385.6 L/s, requiring _four_ O2/H2 Generators.[\[2\]](#cite_note-1.198.027-2)
*   One regular Hydrogen Thruster consumes 80.33 L/s, requiring _one_ O2/H2 Generator.[\[2\]](#cite_note-1.198.027-2)

## Trivia

This block used to be called Oxygen Generator and sometimes you still find it named that way in old blueprints.

## Construction

[![](https://spaceengineers.wiki.gg/images/thumb/Small-grid_vs_large-grid_o2_h2_generator.png/320px-Small-grid_vs_large-grid_o2_h2_generator.png?d31dea)](https://spaceengineers.wiki.gg/wiki/File:Small-grid_vs_large-grid_o2_h2_generator.png)

Small-grid vs large-grid O2/H2 Generator, showing conveyor port positions

Building a O2 H2 Generator is affordable early on as soon as you have access to  [![Icon Item Large Steel Tube.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Item_Large_Steel_Tube.png/21px-Icon_Item_Large_Steel_Tube.png?31c1e4)](https://spaceengineers.wiki.gg/wiki/Large_Steel_Tube "Large Steel Tube") [Large Steel Tube](https://spaceengineers.wiki.gg/wiki/Large_Steel_Tube "Large Steel Tube")s, either salvaged, or produced in any Assembler.

*   The large-grid variant is 1x1x2. It has four large conveyor ports, one on each of both 1x1 ends, as well as two on opposing 1x2 sides.
*   The small-grid variant is 3x3x2. It is similar in port layout to the small-grid oxygen tank, having two small conveyor ports on the same side (spaced one block away from each other), and one large one on the other side.

You need to plan ahead how to connect the block to the conveyor system before placing it. The gas and ice can be piped through small ports, but you will also be using this generator to refill gas bottles, which need large conveyor ports.

## Recipe

| [![Icon Block O2 H2 Generator.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Block_O2_H2_Generator.png/21px-Icon_Block_O2_H2_Generator.png?60936f)](https://spaceengineers.wiki.gg/wiki/O2_H2_Generator "O2 H2 Generator") O2 H2 Generator |     |     |     |     |
| --- | --- | --- | --- | --- |
| Component | Large Ship/Station  <br>Required | Large Ship/Station  <br>Optional | Small Ship  <br>Required | Small Ship  <br>Optional |
| [![Icon Item Steel Plate.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Item_Steel_Plate.png/21px-Icon_Item_Steel_Plate.png?437e3a)](https://spaceengineers.wiki.gg/wiki/Steel_Plate "Steel Plate") [Steel Plate](https://spaceengineers.wiki.gg/wiki/Steel_Plate "Steel Plate") | 110 | 10  | 6   | 2   |
| [![Icon Item Motor.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Item_Motor.png/21px-Icon_Item_Motor.png?4a2f3f)](https://spaceengineers.wiki.gg/wiki/Motor "Motor") [Motor](https://spaceengineers.wiki.gg/wiki/Motor "Motor") | 4   | —   | 1   | —   |
| [![Icon Item Large Steel Tube.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Item_Large_Steel_Tube.png/21px-Icon_Item_Large_Steel_Tube.png?31c1e4)](https://spaceengineers.wiki.gg/wiki/Large_Steel_Tube "Large Steel Tube") [Large Steel Tube](https://spaceengineers.wiki.gg/wiki/Large_Steel_Tube "Large Steel Tube") | 2   | —   | 2   | —   |
| [![Icon Item Construction Comp..png](https://spaceengineers.wiki.gg/images/thumb/Icon_Item_Construction_Comp..png/21px-Icon_Item_Construction_Comp..png?cdc26f)](https://spaceengineers.wiki.gg/wiki/Construction_Comp. "Construction Comp.") [Construction Comp.](https://spaceengineers.wiki.gg/wiki/Construction_Comp. "Construction Comp.") | 5   | —   | 8   | —   |
| [![Icon Item Computer.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Item_Computer.png/21px-Icon_Item_Computer.png?65c1a4)](https://spaceengineers.wiki.gg/wiki/Computer "Computer") [Computer](https://spaceengineers.wiki.gg/wiki/Computer "Computer") | 5   | —   | 3   | —   |
