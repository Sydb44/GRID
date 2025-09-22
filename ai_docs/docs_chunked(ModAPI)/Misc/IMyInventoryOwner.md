---
title: "Interface IMyInventoryOwner"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.IMyInventoryOwner.html"
category: "Misc"
namespace: "VRage.Game.ModAPI.Ingame"
class: "IMyInventoryOwner"
---

# Interface IMyInventoryOwner | Space Engineers ModAPI

Describes interface of object that has inventory (PB scripting interface)

###### **Namespace**: [VRage.Game.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public interface IMyInventoryOwner
```

### Properties

#### EntityId

Gets EntityId, which it belongs to

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### HasInventory

Gets whether has inventory

##### Declaration

```
bool HasInventory { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### InventoryCount

Gets amount of inventories

##### Declaration

```
int InventoryCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### UseConveyorSystem

Gets or sets if that inventory can interact with

##### Declaration

```
bool UseConveyorSystem { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Methods

#### GetInventory(Int32)

Gets inventory by index

##### Declaration

```
IMyInventory GetInventory(int index)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | index | Index of inventory, should be less than [InventoryCount](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.IMyInventoryOwner.html#VRage_Game_ModAPI_Ingame_IMyInventoryOwner_InventoryCount) |

##### Returns

| Type | Description |
| --- | --- |
| [IMyInventory](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.IMyInventory.html) |     |