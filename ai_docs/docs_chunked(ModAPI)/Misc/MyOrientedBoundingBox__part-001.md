---
title: "Class MyOrientedBoundingBox"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyOrientedBoundingBox.html"
category: "Misc"
namespace: "VRageMath"
class: "MyOrientedBoundingBox"
---

# Class MyOrientedBoundingBox | Space Engineers ModAPI

##### Inheritance

System.Object

MyOrientedBoundingBox

###### **Namespace**: [VRageMath](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.html)

###### **Assembly**: VRage.Math.dll

##### Syntax

```
public sealed class MyOrientedBoundingBox : ValueType, IEquatable<MyOrientedBoundingBox>
```

### Constructors

#### MyOrientedBoundingBox(ref Matrix)

Initializes a new instance of the MyOrientedBoundingBox. Scale of matrix is size of box

##### Declaration

```
public MyOrientedBoundingBox(ref Matrix matrix)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html) | matrix |     |

#### MyOrientedBoundingBox(Vector3, Vector3, Quaternion)

##### Declaration

```
public MyOrientedBoundingBox(Vector3 center, Vector3 halfExtents, Quaternion orientation)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | center |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | halfExtents |     |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | orientation |     |

### Fields

#### Center

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### CornerCount

##### Declaration

```
public const int CornerCount = 8
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### EndVertices

##### Declaration

```
public static readonly int[] EndVertices
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32\[\] |     |

#### EndXVertices

##### Declaration

```
public static readonly int[] EndXVertices
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32\[\] |     |

#### EndYVertices

##### Declaration

```
public static readonly int[] EndYVertices
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32\[\] |     |

#### EndZVertices

##### Declaration

```
public static readonly int[] EndZVertices
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32\[\] |     |

#### HalfExtent

##### Declaration

```
public Vector3 HalfExtent
```

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### Orientation

##### Declaration

```
public Quaternion Orientation
```

##### Field Value

| Type | Description |
| --- | --- |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) |     |

#### StartVertices

##### Declaration

```
public static readonly int[] StartVertices
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32\[\] |     |

#### StartXVertices

##### Declaration

```
public static readonly int[] StartXVertices
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32\[\] |     |

#### StartYVertices

##### Declaration

```
public static readonly int[] StartYVertices
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32\[\] |     |

#### StartZVertices

##### Declaration

```
public static readonly int[] StartZVertices
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32\[\] |     |

#### XNeighbourVectorsBack

##### Declaration

```
public static readonly Vector3[] XNeighbourVectorsBack
```

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)\[\] |     |

#### XNeighbourVectorsForw

##### Declaration

```
public static readonly Vector3[] XNeighbourVectorsForw
```

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)\[\] |     |

#### YNeighbourVectorsBack

##### Declaration

```
public static readonly Vector3[] YNeighbourVectorsBack
```

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)\[\] |     |

#### YNeighbourVectorsForw

##### Declaration

```
public static readonly Vector3[] YNeighbourVectorsForw
```

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)\[\] |     |

#### ZNeighbourVectorsBack

##### Declaration

```
public static readonly Vector3[] ZNeighbourVectorsBack
```

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)\[\] |     |

#### ZNeighbourVectorsForw

##### Declaration

```
public static readonly Vector3[] ZNeighbourVectorsForw
```

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)\[\] |     |

### Methods

#### Contains(ref BoundingBox)

##### Declaration

```
public ContainmentType Contains(ref BoundingBox box)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) | box |     |

##### Returns

| Type | Description |
| --- | --- |
| [ContainmentType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.ContainmentType.html) |     |

#### Contains(ref BoundingBox, ref MyOrientedBoundingBox)
