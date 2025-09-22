
Next is the alignment to the Sun, the [<PanelOrientation>](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/CubeBlocks/SolarPanel_Definition#PanelOrientation "Modding/Reference/SBC/CubeBlocks/SolarPanel Definition") turned in world space is checked against the direction to the Sun with a dot product, the result of that represents **SunAngle** in the formula below.  
Can see it as a [visualization](https://www.falstad.com/dotproduct/), where cos theta is the closest number that we'd get here because these vectors are normalized. You can see how the closer aligned they are the closer they are to 1, and when they're 90deg apart they're nearing 0, and when they're closer to complete opposite they're nearing -1. This is also where [<TwoSidedPanel>](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/CubeBlocks/SolarPanel_Definition#TwoSidedPanel "Modding/Reference/SBC/CubeBlocks/SolarPanel Definition") is checked, if that is turned off and this dot product is negative it will force it to be a 0 multiplier.

The formula to calculate the potential output:

PotentialOutput \= <MaxPowerOutput\> \* SunAngle \* (PivotsInSun / TotalPivots) \* Weather.SolarOutputModifier

The **Weather.SolarOutputModifier** comes from the current weather's [<SolarOutputModifier>](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/WeatherEffect_Definition#SolarOutputModifier "Modding/Reference/SBC/WeatherEffect Definition") scaled by how close you are to the weather (distance is cubed).

There's also an extra system where it checks if any planet is between the _grid's pivot_ and the sun, but the intersection is a simple line-to-sphere check therefore it's very fast. If any planet is occluding the sun, it will prevent all solar panels and oxygen farms from working on that grid.

* * *

## WeightedRandom

*   `{{CommonModdingInfo|WeightedRandom}}` results in:

* * *

Weighted random does mean that each entry's number affects the chance of all the entries, because the weight from each is added up to a total and the random number chosen is between 0 and that total.  

A visual example. We have 4 objects: red, green, purple, yellow, and each has its weight number:  
[![WeightedRandom.png](https://spaceengineers.wiki.gg/images/thumb/4/4e/WeightedRandom.png/200px-WeightedRandom.png?5bd705)](https://spaceengineers.wiki.gg/wiki/File:WeightedRandom.png)  
The red object has a ~13.3% chance `(1.0/7.5)*100`, but if any other entry's number were to be changed or any object removed, then the red object's chance also changes and needs to be recalculated with the new total.

* * *

No description.

|     |     |     |     |     |
| --- | --- | --- | --- | --- |
Template parameters\[[Edit template data](https://spaceengineers.wiki.gg/wiki/Template:CommonModdingInfo?action=edit&templatedata=edit "Template:CommonModdingInfo")\]
| Parameter |     | Description | Type | Status |
| --- | --- | --- | --- | --- |
| 1   | `1` | no description<br><br>Suggested values<br><br>`ConveyorEmpties` `UpgradeEmpties` `WheelEmpty` `LinkBlockType` `SunDetection` `EntityComponent` `NoBlockUse` `LightFalloff` `WeightedRandom` | String | required |
| 2   | `2` | Depends on the first param if it looks for a 2nd param, see template documentation. | Unknown | optional |