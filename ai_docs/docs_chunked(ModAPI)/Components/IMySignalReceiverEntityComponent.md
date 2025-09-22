---
title: "Interface IMySignalReceiverEntityComponent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMySignalReceiverEntityComponent.html"
category: "Components"
namespace: "Sandbox.ModAPI"
class: "IMySignalReceiverEntityComponent"
---

# Interface IMySignalReceiverEntityComponent | Space Engineers ModAPI

Describes entity component for triggering toolbar-defined actions when receiving a signal

###### **Namespace**: [Sandbox.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMySignalReceiverEntityComponent
```

### Properties

#### AllowSignalsFrom

Gets or sets [MyTransponderRelationFilter](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.MyTransponderRelationFilter.html) which defines allowed relation between signal sender and signal receiver.

##### Declaration

```
MyTransponderRelationFilter AllowSignalsFrom { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyTransponderRelationFilter](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.MyTransponderRelationFilter.html) |     |

### Methods

#### Receive(Int64, Int32)

Checks the channel and relations between receivers' owner and signal sender, triggers if appropriate to do so

##### Declaration

```
bool Receive(long signalSenderOwnerPlayerId, int incomingChannelId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | signalSenderOwnerPlayerId |     |
| System.Int32 | incomingChannelId |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | true if conditions matched, false otherwise |

### Events

#### SignalReceived

Called when a signal is received

##### Declaration

```
event Action<int> SignalReceived
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<System.Int32\> |     |

#### TriggeredBySignal

Called when successfully triggered by a signal

##### Declaration

```
event Action<int> TriggeredBySignal
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<System.Int32\> |     |