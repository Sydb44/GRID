---
title: "Class MyAPIGatewayShortcuts.GetWorldBoundariesCallback"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.MyAPIGatewayShortcuts.GetWorldBoundariesCallback.html"
category: "Misc"
namespace: "VRage.ModAPI.MyAPIGatewayShortcuts"
class: "GetWorldBoundariesCallback"
---

# Class MyAPIGatewayShortcuts.GetWorldBoundariesCallback | Space Engineers ModAPI

##### Inheritance

System.Object

MyAPIGatewayShortcuts.GetWorldBoundariesCallback

###### **Namespace**: [VRage.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public sealed class GetWorldBoundariesCallback : MulticastDelegate
```

### Constructors

#### GetWorldBoundariesCallback(Object, IntPtr)

##### Declaration

```
public GetWorldBoundariesCallback(object object, IntPtr method)
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
public virtual BoundingBoxD EndInvoke(IAsyncResult result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.IAsyncResult | result |     |

##### Returns

| Type | Description |
| --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) |     |

#### Invoke()

##### Declaration

```
public virtual BoundingBoxD Invoke()
```

##### Returns

| Type | Description |
| --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) |     |