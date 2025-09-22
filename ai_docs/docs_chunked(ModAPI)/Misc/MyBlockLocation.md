---
title: "Class MyCubeGrid.MyBlockLocation"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.MyBlockLocation.html"
category: "Misc"
namespace: "Sandbox.Game.Entities.MyCubeGrid"
class: "MyBlockLocation"
---

# Class MyCubeGrid.MyBlockLocation | Space Engineers ModAPI

##### Inheritance

System.Object

MyCubeGrid.MyBlockLocation

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public sealed class MyBlockLocation : ValueType
```

### Constructors

#### MyBlockLocation(MyDefinitionId, Vector3I, Vector3I, Vector3I, Quaternion, Int64, Int64)

##### Declaration

```
public MyBlockLocation(MyDefinitionId blockDefinition, Vector3I min, Vector3I max, Vector3I center, Quaternion orientation, long entityId, long owner)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | blockDefinition |     |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | min |     |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | max |     |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | center |     |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | orientation |     |
| System.Int64 | entityId |     |
| System.Int64 | owner |     |

### Fields

#### BlockDefinition

##### Declaration

```
public DefinitionIdBlit BlockDefinition
```

##### Field Value

| Type | Description |
| --- | --- |
| [DefinitionIdBlit](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.DefinitionIdBlit.html) |     |

#### CenterPos

##### Declaration

```
public Vector3I CenterPos
```

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) |     |

#### EntityId

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### Max

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) |     |

#### Min

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) |     |

#### Orientation

##### Declaration

```
public MyBlockOrientation Orientation
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyBlockOrientation](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyBlockOrientation.html) |     |

#### Owner

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int64 |     |