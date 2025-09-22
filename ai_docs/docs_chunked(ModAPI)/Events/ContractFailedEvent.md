---
title: "Class ContractFailedEvent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.ContractFailedEvent.html"
category: "Events"
namespace: "Sandbox.Game"
class: "ContractFailedEvent"
---

# Class ContractFailedEvent | Space Engineers ModAPI

##### Inheritance

System.Object

ContractFailedEvent

###### **Namespace**: [Sandbox.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[VisualScriptingEvent]
public sealed class ContractFailedEvent : MulticastDelegate
```

### Constructors

#### ContractFailedEvent(Object, IntPtr)

##### Declaration

```
public ContractFailedEvent(object object, IntPtr method)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | object |     |
| System.IntPtr | method |     |

### Methods

#### BeginInvoke(Int64, MyDefinitionId, Int64, Boolean, Int64, Int64, Int64, Boolean, AsyncCallback, Object)

##### Declaration

```
public virtual IAsyncResult BeginInvoke(long contractId, MyDefinitionId contractDefinitionId, long acceptingPlayerId, bool isPlayerMade, long startingBlockId, long startingFactionId, long startingStationId, bool IsAbandon, AsyncCallback callback, object object)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | contractId |     |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | contractDefinitionId |     |
| System.Int64 | acceptingPlayerId |     |
| System.Boolean | isPlayerMade |     |
| System.Int64 | startingBlockId |     |
| System.Int64 | startingFactionId |     |
| System.Int64 | startingStationId |     |
| System.Boolean | IsAbandon |     |
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

#### Invoke(Int64, MyDefinitionId, Int64, Boolean, Int64, Int64, Int64, Boolean)

##### Declaration

```
public virtual void Invoke(long contractId, MyDefinitionId contractDefinitionId, long acceptingPlayerId, bool isPlayerMade, long startingBlockId, long startingFactionId, long startingStationId, bool IsAbandon)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | contractId |     |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | contractDefinitionId |     |
| System.Int64 | acceptingPlayerId |     |
| System.Boolean | isPlayerMade |     |
| System.Int64 | startingBlockId |     |
| System.Int64 | startingFactionId |     |
| System.Int64 | startingStationId |     |
| System.Boolean | IsAbandon |     |