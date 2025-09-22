Type

Description

System.Boolean

#### Intersect(ref RayD, out Double, out Double)

##### Declaration

```
public bool Intersect(ref RayD ray, out double tmin, out double tmax)
```

##### Parameters

Type

Name

Description

[RayD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.RayD.html)

ray

System.Double

tmin

System.Double

tmax

##### Returns

Type

Description

System.Boolean

#### Intersects(ref BoundingBox, out Boolean)

##### Declaration

```
public void Intersects(ref BoundingBox box, out bool result)
```

##### Parameters

Type

Name

Description

[BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html)

box

System.Boolean

result

#### Intersects(BoundingBoxD)

Checks whether the current BoundingBox intersects another BoundingBox.

##### Declaration

```
public bool Intersects(BoundingBoxD box)
```

##### Parameters

Type

Name

Description

[BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html)

box

The BoundingBox to check for intersection with.

##### Returns

Type

Description

System.Boolean

#### Intersects(ref BoundingBoxD)

##### Declaration

```
public bool Intersects(ref BoundingBoxD box)
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

System.Boolean

#### Intersects(ref BoundingBoxD, out Boolean)

Checks whether the current BoundingBox intersects another BoundingBox.

##### Declaration

```
public void Intersects(ref BoundingBoxD box, out bool result)
```

##### Parameters

Type

Name

Description

[BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html)

box

The BoundingBox to check for intersection with.

System.Boolean

result

\[OutAttribute\] true if the BoundingBox instances intersect; false otherwise.

#### Intersects(BoundingFrustumD)

Checks whether the current BoundingBox intersects a BoundingFrustum.

##### Declaration

```
public bool Intersects(BoundingFrustumD frustum)
```

##### Parameters

Type

Name

Description

[BoundingFrustumD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingFrustumD.html)

frustum

The BoundingFrustum to check for intersection with.

##### Returns

Type

Description

System.Boolean

#### Intersects(BoundingSphereD)

Checks whether the current BoundingBox intersects a BoundingSphere.

##### Declaration

```
public bool Intersects(BoundingSphereD sphere)
```

##### Parameters

Type

Name

Description

[BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html)

sphere

The BoundingSphere to check for intersection with.

##### Returns

Type

Description

System.Boolean

#### Intersects(ref BoundingSphereD)

##### Declaration

```
public bool Intersects(ref BoundingSphereD sphere)
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

System.Boolean

#### Intersects(ref BoundingSphereD, out Boolean)

Checks whether the current BoundingBox intersects a BoundingSphere.

##### Declaration

```
public void Intersects(ref BoundingSphereD sphere, out bool result)
```

##### Parameters

Type

Name

Description

[BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html)

sphere

The BoundingSphere to check for intersection with.

System.Boolean

result

\[OutAttribute\] true if the BoundingBox and BoundingSphere intersect; false otherwise.

#### Intersects(ref LineD)

##### Declaration

```
public bool Intersects(ref LineD line)
```

##### Parameters

Type

Name

Description

[LineD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.LineD.html)

line

##### Returns

Type

Description

System.Boolean

#### Intersects(ref LineD, out Double)

##### Declaration

```
public bool Intersects(ref LineD line, out double distance)
```

##### Parameters

Type

Name

Description

[LineD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.LineD.html)

line

System.Double

distance

##### Returns

Type

Description

System.Boolean

#### Intersects(PlaneD)

Checks whether the current BoundingBox intersects a Plane.

##### Declaration

```
public PlaneIntersectionType Intersects(PlaneD plane)
```

##### Parameters

Type

Name

Description

[PlaneD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.PlaneD.html)

plane

The Plane to check for intersection with.

##### Returns

Type

Description

[PlaneIntersectionType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.PlaneIntersectionType.html)

#### Intersects(ref PlaneD, out PlaneIntersectionType)

Checks whether the current BoundingBox intersects a Plane.

##### Declaration

```
public void Intersects(ref PlaneD plane, out PlaneIntersectionType result)
```

##### Parameters

Type

Name

Description

[PlaneD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.PlaneD.html)

plane

The Plane to check for intersection with.

[PlaneIntersectionType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.PlaneIntersectionType.html)

result

\[OutAttribute\] An enumeration indicating whether the BoundingBox intersects the Plane.

#### Intersects(Ray)

##### Declaration

```
public Nullable<double> Intersects(Ray ray)
```

##### Parameters

Type

Name

Description

[Ray](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Ray.html)

ray

##### Returns

Type

Description

System.Nullable<System.Double\>

#### Intersects(RayD)

Checks whether the current BoundingBox intersects a Ray.

##### Declaration

```
public Nullable<double> Intersects(RayD ray)
```

##### Parameters

Type

Name

Description

[RayD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.RayD.html)

ray

The Ray to check for intersection with.
