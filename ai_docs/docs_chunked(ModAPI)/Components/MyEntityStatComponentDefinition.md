---
title: "Class MyEntityStatComponentDefinition"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyEntityStatComponentDefinition.html"
category: "Components"
namespace: "Sandbox.Game.EntityComponents"
class: "MyEntityStatComponentDefinition"
---

# Class MyEntityStatComponentDefinition | Space Engineers ModAPI

##### Inheritance

System.Object

MyEntityStatComponentDefinition

##### Inherited Members

###### **Namespace**: [Sandbox.Game.EntityComponents](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyDefinitionType]
public class MyEntityStatComponentDefinition : MyComponentDefinitionBase
```

### Constructors

#### MyEntityStatComponentDefinition()

##### Declaration

```
public MyEntityStatComponentDefinition()
```

### Fields

#### Scripts

##### Declaration

```
public List<string> Scripts
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<System.String\> |     |

#### Stats

##### Declaration

```
public List<MyDefinitionId> Stats
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)\> |     |

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