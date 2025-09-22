---
title: "Class MyEntityInventoryOwnerExtensions"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntityInventoryOwnerExtensions.html"
category: "Misc"
namespace: "Sandbox.Game.Entities"
class: "MyEntityInventoryOwnerExtensions"
---

# Class MyEntityInventoryOwnerExtensions | Space Engineers ModAPI

This class simplifies backward compatibility to IMyInventoryOwner in the code Instead checking Entity type, you need to check now if the Entity has Inventory

##### Inheritance

System.Object

MyEntityInventoryOwnerExtensions

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public static class MyEntityInventoryOwnerExtensions : Object
```

### Methods

#### InventoryOwnerType(MyEntity)

##### Declaration

```
public static MyInventoryOwnerTypeEnum InventoryOwnerType(this MyEntity entity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) | entity |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyInventoryOwnerTypeEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyInventoryOwnerTypeEnum.html) |     |