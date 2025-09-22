---
title: "Class MyTimedItemCache"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyTimedItemCache.html"
category: "Misc"
namespace: "VRage.Utils"
class: "MyTimedItemCache"
---

# Class MyTimedItemCache | Space Engineers ModAPI

Temporaly stores information about item (event/place) existence. This is useful if you want to launch some actions only from time to time. You ask timed cache whether your last event still takes effect.

##### Inheritance

System.Object

MyTimedItemCache

###### **Namespace**: [VRage.Utils](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.html)

###### **Assembly**: VRage.dll

##### Syntax

```
public class MyTimedItemCache : Object
```

### Constructors

#### MyTimedItemCache(Int32)

Constructor.

##### Declaration

```
public MyTimedItemCache(int eventTimeoutMs)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | eventTimeoutMs | Time before |

### Properties

#### EventTimeoutMs

##### Declaration

```
public int EventTimeoutMs { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

### Methods

#### IsItemPresent(Int64, Int32, Boolean)

Generic item. Check whether generic item exists in the timed cache.

autoinsert param: If the item is not found, it is inserted to the cache if the argument autoinsert is true.

##### Declaration

```
public bool IsItemPresent(long itemHashCode, int currentTimeMs, bool autoinsert = true)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | itemHashCode |     |
| System.Int32 | currentTimeMs |     |
| System.Boolean | autoinsert |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsPlaceUsed(Vector3D, Double, Int32, Boolean)

Helper function. Check temporal usage of space. Check whether the place is taken. Internally converts position to generic item. Please use consistent eventSpaceMapping, otherwise cache will not find your items.

autoinsert param: If the item is not found, it is inserted to the cache if the argument autoinsert is true.

##### Declaration

```
public bool IsPlaceUsed(Vector3D position, double eventSpaceMapping, int currentTimeMs, bool autoinsert = true)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | position |     |
| System.Double | eventSpaceMapping |     |
| System.Int32 | currentTimeMs |     |
| System.Boolean | autoinsert |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |