---
title: "Class MyIniParseResult"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.MyIniParseResult.html"
category: "Misc"
namespace: "VRage.Game.ModAPI.Ingame.Utilities"
class: "MyIniParseResult"
---

# Class MyIniParseResult | Space Engineers ModAPI

Represents the results of a configuration parsing.

##### Inheritance

System.Object

MyIniParseResult

###### **Namespace**: [VRage.Game.ModAPI.Ingame.Utilities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public sealed class MyIniParseResult : ValueType
```

### [](#fields)Fields

#### [](#VRage_Game_ModAPI_Ingame_Utilities_MyIniParseResult_Error)Error

Gets a description of the error that occurred during parsing. Will be `null` if no error occurred.

##### Declaration

```
public readonly string Error
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

### [](#properties)Properties

#### [](#VRage_Game_ModAPI_Ingame_Utilities_MyIniParseResult_IsDefined)IsDefined

Determines if the value of this result is defined, meaning whether the [Success](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.MyIniParseResult.html#VRage_Game_ModAPI_Ingame_Utilities_MyIniParseResult_Success) actually holds any meaning.

##### Declaration

```
public bool IsDefined { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Game_ModAPI_Ingame_Utilities_MyIniParseResult_LineNo)LineNo

Gets the line number where an error occured.

##### Declaration

```
public int LineNo { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### [](#VRage_Game_ModAPI_Ingame_Utilities_MyIniParseResult_Success)Success

Determines the success of the configuration parsing.

##### Declaration

```
public bool Success { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### [](#methods)Methods

#### [](#VRage_Game_ModAPI_Ingame_Utilities_MyIniParseResult_Equals_System_Object_)Equals(Object)

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

#### [](#VRage_Game_ModAPI_Ingame_Utilities_MyIniParseResult_Equals_VRage_Game_ModAPI_Ingame_Utilities_MyIniParseResult_)Equals(MyIniParseResult)

##### Declaration

```
public bool Equals(MyIniParseResult other)
```

##### Parameters

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Game_ModAPI_Ingame_Utilities_MyIniParseResult_GetHashCode)GetHashCode()

##### Declaration

```
public override int GetHashCode()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### [](#VRage_Game_ModAPI_Ingame_Utilities_MyIniParseResult_ToString)ToString()

Generates a generic error message in the form of `Line N: Error`

##### Declaration

```
public override string ToString()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

### [](#operators)Operators

#### [](#VRage_Game_ModAPI_Ingame_Utilities_MyIniParseResult_op_Equality_VRage_Game_ModAPI_Ingame_Utilities_MyIniParseResult_VRage_Game_ModAPI_Ingame_Utilities_MyIniParseResult_)Equality(MyIniParseResult, MyIniParseResult)

##### Declaration

```
public static bool operator ==(MyIniParseResult a, MyIniParseResult b)
```

##### Parameters

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Game_ModAPI_Ingame_Utilities_MyIniParseResult_op_Inequality_VRage_Game_ModAPI_Ingame_Utilities_MyIniParseResult_VRage_Game_ModAPI_Ingame_Utilities_MyIniParseResult_)Inequality(MyIniParseResult, MyIniParseResult)

##### Declaration

```
public static bool operator !=(MyIniParseResult a, MyIniParseResult b)
```

##### Parameters

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |