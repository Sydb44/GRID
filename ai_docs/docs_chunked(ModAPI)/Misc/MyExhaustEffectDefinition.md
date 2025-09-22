---
title: "Class MyExhaustEffectDefinition"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyExhaustEffectDefinition.html"
category: "Misc"
namespace: "Sandbox.Definitions"
class: "MyExhaustEffectDefinition"
---

# Class MyExhaustEffectDefinition | Space Engineers ModAPI

##### Inheritance

System.Object

MyExhaustEffectDefinition

##### Inherited Members

###### **Namespace**: [Sandbox.Definitions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyDefinitionType]
public class MyExhaustEffectDefinition : MyDefinitionBase
```

### Constructors

#### MyExhaustEffectDefinition()

##### Declaration

```
public MyExhaustEffectDefinition()
```

### Fields

#### ExhaustPipes

##### Declaration

```
public List<MyObjectBuilder_ExhaustEffectDefinition.Pipe> ExhaustPipes
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MyObjectBuilder\_ExhaustEffectDefinition.Pipe](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.Definitions.MyObjectBuilder_ExhaustEffectDefinition.Pipe.html)\> |     |

### Methods

#### GetObjectBuilder()

##### Declaration

```
public override MyObjectBuilder_DefinitionBase GetObjectBuilder()
```

##### Returns

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_DefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_DefinitionBase.html) |     |

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