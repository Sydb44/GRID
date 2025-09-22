---
title: "Interface IMyIntergridCommunicationSystem"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyIntergridCommunicationSystem.html"
category: "Misc"
namespace: "Sandbox.ModAPI.Ingame"
class: "IMyIntergridCommunicationSystem"
---

# Interface IMyIntergridCommunicationSystem | Space Engineers ModAPI

This is the entry point for all communication operations.

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyIntergridCommunicationSystem
```

### Properties

#### Me

Gets communication address for current programmable block.

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### UnicastListener

Gets unicast listener for current programmable block.

##### Declaration

```
IMyUnicastListener UnicastListener { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [IMyUnicastListener](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyUnicastListener.html) |     |

### Methods

#### DisableBroadcastListener(IMyBroadcastListener)

Disables given broadcast listener. In case given broadcast listener is not active nothing happens. Instance of this broadcast listener remains valid and all pending messages may be accepted as normal. Disabling broadcast listener also disables it's message callback, if active. Consuming the last pending message will permanently disable the provided listener and it's never going to be activated again. ==> Registering new broadcast lister with the same tag will allocate new listener instance instead.

##### Declaration

```
void DisableBroadcastListener(IMyBroadcastListener broadcastListener)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyBroadcastListener](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyBroadcastListener.html) | broadcastListener | Broadcast listener which should be deactivated. |

#### GetBroadcastListeners(List<IMyBroadcastListener>, Func<IMyBroadcastListener, Boolean>)

Retrieves list of all active broadcast listeners and listeners with pending messages, registered by current programmable block. Returned list is snapshot of current state and is not updated by future operations.

##### Declaration

```
void GetBroadcastListeners(List<IMyBroadcastListener> broadcastListeners, Func<IMyBroadcastListener, bool> collect = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<[IMyBroadcastListener](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyBroadcastListener.html)\> | broadcastListeners |     |
| System.Func<[IMyBroadcastListener](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyBroadcastListener.html), System.Boolean\> | collect |     |

#### IsEndpointReachable(Int64, TransmissionDistance)

Determines if given endpoint is currently reachable. Similar to sending ICMP message.

##### Declaration

```
bool IsEndpointReachable(long address, TransmissionDistance transmissionDistance)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | address |     |
| [TransmissionDistance](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.TransmissionDistance.html) | transmissionDistance |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### RegisterBroadcastListener(String)

Registers broadcast listener with given tag for current programmable block. In case there is already another active broadcast lister with given tag new listener is NOT registered and the already active one is returned instead.

##### Declaration

```
IMyBroadcastListener RegisterBroadcastListener(string tag)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | tag | String tag broadcast listener should listen for. |

##### Returns

| Type | Description |
| --- | --- |
| [IMyBroadcastListener](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyBroadcastListener.html) | Active broadcast listener for given tag. |

#### SendBroadcastMessage<TData>(String, TData, TransmissionDistance)

Sends broadcast message with given content and tag. This is fire and forget operation and cannot fail. Only broadcast listeners listening to this tag will accept this message. Important: Message will be delivered only to currently reachable IGC endpoints.

##### Declaration

```
void SendBroadcastMessage<TData>(string tag, TData data, TransmissionDistance transmissionDistance)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | tag | Tag of broadcast listeners this message should be accepted by. |
| TData | data | Message data to be send. |
| [TransmissionDistance](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.TransmissionDistance.html) | transmissionDistance | Specifies how far will the be broadcasted |

##### Type Parameters

| Name | Description |
| --- | --- |
| TData |     |

#### SendUnicastMessage<TData>(Int64, String, TData)

Sends unicast message with given content to the PB with specified address. This operation may fail in case the given IGC endpoint is currently unreachable.

##### Declaration

```
bool SendUnicastMessage<TData>(long addressee, string tag, TData data)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | addressee | IGC endpoint to send this message to. |
| System.String | tag | Tags the message type so that the receiving party has easier time recognizing the message |
| TData | data | Message data to be send. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if successfully sent |
