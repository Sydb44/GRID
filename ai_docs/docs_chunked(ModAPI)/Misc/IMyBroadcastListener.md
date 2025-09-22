---
title: "Interface IMyBroadcastListener"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyBroadcastListener.html"
category: "Misc"
namespace: "Sandbox.ModAPI.Ingame"
class: "IMyBroadcastListener"
---

# Interface IMyBroadcastListener | Space Engineers ModAPI

Broadcast listeners scan the network for broadcasted messages with specific tag.

##### Inherited Members

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyBroadcastListener : IMyMessageProvider
```

### Properties

#### IsActive

Gets a value that indicates whether the broadcast listener is active.

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Tag

Gets the tag this broadcast listener is listening for.

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |