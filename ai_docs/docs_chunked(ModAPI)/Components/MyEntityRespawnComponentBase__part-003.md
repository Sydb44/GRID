
##### Declaration

```
void IMyCameraController.Rotate(Vector2 rotationIndicator, float rollIndicator)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html) | rotationIndicator |     |
| System.Single | rollIndicator |     |

#### IMyCameraController.RotateStopped()

##### Declaration

```
void IMyCameraController.RotateStopped()
```

#### IMyControllableEntity.CanSwitchLandingGears

##### Declaration

```
bool IMyControllableEntity.CanSwitchLandingGears { get; }
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IMyControllableEntity.ControllerInfo

##### Declaration

```
IMyControllerInfo IMyControllableEntity.ControllerInfo { get; }
```

##### Returns

| Type | Description |
| --- | --- |
| [IMyControllerInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyControllerInfo.html) |     |

#### IMyControllableEntity.Crouch()

##### Declaration

```
void IMyControllableEntity.Crouch()
```

#### IMyControllableEntity.Die()

##### Declaration

```
void IMyControllableEntity.Die()
```

#### IMyControllableEntity.Down()

##### Declaration

```
void IMyControllableEntity.Down()
```

#### IMyControllableEntity.DrawHud(IMyCameraController, Int64)

##### Declaration

```
void IMyControllableEntity.DrawHud(IMyCameraController camera, long playerId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyCameraController](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Interfaces.IMyCameraController.html) | camera |     |
| System.Int64 | playerId |     |

#### IMyControllableEntity.EnabledDamping

##### Declaration

```
bool IMyControllableEntity.EnabledDamping { get; }
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IMyControllableEntity.EnabledHelmet

##### Declaration

```
bool IMyControllableEntity.EnabledHelmet { get; }
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IMyControllableEntity.EnabledLeadingGears

##### Declaration

```
bool IMyControllableEntity.EnabledLeadingGears { get; }
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IMyControllableEntity.EnabledLights

##### Declaration

```
bool IMyControllableEntity.EnabledLights { get; }
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IMyControllableEntity.EnabledReactors

##### Declaration

```
bool IMyControllableEntity.EnabledReactors { get; }
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IMyControllableEntity.EnabledThrusts

##### Declaration

```
bool IMyControllableEntity.EnabledThrusts { get; }
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IMyControllableEntity.Entity

##### Declaration

```
IMyEntity IMyControllableEntity.Entity { get; }
```

##### Returns

| Type | Description |
| --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) |     |

#### IMyControllableEntity.ForceFirstPersonCamera

##### Declaration

```
bool IMyControllableEntity.ForceFirstPersonCamera { get; set; }
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IMyControllableEntity.GetHeadMatrix(Boolean, Boolean, Boolean, Boolean)

##### Declaration

```
MatrixD IMyControllableEntity.GetHeadMatrix(bool includeY, bool includeX, bool forceHeadAnim, bool forceHeadBone)
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

#### IMyControllableEntity.Jump(Vector3)

##### Declaration

```
void IMyControllableEntity.Jump(Vector3 moveIndicator)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | moveIndicator |     |

#### IMyControllableEntity.MoveAndRotate(Vector3, Vector2, Single)

##### Declaration

```
void IMyControllableEntity.MoveAndRotate(Vector3 moveIndicator, Vector2 rotationIndicator, float rollIndicator)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | moveIndicator |     |
| [Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html) | rotationIndicator |     |
| System.Single | rollIndicator |     |

#### IMyControllableEntity.MoveAndRotateStopped()

##### Declaration

```
void IMyControllableEntity.MoveAndRotateStopped()
```

#### IMyControllableEntity.PickUp()

##### Declaration

```
void IMyControllableEntity.PickUp()
```

#### IMyControllableEntity.PickUpContinues()

##### Declaration

```
void IMyControllableEntity.PickUpContinues()
```

#### IMyControllableEntity.PrimaryLookaround

##### Declaration

```
bool IMyControllableEntity.PrimaryLookaround { get; }
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IMyControllableEntity.RelativeDampeningDistance

##### Declaration

```
float IMyControllableEntity.RelativeDampeningDistance { get; set; }
```

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### IMyControllableEntity.RelativeDampeningTarget

##### Declaration

```
IMyEntity IMyControllableEntity.RelativeDampeningTarget { get; set; }
```

##### Returns

| Type | Description |
| --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) |     |

#### IMyControllableEntity.ShowInventory()
