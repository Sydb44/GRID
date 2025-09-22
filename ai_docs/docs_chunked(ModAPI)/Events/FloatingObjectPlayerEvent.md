---
title: "Class FloatingObjectPlayerEvent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.FloatingObjectPlayerEvent.html"
category: "Events"
namespace: "Sandbox.Game"
class: "FloatingObjectPlayerEvent"
---

# Class FloatingObjectPlayerEvent | Space Engineers ModAPI

##### Inheritance

System.Object

FloatingObjectPlayerEvent

###### **Namespace**: [Sandbox.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[VisualScriptingEvent]
public sealed class FloatingObjectPlayerEvent : MulticastDelegate
```

### Constructors

#### FloatingObjectPlayerEvent(Object, IntPtr)

##### Declaration

```
public FloatingObjectPlayerEvent(object object, IntPtr method)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | object |     |
| System.IntPtr | method |     |

### Methods

#### BeginInvoke(String, String, String, Int64, Int32, AsyncCallback, Object)

##### Declaration

```
public virtual IAsyncResult BeginInvoke(string itemTypeName, string itemSubTypeName, string entityName, long playerId, int amount, AsyncCallback callback, object object)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | itemTypeName |     |
| System.String | itemSubTypeName |     |
| System.String | entityName |     |
| System.Int64 | playerId |     |
| System.Int32 | amount |     |
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

#### Invoke(String, String, String, Int64, Int32)

##### Declaration

```
public virtual void Invoke(string itemTypeName, string itemSubTypeName, string entityName, long playerId, int amount)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | itemTypeName |     |
| System.String | itemSubTypeName |     |
| System.String | entityName |     |
| System.Int64 | playerId |     |
| System.Int32 | amount |     |