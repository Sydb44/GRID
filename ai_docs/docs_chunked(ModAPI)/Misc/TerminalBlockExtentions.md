---
title: "Class TerminalBlockExtentions"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.TerminalBlockExtentions.html"
category: "Misc"
namespace: "Sandbox.ModAPI.Ingame"
class: "TerminalBlockExtentions"
---

# Class TerminalBlockExtentions | Space Engineers ModAPI

Class having some sugar extensions. Written by Kalvin Osborne, AKA Night Lone.

##### Inheritance

System.Object

TerminalBlockExtentions

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public static class TerminalBlockExtentions : Object
```

### [](#methods)Methods

#### [](#Sandbox_ModAPI_Ingame_TerminalBlockExtentions_ApplyAction_Sandbox_ModAPI_Ingame_IMyTerminalBlock_System_String_)ApplyAction(IMyTerminalBlock, String)

##### Declaration

```
public static void ApplyAction(this IMyTerminalBlock block, string actionName)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyTerminalBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyTerminalBlock.html) | block | To apply action on |
| System.String | actionName | Name of action |

##### Exceptions

| Type | Condition |
| --- | --- |
| System.NullReferenceException | If action not found |

#### [](#Sandbox_ModAPI_Ingame_TerminalBlockExtentions_ApplyAction_Sandbox_ModAPI_Ingame_IMyTerminalBlock_System_String_System_Collections_Generic_List_Sandbox_ModAPI_Ingame_TerminalActionParameter__)ApplyAction(IMyTerminalBlock, String, List<TerminalActionParameter>)

##### Declaration

```
public static void ApplyAction(this IMyTerminalBlock block, string actionName, List<TerminalActionParameter> parameters)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyTerminalBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyTerminalBlock.html) | block | To apply action on |
| System.String | actionName | Name of action |
| System.Collections.Generic.List<[TerminalActionParameter](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.TerminalActionParameter.html)\> | parameters | Parameters for terminal action function call |

##### Exceptions

| Type | Condition |
| --- | --- |
| System.NullReferenceException | If action not found |

#### [](#Sandbox_ModAPI_Ingame_TerminalBlockExtentions_GetId_Sandbox_ModAPI_Ingame_IMyTerminalBlock_)GetId(IMyTerminalBlock)

Get EntityId of block

##### Declaration

```
public static long GetId(this IMyTerminalBlock block)
```

##### Parameters

##### Returns

| Type | Description |
| --- | --- |
| System.Int64 | EntityId |

#### [](#Sandbox_ModAPI_Ingame_TerminalBlockExtentions_GetInventory_Sandbox_ModAPI_Ingame_IMyTerminalBlock_System_Int32_)GetInventory(IMyTerminalBlock, Int32)

Obsolete

##### Declaration

```
public static IMyInventory GetInventory(this IMyTerminalBlock block, int index)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyTerminalBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyTerminalBlock.html) | block | obsolete |
| System.Int32 | index | obsolete |

##### Returns

#### [](#Sandbox_ModAPI_Ingame_TerminalBlockExtentions_GetInventoryCount_Sandbox_ModAPI_Ingame_IMyTerminalBlock_)GetInventoryCount(IMyTerminalBlock)

Obsolete

##### Declaration

```
public static int GetInventoryCount(this IMyTerminalBlock block)
```

##### Parameters

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### [](#Sandbox_ModAPI_Ingame_TerminalBlockExtentions_GetUseConveyorSystem_Sandbox_ModAPI_Ingame_IMyTerminalBlock_)GetUseConveyorSystem(IMyTerminalBlock)

Obsolete

##### Declaration

```
public static bool GetUseConveyorSystem(this IMyTerminalBlock block)
```

##### Parameters

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#Sandbox_ModAPI_Ingame_TerminalBlockExtentions_HasAction_Sandbox_ModAPI_Ingame_IMyTerminalBlock_System_String_)HasAction(IMyTerminalBlock, String)

Searches for terminal action with name

##### Declaration

```
public static bool HasAction(this IMyTerminalBlock block, string actionName)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyTerminalBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyTerminalBlock.html) | block | Terminal block which should have action |
| System.String | actionName | Name of action |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if terminal action found |

#### [](#Sandbox_ModAPI_Ingame_TerminalBlockExtentions_HasInventory_Sandbox_ModAPI_Ingame_IMyTerminalBlock_)HasInventory(IMyTerminalBlock)

Obsolete

##### Declaration

```
public static bool HasInventory(this IMyTerminalBlock block)
```

##### Parameters

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#Sandbox_ModAPI_Ingame_TerminalBlockExtentions_SetUseConveyorSystem_Sandbox_ModAPI_Ingame_IMyTerminalBlock_System_Boolean_)SetUseConveyorSystem(IMyTerminalBlock, Boolean)

Obsolete

##### Declaration

```
public static void SetUseConveyorSystem(this IMyTerminalBlock block, bool use)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyTerminalBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyTerminalBlock.html) | block | Obsolete |
| System.Boolean | use | Obsolete |