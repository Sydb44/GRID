---
title: "Class MyUpdateTiersPlayerPresence"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyUpdateTiersPlayerPresence.html"
category: "Misc"
namespace: "VRage.Game.ModAPI"
class: "MyUpdateTiersPlayerPresence"
---

# Class MyUpdateTiersPlayerPresence | Space Engineers ModAPI

Describes tiers of player presence (if any player is nearby and grid is replicated to the client)

##### Inheritance

System.Object

MyUpdateTiersPlayerPresence

###### **Namespace**: [VRage.Game.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public sealed class MyUpdateTiersPlayerPresence : Enum
```

### [](#fields)Fields

#### [](#VRage_Game_ModAPI_MyUpdateTiersPlayerPresence_Normal)Normal

Player is nearby, grid is replicated to the client

##### Declaration

```
public const MyUpdateTiersPlayerPresence Normal
```

##### Field Value

#### [](#VRage_Game_ModAPI_MyUpdateTiersPlayerPresence_Tier1)Tier1

Player is not nearby, grid is not replicated to the client. Update time can be slower.

##### Declaration

```
public const MyUpdateTiersPlayerPresence Tier1
```

##### Field Value

#### [](#VRage_Game_ModAPI_MyUpdateTiersPlayerPresence_Tier2)Tier2

Player is not nearby, grid is not replicated to the client. Update time can be even more slower.

##### Declaration

```
public const MyUpdateTiersPlayerPresence Tier2
```

##### Field Value

#### [](#VRage_Game_ModAPI_MyUpdateTiersPlayerPresence_value__)value\_\_

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |