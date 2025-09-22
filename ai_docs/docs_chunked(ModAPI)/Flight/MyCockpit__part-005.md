Sandbox.Game.Entities.Character.MyCharacter

pilot

#### [](#Sandbox_Game_Entities_MyCockpit_RequestRemovePilot)RequestRemovePilot()

##### Declaration

```
public void RequestRemovePilot()
```

#### [](#Sandbox_Game_Entities_MyCockpit_RequestUse_VRage_Game_Entity_UseObject_UseActionEnum_Sandbox_Game_Entities_Character_MyCharacter_)RequestUse(UseActionEnum, MyCharacter)

##### Declaration

```
public void RequestUse(UseActionEnum actionEnum, MyCharacter user)
```

##### Parameters

Type

Name

Description

[UseActionEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.UseObject.UseActionEnum.html)

actionEnum

Sandbox.Game.Entities.Character.MyCharacter

user

#### [](#Sandbox_Game_Entities_MyCockpit_Rotate_VRageMath_Vector2_System_Single_)Rotate(Vector2, Single)

##### Declaration

```
public void Rotate(Vector2 rotationIndicator, float roll)
```

##### Parameters

Type

Name

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

rotationIndicator

System.Single

roll

#### [](#Sandbox_Game_Entities_MyCockpit_RotateStopped)RotateStopped()

##### Declaration

```
public void RotateStopped()
```

#### [](#Sandbox_Game_Entities_MyCockpit_ShouldSit)ShouldSit()

##### Declaration

```
protected override bool ShouldSit()
```

##### Returns

Type

Description

System.Boolean

##### Overrides

#### [](#Sandbox_Game_Entities_MyCockpit_ShowInventory)ShowInventory()

##### Declaration

```
public override void ShowInventory()
```

##### Overrides

#### [](#Sandbox_Game_Entities_MyCockpit_ShowRemoteAccessMenu)ShowRemoteAccessMenu()

##### Declaration

```
public override void ShowRemoteAccessMenu()
```

##### Overrides

#### [](#Sandbox_Game_Entities_MyCockpit_ShowTerminal)ShowTerminal()

##### Declaration

```
public override void ShowTerminal()
```

##### Overrides

#### [](#Sandbox_Game_Entities_MyCockpit_StartLoopSound)StartLoopSound()

##### Declaration

```
protected override void StartLoopSound()
```

##### Overrides

#### [](#Sandbox_Game_Entities_MyCockpit_StopLoopSound)StopLoopSound()

##### Declaration

```
protected override void StopLoopSound()
```

##### Overrides

#### [](#Sandbox_Game_Entities_MyCockpit_UpdateAfterSimulation10)UpdateAfterSimulation10()

##### Declaration

```
public override void UpdateAfterSimulation10()
```

##### Overrides

#### [](#Sandbox_Game_Entities_MyCockpit_UpdateBeforeSimulation)UpdateBeforeSimulation()

##### Declaration

```
public override void UpdateBeforeSimulation()
```

##### Overrides

#### [](#Sandbox_Game_Entities_MyCockpit_UpdateBeforeSimulation10)UpdateBeforeSimulation10()

##### Declaration

```
public override void UpdateBeforeSimulation10()
```

##### Overrides

#### [](#Sandbox_Game_Entities_MyCockpit_UpdateBeforeSimulation100)UpdateBeforeSimulation100()

##### Declaration

```
public override void UpdateBeforeSimulation100()
```

##### Overrides

#### [](#Sandbox_Game_Entities_MyCockpit_UpdateCameraAfterChange_System_Boolean_)UpdateCameraAfterChange(Boolean)

##### Declaration

```
protected override void UpdateCameraAfterChange(bool resetHeadLocalAngle = true)
```

##### Parameters

Type

Name

Description

System.Boolean

resetHeadLocalAngle

##### Overrides

#### [](#Sandbox_Game_Entities_MyCockpit_UpdateCockpitModel)UpdateCockpitModel()

##### Declaration

```
public virtual void UpdateCockpitModel()
```

#### [](#Sandbox_Game_Entities_MyCockpit_UpdateOnceBeforeFrame)UpdateOnceBeforeFrame()

##### Declaration

```
public override void UpdateOnceBeforeFrame()
```

##### Overrides

#### [](#Sandbox_Game_Entities_MyCockpit_UpdateScreen)UpdateScreen()

##### Declaration

```
public void UpdateScreen()
```

#### [](#Sandbox_Game_Entities_MyCockpit_UpdateSoundState)UpdateSoundState()

##### Declaration

```
protected override void UpdateSoundState()
```

##### Overrides

#### [](#Sandbox_Game_Entities_MyCockpit_UpdateVisual)UpdateVisual()

##### Declaration

```
public override void UpdateVisual()
```

##### Overrides

### [](#events)Events

#### [](#Sandbox_Game_Entities_MyCockpit_IsOccupiedChanged)IsOccupiedChanged

##### Declaration

```
public event Action<IMyCockpit> IsOccupiedChanged
```

##### Event Type

#### [](#Sandbox_Game_Entities_MyCockpit_OnPilotAttached)OnPilotAttached

##### Declaration

```
public static event Action OnPilotAttached
```

##### Event Type

Type

Description

System.Action

### [](#eii)Explicit Interface Implementations

#### [](#Sandbox_Game_Entities_MyCockpit_Sandbox_Game_EntityComponents_IMyMultiTextPanelComponentOwner_MultiTextPanel)IMyMultiTextPanelComponentOwner.MultiTextPanel

##### Declaration

```
MyMultiTextPanelComponent IMyMultiTextPanelComponentOwner.MultiTextPanel { get; }
```

##### Returns

#### [](#Sandbox_Game_Entities_MyCockpit_Sandbox_Game_EntityComponents_IMyMultiTextPanelComponentOwner_SelectPanel_System_Collections_Generic_List_Sandbox_Graphics_GUI_MyGuiControlListbox_Item__)IMyMultiTextPanelComponentOwner.SelectPanel(List<MyGuiControlListbox.Item>)

##### Declaration

```
void IMyMultiTextPanelComponentOwner.SelectPanel(List<MyGuiControlListbox.Item> panelItems)
```

##### Parameters

Type

Name

Description

System.Collections.Generic.List<Sandbox.Graphics.GUI.MyGuiControlListbox.Item\>

panelItems

#### [](#Sandbox_Game_Entities_MyCockpit_Sandbox_ModAPI_IMyCockpit_AttachPilot_VRage_Game_ModAPI_IMyCharacter_)IMyCockpit.AttachPilot(IMyCharacter)

##### Declaration

```
void IMyCockpit.AttachPilot(IMyCharacter pilot)
```

##### Parameters

#### [](#Sandbox_Game_Entities_MyCockpit_Sandbox_ModAPI_IMyCockpit_AttachPilot_VRage_Game_ModAPI_IMyCharacter_System_Int32_)IMyCockpit.AttachPilot(IMyCharacter, Int32)

##### Declaration

```
void IMyCockpit.AttachPilot(IMyCharacter pilot, int animation)
```

##### Parameters

Type

Name

Description

[IMyCharacter](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCharacter.html)

pilot

System.Int32

animation

#### [](#Sandbox_Game_Entities_MyCockpit_Sandbox_ModAPI_IMyCockpit_OxygenFilledRatio)IMyCockpit.OxygenFilledRatio
