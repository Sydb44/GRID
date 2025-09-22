0 is the default to spawn one grid. If you repeated this section to have several grids spawn together, space them apart by changing these numbers!

`<Speed>0</Speed>`

The speed this prefab will spawn with, if not static.

`<GpsGrid>true</GpsGrid>`

True means a GPS signal will indicate to every player in the world where you encounter is.

`</Prefab> </Prefabs>`

These lines end the prefabs list, You could repeat the prefab section inside the prefabs section to spawn several main grids.

## Optional Sub Encounters

Global encounters can spawn sub-encounters as defined and described below. If you don't have sub encounters, leave the section out.

Sub encounters allow for a degree of random generation. They can be of the same faction as the main prefab -- or of a random other faction, potentially staging a fight between two fleets or an ambush by pirates!

`<MinFactionSubEncounters>1</MinFactionSubEncounters>`

The minimum amount of sub encounters that spawn under the same faction as the main prefab, as listed in factions.

`<MaxFactionSubEncounters>3</MaxFactionSubEncounters>`

The maximum amount of sub encounters that spawn under the same faction as the main prefab, as listed in factions.

`<MinHostileSubEncounters>1</MinHostileSubEncounters>`

The minimum amount of sub encounters that spawn under a random picked faction from the world.

`<MaxHostileSubEncounters>3</MaxHostileSubEncounters>`

The maximum amount of sub encounters that spawn under a random picked faction from the world.

`<FactionSubEncounters>`

This starts the list of all the prefabs that can spawn as sub encounters if any are allowed as defined in MinFactionSubEncounters and MaxFactionSubEncounters:

`<SubEncounter SubtypeId="ExampleSubEncounter1">`

Replace "ExampleSubEncounter1" with the name of the sub encounter spawngroup. These are defined in the section below.

`<MinDistanceFromCore>200</MinDistanceFromCore>`

The minimum distance this prefab will spawn from the main prefab. Spawn will fail if the prefab overlaps with anything existing.

`<MaxDistanceFromCore>600</MaxDistanceFromCore>`

The maximum distance this prefab will spawn from the main prefab.

`<MinSpawnCount>1</MinSpawnCount>`

The minimum amount this prefab is spawned, if picked. This does not count towards the MinFactionSubEncounters and MaxFactionSubEncounters.

`<MaxSpawnCount>3</MaxSpawnCount>`

The Maximum amount this prefab is spawned if picked. This does not count towards the MinFactionSubEncounters and MaxFactionSubEncounters.

`</SubEncounter> </FactionSubEncounters>`

End of the sub encounters list.

`<HostileSubEncounters>`

This starts the list of all the prefabs that can spawn as hostile sub encounters if any are allowed as defined in MinHostileSubEncounters and MaxHostileSubEncounters:

`<SubEncounter SubtypeId="ExampleSubEncounter1">`

Replace "ExampleSubEncounter1" with the name of the hostile sub encounter spawngroup.

`<MinDistanceFromCore>200</MinDistanceFromCore><MaxDistanceFromCore>600</MaxDistanceFromCore> <MinSpawnCount>1</MinSpawnCount> <MaxSpawnCount>3</MaxSpawnCount>`

  
`</SubEncounter> </HostileSubEncounters>` End of the sub encounters list.

`</SpawnGroup>` End of the encounter.

Next, define the sub-encounter spawngroups. You can copy and paste the spawngroup section and modify it to load several different ships. They are defined separately here because you can reuse a few ships to appear in several encounters. Yes, they use the same tags as the entries above.

1.  Copy and paste the block and define each ship individually in its own block.
2.  Replace "ExampleSubEncounter1" by its name!
3.  Replace MY\_SUB\_PREFAB with the name of your prefab SBC file to use for this spawn.
4.  Put your file in your mod directory under "Data/Prefabs/GlobalEncounters/GlobalSubEncounters/MY\_SUB\_PREFAB.sbc"!

Tip: Remember you can reuse spawngroups between multiple global encounters, e.g. one defined drone "minion" can appear in several or even all of your encounters!

    <SpawnGroup>
    <Id>
        <TypeId>MyObjectBuilder\_SpawnGroupDefinition</TypeId>
        <SubtypeId>ExampleSubEncounter1</SubtypeId>
    </Id>
    <ReactorsOn>true</ReactorsOn>
        <Prefabs>
            <Prefab SubtypeId="MY\_SUB\_PREFAB">
                <Position>
                    <X>0.0</X>
                    <Y>0.0</Y>
                    <Z>0.0</Z>
                    </Position>
                <BeaconText>Example</BeaconText> 
                <Speed>0.0</Speed>
            </Prefab>
        </Prefabs>
    </SpawnGroup>

For a list of all possible tags and documentation for each: [SpawnGroup Definition](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC/SpawnGroup_Definition "Modding/Reference/SBC/SpawnGroup Definition")

## Troubleshooting Tips

To test your encounter mod:

1.  Create a new world in creative mode.
2.  Edit the [World Settings](https://spaceengineers.wiki.gg/wiki/World_Settings "World Settings"):
    1.  Enable 1 or more encounters in the advanced settings.
    2.  Click **Mods** to install your new mod.
3.  To speed up the testing process, paste in a fast jump ship or use [Admin tools](https://spaceengineers.wiki.gg/wiki/Admin_Screen "Admin Screen") to teleport yourself to encounters to check out whether they are yours.
4.  Then switch to Survival mode and test whether it acts as expected.

While testing, set e.g. <Frequency>10</Frequency> to make the modded encounter that your are testing appear more often.

While testing, open the SE log in a text editor and search for the name of your mod to find error messages quick. (See [Where are my log files?](https://spaceengineers.wiki.gg/wiki/Support#Where_are_My_Log_Files? "Support").) Wrong ID names and unbalanced XML tags are the most common errors. While the game is running, NotePad++ will sometimes ask whether you want to reload the log file in the editor, that's normal, reload it.

If a planetary encounter spawns the wrong way round, change the [Grid Pivot](https://spaceengineers.wiki.gg/wiki/Grid_Pivot "Grid Pivot").
