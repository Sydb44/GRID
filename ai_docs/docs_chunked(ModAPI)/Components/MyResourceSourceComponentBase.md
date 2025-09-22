---
title: "Class MyResourceSourceComponentBase"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyResourceSourceComponentBase.html"
category: "Components"
namespace: "VRage.Game.Components"
class: "MyResourceSourceComponentBase"
---

# Class MyResourceSourceComponentBase | Space Engineers ModAPI

##### Inheritance

System.Object

MyResourceSourceComponentBase

##### Inherited Members

###### **Namespace**: [VRage.Game.Components](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public abstract class MyResourceSourceComponentBase : MyEntityComponentBase, IMyEntityComponentBase, IMyComponentBase
```

### Constructors

#### MyResourceSourceComponentBase()

##### Declaration

```
protected MyResourceSourceComponentBase()
```

### Methods

#### CurrentOutputByType(MyDefinitionId)

Currently used power output of the producer in MW or litres/h.

##### Declaration

```
public abstract float CurrentOutputByType(MyDefinitionId resourceTypeId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | resourceTypeId |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### DefinedOutputByType(MyDefinitionId)

Max resource output defined in definition in MW or litres/h.

##### Declaration

```
public abstract float DefinedOutputByType(MyDefinitionId resourceTypeId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | resourceTypeId |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### MaxOutputByType(MyDefinitionId)

Maximum power output of the producer in MW or litres/h.

##### Declaration

```
public abstract float MaxOutputByType(MyDefinitionId resourceTypeId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | resourceTypeId |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### ProductionEnabledByType(MyDefinitionId)

Resource production is enabled

##### Declaration

```
public abstract bool ProductionEnabledByType(MyDefinitionId resourceTypeId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | resourceTypeId |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Extension Methods