---
title: "Class MyProductionItem"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.MyProductionItem.html"
category: "Production"
namespace: "Sandbox.ModAPI.Ingame"
class: "MyProductionItem"
---

# Class MyProductionItem | Space Engineers ModAPI

Implements production block item

##### Inheritance

System.Object

MyProductionItem

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public sealed class MyProductionItem : ValueType
```

### Constructors

#### MyProductionItem(UInt32, MyDefinitionId, MyFixedPoint)

Implements MyProductionItem constructor

##### Declaration

```
public MyProductionItem(uint itemId, MyDefinitionId blueprintId, MyFixedPoint amount)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.UInt32 | itemId | item id |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | blueprintId | blueprint id |
| VRage.MyFixedPoint | amount | amout |

### Fields

#### Amount

Gets or sets the amount

##### Declaration

```
public readonly MyFixedPoint Amount
```

##### Field Value

| Type | Description |
| --- | --- |
| VRage.MyFixedPoint |     |

#### BlueprintId

Gets or sets the blueprint id

##### Declaration

```
public readonly MyDefinitionId BlueprintId
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) |     |

#### ItemId

Gets or sets the item id

##### Declaration

```
public readonly uint ItemId
```

##### Field Value

| Type | Description |
| --- | --- |
| System.UInt32 |     |