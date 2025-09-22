---
title: "Interface IMyTerminalActionsHelper"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyTerminalActionsHelper.html"
category: "Misc"
namespace: "Sandbox.ModAPI"
class: "IMyTerminalActionsHelper"
---

# Interface IMyTerminalActionsHelper | Space Engineers ModAPI

API class for interactions with terminal actions and properties

###### **Namespace**: [Sandbox.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyTerminalActionsHelper
```

### Methods

#### GetActions(Type, List<ITerminalAction>, Func<ITerminalAction, Boolean>)

Gets available [ITerminalAction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.ITerminalAction.html) for a block with specified type

##### Declaration

```
void GetActions(Type blockType, List<ITerminalAction> resultList, Func<ITerminalAction, bool> collect = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Type | blockType | Block type, that should have actions |
| System.Collections.Generic.List<[ITerminalAction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.ITerminalAction.html)\> | resultList | Preallocated list, where results would be added |
| System.Func<[ITerminalAction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.ITerminalAction.html), System.Boolean\> | collect | Filter function, if it returns true, item would be added to list |

#### GetActionWithName(String, Type)

Gets first available [ITerminalAction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.ITerminalAction.html) for a block with specified type and name

##### Declaration

```
ITerminalAction GetActionWithName(string actionId, Type blockType)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | actionId | action.Id should be equal to this argument |
| System.Type | blockType | Block type, that should have action |

##### Returns

| Type | Description |
| --- | --- |
| [ITerminalAction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.ITerminalAction.html) | Terminal action or null |

#### GetProperties(Type, List<ITerminalProperty>, Func<ITerminalProperty, Boolean>)

Gets all properties that belongs to specific block

##### Declaration

```
void GetProperties(Type blockType, List<ITerminalProperty> resultList, Func<ITerminalProperty, bool> collect = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Type | blockType | Block type, that should have properties |
| System.Collections.Generic.List<[ITerminalProperty](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.ITerminalProperty.html)\> | resultList | Preallocated list, where results would be added |
| System.Func<[ITerminalProperty](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.ITerminalProperty.html), System.Boolean\> | collect | Filter function, if it returns true, item would be added to list |

#### GetProperty(String, Type)

Gets property by id

##### Declaration

```
ITerminalProperty GetProperty(string id, Type blockType)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | id  | Terminal property id should be equal this argument |
| System.Type | blockType | Block type, that should have property |

##### Returns

| Type | Description |
| --- | --- |
| [ITerminalProperty](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.ITerminalProperty.html) |     |

#### GetTerminalSystemForGrid(IMyCubeGrid)

##### Declaration

```
IMyGridTerminalSystem GetTerminalSystemForGrid(IMyCubeGrid grid)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCubeGrid.html) | grid | For which you want to [IMyGridTerminalSystem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyGridTerminalSystem.html) |

##### Returns

| Type | Description |
| --- | --- |
| [IMyGridTerminalSystem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyGridTerminalSystem.html) | [IMyGridTerminalSystem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyGridTerminalSystem.html) or null, if called too early (on MyCubeGrid.InitInternal). |

##### Remarks

#### SearchActionsOfName(String, Type, List<ITerminalAction>, Func<ITerminalAction, Boolean>)

Gets available [ITerminalAction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.ITerminalAction.html) for a block with specified type and name

##### Declaration

```
void SearchActionsOfName(string name, Type blockType, List<ITerminalAction> resultList, Func<ITerminalAction, bool> collect = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | name | Action should contain or be equal to this argument |
| System.Type | blockType | Block type, that should have actions |
| System.Collections.Generic.List<[ITerminalAction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.ITerminalAction.html)\> | resultList | Preallocated list, where results would be added |
| System.Func<[ITerminalAction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.ITerminalAction.html), System.Boolean\> | collect | Filter function, if it returns true, item would be added to list |