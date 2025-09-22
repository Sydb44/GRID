---
title: "Class MyAPIGatewayShortcuts.GetLocalPlayerPositionCallback"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.MyAPIGatewayShortcuts.GetLocalPlayerPositionCallback.html"
category: "Misc"
namespace: "VRage.ModAPI.MyAPIGatewayShortcuts"
class: "GetLocalPlayerPositionCallback"
---

# Class MyAPIGatewayShortcuts.GetLocalPlayerPositionCallback | Space Engineers ModAPI

##### Inheritance

System.Object

MyAPIGatewayShortcuts.GetLocalPlayerPositionCallback

###### **Namespace**: [VRage.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public sealed class GetLocalPlayerPositionCallback : MulticastDelegate
```

### Constructors

#### GetLocalPlayerPositionCallback(Object, IntPtr)

##### Declaration

```
public GetLocalPlayerPositionCallback(object object, IntPtr method)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | object |     |
| System.IntPtr | method |     |

### Methods

#### BeginInvoke(AsyncCallback, Object)

##### Declaration

```
public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.AsyncCallback | callback |     |
| System.Object | object |     |

##### Returns

| Type | Description |
| --- | --- |
| System.IAsyncResult |     |

#### EndInvoke(IAsyncResult)

##### Declaration

```
public virtual Vector3D EndInvoke(IAsyncResult result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.IAsyncResult | result |     |

##### Returns

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

#### Invoke()

##### Declaration

```
public virtual Vector3D Invoke()
```

##### Returns

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |