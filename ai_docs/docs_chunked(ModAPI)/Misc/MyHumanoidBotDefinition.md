---
title: "Class MyHumanoidBotDefinition"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyHumanoidBotDefinition.html"
category: "Misc"
namespace: "Sandbox.Definitions"
class: "MyHumanoidBotDefinition"
---

# Class MyHumanoidBotDefinition | Space Engineers ModAPI

##### Inheritance

System.Object

MyHumanoidBotDefinition

##### Inherited Members

###### **Namespace**: [Sandbox.Definitions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyDefinitionType]
public class MyHumanoidBotDefinition : MyAgentDefinition
```

### Constructors

#### MyHumanoidBotDefinition()

##### Declaration

```
public MyHumanoidBotDefinition()
```

### Fields

#### InventoryItems

##### Declaration

```
public List<MyDefinitionId> InventoryItems
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)\> |     |

#### StartingWeaponDefinitionId

##### Declaration

```
public MyDefinitionId StartingWeaponDefinitionId
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) |     |

### Methods

#### AddItems(MyCharacter)

##### Declaration

```
public override void AddItems(MyCharacter character)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| Sandbox.Game.Entities.Character.MyCharacter | character |     |

##### Overrides

#### Init(MyObjectBuilder\_DefinitionBase)

##### Declaration

```
protected override void Init(MyObjectBuilder_DefinitionBase builder)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_DefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_DefinitionBase.html) | builder |     |

##### Overrides