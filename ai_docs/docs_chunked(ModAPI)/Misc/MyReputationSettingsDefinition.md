---
title: "Class MyReputationSettingsDefinition"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Definitions.Reputation.MyReputationSettingsDefinition.html"
category: "Misc"
namespace: "VRage.Game.Definitions.Reputation"
class: "MyReputationSettingsDefinition"
---

  Class MyReputationSettingsDefinition | Space Engineers ModAPI         

[Show / Hide Table of Contents](#sidetoggle)

# Class MyReputationSettingsDefinition

##### Inheritance

System.Object

[MyDefinitionBase](VRage.Game.MyDefinitionBase.html)

MyReputationSettingsDefinition

##### Inherited Members

[MyDefinitionBase.Id](VRage.Game.MyDefinitionBase.html#VRage_Game_MyDefinitionBase_Id)

[MyDefinitionBase.DisplayNameEnum](VRage.Game.MyDefinitionBase.html#VRage_Game_MyDefinitionBase_DisplayNameEnum)

[MyDefinitionBase.DescriptionEnum](VRage.Game.MyDefinitionBase.html#VRage_Game_MyDefinitionBase_DescriptionEnum)

[MyDefinitionBase.DisplayNameString](VRage.Game.MyDefinitionBase.html#VRage_Game_MyDefinitionBase_DisplayNameString)

[MyDefinitionBase.DescriptionString](VRage.Game.MyDefinitionBase.html#VRage_Game_MyDefinitionBase_DescriptionString)

[MyDefinitionBase.DescriptionArgs](VRage.Game.MyDefinitionBase.html#VRage_Game_MyDefinitionBase_DescriptionArgs)

[MyDefinitionBase.Icons](VRage.Game.MyDefinitionBase.html#VRage_Game_MyDefinitionBase_Icons)

[MyDefinitionBase.Enabled](VRage.Game.MyDefinitionBase.html#VRage_Game_MyDefinitionBase_Enabled)

[MyDefinitionBase.Public](VRage.Game.MyDefinitionBase.html#VRage_Game_MyDefinitionBase_Public)

[MyDefinitionBase.AvailableInSurvival](VRage.Game.MyDefinitionBase.html#VRage_Game_MyDefinitionBase_AvailableInSurvival)

[MyDefinitionBase.Context](VRage.Game.MyDefinitionBase.html#VRage_Game_MyDefinitionBase_Context)

[MyDefinitionBase.Init(MyObjectBuilder\_DefinitionBase, MyModContext)](VRage.Game.MyDefinitionBase.html#VRage_Game_MyDefinitionBase_Init_VRage_Game_MyObjectBuilder_DefinitionBase_VRage_Game_MyModContext_)

[MyDefinitionBase.Postprocess()](VRage.Game.MyDefinitionBase.html#VRage_Game_MyDefinitionBase_Postprocess)

[MyDefinitionBase.GetObjectBuilder()](VRage.Game.MyDefinitionBase.html#VRage_Game_MyDefinitionBase_GetObjectBuilder)

[MyDefinitionBase.ToString()](VRage.Game.MyDefinitionBase.html#VRage_Game_MyDefinitionBase_ToString)

[MyDefinitionBase.CheckDefinitionDLCs(String\[\])](VRage.Game.MyDefinitionBase.html#VRage_Game_MyDefinitionBase_CheckDefinitionDLCs_System_String___)

[MyDefinitionBase.DLCs](VRage.Game.MyDefinitionBase.html#VRage_Game_MyDefinitionBase_DLCs)

[MyDefinitionBase.DisplayNameText](VRage.Game.MyDefinitionBase.html#VRage_Game_MyDefinitionBase_DisplayNameText)

[MyDefinitionBase.DescriptionText](VRage.Game.MyDefinitionBase.html#VRage_Game_MyDefinitionBase_DescriptionText)

###### **Namespace**: [VRage.Game.Definitions.Reputation](VRage.Game.Definitions.Reputation.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
[MyDefinitionType]
public class MyReputationSettingsDefinition : MyDefinitionBase
```

### Constructors

#### MyReputationSettingsDefinition()

##### Declaration

```
public MyReputationSettingsDefinition()
```

### Fields

#### DamageSettings

##### Declaration

```
public MyObjectBuilder_ReputationSettingsDefinition.MyReputationDamageSettings DamageSettings
```

##### Field Value

| Type | Description |
| --- | --- |
| VRage.Game.ObjectBuilders.Definitions.Reputation.MyObjectBuilder\_ReputationSettingsDefinition.MyReputationDamageSettings |     |

#### MaxReputationGainInTime

##### Declaration

```
public int MaxReputationGainInTime
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### PirateDamageSettings

##### Declaration

```
public MyObjectBuilder_ReputationSettingsDefinition.MyReputationDamageSettings PirateDamageSettings
```

##### Field Value

| Type | Description |
| --- | --- |
| VRage.Game.ObjectBuilders.Definitions.Reputation.MyObjectBuilder\_ReputationSettingsDefinition.MyReputationDamageSettings |     |

#### ResetTimeMinForRepGain

##### Declaration

```
public int ResetTimeMinForRepGain
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

### Methods

#### Init(MyObjectBuilder\_DefinitionBase)

##### Declaration

```
protected override void Init(MyObjectBuilder_DefinitionBase builder)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_DefinitionBase](VRage.Game.MyObjectBuilder_DefinitionBase.html) | builder |     |

##### Overrides

[MyDefinitionBase.Init(MyObjectBuilder\_DefinitionBase)](VRage.Game.MyDefinitionBase.html#VRage_Game_MyDefinitionBase_Init_VRage_Game_MyObjectBuilder_DefinitionBase_)

_☀_

_☾_