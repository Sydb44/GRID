---
title: "Class MyStringUtils"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringUtils.html"
category: "Misc"
namespace: "VRage.Utils"
class: "MyStringUtils"
---

# Class MyStringUtils | Space Engineers ModAPI

##### Inheritance

System.Object

MyStringUtils

###### **Namespace**: [VRage.Utils](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.html)

###### **Assembly**: VRage.Library.dll

##### Syntax

```
public static class MyStringUtils : Object
```

### Fields

#### CLOSED\_SQUARE\_BRACKET

##### Declaration

```
public const string CLOSED_SQUARE_BRACKET = "U+005D"
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### OPEN\_SQUARE\_BRACKET

##### Declaration

```
public const string OPEN_SQUARE_BRACKET = "U+005B"
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

### Methods

#### GetUniversalHashCode(String)

Platform agnostic hash code (same as x64 .NET Framework)

##### Declaration

```
public static int GetUniversalHashCode(this string str)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | str |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### Replace(String, String, String, StringComparison)

Same as string.Replace with string comparision support.

##### Declaration

```
public static string Replace(this string str, string oldValue, string newValue, StringComparison comparisonType)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | str |     |
| System.String | oldValue |     |
| System.String | newValue |     |
| System.StringComparison | comparisonType |     |

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

#### UpdateControlsFromNotificationFriendly(String)

Converts '\[' and '\]' UTF form to the regular characters.

##### Declaration

```
public static string UpdateControlsFromNotificationFriendly(this string text)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | text |     |

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

#### UpdateControlsFromNotificationFriendly(StringBuilder)

Converts '\[' and '\]' UTF form to the regular characters.

##### Declaration

```
public static StringBuilder UpdateControlsFromNotificationFriendly(this StringBuilder text)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Text.StringBuilder | text |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Text.StringBuilder |     |

#### UpdateControlsToNotificationFriendly(String)

Converts '\[' and '\]' into their UTF form to avoid being removed by notification processing system.

##### Declaration

```
public static string UpdateControlsToNotificationFriendly(this string text)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | text |     |

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |