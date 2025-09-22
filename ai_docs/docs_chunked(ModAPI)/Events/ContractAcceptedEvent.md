---
title: "Class ContractAcceptedEvent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.ContractAcceptedEvent.html"
category: "Events"
namespace: "Sandbox.Game"
class: "ContractAcceptedEvent"
---

# Class ContractAcceptedEvent | Space Engineers ModAPI

##### Inheritance

System.Object

ContractAcceptedEvent

###### **Namespace**: [Sandbox.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[VisualScriptingEvent]
public sealed class ContractAcceptedEvent : MulticastDelegate
```

### Constructors

#### ContractAcceptedEvent(Object, IntPtr)

##### Declaration

```
public ContractAcceptedEvent(object object, IntPtr method)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | object |     |
| System.IntPtr | method |     |

### Methods

#### BeginInvoke(Int64, MyDefinitionId, Int64, Boolean, Int64, Int64, Int64, AsyncCallback, Object)

##### Declaration

```
public virtual IAsyncResult BeginInvoke(long contractId, MyDefinitionId contractDefinitionId, long acceptingPlayerId, bool isPlayerMade, long startingBlockId, long startingFactionId, long startingStationId, AsyncCallback callback, object object)
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

#### Invoke(Int64, MyDefinitionId, Int64, Boolean, Int64, Int64, Int64)

##### Declaration

```
public virtual void Invoke(long contractId, MyDefinitionId contractDefinitionId, long acceptingPlayerId, bool isPlayerMade, long startingBlockId, long startingFactionId, long startingStationId)
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