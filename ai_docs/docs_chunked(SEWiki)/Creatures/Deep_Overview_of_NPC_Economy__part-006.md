	PricePerUnit can’t go lower than <OfferPriceBellowMinimumMultiplier>	

	If minimalPrice > PricePerUnit:
		PricePerUnitDiscount = (1 - PricePerUnit) / minimalPrice
	Else:
		PricePerUnitDiscount = 0

If item is not Active:
	PricePerUnit = <OfferPriceUpMultiplierMax>

The limit of `<OfferPriceBellowMinimumMultiplier>` is applied over [pricePerUnit](#pricePerUnit) only, and not the increment results of [PricePerUnit](#PricePerUnit).

* * *

### UpdateOrderItem Function

The main function to calculate the **Order** price **Update**. This function is called only if **Update Cycle** does not exceed the value of player-specified [<OrderMaxUpdateCount>](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/FactionType_Definition#OrderMaxUpdateCount "Modding/Reference/SBC/FactionType Definition"). `Amount` and `RemovedAmount` here are referring to the [<MaximumOrderAmount>](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/Items/Component_Definition#MaximumOrderAmount "Modding/Reference/SBC/Items/Component Definition"), with randomly generated **Item Amount** and the amount of goods player withdraw from deal in the **Update Cycle**.

Requires:

• Item Amount in Store

• Removed Item Amount from Store

• [<OrderPriceUpDownPoint>](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/FactionType_Definition#OrderPriceUpDownPoint "Modding/Reference/SBC/FactionType Definition")

• [<OrderPriceUpMultiplierMin>](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/FactionType_Definition#OrderPriceUpMultiplierMin "Modding/Reference/SBC/FactionType Definition")

• [<OrderPriceUpMultiplierMax>](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/FactionType_Definition#OrderPriceUpMultiplierMax "Modding/Reference/SBC/FactionType Definition")

• [<OrderPriceDownMultiplierMin>](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/FactionType_Definition#OrderPriceDownMultiplierMin "Modding/Reference/SBC/FactionType Definition")

• [<OrderPriceDownMultiplierMax>](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/FactionType_Definition#OrderPriceDownMultiplierMax "Modding/Reference/SBC/FactionType Definition")

• [<OrderPriceOverMinimumMultiplier>](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/FactionType_Definition#OrderPriceOverMinimumMultiplier "Modding/Reference/SBC/FactionType Definition")

Result:

• [PricePerUnit](#PricePerUnit)

If item is Active:
	If \[RemovedAmount / (Amount + RemovedAmount)\] > \[<OrderPriceUpDownPoint>\]:
		amount = ((RemovedAmount / (Amount + RemovedAmount)) -  <OrderPriceUpDownPoint>) / (1 - <OrderPriceUpDownPoint>)
		PricePerUnit = linear interpolation between <OrderPriceDownMultiplierMax> and <OrderPriceDownMultiplierMin> by factor \[amount\]
	Else:
		amount2 = (OrderPriceUpDownPoint - (RemovedAmount / (Amount + RemovedAmount))) / <OrderPriceUpDownPoint>
		PricePerUnit = linear interpolation between <OrderPriceUpMultiplierMin> and <OrderPriceUpMultiplierMax> by factor \[amount2\]
	PricePerUnit can’t go higher than <OrderPriceOverMinimumMultiplier>		

If item is not Active:
	Do nothing

The limit of `<OrderPriceOverMinimumMultiplier>` is applied over [pricePerUnit](#pricePerUnit) only, and not the increment results of [PricePerUnit](#PricePerUnit).

## 

Examples of Economy Calculation

[

(Back to top)

](#toc)

In order to understand the concepts and formulas described here, it is better to look at few examples of Economy work in action. We will look at 2 global conditions: if the player want to understand the vanilla price changes and if the player want to set all the prices to x1 multiplier and make them never change. For every case, we will highlight only the most necessary values which will give the result and skip rudimentary ones. And the goal of examples will be to calculate the price of [SmallBlockLandingGear](https://spaceengineers.wiki.gg/wiki/Landing_Gear "Landing Gear"). The global multipliers of [SessionRefinerySpeedMultiplier](https://spaceengineers.wiki.gg/wiki/Modding/Reference/Saves/SessionSettings#RefinerySpeedMultiplier "Modding/Reference/Saves/SessionSettings") and [SessionAssemblerEfficiencyMultiplier](https://spaceengineers.wiki.gg/wiki/Modding/Reference/Saves/SessionSettings#AssemblerEfficiencyMultiplier "Modding/Reference/Saves/SessionSettings") will be set to **Realistic** (x1). As Prefabs can't be sold to NPC Economy, examples will follow only **Offer** operations.

* * *

### Player Checks Vanilla Price Changes

When looking at default behaviour, the player should expect the first price in the NPC Store Block after the world start to be equal to the one multiplied by [<OfferPriceStartingMultiplier>](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/FactionType_Definition#OfferPriceStartingMultiplier "Modding/Reference/SBC/FactionType Definition"). Every next [Economy Tick](https://spaceengineers.wiki.gg/wiki/Modding/Reference/Saves/SessionSettings#EconomyTickInSeconds "Modding/Reference/Saves/SessionSettings") the price will **Update** according to the update functions. And update functions will behave differently depending on interactions with **Items**.

Required Values:

• Everything is default

Calculations (from top to bottom):

|     |     |     |
| --- | --- | --- |
| **Item** | **Result** | **Function** |
| Iron Ore | <MinimalPricePerUnit>: 100 | \-  |
| Iron Ingot | minimalPrice = 149 | CalculateItemMinimalPrice |
| SteelPlate | minimalPrice = 5297 | CalculateItemMinimalPrice |
| Construction | minimalPrice = 2018 | CalculateItemMinimalPrice |
| Nickel Ore | <MinimalPricePerUnit>: 100 | \-  |
| Nickel Ingot | minimalPrice = 376 | CalculateItemMinimalPrice |
| Motor | minimalPrice = 11597 | CalculateItemMinimalPrice |
| SmallBlockLandingGear | minimalPrice = 32281 | CalculateItemMinimalPriceAndPcu |
| SmallBlockLandingGear | TotalPcu = 35 | CalculateItemMinimalPriceAndPcu |
| GenerateOffer: SmallBlockLandingGear | pricePerUnit = 38737 | GenerateOffers |
| GenerateOffer: SmallBlockLandingGear | Amount = 1 | GenerateOffers |
| Economy Update Cycle | UpdateCount = 0 | \-  |
| UpdateOfferItem: SmallBlockLandingGear | PricePerUnit = 35831 | UpdateOfferItem |
| Economy Update Cycle | UpdateCount = 1 | \-  |
| UpdateOfferItem: SmallBlockLandingGear | PricePerUnit = 33144 | UpdateOfferItem |
| Economy Update Cycle | UpdateCount = 2 | \-  |
| UpdateOfferItem: SmallBlockLandingGear | PricePerUnit = 30658 | UpdateOfferItem |
| Economy Update Cycle | UpdateCount = 3 | \-  |
| UpdateOfferItem: SmallBlockLandingGear | Amount = 0 | UpdateOfferItem |

Results:

If there was a Prefab which is made of a single [SmallBlockLandingGear](https://spaceengineers.wiki.gg/wiki/Landing_Gear "Landing Gear"), it would appear in the **Buy** tab of the NPC Store Block at a price of 38737 Space Credits on world load! After 20 minutes the price will go down as the result of [UpdateOfferItem](#UpdateOfferItem_Function) operation with the calculated result of **0.925**. After next 20 minutes, price will go down again by the same multiplier over the previous price. And at the point when [<OfferMaxUpdateCount>](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/FactionType_Definition#OfferMaxUpdateCount "Modding/Reference/SBC/FactionType Definition") is exceeded, [UpdateOfferItem](#UpdateOfferItem_Function) operation will result in resetting the **Item Amount**, which means that **Item** will be not **Active** and there is room for [GenerateOffers](#GenerateOffers_Function) function to **Activate Item** once again.

Keep in mind, that the price of `SteelPlate` in the chain here is calculated only as part of the chain where `GenerateOffers` applies its multiplier to the end-**Item**. If the end-**Item** is `SteelPlate` itself, then `GenerateOffers` multiplier will be applied to its price instead!

* * *
