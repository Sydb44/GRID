---
title: "Class MatchStateStartedEvent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.MatchStateStartedEvent.html"
category: "Events"
namespace: "Sandbox.Game"
class: "MatchStateStartedEvent"
---

# Class MatchStateStartedEvent | Space Engineers ModAPI

##### Inheritance

System.Object

MatchStateStartedEvent

###### **Namespace**: [Sandbox.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[VisualScriptingEvent]
public sealed class MatchStateStartedEvent : MulticastDelegate
```

### Constructors

#### MatchStateStartedEvent(Object, IntPtr)

##### Declaration

```
public MatchStateStartedEvent(object object, IntPtr method)
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