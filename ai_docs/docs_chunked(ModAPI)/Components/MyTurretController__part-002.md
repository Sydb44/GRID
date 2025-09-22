
##### Declaration

```
public void RequestUseMessageImplementation(UseActionEnum useAction, long usedById)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [UseActionEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.UseObject.UseActionEnum.html) | useAction |     |
| System.Int64 | usedById |     |

#### SerializeControls(BitStream)

##### Declaration

```
public void SerializeControls(BitStream stream)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| VRage.Library.Collections.BitStream | stream |     |

#### UpdatePlayerControllers()

##### Declaration

```
public void UpdatePlayerControllers()
```

#### UseFailureCallback(UseActionEnum, Int64, UseActionResult)

##### Declaration

```
[Event(null, 423)]
[Reliable]
[Client]
public void UseFailureCallback(UseActionEnum useAction, long usedById, UseActionResult useResult)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [UseActionEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.UseObject.UseActionEnum.html) | useAction |     |
| System.Int64 | usedById |     |
| [UseActionResult](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.UseObject.UseActionResult.html) | useResult |     |

#### UseSuccessCallback(UseActionEnum, Int64, UseActionResult)

##### Declaration

```
[Event(null, 386)]
[Reliable]
[Broadcast]
public void UseSuccessCallback(UseActionEnum useAction, long usedById, UseActionResult useResult)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [UseActionEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.UseObject.UseActionEnum.html) | useAction |     |
| System.Int64 | usedById |     |
| [UseActionResult](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.UseObject.UseActionResult.html) | useResult |     |

### Events

#### OnCameraOverlayUpdate

##### Declaration

```
public event Action OnCameraOverlayUpdate
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action |     |

#### OnControlAcquired

##### Declaration

```
public event Action<IMyControllableEntity> OnControlAcquired
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<[IMyControllableEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.IMyControllableEntity.html)\> |     |

#### OnControlReleased

##### Declaration

```
public event Action<bool> OnControlReleased
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<System.Boolean\> |     |

#### OnMoveAndRotationUpdate

##### Declaration

```
public event Action<Vector3, Vector2, float, bool, bool> OnMoveAndRotationUpdate
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html), [Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html), System.Single, System.Boolean, System.Boolean\> |     |

#### OnRotationUpdate

##### Declaration

```
public event Action OnRotationUpdate
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action |     |