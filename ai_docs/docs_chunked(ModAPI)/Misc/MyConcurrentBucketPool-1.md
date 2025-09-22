---
title: "Class MyConcurrentBucketPool<T>"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.MyConcurrentBucketPool-1.html"
category: "Misc"
namespace: "VRage.Collections"
class: "MyConcurrentBucketPool-1"
---

# Class MyConcurrentBucketPool<T> | Space Engineers ModAPI

Simple thread-safe pool. Can store external objects by calling return. Creates new instances when empty.

##### Inheritance

System.Object

MyConcurrentBucketPool<T>

##### Inherited Members

###### **Namespace**: [VRage.Collections](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.html)

###### **Assembly**: VRage.Library.dll

##### Syntax

```
public class MyConcurrentBucketPool<T> : MyConcurrentBucketPool where T : class
```

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

### Constructors

#### MyConcurrentBucketPool(String, IMyElementAllocator<T>, Int32, Boolean)

##### Declaration

```
public MyConcurrentBucketPool(string debugName, IMyElementAllocator<T> allocator, int maxPooledInstances = 2147483647, bool autoClearPool = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | debugName |     |
| [IMyElementAllocator](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.IMyElementAllocator-1.html)<T> | allocator |     |
| System.Int32 | maxPooledInstances |     |
| System.Boolean | autoClearPool |     |

### Methods

#### Clear()

##### Declaration

#### DisposeInternal()

##### Declaration

```
protected override void DisposeInternal()
```

##### Overrides

#### Get(Int32)

##### Declaration

```
public T Get(int bucketId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | bucketId |     |

##### Returns

| Type | Description |
| --- | --- |
| T   |     |

#### GetReport()

##### Declaration

```
public MyBufferStatistics GetReport()
```

##### Returns

| Type | Description |
| --- | --- |
| [MyBufferStatistics](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.MyBufferStatistics.html) |     |

#### Return(T)

##### Declaration

```
public void Return(T instance)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| T   | instance |     |