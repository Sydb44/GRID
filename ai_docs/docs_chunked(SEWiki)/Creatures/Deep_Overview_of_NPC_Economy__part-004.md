| BaseCostProductionSpeedMultiplier | A variable that formula is fetching from the other function which is directly linked to player-specified tag [<BaseCostProductionSpeedMultiplier>](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/FactionType_Definition#BaseCostProductionSpeedMultiplier "Modding/Reference/SBC/FactionType Definition"). It is used to generate prices in [MyMinimalPriceCalculator](#MyMinimalPriceCalculator_Class). |

* * *

### MySessionComponentEconomy Class

This class contains a single variable which is a part of price generating process. It is most commonly called with `component` variable within other functions.

|     |     |
| --- | --- |
| DeepSpaceStationStoreBonus | A variable that formula is fetching from the other function which is directly linked to player-specified tag [<DeepSpaceStationStoreBonus>](#DeepSpaceStationStoreBonus). Default value is **0.05f**. It is used to generate prices in [MyFactionTypeBaseStrategy](#MyFactionTypeBaseStrategy_Class). |

* * *

### MyPhysicalItemDefinition Class

This class contains some variables required in formulas to calculate starting prices and their changes. It is most commonly called with `definition` variable within other functions.

|     |     |
| --- | --- |
| MinimalPricePerUnit | A variable that formula is fetching from the other function which is directly linked to player-specified tag [<MinimalPricePerUnit>](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/Items/Component_Definition#MinimalPricePerUnit "Modding/Reference/SBC/Items/Component Definition"). It is used to generate prices in [MyMinimalPriceCalculator](#MyMinimalPriceCalculator_Class). |

<Maximum/Minimum- Offer/Order- Amount> player-specified tags are originally called within this function, but to negate extra steps, consider the fetched values of them in [MyFactionTypeDefinition](#MyFactionTypeDefinition_Function).

* * *

### MyMinimalPriceCalculator Class

This class contains a few variables which are a part of price generating and updating process. It is most commonly called with `m_priceCalculator` variable within other functions.

|     |     |
| --- | --- |
| minimalPrice | A variable which is the result of running the calculations in [CalculateItemMinimalPrice](#CalculateItemMinimalPrice_Function) function call. It is used to generate prices in [MyFactionTypeBaseStrategy](#MyFactionTypeBaseStrategy_Class). |
| MinimalRepairPrice | A variable which is the result of running the calculations in **CalculatePrefabInformation** function call. It is used to generate prices for NPC Repair Contracts. For every block with **<IntegrityPercent> <= 0.5** in Prefab Blueprint, it sums up the full price of this block. |
| TotalPcu | A variable which is the result of running the calculations in **CalculatePrefabInformation** function call. It is used to generate PCU value for Prefabs. For every block in Prefab Blueprint, it sums up the PCU value defined within CybeBlocks data. |

* * *

### MyStoreItem Class

This class contains a calculation formula and rules for price updating process. It is most commonly called with `item` variable within other functions.

|     |     |
| --- | --- |
| PricePerUnit | A variable which is the result of running the calculations in [UpdateOfferItem](#UpdateOfferItem_Function) and [UpdateOrderItem](#UpdateOrderItem_Function) functions calls. It is used to update prices in NPC Store Block. |
| PricePerUnitDiscount | A variable which is the result of running the calculations in [UpdateOfferItem](#UpdateOfferItem_Function) function call. It is used to show the Discount percent of items in **Buy** tab of NPC Store Block when hovering your cursor over them. |

* * *

### MyFactionTypeBaseStrategy Class

This class contains a calculation formula and rules for price generating process.

|     |     |
| --- | --- |
| pricePerUnit | A variable which is the result of running the calculations in [GenerateOffer](#GenerateOffers_Function) and [GenerateOrders](#GenerateOrders_Function) functions calls. It is used to generate prices in NPC Store Block. |

* * *

### Economy Class Reference Graph

For better understanding of how classes are referencing between each other, there is a graph of every called class which plays role in the calculations. As stated above, the process of Generation and Updating of prices is separated and runs in parallel. So the end key in this chart will be the game environment. The color coding of the graph is the one taken from ILSpy.

[![Economy Class Reference Graph](https://spaceengineers.wiki.gg/images/thumb/a/a8/SE1EconomyFormulaDesc01.png/1500px-SE1EconomyFormulaDesc01.png?522ff7)](https://spaceengineers.wiki.gg/wiki/File:SE1EconomyFormulaDesc01.png "Economy Class Reference Graph")

## 

Main Price Calculation Functions

[

(Back to top)

](#toc)

Functions are the main points where all the calculations are happening.

* * *

### CalculateItemMinimalPrice Function

The main function to calculate the price of the **Item** without consideration of Faction-specific multipliers. To calculate that, it relies on `num` and `num4` variables which are taken depending on the condition of the case. `Result TypeID = “Ingot”` refers to the Blueprint.sbc recipes that have such a `TypeID` in `<Results>` tag. For any other `TypeID`, use the "Else" condition. It uses [Natural Logarithm](https://en.wikipedia.org/wiki/Natural_logarithm) in the formula to flatten out the influence of [<BaseProductionTimeInSeconds>](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/Blueprints/Blueprint_Definition#BaseProductionTimeInSeconds "Modding/Reference/SBC/Blueprints/Blueprint Definition").

Requires:

• [<MinimalPricePerUnit>](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/Items/Component_Definition#MinimalPricePerUnit "Modding/Reference/SBC/Items/Component Definition")

• [<Prerequisites Item Amount>](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/Blueprints/Blueprint_Definition#Prerequisites "Modding/Reference/SBC/Blueprints/Blueprint Definition")

• [<Result Item Amount>](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/Blueprints/Blueprint_Definition#Results "Modding/Reference/SBC/Blueprints/Blueprint Definition")

• [<BaseProductionTimeInSeconds>](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/Blueprints/Blueprint_Definition#BaseProductionTimeInSeconds "Modding/Reference/SBC/Blueprints/Blueprint Definition")

• [<baseCostProductionSpeedMultiplier>](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/FactionType_Definition#BaseCostProductionSpeedMultiplier "Modding/Reference/SBC/FactionType Definition") (default: 1.0)

• [SessionRefinerySpeedMultiplier](https://spaceengineers.wiki.gg/wiki/Modding/Reference/Saves/SessionSettings#RefinerySpeedMultiplier "Modding/Reference/Saves/SessionSettings")

• [SessionAssemblerEfficiencyMultiplier](https://spaceengineers.wiki.gg/wiki/Modding/Reference/Saves/SessionSettings#AssemblerEfficiencyMultiplier "Modding/Reference/Saves/SessionSettings")

Result:

• [minimalPrice](#minimalPrice)

If Result TypeID = “Ingot”:
	num = 1
	num4 = RefinerySpeedMultiplier (from the World Settings)
Else:
	num = AssemblerEfficiencyMultiplier (from the World Settings)
	num4 = AssemblerEfficiencyMultiplier (from the World Settings)

If has Prerequisites:
minimalPrice = (<MinimalPricePerUnit> \* <Item Amount> / num) \* (1 / <Result Amount>) \* (1 + Loge(<BaseProductionTimeInSeconds> + 1) \* <baseCostProductionSpeedMultiplier> / num4)

* * *
