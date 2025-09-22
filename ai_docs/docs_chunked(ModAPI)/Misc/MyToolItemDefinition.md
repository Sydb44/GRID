---
title: "Class MyToolItemDefinition"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyToolItemDefinition.html"
category: "Misc"
namespace: "Sandbox.Definitions"
class: "MyToolItemDefinition"
---

# Class MyToolItemDefinition | Space Engineers ModAPI

##### Inheritance

System.Object

MyToolItemDefinition

##### Inherited Members

###### **Namespace**: [Sandbox.Definitions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyDefinitionType]
public class MyToolItemDefinition : MyPhysicalItemDefinition
```

### Constructors

#### MyToolItemDefinition()

##### Declaration

```
public MyToolItemDefinition()
```

### Fields

#### HitDistance

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### PrimaryActions

##### Declaration

```
public List<MyToolActionDefinition> PrimaryActions
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MyToolActionDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyToolActionDefinition.html)\> |     |

#### SecondaryActions

##### Declaration

```
public List<MyToolActionDefinition> SecondaryActions
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MyToolActionDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyToolActionDefinition.html)\> |     |

#### VoxelMinings

##### Declaration

```
public MyVoxelMiningDefinition[] VoxelMinings
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyVoxelMiningDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyVoxelMiningDefinition.html)\[\] |     |

### Methods

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