---
title: "Class BoundingBoxD"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html"
category: "Misc"
namespace: "VRageMath"
class: "BoundingBoxD"
---

# Class BoundingBoxD | Space Engineers ModAPI

Defines an axis-aligned box-shaped 3D volume.

##### Inheritance

System.Object

BoundingBoxD

###### **Namespace**: [VRageMath](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.html)

###### **Assembly**: VRage.Math.dll

##### Syntax

```
public sealed class BoundingBoxD : ValueType, IEquatable<BoundingBoxD>
```

### Constructors

#### BoundingBoxD(Vector3D, Vector3D)

Creates an instance of BoundingBox.

##### Declaration

```
public BoundingBoxD(Vector3D min, Vector3D max)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

min

The minimum point the BoundingBox includes.

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

max

The maximum point the BoundingBox includes.

### Fields

#### Comparer

##### Declaration

```
public static readonly BoundingBoxD.ComparerType Comparer
```

##### Field Value

Type

Description

[BoundingBoxD.ComparerType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.ComparerType.html)

#### Max

The maximum point the BoundingBox contains.

##### Declaration

##### Field Value

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### Min

The minimum point the BoundingBox contains.

##### Declaration

##### Field Value

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### NUMBER\_OF\_CORNERS

Number of corners of the BB

##### Declaration

```
public static readonly int NUMBER_OF_CORNERS
```

##### Field Value

Type

Description

System.Int32

### Properties

#### Center

Calculates center

##### Declaration

```
public Vector3D Center { get; }
```

##### Property Value

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### Extents

##### Declaration

```
public Vector3D Extents { get; }
```

##### Property Value

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### HalfExtents

##### Declaration

```
public Vector3D HalfExtents { get; }
```

##### Property Value

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### Matrix

Matrix of AABB, respecting center and size

##### Declaration

```
public MatrixD Matrix { get; }
```

##### Property Value

Type

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

#### Perimeter

return perimeter of edges

##### Declaration

```
public double Perimeter { get; }
```

##### Property Value

Type

Description

System.Double

#### Size

Size

##### Declaration

```
public Vector3D Size { get; }
```

##### Property Value

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### SurfaceArea

##### Declaration

```
public double SurfaceArea { get; }
```

##### Property Value

Type

Description

System.Double

#### Valid

##### Declaration

```
public bool Valid { get; }
```

##### Property Value

Type

Description

System.Boolean

#### Volume

##### Declaration

```
public double Volume { get; }
```

##### Property Value

Type

Description

System.Double

### Methods

#### AssertIsValid()

##### Declaration

```
public void AssertIsValid()
```

#### Centerize(Vector3D)

##### Declaration

```
public void Centerize(Vector3D center)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

center

#### Contains(BoundingBoxD)

Tests whether the BoundingBox contains another BoundingBox.

##### Declaration

```
public ContainmentType Contains(BoundingBoxD box)
```

##### Parameters

Type

Name

Description

[BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html)

box

The BoundingBox to test for overlap.

##### Returns

Type

Description

[ContainmentType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.ContainmentType.html)

#### Contains(ref BoundingBoxD, out ContainmentType)

Tests whether the BoundingBox contains a BoundingBox.

##### Declaration

```
public void Contains(ref BoundingBoxD box, out ContainmentType result)
```

##### Parameters

Type

Name

Description

[BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html)

box

The BoundingBox to test for overlap.

[ContainmentType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.ContainmentType.html)

result

\[OutAttribute\] Enumeration indicating the extent of overlap.

#### Contains(BoundingFrustumD)

Tests whether the BoundingBox contains a BoundingFrustum.

##### Declaration

```
public ContainmentType Contains(BoundingFrustumD frustum)
```

##### Parameters

Type

Name

Description

[BoundingFrustumD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingFrustumD.html)

frustum

The BoundingFrustum to test for overlap.

##### Returns

Type

Description

[ContainmentType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.ContainmentType.html)

#### Contains(BoundingSphereD)

Tests whether the BoundingBox contains a BoundingSphere.

##### Declaration

```
public ContainmentType Contains(BoundingSphereD sphere)
```

##### Parameters

Type

Name

Description

[BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html)

sphere

The BoundingSphere to test for overlap.
