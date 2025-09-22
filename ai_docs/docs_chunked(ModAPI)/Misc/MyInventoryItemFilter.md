---
title: "Class MyInventoryItemFilter"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.MyInventoryItemFilter.html"
category: "Misc"
namespace: "Sandbox.ModAPI.Ingame"
class: "MyInventoryItemFilter"
---

# Class MyInventoryItemFilter | Space Engineers ModAPI

Implements inventory item filter

##### Inheritance

System.Object

MyInventoryItemFilter

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public sealed class MyInventoryItemFilter : ValueType
```

### Constructors

#### MyInventoryItemFilter(String, Boolean)

Implements MyInventoryItemFilter constructor

##### Declaration

```
public MyInventoryItemFilter(string itemId, bool allSubTypes = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | itemId | item id |
| System.Boolean | allSubTypes | true if all sub types |

#### MyInventoryItemFilter(MyDefinitionId, Boolean)

Implements MyInventoryItemFilter constructor

##### Declaration

```
public MyInventoryItemFilter(MyDefinitionId itemId, bool allSubTypes = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | itemId | item id |
| System.Boolean | allSubTypes | true if all sub types |

### Fields

#### AllSubTypes

Determines whether all subtypes of the given item ID should pass this filter check.

##### Declaration

```
public readonly bool AllSubTypes
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ItemId

Specifies an item to filter. Set [AllSubTypes](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.MyInventoryItemFilter.html#Sandbox_ModAPI_Ingame_MyInventoryItemFilter_AllSubTypes) to true to only check the main type part of this ID.

##### Declaration

```
public readonly MyDefinitionId ItemId
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) |     |

### Properties

#### ItemType

##### Declaration

```
public MyItemType ItemType { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyItemType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.MyItemType.html) |     |

### Operators

#### Implicit(MyItemType to MyInventoryItemFilter)

Implements implicit operator

##### Declaration

```
public static implicit operator MyInventoryItemFilter(MyItemType itemType)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyItemType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.MyItemType.html) | itemType | item type |

##### Returns

| Type | Description |
| --- | --- |
| [MyInventoryItemFilter](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.MyInventoryItemFilter.html) |     |

#### Implicit(MyDefinitionId to MyInventoryItemFilter)

Implements implicit operator

##### Declaration

```
public static implicit operator MyInventoryItemFilter(MyDefinitionId definitionId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | definitionId | definition id |

##### Returns

| Type | Description |
| --- | --- |
| [MyInventoryItemFilter](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.MyInventoryItemFilter.html) |     |