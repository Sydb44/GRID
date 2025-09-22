```
public bool IsOccupied { get; }
```

##### Property Value

Type

Description

System.Boolean

#### [](#Sandbox_Game_Entities_MyCockpit_IsTextPanelOpen)IsTextPanelOpen

##### Declaration

```
public bool IsTextPanelOpen { get; set; }
```

##### Property Value

Type

Description

System.Boolean

#### [](#Sandbox_Game_Entities_MyCockpit_NeighbourPositions)NeighbourPositions

##### Declaration

```
public Vector3I[] NeighbourPositions { get; }
```

##### Property Value

#### [](#Sandbox_Game_Entities_MyCockpit_OxygenAmount)OxygenAmount

##### Declaration

```
public float OxygenAmount { get; set; }
```

##### Property Value

Type

Description

System.Single

#### [](#Sandbox_Game_Entities_MyCockpit_OxygenAmountMissing)OxygenAmountMissing

##### Declaration

```
public float OxygenAmountMissing { get; }
```

##### Property Value

Type

Description

System.Single

#### [](#Sandbox_Game_Entities_MyCockpit_OxygenFillLevel)OxygenFillLevel

##### Declaration

```
public float OxygenFillLevel { get; }
```

##### Property Value

Type

Description

System.Single

#### [](#Sandbox_Game_Entities_MyCockpit_PanelComponent)PanelComponent

##### Declaration

```
public MyTextPanelComponent PanelComponent { get; }
```

##### Property Value

Type

Description

Sandbox.Game.Entities.Blocks.MyTextPanelComponent

#### [](#Sandbox_Game_Entities_MyCockpit_Pilot)Pilot

##### Declaration

```
public override MyCharacter Pilot { get; }
```

##### Property Value

Type

Description

Sandbox.Game.Entities.Character.MyCharacter

##### Overrides

#### [](#Sandbox_Game_Entities_MyCockpit_PilotJetpackEnabledBackup)PilotJetpackEnabledBackup

##### Declaration

```
public bool PilotJetpackEnabledBackup { get; }
```

##### Property Value

Type

Description

System.Boolean

#### [](#Sandbox_Game_Entities_MyCockpit_UseGenericLcd)UseGenericLcd

##### Declaration

```
public bool UseGenericLcd { get; }
```

##### Property Value

Type

Description

System.Boolean

### [](#methods)Methods

#### [](#Sandbox_Game_Entities_MyCockpit_AddShake_System_Single_)AddShake(Single)

##### Declaration

```
public void AddShake(float shakePower)
```

##### Parameters

Type

Name

Description

System.Single

shakePower

#### [](#Sandbox_Game_Entities_MyCockpit_AllowSelfPulling)AllowSelfPulling()

##### Declaration

```
public bool AllowSelfPulling()
```

##### Returns

Type

Description

System.Boolean

#### [](#Sandbox_Game_Entities_MyCockpit_AttachAutopilot_Sandbox_Game_AI_Autopilots_MyAutopilotBase_System_Boolean_)AttachAutopilot(MyAutopilotBase, Boolean)

##### Declaration

```
public void AttachAutopilot(MyAutopilotBase newAutopilot, bool updateSync = true)
```

##### Parameters

Type

Name

Description

Sandbox.Game.AI.Autopilots.MyAutopilotBase

newAutopilot

System.Boolean

updateSync

#### [](#Sandbox_Game_Entities_MyCockpit_AttachPilot_Sandbox_Game_Entities_Character_MyCharacter_System_Int32_System_Boolean_System_Boolean_System_Boolean_)AttachPilot(MyCharacter, Int32, Boolean, Boolean, Boolean)

##### Declaration

```
public void AttachPilot(MyCharacter pilot, int seed, bool storeOriginalPilotWorld = true, bool calledFromInit = false, bool merged = false)
```

##### Parameters

Type

Name

Description

Sandbox.Game.Entities.Character.MyCharacter

pilot

System.Int32

seed

System.Boolean

storeOriginalPilotWorld

System.Boolean

calledFromInit

System.Boolean

merged

#### [](#Sandbox_Game_Entities_MyCockpit_AttachPilotEvent_VRage_Game_Entity_UseObject_UseActionEnum_System_Int64_System_Int32_)AttachPilotEvent(UseActionEnum, Int64, Int32)

##### Declaration

```
[Event(null, 2511)]
[Reliable]
[Server]
public void AttachPilotEvent(UseActionEnum actionEnum, long characterID, int animation)
```

##### Parameters

Type

Name

Description

[UseActionEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.UseObject.UseActionEnum.html)

actionEnum

System.Int64

characterID

System.Int32

animation

#### [](#Sandbox_Game_Entities_MyCockpit_AttachPilotEventFailed_VRage_Game_Entity_UseObject_UseActionResult_)AttachPilotEventFailed(UseActionResult)

##### Declaration

```
public void AttachPilotEventFailed(UseActionResult actionResult)
```

##### Parameters

#### [](#Sandbox_Game_Entities_MyCockpit_CalculateCurrentModel_VRageMath_Matrix__)CalculateCurrentModel(out Matrix)

##### Declaration

```
public override string CalculateCurrentModel(out Matrix orientation)
```

##### Parameters

Type

Name

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

orientation

##### Returns

Type

Description

System.String

##### Overrides

#### [](#Sandbox_Game_Entities_MyCockpit_CanBeMainCockpit)CanBeMainCockpit()

##### Declaration

```
protected override bool CanBeMainCockpit()
```

##### Returns

Type

Description

System.Boolean

##### Overrides

#### [](#Sandbox_Game_Entities_MyCockpit_CanUse_VRage_Game_Entity_UseObject_UseActionEnum_Sandbox_Game_Entities_IMyControllableEntity_)CanUse(UseActionEnum, IMyControllableEntity)

##### Declaration

```
public virtual UseActionResult CanUse(UseActionEnum actionEnum, IMyControllableEntity user)
```

##### Parameters

##### Returns

#### [](#Sandbox_Game_Entities_MyCockpit_CheckEmissiveState_System_Boolean_)CheckEmissiveState(Boolean)

##### Declaration

```
public override void CheckEmissiveState(bool force = false)
```

##### Parameters

Type

Name

Description

System.Boolean

force

##### Overrides

#### [](#Sandbox_Game_Entities_MyCockpit_CheckIsWorking)CheckIsWorking()

##### Declaration

```
protected override bool CheckIsWorking()
```

##### Returns

Type

Description

System.Boolean

##### Overrides

#### [](#Sandbox_Game_Entities_MyCockpit_ClearSavedpilot)ClearSavedpilot()

##### Declaration

```
public void ClearSavedpilot()
```

#### [](#Sandbox_Game_Entities_MyCockpit_Closing)Closing()

##### Declaration

```
protected override void Closing()
```

##### Overrides

#### [](#Sandbox_Game_Entities_MyCockpit_ComponentStack_IsFunctionalChanged)ComponentStack\_IsFunctionalChanged()
