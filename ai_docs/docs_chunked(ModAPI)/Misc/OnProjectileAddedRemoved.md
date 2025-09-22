---
title: "Class OnProjectileAddedRemoved"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.OnProjectileAddedRemoved.html"
category: "Misc"
namespace: "Sandbox.ModAPI"
class: "OnProjectileAddedRemoved"
---

# Class OnProjectileAddedRemoved | Space Engineers ModAPI

Index is used to get position of projectile Projectile can change it index, when it's index == projectilesCount - 1

##### Inheritance

System.Object

OnProjectileAddedRemoved

###### **Namespace**: [Sandbox.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public sealed class OnProjectileAddedRemoved : MulticastDelegate
```

### Constructors

#### OnProjectileAddedRemoved(Object, IntPtr)

##### Declaration

```
public OnProjectileAddedRemoved(object object, IntPtr method)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | object |     |
| System.IntPtr | method |     |

### Methods

#### BeginInvoke(ref MyProjectileInfo, Int32, AsyncCallback, Object)

##### Declaration

```
public virtual IAsyncResult BeginInvoke(ref MyProjectileInfo projectile, int index, AsyncCallback callback, object object)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyProjectileInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.MyProjectileInfo.html) | projectile |     |
| System.Int32 | index |     |
| System.AsyncCallback | callback |     |
| System.Object | object |     |

##### Returns

| Type | Description |
| --- | --- |
| System.IAsyncResult |     |

#### EndInvoke(ref MyProjectileInfo, IAsyncResult)

##### Declaration

```
public virtual void EndInvoke(ref MyProjectileInfo projectile, IAsyncResult result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyProjectileInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.MyProjectileInfo.html) | projectile |     |
| System.IAsyncResult | result |     |

#### Invoke(ref MyProjectileInfo, Int32)

##### Declaration

```
public virtual void Invoke(ref MyProjectileInfo projectile, int index)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyProjectileInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.MyProjectileInfo.html) | projectile |     |
| System.Int32 | index |     |