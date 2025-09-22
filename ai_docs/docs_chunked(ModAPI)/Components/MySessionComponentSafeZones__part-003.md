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

#### IsInSafezone(Int64, MySafeZone)

##### Declaration

```
public static bool IsInSafezone(long entityId, MySafeZone safeZone)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | entityId |     |
| [MySafeZone](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MySafeZone.html) | safeZone |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsInSafezone(Int64, List<MySafeZone>)

##### Declaration

```
public static bool IsInSafezone(long entityId, List<MySafeZone> safeZones)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | entityId |     |
| System.Collections.Generic.List<[MySafeZone](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MySafeZone.html)\> | safeZones |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsPlayerValid(UInt64, Int64, out MyIdentity, out MyCubeBlock)

Validates player and beacon associated with beacon id.

##### Declaration

```
public static bool IsPlayerValid(ulong steamId, long safeZoneBlockId, out MyIdentity playerIdentity, out MyCubeBlock beaconBlock)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.UInt64 | steamId | Player id |
| System.Int64 | safeZoneBlockId | Beacon entity id to check aginst |
| Sandbox.Game.World.MyIdentity | playerIdentity | Returns player identity id |
| [MyCubeBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeBlock.html) | beaconBlock | Returns block |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsRecentlyAddedOrRemoved(MyEntity)

##### Declaration

```
public static bool IsRecentlyAddedOrRemoved(MyEntity obj)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) | obj |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsSafeZoneColliding(Int64, MatrixD, MySafeZoneShape, Single, Vector3)

##### Declaration

```
public static bool IsSafeZoneColliding(long safeZoneId, MatrixD safeZoneWorld, MySafeZoneShape shape, float newRadius = 0F, Vector3 newSize = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | safeZoneId |     |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) | safeZoneWorld |     |
| [MySafeZoneShape](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.MySafeZoneShape.html) | shape |     |
| System.Single | newRadius |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | newSize |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### LoadData()

##### Declaration

```
public override void LoadData()
```

##### Overrides

#### RemoveSafeZone(MySafeZone)

##### Declaration

```
public static void RemoveSafeZone(MySafeZone safeZone)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MySafeZone](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MySafeZone.html) | safeZone |     |

#### RequestCreateSafeZone(Vector3D)

##### Declaration

```
public static void RequestCreateSafeZone(Vector3D position)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | position |     |

#### RequestDeleteSafeZone(Int64)

##### Declaration

```
public static void RequestDeleteSafeZone(long entityId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | entityId |     |

#### RequestUpdateGlobalSafeZone()

##### Declaration

```
public static void RequestUpdateGlobalSafeZone()
```

#### RequestUpdateSafeZone(MyObjectBuilder\_SafeZone)

##### Declaration

```
public static void RequestUpdateSafeZone(MyObjectBuilder_SafeZone ob)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_SafeZone](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.MyObjectBuilder_SafeZone.html) | ob  |     |

#### RequestUpdateSafeZone\_Player(Int64, MyObjectBuilder\_SafeZone)

Updates safe zone of a beacon with new settings set inside of the object builder

##### Declaration

```
public static void RequestUpdateSafeZone_Player(long safeZoneBlockId, MyObjectBuilder_SafeZone ob)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | safeZoneBlockId | Beacon for which to update safe zone |
| [MyObjectBuilder\_SafeZone](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.MyObjectBuilder_SafeZone.html) | ob  | Object builder containing new safe zone settings. |

#### RequestUpdateSafeZonePlayer(Int64, MyObjectBuilder\_SafeZone)

##### Declaration

```
public static void RequestUpdateSafeZonePlayer(long safeZoneBlockId, MyObjectBuilder_SafeZone ob)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | safeZoneBlockId |     |
| [MyObjectBuilder\_SafeZone](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.MyObjectBuilder_SafeZone.html) | ob  |     |

#### RequestUpdateSafeZoneRadius\_Player(Int64, Int64, Single)

##### Declaration

```
public static void RequestUpdateSafeZoneRadius_Player(long safezoneBlockId, long safezoneId, float newRadius)
```
