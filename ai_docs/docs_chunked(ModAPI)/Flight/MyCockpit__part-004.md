##### Parameters

#### [](#Sandbox_Game_Entities_MyCockpit_OnChangeDescription_System_Int32_System_String_)OnChangeDescription(Int32, String)

##### Declaration

```
[Event(null, 591)]
[Reliable]
[Server]
[Broadcast]
public void OnChangeDescription(int panelId, string description)
```

##### Parameters

Type

Name

Description

System.Int32

panelId

System.String

description

#### [](#Sandbox_Game_Entities_MyCockpit_OnClosedPanelMessageBox_Sandbox_Graphics_GUI_MyGuiScreenMessageBox_ResultEnum_)OnClosedPanelMessageBox(MyGuiScreenMessageBox.ResultEnum)

##### Declaration

```
public void OnClosedPanelMessageBox(MyGuiScreenMessageBox.ResultEnum result)
```

##### Parameters

Type

Name

Description

Sandbox.Graphics.GUI.MyGuiScreenMessageBox.ResultEnum

result

#### [](#Sandbox_Game_Entities_MyCockpit_OnClosedPanelTextBox_VRage_Game_ModAPI_ResultEnum_)OnClosedPanelTextBox(ResultEnum)

##### Declaration

```
public void OnClosedPanelTextBox(ResultEnum result)
```

##### Parameters

#### [](#Sandbox_Game_Entities_MyCockpit_OnControlAcquired_UpdateCamera)OnControlAcquired\_UpdateCamera()

##### Declaration

```
protected override void OnControlAcquired_UpdateCamera()
```

##### Overrides

#### [](#Sandbox_Game_Entities_MyCockpit_OnControlledEntity_Used)OnControlledEntity\_Used()

##### Declaration

```
protected override void OnControlledEntity_Used()
```

##### Overrides

#### [](#Sandbox_Game_Entities_MyCockpit_OnControlReleased_Sandbox_Game_World_MyEntityController_)OnControlReleased(MyEntityController)

##### Declaration

```
protected override void OnControlReleased(MyEntityController controller)
```

##### Parameters

Type

Name

Description

Sandbox.Game.World.MyEntityController

controller

##### Overrides

#### [](#Sandbox_Game_Entities_MyCockpit_OnControlReleased_UpdateCamera)OnControlReleased\_UpdateCamera()

##### Declaration

```
protected override void OnControlReleased_UpdateCamera()
```

##### Overrides

#### [](#Sandbox_Game_Entities_MyCockpit_OnInputChanged_VRage_Game_MyDefinitionId_System_Single_Sandbox_Game_EntityComponents_MyResourceSinkComponent_)OnInputChanged(MyDefinitionId, Single, MyResourceSinkComponent)

##### Declaration

```
protected virtual void OnInputChanged(MyDefinitionId resourceTypeId, float oldInput, MyResourceSinkComponent sink)
```

##### Parameters

#### [](#Sandbox_Game_Entities_MyCockpit_OnModelChange)OnModelChange()

##### Declaration

```
public override void OnModelChange()
```

##### Overrides

#### [](#Sandbox_Game_Entities_MyCockpit_OnOwnershipChanged)OnOwnershipChanged()

##### Declaration

```
protected override void OnOwnershipChanged()
```

##### Overrides

Sandbox.Game.Entities.Cube.MyTerminalBlock.OnOwnershipChanged()

#### [](#Sandbox_Game_Entities_MyCockpit_OnRegisteredToGridSystems)OnRegisteredToGridSystems()

##### Declaration

```
public override void OnRegisteredToGridSystems()
```

##### Overrides

#### [](#Sandbox_Game_Entities_MyCockpit_OnReleaseControl_VRage_Game_ModAPI_Interfaces_IMyCameraController_)OnReleaseControl(IMyCameraController)

##### Declaration

```
public void OnReleaseControl(IMyCameraController newCameraController)
```

##### Parameters

#### [](#Sandbox_Game_Entities_MyCockpit_OnRemovedFromScene_System_Object_)OnRemovedFromScene(Object)

##### Declaration

```
public override void OnRemovedFromScene(object source)
```

##### Parameters

Type

Name

Description

System.Object

source

##### Overrides

#### [](#Sandbox_Game_Entities_MyCockpit_OnRequestRemovePilot)OnRequestRemovePilot()

##### Declaration

```
[Event(null, 1614)]
[Reliable]
[Server]
public void OnRequestRemovePilot()
```

#### [](#Sandbox_Game_Entities_MyCockpit_OnUnregisteredFromGridSystems)OnUnregisteredFromGridSystems()

##### Declaration

```
public override void OnUnregisteredFromGridSystems()
```

##### Overrides

#### [](#Sandbox_Game_Entities_MyCockpit_OpenWindow_System_Boolean_System_Boolean_System_Boolean_)OpenWindow(Boolean, Boolean, Boolean)

##### Declaration

```
public void OpenWindow(bool isEditable, bool sync, bool isPublic)
```

##### Parameters

Type

Name

Description

System.Boolean

isEditable

System.Boolean

sync

System.Boolean

isPublic

#### [](#Sandbox_Game_Entities_MyCockpit_PlacePilotInSeat_Sandbox_Game_Entities_Character_MyCharacter_System_Int32_)PlacePilotInSeat(MyCharacter, Int32)

##### Declaration

```
protected virtual void PlacePilotInSeat(MyCharacter pilot, int seed)
```

##### Parameters

Type

Name

Description

Sandbox.Game.Entities.Character.MyCharacter

pilot

System.Int32

seed

#### [](#Sandbox_Game_Entities_MyCockpit_PostBaseInit)PostBaseInit()

##### Declaration

```
protected virtual void PostBaseInit()
```

#### [](#Sandbox_Game_Entities_MyCockpit_RemoveAutopilot_System_Boolean_)RemoveAutopilot(Boolean)

##### Declaration

```
public void RemoveAutopilot(bool updateSync = true)
```

##### Parameters

Type

Name

Description

System.Boolean

updateSync

#### [](#Sandbox_Game_Entities_MyCockpit_RemoveLocal)RemoveLocal()

##### Declaration

```
protected override void RemoveLocal()
```

##### Overrides

#### [](#Sandbox_Game_Entities_MyCockpit_RemoveOriginalPilotPosition)RemoveOriginalPilotPosition()

##### Declaration

```
public void RemoveOriginalPilotPosition()
```

#### [](#Sandbox_Game_Entities_MyCockpit_RemovePilot)RemovePilot()

##### Declaration

```
public bool RemovePilot()
```

##### Returns

Type

Description

System.Boolean

#### [](#Sandbox_Game_Entities_MyCockpit_RemovePilotFromSeat_Sandbox_Game_Entities_Character_MyCharacter_)RemovePilotFromSeat(MyCharacter)

##### Declaration

```
protected virtual void RemovePilotFromSeat(MyCharacter pilot)
```

##### Parameters

Type

Name

Description

Sandbox.Game.Entities.Character.MyCharacter

pilot

#### [](#Sandbox_Game_Entities_MyCockpit_RequestRemovePilot)RequestRemovePilot()

##### Declaration

```
public void RequestRemovePilot()
```

#### [](#Sandbox_Game_Entities_MyCockpit_RequestUse_VRage_Game_Entity_UseObject_UseActionEnum_Sandbox_Game_Entities_Character_MyCharacter_)RequestUse(UseActionEnum, MyCharacter)
