---
title: "Class MyComponentGroupDefinition"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyComponentGroupDefinition.html"
category: "Components"
namespace: "Sandbox.Definitions"
class: "MyComponentGroupDefinition"
---

# Class MyComponentGroupDefinition | Space Engineers ModAPI

##### Inheritance

System.Object

MyComponentGroupDefinition

##### Inherited Members

###### **Namespace**: [Sandbox.Definitions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyDefinitionType]
public class MyComponentGroupDefinition : MyDefinitionBase
```

### Constructors

#### MyComponentGroupDefinition()

##### Declaration

```
public MyComponentGroupDefinition()
```

### Properties

#### IsValid

##### Declaration

```
public bool IsValid { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Methods

#### GetComponentDefinition(Int32)

##### Declaration

```
public MyComponentDefinition GetComponentDefinition(int amount)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | amount |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyComponentDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyComponentDefinition.html) |     |

#### GetComponentNumber()

##### Declaration

```
public int GetComponentNumber()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

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

#### Postprocess()

##### Declaration

```
public override void Postprocess()
```

##### Overrides

#### SetComponentDefinition(Int32, MyComponentDefinition)

##### Declaration

```
public void SetComponentDefinition(int amount, MyComponentDefinition definition)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | amount |     |
| [MyComponentDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyComponentDefinition.html) | definition |     |