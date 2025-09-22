---
title: "Interface IMyMessageProvider"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyMessageProvider.html"
category: "Misc"
namespace: "Sandbox.ModAPI.Ingame"
class: "IMyMessageProvider"
---

# Interface IMyMessageProvider | Space Engineers ModAPI

Base interface for all message providers.

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyMessageProvider
```

### Properties

#### HasPendingMessage

Determines whether there is a message pending to be accepted in this message provider or not. There may be multiple messages pending in single message provider. In such case the flag will stay raised until the last message is consumed.

##### Declaration

```
bool HasPendingMessage { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### MaxWaitingMessages

Indicates number of max messages waiting in queue before the oldest one will be dropped to make space for new one.

##### Declaration

```
int MaxWaitingMessages { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

### Methods

#### AcceptMessage()

Accepts first message from pending message queue for this message provider. Messages are guaranteed to be dequeued and returned by this method in order they arrived.

##### Declaration

```
MyIGCMessage AcceptMessage()
```

##### Returns

| Type | Description |
| --- | --- |
| [MyIGCMessage](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.MyIGCMessage.html) | First message from pending message queue, default([MyIGCMessage](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.MyIGCMessage.html)) if there are no messages pending to be accepted. |

#### DisableMessageCallback()

Disables registered message callback.

##### Declaration

```
void DisableMessageCallback()
```

#### SetMessageCallback(String)

Whenever given message provider obtains new message respective programmable block gets called with provided argument. Each raised callback argument will be called only once per simulation tick no matter how many messages are there pending to be accepted. At most a single callback will be invoked each tick ==> If there are messages pending in multiple message providers with registered callback, one will be randomly picked and invoked. Rest will be deferred to the next tick and follow the same process. In case you don't consume all messages pending in given message provider, the callback will not be raise again in following tick unless new message arrives.

##### Declaration

```
void SetMessageCallback(string argument = "")
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | argument |     |