---
title: "Class MyBankingSystemDefinition"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Definitions.SessionComponents.MyBankingSystemDefinition.html"
category: "Components"
namespace: "VRage.Game.Definitions.SessionComponents"
class: "MyBankingSystemDefinition"
---

  Class MyBankingSystemDefinition | Space Engineers ModAPI         

[Show / Hide Table of Contents](#sidetoggle)

# Class MyBankingSystemDefinition

##### Inheritance

System.Object

[MyDefinitionBase](VRage.Game.MyDefinitionBase.html)

VRage.Game.Components.Session.MySessionComponentDefinition

MyBankingSystemDefinition

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

###### **Namespace**: [VRage.Game.Definitions.SessionComponents](VRage.Game.Definitions.SessionComponents.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
[MyDefinitionType]
public class MyBankingSystemDefinition : MySessionComponentDefinition
```

### Constructors

#### MyBankingSystemDefinition()

##### Declaration

```
public MyBankingSystemDefinition()
```

### Properties

#### AccountLogLen

Max account log entriee.

##### Declaration

```
public uint AccountLogLen { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.UInt32 |     |

#### CurrencyFullName

Currency full name.

##### Declaration

```
public MyStringId CurrencyFullName { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyStringId](VRage.Utils.MyStringId.html) |     |

#### CurrencyShortName

Currency short name.

##### Declaration

```
public MyStringId CurrencyShortName { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyStringId](VRage.Utils.MyStringId.html) |     |

#### PhysicalItemId

Definition id of physical item representation of the currency

##### Declaration

```
public MyDefinitionId PhysicalItemId { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyDefinitionId](VRage.Game.MyDefinitionId.html) |     |

#### StartingBalance

Starting balance when account is created.

##### Declaration

```
public long StartingBalance { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

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