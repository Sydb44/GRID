---
title: "Class MyShipController"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyShipController.html"
category: "Misc"
namespace: "Sandbox.Game.Entities"
class: "MyShipController"
---

# Class MyShipController | Space Engineers ModAPI

##### Inheritance

System.Object

Sandbox.Game.Entities.Cube.MySyncedBlock

Sandbox.Game.Entities.Cube.MyTerminalBlock

MyShipController

##### Implements

##### Inherited Members

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyTerminalInterface]
public class MyShipController : MyTerminalBlock, IMyComponentOwner<MyIDModule>, IMyUpgradableBlock, IMyUpgradableBlock, IMyEventProxy, IMyEventOwner, IMySyncedEntity, IMyControllableEntity, IMyRechargeSocketOwner, IMyShipController, IMyControllableEntity, IMyTerminalBlock, IMyCubeBlock, IMyShipController, IMyTerminalBlock, IMyCubeBlock, IMyTargetingCapableBlock, IMyShootOrigin, IMyPilotable, IMyShipControl, IMyWheelControllableEntity, IMyEntity, IMyEntity
```

### Constructors

#### MyShipController()

##### Declaration

```
public MyShipController()
```

### Fields

#### BuildingMode

##### Declaration

##### Field Value

Type

Description

System.Boolean

#### GridSelectionSystem

##### Declaration

```
public MyGridSelectionSystem GridSelectionSystem
```

##### Field Value

Type

Description

Sandbox.Game.GameSystems.MyGridSelectionSystem

#### hasPower

##### Declaration

```
public readonly bool hasPower
```

##### Field Value

Type

Description

System.Boolean

#### m\_baseIdleSound

##### Declaration

```
protected MySoundPair m_baseIdleSound
```

##### Field Value

Type

Description

[MySoundPair](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MySoundPair.html)

#### m\_enableBuilderCockpit

##### Declaration

```
protected bool m_enableBuilderCockpit
```

##### Field Value

Type

Description

System.Boolean

#### m\_enableFirstPerson

##### Declaration

```
protected bool m_enableFirstPerson
```

##### Field Value

Type

Description

System.Boolean

#### m\_enableShipControl

##### Declaration

```
protected bool m_enableShipControl
```

##### Field Value

Type

Description

System.Boolean

#### m\_getInCockpitSound

##### Declaration

```
protected MySoundPair m_getInCockpitSound
```

##### Field Value

Type

Description

[MySoundPair](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MySoundPair.html)

#### m\_gridGyroSystem

##### Declaration

```
protected MyGridGyroSystem m_gridGyroSystem
```

##### Field Value

Type

Description

Sandbox.Game.GameSystems.MyGridGyroSystem

#### m\_headLocalPosition

##### Declaration

```
protected Vector3 m_headLocalPosition
```

##### Field Value

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### m\_lastPilot

##### Declaration

```
protected MyCharacter m_lastPilot
```

##### Field Value

Type

Description

Sandbox.Game.Entities.Character.MyCharacter

#### m\_rechargeSocket

##### Declaration

```
protected MyRechargeSocket m_rechargeSocket
```

##### Field Value

Type

Description

Sandbox.Game.GameSystems.Electricity.MyRechargeSocket

#### m\_singleWeaponMode

##### Declaration

```
protected bool m_singleWeaponMode
```

##### Field Value

Type

Description

System.Boolean

#### m\_useSoundEmitter

##### Declaration

```
protected MyEntity3DSoundEmitter m_useSoundEmitter
```

##### Field Value

Type

Description

[MyEntity3DSoundEmitter](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntity3DSoundEmitter.html)

#### TargetData

##### Declaration

```
public MyCharacter.MyTargetData TargetData
```

##### Field Value

Type

Description

Sandbox.Game.Entities.Character.MyCharacter.MyTargetData

### Properties

#### AreBreaksOn

##### Declaration

```
public Nullable<bool> AreBreaksOn { get; }
```

##### Property Value

Type

Description

System.Nullable<System.Boolean\>

#### AuxiliaryContext

##### Declaration

```
public MyStringId AuxiliaryContext { get; }
```

##### Property Value

Type

Description

[MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html)

#### BlockDefinition

##### Declaration

```
public MyShipControllerDefinition BlockDefinition { get; }
```

##### Property Value

Type

Description

[MyShipControllerDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyShipControllerDefinition.html)

#### CanHavePreviousCameraEntity

##### Declaration

```
public virtual bool CanHavePreviousCameraEntity { get; }
```

##### Property Value

Type

Description

System.Boolean

#### CanHavePreviousControlledEntity

##### Declaration

```
public virtual bool CanHavePreviousControlledEntity { get; }
```

##### Property Value

Type

Description

System.Boolean

#### CanSwitchLandingGears

##### Declaration

```
public bool CanSwitchLandingGears { get; }
```

##### Property Value

Type

Description

System.Boolean

#### ControlContext

##### Declaration

```
public MyStringId ControlContext { get; }
```

##### Property Value

Type

Description

[MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html)

#### ControlGroup

##### Declaration

```
public MyGroups<MyCubeGrid, MyGridPhysicalGroupData> ControlGroup { get; }
```

##### Property Value

Type

Description

VRage.Groups.MyGroups<[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html), [MyGridPhysicalGroupData](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyGridPhysicalGroupData.html)\>

#### ControlGyros

##### Declaration

```
public bool ControlGyros { get; set; }
```

##### Property Value

Type

Description

System.Boolean
