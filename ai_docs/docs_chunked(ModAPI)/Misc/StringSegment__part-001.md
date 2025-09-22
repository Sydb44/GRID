---
title: "Class StringSegment"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.StringSegment.html"
category: "Misc"
namespace: "VRage.Game.ModAPI.Ingame.Utilities"
class: "StringSegment"
---

# Class StringSegment | Space Engineers ModAPI

Represents a segment of a string.

##### Inheritance

System.Object

StringSegment

###### **Namespace**: [VRage.Game.ModAPI.Ingame.Utilities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public sealed class StringSegment : ValueType
```

### [](#constructors)Constructors

#### [](#VRage_Game_ModAPI_Ingame_Utilities_StringSegment__ctor_System_String_)StringSegment(String)

Creates a new [StringSegment](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.StringSegment.html) encompassing an entire string

##### Declaration

```
public StringSegment(string text)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | text |     |

#### [](#VRage_Game_ModAPI_Ingame_Utilities_StringSegment__ctor_System_String_System_Int32_System_Int32_)StringSegment(String, Int32, Int32)

Creates a new [StringSegment](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.StringSegment.html) for the given string area

##### Declaration

```
public StringSegment(string text, int start, int length)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | text | The original text string |
| System.Int32 | start | Where the segment starts |
| System.Int32 | length | The length of the segment |

### [](#fields)Fields

#### [](#VRage_Game_ModAPI_Ingame_Utilities_StringSegment_Length)Length

The length of the segment

##### Declaration

```
public readonly int Length
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### [](#VRage_Game_ModAPI_Ingame_Utilities_StringSegment_Start)Start

Where the segment starts

##### Declaration

```
public readonly int Start
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### [](#VRage_Game_ModAPI_Ingame_Utilities_StringSegment_Text)Text

The original text string

##### Declaration

```
public readonly string Text
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

### [](#properties)Properties

#### [](#VRage_Game_ModAPI_Ingame_Utilities_StringSegment_IsCached)IsCached

Determines whether this segment has been pre-cached in such a way that no allocation will occur when using [ToString()](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.StringSegment.html#VRage_Game_ModAPI_Ingame_Utilities_StringSegment_ToString)

##### Declaration

```
public bool IsCached { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Game_ModAPI_Ingame_Utilities_StringSegment_IsEmpty)IsEmpty

Determines whether this is an empty/undefined string segment

##### Declaration

```
public bool IsEmpty { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Game_ModAPI_Ingame_Utilities_StringSegment_Item_System_Int32_)Item\[Int32\]

Gets a character at a position relative to [Start](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.StringSegment.html#VRage_Game_ModAPI_Ingame_Utilities_StringSegment_Start).

##### Declaration

```
public char this[int i] { get; }
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | i   |     |

##### Property Value

| Type | Description |
| --- | --- |
| System.Char |     |

### [](#methods)Methods

#### [](#VRage_Game_ModAPI_Ingame_Utilities_StringSegment_Equals_System_Object_)Equals(Object)

Indicates whether this instance and a specified object are equal.

##### Declaration

```
public override bool Equals(object obj)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | obj | The object to compare with the current instance. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | true if `obj` and this instance are the same type and represent the same value; otherwise, false. |

#### [](#VRage_Game_ModAPI_Ingame_Utilities_StringSegment_Equals_System_String_)Equals(String)

Compares this string segment with the given string in a case sensitive manner.

##### Declaration

```
public bool Equals(string other)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | other |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | `true` if the string segment equals the string; `false` otherwise. |

#### [](#VRage_Game_ModAPI_Ingame_Utilities_StringSegment_Equals_VRage_Game_ModAPI_Ingame_Utilities_StringSegment_)Equals(StringSegment)

Compares this string segment with another in a case sensitive manner.

##### Declaration

```
public bool Equals(StringSegment other)
```

##### Parameters

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | `true` if the string segments are equal; `false` otherwise. |

#### [](#VRage_Game_ModAPI_Ingame_Utilities_StringSegment_EqualsIgnoreCase_System_String_)EqualsIgnoreCase(String)

Compares this string segment with the given string in a case insensitive manner.

##### Declaration

```
public bool EqualsIgnoreCase(string other)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | other |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | `true` if the string segment equals the string; `false` otherwise. |

#### [](#VRage_Game_ModAPI_Ingame_Utilities_StringSegment_EqualsIgnoreCase_VRage_Game_ModAPI_Ingame_Utilities_StringSegment_)EqualsIgnoreCase(StringSegment)

Compares this string segment with another in a case insensitive manner.
