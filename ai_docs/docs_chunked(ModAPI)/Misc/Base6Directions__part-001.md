---
title: "Class Base6Directions"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.html"
category: "Misc"
namespace: "VRageMath"
class: "Base6Directions"
---

# Class Base6Directions | Space Engineers ModAPI

Workaround because .NET XML serializer is stupid and does not like enum inside static class

##### Inheritance

System.Object

Base6Directions

###### **Namespace**: [VRageMath](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.html)

###### **Assembly**: VRage.Math.dll

##### Syntax

```
public class Base6Directions : Object
```

### Fields

#### Directions

##### Declaration

```
public static readonly Vector3[] Directions
```

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)\[\] |     |

#### EnumDirections

Because Enum.GetValues(...) returns array of objects

##### Declaration

```
public static readonly Base6Directions.Direction[] EnumDirections
```

##### Field Value

| Type | Description |
| --- | --- |
| [Base6Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.Direction.html)\[\] |     |

#### IntDirections

##### Declaration

```
public static readonly Vector3I[] IntDirections
```

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)\[\] |     |

### Methods

#### GetAxis(Base6Directions.Direction)

##### Declaration

```
public static Base6Directions.Axis GetAxis(Base6Directions.Direction direction)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Base6Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.Direction.html) | direction |     |

##### Returns

| Type | Description |
| --- | --- |
| [Base6Directions.Axis](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.Axis.html) |     |

#### GetBaseAxisDirection(Base6Directions.Axis)

##### Declaration

```
public static Base6Directions.Direction GetBaseAxisDirection(Base6Directions.Axis axis)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Base6Directions.Axis](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.Axis.html) | axis |     |

##### Returns

| Type | Description |
| --- | --- |
| [Base6Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.Direction.html) |     |

#### GetClosestDirection(Vector3)

##### Declaration

```
public static Base6Directions.Direction GetClosestDirection(Vector3 vec)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | vec |     |

##### Returns

| Type | Description |
| --- | --- |
| [Base6Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.Direction.html) |     |

#### GetClosestDirection(ref Vector3)

##### Declaration

```
public static Base6Directions.Direction GetClosestDirection(ref Vector3 vec)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | vec |     |

##### Returns

| Type | Description |
| --- | --- |
| [Base6Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.Direction.html) |     |

#### GetCross(Base6Directions.Direction, Base6Directions.Direction)

##### Declaration

```
public static Base6Directions.Direction GetCross(Base6Directions.Direction dir1, Base6Directions.Direction dir2)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Base6Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.Direction.html) | dir1 |     |
| [Base6Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.Direction.html) | dir2 |     |

##### Returns

| Type | Description |
| --- | --- |
| [Base6Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.Direction.html) |     |

#### GetDirection(Vector3)

##### Declaration

```
public static Base6Directions.Direction GetDirection(Vector3 vec)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | vec |     |

##### Returns

| Type | Description |
| --- | --- |
| [Base6Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.Direction.html) |     |

#### GetDirection(ref Vector3)

##### Declaration

```
public static Base6Directions.Direction GetDirection(ref Vector3 vec)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | vec |     |

##### Returns

| Type | Description |
| --- | --- |
| [Base6Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.Direction.html) |     |

#### GetDirection(Vector3I)

##### Declaration

```
public static Base6Directions.Direction GetDirection(Vector3I vec)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | vec |     |

##### Returns

| Type | Description |
| --- | --- |
| [Base6Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.Direction.html) |     |

#### GetDirection(ref Vector3I)

##### Declaration

```
public static Base6Directions.Direction GetDirection(ref Vector3I vec)
```
