##### Declaration

```
bool IsInsideVoxel(Vector3D pos, Vector3D hintPosition, out Vector3D lastOutsidePos)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | pos | Position of object |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | hintPosition | Position of object few frames back to test whether object entered voxel. Usually pos - LinearVelocity \* x, where x it time. |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | lastOutsidePos | Last position that was outside of voxels |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsInsideWorld(Vector3D)

Returns true if distance from 0,0,0 to provided position is less than [WorldHalfExtent()](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntities.html#VRage_ModAPI_IMyEntities_WorldHalfExtent)

##### Declaration

```
bool IsInsideWorld(Vector3D pos)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | pos | Checked position in world coordinates |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if distance is less than [WorldHalfExtent()](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntities.html#VRage_ModAPI_IMyEntities_WorldHalfExtent) |

#### IsNameExists(IMyEntity, String)

Checks if registered name belongs to this entity

##### Declaration

```
bool IsNameExists(IMyEntity entity, string name)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | entity | Entity to test |
| System.String | name | Name to test |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if registered name belongs to this entity |

#### IsRaycastBlocked(Vector3D, Vector3D)

Returns true if raycast hits anything (with raycast layer=0)

##### Declaration

```
bool IsRaycastBlocked(Vector3D pos, Vector3D target)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | pos | From |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | target | To  |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsSpherePenetrating(ref BoundingSphereD)

Checks if sphere hits any Havok.HkRigidBody

##### Declaration

```
bool IsSpherePenetrating(ref BoundingSphereD bs)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html) | bs  | Sphere that used for intersection check |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if sphere hits any body |

#### IsTypeHidden(Type)

Gets whether entities that inherit type is visible or not. Example:

```
IsTypeHidden(typeof (IMyCubeGrid))
```

##### Declaration

```
bool IsTypeHidden(Type type)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Type | type |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsVisible(IMyEntity)

##### Declaration

```
bool IsVisible(IMyEntity entity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | entity |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True when visible |

#### IsWorldLimited()

Return whether world has limited size in kilometers

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if limited |

#### MarkForClose(IMyEntity)

Mark entity as closed. Soon it would be deleted. Doesn't call [Close()](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html#VRage_ModAPI_IMyEntity_Close)

##### Declaration

```
void MarkForClose(IMyEntity entity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | entity | Entity to close |

#### RegisterForDraw(IMyEntity)

Make entity receive PrepareForDraw and sending to it's Render Draw call

##### Declaration

```
void RegisterForDraw(IMyEntity entity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | entity | That should be drawn |

#### RegisterForUpdate(IMyEntity)

Make entity receive UpdateBeforeSimulation, UpdateBefore10Simulation, UpdateBefore100Simulation, UpdateAfterSimulation, UpdateAfter10Simulation, UpdateAfter100Simulation, Simulate, UpdateBeforeNextFrame depending on it's [NeedsUpdate](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html#VRage_ModAPI_IMyEntity_NeedsUpdate) flags. Physics are still simulated

##### Declaration

```
void RegisterForUpdate(IMyEntity entity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | entity | That should have updates |

#### RemapObjectBuilder(MyObjectBuilder\_EntityBase)

Remaps this entity's [EntityId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html#VRage_ModAPI_IMyEntity_EntityId) and [Name](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html#VRage_ModAPI_IMyEntity_Name) to a new values.
