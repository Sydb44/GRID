---
title: "Class MyAdvancedDoor"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyAdvancedDoor.html"
category: "Blocks"
namespace: "Sandbox.Game.Entities"
class: "MyAdvancedDoor"
---

# Class MyAdvancedDoor | Space Engineers ModAPI

##### Inheritance

System.Object

Sandbox.Game.Entities.Cube.MySyncedBlock

Sandbox.Game.Entities.Cube.MyTerminalBlock

Sandbox.Game.Entities.Cube.MyFunctionalBlock

MyAdvancedDoor

##### Implements

##### Inherited Members

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyCubeBlockType]
[MyTerminalInterface]
public class MyAdvancedDoor : MyDoorBase, IMyComponentOwner<MyIDModule>, IMyUpgradableBlock, IMyUpgradableBlock, IMyEventProxy, IMyEventOwner, IMySyncedEntity, IMyTieredUpdateBlock, IMyUpdateTimer, IMyTextSurfaceProvider, IMyTextSurfaceProvider, IMyMultiTextPanelComponentOwner, IMyTextPanelComponentOwner, IMyAdvancedDoor, IMyDoor, IMyFunctionalBlock, IMyTerminalBlock, IMyCubeBlock, IMyEntity, IMyAdvancedDoor, IMyDoor, IMyFunctionalBlock, IMyTerminalBlock, IMyCubeBlock, IMyEntity
```

### Constructors

#### MyAdvancedDoor()

##### Declaration

### Properties

#### DisassembleRatio

##### Declaration

```
public override float DisassembleRatio { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

##### Overrides

#### FullyClosed

##### Declaration

```
public bool FullyClosed { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### FullyOpen

##### Declaration

```
public bool FullyOpen { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### OpeningSpeed

##### Declaration

```
public float OpeningSpeed { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### OpenRatio

##### Declaration

```
public float OpenRatio { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

### Methods

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

#### Closing()

##### Declaration

```
protected override void Closing()
```

##### Overrides

Sandbox.Game.Entities.Cube.MyFunctionalBlock.Closing()

#### ContactCallbackInternal()

##### Declaration

```
public override void ContactCallbackInternal()
```

##### Overrides

#### EnableContactCallbacks()

##### Declaration

```
public override bool EnableContactCallbacks()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Overrides

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

#### Init(MyObjectBuilder\_CubeBlock, MyCubeGrid)

##### Declaration

```
public override void Init(MyObjectBuilder_CubeBlock builder, MyCubeGrid cubeGrid)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_CubeBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_CubeBlock.html) | builder |     |
| [MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html) | cubeGrid |     |

##### Overrides

#### IsClosing()

##### Declaration

```
public override bool IsClosing()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Overrides

#### OnBuildSuccess(Int64, Boolean)

##### Declaration

```
public override void OnBuildSuccess(long builtBy, bool instantBuild)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | builtBy |     |
| System.Boolean | instantBuild |     |

##### Overrides

#### OnCubeGridChanged(MyCubeGrid)

##### Declaration

```
public override void OnCubeGridChanged(MyCubeGrid oldGrid)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html) | oldGrid |     |

##### Overrides

#### OnEnabledChanged()

##### Declaration

```
protected override void OnEnabledChanged()
```

##### Overrides

Sandbox.Game.Entities.Cube.MyFunctionalBlock.OnEnabledChanged()

#### OnModelChange()

##### Declaration

```
public override void OnModelChange()
```

##### Overrides

Sandbox.Game.Entities.Cube.MyFunctionalBlock.OnModelChange()

#### OnOpenChanged(SyncBase)

##### Declaration

```
protected override void OnOpenChanged(SyncBase obj)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| VRage.Sync.SyncBase | obj |     |

##### Overrides

#### UpdateAfterSimulation()

##### Declaration

```
public override void UpdateAfterSimulation()
```

##### Overrides

Sandbox.Game.Entities.Cube.MyFunctionalBlock.UpdateAfterSimulation()

#### UpdateOnceBeforeFrame()

##### Declaration

```
public override void UpdateOnceBeforeFrame()
```

##### Overrides

Sandbox.Game.Entities.Cube.MyFunctionalBlock.UpdateOnceBeforeFrame()

#### UpdatePowerInput()

##### Declaration

```
protected float UpdatePowerInput()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### UpdateSoundEmitters()

##### Declaration

```
public override void UpdateSoundEmitters()
```

##### Overrides

Sandbox.Game.Entities.Cube.MyFunctionalBlock.UpdateSoundEmitters()
