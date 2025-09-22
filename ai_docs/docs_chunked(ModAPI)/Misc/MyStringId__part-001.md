---
title: "Class MyStringId"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html"
category: "Misc"
namespace: "VRage.Utils"
class: "MyStringId"
---

# Class MyStringId | Space Engineers ModAPI

Generates unique IDs for strings. When used as key for hash tables (Dictionary or HashSet) always pass in MyStringId.Comparer, otherwise lookups will allocate memory! Never serialize to network or disk!

IDs are created sequentially as they get requested so two IDs might be different between sessions or clients and server. You can safely use ToString() as it will not allocate.

##### Inheritance

System.Object

MyStringId

###### **Namespace**: [VRage.Utils](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.html)

###### **Assembly**: VRage.Library.dll

##### Syntax

```
public sealed class MyStringId : ValueType, IXmlSerializable
```

### Fields

#### Comparer

##### Declaration

```
public static readonly MyStringId.IdComparerType Comparer
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyStringId.IdComparerType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.IdComparerType.html) |     |

#### m\_id

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### NullOrEmpty

##### Declaration

```
public static readonly MyStringId NullOrEmpty
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html) |     |

### Properties

#### Id

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### String

##### Declaration

```
public string String { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

### Methods

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

#### Equals(MyStringId)

##### Declaration

```
public bool Equals(MyStringId id)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html) | id  |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Get(String)

##### Declaration

```
public static MyStringId Get(string str)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | str |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html) |     |

#### GetHashCode()

##### Declaration

```
public override int GetHashCode()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### GetOrCompute(String)

##### Declaration

```
public static MyStringId GetOrCompute(string str)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | str |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html) |     |

#### GetSchema()

##### Declaration

```
public XmlSchema GetSchema()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Xml.Schema.XmlSchema |     |

#### IsKnown(MyStringId)

##### Declaration

```
public static bool IsKnown(MyStringId id)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html) | id  |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ReadXml(XmlReader)

##### Declaration

```
public void ReadXml(XmlReader reader)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Xml.XmlReader | reader |     |

#### ToString()

##### Declaration

```
public override string ToString()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

#### TryGet(String)

##### Declaration

```
public static MyStringId TryGet(string str)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | str |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html) |     |

#### TryGet(String, out MyStringId)

##### Declaration

```
public static bool TryGet(string str, out MyStringId id)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | str |     |
| [MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html) | id  |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### WriteXml(XmlWriter)

##### Declaration

```
public void WriteXml(XmlWriter writer)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Xml.XmlWriter | writer |     |

### Operators

#### Equality(MyStringId, MyStringId)

##### Declaration

```
public static bool operator ==(MyStringId lhs, MyStringId rhs)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html) | lhs |     |
| [MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html) | rhs |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Explicit(MyStringId to Int32)

##### Declaration

```
public static explicit operator int (MyStringId id)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html) | id  |     |
