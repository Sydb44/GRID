
## What's my power usage?

[![The HUD element marked with a lightning bolt is your current power usage.](https://spaceengineers.wiki.gg/images/a/a3/HUD-power-in-use.png?6ad7dd)](https://spaceengineers.wiki.gg/wiki/File:HUD-power-in-use.png)

The HUD element marked with a lightning bolt is your current power _usage_, not the remaining charge.

While seated in a grid, your total **power usage** is shown in the bottom-right of the [HUD](https://spaceengineers.wiki.gg/wiki/HUD "HUD") in percent in the powerbar marked with a lightning bolt.

*   If the powerbar is empty, you are not exerting the ship (e.g. because it is docked or powered down).
*   If the powerbar always shows low values even at high exertion, you can remove some batteries/reactors and save weight.
*   If the powerbar fluctuates below 99%, you have just enough power for what you are doing, which is good.
*   If the powerbar fills up to 100% and turns red, your ship lacks the power to perform at the requested level: If this happens regularly, add another battery.

### Calculating You Power Production Needs

1.  Determine the total amount of power that your grid will need.
2.  Calculate the amount of fuel or power you will need from your power producing blocks.

#### Determine Total Amount of Power Needed

Determine the total amount of power that your grid is utilizing by going to the control panel:

*   Selecting your power production block(s) and looking at the current **output**.
*   You may want to add a buffer for increased power production based off your needs.

**Example:** If your large grid is currently using 13 MW of power and your power producers can produce 14.5 MW using a  [![Icon Block Small Reactor.png](https://spaceengineers.wiki.gg/images/thumb/2/23/Icon_Block_Small_Reactor.png/21px-Icon_Block_Small_Reactor.png?64124d)](https://spaceengineers.wiki.gg/wiki/Small_Reactor "Small Reactor") [Small Reactor](https://spaceengineers.wiki.gg/wiki/Small_Reactor "Small Reactor"), you may want to add an additional [battery](https://spaceengineers.wiki.gg/wiki/Battery "Battery"), [Hydrogen Engine](https://spaceengineers.wiki.gg/wiki/Hydrogen_Engine "Hydrogen Engine"), or other power producers to handle an increased load.

#### Calculate Fuel Consumption

The easiest way to calculate fuel consumption for power producers is to convert everything into **megawatt hours** (**MWh**). 1 MWh means that your power producers are consistently outputting 1 MW for an hour.

This is especially important for power generating blocks that consume fuel such as the  [![Icon Block Hydrogen Engine.png](https://spaceengineers.wiki.gg/images/thumb/3/34/Icon_Block_Hydrogen_Engine.png/21px-Icon_Block_Hydrogen_Engine.png?7bc9a7)](https://spaceengineers.wiki.gg/wiki/Hydrogen_Engine "Hydrogen Engine") [Hydrogen Engine](https://spaceengineers.wiki.gg/wiki/Hydrogen_Engine "Hydrogen Engine"),  [![Icon Block Small Reactor.png](https://spaceengineers.wiki.gg/images/thumb/2/23/Icon_Block_Small_Reactor.png/21px-Icon_Block_Small_Reactor.png?64124d)](https://spaceengineers.wiki.gg/wiki/Small_Reactor "Small Reactor") [Small Reactor](https://spaceengineers.wiki.gg/wiki/Small_Reactor "Small Reactor"),  [![Icon Block Large Reactor.png](https://spaceengineers.wiki.gg/images/thumb/1/1c/Icon_Block_Large_Reactor.png/21px-Icon_Block_Large_Reactor.png?f77bf9)](https://spaceengineers.wiki.gg/wiki/Large_Reactor "Large Reactor") [Large Reactor](https://spaceengineers.wiki.gg/wiki/Large_Reactor "Large Reactor"), or  [![Icon Block Prototech Fusion Reactor.png](https://spaceengineers.wiki.gg/images/thumb/1/17/Icon_Block_Prototech_Fusion_Reactor.png/21px-Icon_Block_Prototech_Fusion_Reactor.png?be3c42)](https://spaceengineers.wiki.gg/wiki/Prototech_Fusion_Reactor "Prototech Fusion Reactor") [Prototech Fusion Reactor](https://spaceengineers.wiki.gg/wiki/Prototech_Fusion_Reactor "Prototech Fusion Reactor").

If the **Output** power is given in **MW**, assume that is MW per second. **To convert to MWh** take the **MW** and multiply it by the number of seconds in an hour.

  
**Example:** Our Large Grid is running at **7.4 MW** consistently. How much hydrogen do we need to run it for the next 10 hours at this level? We are only using  [![Icon Block Hydrogen Engine.png](https://spaceengineers.wiki.gg/images/thumb/3/34/Icon_Block_Hydrogen_Engine.png/21px-Icon_Block_Hydrogen_Engine.png?7bc9a7)](https://spaceengineers.wiki.gg/wiki/Hydrogen_Engine "Hydrogen Engine") [Hydrogen Engine](https://spaceengineers.wiki.gg/wiki/Hydrogen_Engine "Hydrogen Engine") for power[\[1\]](#cite_note-Sarcasm-1).

First, let's look at how much hydrogen is needed to produce **1 MWh** with a hydrogen engine. From there, we can calculate the amount of hydrogen and engines we will need to run our grid.

If a Large Grid [hydrogen Engine](https://spaceengineers.wiki.gg/wiki/Hydrogen_Engine "Hydrogen Engine") consumes **500 L/s** of hydrogen to produce **5 MW**, then it will consume **100 L/s** to produce **1 MW**. To find out how much hydrogen we need to sustain our base, we need to figure out how much hydrogen is needed to produce **1 MWh**.

To find how many seconds are in 1 hour: 1hour⇒60secondsminute∙60minuteshour\=3,600secondshr

  
Now multiply the **seconds per hour** by the **fuel consumed per second**. In our example of 1MWh for a hydrogen engine, it would be:

3,600secondshr∙100L of hydrogenMW per second\=360,000L of hydrogenMWh

  
To produce **1 MWh** with a  [![Icon Block Hydrogen Engine.png](https://spaceengineers.wiki.gg/images/thumb/3/34/Icon_Block_Hydrogen_Engine.png/21px-Icon_Block_Hydrogen_Engine.png?7bc9a7)](https://spaceengineers.wiki.gg/wiki/Hydrogen_Engine "Hydrogen Engine") [Hydrogen Engine](https://spaceengineers.wiki.gg/wiki/Hydrogen_Engine "Hydrogen Engine"), we would need **360,000 L of hydrogen**.

  
From here you take the **MW** your base is consuming and multiply it by the fuel consumption calculation. Since our grid is running at **7.4 MW** and we want to run it for **10 hr** we will need:

360,000L of hydrogenMWh∙10hr∙7.4MW\=26,640,000 L of hydrogen

  
So we would need **26,640,000 L** of hydrogen to run our base at **7.4 MW** consitently for **10 hr**. Since Large Grid [Hydrogen Engines](https://spaceengineers.wiki.gg/wiki/Hydrogen_Engine "Hydrogen Engine") have a maximum output of **5 MW**, we would need **two hydrogen engines**.
