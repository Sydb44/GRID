---
title: "Class MyBotDefinition"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyBotDefinition.html"
category: "Misc"
namespace: "Sandbox.Definitions"
class: "MyBotDefinition"
---

  Class MyBotDefinition | Space Engineers ModAPI         

[Show / Hide Table of Contents](#sidetoggle)

# Class MyBotDefinition

##### Inheritance

System.Object

[MyDefinitionBase](VRage.Game.MyDefinitionBase.html)

MyBotDefinition

[MyAgentDefinition](Sandbox.Definitions.MyAgentDefinition.html)

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

###### **Namespace**: [Sandbox.Definitions](Sandbox.Definitions.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyDefinitionType]
public class MyBotDefinition : MyDefinitionBase
```

### Constructors

#### MyBotDefinition()

##### Declaration

```
public MyBotDefinition()
```

### Fields

#### BehaviorSubtype

##### Declaration

```
public string BehaviorSubtype
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### BehaviorType

##### Declaration

```
public string BehaviorType
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### BotBehaviorTree

##### Declaration

```
public MyDefinitionId BotBehaviorTree
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyDefinitionId](VRage.Game.MyDefinitionId.html) |     |

#### Commandable

##### Declaration

```
public bool Commandable
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### TypeDefinitionId

##### Declaration

```
public MyDefinitionId TypeDefinitionId
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyDefinitionId](VRage.Game.MyDefinitionId.html) |     |

### Methods

#### AddItems(MyCharacter)

##### Declaration

```
public virtual void AddItems(MyCharacter character)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| Sandbox.Game.Entities.Character.MyCharacter | character |     |

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