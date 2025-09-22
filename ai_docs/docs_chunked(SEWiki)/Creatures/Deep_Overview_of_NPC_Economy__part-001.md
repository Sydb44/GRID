---
title: "Deep Overview of NPC Economy"
url: "https://spaceengineers.wiki.gg/wiki/Deep_Overview_of_NPC_Economy"
category: "Creatures"
wiki_page: "Deep Overview of NPC Economy"
includes_blocks: true
---

# Deep Overview of NPC Economy

Prices for Ores, Ingots, Prefabs, Components or Gasses and more in [NPC Store Blocks](https://spaceengineers.wiki.gg/wiki/Store "Store") are calculated by the game on the world start and on certain player actions. They take into account the multipliers you set in different modding files, as well as certain variables hard-coded into the game.

## 

General Price Calculation Concepts

[

(Back to top)

](#toc)

### Economy Items and their Active States

The NPC Store Block allows players to either **Buy** or **Sell** certain items or goods to NPC Factions. And while for player the tabs are called according to their perspective, in the code the names of those tabs are called in reverse - from trader's perspective. As such, the **Buy** tab is called behind **Offer** operations, and **Sell** tab - behind **Order** operations. Within those operations there is no separation between Prefabs, Ingots or Gasses. All of them are considered **Items** equally. For example, the logic which updates **Item** price by certain multiplier will act the same for both Iron Ore, or ATV-Survivor, or Hydrogen Gas.

Another important property of NPC Store Block deals is the amount of each **Item** traded there and the existence of the deal you are searching for. The logic for that in code is quite simple and called

**isActive**

state. But we will call it simply **Active**. The definition of being active is as simple as to calculate if **Item Amount** is greater than **Item Removed Amount**. If **Item Amount** is equal to zero, the deal is not **Active**. And most functions in code will check the existence of **Item** by calling the calculation of its **Active** state.

The concept of tracking the item **Activity** is shown in the following example: [Vanilla Price Dynamic](#Player_Checks_Vanilla_Price_Changes).

* * *

### Price Generation and Update Cycles

One of the key features of NPC economy is the way it updates prices from time to time. The logic behind it is split into 2 main parts: **Generate Item** and **Update Item**.

**Generate Item** logic starts with running the price calculator from [<MinimalPricePerUnit>](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/Items/Component_Definition#MinimalPricePerUnit "Modding/Reference/SBC/Items/Component Definition") value defined by player and only if **Item** is not **Active**.

*   First, it is checking the <MinimalPricePerUnit> value of Ores which are also present in the FactionTypes store list, if there are any Blueprints containing them/their result. If it can't find associated Ore price, it will check Blueprint <MinimalPricePerUnit> value of that Blueprint. Note, that while searching through the same Subtype Blueprints(for example you have multiple recipes for Iron Ingot), it will always prefer the last entry from the list!
*   Second, it applies a formula to extracted <MinimalPricePerUnit> with awareness of which Type the Item is. So, for this example, if you have a <MinimalPricePerUnit> set for Iron Ore, it will calculate the multiplier for Iron Ingot by multiplying the specified <MinimalPricePerUnit> of Iron Ore, after that calculate the price of Steel Plate by calculating Iron Ore and Iron Ingot again, and then calculate Armor Blocks by calling the calculation of Iron Ore, Iron Ingot and Steel Plate.
*   And last, it will apply Faction-specific multipliers over the calculated prices. And that result is exactly what you will see when opening NPC Store Block just after world load.

**Update Item** logic performs on any **Active Item** in the deals and goes alongside with the Economy Updates, eventually turning them not **Active**.

The first point here is the **Economy Update Cycle** which is ran every [Economy Tick](https://spaceengineers.wiki.gg/wiki/Modding/Reference/Saves/SessionSettings#EconomyTickInSeconds "Modding/Reference/Saves/SessionSettings") (20 minutes by default). This cycle is specified by player as <Order/Offer- MaxUpdateCount> and acts as count-down until the **Item** will be forcefully set to not **Active**. Each Update Cycle updates the price of the **Active Item** by calculated Faction-specific multiplier. This multiplier is also dependant on **Item Amount**, so trading the **Item** in different manner will influence the multiplier applied to the price in next Update Cycle in different degree. If code runs over Update Cycle which exceeds the specified <Order/Offer- MaxUpdateCount>, it will turn **Item** to not **Active**.

The concept of **Item** generation/updates and the on-goning **Update Cycles** is shown in the following example: [Vanilla Price Dynamic](#Player_Checks_Vanilla_Price_Changes).

## 

Main Price Calculation Classes

[

(Back to top)

](#toc)

While the game is running, code is processing certain classes and functions within them. To learn more about the way you can find them yourself, read the detailed guide on [Scripting/Debugging with dnSpy](https://spaceengineers.wiki.gg/wiki/Scripting/Debugging_with_dnSpy "Scripting/Debugging with dnSpy"). For the topic of NPC Economy Calculations, the code is nested within the following classes.

* * *

### MyFactionTypeDefinition Class

This class contains most of the variables required in formulas to calculate starting prices and their changes. It is most commonly called with `m_definition` variable within other functions.

|     |     |
| --- | --- |
| minimalPricePerUnit | A variable that formula is fetching from the calculated **Item** price which was previously generated/updated on world load or player interaction. It is used to define prices in [MyFactionTypeBaseStrategy](#MyFactionTypeBaseStrategy_Class) and [MyStoreItem](#MyStoreItem_Class). |
| minimumOfferAmount | A variable that formula is fetching from the other function which is directly linked to player-specified tag [<MinimumOfferAmount>](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/Items/Component_Definition#MinimumOfferAmount "Modding/Reference/SBC/Items/Component Definition"). It is used to generate prices in [MyFactionTypeBaseStrategy](#MyFactionTypeBaseStrategy_Class) and [MyStoreItem](#MyStoreItem_Class). |
| maximumOfferAmount | A variable that formula is fetching from the other function which is directly linked to player-specified tag [<MaximumOfferAmount>](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/Items/Component_Definition#MaximumOfferAmount "Modding/Reference/SBC/Items/Component Definition"). It is used to generate prices in [MyFactionTypeBaseStrategy](#MyFactionTypeBaseStrategy_Class) and [MyStoreItem](#MyStoreItem_Class). |
| MaxUpdateCount | A variable that formula is fetching from the other function which is directly linked to player-specified tag [<OfferMaxUpdateCount>](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/FactionType_Definition#OfferMaxUpdateCount "Modding/Reference/SBC/FactionType Definition") for **Buy** tab in Store Block and [<OrderMaxUpdateCount>](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/FactionType_Definition#OrderMaxUpdateCount "Modding/Reference/SBC/FactionType Definition")<br><br>for **Sell** tab. It is used to generate prices in [MyStoreItem](#MyStoreItem_Class). |
| PriceUpDownPoint | A variable that formula is fetching from the other function which is directly linked to player-specified tag [<OfferPriceUpDownPoint>](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/FactionType_Definition#OfferPriceUpDownPoint "Modding/Reference/SBC/FactionType Definition") for **Buy** tab in Store Block and [<OrderPriceUpDownPoint>](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/FactionType_Definition#OrderPriceUpDownPoint "Modding/Reference/SBC/FactionType Definition")<br><br>for **Sell** tab. It is used to generate prices in [MyStoreItem](#MyStoreItem_Class). |
| PriceUpMultiplierMin | A variable that formula is fetching from the other function which is directly linked to player-specified tag [<OfferPriceUpMultiplierMin>](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/FactionType_Definition#OfferPriceUpMultiplierMin "Modding/Reference/SBC/FactionType Definition") for **Buy** tab in Store Block and [<OrderPriceUpMultiplierMin>](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/FactionType_Definition#OrderPriceUpMultiplierMin "Modding/Reference/SBC/FactionType Definition")<br><br>for **Sell** tab. It is used to generate prices in [MyStoreItem](#MyStoreItem_Class). |
| PriceUpMultiplierMax | A variable that formula is fetching from the other function which is directly linked to player-specified tag [<OfferPriceUpMultiplierMax>](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/FactionType_Definition#OfferPriceUpMultiplierMax "Modding/Reference/SBC/FactionType Definition") for **Buy** tab in Store Block and [<OrderPriceUpMultiplierMax>](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/FactionType_Definition#OrderPriceUpMultiplierMax "Modding/Reference/SBC/FactionType Definition")<br><br>for **Sell** tab. It is used to generate prices in [MyStoreItem](#MyStoreItem_Class). |
| PriceDownMultiplierMin | A variable that formula is fetching from the other function which is directly linked to player-specified tag [<OfferPriceDownMultiplierMin>](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/FactionType_Definition#OfferPriceDownMultiplierMin "Modding/Reference/SBC/FactionType Definition") for **Buy** tab in Store Block and [<OrderPriceDownMultiplierMin>](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/FactionType_Definition#OrderPriceDownMultiplierMin "Modding/Reference/SBC/FactionType Definition")<br><br>for **Sell** tab. It is used to generate prices in [MyStoreItem](#MyStoreItem_Class). |
| PriceDownMultiplierMax | A variable that formula is fetching from the other function which is directly linked to player-specified tag [<OfferPriceDownMultiplierMax>](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/FactionType_Definition#OfferPriceDownMultiplierMax "Modding/Reference/SBC/FactionType Definition") for **Buy** tab in Store Block and [<OrderPriceDownMultiplierMax>](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/FactionType_Definition#OrderPriceDownMultiplierMax "Modding/Reference/SBC/FactionType Definition")<br><br>for **Sell** tab. It is used to generate prices in [MyStoreItem](#MyStoreItem_Class). |
| PriceBellowMinimumMultiplier | A variable that formula is fetching from the other function which is directly linked to player-specified tag [<OfferPriceBellowMinimumMultiplier>](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/FactionType_Definition#OfferPriceBellowMinimumMultiplier "Modding/Reference/SBC/FactionType Definition"). It is used to generate prices in [MyStoreItem](#MyStoreItem_Class). |
| PriceOverMinimumMultiplier | A variable that formula is fetching from the other function which is directly linked to player-specified tag [<OrderPriceOverMinimumMultiplier>](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/FactionType_Definition#OrderPriceOverMinimumMultiplier "Modding/Reference/SBC/FactionType Definition"). It is used to generate prices in [MyStoreItem](#MyStoreItem_Class). |
| PriceStartingMultiplier | A variable that formula is fetching from the other function which is directly linked to player-specified tag [<OfferPriceStartingMultiplier>](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/FactionType_Definition#OfferPriceStartingMultiplier "Modding/Reference/SBC/FactionType Definition") for **Buy** tab in Store Block and [<OrderPriceStartingMultiplier>](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/FactionType_Definition#OrderPriceStartingMultiplier "Modding/Reference/SBC/FactionType Definition")<br><br>for **Sell** tab. It is used to generate prices in [MyFactionTypeBaseStrategy](#MyFactionTypeBaseStrategy_Class). |
| BaseCostProductionSpeedMultiplier | A variable that formula is fetching from the other function which is directly linked to player-specified tag [<BaseCostProductionSpeedMultiplier>](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/FactionType_Definition#BaseCostProductionSpeedMultiplier "Modding/Reference/SBC/FactionType Definition"). It is used to generate prices in [MyMinimalPriceCalculator](#MyMinimalPriceCalculator_Class). |

* * *