---
title: "Interface IMySignalSenderEntityComponent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMySignalSenderEntityComponent.html"
category: "Components"
namespace: "Sandbox.ModAPI"
class: "IMySignalSenderEntityComponent"
---

# Interface IMySignalSenderEntityComponent | Space Engineers ModAPI

Describes entity component for sending a signal to appropriate receivers

###### **Namespace**: [Sandbox.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMySignalSenderEntityComponent
```

### Methods

#### SendSignal(Nullable<Int32>)

Sends a signal to the channel. If no channel number is provided, uses channel number from IMySignalChannelProvider component of the same container.

##### Declaration

```
void SendSignal(Nullable<int> channelId = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Nullable<System.Int32\> | channelId |     |