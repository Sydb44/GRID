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

#### GetAllEntitiesInOBB(ref MyOrientedBoundingBoxD, List<MyEntity>, MyEntityQueryType)

##### Declaration

```
public static void GetAllEntitiesInOBB(ref MyOrientedBoundingBoxD obb, List<MyEntity> result, MyEntityQueryType qtype)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyOrientedBoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyOrientedBoundingBoxD.html) | obb |     |
| System.Collections.Generic.List<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\> | result |     |
| [MyEntityQueryType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntityQueryType.html) | qtype |     |

#### GetAllEntitiesInRay(ref LineD, List<MyLineSegmentOverlapResult<MyEntity>>, MyEntityQueryType)

##### Declaration

```
public static void GetAllEntitiesInRay(ref LineD ray, List<MyLineSegmentOverlapResult<MyEntity>> result, MyEntityQueryType qtype)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [LineD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.LineD.html) | ray |     |
| System.Collections.Generic.List<[MyLineSegmentOverlapResult](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyLineSegmentOverlapResult-1.html)<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\>> | result |     |
| [MyEntityQueryType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntityQueryType.html) | qtype |     |

#### GetAllEntitiesInSphere(ref BoundingSphereD, List<MyEntity>, MyEntityQueryType)

##### Declaration

```
public static void GetAllEntitiesInSphere(ref BoundingSphereD sphere, List<MyEntity> result, MyEntityQueryType qtype)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html) | sphere |     |
| System.Collections.Generic.List<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\> | result |     |
| [MyEntityQueryType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntityQueryType.html) | qtype |     |

#### GetAllTopMostEntitiesInSphere(ref BoundingSphereD, List<MyEntity>, MyEntityQueryType)

##### Declaration

```
public static void GetAllTopMostEntitiesInSphere(ref BoundingSphereD sphere, List<MyEntity> result, MyEntityQueryType qtype)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html) | sphere |     |
| System.Collections.Generic.List<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\> | result |     |
| [MyEntityQueryType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntityQueryType.html) | qtype |     |

#### GetAllTopMostStaticEntitiesInBox(ref BoundingBoxD, List<MyEntity>, MyEntityQueryType)

##### Declaration

```
public static void GetAllTopMostStaticEntitiesInBox(ref BoundingBoxD box, List<MyEntity> result, MyEntityQueryType qtype)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | box |     |
| System.Collections.Generic.List<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\> | result |     |
| [MyEntityQueryType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntityQueryType.html) | qtype |     |

#### GetAllVoxelMapsInBox(ref BoundingBoxD, List<MyVoxelBase>)

##### Declaration

```
public static void GetAllVoxelMapsInBox(ref BoundingBoxD box, List<MyVoxelBase> result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | box |     |
| System.Collections.Generic.List<[MyVoxelBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyVoxelBase.html)\> | result |     |

#### GetAllVoxelMapsInSphere(ref BoundingSphereD, List<MyVoxelBase>)

##### Declaration

```
public static void GetAllVoxelMapsInSphere(ref BoundingSphereD sphere, List<MyVoxelBase> result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html) | sphere |     |
| System.Collections.Generic.List<[MyVoxelBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyVoxelBase.html)\> | result |     |

#### GetAproximateDynamicClusters(ref BoundingBoxD, Double, List<BoundingBoxD>)

##### Declaration

```
public void GetAproximateDynamicClusters(ref BoundingBoxD container, double clusterSize, List<BoundingBoxD> clusters)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | container |     |
| System.Double | clusterSize |     |
| System.Collections.Generic.List<[BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html)\> | clusters |     |
