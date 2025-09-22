---
title: "Class MyVersion"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyVersion.html"
category: "Misc"
namespace: "VRage.Utils"
class: "MyVersion"
---

# Class MyVersion | Space Engineers ModAPI

##### Inheritance

System.Object

MyVersion

###### **Namespace**: [VRage.Utils](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.html)

###### **Assembly**: VRage.dll

##### Syntax

```
public class MyVersion : Object
```

### Constructors

#### MyVersion(Int32)

##### Declaration

```
public MyVersion(int version)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | version |     |

### Fields

#### FormattedText

##### Declaration

```
public readonly StringBuilder FormattedText
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Text.StringBuilder |     |

#### FormattedTextFriendly

##### Declaration

```
public readonly StringBuilder FormattedTextFriendly
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Text.StringBuilder |     |

#### Version

##### Declaration

```
public readonly int Version
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

### Methods

#### ToString()

##### Declaration

```
public override string ToString()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

### Operators

#### Implicit(Int32 to MyVersion)

##### Declaration

```
public static implicit operator MyVersion(int version)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | version |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyVersion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyVersion.html) |     |

#### Implicit(MyVersion to Int32)

##### Declaration

```
public static implicit operator int (MyVersion version)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyVersion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyVersion.html) | version |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### Implicit(MyVersion to Version)

##### Declaration

```
public static implicit operator Version(MyVersion version)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyVersion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyVersion.html) | version |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Version |     |