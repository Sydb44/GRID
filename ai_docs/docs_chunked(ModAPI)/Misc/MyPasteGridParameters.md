---
title: "Class MyCubeGrid.MyPasteGridParameters"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.MyPasteGridParameters.html"
category: "Misc"
namespace: "Sandbox.Game.Entities.MyCubeGrid"
class: "MyPasteGridParameters"
---

# Class MyCubeGrid.MyPasteGridParameters | Space Engineers ModAPI

##### Inheritance

System.Object

MyCubeGrid.MyPasteGridParameters

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public sealed class MyPasteGridParameters : ValueType
```

### Constructors

#### MyPasteGridParameters(List<MyObjectBuilder\_CubeGrid>, Boolean, Vector3, Boolean, MyCubeGrid.RelativeOffset, List<UInt64>)

##### Declaration

```
public MyPasteGridParameters(List<MyObjectBuilder_CubeGrid> entities, bool detectDisconnects, Vector3 objectVelocity, bool instantBuild, MyCubeGrid.RelativeOffset offset, List<ulong> clientsideDLCs)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<[MyObjectBuilder\_CubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_CubeGrid.html)\> | entities |     |
| System.Boolean | detectDisconnects |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | objectVelocity |     |
| System.Boolean | instantBuild |     |
| [MyCubeGrid.RelativeOffset](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.RelativeOffset.html) | offset |     |
| System.Collections.Generic.List<System.UInt64\> | clientsideDLCs |     |

### Fields

#### ClientsideDLCs

##### Declaration

```
[Serialize]
public List<ulong> ClientsideDLCs
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<System.UInt64\> |     |

#### DetectDisconnects

##### Declaration

```
public bool DetectDisconnects
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Entities

##### Declaration

```
[Serialize]
public List<MyObjectBuilder_CubeGrid> Entities
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MyObjectBuilder\_CubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_CubeGrid.html)\> |     |

#### InstantBuild

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ObjectVelocity

##### Declaration

```
public Vector3 ObjectVelocity
```

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### Offset

##### Declaration

```
public MyCubeGrid.RelativeOffset Offset
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyCubeGrid.RelativeOffset](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.RelativeOffset.html) |     |