---
title: "Interface IMyPhysics"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyPhysics.html"
category: "Misc"
namespace: "VRage.Game.ModAPI"
class: "IMyPhysics"
---

# Interface IMyPhysics | Space Engineers ModAPI

Mod API interface giving you access to physics

###### **Namespace**: [VRage.Game.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public interface IMyPhysics
```

### Properties

#### ServerSimulationRatio

The server's simulation ratio. When physics cannot keep up server side this is smaller than 1.

##### Declaration

```
float ServerSimulationRatio { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### SimulationRatio

Simulation ratio, when physics cannot keep up, this is smaller than 1

##### Declaration

```
float SimulationRatio { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### StepsLastSecond

Number of physics steps done in last second

##### Declaration

```
int StepsLastSecond { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

### Methods

#### CalculateArtificialGravityAt(Vector3D, Single)

Returns current artificial gravity at world position.

##### Declaration

```
Vector3 CalculateArtificialGravityAt(Vector3D worldPosition, float naturalGravityInterference = 1F)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | worldPosition | Target position |
| System.Single | naturalGravityInterference | Artificial gravity strength is affected by presence of natural gravity. Use [CalculateNaturalGravityAt(Vector3D, out Single)](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyPhysics.html#VRage_Game_ModAPI_IMyPhysics_CalculateNaturalGravityAt_VRageMath_Vector3D_System_Single__) to get correct value for given point in space. Value of 1 indicates no natural gravity effect. |

##### Returns

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### CalculateNaturalGravityAt(Vector3D, out Single)

Returns current natural gravity at world position.

##### Declaration

```
Vector3 CalculateNaturalGravityAt(Vector3D worldPosition, out float naturalGravityInterference)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | worldPosition | Target position |
| System.Single | naturalGravityInterference | Natural gravity affects artificial gravity strength. Use this value when calling [CalculateArtificialGravityAt(Vector3D, Single)](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyPhysics.html#VRage_Game_ModAPI_IMyPhysics_CalculateArtificialGravityAt_VRageMath_Vector3D_System_Single_) to get effective (physical) strength of artificial gravity at point. |

##### Returns

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### CastLongRay(Vector3D, Vector3D, out IHitInfo, Boolean)

Finds closest or any object on the path of the ray from->to. Uses Storage for voxels for faster search but only good for long rays (more or less more than 50m). Use it only in such cases.

##### Declaration

```
bool CastLongRay(Vector3D from, Vector3D to, out IHitInfo hitInfo, bool any)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | from | Start of the ray. |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | to  | End of the ray. |
| [IHitInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IHitInfo.html) | hitInfo | Hit info |
| System.Boolean | any | Indicates if method should return any object found (May not be closest) |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | true if hit, false if no hit |

#### CastRay(Vector3D, Vector3D, List<IHitInfo>, Int32)

Cast a ray and returns all matching entities. Must not be called from parallel thread!!!

##### Declaration

```
void CastRay(Vector3D from, Vector3D to, List<IHitInfo> toList, int raycastFilterLayer = 0)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | from | Start of ray. |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | to  | End of ray. |
| System.Collections.Generic.List<[IHitInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IHitInfo.html)\> | toList | List of hits |
| System.Int32 | raycastFilterLayer | Collision layer |

#### CastRay(Vector3D, Vector3D, out IHitInfo, Int32)

Cast a ray and return first entity. Must not be called from parallel thread!!!

##### Declaration

```
bool CastRay(Vector3D from, Vector3D to, out IHitInfo hitInfo, int raycastFilterLayer = 0)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | from | Start of ray. |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | to  | End of ray. |
| [IHitInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IHitInfo.html) | hitInfo | Hit info |
| System.Int32 | raycastFilterLayer | Collision layer |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | true if hit; false if no hit |
