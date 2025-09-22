---
title: "Class CustomAdjustWaypointAboveMinHeightFunction"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.CustomAdjustWaypointAboveMinHeightFunction.html"
category: "Components"
namespace: "Sandbox.Game.EntityComponents"
class: "CustomAdjustWaypointAboveMinHeightFunction"
---

# Class CustomAdjustWaypointAboveMinHeightFunction | Space Engineers ModAPI

##### Inheritance

System.Object

CustomAdjustWaypointAboveMinHeightFunction

###### **Namespace**: [Sandbox.Game.EntityComponents](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public sealed class CustomAdjustWaypointAboveMinHeightFunction : MulticastDelegate
```

### Constructors

#### CustomAdjustWaypointAboveMinHeightFunction(Object, IntPtr)

##### Declaration

```
public CustomAdjustWaypointAboveMinHeightFunction(object object, IntPtr method)
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
public virtual MyAutopilotWaypoint EndInvoke(IAsyncResult result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.IAsyncResult | result |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyAutopilotWaypoint](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyAutopilotWaypoint.html) |     |

#### Invoke()

##### Declaration

```
public virtual MyAutopilotWaypoint Invoke()
```

##### Returns

| Type | Description |
| --- | --- |
| [MyAutopilotWaypoint](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyAutopilotWaypoint.html) |     |