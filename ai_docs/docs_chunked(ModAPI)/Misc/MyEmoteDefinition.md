---
title: "Class MyEmoteDefinition"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyEmoteDefinition.html"
category: "Misc"
namespace: "Sandbox.Definitions"
class: "MyEmoteDefinition"
---

# Class MyEmoteDefinition | Space Engineers ModAPI

##### Inheritance

System.Object

MyEmoteDefinition

##### Inherited Members

###### **Namespace**: [Sandbox.Definitions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyDefinitionType]
public class MyEmoteDefinition : MyDefinitionBase
```

### Constructors

#### MyEmoteDefinition()

##### Declaration

```
public MyEmoteDefinition()
```

### Fields

#### Animations

##### Declaration

```
public MyObjectBuilder_EmoteDefinition.Animation[] Animations
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_EmoteDefinition.Animation](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.Definitions.MyObjectBuilder_EmoteDefinition.Animation.html)\[\] |     |

### Properties

#### AnimationId

##### Declaration

```
public MyDefinitionId AnimationId { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) |     |

#### ChatCommand

##### Declaration

```
public string ChatCommand { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### ChatCommandDescription

##### Declaration

```
public string ChatCommandDescription { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### ChatCommandName

##### Declaration

```
public string ChatCommandName { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### Overrides

##### Declaration

```
public DictionaryReader<MyDefinitionId, MyDefinitionId> Overrides { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [DictionaryReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.DictionaryReader-2.html)<[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html), [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)\> |     |

#### Priority

##### Declaration

```
public int Priority { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

### Methods

#### GetAnimationForCharacter(MyDefinitionId)

##### Declaration

```
public MyAnimationDefinition GetAnimationForCharacter(MyDefinitionId characterId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | characterId |     |

##### Returns

| Type | Description |
| --- | --- |
| VRage.Game.Definitions.Animation.MyAnimationDefinition |     |

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