| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html) | sphere |     |
| System.Collections.Generic.List<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\> | result |     |
| [MyEntityQueryType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntityQueryType.html) | qtype |     |

#### GetTopMostEntities(ref LineD, List<MyLineSegmentOverlapResult<MyEntity>>, MyEntityQueryType)

##### Declaration

```
public void GetTopMostEntities(ref LineD ray, List<MyLineSegmentOverlapResult<MyEntity>> result, MyEntityQueryType qtype)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [LineD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.LineD.html) | ray |     |
| System.Collections.Generic.List<[MyLineSegmentOverlapResult](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyLineSegmentOverlapResult-1.html)<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\>> | result |     |
| [MyEntityQueryType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntityQueryType.html) | qtype |     |

#### GetTopmostEntitiesInBox(ref BoundingBoxD, List<MyEntity>, MyEntityQueryType)

##### Declaration

```
public static void GetTopmostEntitiesInBox(ref BoundingBoxD box, List<MyEntity> result, MyEntityQueryType qtype)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | box |     |
| System.Collections.Generic.List<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\> | result |     |
| [MyEntityQueryType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntityQueryType.html) | qtype |     |

#### GetTopMostEntitiesInBox(ref BoundingBoxD, List<MyEntity>, MyEntityQueryType)

##### Declaration

```
public static void GetTopMostEntitiesInBox(ref BoundingBoxD box, List<MyEntity> result, MyEntityQueryType qtype)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | box |     |
| System.Collections.Generic.List<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\> | result |     |
| [MyEntityQueryType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntityQueryType.html) | qtype |     |

#### GetTopmostEntitiesOverlappingRay(ref LineD, List<MyLineSegmentOverlapResult<MyEntity>>, MyEntityQueryType)

##### Declaration

```
public static void GetTopmostEntitiesOverlappingRay(ref LineD ray, List<MyLineSegmentOverlapResult<MyEntity>> result, MyEntityQueryType qtype)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [LineD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.LineD.html) | ray |     |
| System.Collections.Generic.List<[MyLineSegmentOverlapResult](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyLineSegmentOverlapResult-1.html)<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\>> | result |     |
| [MyEntityQueryType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntityQueryType.html) | qtype |     |

#### GetVoxelMaps(ref BoundingBoxD, List<MyVoxelBase>)

##### Declaration

```
public void GetVoxelMaps(ref BoundingBoxD box, List<MyVoxelBase> result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | box |     |
| System.Collections.Generic.List<[MyVoxelBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyVoxelBase.html)\> | result |     |

#### GetVoxelMaps(ref BoundingSphereD, List<MyVoxelBase>)

##### Declaration

```
public void GetVoxelMaps(ref BoundingSphereD sphere, List<MyVoxelBase> result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html) | sphere |     |
| System.Collections.Generic.List<[MyVoxelBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyVoxelBase.html)\> | result |     |

#### GetVoxelMaps(ref LineD, List<MyLineSegmentOverlapResult<MyVoxelBase>>)

##### Declaration

```
public void GetVoxelMaps(ref LineD ray, List<MyLineSegmentOverlapResult<MyVoxelBase>> result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [LineD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.LineD.html) | ray |     |
| System.Collections.Generic.List<[MyLineSegmentOverlapResult](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyLineSegmentOverlapResult-1.html)<[MyVoxelBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyVoxelBase.html)\>> | result |     |

#### GetVoxelMapsOverlappingRay(ref LineD, List<MyLineSegmentOverlapResult<MyVoxelBase>>)

##### Declaration

```
public static void GetVoxelMapsOverlappingRay(ref LineD ray, List<MyLineSegmentOverlapResult<MyVoxelBase>> result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [LineD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.LineD.html) | ray |     |
| System.Collections.Generic.List<[MyLineSegmentOverlapResult](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyLineSegmentOverlapResult-1.html)<[MyVoxelBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyVoxelBase.html)\>> | result |     |
