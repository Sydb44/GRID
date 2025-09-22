---
title: "Class MyCriticalSection\\_Mutex"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyCriticalSection_Mutex.html"
category: "Misc"
namespace: "VRage.Utils"
class: "MyCriticalSection_Mutex"
---

# Class MyCriticalSection\_Mutex | Space Engineers ModAPI

##### Inheritance

System.Object

MyCriticalSection\_Mutex

###### **Namespace**: [VRage.Utils](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.html)

###### **Assembly**: VRage.dll

##### Syntax

```
public class MyCriticalSection_Mutex : Object, ISharedCriticalSection, IDisposable
```

### Constructors

#### MyCriticalSection\_Mutex()

##### Declaration

```
public MyCriticalSection_Mutex()
```

### Methods

#### Dispose()

##### Declaration

#### EnterShared()

##### Declaration

```
public SharedCriticalSection_SharedLock EnterShared()
```

##### Returns

| Type | Description |
| --- | --- |
| VRage.Library.Threading.SharedCriticalSection\_SharedLock |     |

#### EnterUnique()

##### Declaration

```
public SharedCriticalSection_UniqueLock EnterUnique()
```

##### Returns

| Type | Description |
| --- | --- |
| VRage.Library.Threading.SharedCriticalSection\_UniqueLock |     |

#### LeaveShared\_Internal()

##### Declaration

```
public void LeaveShared_Internal()
```

#### LeaveUnique\_Internal()

##### Declaration

```
public void LeaveUnique_Internal()
```