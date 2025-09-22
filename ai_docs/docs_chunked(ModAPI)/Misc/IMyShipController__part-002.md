| Type | Description |
| --- | --- |
| [MyShipVelocities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.MyShipVelocities.html) |     |

#### GetTotalGravity()

Gets the total accumulated gravity vector and power at the current location, taking both natural and artificial gravity into account.

##### Declaration

```
Vector3D GetTotalGravity()
```

##### Returns

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | Total gravity vector |

#### TryGetPlanetElevation(MyPlanetElevation, out Double)

Attempts to get the elevation of the ship in relation to the nearest planet. This method is only available when a ship is within the gravity well of a planet.

##### Declaration

```
bool TryGetPlanetElevation(MyPlanetElevation detail, out double elevation)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyPlanetElevation](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.MyPlanetElevation.html) | detail | Mode |
| System.Double | elevation |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if cockpit is in planet gravity |

#### TryGetPlanetPosition(out Vector3D)

Attempts to get the world position of the nearest planet. This method is only available when a ship is within the gravity well of a planet.

##### Declaration

```
bool TryGetPlanetPosition(out Vector3D position)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | position | Position of closet planet or [Zero](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html#VRageMath_Vector3_Zero) |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if cockpit is in gravity of planet |

### Extension Methods