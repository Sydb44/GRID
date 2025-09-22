---
title: "Class StringSegmentComparer"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.StringSegmentComparer.html"
category: "Misc"
namespace: "VRage.Game.ModAPI.Ingame.Utilities"
class: "StringSegmentComparer"
---

# Class StringSegmentComparer | Space Engineers ModAPI

A comparer designed to compare [StringSegment](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.StringSegment.html) instances in a case sensitive manner. Use [DEFAULT](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.StringSegmentComparer.html#VRage_Game_ModAPI_Ingame_Utilities_StringSegmentComparer_DEFAULT) for a default instance

##### Inheritance

System.Object

StringSegmentComparer

###### **Namespace**: [VRage.Game.ModAPI.Ingame.Utilities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public class StringSegmentComparer : Object, IEqualityComparer<StringSegment>
```

### Constructors

#### StringSegmentComparer()

##### Declaration

```
public StringSegmentComparer()
```

### Fields

#### DEFAULT

##### Declaration

```
public static readonly StringSegmentComparer DEFAULT
```

##### Field Value

| Type | Description |
| --- | --- |
| [StringSegmentComparer](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.StringSegmentComparer.html) |     |

### Methods

#### Equals(StringSegment, StringSegment)

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

#### GetHashCode(StringSegment)

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