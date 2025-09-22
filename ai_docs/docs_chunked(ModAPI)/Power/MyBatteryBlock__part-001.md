---
title: "Class MyBatteryBlock"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyBatteryBlock.html"
category: "Power"
namespace: "Sandbox.Game.Entities"
class: "MyBatteryBlock"
---

# Class MyBatteryBlock | Space Engineers ModAPI

##### Inheritance

System.Object

Sandbox.Game.Entities.Cube.MySyncedBlock

Sandbox.Game.Entities.Cube.MyTerminalBlock

Sandbox.Game.Entities.Cube.MyFunctionalBlock

MyBatteryBlock

##### Implements

##### Inherited Members

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyCubeBlockType]
[MyTerminalInterface]
public class MyBatteryBlock : MyFunctionalBlock, IMyComponentOwner<MyIDModule>, IMyUpgradableBlock, IMyUpgradableBlock, IMyEventProxy, IMyEventOwner, IMySyncedEntity, IMyTieredUpdateBlock, IMyUpdateTimer, IMyTextSurfaceProvider, IMyTextSurfaceProvider, IMyMultiTextPanelComponentOwner, IMyTextPanelComponentOwner, IMyBatteryBlock, IMyPowerProducer, IMyFunctionalBlock, IMyTerminalBlock, IMyCubeBlock, IMyEntity, IMyBatteryBlock, IMyPowerProducer, IMyFunctionalBlock, IMyTerminalBlock, IMyCubeBlock, IMyEntity, IMyStoredPowerRatio
```

### [](#constructors)Constructors

#### [](#Sandbox_Game_Entities_MyBatteryBlock__ctor)MyBatteryBlock()

##### Declaration

### [](#properties)Properties

#### [](#Sandbox_Game_Entities_MyBatteryBlock_BlockDefinition)BlockDefinition

##### Declaration

```
public MyBatteryBlockDefinition BlockDefinition { get; }
```

##### Property Value

#### [](#Sandbox_Game_Entities_MyBatteryBlock_ChargeMode)ChargeMode

##### Declaration

```
public ChargeMode ChargeMode { get; set; }
```

##### Property Value

#### [](#Sandbox_Game_Entities_MyBatteryBlock_CurrentInput)CurrentInput

##### Declaration

```
public float CurrentInput { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### [](#Sandbox_Game_Entities_MyBatteryBlock_CurrentOutput)CurrentOutput

##### Declaration

```
public float CurrentOutput { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### [](#Sandbox_Game_Entities_MyBatteryBlock_CurrentOutputRatio)CurrentOutputRatio

##### Declaration

```
public float CurrentOutputRatio { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### [](#Sandbox_Game_Entities_MyBatteryBlock_CurrentStoredPower)CurrentStoredPower

##### Declaration

```
public float CurrentStoredPower { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### [](#Sandbox_Game_Entities_MyBatteryBlock_HasCapacityRemaining)HasCapacityRemaining

##### Declaration

```
public bool HasCapacityRemaining { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#Sandbox_Game_Entities_MyBatteryBlock_IsCharging)IsCharging

##### Declaration

```
public bool IsCharging { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#Sandbox_Game_Entities_MyBatteryBlock_MaxInput)MaxInput

##### Declaration

```
public float MaxInput { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### [](#Sandbox_Game_Entities_MyBatteryBlock_MaxOutput)MaxOutput

##### Declaration

```
public float MaxOutput { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### [](#Sandbox_Game_Entities_MyBatteryBlock_MaxStoredPower)MaxStoredPower

##### Declaration

```
public float MaxStoredPower { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### [](#Sandbox_Game_Entities_MyBatteryBlock_OnlyDischarge)OnlyDischarge

##### Declaration

```
public bool OnlyDischarge { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#Sandbox_Game_Entities_MyBatteryBlock_OnlyRecharge)OnlyRecharge

##### Declaration

```
public bool OnlyRecharge { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#Sandbox_Game_Entities_MyBatteryBlock_SemiautoEnabled)SemiautoEnabled

##### Declaration

```
public bool SemiautoEnabled { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#Sandbox_Game_Entities_MyBatteryBlock_SourceComp)SourceComp

##### Declaration

```
public MyResourceSourceComponent SourceComp { get; set; }
```

##### Property Value

#### [](#Sandbox_Game_Entities_MyBatteryBlock_StoredPowerRatio)StoredPowerRatio

##### Declaration

```
public float StoredPowerRatio { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### [](#Sandbox_Game_Entities_MyBatteryBlock_TimeRemaining)TimeRemaining

##### Declaration

```
public float TimeRemaining { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

### [](#methods)Methods

#### [](#Sandbox_Game_Entities_MyBatteryBlock_CheckIsWorking)CheckIsWorking()

##### Declaration

```
protected override bool CheckIsWorking()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Overrides

Sandbox.Game.Entities.Cube.MyFunctionalBlock.CheckIsWorking()

#### [](#Sandbox_Game_Entities_MyBatteryBlock_Closing)Closing()

##### Declaration

```
protected override void Closing()
```

##### Overrides

Sandbox.Game.Entities.Cube.MyFunctionalBlock.Closing()

#### [](#Sandbox_Game_Entities_MyBatteryBlock_CreateTerminalControls)CreateTerminalControls()

##### Declaration

```
protected override void CreateTerminalControls()
```

##### Overrides

Sandbox.Game.Entities.Cube.MyFunctionalBlock.CreateTerminalControls()

#### [](#Sandbox_Game_Entities_MyBatteryBlock_GetObjectBuilderCubeBlock_System_Boolean_)GetObjectBuilderCubeBlock(Boolean)
