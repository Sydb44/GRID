---
title: "Class MyEntityCycling"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntityCycling.html"
category: "Misc"
namespace: "Sandbox.Game.Entities"
class: "MyEntityCycling"
---

# Class MyEntityCycling | Space Engineers ModAPI

##### Inheritance

System.Object

MyEntityCycling

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public static class MyEntityCycling : Object
```

### Methods

#### FindNext(MyEntityCyclingOrder, ref Single, ref Int64, Boolean, CyclingOptions)

##### Declaration

```
public static void FindNext(MyEntityCyclingOrder order, ref float metric, ref long entityId, bool findLarger, CyclingOptions options)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEntityCyclingOrder](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntityCyclingOrder.html) | order |     |
| System.Single | metric |     |
| System.Int64 | entityId |     |
| System.Boolean | findLarger |     |
| [CyclingOptions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.CyclingOptions.html) | options |     |

#### GetMetric(MyEntityCyclingOrder, MyEntity)

##### Declaration

```
public static float GetMetric(MyEntityCyclingOrder order, MyEntity entity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEntityCyclingOrder](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntityCyclingOrder.html) | order |     |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) | entity |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |