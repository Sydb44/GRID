---
title: "Interface IMyChatBroadcastControllerComponent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyChatBroadcastControllerComponent.html"
category: "Components"
namespace: "Sandbox.ModAPI.Ingame"
class: "IMyChatBroadcastControllerComponent"
---

# Interface IMyChatBroadcastControllerComponent | Space Engineers ModAPI

Describes entity component for broadcast controller

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyChatBroadcastControllerComponent
```

### Properties

#### BroadcastTarget

Gets or sets target for messages send from broadcast controller

##### Declaration

```
BroadcastTarget BroadcastTarget { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [BroadcastTarget](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.BroadcastTarget.html) |     |

#### CustomName

Custom name that will be visible in chat

##### Declaration

```
string CustomName { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### MaxMessageCount

Number of messages that can be stored in this broadcast controller

##### Declaration

```
int MaxMessageCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### UseAntenna

Determines if broadcast controller should try to use antenna for broadcasting messages or sent message only to local cube grid

##### Declaration

```
bool UseAntenna { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Methods

#### GetMessage(Int32)

Gets message at given index

##### Declaration

```
string GetMessage(int messageIndex)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | messageIndex | index of message to get |

##### Returns

| Type | Description |
| --- | --- |
| System.String | message or null when not set |

#### SendGps()

Sends current position as a message

##### Declaration

#### SendMessage(Int32)

Sends message

##### Declaration

```
void SendMessage(int messageIndex)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | messageIndex | index of message to be sent |

#### SendMessage(String)

Sends custom message

##### Declaration

```
void SendMessage(string message)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | message | message to send |

#### SendRandomMessage()

Sends randomly one of stored messages

##### Declaration

#### SetMessage(Int32, String)

Sets message at given index

##### Declaration

```
void SetMessage(int messageIndex, string message)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | messageIndex | index of message to be set |
| System.String | message | message to be set |