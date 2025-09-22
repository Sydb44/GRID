---
title: "Class MyConcurrentBucketPool"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.MyConcurrentBucketPool.html"
category: "Misc"
namespace: "VRage.Collections"
class: "MyConcurrentBucketPool"
---

# Class MyConcurrentBucketPool | Space Engineers ModAPI

##### Inheritance

System.Object

MyConcurrentBucketPool

###### **Namespace**: [VRage.Collections](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.html)

###### **Assembly**: VRage.Library.dll

##### Syntax

```
public abstract class MyConcurrentBucketPool : Object
```

### Constructors

#### MyConcurrentBucketPool(Boolean)

##### Declaration

```
protected MyConcurrentBucketPool(bool requiresDispose)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | requiresDispose |     |

### Fields

#### EnablePooling

##### Declaration

```
public static bool EnablePooling
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Methods

#### DisposeInternal()

##### Declaration

```
protected abstract void DisposeInternal()
```

#### OnExit()

##### Declaration

```
public static void OnExit()
```