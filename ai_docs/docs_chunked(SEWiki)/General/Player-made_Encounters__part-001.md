---
title: "Player-made Encounters"
url: "https://spaceengineers.wiki.gg/wiki/Player-made_Encounters"
category: "General"
wiki_page: "Player-made Encounters"
includes_environment: true
includes_blocks: true
---

# Player-made Encounters - Official Space Engineers Wiki

You can add your own [encounters](https://spaceengineers.wiki.gg/wiki/Encounters "Encounters") that spawn your own ships — this is how. Basic knowledge of editing XML format in the NotePad++ editor is required. See also: [Keen's official Encounter Modding Guide](https://www.spaceengineersgame.com/modding-guides/encounter-modding-guide/).

*   Global encounters are for ion ships, space stations, and asteroid bases.
*   Planetary Encounters are for static (crashed) atmospheric ships, vehicle wrecks, and planetary bases.

## Create the mod folders

Create the mod skeleton. Let's say your mod is called MY\_ENCOUNTER. Create the following folders:

*   `%AppData%\SpaceEngineers\Mods\MY_ENCOUNTER\Data`
*   `%AppData%\SpaceEngineers\Mods\MY_ENCOUNTER\Data\Prefabs\GlobalEncounters\`
*   `%AppData%\SpaceEngineers\Mods\MY_ENCOUNTER\Data\Prefabs\GlobalEncounters\GlobalSubEncounters`
*   `%AppData%\SpaceEngineers\Mods\MY_ENCOUNTER\Data\Prefabs\PlanetaryEncounters\`

## Create the Mod file

Open NotePad++ and create one of the following text files. Write your mod name instead of MY\_GLOBAL\_ENCOUNTER or MY\_PLANETARY\_ENCOUNTER:

*   `%AppData%\SpaceEngineers\Mods\MY_ENCOUNTER\Data\MY_GLOBAL_ENCOUNTER.sbc`
*   `%AppData%\SpaceEngineers\Mods\MY_ENCOUNTER\Data\MY_PLANETARY_ENCOUNTER.sbc`

Look at the following existing files. Don't edit them, just copy example code from them!

*   `C:\Program Files (x86)\Steam\steamapps\common\SpaceEngineers\Content\Data\SpawnGroups_PlanetaryEncounters.sbc`
*   `C:\Program Files (x86)\Steam\steamapps\common\SpaceEngineers\Content\Data\SpawnGroups_GlobalEncounters.sbc`

## Add the ships and stations

1.  Build the ships and bases that should appear, here I'll call them MY\_BASE and MY\_SHIP.
2.  Aim the crosshairs at them in game and press [CTRL key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings")+[B key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings") to save their blueprints.
3.  Go to `%AppData%\SpaceEngineers\Blueprints\local\`.  
    You see the blueprints are saved in folders named MY\_BASE and MY\_SHIP etc.
4.  Inside the folders, find the SBC and SBC5 files:
    *   `%AppData%\SpaceEngineers\Blueprints\local\MY_SHIP\bp.sbc`
    *   `%AppData%\SpaceEngineers\Blueprints\local\MY_SHIP\bp.sbcB5`
    *   `%AppData%\SpaceEngineers\Blueprints\local\MY_BASE\bp.sbc`
    *   `%AppData%\SpaceEngineers\Blueprints\local\MY_BASE\bp.sbcB5`

Copy each file into the mod folder and rename them like this:

*   `%AppData%\SpaceEngineers\Mods\MY_ENCOUNTER\Data\Prefabs\GlobalEncounters\MY_SHIP.sbc`
*   `%AppData%\SpaceEngineers\Mods\MY_ENCOUNTER\Data\Prefabs\GlobalEncounters\MY_SHIP.sbcB5`
*   `%AppData%\SpaceEngineers\Mods\MY_ENCOUNTER\Data\Prefabs\PlanetaryEncounters\MY_BASE.sbc`
*   `%AppData%\SpaceEngineers\Mods\MY_ENCOUNTER\Data\Prefabs\PlanetaryEncounters\MY_BASE.sbcB5`

Open each of these copied .sbc files in NotePad++ and search the word "Blueprint" and replace all by "Prefab"!

If you have renamed any blueprint, make sure that the unique identifier `<Subtype>` has the same name every time it is mentioned in the .sbc and .sbcB5 files.

Create the following directories under Data/:

*   `Data/Prefabs/GlobalEncounters/`
*   `Data/Prefabs/GlobalEncounters/GlobalSubEncounters`

Create an SBC file and name it after your encounter. Give it the following content:

`<SpawnGroup>` Each encounter must start with this.

`<Id Type="MyObjectBuilder_SpawnGroupDefinition" Subtype="UniqueIdentifier" />`

Replace "UniqueIdentifier" by the name of your encounter

`<Frequency>1</Frequency>`

(Optional) Replace 1 with a higher value to make it spawn more frequently, for example during testing.

`<IsGlobalEncounter>true</IsGlobalEncounter>`

Keep this line to make this mod spawn as a global encounter. Or planetary, respectively.

<Factions>      
    <SubtypeId>Factorum</SubtypeId>
</Factions>

Replace "Factorum" by the name of the faction of your encounter.

`<GlobalEncounterSettings>`

This line indicates your settings start here.

`<MinDistanceFromCenter>100000</MinDistanceFromCenter>`

Replace the number by the minimum distance from the center of the world where this prefab will spawn.

`<MaxDistanceFromCenter>10000000</MaxDistanceFromCenter>`

Replace the number by the maximum distance from the center of the world this prefab will spawn.

`<PlanetProximitySpawnProbability>0.2</PlanetProximitySpawnProbability>`

Replace the number by the probability that this prefab will spawn near a planet. Number close to zero means rare, number close to 1.0 means often. This ignores the MinDistanceFromCenter and MaxDistanceFromCenter.

`<MinPlanetProximityDistance>1000</MinPlanetProximityDistance>`

Replace the number by the minimum distance from a planet where this prefab could spawn, in meters. Can not go lower than 1000m.

`<MaxPlanetProximityDistance>1500</MaxPlanetProximityDistance>`

Replace this number by the maximum distance from a planet where this prefab could spawn, in meters.

`</GlobalEncounterSettings>`

This line indicates your settings end here.

`<ReactorsOn>true</ReactorsOn>`

Keep "true" to make the grid start in a powered state.

`<Prefabs>`

This section lists your grids that will spawn. You can repeat the next section to spawn in several grids: Each modified copy of a < prefab > section loads one ship or base.

`<Prefab SubtypeId="MY_BASE">`

The name of your prefab SBC file to use for this spawn. Basically replace MY\_BASE with what you named your central grid. Remember to copy your file into your mods directory here: "Data/Prefabs/GlobalEncounters/MY\_BASE.sbc"!

<Position>
    <X>0</X>
    <Y>0</Y>
    <Z>0</Z>
</Position>

0 is the default to spawn one grid. If you repeated this section to have several grids spawn together, space them apart by changing these numbers!

`<Speed>0</Speed>`

The speed this prefab will spawn with, if not static.

`<GpsGrid>true</GpsGrid>`

True means a GPS signal will indicate to every player in the world where you encounter is.

`</Prefab> </Prefabs>`

These lines end the prefabs list, You could repeat the prefab section inside the prefabs section to spawn several main grids.
