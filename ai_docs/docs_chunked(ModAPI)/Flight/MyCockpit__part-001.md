---
title: "Class MyCockpit"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCockpit.html"
category: "Flight"
namespace: "Sandbox.Game.Entities"
class: "MyCockpit"
---

# Class MyCockpit | Space Engineers ModAPI

##### Inheritance

System.Object

Sandbox.Game.Entities.Cube.MySyncedBlock

Sandbox.Game.Entities.Cube.MyTerminalBlock

MyCockpit

##### Implements

##### Inherited Members

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyCubeBlockType]
[MyTerminalInterface]
public class MyCockpit : MyShipController, IMyComponentOwner<MyIDModule>, IMyUpgradableBlock, IMyUpgradableBlock, IMyEventProxy, IMyEventOwner, IMySyncedEntity, IMyControllableEntity, IMyRechargeSocketOwner, IMyShootOrigin, IMyPilotable, IMyShipControl, IMyWheelControllableEntity, IMyUsableEntity, IMyCockpit, IMyCameraController, IMyShipController, IMyTerminalBlock, IMyCubeBlock, IMyEntity, IMyControllableEntity, IMyTargetingCapableBlock, IMyCockpit, IMyShipController, IMyTerminalBlock, IMyCubeBlock, IMyEntity, IMyTextSurfaceProvider, IMyTextSurfaceProvider, IMyGasBlock, IMyConveyorEndpointBlock, IMyMultiTextPanelComponentOwner, IMyTextPanelComponentOwner
```

### [](#constructors)Constructors

#### [](#Sandbox_Game_Entities_MyCockpit__ctor)MyCockpit()

##### Declaration

### [](#fields)Fields

#### [](#Sandbox_Game_Entities_MyCockpit_m_characterDummy)m\_characterDummy

##### Declaration

```
protected MatrixD m_characterDummy
```

##### Field Value

#### [](#Sandbox_Game_Entities_MyCockpit_m_pilot)m\_pilot

##### Declaration

```
protected MyCharacter m_pilot
```

##### Field Value

Type

Description

Sandbox.Game.Entities.Character.MyCharacter

#### [](#Sandbox_Game_Entities_MyCockpit_m_pilotClosedHandler)m\_pilotClosedHandler

##### Declaration

```
protected readonly Action<MyEntity> m_pilotClosedHandler
```

##### Field Value

Type

Description

System.Action<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\>

#### [](#Sandbox_Game_Entities_MyCockpit_m_pilotGunDefinition)m\_pilotGunDefinition

##### Declaration

```
protected Nullable<MyDefinitionId> m_pilotGunDefinition
```

##### Field Value

#### [](#Sandbox_Game_Entities_MyCockpit_MAX_DRAW_DISTANCE)MAX\_DRAW\_DISTANCE

##### Declaration

```
public const double MAX_DRAW_DISTANCE = 200
```

##### Field Value

Type

Description

System.Double

#### [](#Sandbox_Game_Entities_MyCockpit_MAX_SHAKE_DAMAGE)MAX\_SHAKE\_DAMAGE

##### Declaration

```
public static float MAX_SHAKE_DAMAGE
```

##### Field Value

Type

Description

System.Single

#### [](#Sandbox_Game_Entities_MyCockpit_MaxHeadLocalXAngle)MaxHeadLocalXAngle

##### Declaration

```
protected float MaxHeadLocalXAngle
```

##### Field Value

Type

Description

System.Single

#### [](#Sandbox_Game_Entities_MyCockpit_MaxHeadLocalYAngle)MaxHeadLocalYAngle

##### Declaration

```
protected float MaxHeadLocalYAngle
```

##### Field Value

Type

Description

System.Single

#### [](#Sandbox_Game_Entities_MyCockpit_MinHeadLocalXAngle)MinHeadLocalXAngle

##### Declaration

```
protected float MinHeadLocalXAngle
```

##### Field Value

Type

Description

System.Single

#### [](#Sandbox_Game_Entities_MyCockpit_MinHeadLocalYAngle)MinHeadLocalYAngle

##### Declaration

```
protected float MinHeadLocalYAngle
```

##### Field Value

Type

Description

System.Single

### [](#properties)Properties

#### [](#Sandbox_Game_Entities_MyCockpit_AiPilot)AiPilot

##### Declaration

```
public MyAutopilotBase AiPilot { get; }
```

##### Property Value

Type

Description

Sandbox.Game.AI.Autopilots.MyAutopilotBase

#### [](#Sandbox_Game_Entities_MyCockpit_BlockDefinition)BlockDefinition

##### Declaration

```
public MyCockpitDefinition BlockDefinition { get; }
```

##### Property Value

#### [](#Sandbox_Game_Entities_MyCockpit_CameraPosition)CameraPosition

##### Declaration

```
public Vector3D CameraPosition { get; }
```

##### Property Value

#### [](#Sandbox_Game_Entities_MyCockpit_CameraRotation)CameraRotation

##### Declaration

```
public Quaternion CameraRotation { get; }
```

##### Property Value

#### [](#Sandbox_Game_Entities_MyCockpit_CanPressurizeRoom)CanPressurizeRoom

##### Declaration

```
public bool CanPressurizeRoom { get; }
```

##### Property Value

Type

Description

System.Boolean

#### [](#Sandbox_Game_Entities_MyCockpit_ConveyorEndpoint)ConveyorEndpoint

##### Declaration

```
public IMyConveyorEndpoint ConveyorEndpoint { get; }
```

##### Property Value

Type

Description

Sandbox.Game.GameSystems.Conveyors.IMyConveyorEndpoint

#### [](#Sandbox_Game_Entities_MyCockpit_ForceFirstPersonCamera)ForceFirstPersonCamera

##### Declaration

```
public override bool ForceFirstPersonCamera { get; set; }
```

##### Property Value

Type

Description

System.Boolean

##### Overrides

#### [](#Sandbox_Game_Entities_MyCockpit_HeadLocalXAngle)HeadLocalXAngle

##### Declaration

```
public override float HeadLocalXAngle { get; set; }
```

##### Property Value

Type

Description

System.Single

##### Overrides

#### [](#Sandbox_Game_Entities_MyCockpit_HeadLocalYAngle)HeadLocalYAngle

##### Declaration

```
public override float HeadLocalYAngle { get; set; }
```

##### Property Value

Type

Description

System.Single

##### Overrides

#### [](#Sandbox_Game_Entities_MyCockpit_IsBeingUsedBy)IsBeingUsedBy

##### Declaration

```
public MyEntity IsBeingUsedBy { get; }
```

##### Property Value

#### [](#Sandbox_Game_Entities_MyCockpit_IsInFirstPersonView)IsInFirstPersonView

##### Declaration

```
public virtual bool IsInFirstPersonView { get; set; }
```

##### Property Value

Type

Description

System.Boolean

#### [](#Sandbox_Game_Entities_MyCockpit_IsOccupied)IsOccupied

##### Declaration

```
public bool IsOccupied { get; }
```

##### Property Value

Type

Description

System.Boolean

#### [](#Sandbox_Game_Entities_MyCockpit_IsTextPanelOpen)IsTextPanelOpen
