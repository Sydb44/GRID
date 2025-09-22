---
title: "Interface IMyElementAllocator<T>"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.IMyElementAllocator-1.html"
category: "Misc"
namespace: "VRage.Collections"
class: "IMyElementAllocator-1"
---

# Interface IMyElementAllocator<T> | Space Engineers ModAPI

###### **Namespace**: [VRage.Collections](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.html)

###### **Assembly**: VRage.Library.dll

##### Syntax

```
public interface IMyElementAllocator<T>
    where T : class
```

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

### Properties

#### ExplicitlyDisposeAllElements

##### Declaration

```
bool ExplicitlyDisposeAllElements { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Methods

#### Allocate(Int32)

##### Declaration

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | bucketId |     |

##### Returns

| Type | Description |
| --- | --- |
| T   |     |

#### Dispose(T)

##### Declaration

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| T   | instance |     |

#### GetBucketId(T)

##### Declaration

```
int GetBucketId(T instance)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| T   | instance |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### GetBytes(T)

##### Declaration

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| T   | instance |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### Init(T)

##### Declaration

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| T   | instance |     |