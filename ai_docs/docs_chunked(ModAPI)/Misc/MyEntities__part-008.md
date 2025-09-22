pos

Position of object

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

hintPosition

Position of object few frames back to test whether object enterred voxel. Usually pos - LinearVelocity \* x, where x it time.

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

lastOutsidePos

##### Returns

Type

Description

System.Boolean

#### IsNameExists(MyEntity, String)

##### Declaration

```
public static bool IsNameExists(MyEntity entity, string name)
```

##### Parameters

Type

Name

Description

[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)

entity

System.String

name

##### Returns

Type

Description

System.Boolean

#### IsRaycastBlocked(Vector3D, Vector3D)

##### Declaration

```
public static bool IsRaycastBlocked(Vector3D pos, Vector3D target)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

pos

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

target

##### Returns

Type

Description

System.Boolean

#### IsShapePenetrating(HkShape, ref Vector3D, ref Quaternion, Func<IMyEntity, Boolean>, Int32, Boolean)

##### Declaration

```
public static bool IsShapePenetrating(HkShape shape, ref Vector3D position, ref Quaternion rotation, Func<IMyEntity, bool> entityFilter, int filter = 15, bool allowSafezones = false)
```

##### Parameters

Type

Name

Description

Havok.HkShape

shape

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

position

[Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html)

rotation

System.Func<[IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html), System.Boolean\>

entityFilter

System.Int32

filter

System.Boolean

allowSafezones

##### Returns

Type

Description

System.Boolean

#### IsShapePenetrating(HkShape, ref Vector3D, ref Quaternion, Int32, MyEntity, Boolean)

##### Declaration

```
public static bool IsShapePenetrating(HkShape shape, ref Vector3D position, ref Quaternion rotation, int filter = 15, MyEntity ignoreEnt = null, bool allowSafezones = false)
```

##### Parameters

Type

Name

Description

Havok.HkShape

shape

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

position

[Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html)

rotation

System.Int32

filter

[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)

ignoreEnt

System.Boolean

allowSafezones

##### Returns

Type

Description

System.Boolean

#### IsSpherePenetrating(ref BoundingSphereD, Boolean)

##### Declaration

```
public static bool IsSpherePenetrating(ref BoundingSphereD bs, bool allowSafezones = false)
```

##### Parameters

Type

Name

Description

[BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html)

bs

System.Boolean

allowSafezones

##### Returns

Type

Description

System.Boolean

#### IsTypeHidden(Type)

##### Declaration

```
public static bool IsTypeHidden(Type type)
```

##### Parameters

Type

Name

Description

System.Type

type

##### Returns

Type

Description

System.Boolean

#### IsUpdateInProgress()

##### Declaration

```
public static bool IsUpdateInProgress()
```

##### Returns

Type

Description

System.Boolean

#### IsVisible(IMyEntity)

##### Declaration

```
public static bool IsVisible(IMyEntity entity)
```

##### Parameters

Type

Name

Description

[IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html)

entity

##### Returns

Type

Description

System.Boolean

#### Load(List<MyObjectBuilder\_EntityBase>, out Nullable<MyStringId>)

Returns false when not all entities were loaded

##### Declaration

```
public static bool Load(List<MyObjectBuilder_EntityBase> objectBuilders, out Nullable<MyStringId> errorMessage)
```

##### Parameters

Type

Name

Description

System.Collections.Generic.List<[MyObjectBuilder\_EntityBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_EntityBase.html)\>

objectBuilders

System.Nullable<[MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html)\>

errorMessage

##### Returns

Type

Description

System.Boolean

#### LoadData()

##### Declaration

```
public static void LoadData()
```

#### MemoryLimitAddFailureReset()

##### Declaration

```
public static void MemoryLimitAddFailureReset()
```

#### OverlapAllLineSegment(ref LineD, List<MyLineSegmentOverlapResult<MyEntity>>)

##### Declaration

```
public static void OverlapAllLineSegment(ref LineD line, List<MyLineSegmentOverlapResult<MyEntity>> resultList)
```

##### Parameters

Type

Name

Description

[LineD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.LineD.html)

line

System.Collections.Generic.List<[MyLineSegmentOverlapResult](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyLineSegmentOverlapResult-1.html)<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\>>

resultList

#### RaiseEntityAdd(MyEntity)

##### Declaration

```
public static void RaiseEntityAdd(MyEntity entity)
```

##### Parameters

Type

Name

Description

[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)

entity

#### RaiseEntityCreated(MyEntity)

##### Declaration

```
public static void RaiseEntityCreated(MyEntity entity)
```

##### Parameters

Type

Name

Description

[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)

entity
