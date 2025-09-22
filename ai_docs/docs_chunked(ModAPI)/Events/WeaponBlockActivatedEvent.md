---
title: "Class WeaponBlockActivatedEvent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WeaponBlockActivatedEvent.html"
category: "Events"
namespace: "Sandbox.Game"
class: "WeaponBlockActivatedEvent"
---

# Class WeaponBlockActivatedEvent | Space Engineers ModAPI

##### Inheritance

System.Object

WeaponBlockActivatedEvent

###### **Namespace**: [Sandbox.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[VisualScriptingEvent]
public sealed class WeaponBlockActivatedEvent : MulticastDelegate
```

### Constructors

#### WeaponBlockActivatedEvent(Object, IntPtr)

##### Declaration

```
public WeaponBlockActivatedEvent(object object, IntPtr method)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | object |     |
| System.IntPtr | method |     |

### Methods

#### BeginInvoke(Int64, Int64, String, String, String, String, AsyncCallback, Object)

##### Declaration

```
public virtual IAsyncResult BeginInvoke(long entityId, long gridId, string entityName, string gridName, string blockType, string blockSubtype, AsyncCallback callback, object object)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | entityId |     |
| System.Int64 | gridId |     |
| System.String | entityName |     |
| System.String | gridName |     |
| System.String | blockType |     |
| System.String | blockSubtype |     |
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

#### Invoke(Int64, Int64, String, String, String, String)

##### Declaration

```
public virtual void Invoke(long entityId, long gridId, string entityName, string gridName, string blockType, string blockSubtype)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | entityId |     |
| System.Int64 | gridId |     |
| System.String | entityName |     |
| System.String | gridName |     |
| System.String | blockType |     |
| System.String | blockSubtype |     |