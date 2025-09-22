---
title: "Class MyBuildNumbers"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyBuildNumbers.html"
category: "Misc"
namespace: "VRage.Utils"
class: "MyBuildNumbers"
---

# Class MyBuildNumbers | Space Engineers ModAPI

##### Inheritance

System.Object

MyBuildNumbers

###### **Namespace**: [VRage.Utils](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.html)

###### **Assembly**: VRage.dll

##### Syntax

```
public static class MyBuildNumbers : Object
```

### Fields

#### SEPARATOR

##### Declaration

```
public const string SEPARATOR = "_"
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

### Methods

#### ConvertBuildNumberFromIntToString(Int32)

##### Declaration

```
public static string ConvertBuildNumberFromIntToString(int buildNumberInt)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | buildNumberInt |     |

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

#### ConvertBuildNumberFromIntToString(Int32, String)

##### Declaration

```
public static string ConvertBuildNumberFromIntToString(int buildNumberInt, string separator)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | buildNumberInt |     |
| System.String | separator |     |

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

#### ConvertBuildNumberFromIntToStringFriendly(Int32, String)

##### Declaration

```
public static string ConvertBuildNumberFromIntToStringFriendly(int buildNumberInt, string separator)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | buildNumberInt |     |
| System.String | separator |     |

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

#### ConvertBuildNumberFromStringToInt(String)

##### Declaration

```
public static Nullable<int> ConvertBuildNumberFromStringToInt(string buildNumberString)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | buildNumberString |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Nullable<System.Int32\> |     |

#### GetBuildNumberFromFileName(String, String, String)

##### Declaration

```
public static Nullable<int> GetBuildNumberFromFileName(string filename, string executableFileName, string extensionName)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | filename |     |
| System.String | executableFileName |     |
| System.String | extensionName |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Nullable<System.Int32\> |     |

#### GetBuildNumberWithoutMajor(Int32)

##### Declaration

```
public static int GetBuildNumberWithoutMajor(int buildNumberInt)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | buildNumberInt |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### GetFilenameFromBuildNumber(Int32, String)

##### Declaration

```
public static string GetFilenameFromBuildNumber(int buildNumber, string executableFileName)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | buildNumber |     |
| System.String | executableFileName |     |

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

#### IsValidBuildNumber(String)

##### Declaration

```
public static bool IsValidBuildNumber(string buildNumberString)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | buildNumberString |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |