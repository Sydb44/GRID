---
title: "Class PlayerSuitRechargeEvent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.PlayerSuitRechargeEvent.html"
category: "Events"
namespace: "Sandbox.Game"
class: "PlayerSuitRechargeEvent"
---

# Class PlayerSuitRechargeEvent | Space Engineers ModAPI

##### Inheritance

System.Object

PlayerSuitRechargeEvent

###### **Namespace**: [Sandbox.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[VisualScriptingEvent]
public sealed class PlayerSuitRechargeEvent : MulticastDelegate
```

### Constructors

#### PlayerSuitRechargeEvent(Object, IntPtr)

##### Declaration

```
public PlayerSuitRechargeEvent(object object, IntPtr method)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | object |     |
| System.IntPtr | method |     |

### Methods

#### BeginInvoke(Int64, MyLifeSupportingBlockType, AsyncCallback, Object)

##### Declaration

```
public virtual IAsyncResult BeginInvoke(long playerId, MyLifeSupportingBlockType blockType, AsyncCallback callback, object object)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | playerId |     |
| Sandbox.Game.GameSystems.MyLifeSupportingBlockType | blockType |     |
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

#### Invoke(Int64, MyLifeSupportingBlockType)

##### Declaration

```
public virtual void Invoke(long playerId, MyLifeSupportingBlockType blockType)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | playerId |     |
| Sandbox.Game.GameSystems.MyLifeSupportingBlockType | blockType |     |