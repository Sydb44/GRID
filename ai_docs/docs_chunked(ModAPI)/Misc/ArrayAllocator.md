---
title: "Class MyConcurrentArrayBufferPool<TElement>.ArrayAllocator"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.MyConcurrentArrayBufferPool-1.ArrayAllocator.html"
category: "Misc"
namespace: "VRage.Collections.MyConcurrentArrayBufferPool-1"
class: "ArrayAllocator"
---

# Class MyConcurrentArrayBufferPool<TElement>.ArrayAllocator | Space Engineers ModAPI

##### Inheritance

System.Object

MyConcurrentArrayBufferPool<TElement>.ArrayAllocator

##### Implements

###### **Namespace**: [VRage.Collections](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.html)

###### **Assembly**: VRage.Library.dll

##### Syntax

```
public class ArrayAllocator : Object, IMyElementAllocator<TElement[]>
```

### Constructors

#### ArrayAllocator()

##### Declaration

### Properties

#### ExplicitlyDisposeAllElements

##### Declaration

```
public bool ExplicitlyDisposeAllElements { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Methods

#### Allocate(Int32)

##### Declaration

```
public TElement[] Allocate(int size)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | size |     |

##### Returns

| Type | Description |
| --- | --- |
| TElement\[\] |     |

#### Dispose(TElement\[\])

##### Declaration

```
public void Dispose(TElement[] instance)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| TElement\[\] | instance |     |

#### GetBucketId(TElement\[\])

##### Declaration

```
public int GetBucketId(TElement[] instance)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| TElement\[\] | instance |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### GetBytes(TElement\[\])

##### Declaration

```
public int GetBytes(TElement[] instance)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| TElement\[\] | instance |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### Init(TElement\[\])

##### Declaration

```
public void Init(TElement[] item)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| TElement\[\] | item |     |

### Implements