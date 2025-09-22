---
title: "Class GridPowerGenerationStateChangedEvent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.GridPowerGenerationStateChangedEvent.html"
category: "Events"
namespace: "Sandbox.Game"
class: "GridPowerGenerationStateChangedEvent"
---

# Class GridPowerGenerationStateChangedEvent | Space Engineers ModAPI

##### Inheritance

System.Object

GridPowerGenerationStateChangedEvent

###### **Namespace**: [Sandbox.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[VisualScriptingEvent]
public sealed class GridPowerGenerationStateChangedEvent : MulticastDelegate
```

### [](#constructors)Constructors

#### [](#Sandbox_Game_GridPowerGenerationStateChangedEvent__ctor_System_Object_System_IntPtr_)GridPowerGenerationStateChangedEvent(Object, IntPtr)

##### Declaration

```
public GridPowerGenerationStateChangedEvent(object object, IntPtr method)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | object |     |
| System.IntPtr | method |     |

### [](#methods)Methods

#### [](#Sandbox_Game_GridPowerGenerationStateChangedEvent_BeginInvoke_System_Int64_System_String_System_Boolean_System_AsyncCallback_System_Object_)BeginInvoke(Int64, String, Boolean, AsyncCallback, Object)

##### Declaration

```
public virtual IAsyncResult BeginInvoke(long gridId, string gridName, bool IsPowered, AsyncCallback callback, object object)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | gridId |     |
| System.String | gridName |     |
| System.Boolean | IsPowered |     |
| System.AsyncCallback | callback |     |
| System.Object | object |     |

##### Returns

| Type | Description |
| --- | --- |
| System.IAsyncResult |     |

#### [](#Sandbox_Game_GridPowerGenerationStateChangedEvent_EndInvoke_System_IAsyncResult_)EndInvoke(IAsyncResult)

##### Declaration

```
public virtual void EndInvoke(IAsyncResult result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.IAsyncResult | result |     |

#### [](#Sandbox_Game_GridPowerGenerationStateChangedEvent_Invoke_System_Int64_System_String_System_Boolean_)Invoke(Int64, String, Boolean)

##### Declaration

```
public virtual void Invoke(long gridId, string gridName, bool IsPowered)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | gridId |     |
| System.String | gridName |     |
| System.Boolean | IsPowered |     |