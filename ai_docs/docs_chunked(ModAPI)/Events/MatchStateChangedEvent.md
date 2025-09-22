---
title: "Class MatchStateChangedEvent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.MatchStateChangedEvent.html"
category: "Events"
namespace: "Sandbox.Game"
class: "MatchStateChangedEvent"
---

# Class MatchStateChangedEvent | Space Engineers ModAPI

##### Inheritance

System.Object

MatchStateChangedEvent

###### **Namespace**: [Sandbox.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[VisualScriptingEvent]
public sealed class MatchStateChangedEvent : MulticastDelegate
```

### [](#constructors)Constructors

#### [](#Sandbox_Game_MatchStateChangedEvent__ctor_System_Object_System_IntPtr_)MatchStateChangedEvent(Object, IntPtr)

##### Declaration

```
public MatchStateChangedEvent(object object, IntPtr method)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | object |     |
| System.IntPtr | method |     |

### [](#methods)Methods

#### [](#Sandbox_Game_MatchStateChangedEvent_BeginInvoke_System_String_System_String_System_AsyncCallback_System_Object_)BeginInvoke(String, String, AsyncCallback, Object)

##### Declaration

```
public virtual IAsyncResult BeginInvoke(string oldStateName, string newStateName, AsyncCallback callback, object object)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | oldStateName |     |
| System.String | newStateName |     |
| System.AsyncCallback | callback |     |
| System.Object | object |     |

##### Returns

| Type | Description |
| --- | --- |
| System.IAsyncResult |     |

#### [](#Sandbox_Game_MatchStateChangedEvent_EndInvoke_System_IAsyncResult_)EndInvoke(IAsyncResult)

##### Declaration

```
public virtual void EndInvoke(IAsyncResult result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.IAsyncResult | result |     |

#### [](#Sandbox_Game_MatchStateChangedEvent_Invoke_System_String_System_String_)Invoke(String, String)

##### Declaration

```
public virtual void Invoke(string oldStateName, string newStateName)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | oldStateName |     |
| System.String | newStateName |     |