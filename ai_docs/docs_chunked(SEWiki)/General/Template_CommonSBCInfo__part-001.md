---
title: "Template:CommonSBCInfo"
url: "https://spaceengineers.wiki.gg/wiki/Template:CommonSBCInfo"
category: "General"
wiki_page: "Template:CommonSBCInfo"
includes_environment: true
includes_blocks: true
---

# Template:CommonSBCInfo - Official Space Engineers Wiki

## Description

This is a centralized location for commonly repeated information in SBC elements for modding.

## Syntax

Type `{{CommonSBCInfo|_<key>_}}` where the _key_ parameter is required and defines the information to print.

## Parameters

A list of the available parameters and their result.

## InventoryVolume

*   `{{CommonSBCInfo|InventoryVolume}}` results in:

* * *

Inventory max volume in cubic meters, 1 m3 = 1000 l.  
**Note:** this is saved with the entity therefore existing entities in worlds/blueprints/prefabs/clipboard/etc will keep the old volume.  
**Note:** an Inventory [Entity Component](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/EntityComponents "Modding/Reference/SBC/EntityComponents") will _override_ this.

* * *

*   `{{CommonSBCInfo|InventoryVolume|ec=false}}` results in:

* * *

Inventory max volume in cubic meters, 1 m3 = 1000 l.  
**Note:** this is saved with the entity therefore existing entities in worlds/blueprints/prefabs/clipboard/etc will keep the old volume.

* * *

## InventorySize

*   `{{CommonSBCInfo|InventorySize}}` results in:

* * *

Inventory max volume in cubic meters, 1 m3 = 1000 l. The final volume value is the result of multiplying all axis together: `X * Y * Z`.  
The size itself is not used elsewhere, only the volume result is, therefore you can set 2 axis to 1 and the 3rd to the final volume in cubic meters to have.  
**Note:** this is saved with the entity therefore existing entities in worlds/blueprints/prefabs/clipboard/etc will keep the old volume.  
**Note:** an Inventory [Entity Component](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/EntityComponents "Modding/Reference/SBC/EntityComponents") will _override_ this.

* * *

*   `{{CommonSBCInfo|InventorySize|ec=false}}` results in:

* * *

Inventory max volume in cubic meters, 1 m3 = 1000 l. The final volume value is the result of multiplying all axis together: `X * Y * Z`.  
The size itself is not used elsewhere, only the volume result is, therefore you can set 2 axis to 1 and the 3rd to the final volume in cubic meters to have.  
**Note:** this is saved with the entity therefore existing entities in worlds/blueprints/prefabs/clipboard/etc will keep the old volume.

* * *

## SinkGroup

*   `{{CommonSBCInfo|SinkGroup}}` results in:

* * *

`SubtypeId` of a sink [resource group](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/ResourceDistributionGroup "Modding/Reference/SBC/ResourceDistributionGroup").

* * *

## SourceGroup

*   `{{CommonSBCInfo|SourceGroup}}` results in:

* * *

`SubtypeId` of a source [resource group](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/ResourceDistributionGroup "Modding/Reference/SBC/ResourceDistributionGroup").

* * *

## Asset

*   `{{CommonSBCInfo|Asset|asset=model}}` results in:

* * *

Path to a .mwm file relative to current mod's folder. Falls back to game folder if not found in current mod. [Referencing assets in other mods](https://spaceengineers.wiki.gg/wiki/Modding/Tutorials/Modifying_Mods_by_Other_Creators#Referencing_assets_in_other_mods "Modding/Tutorials/Modifying Mods by Other Creators")

* * *

*   `{{CommonSBCInfo|Asset|asset=image}}` results in:

* * *

Path to a .dds or .png file relative to current mod's folder. Falls back to game folder if not found in current mod. [Referencing assets in other mods](https://spaceengineers.wiki.gg/wiki/Modding/Tutorials/Modifying_Mods_by_Other_Creators#Referencing_assets_in_other_mods "Modding/Tutorials/Modifying Mods by Other Creators")

* * *

*   `{{CommonSBCInfo|Asset|asset=texture}}` results in:

* * *

Path to a .dds file relative to current mod's folder. Falls back to game folder if not found in current mod. [Referencing assets in other mods](https://spaceengineers.wiki.gg/wiki/Modding/Tutorials/Modifying_Mods_by_Other_Creators#Referencing_assets_in_other_mods "Modding/Tutorials/Modifying Mods by Other Creators")

* * *

## GuiTexture

*   `{{CommonSBCInfo|GuiTexture}}` results in:

* * *

`<SubtypeName>` of a [GUI texture](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/GuiTextureAtlas_Definition#Textures "Modding/Reference/SBC/GuiTextureAtlas Definition") (GuiTextures.sbc).

* * *

## GuiTextureComposite

*   `{{CommonSBCInfo|GuiTextureComposite}}` results in:

* * *

`<SubtypeName>` of a [Composite GUI texture](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/GuiTextureAtlas_Definition#CompositeTextures "Modding/Reference/SBC/GuiTextureAtlas Definition") (GuiTextures.sbc).

* * *

## AudioDef

*   `{{CommonSBCInfo|AudioDef}}` results in:

* * *

`SubtypeId` (without Arc or Real prefix) of an [audio definition](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/Audio_Definition "Modding/Reference/SBC/Audio Definition") (Audio\_\*.sbc).

* * *

## PhysicalMaterial

*   `{{CommonSBCInfo|PhysicalMaterial}}` results in:

* * *

`SubtypeId` of a [PhysicalMaterial Definition](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/PhysicalMaterial_Definition "Modding/Reference/SBC/PhysicalMaterial Definition") (PhysicalMaterials.sbc). Visit [Collision Effects](https://spaceengineers.wiki.gg/wiki/Modding/Reference/Collision_Effects "Modding/Reference/Collision Effects") for more details on what it's used for in general.

* * *

## ParticleDef

*   `{{CommonSBCInfo|ParticleDef}}` results in:

* * *

`SubtypeId` of a [ParticleEffect definition](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/ParticleEffect "Modding/Reference/SBC/ParticleEffect") (Particles\_\*.sbc).

* * *

## Prefab-ReplaceColor

*   `{{CommonSBCInfo|Prefab-ReplaceColor}}` results in:

* * *

Prefab's blocks can use a specific color (360°, 100%, 100% in-game HSV or 1, 0.2, 0.55 inside the file) which gets replaced by the faction's `<CustomColor>` (from save file).

* * *
