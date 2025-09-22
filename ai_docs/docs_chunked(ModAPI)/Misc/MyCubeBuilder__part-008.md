blockMaxPosition

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

blockCenterPosition

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

localMatrixAdd

[MyCubeBlockDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.html)

blockDefinition

#### ToggleSymmetry()

##### Declaration

```
public bool ToggleSymmetry()
```

##### Returns

Type

Description

System.Boolean

#### ToggleSymmetrySetup()

##### Declaration

```
public void ToggleSymmetrySetup()
```

#### TransformLargeGridHitCoordToSmallGrid(Vector3D, MatrixD, Single)

Converts large grid hit coordinates for small cubes. Allows placement of small grids to large grids. Returns coordinates of small grid (in large grid coordinates) which touches large grid in the hit position.

##### Declaration

```
public static Vector3 TransformLargeGridHitCoordToSmallGrid(Vector3D coords, MatrixD worldMatrixNormalizedInv, float gridSize)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

coords

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

worldMatrixNormalizedInv

System.Single

gridSize

##### Returns

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### UnloadData()

##### Declaration

```
protected override void UnloadData()
```

##### Overrides

#### UpdateAfterSimulation()

##### Declaration

```
public override void UpdateAfterSimulation()
```

##### Overrides

#### UpdateBeforeSimulation()

##### Declaration

```
public override void UpdateBeforeSimulation()
```

##### Overrides

#### UpdateBlockInfoHud()

##### Declaration

```
protected static void UpdateBlockInfoHud()
```

#### UpdateCubeBlockDefinition(Nullable<MyDefinitionId>)

##### Declaration

```
protected virtual void UpdateCubeBlockDefinition(Nullable<MyDefinitionId> id)
```

##### Parameters

Type

Name

Description

System.Nullable<[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)\>

id

#### UpdateCubeBlockStageDefinition(MyCubeBlockDefinition)

##### Declaration

```
protected virtual void UpdateCubeBlockStageDefinition(MyCubeBlockDefinition stageCubeBlockDefinition)
```

##### Parameters

Type

Name

Description

[MyCubeBlockDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.html)

stageCubeBlockDefinition

#### UpdateGizmo(MyCubeBuilderGizmo.MyGizmoSpaceProperties, Boolean, Boolean, Boolean)

##### Declaration

```
protected virtual void UpdateGizmo(MyCubeBuilderGizmo.MyGizmoSpaceProperties gizmoSpace, bool add, bool remove, bool draw)
```

##### Parameters

Type

Name

Description

Sandbox.Game.Entities.Cube.MyCubeBuilderGizmo.MyGizmoSpaceProperties

gizmoSpace

System.Boolean

add

System.Boolean

remove

System.Boolean

draw

#### UpdateNotificationBlockNotAvailable(Boolean)

##### Declaration

```
public void UpdateNotificationBlockNotAvailable(bool updateNotAvailableNotification)
```

##### Parameters

Type

Name

Description

System.Boolean

updateNotAvailableNotification

### Events

#### OnActivated

##### Declaration

```
public event Action OnActivated
```

##### Event Type

Type

Description

System.Action

#### OnBlockAdded

##### Declaration

```
public event Action<MyCubeBlockDefinition> OnBlockAdded
```

##### Event Type

Type

Description

System.Action<[MyCubeBlockDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.html)\>

#### OnBlockSizeChanged

##### Declaration

```
public event Action OnBlockSizeChanged
```

##### Event Type

Type

Description

System.Action

#### OnBlockVariantChanged

##### Declaration

```
public event Action OnBlockVariantChanged
```

##### Event Type

Type

Description

System.Action

#### OnDeactivated

##### Declaration

```
public event Action OnDeactivated
```

##### Event Type

Type

Description

System.Action

#### OnSymmetrySetupModeChanged

##### Declaration

```
public event Action OnSymmetrySetupModeChanged
```

##### Event Type

Type

Description

System.Action

#### OnToolTypeChanged

##### Declaration

```
public event Action OnToolTypeChanged
```

##### Event Type

Type

Description

System.Action

### Explicit Interface Implementations

#### IMyCubeBuilder.Activate(Nullable<MyDefinitionId>)

##### Declaration

```
void IMyCubeBuilder.Activate(Nullable<MyDefinitionId> blockDefinitionId)
```

##### Parameters

Type

Name

Description

System.Nullable<[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)\>

blockDefinitionId

#### IMyCubeBuilder.AddConstruction(IMyEntity)

##### Declaration

```
bool IMyCubeBuilder.AddConstruction(IMyEntity buildingEntity)
```

##### Parameters

Type

Name

Description

[IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html)

buildingEntity

##### Returns

Type

Description

System.Boolean

#### IMyCubeBuilder.BlockCreationIsActivated

##### Declaration

```
bool IMyCubeBuilder.BlockCreationIsActivated { get; }
```

##### Returns

Type

Description

System.Boolean

#### IMyCubeBuilder.Deactivate()

##### Declaration

```
void IMyCubeBuilder.Deactivate()
```

#### IMyCubeBuilder.DeactivateBlockCreation()

##### Declaration

```
void IMyCubeBuilder.DeactivateBlockCreation()
```

#### IMyCubeBuilder.FindClosestGrid()

##### Declaration

```
IMyCubeGrid IMyCubeBuilder.FindClosestGrid()
```

##### Returns

Type

Description

[IMyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCubeGrid.html)

#### IMyCubeBuilder.FreezeGizmo

##### Declaration

```
bool IMyCubeBuilder.FreezeGizmo { get; set; }
```

##### Returns

Type

Description

System.Boolean
