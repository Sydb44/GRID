| System.Single |     |

#### UpdateSoundEmitters()

##### Declaration

```
public override void UpdateSoundEmitters()
```

##### Overrides

Sandbox.Game.Entities.Cube.MyFunctionalBlock.UpdateSoundEmitters()

#### UpdateVisual()

##### Declaration

```
public override void UpdateVisual()
```

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