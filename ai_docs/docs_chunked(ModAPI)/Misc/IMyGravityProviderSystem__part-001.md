---
title: "Interface IMyGravityProviderSystem"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyGravityProviderSystem.html"
category: "Misc"
namespace: "VRage.Game.ModAPI"
class: "IMyGravityProviderSystem"
---

# Interface IMyGravityProviderSystem | Space Engineers ModAPI

Describes gravity ModAPI

###### **Namespace**: [VRage.Game.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public interface IMyGravityProviderSystem
```

### Methods

#### AddNaturalGravity(Vector3D, Double, Double, Double, Double)

Adds natural gravity to a position.

##### Declaration

```
IMySphericalNaturalGravityComponent AddNaturalGravity(Vector3D position, double minRadius, double maxRadius, double falloff, double intensity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | position | Position coordinates at the center of the natural gravity |
| System.Double | minRadius | Minimum gravity radius before gravity intensity begins to decrease |
| System.Double | maxRadius | Max gravity radius at lowest intensity |
| System.Double | falloff | Gravity falloff between minRadius and maxRadius |
| System.Double | intensity | Gravity strength |

##### Returns

| Type | Description |
| --- | --- |
| [IMySphericalNaturalGravityComponent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMySphericalNaturalGravityComponent.html) |     |

#### AddNaturalGravityToEntity(IMyEntity, Double, Double, Double, Double)

Adds natural gravity to an entity.

##### Declaration

```
IMySphericalNaturalGravityComponent AddNaturalGravityToEntity(IMyEntity entity, double minRadius, double maxRadius, double falloff, double intensity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | entity | The entity you're adding gravity to |
| System.Double | minRadius | Minimum gravity radius before gravity intensity begins to decrease |
| System.Double | maxRadius | Max gravity radius at lowest intensity |
| System.Double | falloff | Gravity falloff between minRadius and maxRadius |
| System.Double | intensity | Gravity strength |

##### Returns

| Type | Description |
| --- | --- |
| [IMySphericalNaturalGravityComponent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMySphericalNaturalGravityComponent.html) |     |

#### AddNaturalModAPI(Vector3D, IMyModAPINaturalGravityImplementation)

Adds natural gravity to a position.

##### Declaration

```
IMyModAPINaturalGravityComponent AddNaturalModAPI(Vector3D position, IMyModAPINaturalGravityImplementation implementation)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | position | Position coordinates at the center of the natural gravity |
| [IMyModAPINaturalGravityImplementation](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyModAPINaturalGravityImplementation.html) | implementation | ModAPI custom gravity provider |

##### Returns

| Type | Description |
| --- | --- |
| [IMyModAPINaturalGravityComponent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyModAPINaturalGravityComponent.html) |     |

#### AddNaturalModAPIGravityToEntity(IMyEntity, IMyModAPINaturalGravityImplementation)

Adds natural gravity to an entity.

##### Declaration

```
IMyModAPINaturalGravityComponent AddNaturalModAPIGravityToEntity(IMyEntity entity, IMyModAPINaturalGravityImplementation implementation)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | entity | The entity you're adding gravity to |
| [IMyModAPINaturalGravityImplementation](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyModAPINaturalGravityImplementation.html) | implementation | Minimum gravity radius before gravity intensity begins to decrease |

##### Returns

| Type | Description |
| --- | --- |
| [IMyModAPINaturalGravityComponent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyModAPINaturalGravityComponent.html) |     |

#### CalculateArtificialGravityInPoint(Vector3D)

Provides a vector of all artificial gravity at a set of coordinates.

##### Declaration

```
Vector3 CalculateArtificialGravityInPoint(Vector3D worldPoint)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | worldPoint | Position coordinates to check |

##### Returns

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### CalculateHighestNaturalGravityMultiplierInPoint(Vector3D)

Provides the highest natural gravity multiplier at a set of coordinates.

##### Declaration

```
float CalculateHighestNaturalGravityMultiplierInPoint(Vector3D worldPoint)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | worldPoint | Position coordinates to check |

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### CalculateNaturalGravityInPoint(Vector3D)

Provides a vector of all natural gravity at a set of coordinates.

##### Declaration

```
Vector3 CalculateNaturalGravityInPoint(Vector3D worldPoint)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | worldPoint | Position coordinates to check |
