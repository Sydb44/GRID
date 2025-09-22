---
title: "Class MyCriticalSection\\_SpinLock"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyCriticalSection_SpinLock.html"
category: "Misc"
namespace: "VRage.Utils"
class: "MyCriticalSection_SpinLock"
---

# Class MyCriticalSection\_SpinLock | Space Engineers ModAPI

##### Inheritance

System.Object

MyCriticalSection\_SpinLock

###### **Namespace**: [VRage.Utils](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.html)

###### **Assembly**: VRage.dll

##### Syntax

```
public class MyCriticalSection_SpinLock : Object, ISharedCriticalSection, IDisposable
```

### Constructors

#### MyCriticalSection\_SpinLock()

##### Declaration

```
public MyCriticalSection_SpinLock()
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