---
title: "Class MyTickTimedItem<T>"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyTickTimedItem-1.html"
category: "Misc"
namespace: "VRage.Utils"
class: "MyTickTimedItem-1"
---

# Class MyTickTimedItem<T> | Space Engineers ModAPI

Item that is accessible only for defined amount of time ticks.

##### Inheritance

System.Object

MyTickTimedItem<T>

###### **Namespace**: [VRage.Utils](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.html)

###### **Assembly**: VRage.dll

##### Syntax

```
public sealed class MyTickTimedItem<T> : ValueType
```

##### Type Parameters

| Name | Description |
| --- | --- |
| T   | item type |

### Methods

#### Get()

Get the stored item.

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| T   | storage on success, default value of T on failure. |

#### Set(Int32, T)

Set the stored value.

##### Declaration

```
public void Set(int itemTickTimeout, T item)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | itemTickTimeout | Number of time ticks for which the item is accessible. |
| T   | item | Item to be stored. |

#### TryGet(out T)

Get the stored item.

##### Declaration

```
public bool TryGet(out T outStoredItem)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| T   | outStoredItem | item stored internally |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | true on success, false on timeout |