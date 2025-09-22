#### [](#Sandbox_Game_Entities_MyBatteryBlock_CreateTerminalControls)CreateTerminalControls()

##### Declaration

```
protected override void CreateTerminalControls()
```

##### Overrides

Sandbox.Game.Entities.Cube.MyFunctionalBlock.CreateTerminalControls()

#### [](#Sandbox_Game_Entities_MyBatteryBlock_GetObjectBuilderCubeBlock_System_Boolean_)GetObjectBuilderCubeBlock(Boolean)

##### Declaration

```
public override MyObjectBuilder_CubeBlock GetObjectBuilderCubeBlock(bool copy = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | copy |     |

##### Returns

##### Overrides

Sandbox.Game.Entities.Cube.MyFunctionalBlock.GetObjectBuilderCubeBlock(System.Boolean)

#### [](#Sandbox_Game_Entities_MyBatteryBlock_Init_VRage_Game_MyObjectBuilder_CubeBlock_Sandbox_Game_Entities_MyCubeGrid_)Init(MyObjectBuilder\_CubeBlock, MyCubeGrid)

##### Declaration

```
public override void Init(MyObjectBuilder_CubeBlock objectBuilder, MyCubeGrid cubeGrid)
```

##### Parameters

##### Overrides

Sandbox.Game.Entities.Cube.MyFunctionalBlock.Init(VRage.Game.MyObjectBuilder\_CubeBlock, Sandbox.Game.Entities.MyCubeGrid)

#### [](#Sandbox_Game_Entities_MyBatteryBlock_OnAddedToScene_System_Object_)OnAddedToScene(Object)

##### Declaration

```
public override void OnAddedToScene(object source)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | source |     |

##### Overrides

Sandbox.Game.Entities.Cube.MyFunctionalBlock.OnAddedToScene(System.Object)

#### [](#Sandbox_Game_Entities_MyBatteryBlock_OnEnabledChanged)OnEnabledChanged()

##### Declaration

```
protected override void OnEnabledChanged()
```

##### Overrides

Sandbox.Game.Entities.Cube.MyFunctionalBlock.OnEnabledChanged()

#### [](#Sandbox_Game_Entities_MyBatteryBlock_OnModelChange)OnModelChange()

##### Declaration

```
public override void OnModelChange()
```

##### Overrides

Sandbox.Game.Entities.Cube.MyFunctionalBlock.OnModelChange()

#### [](#Sandbox_Game_Entities_MyBatteryBlock_SetEmissiveStateDamaged)SetEmissiveStateDamaged()

##### Declaration

```
public override bool SetEmissiveStateDamaged()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Overrides

#### [](#Sandbox_Game_Entities_MyBatteryBlock_SetEmissiveStateDisabled)SetEmissiveStateDisabled()

##### Declaration

```
public override bool SetEmissiveStateDisabled()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Overrides

#### [](#Sandbox_Game_Entities_MyBatteryBlock_SetEmissiveStateWorking)SetEmissiveStateWorking()

##### Declaration

```
public override bool SetEmissiveStateWorking()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Overrides

#### [](#Sandbox_Game_Entities_MyBatteryBlock_UpdateAfterSimulation100)UpdateAfterSimulation100()

##### Declaration

```
public override void UpdateAfterSimulation100()
```

##### Overrides

Sandbox.Game.Entities.Cube.MyFunctionalBlock.UpdateAfterSimulation100()

#### [](#Sandbox_Game_Entities_MyBatteryBlock_UpdateDetailedInfo_System_Text_StringBuilder_)UpdateDetailedInfo(StringBuilder)

##### Declaration

```
protected override void UpdateDetailedInfo(StringBuilder detailedInfo)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Text.StringBuilder | detailedInfo |     |

##### Overrides

Sandbox.Game.Entities.Cube.MyTerminalBlock.UpdateDetailedInfo(System.Text.StringBuilder)

#### [](#Sandbox_Game_Entities_MyBatteryBlock_UpdateVisual)UpdateVisual()

##### Declaration

```
public override void UpdateVisual()
```

##### Overrides

### [](#events)Events

#### [](#Sandbox_Game_Entities_MyBatteryBlock_CurrentOutputRatioChanged)CurrentOutputRatioChanged

##### Declaration

```
public event Action<IMyPowerProducer, float, float> CurrentOutputRatioChanged
```

##### Event Type

### [](#eii)Explicit Interface Implementations

#### [](#Sandbox_Game_Entities_MyBatteryBlock_Sandbox_ModAPI_IMyStoredPowerRatio_StoredPowerRatioChanged)IMyStoredPowerRatio.StoredPowerRatioChanged

##### Declaration

```
event Action<IMyStoredPowerRatio, float, float> IMyStoredPowerRatio.StoredPowerRatioChanged
```

##### Returns

### [](#implements)Implements

### [](#extensionmethods)Extension Methods