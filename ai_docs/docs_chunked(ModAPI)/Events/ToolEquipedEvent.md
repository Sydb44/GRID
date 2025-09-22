---
title: "Class ToolEquipedEvent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.ToolEquipedEvent.html"
category: "Events"
namespace: "Sandbox.Game"
class: "ToolEquipedEvent"
---

# Class ToolEquipedEvent | Space Engineers ModAPI

##### Inheritance

System.Object

ToolEquipedEvent

###### **Namespace**: [Sandbox.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[VisualScriptingEvent]
public sealed class ToolEquipedEvent : MulticastDelegate
```

### Constructors

#### ToolEquipedEvent(Object, IntPtr)

##### Declaration

```
public ToolEquipedEvent(object object, IntPtr method)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | object |     |
| System.IntPtr | method |     |

### Methods

#### BeginInvoke(Int64, String, String, AsyncCallback, Object)

##### Declaration

```
public virtual IAsyncResult BeginInvoke(long playerId, string typeId, string subtypeId, AsyncCallback callback, object object)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | playerId |     |
| System.String | typeId |     |
| System.String | subtypeId |     |
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

#### Invoke(Int64, String, String)

##### Declaration

```
public virtual void Invoke(long playerId, string typeId, string subtypeId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | playerId |     |
| System.String | typeId |     |
| System.String | subtypeId |     |