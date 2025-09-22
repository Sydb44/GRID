---
title: "Class MySpawnGroupDefinition"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MySpawnGroupDefinition.html"
category: "Misc"
namespace: "Sandbox.Definitions"
class: "MySpawnGroupDefinition"
---

# Class MySpawnGroupDefinition | Space Engineers ModAPI

##### Inheritance

System.Object

MySpawnGroupDefinition

##### Inherited Members

###### **Namespace**: [Sandbox.Definitions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyDefinitionType]
public class MySpawnGroupDefinition : MyDefinitionBase
```

### Constructors

#### MySpawnGroupDefinition()

##### Declaration

```
public MySpawnGroupDefinition()
```

### Fields

#### EnableNpcResources

##### Declaration

```
public bool EnableNpcResources
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### EnableTradingStationVisit

##### Declaration

```
public bool EnableTradingStationVisit
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### FactionSubEncounters

##### Declaration

```
public List<SubEncounter> FactionSubEncounters
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[SubEncounter](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.SubEncounter.html)\> |     |

#### Frequency

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### GlobalEncounterSettings

##### Declaration

```
public GlobalEncounterSettings GlobalEncounterSettings
```

##### Field Value

| Type | Description |
| --- | --- |
| [GlobalEncounterSettings](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.GlobalEncounterSettings.html) |     |

#### HostileSubEncounters

##### Declaration

```
public List<SubEncounter> HostileSubEncounters
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[SubEncounter](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.SubEncounter.html)\> |     |

#### IsCargoShip

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsEncounter

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### PlanetaryInstallationSettings

##### Declaration

```
public PlanetaryInstallationSettings PlanetaryInstallationSettings
```

##### Field Value

| Type | Description |
| --- | --- |
| [PlanetaryInstallationSettings](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.PlanetaryInstallationSettings.html) |     |

#### Prefabs

##### Declaration

```
public List<MySpawnGroupDefinition.SpawnGroupPrefab> Prefabs
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MySpawnGroupDefinition.SpawnGroupPrefab](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MySpawnGroupDefinition.SpawnGroupPrefab.html)\> |     |

#### RandomizedPaint

##### Declaration

```
public bool RandomizedPaint
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ReactorsOn

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Voxels

##### Declaration

```
public List<MySpawnGroupDefinition.SpawnGroupVoxel> Voxels
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MySpawnGroupDefinition.SpawnGroupVoxel](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MySpawnGroupDefinition.SpawnGroupVoxel.html)\> |     |

### Properties

#### FactionSubtypeIds

##### Declaration

```
public List<string> FactionSubtypeIds { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<System.String\> |     |

#### FactionTypesSubtypeIds

##### Declaration

```
public List<string> FactionTypesSubtypeIds { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<System.String\> |     |

#### IsGlobalEncounter

##### Declaration

```
public bool IsGlobalEncounter { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsPirate

##### Declaration

```
public bool IsPirate { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsPlanetaryEncounter

##### Declaration

```
public bool IsPlanetaryEncounter { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsValid

##### Declaration

```
public bool IsValid { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### MaxFactionSubEncounters

Max count of faction sub encounters to spawn

##### Declaration

```
public byte MaxFactionSubEncounters { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Byte |     |

#### MaxHostileSubEncounters

Max count of hostile sub encounters to spawn

##### Declaration

```
public byte MaxHostileSubEncounters { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Byte |     |

#### MinFactionSubEncounters

Min count of faction sub encounters to spawn

##### Declaration

```
public byte MinFactionSubEncounters { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Byte |     |

#### MinHostileSubEncounters

Min count of hostile sub encounters to spawn

##### Declaration

```
public byte MinHostileSubEncounters { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Byte |     |

#### SpawnRadius

##### Declaration

```
public float SpawnRadius { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |
