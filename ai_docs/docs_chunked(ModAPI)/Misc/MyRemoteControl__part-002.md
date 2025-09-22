##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### CanUse(UseActionEnum, IMyControllableEntity)

##### Declaration

```
public UseActionResult CanUse(UseActionEnum actionEnum, IMyControllableEntity user)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [UseActionEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.UseObject.UseActionEnum.html) | actionEnum |     |
| [IMyControllableEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.IMyControllableEntity.html) | user |     |

##### Returns

| Type | Description |
| --- | --- |
| [UseActionResult](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.UseObject.UseActionResult.html) |     |

#### ChangeDirection(Base6Directions.Direction)

##### Declaration

```
public void ChangeDirection(Base6Directions.Direction direction)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Base6Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.Direction.html) | direction |     |

#### ChangeFlightMode(FlightMode)

##### Declaration

```
public void ChangeFlightMode(FlightMode flightMode)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [FlightMode](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.FlightMode.html) | flightMode |     |

#### CheckIsWorking()

##### Declaration

```
protected override bool CheckIsWorking()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Overrides

#### ClearWaypoints()

##### Declaration

```
public void ClearWaypoints()
```

#### ComponentStack\_IsFunctionalChanged()

##### Declaration

```
protected override void ComponentStack_IsFunctionalChanged()
```

##### Overrides

#### CreateTerminalControls()

##### Declaration

```
protected override void CreateTerminalControls()
```

##### Overrides

#### DisableUpdates()

##### Declaration

```
public override void DisableUpdates()
```

##### Overrides

#### ForceReleaseControl()

##### Declaration

```
public override void ForceReleaseControl()
```

##### Overrides

#### GetComponent(out MyAutopilotComponent)

##### Declaration

```
public bool GetComponent(out MyAutopilotComponent component)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyAutopilotComponent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyAutopilotComponent.html) | component |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### GetHeadMatrix(Boolean, Boolean, Boolean, Boolean)

##### Declaration

```
public override MatrixD GetHeadMatrix(bool includeY, bool includeX = true, bool forceHeadAnim = false, bool forceHeadBone = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | includeY |     |
| System.Boolean | includeX |     |
| System.Boolean | forceHeadAnim |     |
| System.Boolean | forceHeadBone |     |

##### Returns

| Type | Description |
| --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) |     |

##### Overrides

#### GetNearestPlayer()

##### Declaration

```
public MyPlayer GetNearestPlayer()
```

##### Returns

| Type | Description |
| --- | --- |
| Sandbox.Game.World.MyPlayer |     |

#### GetNearestPlayer(out MatrixD, Vector3)

##### Declaration

```
public bool GetNearestPlayer(out MatrixD playerWorldTransform, Vector3 offset)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) | playerWorldTransform |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | offset |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### GetObjectBuilderCubeBlock(Boolean)

##### Declaration

```
public override MyObjectBuilder_CubeBlock GetObjectBuilderCubeBlock(bool copy = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | copy |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_CubeBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_CubeBlock.html) |     |

##### Overrides

#### Init(MyObjectBuilder\_CubeBlock, MyCubeGrid)

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

#### IsAutopilotEnabled()

##### Declaration

```
public bool IsAutopilotEnabled()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsMainRemoteControlFree()

##### Declaration

```
protected bool IsMainRemoteControlFree()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

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

#### OnControlledEntity\_Used()

##### Declaration

```
protected override void OnControlledEntity_Used()
```

##### Overrides

#### OnOwnershipChanged()

##### Declaration

```
protected override void OnOwnershipChanged()
```

##### Overrides

Sandbox.Game.Entities.Cube.MyTerminalBlock.OnOwnershipChanged()

#### OnRegisteredToGridSystems()

##### Declaration

```
public override void OnRegisteredToGridSystems()
```
