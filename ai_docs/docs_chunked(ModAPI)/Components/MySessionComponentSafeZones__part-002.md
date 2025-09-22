
##### Declaration

```
public static void GetBelongingSafezones(long entity, ICollection<MySafeZone> where)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | entity |     |
| System.Collections.Generic.ICollection<[MySafeZone](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MySafeZone.html)\> | where |     |

#### GetObjectBuilder()

##### Declaration

```
public override MyObjectBuilder_SessionComponent GetObjectBuilder()
```

##### Returns

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_SessionComponent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_SessionComponent.html) |     |

##### Overrides

#### GetSafeZonesInAABB(BoundingBoxD, List<MySafeZone>)

##### Declaration

```
public static List<MySafeZone> GetSafeZonesInAABB(BoundingBoxD worldAabb, List<MySafeZone> buffer = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | worldAabb |     |
| System.Collections.Generic.List<[MySafeZone](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MySafeZone.html)\> | buffer |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MySafeZone](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MySafeZone.html)\> |     |

#### Init(MyObjectBuilder\_SessionComponent)

##### Declaration

```
public override void Init(MyObjectBuilder_SessionComponent sessionComponent)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_SessionComponent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_SessionComponent.html) | sessionComponent |     |

##### Overrides

#### IsActionAllowed(MyCubeGrid, Vector3I, Vector3I, MySafeZoneAction, Int64)

##### Declaration

```
public static bool IsActionAllowed(MyCubeGrid grid, Vector3I cubeMin, Vector3I cubeMax, MySafeZoneAction AllowedActions, long attackerId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html) | grid |     |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | cubeMin |     |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | cubeMax |     |
| VRage.Game.ObjectBuilders.Components.MySafeZoneAction | AllowedActions |     |
| System.Int64 | attackerId |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsActionAllowed(MyEntity, MySafeZoneAction, Int64, UInt64)

Checks if action is allowed.

##### Declaration

```
public static bool IsActionAllowed(MyEntity entity, MySafeZoneAction action, long sourceEntityId = 0L, ulong user = 0UL)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) | entity | Entity that would have applied action |
| VRage.Game.ObjectBuilders.Components.MySafeZoneAction | action | What king of action |
| System.Int64 | sourceEntityId | Who is performing action |
| System.UInt64 | user | What player triggered action |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsActionAllowed(BoundingBoxD, MySafeZoneAction, Int64, UInt64)

##### Declaration

```
public static bool IsActionAllowed(BoundingBoxD aabb, MySafeZoneAction action, long sourceEntityId = 0L, ulong user = 0UL)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | aabb |     |
| VRage.Game.ObjectBuilders.Components.MySafeZoneAction | action |     |
| System.Int64 | sourceEntityId |     |
| System.UInt64 | user |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsActionAllowed(BoundingSphere, MySafeZoneAction, Int64, UInt64)

##### Declaration

```
public static bool IsActionAllowed(BoundingSphere boundingSphere, MySafeZoneAction action, long sourceEntityId = 0L, ulong user = 0UL)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphere](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphere.html) | boundingSphere |     |
| VRage.Game.ObjectBuilders.Components.MySafeZoneAction | action |     |
| System.Int64 | sourceEntityId |     |
| System.UInt64 | user |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsActionAllowed(Vector3D, MySafeZoneAction, Int64, UInt64)

##### Declaration

```
public static bool IsActionAllowed(Vector3D point, MySafeZoneAction action, long sourceEntityId = 0L, ulong user = 0UL)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | point |     |
| VRage.Game.ObjectBuilders.Components.MySafeZoneAction | action |     |
| System.Int64 | sourceEntityId |     |
| System.UInt64 | user |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsActionAllowedFullyInside(MyCubeGrid, MySafeZoneAction, Int64)

##### Declaration

```
public static bool IsActionAllowedFullyInside(MyCubeGrid grid, MySafeZoneAction AllowedActions, long sourceEntityId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html) | grid |     |
| VRage.Game.ObjectBuilders.Components.MySafeZoneAction | AllowedActions |     |
| System.Int64 | sourceEntityId |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |
