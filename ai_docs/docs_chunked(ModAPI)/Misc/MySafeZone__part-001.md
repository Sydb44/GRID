---
title: "Class MySafeZone"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MySafeZone.html"
category: "Misc"
namespace: "Sandbox.Game.Entities"
class: "MySafeZone"
---

# Class MySafeZone | Space Engineers ModAPI

##### Inheritance

System.Object

MySafeZone

##### Implements

##### Inherited Members

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyEntityType]
public class MySafeZone : MyEntity, IMyEntity, IMyEntity, IMyEventProxy, IMyEventOwner, IMyProjectileDetector
```

### Constructors

#### MySafeZone()

##### Declaration

### Fields

#### Entities

##### Declaration

```
public HashSet<long> Entities
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.HashSet<System.Int64\> |     |

#### Factions

##### Declaration

```
public List<MyFaction> Factions
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<Sandbox.Game.World.MyFaction\> |     |

#### m\_containedEntities

##### Declaration

```
protected readonly MyConcurrentHashSet<long> m_containedEntities
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyConcurrentHashSet](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.MyConcurrentHashSet-1.html)<System.Int64\> |     |

#### MAX\_RADIUS

##### Declaration

```
public static readonly float MAX_RADIUS
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### MIN\_RADIUS

##### Declaration

```
public static readonly float MIN_RADIUS
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Players

##### Declaration

```
public List<long> Players
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<System.Int64\> |     |

#### Radius

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

### Properties

#### AccessTypeFactions

##### Declaration

```
public MySafeZoneAccess AccessTypeFactions { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MySafeZoneAccess](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.MySafeZoneAccess.html) |     |

#### AccessTypeFloatingObjects

##### Declaration

```
public MySafeZoneAccess AccessTypeFloatingObjects { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MySafeZoneAccess](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.MySafeZoneAccess.html) |     |

#### AccessTypeGrids

##### Declaration

```
public MySafeZoneAccess AccessTypeGrids { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MySafeZoneAccess](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.MySafeZoneAccess.html) |     |

#### AccessTypePlayers

##### Declaration

```
public MySafeZoneAccess AccessTypePlayers { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MySafeZoneAccess](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.MySafeZoneAccess.html) |     |

#### AllowedActions

##### Declaration

```
public MySafeZoneAction AllowedActions { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| VRage.Game.ObjectBuilders.Components.MySafeZoneAction |     |

#### CurrentTexture

##### Declaration

```
public MyStringHash CurrentTexture { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) |     |

#### DetectorAABB

##### Declaration

```
public BoundingBoxD DetectorAABB { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) |     |

#### Enabled

##### Declaration

```
public bool Enabled { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### HitEntity

##### Declaration

```
public IMyEntity HitEntity { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) |     |

#### IsDetectorEnabled

##### Declaration

```
public bool IsDetectorEnabled { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsStatic

Static safe zone is any which cannot move (for example for safe zone block).

##### Declaration

```
public bool IsStatic { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ModelColor

##### Declaration

```
public Color ModelColor { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html) |     |

#### SafeZoneBlockId

Entity id of the safezone block associated with the safezone. If 0 than safezone is not associated to any block.

##### Declaration

```
public long SafeZoneBlockId { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### Shape

##### Declaration

```
public MySafeZoneShape Shape { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MySafeZoneShape](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.MySafeZoneShape.html) |     |

#### Size

##### Declaration

```
public Vector3 Size { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

### Methods
