##### Declaration

```
protected override void InitVoxelMap(MatrixD worldMatrix, Vector3I size, bool useOffset = true)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) | worldMatrix |     |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | size |     |
| System.Boolean | useOffset |     |

##### Overrides

#### IsOverlapOverThreshold(BoundingBoxD, Single)

##### Declaration

```
public override bool IsOverlapOverThreshold(BoundingBoxD worldAabb, float thresholdPercentage)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | worldAabb |     |
| System.Single | thresholdPercentage |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Overrides

#### UpdateAfterSimulation10()

##### Declaration

```
public override void UpdateAfterSimulation10()
```

##### Overrides

#### UpdateBeforeSimulation10()

##### Declaration

```
public override void UpdateBeforeSimulation10()
```

##### Overrides

#### UpdateOnceBeforeFrame()

##### Declaration

```
public override void UpdateOnceBeforeFrame()
```

##### Overrides

### Explicit Interface Implementations

#### IMyVoxelMap.ClampVoxelCoord(ref Vector3I)

##### Declaration

```
void IMyVoxelMap.ClampVoxelCoord(ref Vector3I voxelCoord)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | voxelCoord |     |

#### IMyVoxelMap.Close()

##### Declaration

#### IMyVoxelMap.DoOverlapSphereTest(Single, Vector3D)

##### Declaration

```
bool IMyVoxelMap.DoOverlapSphereTest(float sphereRadius, Vector3D spherePos)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | sphereRadius |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | spherePos |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IMyVoxelMap.GetIntersectionWithSphere(ref BoundingSphereD)

##### Declaration

```
bool IMyVoxelMap.GetIntersectionWithSphere(ref BoundingSphereD sphere)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html) | sphere |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IMyVoxelMap.GetObjectBuilder(Boolean)

##### Declaration

```
MyObjectBuilder_EntityBase IMyVoxelMap.GetObjectBuilder(bool copy)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | copy |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_EntityBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_EntityBase.html) |     |

#### IMyVoxelMap.GetVoxelContentInBoundingBox(BoundingBoxD, out Single)

##### Declaration

```
float IMyVoxelMap.GetVoxelContentInBoundingBox(BoundingBoxD worldAabb, out float cellCount)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | worldAabb |     |
| System.Single | cellCount |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### IMyVoxelMap.GetVoxelCoordinateFromMeters(Vector3D)

##### Declaration

```
Vector3I IMyVoxelMap.GetVoxelCoordinateFromMeters(Vector3D pos)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | pos |     |

##### Returns

| Type | Description |
| --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) |     |

#### IMyVoxelMap.Init(MyObjectBuilder\_EntityBase)

##### Declaration

```
void IMyVoxelMap.Init(MyObjectBuilder_EntityBase builder)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_EntityBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_EntityBase.html) | builder |     |

### Implements

### Extension Methods