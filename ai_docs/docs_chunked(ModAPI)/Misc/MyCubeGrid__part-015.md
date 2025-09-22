line

[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html)

grid

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

position

System.Double

distanceSquared

##### Returns

Type

Description

System.Boolean

#### GetLineIntersectionExactAll(ref LineD, out Double, out MySlimBlock)

Returns closest line (in world space) intersection with all cubes.

##### Declaration

```
public Nullable<Vector3D> GetLineIntersectionExactAll(ref LineD line, out double distance, out MySlimBlock intersectedBlock)
```

##### Parameters

Type

Name

Description

[LineD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.LineD.html)

line

System.Double

distance

Sandbox.Game.Entities.Cube.MySlimBlock

intersectedBlock

##### Returns

Type

Description

System.Nullable<[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\>

#### GetLineIntersectionExactGrid(ref LineD, ref Vector3I, ref Double)

##### Declaration

```
public bool GetLineIntersectionExactGrid(ref LineD line, ref Vector3I position, ref double distanceSquared)
```

##### Parameters

Type

Name

Description

[LineD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.LineD.html)

line

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

position

System.Double

distanceSquared

##### Returns

Type

Description

System.Boolean

#### GetLineIntersectionExactGrid(ref LineD, ref Vector3I, ref Double, Nullable<MyPhysics.HitInfo>)

##### Declaration

```
public bool GetLineIntersectionExactGrid(ref LineD line, ref Vector3I position, ref double distanceSquared, Nullable<MyPhysics.HitInfo> hitInfo)
```

##### Parameters

Type

Name

Description

[LineD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.LineD.html)

line

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

position

System.Double

distanceSquared

System.Nullable<Sandbox.Engine.Physics.MyPhysics.HitInfo\>

hitInfo

##### Returns

Type

Description

System.Boolean

#### GetLineWidthForGizmo(IMyGizmoDrawableObject, BoundingBox)

##### Declaration

```
protected static float GetLineWidthForGizmo(IMyGizmoDrawableObject block, BoundingBox box)
```

##### Parameters

Type

Name

Description

[IMyGizmoDrawableObject](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.IMyGizmoDrawableObject.html)

block

[BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html)

box

##### Returns

Type

Description

System.Single

#### GetMaxThrustInDirection(Base6Directions.Direction)

##### Declaration

```
public float GetMaxThrustInDirection(Base6Directions.Direction direction)
```

##### Parameters

Type

Name

Description

[Base6Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.Direction.html)

direction

##### Returns

Type

Description

System.Single

#### GetObjectBuilder(Boolean)

##### Declaration

```
public override MyObjectBuilder_EntityBase GetObjectBuilder(bool copy = false)
```

##### Parameters

Type

Name

Description

System.Boolean

copy

##### Returns

Type

Description

[MyObjectBuilder\_EntityBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_EntityBase.html)

##### Overrides

#### GetOwnerLoginTimeSeconds()

##### Declaration

```
public float GetOwnerLoginTimeSeconds()
```

##### Returns

Type

Description

System.Single

#### GetOwnerLogoutTimeSeconds()

##### Declaration

```
public float GetOwnerLogoutTimeSeconds()
```

##### Returns

Type

Description

System.Single

#### GetPhysicalGroupAABB()

##### Declaration

```
public BoundingBoxD GetPhysicalGroupAABB()
```

##### Returns

Type

Description

[BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html)

#### GetShapesFromPosition(Vector3I)

##### Declaration

```
public List<HkShape> GetShapesFromPosition(Vector3I pos)
```

##### Parameters

Type

Name

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

pos

##### Returns

Type

Description

System.Collections.Generic.List<Havok.HkShape\>

#### GetTargetedBlock(Vector3D)

##### Declaration

```
public MySlimBlock GetTargetedBlock(Vector3D position)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

position

In world coordinates

##### Returns

Type

Description

Sandbox.Game.Entities.Cube.MySlimBlock

#### GetTargetedBlockLite(Vector3D)

##### Declaration

```
public MySlimBlock GetTargetedBlockLite(Vector3D position)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

position

In world coordinates

##### Returns

Type

Description

Sandbox.Game.Entities.Cube.MySlimBlock

#### GetTargetEntity()

Obtain entity that player is aiming/looking at.

##### Declaration

```
public static MyEntity GetTargetEntity()
```

##### Returns

Type

Description

[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)

#### GetTargetGrid()

Obtain grid that player is aiming/looking at.

##### Declaration

```
public static MyCubeGrid GetTargetGrid()
```

##### Returns

Type

Description

[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html)

#### GridIntegerToWorld(Single, Vector3I, MatrixD)

##### Declaration

```
public static Vector3D GridIntegerToWorld(float gridSize, Vector3I gridCoords, MatrixD worldMatrix)
```

##### Parameters

Type

Name

Description

System.Single

gridSize

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

gridCoords

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

worldMatrix
