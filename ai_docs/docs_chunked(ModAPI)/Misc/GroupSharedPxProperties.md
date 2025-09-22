---
title: "Class MyGridPhysicalGroupData.GroupSharedPxProperties"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyGridPhysicalGroupData.GroupSharedPxProperties.html"
category: "Misc"
namespace: "Sandbox.Game.Entities.MyGridPhysicalGroupData"
class: "GroupSharedPxProperties"
---

# Class MyGridPhysicalGroupData.GroupSharedPxProperties | Space Engineers ModAPI

##### Inheritance

System.Object

MyGridPhysicalGroupData.GroupSharedPxProperties

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public sealed class GroupSharedPxProperties : ValueType
```

### Constructors

#### GroupSharedPxProperties(MyCubeGrid, HkMassProperties, Int32)

##### Declaration

```
public GroupSharedPxProperties(MyCubeGrid referenceGrid, HkMassProperties sharedProperties, int gridCount)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html) | referenceGrid |     |
| Havok.HkMassProperties | sharedProperties |     |
| System.Int32 | gridCount |     |

### Fields

#### GridCount

##### Declaration

```
public readonly int GridCount
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### PxProperties

##### Declaration

```
public readonly HkMassProperties PxProperties
```

##### Field Value

| Type | Description |
| --- | --- |
| Havok.HkMassProperties |     |

#### ReferenceGrid

##### Declaration

```
public readonly MyCubeGrid ReferenceGrid
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html) |     |

### Properties

#### CoMWorld

##### Declaration

```
public Vector3D CoMWorld { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

#### InertiaTensor

Local to reference-grid

##### Declaration

```
public Matrix InertiaTensor { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html) |     |

#### Mass

##### Declaration

```
public float Mass { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

### Methods

#### GetInertiaTensorLocalToGrid(MyCubeGrid)

##### Declaration

```
public Matrix GetInertiaTensorLocalToGrid(MyCubeGrid localGrid)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html) | localGrid |     |

##### Returns

| Type | Description |
| --- | --- |
| [Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html) |     |