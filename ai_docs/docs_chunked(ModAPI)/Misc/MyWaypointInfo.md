---
title: "Class MyWaypointInfo"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.MyWaypointInfo.html"
category: "Misc"
namespace: "Sandbox.ModAPI.Ingame"
class: "MyWaypointInfo"
---

# Class MyWaypointInfo | Space Engineers ModAPI

Represents a GPS coordinate

##### Inheritance

System.Object

MyWaypointInfo

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public sealed class MyWaypointInfo : ValueType, IEquatable<MyWaypointInfo>
```

### Constructors

#### MyWaypointInfo(String, Double, Double, Double)

Creates a new GPS coordinate

##### Declaration

```
public MyWaypointInfo(string name, double x, double y, double z)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | name |     |
| System.Double | x   |     |
| System.Double | y   |     |
| System.Double | z   |     |

#### MyWaypointInfo(String, Vector3D)

Creates a new GPS coordinate

##### Declaration

```
public MyWaypointInfo(string name, Vector3D coords)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | name |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | coords |     |

### Fields

#### Coords

Gets the target coordinate as a [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

#### Empty

Returns an empty (undefined) GPS coordinate

##### Declaration

```
public static MyWaypointInfo Empty
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyWaypointInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.MyWaypointInfo.html) |     |

#### Name

The name of this GPS coordinate

##### Declaration

```
public readonly string Name
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

### Methods

#### Equals(MyWaypointInfo)

Determines whether this coordinate is the same as another. Uses 0.0001 as the epsilon to counter floating point inaccuracies.

##### Declaration

```
public bool Equals(MyWaypointInfo other)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyWaypointInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.MyWaypointInfo.html) | other |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Equals(MyWaypointInfo, Double)

Determines whether this coordinate is the same as another. Uses 0.0001 as the epsilon to counter floating point inaccuracies.

##### Declaration

```
public bool Equals(MyWaypointInfo other, double epsilon)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyWaypointInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.MyWaypointInfo.html) | other |     |
| System.Double | epsilon | The epsilon (tolerance) of this comparison |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Equals(Object)

Determines whether this coordinate is the same as another. Uses 0.0001 as the epsilon to counter floating point inaccuracies.

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

#### FindAll(String, List<MyWaypointInfo>)

Searches for all GPS coordinates in the given text.

##### Declaration

```
public static void FindAll(string source, List<MyWaypointInfo> gpsList)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | source |     |
| System.Collections.Generic.List<[MyWaypointInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.MyWaypointInfo.html)\> | gpsList |     |

#### GetHashCode()

Gets the hashcode of this coordinate

##### Declaration

```
public override int GetHashCode()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### IsEmpty()

Determines whether this coordinate is empty (undefined)

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ToString()

Converts this GPS coordinate to its string equivalent

##### Declaration

```
public override string ToString()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

#### TryParse(String, out MyWaypointInfo)

Attempts to parse a GPS coordinate from the given text. The text cannot contain anything but the GPS coordinate.

A GPS coordinate has the format GPS:Name:X:Y:Z:

##### Declaration

```
public static bool TryParse(string text, out MyWaypointInfo gps)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | text |     |
| [MyWaypointInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.MyWaypointInfo.html) | gps |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |