relativeSpawner

System.Nullable<[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\>

relativeOffset

System.Boolean

checkPosition

System.Boolean

fadeIn

##### Returns

Type

Description

[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)

#### DebugDraw()

##### Declaration

```
public static void DebugDraw()
```

#### DebugDrawGridStatistics()

##### Declaration

```
public static void DebugDrawGridStatistics()
```

#### DebugDrawStatistics()

##### Declaration

```
public static void DebugDrawStatistics()
```

#### DeleteRememberedEntities()

##### Declaration

```
public static void DeleteRememberedEntities()
```

#### Draw()

##### Declaration

```
public static void Draw()
```

#### EnableEntityBoundingBoxDraw(MyEntity, Boolean, Nullable<Vector4>, Single, Nullable<Vector3>, Nullable<MyStringId>, Boolean)

##### Declaration

```
public static void EnableEntityBoundingBoxDraw(MyEntity entity, bool enable, Nullable<Vector4> color = null, float lineWidth = 0.01F, Nullable<Vector3> inflateAmount = null, Nullable<MyStringId> lineMaterial = null, bool withAxis = false)
```

##### Parameters

Type

Name

Description

[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)

entity

System.Boolean

enable

System.Nullable<[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)\>

color

System.Single

lineWidth

System.Nullable<[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)\>

inflateAmount

System.Nullable<[MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html)\>

lineMaterial

System.Boolean

withAxis

#### EntityExists(Int64)

##### Declaration

```
public static bool EntityExists(long entityId)
```

##### Parameters

Type

Name

Description

System.Int64

entityId

##### Returns

Type

Description

System.Boolean

#### EntityExists(String)

##### Declaration

```
public static bool EntityExists(string name)
```

##### Parameters

Type

Name

Description

System.String

name

##### Returns

Type

Description

System.Boolean

#### EntityNameExists(String)

##### Declaration

```
public static bool EntityNameExists(string name)
```

##### Parameters

Type

Name

Description

System.String

name

##### Returns

Type

Description

System.Boolean

#### Exist(MyEntity)

Checks if entity exists in scene already

##### Declaration

```
public static bool Exist(MyEntity entity)
```

##### Parameters

Type

Name

Description

[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)

entity

##### Returns

Type

Description

System.Boolean

#### FindFreePlace(ref MatrixD, Vector3, Single, Int32, Int32, Single, Boolean)

Finds free place for objects defined by position and radius. StepSize is how fast to increase radius, 0.5f means by half radius.

##### Declaration

```
public static Nullable<Vector3D> FindFreePlace(ref MatrixD matrix, Vector3 axis, float radius, int maxTestCount = 20, int testsPerDistance = 5, float stepSize = 1F, bool allowSafezones = false)
```

##### Parameters

Type

Name

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

matrix

Reference frame from which search for a free place

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

axis

Axis where to perform a rotation searching for a free place

System.Single

radius

System.Int32

maxTestCount

System.Int32

testsPerDistance

System.Single

stepSize

System.Boolean

allowSafezones

##### Returns

Type

Description

System.Nullable<[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\>

#### FindFreePlace(Vector3D, Single, Int32, Int32, Single, MyEntity, Boolean)

Finds free place for objects defined by position and radius. StepSize is how fast to increase radius, 0.5f means by half radius. NOTE: Following method may have the following problems:

1.  CorrectSpawnLocation() should be always followed by a second test for IsShapePenetrating()
    
2.  First overlapping test may result in returning a colliding test sphere with a physics voxel map (case overlappedVoxelmap != null and not a planet)
    
3.  In second overlapping test, CorrectSpawnLocation() is testing from basePos. It should probably test from currentPos cause it's the one that is modified by external cycle
    
4.  In second overlapping test, CorrectSpawnLocation() may have found a safe position but that won't be spotted and the result will be corrupted by the external cycle
    

##### Declaration

```
public static Nullable<Vector3D> FindFreePlace(Vector3D basePos, float radius, int maxTestCount = 20, int testsPerDistance = 5, float stepSize = 1F, MyEntity ignoreEnt = null, bool allowSafezones = false)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

basePos

System.Single

radius

System.Int32

maxTestCount

System.Int32

testsPerDistance

System.Single

stepSize

[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)

ignoreEnt

System.Boolean

allowSafezones

##### Returns

Type

Description

System.Nullable<[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\>

#### FindFreePlaceCustom(Vector3D, Single, Int32, Int32, Single, Single, MyEntity, Boolean)

##### Declaration

```
public static Nullable<Vector3D> FindFreePlaceCustom(Vector3D basePos, float radius, int maxTestCount = 20, int testsPerDistance = 5, float stepSize = 1F, float radiusIncrement = 0F, MyEntity ignoreEnt = null, bool allowSafezones = false)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

basePos

System.Single

radius

System.Int32

maxTestCount

System.Int32

testsPerDistance

System.Single

stepSize

System.Single

radiusIncrement

[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)

ignoreEnt

System.Boolean

allowSafezones
