---
title: "Class MyEntityContainerEventExtensions.InventoryChangedParams"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyEntityContainerEventExtensions.InventoryChangedParams.html"
category: "Events"
namespace: "VRage.Game.Components.MyEntityContainerEventExtensions"
class: "InventoryChangedParams"
---

# Class MyEntityContainerEventExtensions.InventoryChangedParams | Space Engineers ModAPI

This class is used to inform about changes in inventory

##### Inheritance

System.Object

MyEntityContainerEventExtensions.InventoryChangedParams

###### **Namespace**: [VRage.Game.Components](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public class InventoryChangedParams : MyEntityContainerEventExtensions.EntityEventParams
```

### Constructors

#### InventoryChangedParams(UInt32, MyInventoryBase, Single)

##### Declaration

```
public InventoryChangedParams(uint itemId, MyInventoryBase inventory, float amount)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.UInt32 | itemId |     |
| [MyInventoryBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyInventoryBase.html) | inventory |     |
| System.Single | amount |     |

### Fields

#### Amount

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Inventory

##### Declaration

```
public MyInventoryBase Inventory
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyInventoryBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyInventoryBase.html) |     |

#### ItemId

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.UInt32 |     |