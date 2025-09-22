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

Sandbox.Game.Entities.Cube.MyFunctionalBlock.UpdateOnceBeforeFrame()

### Explicit Interface Implementations

#### IMyJumpDrive.CurrentStoredPower

##### Declaration

```
float IMyJumpDrive.CurrentStoredPower { get; set; }
```

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### IMyJumpDrive.Jump(Boolean)

##### Declaration

```
void IMyJumpDrive.Jump(bool usePilot)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | usePilot |     |

#### IMyStoredPowerRatio.StoredPowerRatioChanged

##### Declaration

```
event Action<IMyStoredPowerRatio, float, float> IMyStoredPowerRatio.StoredPowerRatioChanged
```

##### Returns

| Type | Description |
| --- | --- |
| System.Action<[IMyStoredPowerRatio](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyStoredPowerRatio.html), System.Single, System.Single\> |     |

#### IMyJumpDrive.CurrentStoredPower

##### Declaration

```
float IMyJumpDrive.CurrentStoredPower { get; }
```

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### IMyJumpDrive.JumpDistanceMeters

##### Declaration

```
float IMyJumpDrive.JumpDistanceMeters { get; set; }
```

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### IMyJumpDrive.JumpDistanceRatio

##### Declaration

```
float IMyJumpDrive.JumpDistanceRatio { get; set; }
```

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### IMyJumpDrive.MaxJumpDistanceMeters

##### Declaration

```
float IMyJumpDrive.MaxJumpDistanceMeters { get; }
```

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### IMyJumpDrive.MaxStoredPower

##### Declaration

```
float IMyJumpDrive.MaxStoredPower { get; }
```

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### IMyJumpDrive.MinJumpDistanceMeters

##### Declaration

```
float IMyJumpDrive.MinJumpDistanceMeters { get; }
```

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### IMyJumpDrive.Recharge

##### Declaration

```
bool IMyJumpDrive.Recharge { get; set; }
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IMyJumpDrive.Status

##### Declaration

```
MyJumpDriveStatus IMyJumpDrive.Status { get; }
```

##### Returns

| Type | Description |
| --- | --- |
| [MyJumpDriveStatus](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.MyJumpDriveStatus.html) |     |

### Implements

### Extension Methods