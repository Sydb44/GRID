##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### GetCubeBoundingBox(Vector3I)

##### Declaration

```
protected BoundingBoxD GetCubeBoundingBox(Vector3I cubePos)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | cubePos |     |

##### Returns

| Type | Description |
| --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) |     |

#### GetIntersectedBlockData(ref MatrixD, out Vector3D, out MySlimBlock, out Nullable<UInt16>)

Calculates exact intersection point (in uniform grid coordinates) from stored havok's hit info object obtained during FindClosest grid. Returns position of intersected object in uniform grid coordinates.

##### Declaration

```
protected Nullable<Vector3D> GetIntersectedBlockData(ref MatrixD inverseGridWorldMatrix, out Vector3D intersection, out MySlimBlock intersectedBlock, out Nullable<ushort> compoundBlockId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) | inverseGridWorldMatrix |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | intersection |     |
| Sandbox.Game.Entities.Cube.MySlimBlock | intersectedBlock |     |
| System.Nullable<System.UInt16\> | compoundBlockId |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Nullable<[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\> |     |

#### InitFromDefinition(MySessionComponentDefinition)

##### Declaration

```
public override void InitFromDefinition(MySessionComponentDefinition definition)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| VRage.Game.Components.Session.MySessionComponentDefinition | definition |     |

##### Overrides

#### IntersectCubes(MyCubeGrid, out Double)

##### Declaration

```
protected Nullable<Vector3I> IntersectCubes(MyCubeGrid grid, out double distance)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html) | grid |     |
| System.Double | distance |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Nullable<[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)\> |     |

#### IntersectExact(MyCubeGrid, ref MatrixD, out Vector3D, out MySlimBlock)

Calculates exact intersection point (in uniform grid coordinates) of eye ray with the given grid of all cubes. Returns position of intersected object in uniform grid coordinates

##### Declaration

```
protected Nullable<Vector3D> IntersectExact(MyCubeGrid grid, ref MatrixD inverseGridWorldMatrix, out Vector3D intersection, out MySlimBlock intersectedBlock)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html) | grid |     |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) | inverseGridWorldMatrix |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | intersection |     |
| Sandbox.Game.Entities.Cube.MySlimBlock | intersectedBlock |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Nullable<[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\> |     |

#### IntersectInflated(List<Vector3I>, MyCubeGrid)

##### Declaration

```
protected void IntersectInflated(List<Vector3I> outHitPositions, MyCubeGrid grid)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)\> | outHitPositions |     |
| [MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html) | grid |     |