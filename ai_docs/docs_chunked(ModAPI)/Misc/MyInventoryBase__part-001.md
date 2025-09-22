---
title: "Class MyInventoryBase"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyInventoryBase.html"
category: "Misc"
namespace: "VRage.Game.Entity"
class: "MyInventoryBase"
---

# Class MyInventoryBase | Space Engineers ModAPI

##### Inheritance

System.Object

MyInventoryBase

##### Inherited Members

###### **Namespace**: [VRage.Game.Entity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
[MyComponentType]
[StaticEventOwner]
public abstract class MyInventoryBase : MyEntityComponentBase, IMyEntityComponentBase, IMyComponentBase, IMyEventProxy, IMyEventOwner
```

### Constructors

#### MyInventoryBase(String)

##### Declaration

```
public MyInventoryBase(string inventoryId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | inventoryId |     |

### Fields

#### CanPutItems

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsInModifyInventory

##### Declaration

```
public bool IsInModifyInventory
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### RemoveEntityOnEmpty

Setting this flag to true causes to call Close() on the Entity of Container, when the GetItemsCount() == 0. This causes to remove entity from the world, when this inventory is empty.

##### Declaration

```
public bool RemoveEntityOnEmpty
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Properties

#### AttachSyncToEntity

##### Declaration

```
public override bool AttachSyncToEntity { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Overrides

#### ComponentTypeDebugString

##### Declaration

```
public override string ComponentTypeDebugString { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

##### Overrides

#### CurrentMass

##### Declaration

```
public abstract MyFixedPoint CurrentMass { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| VRage.MyFixedPoint |     |

#### CurrentVolume

##### Declaration

```
public abstract MyFixedPoint CurrentVolume { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| VRage.MyFixedPoint |     |

#### ForcedPriority

##### Declaration

```
public abstract Nullable<float> ForcedPriority { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Nullable<System.Single\> |     |

#### InventoryId

This is for the purpose of identifying the inventory in aggregates (i.e. "Backpack", "LeftHand", ...)

##### Declaration

```
public MyStringHash InventoryId { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) |     |

#### MaxItemCount

##### Declaration

```
public abstract int MaxItemCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### MaxMass

##### Declaration

```
public abstract MyFixedPoint MaxMass { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| VRage.MyFixedPoint |     |

#### MaxVolume

##### Declaration

```
public abstract MyFixedPoint MaxVolume { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| VRage.MyFixedPoint |     |

### Methods

#### Add(IMyInventoryItem, MyFixedPoint)

##### Declaration

```
public abstract bool Add(IMyInventoryItem item, MyFixedPoint amount)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyInventoryItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.IMyInventoryItem.html) | item |     |
| VRage.MyFixedPoint | amount |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### AddItems(MyFixedPoint, MyObjectBuilder\_Base)

Adds item to inventory

##### Declaration

```
public abstract bool AddItems(MyFixedPoint amount, MyObjectBuilder_Base objectBuilder)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| VRage.MyFixedPoint | amount |     |
| [MyObjectBuilder\_Base](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_Base.html) | objectBuilder |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | true if items were added, false if items didn't fit |

#### ApplyChanges(List<MyComponentChange>)

##### Declaration

```
public abstract void ApplyChanges(List<MyComponentChange> changes)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<[MyComponentChange](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyComponentChange.html)\> | changes |     |

#### ComputeAmountThatFits(MyDefinitionId, Single, Single)

##### Declaration

```
public abstract MyFixedPoint ComputeAmountThatFits(MyDefinitionId contentId, float volumeRemoved = 0F, float massRemoved = 0F)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | contentId |     |
| System.Single | volumeRemoved |     |
| System.Single | massRemoved |     |

##### Returns

| Type | Description |
| --- | --- |
| VRage.MyFixedPoint |     |

#### ConsumeItem(MyDefinitionId, MyFixedPoint, Int64)

##### Declaration

```
public abstract void ConsumeItem(MyDefinitionId itemId, MyFixedPoint amount, long consumerEntityId = 0L)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | itemId |     |
| VRage.MyFixedPoint | amount |     |
| System.Int64 | consumerEntityId |     |

#### CountItems(Dictionary<MyDefinitionId, MyFixedPoint>)
