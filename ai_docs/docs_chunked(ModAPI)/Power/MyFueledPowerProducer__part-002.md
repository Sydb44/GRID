
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

#### InitializeConveyorEndpoint()

##### Declaration

```
public void InitializeConveyorEndpoint()
```

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

#### OnCapacityChanged(SyncBase)

##### Declaration

```
protected virtual void OnCapacityChanged(SyncBase obj)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| VRage.Sync.SyncBase | obj |     |

#### OnCurrentOrMaxOutputChanged(MyDefinitionId, Single, MyResourceSourceComponent)

##### Declaration

```
protected virtual void OnCurrentOrMaxOutputChanged(MyDefinitionId changedResourceId, float oldOutput, MyResourceSourceComponent source)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | changedResourceId |     |
| System.Single | oldOutput |     |
| [MyResourceSourceComponent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyResourceSourceComponent.html) | source |     |

#### OnEnabledChanged()

##### Declaration

```
protected override void OnEnabledChanged()
```

##### Overrides

Sandbox.Game.Entities.Cube.MyFunctionalBlock.OnEnabledChanged()

#### OnProductionChanged()

##### Declaration

```
protected virtual void OnProductionChanged()
```

#### OnStartWorking()

##### Declaration

```
protected override void OnStartWorking()
```

##### Overrides

Sandbox.Game.Entities.Cube.MyFunctionalBlock.OnStartWorking()

#### OnStopWorking()

##### Declaration

```
protected override void OnStopWorking()
```

##### Overrides

Sandbox.Game.Entities.Cube.MyFunctionalBlock.OnStopWorking()

#### UpdateDetailedInfo(StringBuilder)

##### Declaration

```
protected override void UpdateDetailedInfo(StringBuilder sb)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Text.StringBuilder | sb  |     |

##### Overrides

Sandbox.Game.Entities.Cube.MyTerminalBlock.UpdateDetailedInfo(System.Text.StringBuilder)

#### UpdateDisplay()

##### Declaration

```
protected void UpdateDisplay()
```

### Events

#### CurrentOutputRatioChanged

##### Declaration

```
public event Action<IMyPowerProducer, float, float> CurrentOutputRatioChanged
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<[IMyPowerProducer](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyPowerProducer.html), System.Single, System.Single\> |     |

### Implements

### Extension Methods