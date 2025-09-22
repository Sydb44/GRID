---
title: "Class BlockEvent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.BlockEvent.html"
category: "Events"
namespace: "Sandbox.Game"
class: "BlockEvent"
---

# Class BlockEvent | Space Engineers ModAPI

##### Inheritance

System.Object

BlockEvent

###### **Namespace**: [Sandbox.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[VisualScriptingEvent]
public sealed class BlockEvent : MulticastDelegate
```

### [](#constructors)Constructors

#### [](#Sandbox_Game_BlockEvent__ctor_System_Object_System_IntPtr_)BlockEvent(Object, IntPtr)

##### Declaration

```
public BlockEvent(object object, IntPtr method)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | object |     |
| System.IntPtr | method |     |

### [](#methods)Methods

#### [](#Sandbox_Game_BlockEvent_BeginInvoke_System_String_System_String_System_String_System_Int64_System_AsyncCallback_System_Object_)BeginInvoke(String, String, String, Int64, AsyncCallback, Object)

##### Declaration

```
public virtual IAsyncResult BeginInvoke(string typeId, string subtypeId, string gridName, long blockId, AsyncCallback callback, object object)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | typeId |     |
| System.String | subtypeId |     |
| System.String | gridName |     |
| System.Int64 | blockId |     |
| System.AsyncCallback | callback |     |
| System.Object | object |     |

##### Returns

| Type | Description |
| --- | --- |
| System.IAsyncResult |     |

#### [](#Sandbox_Game_BlockEvent_EndInvoke_System_IAsyncResult_)EndInvoke(IAsyncResult)

##### Declaration

```
public virtual void EndInvoke(IAsyncResult result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.IAsyncResult | result |     |

#### [](#Sandbox_Game_BlockEvent_Invoke_System_String_System_String_System_String_System_Int64_)Invoke(String, String, String, Int64)

##### Declaration

```
public virtual void Invoke(string typeId, string subtypeId, string gridName, long blockId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | typeId |     |
| System.String | subtypeId |     |
| System.String | gridName |     |
| System.Int64 | blockId |     |