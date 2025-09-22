---
title: "Class MySessionComponentSafeZones"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MySessionComponentSafeZones.html"
category: "Components"
namespace: "Sandbox.Game.Entities"
class: "MySessionComponentSafeZones"
---

# Class MySessionComponentSafeZones | Space Engineers ModAPI

##### Inheritance

System.Object

MySessionComponentSafeZones

##### Inherited Members

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[StaticEventOwner]
[MySessionComponentDescriptor]
public class MySessionComponentSafeZones : MySessionComponentBase, IMyUserInputComponent
```

### Constructors

#### MySessionComponentSafeZones()

##### Declaration

```
public MySessionComponentSafeZones()
```

### Fields

#### AllowedActions

##### Declaration

```
public static MySafeZoneAction AllowedActions
```

##### Field Value

| Type | Description |
| --- | --- |
| VRage.Game.ObjectBuilders.Components.MySafeZoneAction |     |

### Properties

#### IsRequiredByGame

##### Declaration

```
public override bool IsRequiredByGame { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Overrides

#### SafeZones

##### Declaration

```
public static ListReader<MySafeZone> SafeZones { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [ListReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.ListReader-1.html)<[MySafeZone](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MySafeZone.html)\> |     |

### Methods

#### AddSafeZone(MySafeZone)

##### Declaration

```
public static void AddSafeZone(MySafeZone safeZone)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MySafeZone](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MySafeZone.html) | safeZone |     |

#### CanPerformAction(MySafeZoneAction, UInt64)

##### Declaration

```
public static bool CanPerformAction(MySafeZoneAction action, ulong user = 0UL)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| VRage.Game.ObjectBuilders.Components.MySafeZoneAction | action |     |
| System.UInt64 | user |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### CrateSafeZone(MatrixD, MySafeZoneShape, MySafeZoneAccess, Int64\[\], Int64\[\], Single, Boolean, Boolean, Vector3, String, Int64, String)

##### Declaration

```
public static MyEntity CrateSafeZone(MatrixD transform, MySafeZoneShape safeZoneShape, MySafeZoneAccess zoneAccess, long[] players, long[] factions, float startRadius, bool enable, bool isVisible = true, Vector3 color = null, string visualTexture = "", long safeZoneBlockId = 0L, string name = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) | transform |     |
| [MySafeZoneShape](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.MySafeZoneShape.html) | safeZoneShape |     |
| [MySafeZoneAccess](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.MySafeZoneAccess.html) | zoneAccess |     |
| System.Int64\[\] | players |     |
| System.Int64\[\] | factions |     |
| System.Single | startRadius |     |
| System.Boolean | enable |     |
| System.Boolean | isVisible |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | color |     |
| System.String | visualTexture |     |
| System.Int64 | safeZoneBlockId |     |
| System.String | name |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) |     |

#### CreateSafeZone\_Implementation(Vector3D)

##### Declaration

```
[Event(null, 325)]
[Reliable]
[Server]
public static void CreateSafeZone_Implementation(Vector3D position)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | position |     |

#### CreateSafeZone\_ImplementationPlayer(Int64, Single, Boolean, UInt64)

##### Declaration

```
public static long CreateSafeZone_ImplementationPlayer(long safeZoneBlockId, float startRadius, bool activate, ulong playerSteamId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | safeZoneBlockId |     |
| System.Single | startRadius |     |
| System.Boolean | activate |     |
| System.UInt64 | playerSteamId |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### DeleteSafeZone\_Implementation(Int64)

##### Declaration

```
[Event(null, 483)]
[Reliable]
[Server]
public static void DeleteSafeZone_Implementation(long entityId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | entityId |     |

#### DeleteSafeZone\_ImplementationPlayer(Int64, Int64, UInt64)

##### Declaration

```
public static void DeleteSafeZone_ImplementationPlayer(long safeZoneBlockId, long safeZoneId, ulong steamId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | safeZoneBlockId |     |
| System.Int64 | safeZoneId |     |
| System.UInt64 | steamId |     |

#### GetBelongingSafezones(Int64, ICollection<MySafeZone>)

##### Declaration

```
public static void GetBelongingSafezones(long entity, ICollection<MySafeZone> where)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | entity |     |
| System.Collections.Generic.ICollection<[MySafeZone](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MySafeZone.html)\> | where |     |
