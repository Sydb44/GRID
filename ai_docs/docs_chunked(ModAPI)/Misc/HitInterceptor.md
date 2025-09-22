---
title: "Class HitInterceptor"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.HitInterceptor.html"
category: "Misc"
namespace: "Sandbox.ModAPI"
class: "HitInterceptor"
---

# Class HitInterceptor | Space Engineers ModAPI

Provide information about projectiles hit.

##### Inheritance

System.Object

HitInterceptor

###### **Namespace**: [Sandbox.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public sealed class HitInterceptor : MulticastDelegate
```

### Constructors

#### HitInterceptor(Object, IntPtr)

##### Declaration

```
public HitInterceptor(object object, IntPtr method)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | object |     |
| System.IntPtr | method |     |

### Methods

#### BeginInvoke(ref MyProjectileInfo, ref MyProjectileHitInfo, AsyncCallback, Object)

##### Declaration

```
public virtual IAsyncResult BeginInvoke(ref MyProjectileInfo projectile, ref MyProjectileHitInfo info, AsyncCallback callback, object object)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyProjectileInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.MyProjectileInfo.html) | projectile |     |
| [MyProjectileHitInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.MyProjectileHitInfo.html) | info |     |
| System.AsyncCallback | callback |     |
| System.Object | object |     |

##### Returns

| Type | Description |
| --- | --- |
| System.IAsyncResult |     |

#### EndInvoke(ref MyProjectileInfo, ref MyProjectileHitInfo, IAsyncResult)

##### Declaration

```
public virtual void EndInvoke(ref MyProjectileInfo projectile, ref MyProjectileHitInfo info, IAsyncResult result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyProjectileInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.MyProjectileInfo.html) | projectile |     |
| [MyProjectileHitInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.MyProjectileHitInfo.html) | info |     |
| System.IAsyncResult | result |     |

#### Invoke(ref MyProjectileInfo, ref MyProjectileHitInfo)

##### Declaration

```
public virtual void Invoke(ref MyProjectileInfo projectile, ref MyProjectileHitInfo info)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyProjectileInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.MyProjectileInfo.html) | projectile |     |
| [MyProjectileHitInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.MyProjectileHitInfo.html) | info |     |