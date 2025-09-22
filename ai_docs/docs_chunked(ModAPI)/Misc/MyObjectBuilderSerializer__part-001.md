---
title: "Class MyObjectBuilderSerializer"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilderSerializer.html"
category: "Misc"
namespace: "VRage.ObjectBuilders"
class: "MyObjectBuilderSerializer"
---

# Class MyObjectBuilderSerializer | Space Engineers ModAPI

Mod API

##### Inheritance

System.Object

MyObjectBuilderSerializer

###### **Namespace**: [VRage.ObjectBuilders](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public class MyObjectBuilderSerializer : Object
```

### Constructors

#### MyObjectBuilderSerializer()

##### Declaration

```
public MyObjectBuilderSerializer()
```

### Methods

#### Clone(MyObjectBuilder\_Base)

##### Declaration

```
public static MyObjectBuilder_Base Clone(MyObjectBuilder_Base toClone)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_Base](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_Base.html) | toClone |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_Base](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_Base.html) |     |

#### CreateNewObject(MyObjectBuilderType)

##### Declaration

```
public static MyObjectBuilder_Base CreateNewObject(MyObjectBuilderType type)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilderType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilderType.html) | type |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_Base](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_Base.html) |     |

#### CreateNewObject(MyObjectBuilderType, String)

##### Declaration

```
public static MyObjectBuilder_Base CreateNewObject(MyObjectBuilderType type, string subtypeName)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilderType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilderType.html) | type |     |
| System.String | subtypeName |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_Base](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_Base.html) |     |

#### CreateNewObject(SerializableDefinitionId)

##### Declaration

```
public static MyObjectBuilder_Base CreateNewObject(SerializableDefinitionId id)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [SerializableDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.SerializableDefinitionId.html) | id  |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_Base](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_Base.html) |     |

#### CreateNewObject<T>()

##### Declaration

```
public static T CreateNewObject<T>()
    where T : MyObjectBuilder_Base, new()
```

##### Returns

| Type | Description |
| --- | --- |
| T   |     |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

#### CreateNewObject<T>(String)

##### Declaration

```
public static T CreateNewObject<T>(string subtypeName)
    where T : MyObjectBuilder_Base, new()
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | subtypeName |     |

##### Returns

| Type | Description |
| --- | --- |
| T   |     |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

#### DeserializePB<T>(Byte\[\], out T, out UInt64)

##### Declaration

```
public static bool DeserializePB<T>(byte[] data, out T objectBuilder, out ulong fileSize)
    where T : MyObjectBuilder_Base
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Byte\[\] | data |     |
| T   | objectBuilder |     |
| System.UInt64 | fileSize |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

#### DeserializePB<T>(String, out T)

Deserialize data by protobuf

##### Declaration

```
public static bool DeserializePB<T>(string path, out T objectBuilder)
    where T : MyObjectBuilder_Base
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | path | path |
| T   | objectBuilder | instance |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | false when fails |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   | object builder type |

#### DeserializePB<T>(String, out T, out UInt64)

Deserialize data by protobuf

##### Declaration

```
public static bool DeserializePB<T>(string path, out T objectBuilder, out ulong fileSize)
    where T : MyObjectBuilder_Base
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | path | path |
| T   | objectBuilder | instance |
| System.UInt64 | fileSize | size of the file |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | false when fails |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   | object builder type |

#### DeserializeXML(String, out MyObjectBuilder\_Base, Type)

##### Declaration

```
public static bool DeserializeXML(string path, out MyObjectBuilder_Base objectBuilder, Type builderType)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | path |     |
| [MyObjectBuilder\_Base](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_Base.html) | objectBuilder |     |
| System.Type | builderType |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### DeserializeXML<T>(Byte\[\], out T, out UInt64)
