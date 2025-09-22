##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) | child |     |

#### AddToStationOreBlockTree(ref MyDynamicAABBTree, Vector3D, Single)

##### Declaration

```
public void AddToStationOreBlockTree(ref MyDynamicAABBTree stationOreBlockTree, Vector3D position, float radius)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDynamicAABBTree](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyDynamicAABBTree.html) | stationOreBlockTree |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | position |     |
| System.Single | radius |     |

#### AfterPaste()

##### Declaration

```
public override void AfterPaste()
```

##### Overrides

#### BeforeDelete()

##### Declaration

```
protected override void BeforeDelete()
```

##### Overrides

#### BeforePaste()

##### Declaration

```
public override void BeforePaste()
```

##### Overrides

#### Closing()

##### Declaration

```
protected override void Closing()
```

##### Overrides

#### CorrectSpawnLocation(ref Vector3D, Double)

##### Declaration

```
public void CorrectSpawnLocation(ref Vector3D position, double radius)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | position |     |
| System.Double | radius |     |

#### CorrectSpawnLocation2(ref Vector3D, Double, Boolean)

##### Declaration

```
public bool CorrectSpawnLocation2(ref Vector3D position, double radius, bool resumeSearch = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | position |     |
| System.Double | radius |     |
| System.Boolean | resumeSearch | Don't modify initial search position |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if it a safe position is found |

#### DebugDrawPhysics()

##### Declaration

```
public override void DebugDrawPhysics()
```

##### Overrides

#### GetAirDensity(Vector3D)

##### Declaration

```
public float GetAirDensity(Vector3D worldPosition)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | worldPosition |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### GetClosestSurfacePointGlobal(Vector3D)

##### Declaration

```
public Vector3D GetClosestSurfacePointGlobal(Vector3D globalPos)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | globalPos |     |

##### Returns

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

#### GetClosestSurfacePointGlobal(ref Vector3D)

##### Declaration

```
public Vector3D GetClosestSurfacePointGlobal(ref Vector3D globalPos)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | globalPos |     |

##### Returns

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

#### GetClosestSurfacePointLocal(ref Vector3)

##### Declaration

```
public Vector3D GetClosestSurfacePointLocal(ref Vector3 localPos)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | localPos |     |

##### Returns

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

#### GetHeightFromSurface(Vector3D)

##### Declaration

```
public double GetHeightFromSurface(Vector3D position)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | position |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Double |     |

#### GetInstanceHash()

##### Declaration

```
public int GetInstanceHash()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### GetObjectBuilder(Boolean)

##### Declaration

```
public override MyObjectBuilder_EntityBase GetObjectBuilder(bool copy = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | copy |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_EntityBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_EntityBase.html) |     |

##### Overrides

#### GetOrePriority()

##### Declaration

```
public override int GetOrePriority()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

##### Overrides

#### GetOxygenForPosition(Vector3D)

##### Declaration

```
public float GetOxygenForPosition(Vector3D worldPoint)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | worldPoint |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### GetWindSpeed(Vector3D)

##### Declaration

```
public float GetWindSpeed(Vector3D worldPosition)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | worldPosition |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |
