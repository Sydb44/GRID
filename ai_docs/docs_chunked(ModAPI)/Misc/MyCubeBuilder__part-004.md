Type

Description

System.Boolean

#### CheckGizmoRotation()

##### Declaration

```
public void CheckGizmoRotation()
```

#### CheckSmallViewChange()

##### Declaration

```
protected bool CheckSmallViewChange()
```

##### Returns

Type

Description

System.Boolean

#### CheckValidBlockRotation(Matrix, MyBlockDirection, MyBlockRotation)

##### Declaration

```
public static bool CheckValidBlockRotation(Matrix localMatrix, MyBlockDirection blockDirection, MyBlockRotation blockRotation)
```

##### Parameters

Type

Name

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

localMatrix

[MyBlockDirection](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyBlockDirection.html)

blockDirection

[MyBlockRotation](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyBlockRotation.html)

blockRotation

##### Returns

Type

Description

System.Boolean

#### CheckValidBlocksRotation(Matrix, MyCubeGrid)

##### Declaration

```
public static bool CheckValidBlocksRotation(Matrix gridLocalMatrix, MyCubeGrid grid)
```

##### Parameters

Type

Name

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

gridLocalMatrix

[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html)

grid

##### Returns

Type

Description

System.Boolean

#### ChooseHitObject()

##### Declaration

```
protected override void ChooseHitObject()
```

##### Overrides

#### ClearRenderData()

##### Declaration

```
protected void ClearRenderData()
```

#### ColorPickerCancel()

##### Declaration

```
public void ColorPickerCancel()
```

#### ColorPickerOk()

##### Declaration

```
public void ColorPickerOk()
```

#### ContinueBuilding(Boolean)

##### Declaration

```
public virtual void ContinueBuilding(bool planeBuild)
```

##### Parameters

Type

Name

Description

System.Boolean

planeBuild

#### ContinueBuilding(Boolean, Nullable<Vector3I>, Nullable<Vector3I>, ref Nullable<Vector3I>, Vector3I, Vector3I)

Continues building/removing. Do not put any gizmo related stuff here.

##### Declaration

```
protected void ContinueBuilding(bool planeBuild, Nullable<Vector3I> startBuild, Nullable<Vector3I> startRemove, ref Nullable<Vector3I> continueBuild, Vector3I blockMinPosision, Vector3I blockMaxPosition)
```

##### Parameters

Type

Name

Description

System.Boolean

planeBuild

System.Nullable<[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)\>

startBuild

System.Nullable<[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)\>

startRemove

System.Nullable<[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)\>

continueBuild

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

blockMinPosision

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

blockMaxPosition

#### ConvertDynamicGridBlockToStatic(ref MatrixD, MyObjectBuilder\_CubeBlock)

##### Declaration

```
public static MyObjectBuilder_CubeBlock ConvertDynamicGridBlockToStatic(ref MatrixD worldMatrix, MyObjectBuilder_CubeBlock origBlock)
```

##### Parameters

Type

Name

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

worldMatrix

[MyObjectBuilder\_CubeBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_CubeBlock.html)

origBlock

##### Returns

Type

Description

[MyObjectBuilder\_CubeBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_CubeBlock.html)

#### ConvertGridBuilderToStatic(MyObjectBuilder\_CubeGrid, MatrixD)

##### Declaration

```
public static MyObjectBuilder_CubeGrid ConvertGridBuilderToStatic(MyObjectBuilder_CubeGrid originalGrid, MatrixD worldMatrix)
```

##### Parameters

Type

Name

Description

[MyObjectBuilder\_CubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_CubeGrid.html)

originalGrid

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

worldMatrix

##### Returns

Type

Description

[MyObjectBuilder\_CubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_CubeGrid.html)

#### CycleCubePlacementMode()

##### Declaration

```
public void CycleCubePlacementMode()
```

#### Deactivate()

##### Declaration

```
public override void Deactivate()
```

##### Overrides

#### DeactivateBlockCreation()

##### Declaration

```
public void DeactivateBlockCreation()
```

#### Draw()

##### Declaration

```
public override void Draw()
```

##### Overrides

#### DrawBuildingStepsCount(Nullable<Vector3I>, Nullable<Vector3I>, Nullable<Vector3I>, ref Matrix)

##### Declaration

```
protected void DrawBuildingStepsCount(Nullable<Vector3I> startBuild, Nullable<Vector3I> startRemove, Nullable<Vector3I> continueBuild, ref Matrix localMatrixAdd)
```

##### Parameters

Type

Name

Description

System.Nullable<[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)\>

startBuild

System.Nullable<[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)\>

startRemove

System.Nullable<[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)\>

continueBuild

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

localMatrixAdd

#### DrawMountPoints(Single, MyCubeBlockDefinition, MatrixD, MyCubeBlockDefinition.MountPoint\[\])

##### Declaration

```
public static void DrawMountPoints(float cubeSize, MyCubeBlockDefinition def, MatrixD drawMatrix, MyCubeBlockDefinition.MountPoint[] mountPoints)
```

##### Parameters

Type

Name

Description

System.Single

cubeSize

[MyCubeBlockDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.html)

def

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

drawMatrix

[MyCubeBlockDefinition.MountPoint](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.MountPoint.html)\[\]

mountPoints
