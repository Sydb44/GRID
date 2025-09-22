---
title: "Class MyGamePruningStructure"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyGamePruningStructure.html"
category: "Misc"
namespace: "Sandbox.Game.Entities"
class: "MyGamePruningStructure"
---

# Class MyGamePruningStructure | Space Engineers ModAPI

##### Inheritance

System.Object

MyGamePruningStructure

##### Inherited Members

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MySessionComponentDescriptor]
public sealed class MyGamePruningStructure : MySessionComponentBase, IMyUserInputComponent
```

### Constructors

#### MyGamePruningStructure()

##### Declaration

```
public MyGamePruningStructure()
```

### Properties

#### Instance

##### Declaration

```
public static MyGamePruningStructure Instance { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyGamePruningStructure](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyGamePruningStructure.html) |     |

### Methods

#### Add(MyEntity)

##### Declaration

```
public static void Add(MyEntity entity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) | entity |     |

#### AddEntity(MyEntity)

##### Declaration

```
public void AddEntity(MyEntity entity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) | entity |     |

#### AnyVoxelMap(ref BoundingBoxD)

##### Declaration

```
public bool AnyVoxelMap(ref BoundingBoxD box)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | box |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### AnyVoxelMapInBox(ref BoundingBoxD)

##### Declaration

```
public static bool AnyVoxelMapInBox(ref BoundingBoxD box)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | box |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Draw()

##### Declaration

```
public override void Draw()
```

##### Overrides

#### GetAllEntities(ref BoundingBoxD, List<MyEntity>, MyEntityQueryType)

##### Declaration

```
public void GetAllEntities(ref BoundingBoxD box, List<MyEntity> result, MyEntityQueryType qtype)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | box |     |
| System.Collections.Generic.List<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\> | result |     |
| [MyEntityQueryType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntityQueryType.html) | qtype |     |

#### GetAllEntities(ref BoundingSphereD, List<MyEntity>, MyEntityQueryType)

##### Declaration

```
public void GetAllEntities(ref BoundingSphereD sphere, List<MyEntity> result, MyEntityQueryType qtype)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html) | sphere |     |
| System.Collections.Generic.List<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\> | result |     |
| [MyEntityQueryType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntityQueryType.html) | qtype |     |

#### GetAllEntities(ref LineD, List<MyLineSegmentOverlapResult<MyEntity>>, MyEntityQueryType)

##### Declaration

```
public void GetAllEntities(ref LineD ray, List<MyLineSegmentOverlapResult<MyEntity>> result, MyEntityQueryType qtype)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [LineD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.LineD.html) | ray |     |
| System.Collections.Generic.List<[MyLineSegmentOverlapResult](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyLineSegmentOverlapResult-1.html)<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\>> | result |     |
| [MyEntityQueryType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntityQueryType.html) | qtype |     |

#### GetAllEntities(ref MyOrientedBoundingBoxD, List<MyEntity>, MyEntityQueryType)

##### Declaration

```
public void GetAllEntities(ref MyOrientedBoundingBoxD obb, List<MyEntity> result, MyEntityQueryType qtype)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyOrientedBoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyOrientedBoundingBoxD.html) | obb |     |
| System.Collections.Generic.List<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\> | result |     |
| [MyEntityQueryType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntityQueryType.html) | qtype |     |

#### GetAllEntitiesInBox(ref BoundingBoxD, List<MyEntity>, MyEntityQueryType)

##### Declaration

```
public static void GetAllEntitiesInBox(ref BoundingBoxD box, List<MyEntity> result, MyEntityQueryType qtype)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | box |     |
| System.Collections.Generic.List<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\> | result |     |
| [MyEntityQueryType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntityQueryType.html) | qtype |     |
