---
title: "Interface IMyTransponder"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/SpaceEngineers.Game.ModAPI.Ingame.IMyTransponder.html"
category: "Misc"
namespace: "SpaceEngineers.Game.ModAPI.Ingame"
class: "IMyTransponder"
---

# Interface IMyTransponder | Space Engineers ModAPI

Describes Transponder block (PB scripting interface)

##### Inherited Members

###### **Namespace**: [SpaceEngineers.Game.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/SpaceEngineers.Game.ModAPI.Ingame.html)

###### **Assembly**: SpaceEngineers.Game.dll

##### Syntax

```
public interface IMyTransponder : IMyFunctionalBlock, IMyTerminalBlock, IMyCubeBlock, IMyEntity
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

#### Channel

Gets or sets channel number to be used for further signals. Setter does nothing if there is no IMySignalChannelProvider component accessible. Getter returns zero if there is no IMySignalChannelProvider component accessible.

##### Declaration

```
int Channel { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

### Methods

#### SendSignal(Nullable<Int32>)

Sends a signal to the channel. If no channel number is provided, uses channel number from IMySignalChannelProvider component of the same container.

##### Declaration

```
void SendSignal(Nullable<int> channel = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Nullable<System.Int32\> | channel |     |

### Extension Methods