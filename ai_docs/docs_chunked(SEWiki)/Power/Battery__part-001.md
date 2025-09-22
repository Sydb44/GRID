---
title: "Battery"
url: "https://spaceengineers.wiki.gg/wiki/Battery"
category: "Power"
wiki_page: "Battery"
includes_blocks: true
---

# Battery - Official Space Engineers Wiki

| Battery |     |
| --- | --- |
| [![Icon Block Battery.png](https://spaceengineers.wiki.gg/images/1/13/Icon_Block_Battery.png?fc3f6b)](https://spaceengineers.wiki.gg/wiki/File:Icon_Block_Battery.png) |     |
| * * * |     |
| **Function:** | A battery stores power and is able to distribute a high output of e... |
| **DLC?** | Vanilla |
| * * * |     |
| **Fits small grid** |     |
| Mass: | 1040.4 kg |
| Hitpoints: | 3652 |
| Power: | \-4 MW |
| PCU: | 15  |
| Size: | 3x2x3 |
| Time to Build: | 20 sec |
| * * * |     |
| **Fits large grid** |     |
| Mass: | 3845.0 kg |
| Hitpoints: | 12925 |
| Power: | \-12 MW |
| PCU: | 15  |
| Size: | 1x1x1 |
| Time to Build: | 40 sec |
| * * * |     |
| _Data Controls:_ | \[[purge](https://spaceengineers.wiki.gg/wiki/Battery?action=purge)\] ([?](https://spaceengineers.wiki.gg/wiki/Template:Info_Block))) |
|     |     |

The Battery is a functional block which stores [power](https://spaceengineers.wiki.gg/wiki/Power "Power") from [Reactors](https://spaceengineers.wiki.gg/wiki/Reactor "Reactor"), [Solar Panels](https://spaceengineers.wiki.gg/wiki/Solar_Panel "Solar Panel"), [Hydrogen Engines](https://spaceengineers.wiki.gg/wiki/Hydrogen_Engine "Hydrogen Engine"), and [Wind Turbines](https://spaceengineers.wiki.gg/wiki/Wind_Turbine "Wind Turbine") for later use. For related smaller block, see [Small Battery](https://spaceengineers.wiki.gg/wiki/Small_Battery "Small Battery").

The [Warfare Battery](https://spaceengineers.wiki.gg/wiki/Warfare_Battery "Warfare Battery") style variant has the same functionality and recipe as described here; you need to purchase the [Warfare 2 Pack](https://spaceengineers.wiki.gg/wiki/Warfare_2_Pack "Warfare 2 Pack") DLC to build it.

## Usage

You expected a battery to provide power, but your ship dropped like a rock? You expected the batteries to recharge after docking, but they didn't? Check your settings in the [Control Panel Screen](https://spaceengineers.wiki.gg/wiki/Control_Panel_Screen "Control Panel Screen").

Tip: Add the battery block's **Recharge On/Off** and **Discharge On/Off** actions to your Cockpit [toolbar](https://spaceengineers.wiki.gg/wiki/Toolbar "Toolbar"). The icon will display their status: Auto, Charge, or Drain.

### How to charge/discharge batteries

Open the [Control Panel Screen](https://spaceengineers.wiki.gg/wiki/Control_Panel_Screen "Control Panel Screen") to change the block's **Charge Mode**.

*   **Automatic**: The battery charges itself if there is excess power on the ship, and discharges (provides power) if a block needs it.
    *   This is the recommended default.
    *   Choose Automatic if your ship has several batteries to charge from Wind/Solar/Reactor or from a base.
*   **Recharge**: The battery actively draws power from other power sources including other batteries. The battery stops providing power.
    *   Use Recharge to drain another battery before dismantling it. Transfer of power between batteries is lossy!
    *   While recharging, make sure you're safely docked, because batteries on Recharge will not provide energy to thrusters.
    *   Enable Recharge to build up charge from Solar/Wind/Reactors in a backup battery.
*   **Discharge**: The battery provides power to other blocks and stops trying to recharge itself.
    *   Use this to drain a battery that you want to leave behind or dismantle.
    *   If there are several batteries on one ship, toggle Discharge to Auto to prevent them from drawing power _from each other_ (which is lossy).

### Battery Status Indicators

The battery will display its current mode and charge level.

#### Automatic Mode

| Indicator | Charge Level | Mode | Description |
| --- | --- | --- | --- |
| [![Solar off.svg](https://spaceengineers.wiki.gg/images/9/93/Solar_off.svg?e30b19)](https://spaceengineers.wiki.gg/wiki/File:Solar_off.svg) | NA  | Off | **Red indicators**: The Battery is turned off or damaged. |
| [![Indicator grey 4.svg](https://spaceengineers.wiki.gg/images/7/7a/Indicator_grey_4.svg?c2aea7)](https://spaceengineers.wiki.gg/wiki/File:Indicator_grey_4.svg) | 0-24% | Auto | **Grey indicator:** 0 green lights - The Battery is providing power and is charged between 0% to 24%. |
| [![Solar power 25.svg](https://spaceengineers.wiki.gg/images/3/32/Solar_power_25.svg?b5c414)](https://spaceengineers.wiki.gg/wiki/File:Solar_power_25.svg) | 25-49% | Auto | **Green indicator:** 1 green light - The Battery is providing power and is charged between 25% to 49%. |
| [![Solar power 50.svg](https://spaceengineers.wiki.gg/images/9/95/Solar_power_50.svg?4221c6)](https://spaceengineers.wiki.gg/wiki/File:Solar_power_50.svg) | 50-74% | Auto | **Green indicator:** 2 green lights - The Battery is providing power and is charged between 50% to 74%. |
| [![Solar power 75.svg](https://spaceengineers.wiki.gg/images/7/7c/Solar_power_75.svg?3efdd5)](https://spaceengineers.wiki.gg/wiki/File:Solar_power_75.svg) | 75-99% | Auto | **Green indicator:** 3 green lights - The Battery is providing power and is charged between 75% to 99%. |
| [![Solar power indicator 100.svg](https://spaceengineers.wiki.gg/images/c/c6/Solar_power_indicator_100.svg?d8898c)](https://spaceengineers.wiki.gg/wiki/File:Solar_power_indicator_100.svg) | 100% | Auto | **Green indicator:** 4 green lights - The Battery is providing power and is charged to 100%. |

#### Recharge Mode

| Indicator | Charge Level | Mode | Description |
| --- | --- | --- | --- |
| [![Solar off.svg](https://spaceengineers.wiki.gg/images/9/93/Solar_off.svg?e30b19)](https://spaceengineers.wiki.gg/wiki/File:Solar_off.svg) | NA  | Off | **Red indicators**: The Battery is turned off or damaged. |
| [![Indicator grey 4.svg](https://spaceengineers.wiki.gg/images/7/7a/Indicator_grey_4.svg?c2aea7)](https://spaceengineers.wiki.gg/wiki/File:Indicator_grey_4.svg) | 0-24% | Recharge | **Grey indicator:** 0 yellow lights - The Battery is charged between 0% to 24%. |
| [![Indicator yellow 1.svg](https://spaceengineers.wiki.gg/images/c/c2/Indicator_yellow_1.svg?c460a9)](https://spaceengineers.wiki.gg/wiki/File:Indicator_yellow_1.svg) | 25-49% | Recharge | **Yellow indicator:** 1 yellow light - The Battery is charged between 25% to 49%. |
| [![Indicator yellow 2.svg](https://spaceengineers.wiki.gg/images/3/3e/Indicator_yellow_2.svg?a8f00a)](https://spaceengineers.wiki.gg/wiki/File:Indicator_yellow_2.svg) | 50-74% | Recharge | **Yellow indicator:** 2 yellow lights - The Battery is charged between 50% to 74%. |
| [![Indicator yellow 3.svg](https://spaceengineers.wiki.gg/images/9/91/Indicator_yellow_3.svg?7eb167)](https://spaceengineers.wiki.gg/wiki/File:Indicator_yellow_3.svg) | 75-99% | Recharge | **Yellow indicator:** 3 yellow lights - The Battery is charged between 75% to 99%. |
| [![Indicator yellow 4.svg](https://spaceengineers.wiki.gg/images/e/e6/Indicator_yellow_4.svg?936f7b)](https://spaceengineers.wiki.gg/wiki/File:Indicator_yellow_4.svg) | 100% | Recharge | **Yellow indicator:** 4 yellow lights - The Battery is fully charged. |
