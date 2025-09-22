---
title: "Class MissileMoveDelegate"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.MissileMoveDelegate.html"
category: "Misc"
namespace: "Sandbox.ModAPI"
class: "MissileMoveDelegate"
---

# Class MissileMoveDelegate | Space Engineers ModAPI

Missile Move delegate

##### Inheritance

System.Object

MissileMoveDelegate

###### **Namespace**: [Sandbox.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public sealed class MissileMoveDelegate : MulticastDelegate
```

### Constructors

#### MissileMoveDelegate(Object, IntPtr)

##### Declaration

```
public MissileMoveDelegate(object object, IntPtr method)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | object |     |
| System.IntPtr | method |     |

### Methods

#### BeginInvoke(IMyMissile, ref Vector3, AsyncCallback, Object)

##### Declaration

```
public virtual IAsyncResult BeginInvoke(IMyMissile missile, ref Vector3 Velocity, AsyncCallback callback, object object)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyMissile](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyMissile.html) | missile |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | Velocity |     |
| System.AsyncCallback | callback |     |
| System.Object | object |     |

##### Returns

| Type | Description |
| --- | --- |
| System.IAsyncResult |     |

#### EndInvoke(ref Vector3, IAsyncResult)

##### Declaration

```
public virtual void EndInvoke(ref Vector3 Velocity, IAsyncResult result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | Velocity |     |
| System.IAsyncResult | result |     |

#### Invoke(IMyMissile, ref Vector3)

##### Declaration

```
public virtual void Invoke(IMyMissile missile, ref Vector3 Velocity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyMissile](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyMissile.html) | missile |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | Velocity |     |