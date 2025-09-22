#### IsSerialized()

##### Declaration

```
public override bool IsSerialized()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Overrides

#### OnAddedToContainer()

##### Declaration

```
public override void OnAddedToContainer()
```

##### Overrides

#### OnBeforeRemovedFromContainer()

##### Declaration

```
public override void OnBeforeRemovedFromContainer()
```

##### Overrides

#### OnRemovedFromScene()

##### Declaration

```
public override void OnRemovedFromScene()
```

##### Overrides

#### Play()

##### Declaration

#### Record()

##### Declaration

#### RefreshErrors(Boolean)

##### Declaration

```
public void RefreshErrors(bool setParentDetailInfoDirty = true)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | setParentDetailInfoDirty |     |

#### RemoveBeacon()

##### Declaration

```
public void RemoveBeacon()
```

#### RemoveWaypoint(IMyAutopilotWaypoint)

##### Declaration

```
public void RemoveWaypoint(IMyAutopilotWaypoint waypoint)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyAutopilotWaypoint](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyAutopilotWaypoint.html) | waypoint |     |

#### ReverseOrder()

##### Declaration

```
public void ReverseOrder()
```

#### Serialize(Boolean)

##### Declaration

```
public override MyObjectBuilder_ComponentBase Serialize(bool copy = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | copy |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_ComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.ComponentSystem.MyObjectBuilder_ComponentBase.html) |     |

##### Overrides

#### StopPlay()

##### Declaration

#### StopRecord()

##### Declaration

#### UpdateAfterSimulation100()

##### Declaration

```
public void UpdateAfterSimulation100()
```

### Events

#### IsPlayingChanged

##### Declaration

```
public event Action<IMyPathRecorderComponent> IsPlayingChanged
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<[IMyPathRecorderComponent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyPathRecorderComponent.html)\> |     |

#### IsRecordingChanged

##### Declaration

```
public event Action<IMyPathRecorderComponent> IsRecordingChanged
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<[IMyPathRecorderComponent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyPathRecorderComponent.html)\> |     |

### Explicit Interface Implementations

#### IMyPathRecorderComponent.DeleteAllWaypoints()

##### Declaration

```
void IMyPathRecorderComponent.DeleteAllWaypoints()
```

#### IMyPathRecorderComponent.BeaconEntityId

##### Declaration

```
Nullable<long> IMyPathRecorderComponent.BeaconEntityId { get; }
```

##### Returns

| Type | Description |
| --- | --- |
| System.Nullable<System.Int64\> |     |

### Implements

### Extension Methods