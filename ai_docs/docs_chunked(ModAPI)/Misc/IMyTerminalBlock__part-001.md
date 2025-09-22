---
title: "Interface IMyTerminalBlock"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyTerminalBlock.html"
category: "Misc"
namespace: "Sandbox.ModAPI.Ingame"
class: "IMyTerminalBlock"
---

# Interface IMyTerminalBlock | Space Engineers ModAPI

Describes terminal block (PB scripting interface)

##### Inherited Members

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyTerminalBlock : IMyCubeBlock, IMyEntity
```

### Properties

#### CustomData

Gets or sets the Custom Data string. NOTE: Only use this for user input. For storing large mod configs, create your own MyModStorageComponent

##### Declaration

```
string CustomData { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### CustomInfo

##### Declaration

```
string CustomInfo { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### CustomName

Gets or sets how block is named in Terminal menu

##### Declaration

```
string CustomName { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### CustomNameWithFaction

Gets or sets how block is named in Terminal menu. Work only for Cockpit, LaserAntenna RadioAntenna, SpaceBall, Beacon

##### Declaration

```
string CustomNameWithFaction { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### DetailedInfo

Gets information about block status. In Control panel bottom right text

##### Declaration

```
string DetailedInfo { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### ShowInInventory

Represent terminal gui toggle `Show block in Inventory Screen`. Gets or sets its value

##### Declaration

```
bool ShowInInventory { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ShowInTerminal

Represent terminal gui toggle `Show block in terminal`. Gets or sets its value

##### Declaration

```
bool ShowInTerminal { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ShowInToolbarConfig

Represent terminal gui toggle `Show in toolbar config`. Gets or sets its value

##### Declaration

```
bool ShowInToolbarConfig { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ShowOnHUD

Represent terminal gui toggle `Show On HUD`. Gets or sets its value

##### Declaration

```
bool ShowOnHUD { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Methods

#### GetActions(List<ITerminalAction>, Func<ITerminalAction, Boolean>)

Get all terminal actions available for block

##### Declaration

```
void GetActions(List<ITerminalAction> resultList, Func<ITerminalAction, bool> collect = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<[ITerminalAction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.ITerminalAction.html)\> | resultList | Buffer list, results would be added here. Can be null if  always returns false |
| System.Func<[ITerminalAction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.ITerminalAction.html), System.Boolean\> | collect | Filter function, if function is null or returns true, terminal action would be added to |

##### See Also

#### GetActionWithName(String)

Get first found terminal action with name

##### Declaration

```
ITerminalAction GetActionWithName(string name)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | name | Searches for terminal action with this name |

##### Returns

| Type | Description |
| --- | --- |
| [ITerminalAction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.ITerminalAction.html) | Found terminal action or null |

##### See Also

#### GetProperties(List<ITerminalProperty>, Func<ITerminalProperty, Boolean>)

Get all terminal actions available for block.

##### Declaration

```
void GetProperties(List<ITerminalProperty> resultList, Func<ITerminalProperty, bool> collect = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<[ITerminalProperty](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.ITerminalProperty.html)\> | resultList | Buffer list, results would be added here. Can be null if  always returns false |
| System.Func<[ITerminalProperty](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.ITerminalProperty.html), System.Boolean\> | collect | Filter function, if function is null or returns true, terminal property would be added to |

##### See Also

#### GetProperty(String)

Finds terminal property with provided id

##### Declaration

```
ITerminalProperty GetProperty(string id)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | id  | Terminal id |

##### Returns

| Type | Description |
| --- | --- |
| [ITerminalProperty](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.ITerminalProperty.html) | Found terminal property or null |

##### See Also

#### HasLocalPlayerAccess()

##### Declaration

```
bool HasLocalPlayerAccess()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | Can player access this block or not. (Result of [HasPlayerAccess(Int64, MyRelationsBetweenPlayerAndBlock)](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyTerminalBlock.html#Sandbox_ModAPI_Ingame_IMyTerminalBlock_HasPlayerAccess_System_Int64_VRage_Game_MyRelationsBetweenPlayerAndBlock_) function call) |
