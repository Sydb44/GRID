As with all thrusters it's recommended to create [control groups](https://spaceengineers.wiki.gg/wiki/Groups "Groups"), one for all RCS thrusters, and one for only the lift-off thrusters. This allows you to switch on/off different sets of thrusters when needed. For example, switch off the large thrusters while steering carefully close to asteroids in zero gravity, switch them on for takeoff, landing, and de/acceleration.

If you intend to fly horizontally in gravity, you must keep [Inertia Dampers](https://spaceengineers.wiki.gg/wiki/Inertial_Dampeners "Inertial Dampeners") on, but they waste fuel by engaging your braking thrusters (the fore thrusters) needlessly. Create a control group for your braking thrusters so that you can coast forwards with [Inertia Dampers](https://spaceengineers.wiki.gg/wiki/Inertial_Dampeners "Inertial Dampeners") switched on, and braking thrusters switched off. To brake, reenable the braking thruster group again!

### How to save fuel by using Thruster Overrides

Accelerating ("holding [W key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings")") and pushing against the artificial speed limit wastes hydrogen. When you configure your [Tool Bar](https://spaceengineers.wiki.gg/wiki/Tool_Bar "Tool Bar"), not only add on/off toggles for your thruster groups and Hydrogen Tank Stockpile, but also add **Increase** and **Decrease Thrust Override** controls for the lift-off thruster group. Instead of having to hold [W key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings") down the whole way, use these controls to increase and decrease constant thrust, like a throttle.

1.  Lift off and accelerate up manually by holding [W key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings").
2.  Once you hit the maximum speed of 100 m/s, let go of the key and tap **Increase Thrust Override** about a dozen times until you maintain that speed.
3.  When planetary gravity starts decreasing, carefully tap **Decrease Thrust Override** to back off the fuel usage while keeping your speed at 99 m/s.

At lower and lower gravity, less and less override is needed to maintain the escape velocity. In space, switch off the override and fly as usual using WASD keys (and Inertial Dampers).

### Pros and cons

The unique advantage of Hydrogen Thrusters is their consistent acceleration and strength and that they work equally well in space and in atmosphere, which makes them ideal for shuttles.

Their disadvantage is that they must be [conveyored](https://spaceengineers.wiki.gg/wiki/Conveyor_system "Conveyor system") to a large source of hydrogen. This forces you to add  [![Icon Block Hydrogen Tank.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Block_Hydrogen_Tank.png/21px-Icon_Block_Hydrogen_Tank.png?5afea3)](https://spaceengineers.wiki.gg/wiki/Hydrogen_Tank "Hydrogen Tank") [Hydrogen Tanks](https://spaceengineers.wiki.gg/wiki/Hydrogen_Tank "Hydrogen Tank") and (for anything but the smallest short-range shuttles) also  [![Icon Block O2 H2 Generator.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Block_O2_H2_Generator.png/21px-Icon_Block_O2_H2_Generator.png?60936f)](https://spaceengineers.wiki.gg/wiki/O2_H2_Generator "O2 H2 Generator") [O2/H2 Generators](https://spaceengineers.wiki.gg/wiki/O2_H2_Generator "O2 H2 Generator") filled with  [![Icon Item Ice.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Item_Ice.png/21px-Icon_Item_Ice.png?f8a728)](https://spaceengineers.wiki.gg/wiki/Ice "Ice") [Ice](https://spaceengineers.wiki.gg/wiki/Ice "Ice").

The extra mass, volume, and conveyor tubing that these peripherals add to a hydrogen-powered ship can diminish the returns. However, if you find the right balance, the above-average acceleration and versatility of the Hydrogen Thrusters makes up for the added complexity and volume.

As all thrusters, large hydrogen thrusters cause damage to blocks up to 6 blocks length in front of them, and small thrusters up to 3 blocks length.

### Hybrid usage

Pure Hydrogen ships work well in space and in the atmosphere, but require large tanks. For shuttles, it’s feasible to take advantage of both the efficiency of the atmospheric (or ion) thrusters _and_ the power-to-surface ratio of the hydrogen thrusters in one ship: Use atmospheric (or ion) thrusters as the "primary thrust", and treat the hydrogen thrusters as secondary "afterburner".

*   An Ion-Hydrogen hybrid shuttle operates mainly at orbital space stations and it sometimes takes passengers down to the near-by planet surface.
*   An Atmo-Hydrogen hybrid shuttle operates mainly at planetary stations and it sometimes takes passengers up to a near-by orbital space station.

This way, the secondary hydrogen thrusters would make do with a limited volume of fuel (with or without fuel regeneration via an onboard O2/H2 generator), used only for high-thrust-demand situations such as combat manoeuvres, escaping a planet's gravity well, or avoiding cratering on re-entry.

## Fuel Cost

|     |     |     |
| --- | --- | --- |Fuel Cost
| Hydrogen Thruster size | MN of thrust force | Hydrogen cost in L/s |
| --- | --- | --- |
| [Large-Grid Large Hydrogen Thruster](https://spaceengineers.wiki.gg/wiki/Large_Hydrogen_Thruster "Large Hydrogen Thruster") | 7.2 MN | 4,820.05 L/s |
| [Large-Grid Small Hydrogen Thruster](https://spaceengineers.wiki.gg/wiki/Hydrogen_Thruster "Hydrogen Thruster") | 1.08 MN | 803.34 L/s |
| [Small-Grid Large Hydrogen Thruster](https://spaceengineers.wiki.gg/wiki/Large_Hydrogen_Thruster "Large Hydrogen Thruster") | 480 kN | 385.60 L/s |
| [Small-Grid Small Hydrogen Thruster](https://spaceengineers.wiki.gg/wiki/Hydrogen_Thruster "Hydrogen Thruster") | 98.4 kN | 80.33 L/s |

The formula for the fuel cost is `FuelPerSec = <MaxPowerConsumption> / (Fuel_EnergyDensity * <Efficiency>)` where  

*   `<MaxPowerConsumption>` is the maximum power consumption of the thruster
*   `<Fuel_EnergyDensity>` is a constant of value 0.001556
*   `<Efficiency>` is the thruster block's fuel efficiency value (which is currently 1 for all thrusters)

  
For reference, 1 Newton (unit abbreviation 'N') is defined as the unit of force necessary to accelerate 1 kg of mass at 1 m/s^2. A planet with 1 G has an acceleration from gravity of 9.81 m/s^2. Thus 9.81 N of force is required to counter the gravity of 1 kg of grid mass against 1 G of gravitational acceleration (and, of course, more is needed to actually go \_up\_ and carry cargo). 1 kN is 1000 N, and 1 MN is 1000 kN (1,000,000 N).
