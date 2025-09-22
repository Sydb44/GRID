---
title: "Class StringSegmentIgnoreCaseComparer"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.StringSegmentIgnoreCaseComparer.html"
category: "Misc"
namespace: "VRage.Game.ModAPI.Ingame.Utilities"
class: "StringSegmentIgnoreCaseComparer"
---

# Class StringSegmentIgnoreCaseComparer | Space Engineers ModAPI

A comparer designed to compare [StringSegment](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.StringSegment.html) instances in a case insensitive manner. Use [DEFAULT](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.StringSegmentIgnoreCaseComparer.html#VRage_Game_ModAPI_Ingame_Utilities_StringSegmentIgnoreCaseComparer_DEFAULT) for a default instance

##### Inheritance

System.Object

StringSegmentIgnoreCaseComparer

###### **Namespace**: [VRage.Game.ModAPI.Ingame.Utilities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public class StringSegmentIgnoreCaseComparer : Object, IEqualityComparer<StringSegment>
```

### [](#constructors)Constructors

#### [](#VRage_Game_ModAPI_Ingame_Utilities_StringSegmentIgnoreCaseComparer__ctor)StringSegmentIgnoreCaseComparer()

##### Declaration

```
public StringSegmentIgnoreCaseComparer()
```

### [](#fields)Fields

#### [](#VRage_Game_ModAPI_Ingame_Utilities_StringSegmentIgnoreCaseComparer_DEFAULT)DEFAULT

##### Declaration

```
public static readonly StringSegmentIgnoreCaseComparer DEFAULT
```

##### Field Value

### [](#methods)Methods

#### [](#VRage_Game_ModAPI_Ingame_Utilities_StringSegmentIgnoreCaseComparer_Equals_VRage_Game_ModAPI_Ingame_Utilities_StringSegment_VRage_Game_ModAPI_Ingame_Utilities_StringSegment_)Equals(StringSegment, StringSegment)

Determines whether the specified objects are equal.

##### Declaration

```
public bool Equals(StringSegment x, StringSegment y)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [StringSegment](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.StringSegment.html) | x   | The first object of type T to compare. |
| [StringSegment](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.StringSegment.html) | y   | The second object of type T to compare. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | true if the specified objects are equal; otherwise, false. |

#### [](#VRage_Game_ModAPI_Ingame_Utilities_StringSegmentIgnoreCaseComparer_GetHashCode_VRage_Game_ModAPI_Ingame_Utilities_StringSegment_)GetHashCode(StringSegment)

Returns a hash code for the specified object.

##### Declaration

```
public int GetHashCode(StringSegment obj)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [StringSegment](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.StringSegment.html) | obj | The System.Object for which a hash code is to be returned. |

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 | A hash code for the specified object. |

##### Exceptions

| Type | Condition |
| --- | --- |
| System.ArgumentNullException | The type of `obj` is a reference type and `obj` is null. |