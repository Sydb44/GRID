---
title: "Class PlayerHealthRechargeEvent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.PlayerHealthRechargeEvent.html"
category: "Events"
namespace: "Sandbox.Game"
class: "PlayerHealthRechargeEvent"
---

# Class PlayerHealthRechargeEvent | Space Engineers ModAPI

##### Inheritance

System.Object

PlayerHealthRechargeEvent

###### **Namespace**: [Sandbox.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[VisualScriptingEvent]
public sealed class PlayerHealthRechargeEvent : MulticastDelegate
```

### Constructors

#### PlayerHealthRechargeEvent(Object, IntPtr)

##### Declaration

```
public PlayerHealthRechargeEvent(object object, IntPtr method)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | object |     |
| System.IntPtr | method |     |

### Methods

#### BeginInvoke(Int64, MyLifeSupportingBlockType, Single, AsyncCallback, Object)

##### Declaration

```
public virtual IAsyncResult BeginInvoke(long playerId, MyLifeSupportingBlockType blockType, float value, AsyncCallback callback, object object)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | playerId |     |
| Sandbox.Game.GameSystems.MyLifeSupportingBlockType | blockType |     |
| System.Single | value |     |
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

#### Invoke(Int64, MyLifeSupportingBlockType, Single)

##### Declaration

```
public virtual void Invoke(long playerId, MyLifeSupportingBlockType blockType, float value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | playerId |     |
| Sandbox.Game.GameSystems.MyLifeSupportingBlockType | blockType |     |
| System.Single | value |     |