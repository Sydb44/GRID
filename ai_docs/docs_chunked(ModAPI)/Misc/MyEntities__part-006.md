Description

System.String

name

##### Returns

Type

Description

[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)

#### GetEntityFromRenderObjectID(UInt32)

##### Declaration

```
public static IMyEntity GetEntityFromRenderObjectID(uint renderObjectID)
```

##### Parameters

Type

Name

Description

System.UInt32

renderObjectID

##### Returns

Type

Description

[IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html)

#### GetInflatedPlayerBoundingBox(ref BoundingBoxD, Single)

##### Declaration

```
public static void GetInflatedPlayerBoundingBox(ref BoundingBoxD playerBox, float inflation)
```

##### Parameters

Type

Name

Description

[BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html)

playerBox

System.Single

inflation

#### GetIntersectionWithLine(ref LineD, MyEntity, MyEntity, Boolean, Boolean, Boolean, IntersectionFlags, Single, Boolean, Boolean, Boolean, Boolean)

##### Declaration

```
public static Nullable<MyIntersectionResultLineTriangleEx> GetIntersectionWithLine(ref LineD line, MyEntity ignoreEntity0, MyEntity ignoreEntity1, bool ignoreChildren = false, bool ignoreFloatingObjects = true, bool ignoreHandWeapons = true, IntersectionFlags flags, float timeFrame = 0F, bool ignoreObjectsWithoutPhysics = true, bool ignoreSubgridsOfIgnoredEntities = false, bool ignoreCharacters = false, bool ignoreProjections = false)
```

##### Parameters

Type

Name

Description

[LineD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.LineD.html)

line

[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)

ignoreEntity0

[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)

ignoreEntity1

System.Boolean

ignoreChildren

System.Boolean

ignoreFloatingObjects

System.Boolean

ignoreHandWeapons

[IntersectionFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.IntersectionFlags.html)

flags

System.Single

timeFrame

System.Boolean

ignoreObjectsWithoutPhysics

System.Boolean

ignoreSubgridsOfIgnoredEntities

System.Boolean

ignoreCharacters

System.Boolean

ignoreProjections

##### Returns

Type

Description

System.Nullable<VRage.Game.Models.MyIntersectionResultLineTriangleEx\>

#### GetIntersectionWithSphere(ref BoundingSphereD)

##### Declaration

```
public static MyEntity GetIntersectionWithSphere(ref BoundingSphereD sphere)
```

##### Parameters

Type

Name

Description

[BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html)

sphere

##### Returns

Type

Description

[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)

#### GetIntersectionWithSphere(ref BoundingSphereD, MyEntity, MyEntity)

##### Declaration

```
public static MyEntity GetIntersectionWithSphere(ref BoundingSphereD sphere, MyEntity ignoreEntity0, MyEntity ignoreEntity1)
```

##### Parameters

Type

Name

Description

[BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html)

sphere

[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)

ignoreEntity0

[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)

ignoreEntity1

##### Returns

Type

Description

[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)

#### GetIntersectionWithSphere(ref BoundingSphereD, MyEntity, MyEntity, Boolean, Boolean, Boolean, Boolean, Boolean)

##### Declaration

```
public static MyEntity GetIntersectionWithSphere(ref BoundingSphereD sphere, MyEntity ignoreEntity0, MyEntity ignoreEntity1, bool ignoreVoxelMaps, bool volumetricTest, bool excludeEntitiesWithDisabledPhysics = false, bool ignoreFloatingObjects = true, bool ignoreHandWeapons = true)
```

##### Parameters

Type

Name

Description

[BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html)

sphere

[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)

ignoreEntity0

[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)

ignoreEntity1

System.Boolean

ignoreVoxelMaps

System.Boolean

volumetricTest

System.Boolean

excludeEntitiesWithDisabledPhysics

System.Boolean

ignoreFloatingObjects

System.Boolean

ignoreHandWeapons

##### Returns

Type

Description

[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)

#### GetIntersectionWithSphere(ref BoundingSphereD, MyEntity, MyEntity, Boolean, Boolean, ref List<MyEntity>)

##### Declaration

```
public static void GetIntersectionWithSphere(ref BoundingSphereD sphere, MyEntity ignoreEntity0, MyEntity ignoreEntity1, bool ignoreVoxelMaps, bool volumetricTest, ref List<MyEntity> result)
```

##### Parameters

Type

Name

Description

[BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html)

sphere

[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)

ignoreEntity0

[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)

ignoreEntity1

System.Boolean

ignoreVoxelMaps

System.Boolean

volumetricTest

System.Collections.Generic.List<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\>

result

#### GetTopMostEntitiesInBox(ref BoundingBoxD, List<MyEntity>, MyEntityQueryType)

##### Declaration

```
public static void GetTopMostEntitiesInBox(ref BoundingBoxD boundingBox, List<MyEntity> foundElements, MyEntityQueryType qtype)
```
