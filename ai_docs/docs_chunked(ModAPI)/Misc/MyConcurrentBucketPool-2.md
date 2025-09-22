---
title: "Class MyConcurrentBucketPool<TElement, TAllocator>"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.MyConcurrentBucketPool-2.html"
category: "Misc"
namespace: "VRage.Collections"
class: "MyConcurrentBucketPool-2"
---

# Class MyConcurrentBucketPool<TElement, TAllocator> | Space Engineers ModAPI

##### Inheritance

System.Object

MyConcurrentBucketPool<TElement, TAllocator>

##### Inherited Members

###### **Namespace**: [VRage.Collections](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.html)

###### **Assembly**: VRage.Library.dll

##### Syntax

```
public class MyConcurrentBucketPool<TElement, TAllocator> : MyConcurrentBucketPool<TElement> where TElement : class where TAllocator : IMyElementAllocator<TElement>, new()
```

##### Type Parameters

| Name | Description |
| --- | --- |
| TElement |     |
| TAllocator |     |

### [](#constructors)Constructors

#### [](#VRage_Collections_MyConcurrentBucketPool_2__ctor_System_String_System_Int32_System_Boolean_)MyConcurrentBucketPool(String, Int32, Boolean)

##### Declaration

```
public MyConcurrentBucketPool(string debugName, int maxPooledInstances = 2147483647, bool autoClearPool = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | debugName |     |
| System.Int32 | maxPooledInstances |     |
| System.Boolean | autoClearPool |     |