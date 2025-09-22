---
title: "Class MyRemoteControl"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyRemoteControl.html"
category: "Misc"
namespace: "Sandbox.Game.Entities"
class: "MyRemoteControl"
---

# Class MyRemoteControl | Space Engineers ModAPI

##### Inheritance

System.Object

Sandbox.Game.Entities.Cube.MySyncedBlock

Sandbox.Game.Entities.Cube.MyTerminalBlock

MyRemoteControl

##### Implements

##### Inherited Members

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyCubeBlockType]
[MyTerminalInterface]
public class MyRemoteControl : MyShipController, IMyComponentOwner<MyIDModule>, IMyUpgradableBlock, IMyUpgradableBlock, IMyEventProxy, IMyEventOwner, IMySyncedEntity, IMyControllableEntity, IMyRechargeSocketOwner, IMyShootOrigin, IMyPilotable, IMyShipControl, IMyWheelControllableEntity, IMyUsableEntity, IMyRemoteControl, IMyShipController, IMyTerminalBlock, IMyCubeBlock, IMyControllableEntity, IMyTargetingCapableBlock, IMyRemoteControl, IMyShipController, IMyTerminalBlock, IMyCubeBlock, IMyParallelUpdateable, IMyEntity, IMyEntity, IMyComponentOwner<MyAutopilotComponent>, IMyAutopilotable
```

### Constructors

#### MyRemoteControl()

##### Declaration

### Fields

#### AutomaticallyProlongJourney

##### Declaration

```
public bool AutomaticallyProlongJourney
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Properties

#### AutomaticBehaviour

##### Declaration

```
public IRemoteControlAutomaticBehaviour AutomaticBehaviour { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [IRemoteControlAutomaticBehaviour](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.IRemoteControlAutomaticBehaviour.html) |     |

#### CanHavePreviousCameraEntity

##### Declaration

```
public override bool CanHavePreviousCameraEntity { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Overrides

#### CanHavePreviousControlledEntity

##### Declaration

```
public override bool CanHavePreviousControlledEntity { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Overrides

#### CurrentWaypoint

##### Declaration

```
public MyAutopilotWaypoint CurrentWaypoint { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyAutopilotWaypoint](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyAutopilotWaypoint.html) |     |

#### GetPreviousCameraEntity

##### Declaration

```
public override IMyEntity GetPreviousCameraEntity { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) |     |

##### Overrides

#### IsMainRemoteControl

##### Declaration

```
public bool IsMainRemoteControl { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Pilot

##### Declaration

```
public override MyCharacter Pilot { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| Sandbox.Game.Entities.Character.MyCharacter |     |

##### Overrides

#### PreviousControlledEntity

##### Declaration

```
public override IMyControllableEntity PreviousControlledEntity { get; protected set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [IMyControllableEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.IMyControllableEntity.html) |     |

##### Overrides

#### Priority

##### Declaration

```
public override ControllerPriority Priority { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [ControllerPriority](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.ControllerPriority.html) |     |

##### Overrides

#### UpdateFlags

##### Declaration

```
public MyParallelUpdateFlags UpdateFlags { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyParallelUpdateFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyParallelUpdateFlags.html) |     |

### Methods

#### AddWaypoint(MyWaypointInfo)

##### Declaration

```
public void AddWaypoint(MyWaypointInfo coords)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyWaypointInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.MyWaypointInfo.html) | coords |     |

#### AddWaypoint(Vector3D, String)

##### Declaration

```
public void AddWaypoint(Vector3D coords, string name)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | coords |     |
| System.String | name |     |

#### AdvanceWaypoint()

##### Declaration

```
public void AdvanceWaypoint()
```

#### AssignControl(IMyControllableEntity)

##### Declaration

```
protected void AssignControl(IMyControllableEntity user)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyControllableEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.IMyControllableEntity.html) | user |     |

#### CanControl(IMyControllableEntity)

##### Declaration

```
public bool CanControl(IMyControllableEntity controllingEntity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyControllableEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.IMyControllableEntity.html) | controllingEntity |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### CanUse(UseActionEnum, IMyControllableEntity)

##### Declaration

```
public UseActionResult CanUse(UseActionEnum actionEnum, IMyControllableEntity user)
```
