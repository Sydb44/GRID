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

#### GetAproximateDynamicClustersForSize(ref BoundingBoxD, Double, List<BoundingBoxD>)

##### Declaration

```
public static void GetAproximateDynamicClustersForSize(ref BoundingBoxD container, double clusterSize, List<BoundingBoxD> clusters)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | container |     |
| System.Double | clusterSize |     |
| System.Collections.Generic.List<[BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html)\> | clusters |     |

#### GetAproximateDynamicClustersForSizeDebug(ref BoundingBoxD, Double, List<BoundingBoxD>)

##### Declaration

```
public static void GetAproximateDynamicClustersForSizeDebug(ref BoundingBoxD container, double clusterSize, List<BoundingBoxD> clusters)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | container |     |
| System.Double | clusterSize |     |
| System.Collections.Generic.List<[BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html)\> | clusters |     |

#### GetClosestPlanet(ref BoundingBoxD)

##### Declaration

```
public static MyPlanet GetClosestPlanet(ref BoundingBoxD box)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | box |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyPlanet](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyPlanet.html) |     |

#### GetClosestPlanet(Vector3D)

Get the closest planet overlapping a position.  
This will not return anything if the position is not within the bounding box of the planet.

##### Declaration

```
public static MyPlanet GetClosestPlanet(Vector3D position)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | position | position |

##### Returns

| Type | Description |
| --- | --- |
| [MyPlanet](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyPlanet.html) |     |

#### GetEntityAABB(MyEntity)

##### Declaration

```
public static BoundingBoxD GetEntityAABB(MyEntity entity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) | entity |     |

##### Returns

| Type | Description |
| --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) |     |

#### GetPlanet(ref BoundingBoxD)

##### Declaration

```
public MyPlanet GetPlanet(ref BoundingBoxD box)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | box |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyPlanet](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyPlanet.html) |     |

#### GetPlanet(Vector3D)

##### Declaration

```
public MyPlanet GetPlanet(Vector3D position)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | position |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyPlanet](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyPlanet.html) |     |

#### GetTopMostEntities(ref BoundingBoxD, List<MyEntity>, MyEntityQueryType)

##### Declaration

```
public void GetTopMostEntities(ref BoundingBoxD box, List<MyEntity> result, MyEntityQueryType qtype)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | box |     |
| System.Collections.Generic.List<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\> | result |     |
| [MyEntityQueryType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntityQueryType.html) | qtype |     |

#### GetTopMostEntities(ref BoundingSphereD, List<MyEntity>, MyEntityQueryType)

##### Declaration

```
public void GetTopMostEntities(ref BoundingSphereD sphere, List<MyEntity> result, MyEntityQueryType qtype)
```

##### Parameters

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
