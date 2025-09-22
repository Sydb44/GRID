---
title: "Class SingleKeyEntityNameEvent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.SingleKeyEntityNameEvent.html"
category: "Events"
namespace: "Sandbox.Game"
class: "SingleKeyEntityNameEvent"
---

# Class SingleKeyEntityNameEvent | Space Engineers ModAPI

##### Inheritance

System.Object

SingleKeyEntityNameEvent

###### **Namespace**: [Sandbox.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[VisualScriptingEvent]
public sealed class SingleKeyEntityNameEvent : MulticastDelegate
```

### Constructors

#### SingleKeyEntityNameEvent(Object, IntPtr)

##### Declaration

```
public SingleKeyEntityNameEvent(object object, IntPtr method)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | object |     |
| System.IntPtr | method |     |

### Methods

#### BeginInvoke(String, AsyncCallback, Object)

##### Declaration

```
public virtual IAsyncResult BeginInvoke(string entityName, AsyncCallback callback, object object)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | entityName |     |
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

#### Invoke(String)

##### Declaration

```
public virtual void Invoke(string entityName)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | entityName |     |