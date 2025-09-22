#### GetPullInformation()

##### Declaration

```
public PullInformation GetPullInformation()
```

##### Returns

| Type | Description |
| --- | --- |
| Sandbox.Game.GameSystems.Conveyors.PullInformation |     |

#### GetPushInformation()

##### Declaration

```
public PullInformation GetPushInformation()
```

##### Returns

| Type | Description |
| --- | --- |
| Sandbox.Game.GameSystems.Conveyors.PullInformation |     |

#### GetTerminalName(StringBuilder)

##### Declaration

```
public override void GetTerminalName(StringBuilder result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Text.StringBuilder | result |     |

##### Overrides

Sandbox.Game.Entities.Cube.MyTerminalBlock.GetTerminalName(System.Text.StringBuilder)

#### GetTimerEnabledState()

##### Declaration

```
public override bool GetTimerEnabledState()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Overrides

Sandbox.Game.Entities.Cube.MyFunctionalBlock.GetTimerEnabledState()

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

Sandbox.Game.Entities.Cube.MyFunctionalBlock.Init(VRage.Game.MyObjectBuilder\_CubeBlock, Sandbox.Game.Entities.MyCubeGrid)

#### InitComponents()

##### Declaration

```
public override void InitComponents()
```

##### Overrides

#### InitializeConveyorEndpoint()

##### Declaration

```
public void InitializeConveyorEndpoint()
```

#### InstantiateSubpart(MyModelDummy, ref MyEntitySubpart.Data)

##### Declaration

```
protected override MyEntitySubpart InstantiateSubpart(MyModelDummy subpartDummy, ref MyEntitySubpart.Data data)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| VRageRender.Import.MyModelDummy | subpartDummy |     |
| [MyEntitySubpart.Data](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntitySubpart.Data.html) | data |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyEntitySubpart](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntitySubpart.html) |     |

##### Overrides

#### OnCubeGridChanged(MyCubeGrid)

##### Declaration

```
public override void OnCubeGridChanged(MyCubeGrid oldGrid)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html) | oldGrid |     |

##### Overrides

#### OnEnabledChanged()

##### Declaration

```
protected override void OnEnabledChanged()
```

##### Overrides

Sandbox.Game.Entities.Cube.MyFunctionalBlock.OnEnabledChanged()

#### OnModelChange()

##### Declaration

```
public override void OnModelChange()
```

##### Overrides

Sandbox.Game.Entities.Cube.MyFunctionalBlock.OnModelChange()

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

#### RandomizeFlameProperties(Single, Single, ref Single, ref Single)

##### Declaration

```
public static void RandomizeFlameProperties(float strength, float flameScale, ref float thrustRadiusRand, ref float thrustLengthRand)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | strength |     |
| System.Single | flameScale |     |
| System.Single | thrustRadiusRand |     |
| System.Single | thrustLengthRand |     |

#### Sink\_IsPoweredChanged()

##### Declaration

```
public void Sink_IsPoweredChanged()
```

#### TiersChanged()

##### Declaration

```
protected override void TiersChanged()
```

##### Overrides

Sandbox.Game.Entities.Cube.MyFunctionalBlock.TiersChanged()

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

#### UpdateAfterSimulation100()

##### Declaration

```
public override void UpdateAfterSimulation100()
```

##### Overrides

Sandbox.Game.Entities.Cube.MyFunctionalBlock.UpdateAfterSimulation100()

#### UpdateBeforeSimulation100()

##### Declaration

```
public override void UpdateBeforeSimulation100()
```

##### Overrides

Sandbox.Game.Entities.Cube.MyFunctionalBlock.UpdateBeforeSimulation100()

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

### Events

#### ThrustChanged

##### Declaration

```
public event Action<IMyThrust, float, float> ThrustChanged
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<[IMyThrust](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyThrust.html), System.Single, System.Single\> |     |

#### ThrustOverrideChanged

##### Declaration

```
public event Action<MyThrust, float> ThrustOverrideChanged
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<[MyThrust](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyThrust.html), System.Single\> |     |
