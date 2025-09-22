Provides a vector of all natural gravity at a set of coordinates.

##### Declaration

```
Vector3 CalculateNaturalGravityInPoint(Vector3D worldPoint)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | worldPoint | Position coordinates to check |

##### Returns

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### CalculateNaturalGravityInPoint(Vector3D, out Single)

Calculates all natural gravity at provided coordinates, returns gravity vector, and outputs gravity multiplier

##### Declaration

```
Vector3 CalculateNaturalGravityInPoint(Vector3D worldPoint, out float naturalGravityMultiplier)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | worldPoint | Position coordinates to check |
| System.Single | naturalGravityMultiplier | Gravity multiplier output |

##### Returns

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### CalculateTotalGravityInPoint(Vector3D)

Provides a vector of all natural and artificial gravity at a sec of coordinates.

##### Declaration

```
Vector3 CalculateTotalGravityInPoint(Vector3D worldPoint)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | worldPoint | Position coordinates to check |

##### Returns

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### DoesEntityHaveGravityProvider(IMyEntity)

Determines if a provided entity is generating gravity (artificial or natural).

##### Declaration

```
bool DoesEntityHaveGravityProvider(IMyEntity entity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | entity | Entity to check for gravity |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### DoesTrajectoryIntersectNaturalGravity(Vector3D, Vector3D, Double)

Checks if the specified trajectory intersects any natural gravity wells.

##### Declaration

```
bool DoesTrajectoryIntersectNaturalGravity(Vector3D start, Vector3D end, double raySize = 0)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | start | Starting point of the trajectory. |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | end | Destination of the trajectory. |
| System.Double | raySize | Size of the ray to test with. (Cylinder test) |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### GetStrongestNaturalGravityWell(Vector3D, out IMyNaturalGravityComponent)

Determines the strongest natural gravity source at a given set of coordinates.

##### Declaration

```
double GetStrongestNaturalGravityWell(Vector3D worldPosition, out IMyNaturalGravityComponent nearestProvider)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | worldPosition | Position coordinates to check |
| [IMyNaturalGravityComponent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyNaturalGravityComponent.html) | nearestProvider | Outputs the strongest natural gravity component detected |

##### Returns

| Type | Description |
| --- | --- |
| System.Double | Gravity intensity value |

#### IsPositionInNaturalGravity(Vector3D, Double)

This quickly checks if a given position is in any natural gravity.

##### Declaration

```
bool IsPositionInNaturalGravity(Vector3D position, double sphereSize = 0)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | position | Position to check |
| System.Double | sphereSize | Sphere size to test with. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if there is natural gravity at this position, false otherwise. |

#### RemoveNaturalGravity(IMyNaturalGravityComponent)

Removes the natural gravity component provided.

##### Declaration

```
void RemoveNaturalGravity(IMyNaturalGravityComponent gravity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyNaturalGravityComponent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyNaturalGravityComponent.html) | gravity | Natural gravity component to remove. |

#### RemoveNaturalGravityFromEntity(IMyEntity)

Removes the natural gravity from a provided entity.

##### Declaration

```
void RemoveNaturalGravityFromEntity(IMyEntity entity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | entity | The entity you're removing natural gravity from. |