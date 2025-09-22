| [Large-Grid Large Hydrogen Thruster](https://spaceengineers.wiki.gg/wiki/Large_Hydrogen_Thruster "Large Hydrogen Thruster") | 7.2 MN | 4,820.05 L/s |
| [Large-Grid Small Hydrogen Thruster](https://spaceengineers.wiki.gg/wiki/Hydrogen_Thruster "Hydrogen Thruster") | 1.08 MN | 803.34 L/s |
| [Small-Grid Large Hydrogen Thruster](https://spaceengineers.wiki.gg/wiki/Large_Hydrogen_Thruster "Large Hydrogen Thruster") | 480 kN | 385.60 L/s |
| [Small-Grid Small Hydrogen Thruster](https://spaceengineers.wiki.gg/wiki/Hydrogen_Thruster "Hydrogen Thruster") | 98.4 kN | 80.33 L/s |

The formula for the fuel cost is `FuelPerSec = <MaxPowerConsumption> / (Fuel_EnergyDensity * <Efficiency>)` where  

*   `<MaxPowerConsumption>` is the maximum power consumption of the thruster
*   `<Fuel_EnergyDensity>` is a constant of value 0.001556
*   `<Efficiency>` is the thruster block's fuel efficiency value (which is currently 1 for all thrusters)

  
For reference, 1 Newton (unit abbreviation 'N') is defined as the unit of force necessary to accelerate 1 kg of mass at 1 m/s^2. A planet with 1 G has an acceleration from gravity of 9.81 m/s^2. Thus 9.81 N of force is required to counter the gravity of 1 kg of grid mass against 1 G of gravitational acceleration (and, of course, more is needed to actually go \_up\_ and carry cargo). 1 kN is 1000 N, and 1 MN is 1000 kN (1,000,000 N).

## Thrust per Volume

|     |     |     |     |
| --- | --- | --- | --- |thrust per volume
| hydrogen thruster size | kN of thrust per L/s of hydrogen | kN of thrust per block (3x3x3) | thrust per thruster-face block area (3x3) |
| --- | --- | --- | --- |
| Large-Grid Large Hydrogen Thruster | 1.4934 kN | 266.67 kN | 800.00 kN |
| Large-Grid Small Hydrogen Thruster | 1.3440 kN | 1,080.00 kN | 1,080.00 kN |
| Small-Grid Large Hydrogen Thruster | 1.2245 kN | 17.78 kN | 53.33 kN |
| Small-Grid Small Hydrogen Thruster | 1.2246 kN | 98.4 kN | 94.4 kN |

As you know, the block sizes for the small grid thrusters are 1/5th the size, in each dimension, as the large grid blocks. Thus a Small-Grid Large Thruster has an equivalent of 6,666.25 kN per large block (17.78 \* 5^3), and 1,333.325 kN per large block thruster face. It is, however, typically impractical to attempt to use small-grid thrusters on a large grid.

The small thrusters in each grid size are noticeably superior in thrust per volume and thrust per thruster-face block surface. The latter is an important consideration because, while a large thruster requires 27 blocks of volume (3x3x3), it can typically only be replaced by 9 small thrusters due to thrusters damaging blocks in their thrust path. Both small thrusters _are_ still superior in thrust-per-surface-area compared to the same-grid-size large thruster, however, which means that replacing a large thruster with even only 9 small thrusters will improve total thrust. Note, however, that the large grid small thruster is 10% less efficient on fuel than the large grid large thruster (the small grid ones are nearly equal to each other).

## Material Costs

It's also worth considering that a small thruster is more expensive and weighs more for its volume than a large thruster.

*   In large grid, 1 large thruster's worth of materials is worth 6 small thrusters on Steel Plates, 3.75 small thrusters on Construction Components, 6.25 small thrusters worth of Metal Grids, and 5 small thrusters worth of Large Steel Tubes.
*   In small grid, the ratios for large to small on materials are 4.29 in Steel Plates, 2 in Construction Components, 5.5 on Metal Grids, and 5 on Large steel Tubes.

As a result, 9 small thrusters both cost more materials and _weigh more_ (since block mass is the sum of the mass of the components required to build it) than a single large thruster. Combined with the fuel efficiency disadvantage, this means that in particular the large grid small hydrogen thruster is quite a bit less useful compared to the large grid large. In small grid, the direct fuel efficiencies are effectively equal, so the weight is the only difference on fuel efficiency.

## Comparison to Other Thruster Types: Power

While hydrogen thrusters provide the best option in the game currently for thrust-per-volume and thrust-per-surface-area, as well as the only thrust option that works equally well in and out of atmospheres, both atmospheric and ion thrusters can be compared against other thrusters when their electricity is supplied by the [Hydrogen Engine](https://spaceengineers.wiki.gg/wiki/Hydrogen_Engine "Hydrogen Engine"), which produces 10 kW of power per L/s of Hydrogen.

*   For ion thrusters, the thrust per MW of power varies from 128.57 for the large-grid Large to 72 for the small-grid Large and Small (they have equal efficiency).
*   For atmospheric thrusters, the thrust per MW varies from 385.71 for the large-grid Large to 160 for the small-grid Small.
*   At 1 MW = 100 L/s, hydrogen thrusters vary from 122.59 kN per MW equivalent (SG small), to 149.38 per MW equivalent (LG large).

This means that ion thrusters are around as efficient on H2 as hydrogen thrusters, and atmospheric thrusters up to 2.5 times as efficient -- but remember, their efficiency degrades with altitude!

## Comparison to Other Thruster Types: Volume

Hydrogen thrusters themselves are quite a bit more space-efficient, in terms of thrust-per-block-volume and thrust-per-surface-area compared to the other two options, especially if one needs to combine both ion and atmospheric for a craft that can operate both in and out of atmosphere. However, hydrogen _storage_ is substantially _less_ space-efficient than electrical energy storage.

For example, a small-grid large hydrogen tank, which is 3x3 (27 blocks of volume), has a capacity of 160 kL of hydrogen. This is equivalent to 0.444 kWh of energy storage when run through the hydrogen engine (10 kW-seconds per litre), or 0.01646 kWh per block. Meanwhile, a small-grid large battery, which is 3x2x3 (18 blocks of volume) can store 1 MWh of power, or 55.5 kWh per block, 3375 times as much energy density as a tank of hydrogen. And note that that's comparing them using the hydrogen engine, hydrogen thrusters are 5 to 25 times _less_ efficient, depending on the thruster alternative being considered. The lack of storage density means that _most_ hydrogen-driven craft must also have an O2/H2 generator on board (or multiple), and the ice to fuel them, increasing mass and decreasing the net thrust advantage. This issue is compounded by the need to run conveyers to all of the thrusters, while electric thrusters merely have to be attached to the grid (how much of a block space cost this is depends on the layout of the craft and any other reasons, such as weapons, that one might need to be running conveyors throughout).

As an example, two small-grid large hydrogen tanks attached to a single large hydrogen thruster requires a total volume of 81 blocks (3x3x9). The tanks have a total capacity of 320 kL, which can fuel the single large hydrogen thruster for 830 seconds of thrust, or ~13.83 minutes. Two small-grid large batteries and a single small-grid large atmospheric thruster, which occupies the same volume of 3x3x9, have a total battery capacity of 2 MWh, or 7200 MW-seconds of energy. That can fuel the single large atmospheric thruster for 3000 seconds, or 50 minutes, while providing 20% more thrust (576 kN from the large atmospheric thruster, versus 480 kN from the large hydrogen).

To minimize the extra internal volume required to run conveyors for the hydrogen thrusters, a common arrangement is to mount large hydrogen thrusters directly onto large hydrogen tanks, though one still needs a method of filling those tanks (either on-board, using an O2/H2 generator, or from an external ship/base via a Connector).
