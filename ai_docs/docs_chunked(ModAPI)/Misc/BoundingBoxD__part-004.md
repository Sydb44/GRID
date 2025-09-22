```

##### Parameters

Type

Name

Description

[BoundingFrustumD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingFrustumD.html)

frustum

##### Returns

Type

Description

[BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html)

#### Include(BoundingSphereD)

##### Declaration

```
public BoundingBoxD Include(BoundingSphereD sphere)
```

##### Parameters

Type

Name

Description

[BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html)

sphere

##### Returns

Type

Description

[BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html)

#### Include(ref BoundingSphereD)

##### Declaration

```
public BoundingBoxD Include(ref BoundingSphereD sphere)
```

##### Parameters

Type

Name

Description

[BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html)

sphere

##### Returns

Type

Description

[BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html)

#### Include(ref LineD)

##### Declaration

```
public void Include(ref LineD line)
```

##### Parameters

Type

Name

Description

[LineD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.LineD.html)

line

#### Include(Vector3D)

##### Declaration

```
public BoundingBoxD Include(Vector3D point)
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

[BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html)

#### Include(Vector3D, Vector3D, Vector3D)

##### Declaration

```
public BoundingBoxD Include(Vector3D p0, Vector3D p1, Vector3D p2)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

p0

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

p1

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

p2

##### Returns

Type

Description

[BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html)

#### Include(ref Vector3D)

return expanded aabb (aabb include point)

##### Declaration

```
public BoundingBoxD Include(ref Vector3D point)
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

[BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html)

#### Include(ref Vector3D, ref Vector3D, ref Vector3D)

##### Declaration

```
public BoundingBoxD Include(ref Vector3D p0, ref Vector3D p1, ref Vector3D p2)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

p0

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

p1

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

p2

##### Returns

Type

Description

[BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html)

#### Inflate(Double)

##### Declaration

```
public BoundingBoxD Inflate(double size)
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

#### Inflate(Vector3D)

##### Declaration

```
public BoundingBoxD Inflate(Vector3D size)
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

#### InflateToMinimum(Double)

##### Declaration

```
public void InflateToMinimum(double minimumSize)
```

##### Parameters

Type

Name

Description

System.Double

minimumSize

#### InflateToMinimum(Vector3D)

##### Declaration

```
public void InflateToMinimum(Vector3D minimumSize)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

minimumSize

#### Intersect(BoundingBoxD)

Returns bounding box which is intersection of this and box  
Result is invalid box when there's no intersection (Min > Max)

##### Declaration

```
public BoundingBoxD Intersect(BoundingBoxD box)
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

#### Intersect(ref LineD, out Double, out Double)

##### Declaration

```
public bool Intersect(ref LineD line, out double t1, out double t2)
```

##### Parameters

Type

Name

Description

[LineD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.LineD.html)

line

System.Double

t1

System.Double

t2

##### Returns

Type

Description

System.Boolean

#### Intersect(ref LineD, out LineD)

##### Declaration

```
public bool Intersect(ref LineD line, out LineD intersectedLine)
```

##### Parameters

Type

Name

Description

[LineD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.LineD.html)

line

[LineD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.LineD.html)

intersectedLine

##### Returns

Type

Description

System.Boolean

#### Intersect(ref RayD, out Double, out Double)

##### Declaration

```
public bool Intersect(ref RayD ray, out double tmin, out double tmax)
```
