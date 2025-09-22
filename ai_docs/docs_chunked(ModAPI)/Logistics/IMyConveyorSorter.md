---
title: "Interface IMyConveyorSorter"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyConveyorSorter.html"
category: "Logistics"
namespace: "Sandbox.ModAPI.Ingame"
class: "IMyConveyorSorter"
---

# Interface IMyConveyorSorter | Space Engineers ModAPI

Describes conveyor sorter block (PB scripting interface)

##### Inherited Members

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyConveyorSorter : IMyFunctionalBlock, IMyTerminalBlock, IMyCubeBlock, IMyEntity
```

### Properties

#### DrainAll

Determines whether the sorter should drain any inventories connected to it and push them to the other side - as long as the items passes the filtering as defined by the filter list ([GetFilterList(List<MyInventoryItemFilter>)](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyConveyorSorter.html#Sandbox_ModAPI_Ingame_IMyConveyorSorter_GetFilterList_System_Collections_Generic_List_Sandbox_ModAPI_Ingame_MyInventoryItemFilter__)) and [Mode](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyConveyorSorter.html#Sandbox_ModAPI_Ingame_IMyConveyorSorter_Mode).

##### Declaration

```
bool DrainAll { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Mode

Determines the current mode of this sorter.

##### Declaration

```
MyConveyorSorterMode Mode { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyConveyorSorterMode](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.MyConveyorSorterMode.html) |     |

### Methods

#### AddItem(MyInventoryItemFilter)

##### Declaration

```
void AddItem(MyInventoryItemFilter item)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyInventoryItemFilter](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.MyInventoryItemFilter.html) | item | Item filter settings |

#### GetFilterList(List<MyInventoryItemFilter>)

Gets the items currently being allowed through or rejected, depending on the [Mode](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyConveyorSorter.html#Sandbox_ModAPI_Ingame_IMyConveyorSorter_Mode).

##### Declaration

```
void GetFilterList(List<MyInventoryItemFilter> items)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<[MyInventoryItemFilter](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.MyInventoryItemFilter.html)\> | items | Buffer array, that would be cleared, and receive block filter settings |

#### IsAllowed(MyDefinitionId)

##### Declaration

```
bool IsAllowed(MyDefinitionId id)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | id  | Item id |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | Whether a given item type is allowed go through the sorter |

#### RemoveItem(MyInventoryItemFilter)

##### Declaration

```
void RemoveItem(MyInventoryItemFilter item)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyInventoryItemFilter](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.MyInventoryItemFilter.html) | item | Item filter settings |

#### SetFilter(MyConveyorSorterMode, List<MyInventoryItemFilter>)

Changes the sorter to desired mode and filters the provided items. You can pass in `null` to empty the list.

##### Declaration

```
void SetFilter(MyConveyorSorterMode mode, List<MyInventoryItemFilter> items)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyConveyorSorterMode](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.MyConveyorSorterMode.html) | mode | New work mod |
| System.Collections.Generic.List<[MyInventoryItemFilter](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.MyInventoryItemFilter.html)\> | items | Replaces previous filter settings with this one |

### Extension Methods