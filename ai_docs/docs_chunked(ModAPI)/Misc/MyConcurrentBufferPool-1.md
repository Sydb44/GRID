---
title: "Class MyConcurrentBufferPool<TElement>"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.MyConcurrentBufferPool-1.html"
category: "Misc"
namespace: "VRage.Collections"
class: "MyConcurrentBufferPool-1"
---

# Class MyConcurrentBufferPool<TElement> | Space Engineers ModAPI

##### Inheritance

System.Object

MyConcurrentBufferPool<TElement>

##### Inherited Members

###### **Namespace**: [VRage.Collections](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.html)

###### **Assembly**: VRage.Library.dll

##### Syntax

```
public class MyConcurrentBufferPool<TElement> : MyConcurrentBucketPool<TElement> where TElement : class
```

##### Type Parameters

| Name | Description |
| --- | --- |
| TElement |     |

### Constructors

#### MyConcurrentBufferPool(String, IMyElementAllocator<TElement>)

##### Declaration

```
public MyConcurrentBufferPool(string debugName, IMyElementAllocator<TElement> allocator)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | debugName |     |
| [IMyElementAllocator](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.IMyElementAllocator-1.html)<TElement> | allocator |     |

### Methods

#### Get(Int32)

##### Declaration

```
public TElement Get(int bucketId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | bucketId |     |

##### Returns

| Type | Description |
| --- | --- |
| TElement |     |