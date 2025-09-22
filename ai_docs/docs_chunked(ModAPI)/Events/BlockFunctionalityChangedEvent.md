---
title: "Class BlockFunctionalityChangedEvent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.BlockFunctionalityChangedEvent.html"
category: "Events"
namespace: "Sandbox.Game"
class: "BlockFunctionalityChangedEvent"
---

# Class BlockFunctionalityChangedEvent | Space Engineers ModAPI

##### Inheritance

System.Object

BlockFunctionalityChangedEvent

###### **Namespace**: [Sandbox.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[VisualScriptingEvent]
public sealed class BlockFunctionalityChangedEvent : MulticastDelegate
```

### Constructors

#### BlockFunctionalityChangedEvent(Object, IntPtr)

##### Declaration

```
public BlockFunctionalityChangedEvent(object object, IntPtr method)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | object |     |
| System.IntPtr | method |     |

### Methods

#### BeginInvoke(Int64, Int64, String, String, String, String, Boolean, AsyncCallback, Object)

##### Declaration

```
public virtual IAsyncResult BeginInvoke(long entityId, long gridId, string enitytName, string gridName, string typeId, string subtypeId, bool BecameFunctional, AsyncCallback callback, object object)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | entityId |     |
| System.Int64 | gridId |     |
| System.String | enitytName |     |
| System.String | gridName |     |
| System.String | typeId |     |
| System.String | subtypeId |     |
| System.Boolean | BecameFunctional |     |
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

#### Invoke(Int64, Int64, String, String, String, String, Boolean)

##### Declaration

```
public virtual void Invoke(long entityId, long gridId, string enitytName, string gridName, string typeId, string subtypeId, bool BecameFunctional)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | entityId |     |
| System.Int64 | gridId |     |
| System.String | enitytName |     |
| System.String | gridName |     |
| System.String | typeId |     |
| System.String | subtypeId |     |
| System.Boolean | BecameFunctional |     |