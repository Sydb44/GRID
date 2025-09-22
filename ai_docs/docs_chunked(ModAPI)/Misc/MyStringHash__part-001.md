---
title: "Class MyStringHash"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html"
category: "Misc"
namespace: "VRage.Utils"
class: "MyStringHash"
---

# Class MyStringHash | Space Engineers ModAPI

Generates string hashes deterministically and crashes on collisions. When used as key for hash tables (Dictionary or HashSet) always pass in MyStringHash.Comparer, otherwise lookups will allocate memory! Can be safely used in network but never serialize to disk!

IDs are computed as hash from string so there is a risk of collisions. Use only when MyStringId is not sufficient (eg. sending over network). Because the odds of collision get higher the more hashes are in use, do not use this for generated strings and make sure hashes are computed deterministically (eg. at startup) and don't require lengthy gameplay. This way we know about any collision early and not from rare and random crash reports.

##### Inheritance

System.Object

MyStringHash

###### **Namespace**: [VRage.Utils](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.html)

###### **Assembly**: VRage.dll

##### Syntax

```
public sealed class MyStringHash : ValueType, IEquatable<MyStringHash>, IXmlSerializable
```

### Fields

#### Comparer

##### Declaration

```
public static readonly MyStringHash.HashComparerType Comparer
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyStringHash.HashComparerType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.HashComparerType.html) |     |

#### m\_hash

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### NullOrEmpty

##### Declaration

```
public static readonly MyStringHash NullOrEmpty
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) |     |

### Properties

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

#### Equals(MyStringHash)

##### Declaration

```
public bool Equals(MyStringHash id)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) | id  |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Get(String)

##### Declaration

```
public static MyStringHash Get(string str)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | str |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) |     |

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
public static MyStringHash GetOrCompute(string str)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | str |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) |     |

#### GetSchema()

##### Declaration

```
public XmlSchema GetSchema()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Xml.Schema.XmlSchema |     |

#### IsKnown(MyStringHash)

##### Declaration

```
public static bool IsKnown(MyStringHash id)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) | id  |     |

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

#### TryGet(Int32)

Think HARD before using this. Usually you should be able to use MyStringHash as it is without conversion to int.

##### Declaration

```
public static MyStringHash TryGet(int id)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | id  |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) |     |

#### TryGet(String)

##### Declaration

```
public static MyStringHash TryGet(string str)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | str |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) |     |

#### TryGet(String, out MyStringHash)

##### Declaration

```
public static bool TryGet(string str, out MyStringHash id)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | str |     |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) | id  |     |

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
