---
title: "Class MyObjectBuilder\\_GlobalEventBase"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_GlobalEventBase.html"
category: "Events"
namespace: "VRage.Game"
class: "MyObjectBuilder_GlobalEventBase"
---

# Class MyObjectBuilder\_GlobalEventBase | Space Engineers ModAPI

##### Inheritance

System.Object

MyObjectBuilder\_GlobalEventBase

##### Inherited Members

###### **Namespace**: [VRage.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
[MyObjectBuilderDefinition]
public class MyObjectBuilder_GlobalEventBase : MyObjectBuilder_Base
```

### Constructors

#### MyObjectBuilder\_GlobalEventBase()

##### Declaration

```
public MyObjectBuilder_GlobalEventBase()
```

### Fields

#### ActivationTimeMs

##### Declaration

```
public long ActivationTimeMs
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### DefinitionId

##### Declaration

```
public Nullable<SerializableDefinitionId> DefinitionId
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<[SerializableDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.SerializableDefinitionId.html)\> |     |

#### Enabled

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### EventType

##### Declaration

```
public MyGlobalEventTypeEnum EventType
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyGlobalEventTypeEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyGlobalEventTypeEnum.html) |     |

#### TargetIdentity

##### Declaration

```
public long TargetIdentity
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

### Methods

#### ShouldSerializeDefinitionId()

##### Declaration

```
public bool ShouldSerializeDefinitionId()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ShouldSerializeEventType()

##### Declaration

```
public bool ShouldSerializeEventType()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Extension Methods