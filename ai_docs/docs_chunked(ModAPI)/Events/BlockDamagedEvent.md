---
title: "Class BlockDamagedEvent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.BlockDamagedEvent.html"
category: "Events"
namespace: "Sandbox.Game"
class: "BlockDamagedEvent"
---

# Class BlockDamagedEvent | Space Engineers ModAPI

##### Inheritance

System.Object

BlockDamagedEvent

###### **Namespace**: [Sandbox.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[VisualScriptingEvent]
public sealed class BlockDamagedEvent : MulticastDelegate
```

### Constructors

#### BlockDamagedEvent(Object, IntPtr)

##### Declaration

```
public BlockDamagedEvent(object object, IntPtr method)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | object |     |
| System.IntPtr | method |     |

### Methods

#### BeginInvoke(String, String, String, String, Single, String, Int64, AsyncCallback, Object)

##### Declaration

```
public virtual IAsyncResult BeginInvoke(string entityName, string gridName, string typeId, string subtypeId, float damage, string damageType, long attackerId, AsyncCallback callback, object object)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | entityName |     |
| System.String | gridName |     |
| System.String | typeId |     |
| System.String | subtypeId |     |
| System.Single | damage |     |
| System.String | damageType |     |
| System.Int64 | attackerId |     |
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

#### Invoke(String, String, String, String, Single, String, Int64)

##### Declaration

```
public virtual void Invoke(string entityName, string gridName, string typeId, string subtypeId, float damage, string damageType, long attackerId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | entityName |     |
| System.String | gridName |     |
| System.String | typeId |     |
| System.String | subtypeId |     |
| System.Single | damage |     |
| System.String | damageType |     |
| System.Int64 | attackerId |     |