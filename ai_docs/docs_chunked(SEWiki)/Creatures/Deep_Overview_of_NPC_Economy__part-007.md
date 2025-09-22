| UpdateOfferItem: SmallBlockLandingGear | PricePerUnit = 33144 | UpdateOfferItem |
| Economy Update Cycle | UpdateCount = 2 | \-  |
| UpdateOfferItem: SmallBlockLandingGear | PricePerUnit = 30658 | UpdateOfferItem |
| Economy Update Cycle | UpdateCount = 3 | \-  |
| UpdateOfferItem: SmallBlockLandingGear | Amount = 0 | UpdateOfferItem |

Results:

If there was a Prefab which is made of a single [SmallBlockLandingGear](https://spaceengineers.wiki.gg/wiki/Landing_Gear "Landing Gear"), it would appear in the **Buy** tab of the NPC Store Block at a price of 38737 Space Credits on world load! After 20 minutes the price will go down as the result of [UpdateOfferItem](#UpdateOfferItem_Function) operation with the calculated result of **0.925**. After next 20 minutes, price will go down again by the same multiplier over the previous price. And at the point when [<OfferMaxUpdateCount>](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/FactionType_Definition#OfferMaxUpdateCount "Modding/Reference/SBC/FactionType Definition") is exceeded, [UpdateOfferItem](#UpdateOfferItem_Function) operation will result in resetting the **Item Amount**, which means that **Item** will be not **Active** and there is room for [GenerateOffers](#GenerateOffers_Function) function to **Activate Item** once again.

Keep in mind, that the price of `SteelPlate` in the chain here is calculated only as part of the chain where `GenerateOffers` applies its multiplier to the end-**Item**. If the end-**Item** is `SteelPlate` itself, then `GenerateOffers` multiplier will be applied to its price instead!

* * *

### Player Locks Price Changes to Static x1 Multiplier

First thing player will look at is the way to **Generate** prices at x1 multiplier. As on the world load, all NPC Store Blocks have no **Active** items. So the function which creates those items is the target! Next up, the player need to stop prices from changing. And **Update** function performs exactly that, over any **Item** which is not equal to 0 **Amount**. One way to approach the update haul is to manipulate the [UpdateOfferItem Function](#UpdateOfferItem_Function) variables. Another way - is to limit the main requirement for **Update** - [<OfferMaxUpdateCount>](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/FactionType_Definition#OfferMaxUpdateCount "Modding/Reference/SBC/FactionType Definition"). Let's assume the player decided to limit the Update Cycles!

Required Values:

• [<OfferPriceStartingMultiplier>](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/FactionType_Definition#OfferPriceStartingMultiplier "Modding/Reference/SBC/FactionType Definition") = 1.0

• [<OrderPriceStartingMultiplier>](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/FactionType_Definition#OrderPriceStartingMultiplier "Modding/Reference/SBC/FactionType Definition") = 1.0

• [<OfferMaxUpdateCount>](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/FactionType_Definition#OfferMaxUpdateCount "Modding/Reference/SBC/FactionType Definition") = 0

• [<OrderMaxUpdateCount>](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/FactionType_Definition#OrderMaxUpdateCount "Modding/Reference/SBC/FactionType Definition") = 0

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
| GenerateOffer: SmallBlockLandingGear | pricePerUnit = 32281 | GenerateOffers |

Results:

If there was a Prefab which is made of a single [SmallBlockLandingGear](https://spaceengineers.wiki.gg/wiki/Landing_Gear "Landing Gear"), it would appear in the **Buy** tab of the NPC Store Block at a price of 32281 Space Credits! As a side note, the `UpdateOffer` will never be called because [<OfferMaxUpdateCount>](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/FactionType_Definition#OfferMaxUpdateCount "Modding/Reference/SBC/FactionType Definition") is under the least acceptable value. It means that every [Economy Tick](https://spaceengineers.wiki.gg/wiki/Modding/Reference/Saves/SessionSettings#EconomyTickInSeconds "Modding/Reference/Saves/SessionSettings") only **Generate** function is called, and so does re-generate **Item Amount** and **Item** price.

## 

Helpful Tips for Economy Calculations

[

(Back to top)

](#toc)

• For more advanced users, there is an Excel Template containing the most difficult formulas to handle from all of the Economy Calculation process with some default values set in place. In order to use it, make sure to create a new Sheet, select a cell **A1**, and paste the content of the Template into it (_tested in GoogleDocs_).

Excel Template - Open here

MyStoreItem																	
UpdateOfferItem																	
UpDownPoint	Amount	RemovedAmount	amount	amount2	DownMultMax	DownMultMin	belowMinMult	UpMultMax	UpMultMin	PricePerUnit							
0.5	1	0	=((C4/(C4+B4))-A4)/(1-A4)	=(A4-(C4/(B4+C4)))/A4	0.925	0.9	0.85	1.1	1.05	=IF((B4-C4)>0,(IF((C4/(B4+C4))>A4,J4+((I4-J4)/(1/D4)),G4+((F4-G4)/(1/E4)))),I4)							
UpdateOrderItem																	
UpDownPoint	Amount	RemovedAmount	amount	amount2	DownMultMax	DownMultMin	overMinMult	UpMultMax	UpMultMin	PricePerUnit							
0.25	1	0	=((C7/(B7+C7))-A7)/(1-A7)	=(A7-(C7/(B7+C7)))/A7	0.950	0.75	1.1	1.1	1.05	=IF((B7-C7)>0,(IF((C7/(B7+C7))>A7,F7+((G7-F7)/(1/D7)),J7+((I7-J7)/(1/E7)))),0)							
																	
MyMinimalPriceCalculator																	
CalculateItemMinimalPrice (Ores to Ingots)																	
Ore Type	MinimalPricePerUnit	ProductionTime	baseCostProductionSpeedMultiplier	SpeedMultiplier = 1	Result Amount		num7 =	minimalPrice =									
Iron	100	0.05	1	1	0.7		=1+log((C12+1),2.7182818)\*D12/E12	=(B12\*(1/F12)\*H12)									
Nickel	100	0.66	1	1	0.4		=1+log((C13+1),2.7182818)\*D13/E13	=(B13\*(1/F13)\*H13)									
Cobalt	300	3	1	1	0.3		=1+log((C14+1),2.7182818)\*D14/E14	=(B14\*(1/F14)\*H14)									
Silicon	100	0.6	1	1	0.7		=1+log((C15+1),2.7182818)\*D15/E15	=(B15\*(1/F15)\*H15)									
Stone	10	0.1	1	1	1		=1+log((C16+1),2.7182818)\*D16/E16	=(B16\*(1/F16)\*H16)									
Silver	200	1	1	1	0.1		=1+log((C17+1),2.7182818)\*D17/E17	=(B17\*(1/F17)\*H17)									
Gold	200	0.4	1	1	0.01		=1+log((C18+1),2.7182818)\*D18/E18	=(B18\*(1/F18)\*H18)									
Platinum	400	3	1	1	0.005		=1+log((C19+1),2.7182818)\*D19/E19	=(B19\*(1/F19)\*H19)									
CalculateItemMinimalPrice (Ingots to Components)										Blueprint Prerequisites							
Component Name	minimalPrice	ProductionTime	baseCostProductionSpeedMultiplier	SessionRefineryMult	Result Amount		num7 =	minimalPrice =		Iron	Nickel	Cobalt	Silicon	Stone(Gravel)	Silver	Gold	Platinum
SteelPlate	=ROUNDDOWN(SUMPRODUCT(K22:R22,K43:R43))	1	1	1	1		=1+log((C22+1),2.7182818)\*D22/E22	=ROUNDDOWN(B22\*(1/F22)\*H22)		21							
Construction	=ROUNDDOWN(SUMPRODUCT(K23:R23,K43:R43))	1	1	1	1		=1+log((C23+1),2.7182818)\*D23/E23	=ROUNDDOWN(B23\*(1/F23)\*H23)		8							
MetalGrid	=ROUNDDOWN(SUMPRODUCT(K24:R24,K43:R43))	2	1	1	1		=1+log((C24+1),2.7182818)\*D24/E24	=ROUNDDOWN(B24\*(1/F24)\*H24)		12	5	3					
LargeTube	=ROUNDDOWN(SUMPRODUCT(K25:R25,K43:R43))	2	1	1	1		=1+log((C25+1),2.7182818)\*D25/E25	=ROUNDDOWN(B25\*(1/F25)\*H25)		30							
InteriorPlate	=ROUNDDOWN(SUMPRODUCT(K26:R26,K43:R43))	1	1	1	1		=1+log((C26+1),2.7182818)\*D26/E26	=ROUNDDOWN(B26\*(1/F26)\*H26)		3							
Motor	=ROUNDDOWN(SUMPRODUCT(K27:R27,K43:R43))	3	1	1	1		=1+log((C27+1),2.7182818)\*D27/E27	=ROUNDDOWN(B27\*(1/F27)\*H27)		20	5						
SmallTube	=ROUNDDOWN(SUMPRODUCT(K28:R28,K43:R43))	1	1	1	1		=1+log((C28+1),2.7182818)\*D28/E28	=ROUNDDOWN(B28\*(1/F28)\*H28)		5							
Computer	=ROUNDDOWN(SUMPRODUCT(K29:R29,K43:R43))	1	1	1	1		=1+log((C29+1),2.7182818)\*D29/E29	=ROUNDDOWN(B29\*(1/F29)\*H29)		0.5			0.2				
Detector	=ROUNDDOWN(SUMPRODUCT(K30:R30,K43:R43))	4	1	1	1		=1+log((C30+1),2.7182818)\*D30/E30	=ROUNDDOWN(B30\*(1/F30)\*H30)		5	15						
Display	=ROUNDDOWN(SUMPRODUCT(K31:R31,K43:R43))	1	1	1	1		=1+log((C31+1),2.7182818)\*D31/E31	=ROUNDDOWN(B31\*(1/F31)\*H31)		1			5				
BulletproofGlass	=ROUNDDOWN(SUMPRODUCT(K32:R32,K43:R43))	1	1	1	1		=1+log((C32+1),2.7182818)\*D32/E32	=ROUNDDOWN(B32\*(1/F32)\*H32)					15				
RadioCommunication	=ROUNDDOWN(SUMPRODUCT(K33:R33,K43:R43))	4	1	1	1		=1+log((C33+1),2.7182818)\*D33/E33	=ROUNDDOWN(B33\*(1/F33)\*H33)		8			1				
Reactor	=ROUNDDOWN(SUMPRODUCT(K34:R34,K43:R43))	8	1	1	1		=1+log((C34+1),2.7182818)\*D34/E34	=ROUNDDOWN(B34\*(1/F34)\*H34)		15				20	5		
PowerCell	=ROUNDDOWN(SUMPRODUCT(K35:R35,K43:R43))	4	1	1	1		=1+log((C35+1),2.7182818)\*D35/E35	=ROUNDDOWN(B35\*(1/F35)\*H35)		10	2		1				
Medical	=ROUNDDOWN(SUMPRODUCT(K36:R36,K43:R43))	6	1	1	1		=1+log((C36+1),2.7182818)\*D36/E36	=ROUNDDOWN(B36\*(1/F36)\*H36)		60	70				20		
Girder	=ROUNDDOWN(SUMPRODUCT(K37:R37,K43:R43))	1	1	1	1		=1+log((C37+1),2.7182818)\*D37/E37	=ROUNDDOWN(B37\*(1/F37)\*H37)		6							
SolarCell	=ROUNDDOWN(SUMPRODUCT(K38:R38,K43:R43))	2	1	1	1		=1+log((C38+1),2.7182818)\*D38/E38	=ROUNDDOWN(B38\*(1/F38)\*H38)			3		6				
GravityGenerator	=ROUNDDOWN(SUMPRODUCT(K39:R39,K43:R43))	10	1	1	1		=1+log((C39+1),2.7182818)\*D39/E39	=ROUNDDOWN(B39\*(1/F39)\*H39)		600		220			5	10	
Superconductor	=ROUNDDOWN(SUMPRODUCT(K40:R40,K43:R43))	8	1	1	1		=1+log((C40+1),2.7182818)\*D40/E40	=ROUNDDOWN(B40\*(1/F40)\*H40)		10						2	
Thrust	=ROUNDDOWN(SUMPRODUCT(K41:R41,K43:R43))	4	1	1	1		=1+log((C41+1),2.7182818)\*D41/E41	=ROUNDDOWN(B41\*(1/F41)\*H41)		30		10				1	0.4
										minimalPrice							
										=ROUNDDOWN(I12)	=ROUNDDOWN(I13)	=ROUNDDOWN(I14)	=ROUNDDOWN(I15)	=ROUNDDOWN(I16)	=ROUNDDOWN(I17)	=ROUNDDOWN(I18)	=ROUNDDOWN(I19)

• In order to calculate the [UpdateOfferItem Function](#UpdateOfferItem_Function) result on specific **Update Cycle** with no **Removed Item Amount** influence, simply multiply the [minimalPrice](#minimalPrice) by [<OfferPriceDownMultiplierMax>](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/FactionType_Definition#OfferPriceDownMultiplierMax "Modding/Reference/SBC/FactionType Definition") in a root of **(Update Cycle + 1)** value! For **Order** operation use [<OrderPriceUpMultiplierMax>](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/FactionType_Definition#OrderPriceUpMultiplierMax "Modding/Reference/SBC/FactionType Definition") instead.

• The rounding error can be an issue when verifying the calculated result with live-tests. So make sure that you **round down!** all the calculations results on every step. The variables for calculations are not rounded though.

• Most of the calculated data such as `<UpdateCount>`, `[<PricePerUnit>](#PricePerUnit)` or `<RemovedAmount>` are stored in [Sandbox.sbc](#Sandbox.sbc) which is part of [world save settings](https://spaceengineers.wiki.gg/wiki/Modding/Reference/Saves/SessionSettings "Modding/Reference/Saves/SessionSettings").