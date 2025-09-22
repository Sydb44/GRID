```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

point

##### Returns

Type

Description

System.Double

#### DistanceSquared(ref BoundingBoxD)

##### Declaration

```
public double DistanceSquared(ref BoundingBoxD other)
```

##### Parameters

Type

Name

Description

[BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html)

other

##### Returns

Type

Description

System.Double

#### DistanceSquared(Vector3D)

##### Declaration

```
public double DistanceSquared(Vector3D point)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

point

##### Returns

Type

Description

System.Double

#### DistanceSquared(ref Vector3D)

##### Declaration

```
public double DistanceSquared(ref Vector3D point)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

point

##### Returns

Type

Description

System.Double

#### Equals(Object)

Determines whether two instances of BoundingBox are equal.

##### Declaration

```
public override bool Equals(object obj)
```

##### Parameters

Type

Name

Description

System.Object

obj

The Object to compare with the current BoundingBox.

##### Returns

Type

Description

System.Boolean

#### Equals(BoundingBoxD)

Determines whether two instances of BoundingBox are equal.

##### Declaration

```
public bool Equals(BoundingBoxD other)
```

##### Parameters

Type

Name

Description

[BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html)

other

The BoundingBox to compare with the current BoundingBox.

##### Returns

Type

Description

System.Boolean

#### Equals(BoundingBoxD, Double)

##### Declaration

```
public bool Equals(BoundingBoxD other, double epsilon)
```

##### Parameters

Type

Name

Description

[BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html)

other

System.Double

epsilon

##### Returns

Type

Description

System.Boolean

#### GetCorner(Int32)

Gets corner of the BB by index

##### Declaration

```
public Vector3D GetCorner(int index)
```

##### Parameters

Type

Name

Description

System.Int32

index

index of the corner

##### Returns

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

corner position

#### GetCorners()

Gets an array of points that make up the corners of the BoundingBox. ALLOCATION!

##### Declaration

```
public Vector3D[] GetCorners()
```

##### Returns

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\[\]

#### GetCorners(Vector3D\[\])

Gets the array of points that make up the corners of the BoundingBox.

##### Declaration

```
public void GetCorners(Vector3D[] corners)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\[\]

corners

An existing array of at least 8 Vector3 points where the corners of the BoundingBox are written.

#### GetCornersUnsafe(Vector3D\*)

Gets the array of points that make up the corners of the BoundingBox.

##### Declaration

```
public void GetCornersUnsafe(Vector3D*corners)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\*

corners

An existing array of at least 8 Vector3 points where the corners of the BoundingBox are written.

#### GetHashCode()

Gets the hash code for this instance.

##### Declaration

```
public override int GetHashCode()
```

##### Returns

Type

Description

System.Int32

#### GetInflated(Double)

##### Declaration

```
public BoundingBoxD GetInflated(double size)
```

##### Parameters

Type

Name

Description

System.Double

size

##### Returns

Type

Description

[BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html)

#### GetInflated(Vector3)

##### Declaration

```
public BoundingBoxD GetInflated(Vector3 size)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

size

##### Returns

Type

Description

[BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html)

#### GetInflated(Vector3D)

##### Declaration

```
public BoundingBoxD GetInflated(Vector3D size)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

size

##### Returns

Type

Description

[BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html)

#### Include(BoundingBoxD)

##### Declaration

```
public BoundingBoxD Include(BoundingBoxD box)
```

##### Parameters

Type

Name

Description

[BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html)

box

##### Returns

Type

Description

[BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html)

#### Include(ref BoundingBoxD)

return expanded aabb (aabb include aabb)

##### Declaration

```
public BoundingBoxD Include(ref BoundingBoxD box)
```

##### Parameters

Type

Name

Description

[BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html)

box

##### Returns

Type

Description

[BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html)

#### Include(ref BoundingFrustumD)

##### Declaration

```
public BoundingBoxD Include(ref BoundingFrustumD frustum)
```

##### Parameters

Type

Name

Description

[BoundingFrustumD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingFrustumD.html)

frustum
