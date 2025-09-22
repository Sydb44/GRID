---
title: "Class MyInventoryItem"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.MyInventoryItem.html"
category: "Misc"
namespace: "VRage.Game.ModAPI.Ingame"
class: "MyInventoryItem"
---

# Class MyInventoryItem | Space Engineers ModAPI

Snapshot of inventory item at the moment of query. Not updated afterwards!

##### Inheritance

System.Object

MyInventoryItem

###### **Namespace**: [VRage.Game.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public sealed class MyInventoryItem : ValueType, IComparable<MyInventoryItem>, IEquatable<MyInventoryItem>
```

### Constructors

#### MyInventoryItem(MyItemType, UInt32, MyFixedPoint)

##### Declaration

```
public MyInventoryItem(MyItemType type, uint itemId, MyFixedPoint amount)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyItemType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.MyItemType.html) | type |     |
| System.UInt32 | itemId |     |
| VRage.MyFixedPoint | amount |     |

### Fields

#### Amount

Amount of stacked items. Kg or count, based on item type.

##### Declaration

```
public readonly MyFixedPoint Amount
```

##### Field Value

| Type | Description |
| --- | --- |
| VRage.MyFixedPoint |     |

#### ItemId

Id of item, unique within a single inventory.

##### Declaration

```
public readonly uint ItemId
```

##### Field Value

| Type | Description |
| --- | --- |
| System.UInt32 |     |

#### Type

Type of inventory item.

##### Declaration

```
public readonly MyItemType Type
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyItemType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.MyItemType.html) |     |

### Methods

#### CompareTo(MyInventoryItem)

##### Declaration

```
public int CompareTo(MyInventoryItem other)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyInventoryItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.MyInventoryItem.html) | other |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### Equals(Object)

##### Declaration

```
public override bool Equals(object obj)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | obj |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Equals(MyInventoryItem)

##### Declaration

```
public bool Equals(MyInventoryItem other)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyInventoryItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.MyInventoryItem.html) | other |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### GetHashCode()

##### Declaration

```
public override int GetHashCode()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### ToString()

##### Declaration

```
public override string ToString()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

### Operators

#### Equality(MyInventoryItem, MyInventoryItem)

##### Declaration

```
public static bool operator ==(MyInventoryItem a, MyInventoryItem b)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyInventoryItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.MyInventoryItem.html) | a   |     |
| [MyInventoryItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.MyInventoryItem.html) | b   |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Inequality(MyInventoryItem, MyInventoryItem)

##### Declaration

```
public static bool operator !=(MyInventoryItem a, MyInventoryItem b)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyInventoryItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.MyInventoryItem.html) | a   |     |
| [MyInventoryItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.MyInventoryItem.html) | b   |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |