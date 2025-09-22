#### IMyRemoteControl.Direction

##### Declaration

```
Base6Directions.Direction IMyRemoteControl.Direction { get; set; }
```

##### Returns

| Type | Description |
| --- | --- |
| [Base6Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.Direction.html) |     |

#### IMyRemoteControl.FlightMode

##### Declaration

```
FlightMode IMyRemoteControl.FlightMode { get; set; }
```

##### Returns

| Type | Description |
| --- | --- |
| [FlightMode](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.FlightMode.html) |     |

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

#### IMyRemoteControl.GetWaypointInfo(List<MyWaypointInfo>)

##### Declaration

```
void IMyRemoteControl.GetWaypointInfo(List<MyWaypointInfo> waypoints)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<[MyWaypointInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.MyWaypointInfo.html)\> | waypoints |     |

#### IMyRemoteControl.IsAutoPilotEnabled

##### Declaration

```
bool IMyRemoteControl.IsAutoPilotEnabled { get; }
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IMyRemoteControl.SpeedLimit

##### Declaration

```
float IMyRemoteControl.SpeedLimit { get; set; }
```

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### IMyRemoteControl.WaitForFreeWay

##### Declaration

```
bool IMyRemoteControl.WaitForFreeWay { get; set; }
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Implements

### Extension Methods