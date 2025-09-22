---
title: "Interface IMyDLC"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyDLC.html"
category: "Misc"
namespace: "VRage.Game.ModAPI"
class: "IMyDLC"
---

# Interface IMyDLC | Space Engineers ModAPI

Contains information about a particular DLC package.

###### **Namespace**: [VRage.Game.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

### Properties

#### AppId

Gets the Steam AppID of the DLC.

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.UInt32 |     |

#### Badge

Gets badge of the DLC. Displayed in main menu.

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### Description

Gets localized description of the DLC.

##### Declaration

```
MyStringId Description { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html) |     |

#### DisplayName

Gets localized name of the DLC.

##### Declaration

```
MyStringId DisplayName { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html) |     |

#### Icon

Gets icon of the DLC. Displayed in G-screen, blueprints, etc ...

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### Name

Gets the internal name of the DLC. This is the name used in CubeBlocks.sbc, for example.

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |