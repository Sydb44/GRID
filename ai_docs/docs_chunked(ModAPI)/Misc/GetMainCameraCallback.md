---
title: "Class MyAPIGatewayShortcuts.GetMainCameraCallback"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.MyAPIGatewayShortcuts.GetMainCameraCallback.html"
category: "Misc"
namespace: "VRage.ModAPI.MyAPIGatewayShortcuts"
class: "GetMainCameraCallback"
---

# Class MyAPIGatewayShortcuts.GetMainCameraCallback | Space Engineers ModAPI

##### Inheritance

System.Object

MyAPIGatewayShortcuts.GetMainCameraCallback

###### **Namespace**: [VRage.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public sealed class GetMainCameraCallback : MulticastDelegate
```

### Constructors

#### GetMainCameraCallback(Object, IntPtr)

##### Declaration

```
public GetMainCameraCallback(object object, IntPtr method)
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
public virtual IMyCamera EndInvoke(IAsyncResult result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.IAsyncResult | result |     |

##### Returns

| Type | Description |
| --- | --- |
| [IMyCamera](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyCamera.html) |     |

#### Invoke()

##### Declaration

```
public virtual IMyCamera Invoke()
```

##### Returns

| Type | Description |
| --- | --- |
| [IMyCamera](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyCamera.html) |     |