---
title: "Class MyCargoContainer"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCargoContainer.html"
category: "Logistics"
namespace: "Sandbox.Game.Entities"
class: "MyCargoContainer"
---

# Class MyCargoContainer | Space Engineers ModAPI

##### Inheritance

System.Object

Sandbox.Game.Entities.Cube.MySyncedBlock

Sandbox.Game.Entities.Cube.MyTerminalBlock

MyCargoContainer

##### Implements

##### Inherited Members

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyCubeBlockType]
[MyTerminalInterface]
public class MyCargoContainer : MyTerminalBlock, IMyComponentOwner<MyIDModule>, IMyUpgradableBlock, IMyUpgradableBlock, IMyEventProxy, IMyEventOwner, IMySyncedEntity, IMyConveyorEndpointBlock, IMyCargoContainer, IMyTerminalBlock, IMyCubeBlock, IMyEntity, IMyCargoContainer, IMyTerminalBlock, IMyCubeBlock, IMyEntity, IMyInventoryOwner
```

### Constructors

#### MyCargoContainer()

##### Declaration

```
public MyCargoContainer()
```

### Properties

#### ContainerType

Use this only for debugging/cheating purposes!

##### Declaration

```
public string ContainerType { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### ConveyorEndpoint

##### Declaration

```
public IMyConveyorEndpoint ConveyorEndpoint { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| Sandbox.Game.GameSystems.Conveyors.IMyConveyorEndpoint |     |

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

Sandbox.Game.Entities.Cube.MyTerminalBlock.GetObjectBuilderCubeBlock(System.Boolean)

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

Sandbox.Game.Entities.Cube.MyTerminalBlock.Init(VRage.Game.MyObjectBuilder\_CubeBlock, Sandbox.Game.Entities.MyCubeGrid)

#### InitializeConveyorEndpoint()

##### Declaration

```
public void InitializeConveyorEndpoint()
```

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

#### OnInventoryComponentRemoved(MyInventoryBase)

##### Declaration

```
protected override void OnInventoryComponentRemoved(MyInventoryBase inventory)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyInventoryBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyInventoryBase.html) | inventory |     |

##### Overrides

#### SpawnRandomCargo()

##### Declaration

```
public void SpawnRandomCargo()
```

#### UpdateBeforeSimulation100()

##### Declaration

```
public override void UpdateBeforeSimulation100()
```

##### Overrides

### Explicit Interface Implementations

#### IMyInventoryOwner.EntityId

##### Declaration

```
long IMyInventoryOwner.EntityId { get; }
```

##### Returns

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### IMyInventoryOwner.GetInventory(Int32)

##### Declaration

```
IMyInventory IMyInventoryOwner.GetInventory(int index)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | index |     |

##### Returns

| Type | Description |
| --- | --- |
| [IMyInventory](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.IMyInventory.html) |     |

#### IMyInventoryOwner.HasInventory

##### Declaration

```
bool IMyInventoryOwner.HasInventory { get; }
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IMyInventoryOwner.InventoryCount

##### Declaration

```
int IMyInventoryOwner.InventoryCount { get; }
```

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### IMyInventoryOwner.UseConveyorSystem

##### Declaration

```
bool IMyInventoryOwner.UseConveyorSystem { get; set; }
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Implements

### Extension Methods