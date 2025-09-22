---
title: "Class SerializableDefinitionId"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.SerializableDefinitionId.html"
category: "Misc"
namespace: "VRage.ObjectBuilders"
class: "SerializableDefinitionId"
---

# Class SerializableDefinitionId | Space Engineers ModAPI

##### Inheritance

System.Object

SerializableDefinitionId

###### **Namespace**: [VRage.ObjectBuilders](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public sealed class SerializableDefinitionId : ValueType
```

### Constructors

#### SerializableDefinitionId(MyObjectBuilderType, String)

##### Declaration

```
public SerializableDefinitionId(MyObjectBuilderType typeId, string subtypeName)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilderType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilderType.html) | typeId |     |
| System.String | subtypeName |     |

### Fields

#### SubtypeName

##### Declaration

```
[NoSerialize]
public string SubtypeName
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### TypeId

##### Declaration

```
[NoSerialize]
public MyObjectBuilderType TypeId
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyObjectBuilderType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilderType.html) |     |

### Properties

#### SubtypeId

##### Declaration

```
[NoSerialize]
public string SubtypeId { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### SubtypeIdAttribute

##### Declaration

```
[NoSerialize]
public string SubtypeIdAttribute { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### TypeIdString

##### Declaration

```
[NoSerialize]
public string TypeIdString { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### TypeIdStringAttribute

##### Declaration

```
[NoSerialize]
public string TypeIdStringAttribute { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

### Methods

#### IsNull()

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ShouldSerializeSubtypeId()

##### Declaration

```
public bool ShouldSerializeSubtypeId()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ShouldSerializeTypeIdString()

##### Declaration

```
public bool ShouldSerializeTypeIdString()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ToString()

##### Declaration

```
public override string ToString()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |