---
title: "Interface IMyProductionBlock"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyProductionBlock.html"
category: "Production"
namespace: "Sandbox.ModAPI.Ingame"
class: "IMyProductionBlock"
---

# Interface IMyProductionBlock | Space Engineers ModAPI

Describes production block (assembler/refinery/survival kit) (PB scripting interface)

##### Inherited Members

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyProductionBlock : IMyFunctionalBlock, IMyTerminalBlock, IMyCubeBlock, IMyEntity
```

### Properties

#### InputInventory

Gets the input inventory.

##### Declaration

```
IMyInventory InputInventory { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [IMyInventory](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.IMyInventory.html) |     |

#### IsProducing

Gets whether block is currently producing.

##### Declaration

```
bool IsProducing { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsQueueEmpty

Gets whether production queue is empty.

##### Declaration

```
bool IsQueueEmpty { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### NextItemId

Gets the queue item ID of the next item to be produced.

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.UInt32 |     |

#### OutputInventory

Gets the output inventory.

##### Declaration

```
IMyInventory OutputInventory { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [IMyInventory](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.IMyInventory.html) |     |

#### UseConveyorSystem

Gets or sets whether this device should use the conveyor system to retrieve and store items.

##### Declaration

```
bool UseConveyorSystem { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Methods

#### AddQueueItem(MyDefinitionId, Decimal)

Adds a blueprint to the production queue

##### Declaration

```
void AddQueueItem(MyDefinitionId blueprint, Decimal amount)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | blueprint | A MyDefinitionId that names the blueprint |
| System.Decimal | amount | Amount of items |

#### AddQueueItem(MyDefinitionId, Double)

Adds a blueprint to the production queue

##### Declaration

```
void AddQueueItem(MyDefinitionId blueprint, double amount)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | blueprint | A MyDefinitionId that names the blueprint |
| System.Double | amount | Amount of items |

#### AddQueueItem(MyDefinitionId, MyFixedPoint)

Adds a blueprint to the production queue

##### Declaration

```
void AddQueueItem(MyDefinitionId blueprint, MyFixedPoint amount)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | blueprint | A MyDefinitionId that names the blueprint |
| VRage.MyFixedPoint | amount | Amount of items |

#### CanUseBlueprint(MyDefinitionId)

Can this production block produce this blueprint?

##### Declaration

```
bool CanUseBlueprint(MyDefinitionId blueprint)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | blueprint | A MyDefinitionId that names the blueprint |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if production block can use blueprint |

#### ClearQueue()

Clears the Queue

##### Declaration

#### GetQueue(List<MyProductionItem>)

Gets the current production queue

##### Declaration

```
void GetQueue(List<MyProductionItem> items)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<[MyProductionItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.MyProductionItem.html)\> | items |     |

#### InsertQueueItem(Int32, MyDefinitionId, Decimal)

Inserts a blueprint into the production queue

##### Declaration

```
void InsertQueueItem(int idx, MyDefinitionId blueprint, Decimal amount)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | idx | Index of the item |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | blueprint | A MyDefinitionId that names the blueprint |
| System.Decimal | amount | Amount of items |

#### InsertQueueItem(Int32, MyDefinitionId, Double)

Inserts a blueprint into the production queue

##### Declaration

```
void InsertQueueItem(int idx, MyDefinitionId blueprint, double amount)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | idx | Index of the item |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | blueprint | A MyDefinitionId that names the blueprint |
| System.Double | amount | Amount of items |

#### InsertQueueItem(Int32, MyDefinitionId, MyFixedPoint)

Inserts a blueprint into the production queue

##### Declaration

```
void InsertQueueItem(int idx, MyDefinitionId blueprint, MyFixedPoint amount)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | idx | Index of the item |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | blueprint | A MyDefinitionId that names the blueprint |
| VRage.MyFixedPoint | amount | Amount of items |
