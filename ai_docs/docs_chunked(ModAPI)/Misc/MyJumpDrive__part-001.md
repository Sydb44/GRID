---
title: "Class MyJumpDrive"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyJumpDrive.html"
category: "Misc"
namespace: "Sandbox.Game.Entities"
class: "MyJumpDrive"
---

# Class MyJumpDrive | Space Engineers ModAPI

##### Inheritance

System.Object

Sandbox.Game.Entities.Cube.MySyncedBlock

Sandbox.Game.Entities.Cube.MyTerminalBlock

Sandbox.Game.Entities.Cube.MyFunctionalBlock

MyJumpDrive

##### Implements

##### Inherited Members

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyCubeBlockType]
[MyTerminalInterface]
public class MyJumpDrive : MyFunctionalBlock, IMyComponentOwner<MyIDModule>, IMyUpgradableBlock, IMyUpgradableBlock, IMyEventProxy, IMyEventOwner, IMySyncedEntity, IMyTieredUpdateBlock, IMyUpdateTimer, IMyTextSurfaceProvider, IMyTextSurfaceProvider, IMyMultiTextPanelComponentOwner, IMyTextPanelComponentOwner, IMyJumpDrive, IMyFunctionalBlock, IMyTerminalBlock, IMyCubeBlock, IMyEntity, IMyJumpDrive, IMyFunctionalBlock, IMyTerminalBlock, IMyCubeBlock, IMyEntity, IMyStoredPowerRatio
```

### Constructors

#### MyJumpDrive()

##### Declaration

### Fields

#### IsJumping

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Properties

#### BlockDefinition

##### Declaration

```
public MyJumpDriveDefinition BlockDefinition { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyJumpDriveDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyJumpDriveDefinition.html) |     |

#### StoredPowerRatio

##### Declaration

```
public float StoredPowerRatio { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

### Methods

#### CanJumpAndHasAccess(Int64)

##### Declaration

```
public bool CanJumpAndHasAccess(long userId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | userId |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### CanJumpIfFullAndHasAccess(Int64)

##### Declaration

```
public bool CanJumpIfFullAndHasAccess(long userId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | userId |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

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

##### Overrides

Sandbox.Game.Entities.Cube.MyFunctionalBlock.Init(VRage.Game.MyObjectBuilder\_CubeBlock, Sandbox.Game.Entities.MyCubeGrid)

#### OnAddedToScene(Object)

##### Declaration

```
public override void OnAddedToScene(object source)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | source |     |

##### Overrides

Sandbox.Game.Entities.Cube.MyFunctionalBlock.OnAddedToScene(System.Object)

#### OnModelChange()

##### Declaration

```
public override void OnModelChange()
```

##### Overrides

Sandbox.Game.Entities.Cube.MyFunctionalBlock.OnModelChange()

#### OnRegisteredToGridSystems()

##### Declaration

```
public override void OnRegisteredToGridSystems()
```

##### Overrides

#### OnUnregisteredFromGridSystems()

##### Declaration

```
public override void OnUnregisteredFromGridSystems()
```

##### Overrides

#### SetEmissiveStateDamaged()

##### Declaration

```
public override bool SetEmissiveStateDamaged()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Overrides

#### SetEmissiveStateDisabled()

##### Declaration

```
public override bool SetEmissiveStateDisabled()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Overrides

#### SetEmissiveStateWorking()

##### Declaration

```
public override bool SetEmissiveStateWorking()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Overrides

#### SetStoredPower(Single)

##### Declaration

```
public void SetStoredPower(float filledRatio)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | filledRatio |     |

#### UpdateAfterSimulation()

##### Declaration

```
public override void UpdateAfterSimulation()
```

##### Overrides

Sandbox.Game.Entities.Cube.MyFunctionalBlock.UpdateAfterSimulation()

#### UpdateAfterSimulation100()

##### Declaration

```
public override void UpdateAfterSimulation100()
```

##### Overrides

Sandbox.Game.Entities.Cube.MyFunctionalBlock.UpdateAfterSimulation100()

#### UpdateDetailedInfo(StringBuilder)

##### Declaration

```
protected override void UpdateDetailedInfo(StringBuilder detailedInfo)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Text.StringBuilder | detailedInfo |     |
