---
title: "Class MyTimedItem<T>"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyTimedItem-1.html"
category: "Misc"
namespace: "VRage.Utils"
class: "MyTimedItem-1"
---

# Class MyTimedItem<T> | Space Engineers ModAPI

Item that is accessible only for defined time span.

##### Inheritance

System.Object

MyTimedItem<T>

###### **Namespace**: [VRage.Utils](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.html)

###### **Assembly**: VRage.dll

##### Syntax

```
public sealed class MyTimedItem<T> : ValueType
```

##### Type Parameters

| Name | Description |
| --- | --- |
| T   | item type |

### Methods

#### Get(Int32, Boolean)

Get the stored item.

##### Declaration

```
public T Get(int currentTime, bool autoRefreshTimeout)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | currentTime | Pass current time. |
| System.Boolean | autoRefreshTimeout | Should the storage timeout be refreshed? |

##### Returns

| Type | Description |
| --- | --- |
| T   | storage on success, default value of T on failure. |

#### Set(Int32, Int32, T)

Set the stored value.

##### Declaration

```
public void Set(int currentTime, int itemTimeout, T item)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | currentTime | Pass current time. |
| System.Int32 | itemTimeout | Period of time for which the item is accessible. |
| T   | item | Item to be stored. |

#### TryGet(Int32, Boolean, out T)

Get the stored item.

##### Declaration

```
public bool TryGet(int currentTime, bool autoRefreshTimeout, out T outStoredItem)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | currentTime | Pass current time. |
| System.Boolean | autoRefreshTimeout | Should the storage timeout be refreshed? |
| T   | outStoredItem | item stored internally |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | true on success, false on timeout |