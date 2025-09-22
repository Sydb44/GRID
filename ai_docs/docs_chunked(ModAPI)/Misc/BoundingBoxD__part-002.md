##### Parameters

Type

Name

Description

[BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html)

sphere

The BoundingSphere to test for overlap.

##### Returns

Type

Description

[ContainmentType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.ContainmentType.html)

#### Contains(ref BoundingSphereD, out ContainmentType)

Tests whether the BoundingBox contains a BoundingSphere.

##### Declaration

```
public void Contains(ref BoundingSphereD sphere, out ContainmentType result)
```

##### Parameters

Type

Name

Description

[BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html)

sphere

The BoundingSphere to test for overlap.

[ContainmentType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.ContainmentType.html)

result

\[OutAttribute\] Enumeration indicating the extent of overlap.

#### Contains(Vector3D)

Tests whether the BoundingBox contains a point.

##### Declaration

```
public ContainmentType Contains(Vector3D point)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

point

The point to test for overlap.

##### Returns

Type

Description

[ContainmentType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.ContainmentType.html)

#### Contains(ref Vector3D, out ContainmentType)

Tests whether the BoundingBox contains a point.

##### Declaration

```
public void Contains(ref Vector3D point, out ContainmentType result)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

point

The point to test for overlap.

[ContainmentType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.ContainmentType.html)

result

\[OutAttribute\] Enumeration indicating the extent of overlap.

#### CreateFromPoints(IEnumerable<Vector3D>)

Creates the smallest BoundingBox that will contain a group of points.

##### Declaration

```
public static BoundingBoxD CreateFromPoints(IEnumerable<Vector3D> points)
```

##### Parameters

Type

Name

Description

System.Collections.Generic.IEnumerable<[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\>

points

A list of points the BoundingBox should contain.

##### Returns

Type

Description

[BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html)

#### CreateFromSphere(BoundingSphereD)

Creates the smallest BoundingBox that will contain the specified BoundingSphere.

##### Declaration

```
public static BoundingBoxD CreateFromSphere(BoundingSphereD sphere)
```

##### Parameters

Type

Name

Description

[BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html)

sphere

The BoundingSphere to contain.

##### Returns

Type

Description

[BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html)

#### CreateFromSphere(ref BoundingSphereD, out BoundingBoxD)

Creates the smallest BoundingBox that will contain the specified BoundingSphere.

##### Declaration

```
public static void CreateFromSphere(ref BoundingSphereD sphere, out BoundingBoxD result)
```

##### Parameters

Type

Name

Description

[BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html)

sphere

The BoundingSphere to contain.

[BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html)

result

\[OutAttribute\] The created BoundingBox.

#### CreateInvalid()

##### Declaration

```
public static BoundingBoxD CreateInvalid()
```

##### Returns

Type

Description

[BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html)

#### CreateMerged(BoundingBoxD, BoundingBoxD)

Creates the smallest BoundingBox that contains the two specified BoundingBox instances.

##### Declaration

```
public static BoundingBoxD CreateMerged(BoundingBoxD original, BoundingBoxD additional)
```

##### Parameters

Type

Name

Description

[BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html)

original

One of the BoundingBoxs to contain.

[BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html)

additional

One of the BoundingBoxs to contain.

##### Returns

Type

Description

[BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html)

#### CreateMerged(ref BoundingBoxD, ref BoundingBoxD, out BoundingBoxD)

Creates the smallest BoundingBox that contains the two specified BoundingBox instances.

##### Declaration

```
public static void CreateMerged(ref BoundingBoxD original, ref BoundingBoxD additional, out BoundingBoxD result)
```

##### Parameters

Type

Name

Description

[BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html)

original

One of the BoundingBox instances to contain.

[BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html)

additional

One of the BoundingBox instances to contain.

[BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html)

result

\[OutAttribute\] The created BoundingBox.

#### Distance(ref BoundingBoxD)

##### Declaration

```
public double Distance(ref BoundingBoxD other)
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

#### Distance(Vector3D)

##### Declaration

```
public double Distance(Vector3D point)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

point
