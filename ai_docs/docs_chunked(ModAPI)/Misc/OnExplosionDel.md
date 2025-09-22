---
title: "Class OnExplosionDel"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.OnExplosionDel.html"
category: "Misc"
namespace: "Sandbox.Game"
class: "OnExplosionDel"
---

# Class OnExplosionDel | Space Engineers ModAPI

##### Inheritance

System.Object

OnExplosionDel

###### **Namespace**: [Sandbox.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public sealed class OnExplosionDel : MulticastDelegate
```

### Constructors

#### OnExplosionDel(Object, IntPtr)

##### Declaration

```
public OnExplosionDel(object object, IntPtr method)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | object |     |
| System.IntPtr | method |     |

### Methods

#### BeginInvoke(ref MyExplosionInfo, AsyncCallback, Object)

##### Declaration

```
public virtual IAsyncResult BeginInvoke(ref MyExplosionInfo explosionInfo, AsyncCallback callback, object object)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyExplosionInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.MyExplosionInfo.html) | explosionInfo |     |
| System.AsyncCallback | callback |     |
| System.Object | object |     |

##### Returns

| Type | Description |
| --- | --- |
| System.IAsyncResult |     |

#### EndInvoke(ref MyExplosionInfo, IAsyncResult)

##### Declaration

```
public virtual void EndInvoke(ref MyExplosionInfo explosionInfo, IAsyncResult result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyExplosionInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.MyExplosionInfo.html) | explosionInfo |     |
| System.IAsyncResult | result |     |

#### Invoke(ref MyExplosionInfo)

##### Declaration

```
public virtual void Invoke(ref MyExplosionInfo explosionInfo)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyExplosionInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.MyExplosionInfo.html) | explosionInfo |     |