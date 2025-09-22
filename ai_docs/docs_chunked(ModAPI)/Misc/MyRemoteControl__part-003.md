```

##### Overrides

Sandbox.Game.Entities.Cube.MyTerminalBlock.OnOwnershipChanged()

#### OnRegisteredToGridSystems()

##### Declaration

```
public override void OnRegisteredToGridSystems()
```

##### Overrides

#### OnUnregisteredFromGridSystems()

##### Declaration

```
public override void OnUnregisteredFromGridSystems()
```

##### Overrides

#### RequestControl()

##### Declaration

```
public void RequestControl()
```

#### RequestUse(UseActionEnum, IMyControllableEntity)

##### Declaration

```
public void RequestUse(UseActionEnum actionEnum, IMyControllableEntity usedBy)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [UseActionEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.UseObject.UseActionEnum.html) | actionEnum |     |
| [IMyControllableEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.IMyControllableEntity.html) | usedBy |     |

#### SetAutomaticBehaviour(IRemoteControlAutomaticBehaviour)

##### Declaration

```
public void SetAutomaticBehaviour(IRemoteControlAutomaticBehaviour automaticBehaviour)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IRemoteControlAutomaticBehaviour](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.IRemoteControlAutomaticBehaviour.html) | automaticBehaviour |     |

#### SetAutoPilotEnabled(Boolean)

##### Declaration

```
public void SetAutoPilotEnabled(bool enabled)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | enabled |     |

#### SetAutoPilotSpeedLimit(Single)

##### Declaration

```
public void SetAutoPilotSpeedLimit(float speedLimit)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | speedLimit |     |

#### SetCollisionAvoidance(Boolean)

##### Declaration

```
public void SetCollisionAvoidance(bool enabled)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | enabled |     |

#### SetDockingMode(Boolean)

##### Declaration

```
public void SetDockingMode(bool enabled)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | enabled |     |

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

#### SetWaitForFreeWay(Boolean)

##### Declaration

```
public void SetWaitForFreeWay(bool waitForFreeWay)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | waitForFreeWay |     |

#### SetWaypointThresholdDistance(Single)

##### Declaration

```
public void SetWaypointThresholdDistance(float thresholdDistance)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | thresholdDistance |     |

#### ShowInventory()

##### Declaration

```
public override void ShowInventory()
```

##### Overrides

#### ShowTerminal()

##### Declaration

```
public override void ShowTerminal()
```

##### Overrides

#### UpdateAfterSimulation10()

##### Declaration

```
public override void UpdateAfterSimulation10()
```

##### Overrides

#### UpdateAfterSimulationParallel()

##### Declaration

```
public void UpdateAfterSimulationParallel()
```

#### UpdateBeforeSimulation()

##### Declaration

```
public override void UpdateBeforeSimulation()
```

##### Overrides

#### UpdateBeforeSimulationParallel()

##### Declaration

```
public void UpdateBeforeSimulationParallel()
```

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

#### UpdateOnceBeforeFrame()

##### Declaration

```
public override void UpdateOnceBeforeFrame()
```

##### Overrides

#### WasControllingCockpitWhenSaved()

##### Declaration

```
public bool WasControllingCockpitWhenSaved()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Explicit Interface Implementations

#### IMyRemoteControl.GetFreeDestination(Vector3D, Single, Single)

##### Declaration

```
Vector3D IMyRemoteControl.GetFreeDestination(Vector3D originalDestination, float checkRadius, float shipRadius)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | originalDestination |     |
| System.Single | checkRadius |     |
| System.Single | shipRadius |     |

##### Returns

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

#### IMyRemoteControl.GetNearestPlayer(out Vector3D)

##### Declaration

```
bool IMyRemoteControl.GetNearestPlayer(out Vector3D playerPosition)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | playerPosition |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IMyRemoteControl.CurrentWaypoint

##### Declaration

```
MyWaypointInfo IMyRemoteControl.CurrentWaypoint { get; }
```

##### Returns

| Type | Description |
| --- | --- |
| [MyWaypointInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.MyWaypointInfo.html) |     |

#### IMyRemoteControl.Direction

##### Declaration

```
Base6Directions.Direction IMyRemoteControl.Direction { get; set; }
```

##### Returns

| Type | Description |
| --- | --- |
| [Base6Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.Direction.html) |     |
