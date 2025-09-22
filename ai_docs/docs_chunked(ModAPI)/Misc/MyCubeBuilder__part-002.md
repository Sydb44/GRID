##### Declaration

```
public override MyCubeBlockDefinition CurrentBlockDefinition { get; protected set; }
```

##### Property Value

Type

Description

[MyCubeBlockDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.html)

##### Overrides

#### CurrentGrid

##### Declaration

```
protected override MyCubeGrid CurrentGrid { get; set; }
```

##### Property Value

Type

Description

[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html)

##### Overrides

#### CurrentVoxelBase

##### Declaration

```
protected override MyVoxelBase CurrentVoxelBase { get; set; }
```

##### Property Value

Type

Description

[MyVoxelBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyVoxelBase.html)

##### Overrides

#### Dependencies

##### Declaration

```
public override Type[] Dependencies { get; }
```

##### Property Value

Type

Description

System.Type\[\]

##### Overrides

#### DynamicMode

##### Declaration

```
public bool DynamicMode { get; protected set; }
```

##### Property Value

Type

Description

System.Boolean

#### FreezeGizmo

##### Declaration

```
public bool FreezeGizmo { get; set; }
```

##### Property Value

Type

Description

System.Boolean

#### GridAndBlockValid

##### Declaration

```
protected bool GridAndBlockValid { get; }
```

##### Property Value

Type

Description

System.Boolean

#### GridValid

##### Declaration

```
protected bool GridValid { get; }
```

##### Property Value

Type

Description

System.Boolean

#### IsActivated

##### Declaration

```
public override bool IsActivated { get; }
```

##### Property Value

Type

Description

System.Boolean

##### Overrides

#### IsBuildMode

##### Declaration

```
public bool IsBuildMode { get; set; }
```

##### Property Value

Type

Description

System.Boolean

#### IsCubeSizeModesAvailable

##### Declaration

```
public virtual bool IsCubeSizeModesAvailable { get; }
```

##### Property Value

Type

Description

System.Boolean

#### PlacingSmallGridOnLargeStatic

##### Declaration

```
public bool PlacingSmallGridOnLargeStatic { get; }
```

##### Property Value

Type

Description

System.Boolean

#### RotationAxis

##### Declaration

```
public int RotationAxis { get; }
```

##### Property Value

Type

Description

System.Int32

#### ShowRemoveGizmo

##### Declaration

```
public bool ShowRemoveGizmo { get; set; }
```

##### Property Value

Type

Description

System.Boolean

#### ToolbarBlockDefinition

Current block definition for toolbar.

##### Declaration

```
public MyCubeBlockDefinition ToolbarBlockDefinition { get; }
```

##### Property Value

Type

Description

[MyCubeBlockDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.html)

#### ToolType

##### Declaration

```
public MyCubeBuilderToolType ToolType { get; set; }
```

##### Property Value

Type

Description

[MyCubeBuilderToolType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeBuilderToolType.html)

#### UseSymmetry

##### Declaration

```
public bool UseSymmetry { get; set; }
```

##### Property Value

Type

Description

System.Boolean

#### UseTransparency

##### Declaration

```
public bool UseTransparency { get; set; }
```

##### Property Value

Type

Description

System.Boolean

#### VoxelMapAndBlockValid

##### Declaration

```
protected bool VoxelMapAndBlockValid { get; }
```

##### Property Value

Type

Description

System.Boolean

### Methods

#### Activate(Nullable<MyDefinitionId>, Boolean)

##### Declaration

```
public override void Activate(Nullable<MyDefinitionId> blockDefinitionId = null, bool groupwideDLCCheck = false)
```

##### Parameters

Type

Name

Description

System.Nullable<[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)\>

blockDefinitionId

System.Boolean

groupwideDLCCheck

##### Overrides

#### ActivateColorTool()

##### Declaration

```
public void ActivateColorTool()
```

#### ActivateFromRadialMenu(Nullable<MyDefinitionId>)

##### Declaration

```
public void ActivateFromRadialMenu(Nullable<MyDefinitionId> blockDefinitionId = null)
```

##### Parameters

Type

Name

Description

System.Nullable<[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)\>

blockDefinitionId

#### Add()

##### Declaration

```
public virtual void Add()
```

#### AddBlocksToBuildQueueOrSpawn(MyCubeBlockDefinition, ref MatrixD, Vector3I, Vector3I, Vector3I, Quaternion)

##### Declaration

```
public bool AddBlocksToBuildQueueOrSpawn(MyCubeBlockDefinition blockDefinition, ref MatrixD worldMatrixAdd, Vector3I min, Vector3I max, Vector3I center, Quaternion localOrientation)
```

##### Parameters

Type

Name

Description

[MyCubeBlockDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.html)

blockDefinition

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

worldMatrixAdd

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

min

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

max

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

center

[Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html)

localOrientation

##### Returns

Type

Description

System.Boolean

#### AddConstruction(MyEntity)

##### Declaration

```
public virtual bool AddConstruction(MyEntity builder)
```

##### Parameters

Type

Name

Description

[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)

builder

##### Returns

Type

Description

System.Boolean

#### AddFastBuildModels(MatrixD, ref Matrix, List<MatrixD>, List<String>, MyCubeBlockDefinition, Nullable<Vector3I>, Nullable<Vector3I>)
