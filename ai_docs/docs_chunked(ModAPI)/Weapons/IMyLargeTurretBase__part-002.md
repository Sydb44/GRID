
##### Declaration

```
void SetManualAzimuthAndElevation(float azimuth, float elevation)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | azimuth | azimuth value |
| System.Single | elevation | elevation value |

#### SetTarget(Vector3D)

Set targets given position

##### Declaration

```
void SetTarget(Vector3D pos)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | pos | Target world coordinates |

#### SetTargetingGroup(String)

Sets current targeting group

##### Declaration

```
void SetTargetingGroup(string groupSubtypeId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | groupSubtypeId |     |

#### SyncAzimuth()

Method used to sync azimuth, you need to call it to sync azimuth for other clients/server

##### Declaration

#### SyncElevation()

Method used to sync elevation of turret, you need to call it to sync elevation for other clients/server

##### Declaration

#### SyncEnableIdleRotation()

Method used to sync idle rotation and elevation, you need to call it to sync rotation and elevation for other clients/server

##### Declaration

```
void SyncEnableIdleRotation()
```

#### TrackTarget(Vector3D, Vector3)

Tracks given target with enabled position prediction

##### Declaration

```
void TrackTarget(Vector3D pos, Vector3 velocity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | pos | Position of turret |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | velocity | Velocity of target |

### Extension Methods