---
title: "Interface IMyGlobalEncounterComponent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyGlobalEncounterComponent.html"
category: "Components"
namespace: "Sandbox.ModAPI"
class: "IMyGlobalEncounterComponent"
---

# Interface IMyGlobalEncounterComponent | Space Engineers ModAPI

Describes entity component used for global encounters grids

###### **Namespace**: [Sandbox.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyGlobalEncounterComponent
```

### Properties

#### EncounterId

Gets encounter id, generated id when encounter is created

##### Declaration

```
long EncounterId { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### GpsCreated

Gets true if GPS was created with this component when registered

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### RegisteredAsEncounter

Gets true if component was registered to GE system

##### Declaration

```
bool RegisteredAsEncounter { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### SpawnGroupName

Gets spawn group name, which was used when spawning GE

##### Declaration

```
string SpawnGroupName { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

### Methods

#### AddGlobalEncounterComponent(IMyCubeGrid)

Adds new instance of Global Encounter Component to the grid with the same encounter id

##### Declaration

```
void AddGlobalEncounterComponent(IMyCubeGrid grid)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCubeGrid.html) | grid | grid instance |

#### UnregisterFromEncounter()

Unregisters entity from the encounter so it is not longer considered as part of the global encounter.

##### Declaration

```
void UnregisterFromEncounter()
```