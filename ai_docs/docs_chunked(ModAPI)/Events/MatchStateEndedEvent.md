---
title: "Class MatchStateEndedEvent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.MatchStateEndedEvent.html"
category: "Events"
namespace: "Sandbox.Game"
class: "MatchStateEndedEvent"
---

# Class MatchStateEndedEvent | Space Engineers ModAPI

##### Inheritance

System.Object

MatchStateEndedEvent

###### **Namespace**: [Sandbox.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[VisualScriptingEvent]
public sealed class MatchStateEndedEvent : MulticastDelegate
```

### Constructors

#### MatchStateEndedEvent(Object, IntPtr)

##### Declaration

```
public MatchStateEndedEvent(object object, IntPtr method)
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
public virtual IAsyncResult BeginInvoke(string stateName, AsyncCallback callback, object object)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | stateName |     |
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
public virtual void Invoke(string stateName)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | stateName |     |