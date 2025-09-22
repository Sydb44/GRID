---
title: "Class MyTurretController"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyTurretController.html"
category: "Components"
namespace: "Sandbox.Game.EntityComponents"
class: "MyTurretController"
---

# Class MyTurretController | Space Engineers ModAPI

##### Inheritance

System.Object

MyTurretController

###### **Namespace**: [Sandbox.Game.EntityComponents](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public class MyTurretController : Object, IMyUsableEntity, IMyEventProxy, IMyEventOwner
```

### Constructors

#### MyTurretController(MyCubeBlock)

##### Declaration

```
public MyTurretController(MyCubeBlock cubeBlock)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyCubeBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeBlock.html) | cubeBlock |     |

### Fields

#### m\_isControlled

##### Declaration

```
protected bool m_isControlled
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Properties

#### CockpitPilot

##### Declaration

```
public MyCharacter CockpitPilot { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| Sandbox.Game.Entities.Character.MyCharacter |     |

#### ControllerInfo

##### Declaration

```
public MyControllerInfo ControllerInfo { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| Sandbox.Game.World.MyControllerInfo |     |

#### IsControlled

##### Declaration

```
public bool IsControlled { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsControlledByLocalPlayer

##### Declaration

```
public bool IsControlledByLocalPlayer { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsPlayerControlled

##### Declaration

```
public bool IsPlayerControlled { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### LastNetCanControl

##### Declaration

```
public bool LastNetCanControl { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### LastNetMoveState

Used to serialize user input.

##### Declaration

```
public MyGridClientState LastNetMoveState { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| Sandbox.Game.Replication.ClientStates.MyGridClientState |     |

#### LastNetRotateShip

##### Declaration

```
public bool LastNetRotateShip { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Pilot

##### Declaration

```
public MyCharacter Pilot { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| Sandbox.Game.Entities.Character.MyCharacter |     |

#### PreviousControlledEntity

##### Declaration

```
public IMyControllableEntity PreviousControlledEntity { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [IMyControllableEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.IMyControllableEntity.html) |     |

#### SavedPreviousControlledEntityId

##### Declaration

```
public Nullable<long> SavedPreviousControlledEntityId { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Nullable<System.Int64\> |     |

### Methods

#### CanControl()

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### CanUse(UseActionEnum, IMyControllableEntity)

##### Declaration

```
public UseActionResult CanUse(UseActionEnum actionEnum, IMyControllableEntity user)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [UseActionEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.UseObject.UseActionEnum.html) | actionEnum |     |
| [IMyControllableEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.IMyControllableEntity.html) | user |     |

##### Returns

| Type | Description |
| --- | --- |
| [UseActionResult](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.UseObject.UseActionResult.html) |     |

#### DeserializeControls(BitStream, Boolean)

##### Declaration

```
public void DeserializeControls(BitStream stream, bool outOfOrder)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| VRage.Library.Collections.BitStream | stream |     |
| System.Boolean | outOfOrder |     |

#### GetFirstRadioReceiver()

##### Declaration

```
public MyDataReceiver GetFirstRadioReceiver()
```

##### Returns

| Type | Description |
| --- | --- |
| [MyDataReceiver](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyDataReceiver.html) |     |

#### GetUser()

##### Declaration

```
public MyCharacter GetUser()
```

##### Returns

| Type | Description |
| --- | --- |
| Sandbox.Game.Entities.Character.MyCharacter |     |

#### IsInRangeAndPlayerHasAccess()

##### Declaration

```
public bool IsInRangeAndPlayerHasAccess()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### RemoveUsers(Boolean)

##### Declaration

```
public void RemoveUsers(bool local)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | local |     |

#### RequestControl()

##### Declaration

```
public void RequestControl()
```

#### RequestUseMessageImplementation(UseActionEnum, Int64)

##### Declaration

```
public void RequestUseMessageImplementation(UseActionEnum useAction, long usedById)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [UseActionEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.UseObject.UseActionEnum.html) | useAction |     |
| System.Int64 | usedById |     |
