---
title: "Class LineD"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.LineD.html"
category: "Misc"
namespace: "VRageMath"
class: "LineD"
---

# Class LineD | Space Engineers ModAPI

##### Inheritance

System.Object

LineD

###### **Namespace**: [VRageMath](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.html)

###### **Assembly**: VRage.Math.dll

##### Syntax

```
public sealed class LineD : ValueType
```

### Constructors

#### LineD(Vector3D, Vector3D)

##### Declaration

```
public LineD(Vector3D from, Vector3D to)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | from |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | to  |     |

#### LineD(Vector3D, Vector3D, Double)

##### Declaration

```
public LineD(Vector3D from, Vector3D to, double lineLength)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | from |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | to  |     |
| System.Double | lineLength |     |

### Fields

#### Direction

##### Declaration

```
public Vector3D Direction
```

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

#### From

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

#### Length

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Double |     |

#### To

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

### Methods

#### GetBoundingBox()

##### Declaration

```
public BoundingBoxD GetBoundingBox()
```

##### Returns

| Type | Description |
| --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) |     |

#### GetHash()

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### GetShortestDistanceSquared(LineD, LineD)

##### Declaration

```
public static double GetShortestDistanceSquared(LineD line1, LineD line2)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [LineD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.LineD.html) | line1 |     |
| [LineD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.LineD.html) | line2 |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Double |     |

#### GetShortestVector(ref LineD, ref LineD, out Vector3D, out Vector3D)

##### Declaration

```
public static Vector3D GetShortestVector(ref LineD line1, ref LineD line2, out Vector3D res1, out Vector3D res2)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [LineD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.LineD.html) | line1 |     |
| [LineD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.LineD.html) | line2 |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | res1 |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | res2 |     |

##### Returns

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

### Operators

#### Explicit(Line to LineD)

##### Declaration

```
public static explicit operator LineD(Line b)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Line](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Line.html) | b   |     |

##### Returns

| Type | Description |
| --- | --- |
| [LineD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.LineD.html) |     |

#### Explicit(LineD to Line)

##### Declaration

```
public static explicit operator Line(LineD b)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [LineD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.LineD.html) | b   |     |

##### Returns

| Type | Description |
| --- | --- |
| [Line](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Line.html) |     |