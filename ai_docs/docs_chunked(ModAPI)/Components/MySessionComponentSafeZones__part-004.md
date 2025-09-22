
| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | safeZoneBlockId |     |
| [MyObjectBuilder\_SafeZone](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.MyObjectBuilder_SafeZone.html) | ob  |     |

#### RequestUpdateSafeZoneRadius\_Player(Int64, Int64, Single)

##### Declaration

```
public static void RequestUpdateSafeZoneRadius_Player(long safezoneBlockId, long safezoneId, float newRadius)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | safezoneBlockId |     |
| System.Int64 | safezoneId |     |
| System.Single | newRadius |     |

#### UnloadData()

##### Declaration

```
protected override void UnloadData()
```

##### Overrides

#### UpdateAfterSimulation()

##### Declaration

```
public override void UpdateAfterSimulation()
```

##### Overrides

#### UpdateGlobalSafeZone\_Implementation(MySafeZoneAction)

##### Declaration

```
[Event(null, 732)]
[Reliable]
[Server]
[Broadcast]
public static void UpdateGlobalSafeZone_Implementation(MySafeZoneAction allowedActions)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| VRage.Game.ObjectBuilders.Components.MySafeZoneAction | allowedActions |     |

#### UpdateSafeZone(MyObjectBuilder\_SafeZone, Boolean)

Updates save zone with data from object builder. Use only on server

##### Declaration

```
public static void UpdateSafeZone(MyObjectBuilder_SafeZone ob, bool sync = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_SafeZone](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.MyObjectBuilder_SafeZone.html) | ob  | Object builder with new data |
| System.Boolean | sync |     |

#### UpdateSafeZone\_Implementation(MyObjectBuilder\_SafeZone)

##### Declaration

```
[Event(null, 527)]
[Reliable]
[Server]
[Broadcast]
public static void UpdateSafeZone_Implementation(MyObjectBuilder_SafeZone ob)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_SafeZone](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.MyObjectBuilder_SafeZone.html) | ob  |     |

#### UpdateSafeZone\_ImplementationPlayer(Int64, MyObjectBuilder\_SafeZone)

##### Declaration

```
[Event(null, 588)]
[Reliable]
[Server]
[Broadcast]
public static void UpdateSafeZone_ImplementationPlayer(long safezoneBlockId, MyObjectBuilder_SafeZone ob)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | safezoneBlockId |     |
| [MyObjectBuilder\_SafeZone](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.MyObjectBuilder_SafeZone.html) | ob  |     |

#### UpdateSafeZonePlayer\_Implementation(Int64, MyObjectBuilder\_SafeZone)

##### Declaration

```
[Event(null, 534)]
[Reliable]
[Server]
[Broadcast]
public static void UpdateSafeZonePlayer_Implementation(long safeZoneBlockId, MyObjectBuilder_SafeZone ob)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | safeZoneBlockId |     |
| [MyObjectBuilder\_SafeZone](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.MyObjectBuilder_SafeZone.html) | ob  |     |

#### UpdateSafeZoneRadius\_ImplementationPlayer(Int64, Int64, Single)

##### Declaration

```
[Event(null, 621)]
[Reliable]
[Server]
[Broadcast]
public static void UpdateSafeZoneRadius_ImplementationPlayer(long safezoneBlockId, long safezoneId, float radius)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | safezoneBlockId |     |
| System.Int64 | safezoneId |     |
| System.Single | radius |     |

### Events

#### OnAddSafeZone

##### Declaration

```
public static event EventHandler OnAddSafeZone
```

##### Event Type

| Type | Description |
| --- | --- |
| System.EventHandler |     |

#### OnRemoveSafeZone

##### Declaration

```
public static event EventHandler OnRemoveSafeZone
```

##### Event Type

| Type | Description |
| --- | --- |
| System.EventHandler |     |

#### OnSafeZoneUpdated

##### Declaration

```
public static event Action<MySafeZone> OnSafeZoneUpdated
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<[MySafeZone](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MySafeZone.html)\> |     |