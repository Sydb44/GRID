`SubtypeId` of a [ParticleEffect definition](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/ParticleEffect "Modding/Reference/SBC/ParticleEffect") (Particles\_\*.sbc).

* * *

## Prefab-ReplaceColor

*   `{{CommonSBCInfo|Prefab-ReplaceColor}}` results in:

* * *

Prefab's blocks can use a specific color (360°, 100%, 100% in-game HSV or 1, 0.2, 0.55 inside the file) which gets replaced by the faction's `<CustomColor>` (from save file).

* * *

## Prefab-RandomColor

*   `{{CommonSBCInfo|Prefab-RandomColor}}` results in:

* * *

Prefab's blocks can use a specific color (360°, 100%, 100% in-game HSV or 1, 0.2, 0.55 inside the file) which gets replaced by a random color from [Game definition's <EncounterColors>](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/Game_Definition#EncounterColors "Modding/Reference/SBC/Game Definition").

* * *

## Prefab-CargoLoot

*   `{{CommonSBCInfo|Prefab-CargoLoot}}` results in:

* * *

Prefab's blocks support spawning random loot if configured to do so, for details see the [Cargo Loot tutorial](https://spaceengineers.wiki.gg/wiki/Modding/Tutorials/SBC/Cargo_Loot "Modding/Tutorials/SBC/Cargo Loot").

* * *

## xsitype

*   `{{CommonSBCInfo|xsitype|element=YourElement|deftype=MyObjectBuilder_SomeDefinition}}` results in:

* * *

A definition using this template requires an `xsi:type` attribute:  

<YourElement xsi:type="MyObjectBuilder\_SomeDefinition"\>

* * *

## NothingHere

*   `{{CommonSBCInfo|NothingHere}}` results in:

* * *

_(Nothing)_  

* * *

*   `{{CommonSBCInfo|NothingHere|type=block}}` results in:

* * *

_(Nothing)_  

* * *

*   `{{CommonSBCInfo|NothingHere|type=item}}` results in:

* * *

_(Nothing)_  

* * *

## VectorUsage

*   `{{CommonSBCInfo|VectorUsage|element=YourElement}}` results in:

* * *

Usage:

<YourElement>
  <X>0.0</X>
  <Y>0.0</Y>
  <Z>0.0</Z>
</YourElement>

X/Y/Z are Right/Up/Back for positive values, and they're in meters.

* * *

## VectorInlineUsage

*   `{{CommonSBCInfo|VectorInlineUsage|element=YourElement}}` results in:

* * *

Usage:

<YourElement x="0.0" y="0.0" z="0.0" />

X/Y/Z are Right/Up/Back for positive values, and they're in meters.

* * *

## Vector4ColorUsage

*   `{{CommonSBCInfo|Vector4ColorUsage|element=YourElement}}` results in:

* * *

Usage:

<YourElement>
  <X>0.5</X>
  <Y>0.2</Y>
  <Z>1.0</Z>
  <W>0.25</W>
</YourElement>

Where **X/Y/Z/W** = Red/Green/Blue/Alpha.

* * *

## RGBAUsage

*   `{{CommonSBCInfo|RGBAUsage|element=YourElement}}` results in:

* * *

Usage (pick one):

<YourElement R="0" G="85" B="153" A="255" />
<YourElement Hex="#005599" />
<YourElement Hex="#FF005599" />

The hex versions are RGB and ARGB respectively.

* * *

## Quaternion

*   `{{CommonSBCInfo|Quaternion|element=YourElement}}` results in:

* * *

Usage:

<YourElement>
  <X>0.0</X>
  <Y>0.0</Y>
  <Z>0.0</Z>
  <W>1.0</W>
</YourElement>

You can use [quaternions.online](https://quaternions.online/) (or any other calculator) to get the 4 values from 3 euler angles, but mind that X and Z are flipped (X is roll there, Z is roll in SE).

* * *

## SerializableBoundsUsage

*   `{{CommonSBCInfo|SerializableBoundsUsage|element=YourElement}}` results in:

* * *

Usage:

<YourElement Min="0.0" Max="10.0" Default="3.5" />

* * *

## DecalSource

*   `{{CommonSBCInfo|DecalSource}}` results in:

* * *

The name of a <Source> that's used by one or more [DecalDefinitions](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/Decal_Definition "Modding/Reference/SBC/Decal Definition") (Decals\*.sbc).

* * *

## PlanetRules

*   `{{CommonSBCInfo|PlanetRules|rule=height}}` results in:

* * *

The minimum and maximum relative height to allow within.  
The values ratios between the [planet <HillParams>](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/PlanetGenerator_Definition#HillParams "Modding/Reference/SBC/PlanetGenerator Definition")'s Min and Max, where 0 here represents the HillParams's Min, and 1 represents HillParams's Max, and decimals in-between allowed of course.  

Example:

<Height Min="0.4" Max="0.7" />

* * *

*   `{{CommonSBCInfo|PlanetRules|rule=lat}}` results in:

* * *

Angles away from the equator in degrees.  
0 is at the equator and 90 is at either pole. If the Mirror attribute is set to false, then the world-up planet side is -90 and the world-down side is 90.  

Example:

<Latitude Min="-90" Max="90" Mirror="true" />

* * *

*   `{{CommonSBCInfo|PlanetRules|rule=long}}` results in:

* * *

Angles around the world-up axis, where 0 is on the world-back side of the planet, and 90 is on the world-right side.  

Example:

<Longitude Min="-180" Max="180" />

* * *

*   `{{CommonSBCInfo|PlanetRules|rule=slope}}` results in:

* * *

Angles in degrees of terrain slope.  

Example:

<Slope Min="0" Max="90" />

* * *

## EventUniqueSelectionId

*   `{{CommonSBCInfo|EventUniqueSelectionId}}` results in:

* * *

An integer that must not clash with any other event, including ones from other mods...  
Because this is a 64bit integer, the WorkshopId of the published mod can be used and subtracting 1 for every event. Those would match other workshop content but the odds of it being a SE mod and one that adds events are pretty slim, you can still check them by changing the ID in the web page address if you want to be sure.

* * *

No description.

|     |     |     |     |     |
| --- | --- | --- | --- | --- |
Template parameters\[[Edit template data](https://spaceengineers.wiki.gg/wiki/Template:CommonSBCInfo?action=edit&templatedata=edit "Template:CommonSBCInfo")\]
This template prefers inline formatting of parameters.
| Parameter |     | Description | Type | Status |
| --- | --- | --- | --- | --- |
| Info to print | `1` | no description<br><br>Suggested values<br><br>`InventoryVolume` `InventorySize` `SinkGroup` `SourceGroup` `Asset` `AudioDef` `PhysicalMaterial` `ParticleDef` `xsitype` `NothingHere` `VectorUsage` `VectorInlineUsage` `Vector4ColorUsage` `RGBAUsage` `Quaternion` `SerializableBoundsUsage` `DecalSource` `PlanetRules` | String | required |
| For Asset: type of asset | `asset` | no description<br><br>Suggested values<br><br>`model` `image` `texture` | String | optional |
| For inventory\*: Include entity component note? | `ec` | no description | Boolean | optional |
| For NothingHere: the type of definition | `type` | no description<br><br>Suggested values<br><br>`block` `item` | String | optional |
| The element name for xsitype, VectorUsage, VectorInlineUsage, Vector4ColorUsage, RGBAUsage, Quaternion, SerializableBoundsUsage. | `element` | no description | String | optional |
| For xsitype: the definition OB name | `deftype` | no description | String | optional |
| For PlanetRules: rule to show | `rule` | no description<br><br>Suggested values<br><br>`height` `lat` `long` `slope` | String | optional |