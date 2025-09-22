---
title: "Class MyEnvironmentSectorExtensions"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.MyEnvironmentSectorExtensions.html"
category: "Misc"
namespace: "Sandbox.Game.WorldEnvironment"
class: "MyEnvironmentSectorExtensions"
---

# Class MyEnvironmentSectorExtensions | Space Engineers ModAPI

##### Inheritance

System.Object

MyEnvironmentSectorExtensions

###### **Namespace**: [Sandbox.Game.WorldEnvironment](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public static class MyEnvironmentSectorExtensions : Object
```

### Methods

#### DisableItemsInBox(MyEnvironmentSector, ref BoundingBoxD)

##### Declaration

```
public static void DisableItemsInBox(this MyEnvironmentSector sector, ref BoundingBoxD box)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEnvironmentSector](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.MyEnvironmentSector.html) | sector |     |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | box |     |

#### GetItemsInAabb(MyEnvironmentSector, ref BoundingBoxD, List<Int32>)

##### Declaration

```
public static void GetItemsInAabb(this MyEnvironmentSector sector, ref BoundingBoxD aabb, List<int> itemsInBox)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEnvironmentSector](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.MyEnvironmentSector.html) | sector |     |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | aabb |     |
| System.Collections.Generic.List<System.Int32\> | itemsInBox |     |

#### HasWorkPending(MyEnvironmentSector)

##### Declaration

```
public static bool HasWorkPending(this MyEnvironmentSector self)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEnvironmentSector](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.MyEnvironmentSector.html) | self |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |