---
title: "Template:CommonModdingInfo"
url: "https://spaceengineers.wiki.gg/wiki/Template:CommonModdingInfo"
category: "Modding"
wiki_page: "Template:CommonModdingInfo"
includes_environment: true
includes_blocks: true
---

# Template:CommonModdingInfo - Official Space Engineers Wiki

## Description

This is a centralized location for commonly repeated information for general modding.

## Syntax

Type `{{CommonModdingInfo|_<key>_}}` where the _key_ parameter is required and defines the information to print.

## Parameters

A list of the available parameters and their result.

## ConveyorEmpties

*   `{{CommonModdingInfo|ConveyorEmpties}}` results in:

* * *

Supports `detector_conveyor*` to connect to the conveyor network and provides an interactive area to open inventory/terminal.  
Then the \* can be various suffixes (if multiple are wanted, add them in this order):

*   `line` suffix to prevent this from being an interactive port.
*   `_small` suffix to be a small port (can only transfer items small enough, see [item's <Size>](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/Items/PhysicalItem_Definition#Size "Modding/Reference/SBC/Items/PhysicalItem Definition")), otherwise it's a large port.
*   `_in` or `_out` suffix can be used to make it directional, however it does _not_ work for gases.

Past that they can have another `_` followed by numbers (or really anything) to declare more than one with the same name.  
Example of a directional small non-interactive port: `detector_conveyorline_small_out_001`

* * *

## UpgradeEmpties

*   `{{CommonModdingInfo|UpgradeEmpties}}` results in:

* * *

Supports `detector_upgrade_*` to define upgrade ports, for [UpgradeModules](https://spaceengineers.wiki.gg/wiki/Modding/Reference/Blocks/UpgradeModule "Modding/Reference/Blocks/UpgradeModule") to attach to.  
They can have any suffix desired to declare more than one.

* * *

## WheelEmpty

*   `{{CommonModdingInfo|WheelEmpty}}` results in:

* * *

A single dummy that contains `wheel` (case-insensitive) can be used to define the position where this block is attached/steered by a suspension.  
If missing it will use block center (affected by `ModelOffset`).

* * *

## LinkBlockType

*   `{{CommonModdingInfo|LinkBlockType|Ladder2}}` results in:

* * *

[Ladder2](https://spaceengineers.wiki.gg/wiki/Modding/Reference/Blocks/Ladder2 "Modding/Reference/Blocks/Ladder2") block type page shows how it functions, what expects in the model, etc.

* * *

## EntityComponent

*   `{{CommonModdingInfo|EntityComponent}}` results in:

* * *

This is part of an entity component, see [EntityComponents](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/EntityComponents "Modding/Reference/SBC/EntityComponents") for usage details.

* * *

## NoBlockUse

*   `{{CommonModdingInfo|NoBlockUse}}` results in:

* * *

**Note:** This definition is not _directly_ used by any vanilla blocks, look at [inheriting types](#Other_Definitions) instead.

* * *

## LightFalloff

*   `{{CommonModdingInfo|LightFalloff}}` results in:

* * *

The value is exponential falloff where 0 is no light, 1 is linear, 2 is quadratic, 3 cubic and past that it's very hard to tell of any difference.  
Values between these numbers can be used which are a blend of the two neighbouring types.

[![](https://spaceengineers.wiki.gg/images/thumb/e/e3/Light_Falloff_Comparison.jpg/320px-Light_Falloff_Comparison.jpg?ffbd88)](https://spaceengineers.wiki.gg/wiki/File:Light_Falloff_Comparison.jpg)

In-game falloff comparisons

Unfortunately lights in this game do not support the realistic [inverse-square](https://en.wikipedia.org/wiki/Inverse-square_law) ([comparison](https://dev.epicgames.com/documentation/en-us/unreal-engine/4.2---inverse-square-falloff?application_version=4.27)).

* * *

## SunDetection

*   `{{CommonModdingInfo|SunDetection|SolarPanel_Definition}}` results in:

* * *

A few things come together to form the final output:

*   No output if planets block sunlight, at any distance.
*   Physical objects will block sunlight within 100m of each pivot (checked one at a time every 1.66s).
*   Angle between direction to the Sun and `<PanelOrientation>`.
*   Weather's `<SolarOutputModifier>` scaled by weather intensity.

In more detail

Each of the panel's [pivots](#Pivots) will do a 100m physics raycast (meaning it can't go through glass windows) from its position towards the Sun.  
Cycles through pivots every 100 ticks (~1.66s) therefore the more pivots it has the more accurate it is but it also takes longer to compute the entire surface.  
The ratio of pivots not hitting anything to total pivots is then used in the formula below as **PivotsInSun / TotalPivots**.  

Next is the alignment to the Sun, the [<PanelOrientation>](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/CubeBlocks/SolarPanel_Definition#PanelOrientation "Modding/Reference/SBC/CubeBlocks/SolarPanel Definition") turned in world space is checked against the direction to the Sun with a dot product, the result of that represents **SunAngle** in the formula below.  
Can see it as a [visualization](https://www.falstad.com/dotproduct/), where cos theta is the closest number that we'd get here because these vectors are normalized. You can see how the closer aligned they are the closer they are to 1, and when they're 90deg apart they're nearing 0, and when they're closer to complete opposite they're nearing -1. This is also where [<TwoSidedPanel>](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/CubeBlocks/SolarPanel_Definition#TwoSidedPanel "Modding/Reference/SBC/CubeBlocks/SolarPanel Definition") is checked, if that is turned off and this dot product is negative it will force it to be a 0 multiplier.

The formula to calculate the potential output:

PotentialOutput \= <MaxPowerOutput\> \* SunAngle \* (PivotsInSun / TotalPivots) \* Weather.SolarOutputModifier

The **Weather.SolarOutputModifier** comes from the current weather's [<SolarOutputModifier>](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/WeatherEffect_Definition#SolarOutputModifier "Modding/Reference/SBC/WeatherEffect Definition") scaled by how close you are to the weather (distance is cubed).

There's also an extra system where it checks if any planet is between the _grid's pivot_ and the sun, but the intersection is a simple line-to-sphere check therefore it's very fast. If any planet is occluding the sun, it will prevent all solar panels and oxygen farms from working on that grid.

* * *
