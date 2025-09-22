#### Waypoints

##### Declaration

```
public List<MyAutopilotWaypoint> Waypoints { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MyAutopilotWaypoint](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyAutopilotWaypoint.html)\> |     |

#### WaypointThresholdDistance

##### Declaration

```
public float WaypointThresholdDistance { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### WorkAreaStartForward

##### Declaration

```
public Vector3D WorkAreaStartForward { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

### Methods

#### AddedToScene()

##### Declaration

```
public void AddedToScene()
```

#### AddSelectedWaypoints()

##### Declaration

```
public void AddSelectedWaypoints()
```

#### AddWaypoint(MyWaypointInfo)

##### Declaration

```
public void AddWaypoint(MyWaypointInfo coords)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyWaypointInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.MyWaypointInfo.html) | coords |     |

#### AddWaypoint(Vector3D, String, Boolean)

##### Declaration

```
public void AddWaypoint(Vector3D point, string name, bool setAsCurrent)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | point |     |
| System.String | name |     |
| System.Boolean | setAsCurrent |     |

#### AddWaypointBroadcast(MatrixD, Int64, String)

##### Declaration

```
[Event(null, 3546)]
[Reliable]
[Server]
[Broadcast]
public void AddWaypointBroadcast(MatrixD Matrix, long RelatedEntityId, string Name)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) | Matrix |     |
| System.Int64 | RelatedEntityId |     |
| System.String | Name |     |

#### AdvanceWaypoint(Boolean, Boolean)

##### Declaration

```
public void AdvanceWaypoint(bool reportRemoval = true, bool playAction = true)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | reportRemoval |     |
| System.Boolean | playAction |     |

#### AlignToMinHeight(MyAutopilotWaypoint)

##### Declaration

```
public bool AlignToMinHeight(MyAutopilotWaypoint waypoint)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyAutopilotWaypoint](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyAutopilotWaypoint.html) | waypoint |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### CanAddWaypoints()

##### Declaration

```
public bool CanAddWaypoints()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### CanEnableAutoPilot()

##### Declaration

```
public bool CanEnableAutoPilot()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### CanMoveWaypointsDown()

##### Declaration

```
public bool CanMoveWaypointsDown()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### CanMoveWaypointsUp()

##### Declaration

```
public bool CanMoveWaypointsUp()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### CanRemoveWaypoints()

##### Declaration

```
public bool CanRemoveWaypoints()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ChangeDirection(Base6Directions.Direction)

##### Declaration

```
public void ChangeDirection(Base6Directions.Direction direction)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Base6Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.Direction.html) | direction |     |

#### ChangeFlightMode(FlightMode, Boolean)

##### Declaration

```
public void ChangeFlightMode(FlightMode flightMode, bool forceEnable = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [FlightMode](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.FlightMode.html) | flightMode |     |
| System.Boolean | forceEnable |     |

#### ClearWaypoints(Boolean)

##### Declaration

```
public void ClearWaypoints(bool advanceWaypoint = true)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | advanceWaypoint |     |

#### CopyAutopilotSetup()

##### Declaration

```
public void CopyAutopilotSetup()
```

#### Deserialize(MyObjectBuilder\_ComponentBase)

##### Declaration

```
public override void Deserialize(MyObjectBuilder_ComponentBase builder)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_ComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.ComponentSystem.MyObjectBuilder_ComponentBase.html) | builder |     |

##### Overrides

#### FillDirectionCombo(List<MyTerminalControlComboBoxItem>)

##### Declaration

```
public static void FillDirectionCombo(List<MyTerminalControlComboBoxItem> list)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<[MyTerminalControlComboBoxItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.MyTerminalControlComboBoxItem.html)\> | list |     |

#### FillFlightModeCombo(List<MyTerminalControlComboBoxItem>)

##### Declaration

```
public static void FillFlightModeCombo(List<MyTerminalControlComboBoxItem> list)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<[MyTerminalControlComboBoxItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.MyTerminalControlComboBoxItem.html)\> | list |     |
