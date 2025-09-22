
##### Declaration

```
public override void Init(MyObjectBuilder_CubeBlock builder, MyCubeGrid cubeGrid)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_CubeBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_CubeBlock.html) | builder |     |
| [MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html) | cubeGrid |     |

##### Overrides

#### IsEnoughPower()

##### Declaration

```
protected bool IsEnoughPower()
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

Sandbox.Game.Entities.Cube.MyFunctionalBlock.OnAddedToScene(System.Object)

#### OnBuildSuccess(Int64, Boolean)

##### Declaration

```
public override void OnBuildSuccess(long builtBy, bool instantBuild)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | builtBy |     |
| System.Boolean | instantBuild |     |

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

#### OnOpenChanged(SyncBase)

##### Declaration

```
protected override void OnOpenChanged(SyncBase obj)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| VRage.Sync.SyncBase | obj |     |

##### Overrides

#### OnRemovedFromScene(Object)

##### Declaration

```
public override void OnRemovedFromScene(object source)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | source |     |

##### Overrides

Sandbox.Game.Entities.Cube.MyFunctionalBlock.OnRemovedFromScene(System.Object)

#### SetEmissive(Color, Single, Boolean)

##### Declaration

```
protected void SetEmissive(Color color, float emissivity = 1F, bool force = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html) | color |     |
| System.Single | emissivity |     |
| System.Boolean | force |     |

#### UpdateAfterSimulation()

##### Declaration

```
public override void UpdateAfterSimulation()
```

##### Overrides

Sandbox.Game.Entities.Cube.MyFunctionalBlock.UpdateAfterSimulation()

#### UpdateBeforeSimulation()

##### Declaration

```
public override void UpdateBeforeSimulation()
```

##### Overrides

Sandbox.Game.Entities.Cube.MyFunctionalBlock.UpdateBeforeSimulation()

#### UpdateDoorPosition()

##### Declaration

```
protected abstract void UpdateDoorPosition()
```

#### UpdateEmissivity(Boolean)

##### Declaration

```
protected virtual void UpdateEmissivity(bool force = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | force |     |

#### UpdateOnceBeforeFrame()

##### Declaration

```
public override void UpdateOnceBeforeFrame()
```

##### Overrides

Sandbox.Game.Entities.Cube.MyFunctionalBlock.UpdateOnceBeforeFrame()

#### UpdatePowerInput()

##### Declaration

```
protected float UpdatePowerInput()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### UpdateVisual()

##### Declaration

```
public override void UpdateVisual()
```

##### Overrides

#### WorldPositionChanged(Object)

##### Declaration

```
protected override void WorldPositionChanged(object source)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | source |     |

##### Overrides

### Events

#### DoorStateChanged

##### Declaration

```
public event Action<bool> DoorStateChanged
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<System.Boolean\> |     |

#### OnDoorClosed

##### Declaration

```
public event Action<IMyDoor> OnDoorClosed
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<[IMyDoor](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyDoor.html)\> |     |

#### OnDoorOpened

##### Declaration

```
public event Action<IMyDoor> OnDoorOpened
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<[IMyDoor](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyDoor.html)\> |     |

#### OnDoorStateChanged

##### Declaration

```
public event Action<IMyDoor, bool> OnDoorStateChanged
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<[IMyDoor](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyDoor.html), System.Boolean\> |     |

### Explicit Interface Implementations

#### IMyDoor.IsFullyClosed

##### Declaration

```
bool IMyDoor.IsFullyClosed { get; }
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IMyDoor.CloseDoor()

##### Declaration

#### IMyDoor.OpenDoor()

##### Declaration

#### IMyDoor.Status

##### Declaration

```
DoorStatus IMyDoor.Status { get; }
```

##### Returns

| Type | Description |
| --- | --- |
| [DoorStatus](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.DoorStatus.html) |     |

#### IMyDoor.ToggleDoor()

##### Declaration

```
void IMyDoor.ToggleDoor()
```

### Implements

### Extension Methods