---
title: "Class MyBlueprintClassDefinition"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyBlueprintClassDefinition.html"
category: "Misc"
namespace: "Sandbox.Definitions"
class: "MyBlueprintClassDefinition"
---

# Class MyBlueprintClassDefinition | Space Engineers ModAPI

##### Inheritance

System.Object

MyBlueprintClassDefinition

##### Inherited Members

###### **Namespace**: [Sandbox.Definitions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyDefinitionType]
public class MyBlueprintClassDefinition : MyDefinitionBase, IEnumerable<MyBlueprintDefinitionBase>, IEnumerable
```

### Constructors

#### MyBlueprintClassDefinition()

##### Declaration

```
public MyBlueprintClassDefinition()
```

### Fields

#### FocusIcon

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### HighlightIcon

##### Declaration

```
public string HighlightIcon
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### InputConstraintIcon

##### Declaration

```
public string InputConstraintIcon
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### OutputConstraintIcon

##### Declaration

```
public string OutputConstraintIcon
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### ProgressBarSoundCue

##### Declaration

```
public string ProgressBarSoundCue
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

### Methods

#### AddBlueprint(MyBlueprintDefinitionBase)

##### Declaration

```
public void AddBlueprint(MyBlueprintDefinitionBase blueprint)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyBlueprintDefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyBlueprintDefinitionBase.html) | blueprint |     |

#### ClearBlueprints()

##### Declaration

```
public void ClearBlueprints()
```

#### ContainsBlueprint(MyBlueprintDefinitionBase)

##### Declaration

```
public bool ContainsBlueprint(MyBlueprintDefinitionBase blueprint)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyBlueprintDefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyBlueprintDefinitionBase.html) | blueprint |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### GetEnumerator()

##### Declaration

```
public IEnumerator<MyBlueprintDefinitionBase> GetEnumerator()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.IEnumerator<[MyBlueprintDefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyBlueprintDefinitionBase.html)\> |     |

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