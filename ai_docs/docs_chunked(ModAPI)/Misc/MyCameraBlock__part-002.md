
##### Declaration

```
public override void Init(MyObjectBuilder_CubeBlock objectBuilder, MyCubeGrid cubeGrid)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_CubeBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_CubeBlock.html) | objectBuilder |     |
| [MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html) | cubeGrid |     |

##### Overrides

Sandbox.Game.Entities.Cube.MyFunctionalBlock.Init(VRage.Game.MyObjectBuilder\_CubeBlock, Sandbox.Game.Entities.MyCubeGrid)

#### OnActiveChanged(Boolean)

##### Declaration

```
public void OnActiveChanged(bool state)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | state |     |

#### OnAddedToScene(Object)

##### Declaration

```
public override void OnAddedToScene(object source)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | source |     |

##### Overrides

Sandbox.Game.Entities.Cube.MyFunctionalBlock.OnAddedToScene(System.Object)

#### OnAssumeControl(IMyCameraController)

##### Declaration

```
public void OnAssumeControl(IMyCameraController previousCameraController)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyCameraController](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Interfaces.IMyCameraController.html) | previousCameraController |     |

#### OnEnabledChanged()

##### Declaration

```
protected override void OnEnabledChanged()
```

##### Overrides

Sandbox.Game.Entities.Cube.MyFunctionalBlock.OnEnabledChanged()

#### OnExitView()

##### Declaration

#### OnReleaseControl(IMyCameraController)

##### Declaration

```
public void OnReleaseControl(IMyCameraController newCameraController)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyCameraController](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Interfaces.IMyCameraController.html) | newCameraController |     |

#### Raycast(Double, Vector3D)

##### Declaration

```
public MyDetectedEntityInfo Raycast(double distance, Vector3D direction)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Double | distance |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | direction |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyDetectedEntityInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.MyDetectedEntityInfo.html) |     |

#### RequestSetView()

##### Declaration

```
public void RequestSetView()
```

#### Rotate(Vector2, Single)

##### Declaration

```
public void Rotate(Vector2 rotationIndicator, float rollIndicator)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html) | rotationIndicator |     |
| System.Single | rollIndicator |     |

#### RotateStopped()

##### Declaration

```
public void RotateStopped()
```

#### SetEmissiveStateWorking()

##### Declaration

```
public override bool SetEmissiveStateWorking()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Overrides

#### SetView()

##### Declaration

#### UpdateAfterSimulation()

##### Declaration

```
public override void UpdateAfterSimulation()
```

##### Overrides

Sandbox.Game.Entities.Cube.MyFunctionalBlock.UpdateAfterSimulation()

#### UpdateAfterSimulation10()

##### Declaration

```
public override void UpdateAfterSimulation10()
```

##### Overrides

Sandbox.Game.Entities.Cube.MyFunctionalBlock.UpdateAfterSimulation10()

#### UpdateDetailedInfo(StringBuilder)

##### Declaration

```
protected override void UpdateDetailedInfo(StringBuilder detailedInfo)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Text.StringBuilder | detailedInfo |     |

##### Overrides

Sandbox.Game.Entities.Cube.MyTerminalBlock.UpdateDetailedInfo(System.Text.StringBuilder)

### Explicit Interface Implementations

#### IMyCameraBlock.IsActiveLocal

##### Declaration

```
bool IMyCameraBlock.IsActiveLocal { get; }
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IMyCameraBlock.AvailableScanRange

##### Declaration

```
double IMyCameraBlock.AvailableScanRange { get; }
```

##### Returns

| Type | Description |
| --- | --- |
| System.Double |     |

#### IMyCameraBlock.CanScan(Double)

##### Declaration

```
bool IMyCameraBlock.CanScan(double distance)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Double | distance |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IMyCameraBlock.CanScan(Double, Vector3D)

##### Declaration

```
bool IMyCameraBlock.CanScan(double distance, Vector3D direction)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Double | distance |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | direction |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IMyCameraBlock.CanScan(Vector3D)

##### Declaration

```
bool IMyCameraBlock.CanScan(Vector3D target)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | target |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IMyCameraBlock.EnableRaycast

##### Declaration

```
bool IMyCameraBlock.EnableRaycast { get; set; }
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IMyCameraBlock.IsActive

##### Declaration

```
bool IMyCameraBlock.IsActive { get; }
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |
