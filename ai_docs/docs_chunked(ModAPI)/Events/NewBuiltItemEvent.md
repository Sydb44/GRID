---
title: "Class NewBuiltItemEvent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.NewBuiltItemEvent.html"
category: "Events"
namespace: "Sandbox.Game"
class: "NewBuiltItemEvent"
---

# Class NewBuiltItemEvent | Space Engineers ModAPI

##### Inheritance

System.Object

NewBuiltItemEvent

###### **Namespace**: [Sandbox.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[VisualScriptingEvent]
public sealed class NewBuiltItemEvent : MulticastDelegate
```

### Constructors

#### NewBuiltItemEvent(Object, IntPtr)

##### Declaration

```
public NewBuiltItemEvent(object object, IntPtr method)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | object |     |
| System.IntPtr | method |     |

### Methods

#### BeginInvoke(Int64, Int64, String, String, String, String, Int32, AsyncCallback, Object)

##### Declaration

```
public virtual IAsyncResult BeginInvoke(long entityId, long gridId, string entityName, string gridName, string ItemTypeName, string itemSubTypeName, int amount, AsyncCallback callback, object object)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | entityId |     |
| System.Int64 | gridId |     |
| System.String | entityName |     |
| System.String | gridName |     |
| System.String | ItemTypeName |     |
| System.String | itemSubTypeName |     |
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

#### Invoke(Int64, Int64, String, String, String, String, Int32)

##### Declaration

```
public virtual void Invoke(long entityId, long gridId, string entityName, string gridName, string ItemTypeName, string itemSubTypeName, int amount)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | entityId |     |
| System.Int64 | gridId |     |
| System.String | entityName |     |
| System.String | gridName |     |
| System.String | ItemTypeName |     |
| System.String | itemSubTypeName |     |
| System.Int32 | amount |     |