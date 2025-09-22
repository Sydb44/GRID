---
title: "Class MyDefinitionId"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html"
category: "Misc"
namespace: "VRage.Game"
class: "MyDefinitionId"
---

# Class MyDefinitionId | Space Engineers ModAPI

Prefer getting definition ID using object builder used to create the item. If you have automatic rifle, in its Init method create new MyDefinitionId using TypeId and SubtypeName of object builder. Do not write specific values in code, as data comes from XML and if those change, code needs to change as well.

##### Inheritance

System.Object

MyDefinitionId

###### **Namespace**: [VRage.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public sealed class MyDefinitionId : ValueType, IEquatable<MyDefinitionId>
```

### Constructors

#### MyDefinitionId(MyObjectBuilderType)

##### Declaration

```
public MyDefinitionId(MyObjectBuilderType type)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilderType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilderType.html) | type |     |

#### MyDefinitionId(MyObjectBuilderType, String)

##### Declaration

```
public MyDefinitionId(MyObjectBuilderType type, string subtypeName)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilderType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilderType.html) | type |     |
| System.String | subtypeName |     |

#### MyDefinitionId(MyObjectBuilderType, MyStringHash)

##### Declaration

```
public MyDefinitionId(MyObjectBuilderType type, MyStringHash subtypeId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilderType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilderType.html) | type |     |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) | subtypeId |     |

#### MyDefinitionId(MyRuntimeObjectBuilderId, MyStringHash)

##### Declaration

```
public MyDefinitionId(MyRuntimeObjectBuilderId type, MyStringHash subtypeId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyRuntimeObjectBuilderId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyRuntimeObjectBuilderId.html) | type |     |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) | subtypeId |     |

### Fields

#### Comparer

##### Declaration

```
public static readonly MyDefinitionId.DefinitionIdComparerType Comparer
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyDefinitionId.DefinitionIdComparerType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.DefinitionIdComparerType.html) |     |

#### SubtypeId

##### Declaration

```
public readonly MyStringHash SubtypeId
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) |     |

#### TypeId

##### Declaration

```
public readonly MyObjectBuilderType TypeId
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyObjectBuilderType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilderType.html) |     |

### Properties

#### SubtypeName

##### Declaration

```
public string SubtypeName { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

### Methods

#### DropToStringCache()

##### Declaration

```
public static void DropToStringCache()
```

#### Equals(Object)

##### Declaration

```
public override bool Equals(object obj)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | obj |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Equals(MyDefinitionId)

##### Declaration

```
public bool Equals(MyDefinitionId other)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | other |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### FromContent(MyObjectBuilder\_Base)

Creates a new definition ID from a given content.

##### Declaration

```
public static MyDefinitionId FromContent(MyObjectBuilder_Base content)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_Base](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_Base.html) | content |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) |     |

#### GetHashCode()

##### Declaration

```
public override int GetHashCode()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### GetHashCodeLong()

Safer hash code. It is unique in more situations than GetHashCode would be, but it may still require full check.

##### Declaration

```
public long GetHashCodeLong()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Int64 | 64-bit hash code. |

#### Parse(String)

Attempts to create a definition ID from a definition string, which has the form (using ores as an example) "MyObjectBuilder\_Ore/Iron". The first part must represent an existing type. If it does not, an exception will be thrown. The second (the subtype) is not enforced. See TryParse for a parsing method that does not throw an exception.

##### Declaration

```
public static MyDefinitionId Parse(string id)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | id  |     |
