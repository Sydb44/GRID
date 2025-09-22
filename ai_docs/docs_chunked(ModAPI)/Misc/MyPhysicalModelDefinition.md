---
title: "Class MyPhysicalModelDefinition"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyPhysicalModelDefinition.html"
category: "Misc"
namespace: "Sandbox.Definitions"
class: "MyPhysicalModelDefinition"
---

# Class MyPhysicalModelDefinition | Space Engineers ModAPI

##### Inheritance

System.Object

MyPhysicalModelDefinition

##### Inherited Members

###### **Namespace**: [Sandbox.Definitions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyDefinitionType]
public class MyPhysicalModelDefinition : MyDefinitionBase
```

### Constructors

#### MyPhysicalModelDefinition()

##### Declaration

```
public MyPhysicalModelDefinition()
```

### Fields

#### Mass

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Model

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### PhysicalMaterial

##### Declaration

```
public MyPhysicalMaterialDefinition PhysicalMaterial
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyPhysicalMaterialDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyPhysicalMaterialDefinition.html) |     |

#### UseInstanceRender

##### Declaration

```
public bool UseInstanceRender
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

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