[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)

builder

##### Returns

Type

Description

System.Boolean

#### AddFastBuildModels(MatrixD, ref Matrix, List<MatrixD>, List<String>, MyCubeBlockDefinition, Nullable<Vector3I>, Nullable<Vector3I>)

##### Declaration

```
public void AddFastBuildModels(MatrixD baseMatrix, ref Matrix localMatrixAdd, List<MatrixD> matrices, List<string> models, MyCubeBlockDefinition definition, Nullable<Vector3I> startBuild, Nullable<Vector3I> continueBuild)
```

##### Parameters

Type

Name

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

baseMatrix

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

localMatrixAdd

System.Collections.Generic.List<[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)\>

matrices

System.Collections.Generic.List<System.String\>

models

[MyCubeBlockDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.html)

definition

System.Nullable<[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)\>

startBuild

System.Nullable<[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)\>

continueBuild

#### AfterGridBuild(MyEntity, MyCubeGrid, Boolean, UInt64)

##### Declaration

```
protected static void AfterGridBuild(MyEntity builder, MyCubeGrid grid, bool instantBuild, ulong senderId)
```

##### Parameters

Type

Name

Description

[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)

builder

[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html)

grid

System.Boolean

instantBuild

System.UInt64

senderId

#### AlignToGravity(Boolean)

##### Declaration

```
public void AlignToGravity(bool alignToCamera = true)
```

##### Parameters

Type

Name

Description

System.Boolean

alignToCamera

#### AutogenerateMountpoints(HkShape\[\], Single)

##### Declaration

```
public static MyCubeBlockDefinition.MountPoint[] AutogenerateMountpoints(HkShape[] shapes, float gridSize)
```

##### Parameters

Type

Name

Description

Havok.HkShape\[\]

shapes

System.Single

gridSize

##### Returns

Type

Description

[MyCubeBlockDefinition.MountPoint](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.MountPoint.html)\[\]

#### AutogenerateMountpoints(MyModel, Single)

##### Declaration

```
public static MyCubeBlockDefinition.MountPoint[] AutogenerateMountpoints(MyModel model, float gridSize)
```

##### Parameters

Type

Name

Description

VRage.Game.Models.MyModel

model

System.Single

gridSize

##### Returns

Type

Description

[MyCubeBlockDefinition.MountPoint](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.MountPoint.html)\[\]

#### CalculateBlockRotation(Int32, Int32, ref MatrixD, out MatrixD, Double, MyBlockDirection, MyBlockRotation)

##### Declaration

```
public static bool CalculateBlockRotation(int index, int sign, ref MatrixD currentMatrix, out MatrixD rotatedMatrix, double angle, MyBlockDirection blockDirection, MyBlockRotation blockRotation)
```

##### Parameters

Type

Name

Description

System.Int32

index

System.Int32

sign

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

currentMatrix

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

rotatedMatrix

System.Double

angle

[MyBlockDirection](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyBlockDirection.html)

blockDirection

[MyBlockRotation](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyBlockRotation.html)

blockRotation

##### Returns

Type

Description

System.Boolean

#### CalculateFreePlacementMode(Vector3D)

##### Declaration

```
protected void CalculateFreePlacementMode(Vector3D position)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

position

#### CalculateGravityAlignedMode(Vector3D)

##### Declaration

```
protected void CalculateGravityAlignedMode(Vector3D position)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

position

#### CalculateLocalCoordinateSystemMode(Vector3D)

##### Declaration

```
protected void CalculateLocalCoordinateSystemMode(Vector3D position)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

position

#### CaluclateDynamicModePos(Vector3D, Boolean)

Calculates final position of the block in through gizmo.

##### Declaration

```
protected virtual bool CaluclateDynamicModePos(Vector3D defaultPos, bool isDynamicOverride = false)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

defaultPos

Proposed position.

System.Boolean

isDynamicOverride

##### Returns

Type

Description

System.Boolean

If True than success.

#### CancelBuilding()

##### Declaration

```
protected virtual bool CancelBuilding()
```

##### Returns

Type

Description

System.Boolean

#### CanStartConstruction(MyEntity)

##### Declaration

```
public virtual bool CanStartConstruction(MyEntity buildingEntity)
```

##### Parameters

Type

Name

Description

[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)

buildingEntity

##### Returns

Type

Description

System.Boolean

#### CheckGizmoRotation()

##### Declaration

```
public void CheckGizmoRotation()
```
