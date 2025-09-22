---
title: "Interface IMyRadioAntenna"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyRadioAntenna.html"
category: "Misc"
namespace: "Sandbox.ModAPI.Ingame"
class: "IMyRadioAntenna"
---

# Interface IMyRadioAntenna | Space Engineers ModAPI

Describes antenna block interface (PB scripting interface)

##### Inherited Members

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyRadioAntenna : IMyFunctionalBlock, IMyTerminalBlock, IMyCubeBlock, IMyEntity
```

### Properties

#### EnableBroadcasting

Gets or sets if broadcasting is enabled

##### Declaration

```
bool EnableBroadcasting { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### HudText

Gets or sets text displayed in the spawn menu

##### Declaration

```
string HudText { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### IsBroadcasting

Returns true if antenna is broadcasting

##### Declaration

```
bool IsBroadcasting { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Radius

Gets or sets Broadcasting/Receiving range

##### Declaration

```
float Radius { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### ShowShipName

Gets or sets show ship name on hud

##### Declaration

```
bool ShowShipName { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Extension Methods