#### IMyCameraBlock.IsActive

##### Declaration

```
bool IMyCameraBlock.IsActive { get; }
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IMyCameraBlock.Raycast(Double, Single, Single)

##### Declaration

```
MyDetectedEntityInfo IMyCameraBlock.Raycast(double distance, float pitch, float yaw)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Double | distance |     |
| System.Single | pitch |     |
| System.Single | yaw |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyDetectedEntityInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.MyDetectedEntityInfo.html) |     |

#### IMyCameraBlock.Raycast(Double, Vector3D)

##### Declaration

```
MyDetectedEntityInfo IMyCameraBlock.Raycast(double distance, Vector3D targetDirection)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Double | distance |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | targetDirection |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyDetectedEntityInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.MyDetectedEntityInfo.html) |     |

#### IMyCameraBlock.Raycast(Vector3D)

##### Declaration

```
MyDetectedEntityInfo IMyCameraBlock.Raycast(Vector3D targetPos)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | targetPos |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyDetectedEntityInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.MyDetectedEntityInfo.html) |     |

#### IMyCameraBlock.RaycastConeLimit

##### Declaration

```
float IMyCameraBlock.RaycastConeLimit { get; }
```

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### IMyCameraBlock.RaycastDistanceLimit

##### Declaration

```
double IMyCameraBlock.RaycastDistanceLimit { get; }
```

##### Returns

| Type | Description |
| --- | --- |
| System.Double |     |

#### IMyCameraBlock.RaycastTimeMultiplier

##### Declaration

```
float IMyCameraBlock.RaycastTimeMultiplier { get; }
```

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### IMyCameraBlock.TimeUntilScan(Double)

##### Declaration

```
int IMyCameraBlock.TimeUntilScan(double distance)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Double | distance |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### IMyCameraController.AllowCubeBuilding

##### Declaration

```
bool IMyCameraController.AllowCubeBuilding { get; }
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IMyCameraController.ControlCamera(MyCamera)

##### Declaration

```
void IMyCameraController.ControlCamera(MyCamera currentCamera)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| VRage.Game.Utils.MyCamera | currentCamera |     |

#### IMyCameraController.ForceFirstPersonCamera

##### Declaration

```
bool IMyCameraController.ForceFirstPersonCamera { get; set; }
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IMyCameraController.HandlePickUp()

##### Declaration

```
bool IMyCameraController.HandlePickUp()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IMyCameraController.HandleUse()

##### Declaration

```
bool IMyCameraController.HandleUse()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IMyCameraController.IsInFirstPersonView

##### Declaration

```
bool IMyCameraController.IsInFirstPersonView { get; set; }
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IMyCameraController.OnAssumeControl(IMyCameraController)

##### Declaration

```
void IMyCameraController.OnAssumeControl(IMyCameraController previousCameraController)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyCameraController](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Interfaces.IMyCameraController.html) | previousCameraController |     |

#### IMyCameraController.OnReleaseControl(IMyCameraController)

##### Declaration

```
void IMyCameraController.OnReleaseControl(IMyCameraController newCameraController)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyCameraController](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Interfaces.IMyCameraController.html) | newCameraController |     |

#### IMyCameraController.Rotate(Vector2, Single)

##### Declaration

```
void IMyCameraController.Rotate(Vector2 rotationIndicator, float rollIndicator)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html) | rotationIndicator |     |
| System.Single | rollIndicator |     |

#### IMyCameraController.RotateStopped()

##### Declaration

```
void IMyCameraController.RotateStopped()
```

### Implements

### Extension Methods