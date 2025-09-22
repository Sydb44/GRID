---
title: "Interface IMyOxygenBlock"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyOxygenBlock.html"
category: "Misc"
namespace: "VRage.Game.ModAPI"
class: "IMyOxygenBlock"
---

# Interface IMyOxygenBlock | Space Engineers ModAPI

ModAPI describing block that can work with gas in airtight rooms (AirVent)

###### **Namespace**: [VRage.Game.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public interface IMyOxygenBlock
```

### [](#properties)Properties

#### [](#VRage_Game_ModAPI_IMyOxygenBlock_OxygenChangeTime)OxygenChangeTime

Get time in milliseconds when last oxygen level was changed.

##### Declaration

```
int OxygenChangeTime { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### [](#VRage_Game_ModAPI_IMyOxygenBlock_PreviousOxygenAmount)PreviousOxygenAmount

Gets previous oxygen level. Oxygen level is updated each 100 frames.

##### Declaration

```
float PreviousOxygenAmount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### [](#VRage_Game_ModAPI_IMyOxygenBlock_Room)Room

Gets oxygen room to which this block belongs to.

##### Declaration

```
IMyOxygenRoom Room { get; }
```

##### Property Value

### [](#methods)Methods

#### [](#VRage_Game_ModAPI_IMyOxygenBlock_OxygenLevel_System_Single_)OxygenLevel(Single)

Gets oxygen level in current oxygen room

##### Declaration

```
float OxygenLevel(float gridSize)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | gridSize | Should be 0.5 for small, and 2.5 for large grid |

##### Returns

| Type | Description |
| --- | --- |
| System.Single | Oxygen level from 0 to 1 |