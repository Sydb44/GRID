---
title: "Interface IMyEnvironmentOwner"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.IMyEnvironmentOwner.html"
category: "Misc"
namespace: "Sandbox.Game.WorldEnvironment"
class: "IMyEnvironmentOwner"
---

# Interface IMyEnvironmentOwner | Space Engineers ModAPI

###### **Namespace**: [Sandbox.Game.WorldEnvironment](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public interface IMyEnvironmentOwner
```

### Properties

#### Entity

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) |     |

#### EnvironmentDefinition

##### Declaration

```
MyWorldEnvironmentDefinition EnvironmentDefinition { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| Sandbox.Game.WorldEnvironment.Definitions.MyWorldEnvironmentDefinition |     |

### Methods

#### GetBoundingShape(ref Vector3D, ref Vector3, ref Vector3)

##### Declaration

```
Vector3D[] GetBoundingShape(ref Vector3D worldPos, ref Vector3 basisX, ref Vector3 basisY)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | worldPos |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | basisX |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | basisY |     |

##### Returns

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\[\] |     |

#### GetDefinition(UInt16, out MyRuntimeEnvironmentItemInfo)

##### Declaration

```
void GetDefinition(ushort index, out MyRuntimeEnvironmentItemInfo def)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.UInt16 | index |     |
| Sandbox.Game.WorldEnvironment.Definitions.MyRuntimeEnvironmentItemInfo | def |     |

#### GetModelForId(Int16)

##### Declaration

```
MyPhysicalModelDefinition GetModelForId(short id)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int16 | id  |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyPhysicalModelDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyPhysicalModelDefinition.html) |     |

#### GetModelId(MyPhysicalModelDefinition)

##### Declaration

```
short GetModelId(MyPhysicalModelDefinition def)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyPhysicalModelDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyPhysicalModelDefinition.html) | def |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Int16 |     |

#### GetSectorById(Int64)

##### Declaration

```
MyEnvironmentSector GetSectorById(long packedSectorId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | packedSectorId |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyEnvironmentSector](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.MyEnvironmentSector.html) |     |

#### GetSectorForPosition(Vector3D)

##### Declaration

```
MyEnvironmentSector GetSectorForPosition(Vector3D positionWorld)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | positionWorld |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyEnvironmentSector](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.MyEnvironmentSector.html) |     |

#### GetSeed()

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### GetSurfaceNormalForPoint(ref Vector3D, out Vector3D)

##### Declaration

```
void GetSurfaceNormalForPoint(ref Vector3D point, out Vector3D normal)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | point |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | normal |     |

#### ProjectPointToSurface(ref Vector3D)

##### Declaration

```
void ProjectPointToSurface(ref Vector3D center)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | center |     |

#### QuerySurfaceParameters(Vector3D, ref BoundingBoxD, List<Vector3>, MyList<MySurfaceParams>)

##### Declaration

```
void QuerySurfaceParameters(Vector3D localOrigin, ref BoundingBoxD queryBounds, List<Vector3> queries, MyList<MySurfaceParams> results)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | localOrigin |     |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | queryBounds |     |
| System.Collections.Generic.List<[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)\> | queries |     |
| VRage.Library.Collections.MyList<[MySurfaceParams](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.MySurfaceParams.html)\> | results |     |

#### ScheduleWork(MyEnvironmentSector, Boolean)

##### Declaration

```
void ScheduleWork(MyEnvironmentSector sector, bool parallel)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEnvironmentSector](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.MyEnvironmentSector.html) | sector |     |
| System.Boolean | parallel |     |
