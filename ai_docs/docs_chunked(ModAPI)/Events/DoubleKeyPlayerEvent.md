---
title: "Class DoubleKeyPlayerEvent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.DoubleKeyPlayerEvent.html"
category: "Events"
namespace: "Sandbox.Game"
class: "DoubleKeyPlayerEvent"
---

# Class DoubleKeyPlayerEvent | Space Engineers ModAPI

##### Inheritance

System.Object

DoubleKeyPlayerEvent

###### **Namespace**: [Sandbox.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[VisualScriptingEvent]
public sealed class DoubleKeyPlayerEvent : MulticastDelegate
```

### Constructors

#### DoubleKeyPlayerEvent(Object, IntPtr)

##### Declaration

```
public DoubleKeyPlayerEvent(object object, IntPtr method)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | object |     |
| System.IntPtr | method |     |

### Methods

#### BeginInvoke(String, Int64, String, AsyncCallback, Object)

##### Declaration

```
public virtual IAsyncResult BeginInvoke(string entityName, long playerId, string gridName, AsyncCallback callback, object object)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | entityName |     |
| System.Int64 | playerId |     |
| System.String | gridName |     |
| System.AsyncCallback | callback |     |
| System.Object | object |     |

##### Returns

| Type | Description |
| --- | --- |
| System.IAsyncResult |     |

#### EndInvoke(IAsyncResult)

##### Declaration

```
public virtual void EndInvoke(IAsyncResult result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.IAsyncResult | result |     |

#### Invoke(String, Int64, String)

##### Declaration

```
public virtual void Invoke(string entityName, long playerId, string gridName)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | entityName |     |
| System.Int64 | playerId |     |
| System.String | gridName |     |