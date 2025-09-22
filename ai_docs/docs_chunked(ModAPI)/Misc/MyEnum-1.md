---
title: "Class MyEnum<T>"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Library.Utils.MyEnum-1.html"
category: "Misc"
namespace: "VRage.Library.Utils"
class: "MyEnum-1"
---

# Class MyEnum<T> | Space Engineers ModAPI

##### Inheritance

System.Object

MyEnum<T>

###### **Namespace**: [VRage.Library.Utils](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Library.Utils.html)

###### **Assembly**: VRage.Library.dll

##### Syntax

```
public static class MyEnum<T> : Object where T : struct, IComparable, IFormattable, IConvertible, ValueType
```

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

### Fields

#### UnderlyingType

##### Declaration

```
public static readonly Type UnderlyingType
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Type |     |

#### Values

##### Declaration

```
public static readonly T[] Values
```

##### Field Value

| Type | Description |
| --- | --- |
| T\[\] |     |

### Properties

#### Name

##### Declaration

```
public static string Name { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

### Methods

#### GetName(T)

##### Declaration

```
public static string GetName(T value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| T   | value |     |

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

#### GetValue(T)

##### Declaration

```
public static ulong GetValue(T value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| T   | value |     |

##### Returns

| Type | Description |
| --- | --- |
| System.UInt64 |     |

#### SetValue(UInt64)

##### Declaration

```
public static T SetValue(ulong value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.UInt64 | value |     |

##### Returns

| Type | Description |
| --- | --- |
| T   |     |