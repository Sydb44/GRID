---
title: "Interface IMyGridConveyorSystem"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyGridConveyorSystem.html"
category: "Logistics"
namespace: "VRage.ModAPI"
class: "IMyGridConveyorSystem"
---

# Interface IMyGridConveyorSystem | Space Engineers ModAPI

ModAPI interface giving access to grid-group conveyor system

###### **Namespace**: [VRage.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public interface IMyGridConveyorSystem
```

### Methods

#### PullItem(MyDefinitionId, Nullable<MyFixedPoint>, IMyEntity, IMyInventory, Boolean)

Implements pull item with possible optional remove. Computation part of this method is done in parallel, so if you call it on new conveyor network, it will not pull anything for the first time. So the best approach is to call it in some steps, so it does not matter that you don't get result instantly. Be careful not to call it every frame as it can degrade performance.

##### Declaration

```
MyFixedPoint PullItem(MyDefinitionId itemDefinitionId, Nullable<MyFixedPoint> amount, IMyEntity startingBlock, IMyInventory destinationInventory, bool remove)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | itemDefinitionId | Item id |
| System.Nullable<VRage.MyFixedPoint\> | amount | Amount to transfer |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | startingBlock | starting block |
| [IMyInventory](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyInventory.html) | destinationInventory | destination inventory |
| System.Boolean | remove | if true item is removed from inventories instead of transfer |

##### Returns

| Type | Description |
| --- | --- |
| VRage.MyFixedPoint | amount of item pulled |

#### PushGenerateItem(MyDefinitionId, Nullable<MyFixedPoint>, out MyFixedPoint, IMyEntity, Boolean)

Implements push item from one source block. Item will be generated from source.

##### Declaration

```
bool PushGenerateItem(MyDefinitionId itemDefinitionId, Nullable<MyFixedPoint> amount, out MyFixedPoint transferredAmount, IMyEntity sourceBlock, bool partialPush)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | itemDefinitionId | Item type to be transferred |
| System.Nullable<VRage.MyFixedPoint\> | amount | Amount of items to transfer |
| VRage.MyFixedPoint | transferredAmount | Amount of items that was transferred |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | sourceBlock | Source block |
| System.Boolean | partialPush | If true, items fill be pushed even though not all can fit the conveyor system. Items that can't fit will be thrown away. If false, items will be pushed into system only when all of them fits. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | Returns info whether all items could fit in target network or not. |