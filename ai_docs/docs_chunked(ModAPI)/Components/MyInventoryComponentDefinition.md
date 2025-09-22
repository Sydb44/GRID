---
title: "Class MyInventoryComponentDefinition"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyInventoryComponentDefinition.html"
category: "Components"
namespace: "Sandbox.Game.EntityComponents"
class: "MyInventoryComponentDefinition"
---

# Class MyInventoryComponentDefinition | Space Engineers ModAPI

##### Inheritance

System.Object

MyInventoryComponentDefinition

##### Implements

##### Inherited Members

###### **Namespace**: [Sandbox.Game.EntityComponents](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyDefinitionType]
public class MyInventoryComponentDefinition : MyComponentDefinitionBase, IMyInventoryComponentDefinition
```

### Constructors

#### MyInventoryComponentDefinition()

##### Declaration

```
public MyInventoryComponentDefinition()
```

### Fields

#### CanReceive

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### CanSend

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### InputConstraint

##### Declaration

```
public MyInventoryConstraint InputConstraint
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyInventoryConstraint](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.MyInventoryConstraint.html) |     |

#### Mass

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### MaxItemCount

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### MultiplierEnabled

##### Declaration

```
public bool MultiplierEnabled
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### RemoveEntityOnEmpty

##### Declaration

```
public bool RemoveEntityOnEmpty
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Volume

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

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

### Explicit Interface Implementations

#### IMyInventoryComponentDefinition.Volume

##### Declaration

```
float IMyInventoryComponentDefinition.Volume { get; }
```

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

### Implements