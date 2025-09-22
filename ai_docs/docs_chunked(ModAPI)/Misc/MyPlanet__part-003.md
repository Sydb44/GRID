```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | worldPosition |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### Init(MyPlanetInitArguments)

##### Declaration

```
public void Init(MyPlanetInitArguments arguments)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyPlanetInitArguments](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyPlanetInitArguments.html) | arguments |     |

#### Init(MyObjectBuilder\_EntityBase)

##### Declaration

```
public override void Init(MyObjectBuilder_EntityBase builder)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_EntityBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_EntityBase.html) | builder |     |

##### Overrides

#### Init(MyObjectBuilder\_EntityBase, IMyStorage)

##### Declaration

```
public override void Init(MyObjectBuilder_EntityBase builder, IMyStorage storage)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_EntityBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_EntityBase.html) | builder |     |
| VRage.Game.Voxels.IMyStorage | storage |     |

##### Overrides

#### IntersectsWithGravityFast(ref BoundingBoxD)

##### Declaration

```
public bool IntersectsWithGravityFast(ref BoundingBoxD boundingBox)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | boundingBox |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsUnderGround(Vector3D)

##### Declaration

```
public bool IsUnderGround(Vector3D position)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | position |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### OnAddedToScene(Object)

##### Declaration

```
public override void OnAddedToScene(object source)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | source |     |

##### Overrides

#### OnRemovedFromScene(Object)

##### Declaration

```
public override void OnRemovedFromScene(object source)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | source |     |

##### Overrides

#### PrefetchShapeOnRay(ref LineD, Boolean)

Prefetch voxel physics and creates one if it don't exist

##### Declaration

```
public bool PrefetchShapeOnRay(ref LineD ray, bool prefetchOnlyNew = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [LineD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.LineD.html) | ray |     |
| System.Boolean | prefetchOnlyNew | when true it starts shape prefetch only when voxel map was created |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### RemoveChildEntity(MyEntity)

##### Declaration

```
public void RemoveChildEntity(MyEntity child)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) | child |     |

#### RevertBoulder(MyBoulderInformation)

##### Declaration

```
public static void RevertBoulder(MyBoulderInformation boulder)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyBoulderInformation](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.MyBoulderInformation.html) | boulder |     |

#### RevertBoulderBroadcast(Int64, Int64, Int32)

##### Declaration

```
[Event(null, 605)]
[Reliable]
[Broadcast]
public static void RevertBoulderBroadcast(long planetId, long sectorId, int itemId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | planetId |     |
| System.Int64 | sectorId |     |
| System.Int32 | itemId |     |

#### RevertBoulderServer(MyVoxelBase)

##### Declaration

```
public static void RevertBoulderServer(MyVoxelBase voxels)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyVoxelBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyVoxelBase.html) | voxels |     |

#### SetStationOreBlockTree(MyDynamicAABBTree)

##### Declaration

```
public void SetStationOreBlockTree(MyDynamicAABBTree tree)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDynamicAABBTree](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyDynamicAABBTree.html) | tree |     |

#### UpdateAfterSimulation10()

##### Declaration

```
public override void UpdateAfterSimulation10()
```

##### Overrides

#### UpdateAfterSimulation100()

##### Declaration

```
public override void UpdateAfterSimulation100()
```

##### Overrides

#### UpdateOnceBeforeFrame()

##### Declaration

```
public override void UpdateOnceBeforeFrame()
```

##### Overrides

### Explicit Interface Implementations

#### IMyOxygenProvider.IsPositionInRange(Vector3D)

##### Declaration

```
bool IMyOxygenProvider.IsPositionInRange(Vector3D worldPoint)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | worldPoint |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Implements

### Extension Methods