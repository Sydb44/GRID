---
title: "Interface IMyButtonPanel"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/SpaceEngineers.Game.ModAPI.Ingame.IMyButtonPanel.html"
category: "Misc"
namespace: "SpaceEngineers.Game.ModAPI.Ingame"
class: "IMyButtonPanel"
---

# Interface IMyButtonPanel | Space Engineers ModAPI

##### Inherited Members

###### **Namespace**: [SpaceEngineers.Game.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/SpaceEngineers.Game.ModAPI.Ingame.html)

###### **Assembly**: SpaceEngineers.Game.dll

##### Syntax

```
public interface IMyButtonPanel : IMyTerminalBlock, IMyCubeBlock, IMyEntity
```

### Properties

#### AnyoneCanUse

Gets or sets if anyone is allowed to activate the buttons.

##### Declaration

```
bool AnyoneCanUse { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Methods

#### ClearCustomButtonName(Int32)

Clears the custom name of the specified button.

##### Declaration

```
void ClearCustomButtonName(int index)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | index | Zero-base button position |

#### GetButtonName(Int32)

Gets the button name.

##### Declaration

```
string GetButtonName(int index)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | index | Zero-based button position |

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

#### HasCustomButtonName(Int32)

Gets if the specified button has a custom name set.

##### Declaration

```
bool HasCustomButtonName(int index)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | index | Zero-base button position |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsButtonAssigned(Int32)

Gets if the specified button is assigned an action.

##### Declaration

```
bool IsButtonAssigned(int index)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | index | Zero-base button position |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### SetCustomButtonName(Int32, String)

Sets the custom button name.

##### Declaration

```
void SetCustomButtonName(int index, string name)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | index | Zero-base button position |
| System.String | name | Name of button |

### Extension Methods