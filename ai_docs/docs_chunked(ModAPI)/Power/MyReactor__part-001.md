---
title: "Class MyReactor"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyReactor.html"
category: "Power"
namespace: "Sandbox.Game.Entities"
class: "MyReactor"
---

# Class MyReactor | Space Engineers ModAPI

##### Inheritance

System.Object

Sandbox.Game.Entities.Cube.MySyncedBlock

Sandbox.Game.Entities.Cube.MyTerminalBlock

Sandbox.Game.Entities.Cube.MyFunctionalBlock

MyReactor

##### Implements

##### Inherited Members

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyCubeBlockType]
[MyTerminalInterface]
public class MyReactor : MyFueledPowerProducer, IMyComponentOwner<MyIDModule>, IMyUpgradableBlock, IMyUpgradableBlock, IMyEventProxy, IMyEventOwner, IMySyncedEntity, IMyTieredUpdateBlock, IMyUpdateTimer, IMyTextSurfaceProvider, IMyTextSurfaceProvider, IMyMultiTextPanelComponentOwner, IMyTextPanelComponentOwner, IMyConveyorEndpointBlock, IMyReactor, IMyReactor, IMyPowerProducer, IMyPowerProducer, IMyFunctionalBlock, IMyFunctionalBlock, IMyTerminalBlock, IMyTerminalBlock, IMyCubeBlock, IMyCubeBlock, IMyEntity, IMyEntity, IMyInventoryOwner
```

### Constructors

#### MyReactor()

##### Declaration

### Properties

#### BlockDefinition

##### Declaration

```
public MyReactorDefinition BlockDefinition { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyReactorDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyReactorDefinition.html) |     |

#### IsTieredUpdateSupported

##### Declaration

```
public override bool IsTieredUpdateSupported { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Overrides

Sandbox.Game.Entities.Cube.MyFunctionalBlock.IsTieredUpdateSupported

#### MaxOutput

##### Declaration

```
public override float MaxOutput { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

##### Overrides

#### UseConveyorSystem

##### Declaration

```
public bool UseConveyorSystem { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Methods

#### CheckEmissiveState(Boolean)

##### Declaration

```
public override void CheckEmissiveState(bool force = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | force |     |

##### Overrides

#### CreateTerminalControls()

##### Declaration

```
protected override void CreateTerminalControls()
```

##### Overrides

Sandbox.Game.Entities.Cube.MyFunctionalBlock.CreateTerminalControls()

#### DoUpdateTimerTick()

##### Declaration

```
public override void DoUpdateTimerTick()
```

##### Overrides

Sandbox.Game.Entities.Cube.MyFunctionalBlock.DoUpdateTimerTick()

#### GetDefaultTimeForUpdateTimer(Int32)

##### Declaration

```
protected override uint GetDefaultTimeForUpdateTimer(int index)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | index |     |

##### Returns

| Type | Description |
| --- | --- |
| System.UInt32 |     |

##### Overrides

Sandbox.Game.Entities.Cube.MyFunctionalBlock.GetDefaultTimeForUpdateTimer(System.Int32)

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

#### GetPullInformation()

##### Declaration

```
public override PullInformation GetPullInformation()
```

##### Returns

| Type | Description |
| --- | --- |
| Sandbox.Game.GameSystems.Conveyors.PullInformation |     |

##### Overrides

#### GetTimerEnabledState()

##### Declaration

```
public override bool GetTimerEnabledState()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Overrides

Sandbox.Game.Entities.Cube.MyFunctionalBlock.GetTimerEnabledState()

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

#### OnCurrentOrMaxOutputChanged(MyDefinitionId, Single, MyResourceSourceComponent)

##### Declaration

```
protected override void OnCurrentOrMaxOutputChanged(MyDefinitionId resourceTypeId, float oldOutput, MyResourceSourceComponent source)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | resourceTypeId |     |
| System.Single | oldOutput |     |
| [MyResourceSourceComponent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyResourceSourceComponent.html) | source |     |

##### Overrides

#### OnEnabledChanged()

##### Declaration

```
protected override void OnEnabledChanged()
```

##### Overrides

#### OnInventoryComponentAdded(MyInventoryBase)

##### Declaration

```
protected override void OnInventoryComponentAdded(MyInventoryBase inventory)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyInventoryBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyInventoryBase.html) | inventory |     |

##### Overrides
