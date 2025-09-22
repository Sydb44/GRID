---
title: "Class SingleKeyEntityNameGridNameEvent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.SingleKeyEntityNameGridNameEvent.html"
category: "Events"
namespace: "Sandbox.Game"
class: "SingleKeyEntityNameGridNameEvent"
---

# Class SingleKeyEntityNameGridNameEvent | Space Engineers ModAPI

##### Inheritance

System.Object

SingleKeyEntityNameGridNameEvent

###### **Namespace**: [Sandbox.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[VisualScriptingEvent]
public sealed class SingleKeyEntityNameGridNameEvent : MulticastDelegate
```

### [](#constructors)Constructors

#### [](#Sandbox_Game_SingleKeyEntityNameGridNameEvent__ctor_System_Object_System_IntPtr_)SingleKeyEntityNameGridNameEvent(Object, IntPtr)

##### Declaration

```
public SingleKeyEntityNameGridNameEvent(object object, IntPtr method)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | object |     |
| System.IntPtr | method |     |

### [](#methods)Methods

#### [](#Sandbox_Game_SingleKeyEntityNameGridNameEvent_BeginInvoke_System_String_System_String_System_String_System_String_System_AsyncCallback_System_Object_)BeginInvoke(String, String, String, String, AsyncCallback, Object)

##### Declaration

```
public virtual IAsyncResult BeginInvoke(string entityName, string gridName, string typeId, string subtypeId, AsyncCallback callback, object object)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | entityName |     |
| System.String | gridName |     |
| System.String | typeId |     |
| System.String | subtypeId |     |
| System.AsyncCallback | callback |     |
| System.Object | object |     |

##### Returns

| Type | Description |
| --- | --- |
| System.IAsyncResult |     |

#### [](#Sandbox_Game_SingleKeyEntityNameGridNameEvent_EndInvoke_System_IAsyncResult_)EndInvoke(IAsyncResult)

##### Declaration

```
public virtual void EndInvoke(IAsyncResult result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.IAsyncResult | result |     |

#### [](#Sandbox_Game_SingleKeyEntityNameGridNameEvent_Invoke_System_String_System_String_System_String_System_String_)Invoke(String, String, String, String)

##### Declaration

```
public virtual void Invoke(string entityName, string gridName, string typeId, string subtypeId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | entityName |     |
| System.String | gridName |     |
| System.String | typeId |     |
| System.String | subtypeId |     |