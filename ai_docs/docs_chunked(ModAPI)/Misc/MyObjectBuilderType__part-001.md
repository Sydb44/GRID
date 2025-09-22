---
title: "Class MyObjectBuilderType"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilderType.html"
category: "Misc"
namespace: "VRage.ObjectBuilders"
class: "MyObjectBuilderType"
---

# Class MyObjectBuilderType | Space Engineers ModAPI

##### Inheritance

System.Object

MyObjectBuilderType

###### **Namespace**: [VRage.ObjectBuilders](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public sealed class MyObjectBuilderType : ValueType
```

### Constructors

#### MyObjectBuilderType(Type)

##### Declaration

```
public MyObjectBuilderType(Type type)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Type | type |     |

### Fields

#### Comparer

##### Declaration

```
public static readonly MyObjectBuilderType.ComparerType Comparer
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyObjectBuilderType.ComparerType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilderType.ComparerType.html) |     |

#### Invalid

##### Declaration

```
public static readonly MyObjectBuilderType Invalid
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyObjectBuilderType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilderType.html) |     |

#### LEGACY\_TYPE\_PREFIX

##### Declaration

```
public const string LEGACY_TYPE_PREFIX = "MyObjectBuilder_"
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

### Properties

#### IsNull

##### Declaration

```
public bool IsNull { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

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

#### Equals(MyObjectBuilderType)

##### Declaration

```
public bool Equals(MyObjectBuilderType type)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilderType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilderType.html) | type |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### GetHashCode()

##### Declaration

```
public override int GetHashCode()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### IsReady()

##### Declaration

```
public static bool IsReady()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsValidTypeName(String)

##### Declaration

```
public static bool IsValidTypeName(string value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | value |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Parse(String)

##### Declaration

```
public static MyObjectBuilderType Parse(string value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | value |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyObjectBuilderType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilderType.html) |     |

#### ParseBackwardsCompatible(String)

Can handle old values as well.

##### Declaration

```
public static MyObjectBuilderType ParseBackwardsCompatible(string value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | value |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyObjectBuilderType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilderType.html) |     |

#### RegisterFromAssembly(Assembly, Boolean)

##### Declaration

```
public static void RegisterFromAssembly(Assembly assembly, bool registerLegacyNames = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Reflection.Assembly | assembly |     |
| System.Boolean | registerLegacyNames |     |

#### ToString()

##### Declaration

```
public override string ToString()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

#### TryParse(String, out MyObjectBuilderType)

##### Declaration

```
public static bool TryParse(string value, out MyObjectBuilderType result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | value |     |
| [MyObjectBuilderType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilderType.html) | result |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### UnregisterAssemblies()

##### Declaration

```
public static void UnregisterAssemblies()
```

#### UnregisterFromAssembly(Assembly)

##### Declaration

```
public static void UnregisterFromAssembly(Assembly assembly)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Reflection.Assembly | assembly |     |

### Operators

#### Equality(Type, MyObjectBuilderType)

##### Declaration

```
public static bool operator ==(Type lhs, MyObjectBuilderType rhs)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Type | lhs |     |
| [MyObjectBuilderType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilderType.html) | rhs |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Equality(MyObjectBuilderType, Type)

##### Declaration

```
public static bool operator ==(MyObjectBuilderType lhs, Type rhs)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilderType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilderType.html) | lhs |     |
| System.Type | rhs |     |
