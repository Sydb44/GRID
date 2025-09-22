---
title: "Class MyConcurrentBufferPool<TElement, TAllocator>"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.MyConcurrentBufferPool-2.html"
category: "Misc"
namespace: "VRage.Collections"
class: "MyConcurrentBufferPool-2"
---

# Class MyConcurrentBufferPool<TElement, TAllocator> | Space Engineers ModAPI

##### Inheritance

System.Object

MyConcurrentBufferPool<TElement, TAllocator>

##### Inherited Members

###### **Namespace**: [VRage.Collections](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.html)

###### **Assembly**: VRage.Library.dll

##### Syntax

```
public class MyConcurrentBufferPool<TElement, TAllocator> : MyConcurrentBufferPool<TElement> where TElement : class where TAllocator : IMyElementAllocator<TElement>, new()
```

##### Type Parameters

| Name | Description |
| --- | --- |
| TElement |     |
| TAllocator |     |

### Constructors

#### MyConcurrentBufferPool(String)

##### Declaration

```
public MyConcurrentBufferPool(string debugName)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | debugName |     |