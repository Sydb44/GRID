---
title: "Class MyConveyorSorter"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyConveyorSorter.html"
category: "Logistics"
namespace: "Sandbox.Game.Entities"
class: "MyConveyorSorter"
---

# Class MyConveyorSorter | Space Engineers ModAPI

##### Inheritance

System.Object

Sandbox.Game.Entities.Cube.MySyncedBlock

Sandbox.Game.Entities.Cube.MyTerminalBlock

Sandbox.Game.Entities.Cube.MyFunctionalBlock

MyConveyorSorter

##### Implements

##### Inherited Members

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyCubeBlockType]
[MyTerminalInterface]
public class MyConveyorSorter : MyFunctionalBlock, IMyComponentOwner<MyIDModule>, IMyUpgradableBlock, IMyUpgradableBlock, IMyEventProxy, IMyEventOwner, IMySyncedEntity, IMyTieredUpdateBlock, IMyUpdateTimer, IMyTextSurfaceProvider, IMyTextSurfaceProvider, IMyMultiTextPanelComponentOwner, IMyTextPanelComponentOwner, IMyConveyorEndpointBlock, IMyConveyorSorter, IMyFunctionalBlock, IMyTerminalBlock, IMyCubeBlock, IMyEntity, IMyConveyorSorter, IMyFunctionalBlock, IMyTerminalBlock, IMyCubeBlock, IMyEntity, IMyInventoryOwner
```

### Constructors

#### MyConveyorSorter()

##### Declaration

```
public MyConveyorSorter()
```

### Properties

#### BlockDefinition

##### Declaration

```
public MyConveyorSorterDefinition BlockDefinition { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyConveyorSorterDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyConveyorSorterDefinition.html) |     |

#### ConveyorEndpoint

##### Declaration

```
public IMyConveyorEndpoint ConveyorEndpoint { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| Sandbox.Game.GameSystems.Conveyors.IMyConveyorEndpoint |     |

#### DrainAll

##### Declaration

```
public bool DrainAll { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsWhitelist

##### Declaration

```
public bool IsWhitelist { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Methods

#### AllowSelfPulling()

##### Declaration

```
public bool AllowSelfPulling()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ChangeBlWl(Boolean)

##### Declaration

```
public void ChangeBlWl(bool IsWl)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | IsWl |     |

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

#### GetPullInformation()

##### Declaration

```
public PullInformation GetPullInformation()
```

##### Returns

| Type | Description |
| --- | --- |
| Sandbox.Game.GameSystems.Conveyors.PullInformation |     |

#### GetPushInformation()

##### Declaration

```
public PullInformation GetPushInformation()
```

##### Returns

| Type | Description |
| --- | --- |
| Sandbox.Game.GameSystems.Conveyors.PullInformation |     |

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

#### InitializeConveyorEndpoint()

##### Declaration

```
public void InitializeConveyorEndpoint()
```

#### IsAllowed(MyDefinitionId)

##### Declaration

```
public bool IsAllowed(MyDefinitionId itemId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | itemId |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

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

#### OnEnabledChanged()

##### Declaration

```
protected override void OnEnabledChanged()
```

##### Overrides

Sandbox.Game.Entities.Cube.MyFunctionalBlock.OnEnabledChanged()

#### OnInventoryComponentAdded(MyInventoryBase)

##### Declaration

```
protected override void OnInventoryComponentAdded(MyInventoryBase inventory)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyInventoryBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyInventoryBase.html) | inventory |     |
