```
public override void OnRemovedFromScene(object source)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | source |     |

##### Overrides

Sandbox.Game.Entities.Cube.MyFunctionalBlock.OnRemovedFromScene(System.Object)

#### [](#Sandbox_Game_Entities_MyDoor_UpdateAfterSimulation)UpdateAfterSimulation()

##### Declaration

```
public override void UpdateAfterSimulation()
```

##### Overrides

Sandbox.Game.Entities.Cube.MyFunctionalBlock.UpdateAfterSimulation()

#### [](#Sandbox_Game_Entities_MyDoor_UpdateBeforeSimulation)UpdateBeforeSimulation()

##### Declaration

```
public override void UpdateBeforeSimulation()
```

##### Overrides

Sandbox.Game.Entities.Cube.MyFunctionalBlock.UpdateBeforeSimulation()

#### [](#Sandbox_Game_Entities_MyDoor_UpdateOnceBeforeFrame)UpdateOnceBeforeFrame()

##### Declaration

```
public override void UpdateOnceBeforeFrame()
```

##### Overrides

Sandbox.Game.Entities.Cube.MyFunctionalBlock.UpdateOnceBeforeFrame()

#### [](#Sandbox_Game_Entities_MyDoor_WorldPositionChanged_System_Object_)WorldPositionChanged(Object)

##### Declaration

```
protected override void WorldPositionChanged(object source)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | source |     |

##### Overrides

### [](#events)Events

#### [](#Sandbox_Game_Entities_MyDoor_DoorStateChanged)DoorStateChanged

##### Declaration

```
public event Action<bool> DoorStateChanged
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<System.Boolean\> |     |

#### [](#Sandbox_Game_Entities_MyDoor_OnDoorClosed)OnDoorClosed

##### Declaration

```
public event Action<IMyDoor> OnDoorClosed
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<[IMyDoor](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyDoor.html)\> |     |

#### [](#Sandbox_Game_Entities_MyDoor_OnDoorOpened)OnDoorOpened

##### Declaration

```
public event Action<IMyDoor> OnDoorOpened
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<[IMyDoor](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyDoor.html)\> |     |

#### [](#Sandbox_Game_Entities_MyDoor_OnDoorStateChanged)OnDoorStateChanged

##### Declaration

```
public event Action<IMyDoor, bool> OnDoorStateChanged
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<[IMyDoor](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyDoor.html), System.Boolean\> |     |

### [](#eii)Explicit Interface Implementations

#### [](#Sandbox_Game_Entities_MyDoor_Sandbox_ModAPI_IMyDoor_IsFullyClosed)IMyDoor.IsFullyClosed

##### Declaration

```
bool IMyDoor.IsFullyClosed { get; }
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#Sandbox_Game_Entities_MyDoor_Sandbox_ModAPI_Ingame_IMyDoor_CloseDoor)IMyDoor.CloseDoor()

##### Declaration

#### [](#Sandbox_Game_Entities_MyDoor_Sandbox_ModAPI_Ingame_IMyDoor_OpenDoor)IMyDoor.OpenDoor()

##### Declaration

#### [](#Sandbox_Game_Entities_MyDoor_Sandbox_ModAPI_Ingame_IMyDoor_Status)IMyDoor.Status

##### Declaration

```
DoorStatus IMyDoor.Status { get; }
```

##### Returns

#### [](#Sandbox_Game_Entities_MyDoor_Sandbox_ModAPI_Ingame_IMyDoor_ToggleDoor)IMyDoor.ToggleDoor()

##### Declaration

```
void IMyDoor.ToggleDoor()
```

### [](#implements)Implements

### [](#extensionmethods)Extension Methods