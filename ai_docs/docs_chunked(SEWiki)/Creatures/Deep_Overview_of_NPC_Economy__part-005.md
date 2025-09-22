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

### CalculateItemMinimalPriceAndPcu Function

The main function to calculate the price of the **Block** without consideration of Faction-specific multipliers. To calculate that, it relies on `num` and `num4` variables which are taken depending on the condition of the case. `Result TypeID = “Ingot”` refers to the Blueprint.sbc recipes that have such a `TypeID` in `<Results>` tag. For any other `TypeID`, use the "Else" condition. It uses [Natural Logarithm](https://en.wikipedia.org/wiki/Natural_logarithm) in the formula to flatten out the influence of [<BaseProductionTimeInSeconds>](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/Blueprints/Blueprint_Definition#BaseProductionTimeInSeconds "Modding/Reference/SBC/Blueprints/Blueprint Definition"). Formula parses through every **CubeBlock Component**, and all the ingredients of those **Components**. For PCU calculation, it simply sums up the PCU value of the Block regardless of any possible modifiers.

Requires:

• [<MinimalPricePerUnit>](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/Items/Component_Definition#MinimalPricePerUnit "Modding/Reference/SBC/Items/Component Definition")

• [<Prerequisites Item Amount>](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/Blueprints/Blueprint_Definition#Prerequisites "Modding/Reference/SBC/Blueprints/Blueprint Definition")

• [<Result Item Amount>](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/Blueprints/Blueprint_Definition#Results "Modding/Reference/SBC/Blueprints/Blueprint Definition")

• [<BaseProductionTimeInSeconds>](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/Blueprints/Blueprint_Definition#BaseProductionTimeInSeconds "Modding/Reference/SBC/Blueprints/Blueprint Definition")

• [<baseCostProductionSpeedMultiplier>](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/FactionType_Definition#BaseCostProductionSpeedMultiplier "Modding/Reference/SBC/FactionType Definition") (default: 1.0)

• [SessionRefinerySpeedMultiplier](https://spaceengineers.wiki.gg/wiki/Modding/Reference/Saves/SessionSettings#RefinerySpeedMultiplier "Modding/Reference/Saves/SessionSettings")

• [SessionAssemblerEfficiencyMultiplier](https://spaceengineers.wiki.gg/wiki/Modding/Reference/Saves/SessionSettings#AssemblerEfficiencyMultiplier "Modding/Reference/Saves/SessionSettings")

• [Block Component Count](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/CubeBlocks/CubeBlock_Definition#Components "Modding/Reference/SBC/CubeBlocks/CubeBlock Definition")

Result:

• [minimalPrice](#minimalPrice)

If Result TypeID = “Ingot”:
	num = 1
	num4 = RefinerySpeedMultiplier (from the World Settings)
Else:
	num = AssemblerEfficiencyMultiplier (from the World Settings)
	num4 = AssemblerEfficiencyMultiplier (from the World Settings)

If has Components:
minimalPrice = ((<MinimalPricePerUnit> \* <Item Amount> / num) \* (1 / <Result Amount>) \* (1 + Loge(<BaseProductionTimeInSeconds> + 1) \* <baseCostProductionSpeedMultiplier> / num4)) \* <Component Count>

* * *

### GenerateOffers Function

The main function to calculate the **Offer** price **Generation**. This function is called only if **Item** is not **Active**. This function refers `minimalPrice` from [CalculateItemMinimalPrice](#CalculateItemMinimalPrice_Function) function above.

Requires:

• [minimalPrice](#minimalPrice)

• [<OfferPriceStartingMultiplier>](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/FactionType_Definition#OfferPriceStartingMultiplier "Modding/Reference/SBC/FactionType Definition")

• [<DeepSpaceStationStoreBonus>](#DeepSpaceStationStoreBonus)

Result:

• [pricePerUnit](#pricePerUnit)

pricePerUnit = minimalPrice \* <OfferPriceStartingMultiplier> \* (1 - <DeepSpaceStationStoreBonus>

* * *

### GenerateOrders Function

The main function to calculate the **Order** price **Generation**. This function is called only if **Item** is not **Active**. This function refers `minimalPrice` from [CalculateItemMinimalPrice](#CalculateItemMinimalPrice_Function) function above.

Requires:

• [minimalPrice](#minimalPrice)

• [<OrderPriceStartingMultiplier>](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/FactionType_Definition#OrderPriceStartingMultiplier "Modding/Reference/SBC/FactionType Definition")

• [<DeepSpaceStationStoreBonus>](#DeepSpaceStationStoreBonus)

Result:

• [pricePerUnit](#pricePerUnit)

pricePerUnit = minimalPrice \* <OrderPriceStartingMultiplier> \* (1 + <DeepSpaceStationStoreBonus>)

* * *

### UpdateOfferItem Function

The main function to calculate the **Offer** price **Update**. This function is called only if **Update Cycle** does not exceed the value of player-specified [<OfferMaxUpdateCount>](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/FactionType_Definition#OfferMaxUpdateCount "Modding/Reference/SBC/FactionType Definition"). `Amount` and `RemovedAmount` here are referring to the [<MaximumOfferAmount>](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/Items/Component_Definition#MaximumOfferAmount "Modding/Reference/SBC/Items/Component Definition"), with randomly generated **Item Amount** and the amount of goods player withdraw from deal in the **Update Cycle**. Discount is calculated here just as the visual representation for players, when they can spot a red-colored price with the certain percent of price drop relative to the [minimalPrice](#minimalPrice) shown when hovered over it.

Requires:

• Item Amount in Store

• Removed Item Amount from Store

• [<OfferPriceUpDownPoint>](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/FactionType_Definition#OfferPriceUpDownPoint "Modding/Reference/SBC/FactionType Definition")

• [<OfferPriceUpMultiplierMin>](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/FactionType_Definition#OfferPriceUpMultiplierMin "Modding/Reference/SBC/FactionType Definition")

• [<OfferPriceUpMultiplierMax>](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/FactionType_Definition#OfferPriceUpMultiplierMax "Modding/Reference/SBC/FactionType Definition")

• [<OfferPriceDownMultiplierMin>](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/FactionType_Definition#OfferPriceDownMultiplierMin "Modding/Reference/SBC/FactionType Definition")

• [<OfferPriceDownMultiplierMax>](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/FactionType_Definition#OfferPriceDownMultiplierMax "Modding/Reference/SBC/FactionType Definition")

• [<OfferPriceBellowMinimumMultiplier>](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/FactionType_Definition#OfferPriceBellowMinimumMultiplier "Modding/Reference/SBC/FactionType Definition")

• [minimalPrice](#minimalPrice)

Result:

• [PricePerUnit](#PricePerUnit)

• [PricePerUnitDiscount](#PricePerUnit)

If item is Active:
	If \[RemovedAmount / (Amount + RemovedAmount)\] > \[<OfferPriceUpDownPoint>\]:
		amount = ((RemovedAmount / (Amount + RemovedAmount)) -  <OfferPriceUpDownPoint>) / (1 - <OfferPriceUpDownPoint>)
		PricePerUnit = linear interpolation between <OfferPriceUpMultiplierMin> and <OfferPriceUpMultiplierMax> by factor \[amount\]
	Else:
		amount2 = (OfferPriceUpDownPoint - (RemovedAmount / (Amount + RemovedAmount))) / <OfferPriceUpDownPoint>
		PricePerUnit = linear interpolation between <OfferPriceDownMultiplierMin> and <OfferPriceDownMultiplierMax> by factor \[amount2\]
	PricePerUnit can’t go lower than <OfferPriceBellowMinimumMultiplier>	

	If minimalPrice > PricePerUnit:
		PricePerUnitDiscount = (1 - PricePerUnit) / minimalPrice
	Else:
		PricePerUnitDiscount = 0

If item is not Active:
	PricePerUnit = <OfferPriceUpMultiplierMax>

The limit of `<OfferPriceBellowMinimumMultiplier>` is applied over [pricePerUnit](#pricePerUnit) only, and not the increment results of [PricePerUnit](#PricePerUnit).

* * *
