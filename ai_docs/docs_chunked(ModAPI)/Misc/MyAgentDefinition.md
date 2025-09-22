---
title: "Class MyAgentDefinition"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyAgentDefinition.html"
category: "Misc"
namespace: "Sandbox.Definitions"
class: "MyAgentDefinition"
---

# Class MyAgentDefinition | Space Engineers ModAPI

##### Inheritance

System.Object

MyAgentDefinition

##### Inherited Members

###### **Namespace**: [Sandbox.Definitions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyDefinitionType]
public class MyAgentDefinition : MyBotDefinition
```

### Constructors

#### MyAgentDefinition()

##### Declaration

```
public MyAgentDefinition()
```

### Fields

#### AttackLength

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### AttackRadius

##### Declaration

```
public double AttackRadius
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Double |     |

#### AttackSound

##### Declaration

```
public string AttackSound
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### BotModel

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### CharacterDamage

##### Declaration

```
public int CharacterDamage
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### FactionTag

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### GridDamage

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### InventoryContainerTypeId

##### Declaration

```
public MyDefinitionId InventoryContainerTypeId
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) |     |

#### InventoryContentGenerated

##### Declaration

```
public bool InventoryContentGenerated
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### RemoveAfterDeath

##### Declaration

```
public bool RemoveAfterDeath
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### RemoveTimeMs

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### RespawnTimeMs

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### TargetCharacters

##### Declaration

```
public bool TargetCharacters
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### TargetGrids

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### TargetType

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

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