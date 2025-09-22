---
title: "Class MyCameraBlock"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCameraBlock.html"
category: "Misc"
namespace: "Sandbox.Game.Entities"
class: "MyCameraBlock"
---

# Class MyCameraBlock | Space Engineers ModAPI

##### Inheritance

System.Object

Sandbox.Game.Entities.Cube.MySyncedBlock

Sandbox.Game.Entities.Cube.MyTerminalBlock

Sandbox.Game.Entities.Cube.MyFunctionalBlock

MyCameraBlock

##### Implements

##### Inherited Members

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyCubeBlockType]
[MyTerminalInterface]
public class MyCameraBlock : MyFunctionalBlock, IMyComponentOwner<MyIDModule>, IMyUpgradableBlock, IMyUpgradableBlock, IMyEventProxy, IMyEventOwner, IMySyncedEntity, IMyTieredUpdateBlock, IMyUpdateTimer, IMyTextSurfaceProvider, IMyTextSurfaceProvider, IMyMultiTextPanelComponentOwner, IMyTextPanelComponentOwner, IMyCameraBlock, IMyCameraController, IMyFunctionalBlock, IMyTerminalBlock, IMyCubeBlock, IMyEntity, IMyCameraBlock, IMyFunctionalBlock, IMyTerminalBlock, IMyCubeBlock, IMyEntity
```

### Constructors

#### MyCameraBlock()

##### Declaration

### Fields

#### DUMMY\_NAME\_POSITION

##### Declaration

```
public const string DUMMY_NAME_POSITION = "camera"
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### ID\_VIEW

##### Declaration

```
public const string ID_VIEW = "View"
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### m\_activeViewers

##### Declaration

```
protected readonly Sync<int, SyncDirection.BothWays> m_activeViewers
```

##### Field Value

| Type | Description |
| --- | --- |
| VRage.Sync.Sync<System.Int32, VRage.Sync.SyncDirection.BothWays\> |     |

### Properties

#### BlockDefinition

##### Declaration

```
public MyCameraBlockDefinition BlockDefinition { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyCameraBlockDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCameraBlockDefinition.html) |     |

#### EnableFirstPersonView

##### Declaration

```
public bool EnableFirstPersonView { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### EnableRaycast

##### Declaration

```
public bool EnableRaycast { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Entity

##### Declaration

```
public MyEntity Entity { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) |     |

#### ForceFirstPersonCamera

##### Declaration

```
public bool ForceFirstPersonCamera { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsActive

##### Declaration

```
public bool IsActive { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsInFirstPersonView

##### Declaration

```
public bool IsInFirstPersonView { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Methods

#### CanUse()

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ChangeZoomPrecise(Single)

##### Declaration

```
public void ChangeZoomPrecise(float deltaZoom)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | deltaZoom |     |

#### CheckAngleLimits(Vector3D)

Checks if the specified world direction relative to the camera is within the valid scanning range

##### Declaration

```
public bool CheckAngleLimits(Vector3D directionNormalized)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | directionNormalized |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### CheckIsWorking()

##### Declaration

```
protected override bool CheckIsWorking()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Overrides

Sandbox.Game.Entities.Cube.MyFunctionalBlock.CheckIsWorking()

#### CreateTerminalControls()

##### Declaration

```
protected override void CreateTerminalControls()
```

##### Overrides

Sandbox.Game.Entities.Cube.MyFunctionalBlock.CreateTerminalControls()

#### GetObjectBuilderCubeBlock(Boolean)

##### Declaration

```
public override MyObjectBuilder_CubeBlock GetObjectBuilderCubeBlock(bool copy = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | copy |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_CubeBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_CubeBlock.html) |     |

##### Overrides

Sandbox.Game.Entities.Cube.MyFunctionalBlock.GetObjectBuilderCubeBlock(System.Boolean)

#### GetOverridingFocusMatrix()

##### Declaration

```
public Nullable<MatrixD> GetOverridingFocusMatrix()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Nullable<[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)\> |     |

#### GetViewMatrix()

##### Declaration

```
public override MatrixD GetViewMatrix()
```

##### Returns

| Type | Description |
| --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) |     |

##### Overrides

#### Init(MyObjectBuilder\_CubeBlock, MyCubeGrid)

##### Declaration

```
public override void Init(MyObjectBuilder_CubeBlock objectBuilder, MyCubeGrid cubeGrid)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_CubeBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_CubeBlock.html) | objectBuilder |     |
| [MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html) | cubeGrid |     |
