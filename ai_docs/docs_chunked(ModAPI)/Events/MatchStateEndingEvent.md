---
title: "Class MatchStateEndingEvent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.MatchStateEndingEvent.html"
category: "Events"
namespace: "Sandbox.Game"
class: "MatchStateEndingEvent"
---

# Class MatchStateEndingEvent | Space Engineers ModAPI

##### Inheritance

System.Object

MatchStateEndingEvent

###### **Namespace**: [Sandbox.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[VisualScriptingEvent]
public sealed class MatchStateEndingEvent : MulticastDelegate
```

### Constructors

#### MatchStateEndingEvent(Object, IntPtr)

##### Declaration

```
public MatchStateEndingEvent(object object, IntPtr method)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | object |     |
| System.IntPtr | method |     |

### Methods

#### BeginInvoke(String, ref Boolean, AsyncCallback, Object)

##### Declaration

```
public virtual IAsyncResult BeginInvoke(string stateCurrentName, ref bool interruptStateChange, AsyncCallback callback, object object)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | stateCurrentName |     |
| System.Boolean | interruptStateChange |     |
| System.AsyncCallback | callback |     |
| System.Object | object |     |

##### Returns

| Type | Description |
| --- | --- |
| System.IAsyncResult |     |

#### EndInvoke(ref Boolean, IAsyncResult)

##### Declaration

```
public virtual void EndInvoke(ref bool interruptStateChange, IAsyncResult result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | interruptStateChange |     |
| System.IAsyncResult | result |     |

#### Invoke(String, ref Boolean)

##### Declaration

```
public virtual void Invoke(string stateCurrentName, ref bool interruptStateChange)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | stateCurrentName |     |
| System.Boolean | interruptStateChange |     |