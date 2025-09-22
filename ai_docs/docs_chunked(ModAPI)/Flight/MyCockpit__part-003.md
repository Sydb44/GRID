```

#### [](#Sandbox_Game_Entities_MyCockpit_Closing)Closing()

##### Declaration

```
protected override void Closing()
```

##### Overrides

#### [](#Sandbox_Game_Entities_MyCockpit_ComponentStack_IsFunctionalChanged)ComponentStack\_IsFunctionalChanged()

##### Declaration

```
protected override void ComponentStack_IsFunctionalChanged()
```

##### Overrides

#### [](#Sandbox_Game_Entities_MyCockpit_CreateTerminalControls)CreateTerminalControls()

##### Declaration

```
protected override void CreateTerminalControls()
```

##### Overrides

#### [](#Sandbox_Game_Entities_MyCockpit_FindFreeNeighbourPosition)FindFreeNeighbourPosition()

##### Declaration

```
protected Nullable<Vector3D> FindFreeNeighbourPosition()
```

##### Returns

Type

Description

System.Nullable<[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\>

#### [](#Sandbox_Game_Entities_MyCockpit_GetHeadMatrix_System_Boolean_System_Boolean_System_Boolean_System_Boolean_)GetHeadMatrix(Boolean, Boolean, Boolean, Boolean)

##### Declaration

```
public override MatrixD GetHeadMatrix(bool includeY, bool includeX = true, bool forceHeadAnim = false, bool forceHeadBone = false)
```

##### Parameters

Type

Name

Description

System.Boolean

includeY

System.Boolean

includeX

System.Boolean

forceHeadAnim

System.Boolean

forceHeadBone

##### Returns

##### Overrides

#### [](#Sandbox_Game_Entities_MyCockpit_GetHudParams_System_Boolean_)GetHudParams(Boolean)

##### Declaration

```
public override List<MyHudEntityParams> GetHudParams(bool allowBlink)
```

##### Parameters

Type

Name

Description

System.Boolean

allowBlink

##### Returns

Type

Description

System.Collections.Generic.List<VRage.Game.Gui.MyHudEntityParams\>

##### Overrides

Sandbox.Game.Entities.Cube.MyTerminalBlock.GetHudParams(System.Boolean)

#### [](#Sandbox_Game_Entities_MyCockpit_GetObjectBuilderCubeBlock_System_Boolean_)GetObjectBuilderCubeBlock(Boolean)

##### Declaration

```
public override MyObjectBuilder_CubeBlock GetObjectBuilderCubeBlock(bool copy = false)
```

##### Parameters

Type

Name

Description

System.Boolean

copy

##### Returns

##### Overrides

#### [](#Sandbox_Game_Entities_MyCockpit_GetOverridingFocusMatrix)GetOverridingFocusMatrix()

##### Declaration

```
public Nullable<MatrixD> GetOverridingFocusMatrix()
```

##### Returns

Type

Description

System.Nullable<[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)\>

#### [](#Sandbox_Game_Entities_MyCockpit_GetPullInformation)GetPullInformation()

##### Declaration

```
public PullInformation GetPullInformation()
```

##### Returns

Type

Description

Sandbox.Game.GameSystems.Conveyors.PullInformation

#### [](#Sandbox_Game_Entities_MyCockpit_GetPushInformation)GetPushInformation()

##### Declaration

```
public PullInformation GetPushInformation()
```

##### Returns

Type

Description

Sandbox.Game.GameSystems.Conveyors.PullInformation

#### [](#Sandbox_Game_Entities_MyCockpit_GetSitAnimation_Sandbox_Game_Entities_Character_MyCharacter_System_Int32_)GetSitAnimation(MyCharacter, Int32)

##### Declaration

```
protected string GetSitAnimation(MyCharacter pilot, int seed)
```

##### Parameters

Type

Name

Description

Sandbox.Game.Entities.Character.MyCharacter

pilot

System.Int32

seed

##### Returns

Type

Description

System.String

#### [](#Sandbox_Game_Entities_MyCockpit_GetViewMatrix)GetViewMatrix()

##### Declaration

```
public override MatrixD GetViewMatrix()
```

##### Returns

##### Overrides

#### [](#Sandbox_Game_Entities_MyCockpit_GiveControlToPilot)GiveControlToPilot()

##### Declaration

```
public void GiveControlToPilot()
```

#### [](#Sandbox_Game_Entities_MyCockpit_Init_VRage_Game_MyObjectBuilder_CubeBlock_Sandbox_Game_Entities_MyCubeGrid_)Init(MyObjectBuilder\_CubeBlock, MyCubeGrid)

##### Declaration

```
public override void Init(MyObjectBuilder_CubeBlock objectBuilder, MyCubeGrid cubeGrid)
```

##### Parameters

##### Overrides

#### [](#Sandbox_Game_Entities_MyCockpit_InitComponents)InitComponents()

##### Declaration

```
public override void InitComponents()
```

##### Overrides

#### [](#Sandbox_Game_Entities_MyCockpit_InitializeConveyorEndpoint)InitializeConveyorEndpoint()

##### Declaration

```
public void InitializeConveyorEndpoint()
```

#### [](#Sandbox_Game_Entities_MyCockpit_IsCameraController)IsCameraController()

##### Declaration

```
protected override bool IsCameraController()
```

##### Returns

Type

Description

System.Boolean

##### Overrides

#### [](#Sandbox_Game_Entities_MyCockpit_IsLargeShip)IsLargeShip()

##### Declaration

```
public override bool IsLargeShip()
```

##### Returns

Type

Description

System.Boolean

##### Overrides

#### [](#Sandbox_Game_Entities_MyCockpit_IsNeighbourPositionFree_VRageMath_Vector3I_VRageMath_Vector3D__)IsNeighbourPositionFree(Vector3I, out Vector3D)

##### Declaration

```
public bool IsNeighbourPositionFree(Vector3I neighbourOffsetI, out Vector3D translation)
```

##### Parameters

##### Returns

Type

Description

System.Boolean

#### [](#Sandbox_Game_Entities_MyCockpit_NeedsUpdate10)NeedsUpdate10()

##### Declaration

```
protected bool NeedsUpdate10()
```

##### Returns

Type

Description

System.Boolean

#### [](#Sandbox_Game_Entities_MyCockpit_OnAddedToScene_System_Object_)OnAddedToScene(Object)

##### Declaration

```
public override void OnAddedToScene(object source)
```

##### Parameters

Type

Name

Description

System.Object

source

##### Overrides

#### [](#Sandbox_Game_Entities_MyCockpit_OnAssumeControl_VRage_Game_ModAPI_Interfaces_IMyCameraController_)OnAssumeControl(IMyCameraController)

##### Declaration

```
public void OnAssumeControl(IMyCameraController previousCameraController)
```

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
