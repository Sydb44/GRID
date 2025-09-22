[BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html)

sphere

##### Returns

Type

Description

System.Double

#### GetSmallestDistanceToSphereAlwaysPositive(ref Vector3D, ref BoundingSphereD)

##### Declaration

```
public static double GetSmallestDistanceToSphereAlwaysPositive(ref Vector3D from, ref BoundingSphereD sphere)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

from

[BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html)

sphere

##### Returns

Type

Description

System.Double

#### GetSpherePlaneIntersection(ref BoundingSphere, ref Plane, out Single)

This tells if a sphere is BEHIND, in FRONT, or INTERSECTS a plane, also it's distance

##### Declaration

```
public static MySpherePlaneIntersectionEnum GetSpherePlaneIntersection(ref BoundingSphere sphere, ref Plane plane, out float distanceFromPlaneToSphere)
```

##### Parameters

Type

Name

Description

[BoundingSphere](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphere.html)

sphere

[Plane](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Plane.html)

plane

System.Single

distanceFromPlaneToSphere

##### Returns

Type

Description

[MySpherePlaneIntersectionEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MySpherePlaneIntersectionEnum.html)

#### GetSpherePlaneIntersection(ref BoundingSphereD, ref PlaneD, out Double)

This tells if a sphere is BEHIND, in FRONT, or INTERSECTS a plane, also it's distance

##### Declaration

```
public static MySpherePlaneIntersectionEnum GetSpherePlaneIntersection(ref BoundingSphereD sphere, ref PlaneD plane, out double distanceFromPlaneToSphere)
```

##### Parameters

Type

Name

Description

[BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html)

sphere

[PlaneD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.PlaneD.html)

plane

System.Double

distanceFromPlaneToSphere

##### Returns

Type

Description

[MySpherePlaneIntersectionEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MySpherePlaneIntersectionEnum.html)

#### GetSphereTriangleIntersection(ref BoundingSphere, ref Plane, ref MyTriangle\_Vertices)

Method returns intersection point between sphere and triangle (which is defined by vertexes and plane). If no intersection found, method returns null. See below how intersection point can be calculated, because it's not so easy - for example sphere vs. triangle will hardly generate just intersection point... more like intersection area or something.

##### Declaration

```
public static Nullable<Vector3> GetSphereTriangleIntersection(ref BoundingSphere sphere, ref Plane trianglePlane, ref MyTriangle_Vertices triangle)
```

##### Parameters

Type

Name

Description

[BoundingSphere](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphere.html)

sphere

[Plane](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Plane.html)

trianglePlane

VRage.MyTriangle\_Vertices

triangle

##### Returns

Type

Description

System.Nullable<[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)\>

#### GetTransformNormalNormalized(Vector3D, ref MatrixD)

##### Declaration

```
public static Vector3D GetTransformNormalNormalized(Vector3D vec, ref MatrixD matrix)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

vec

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

matrix

##### Returns

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### GetUIntFromString(String)

##### Declaration

```
public static Nullable<uint> GetUIntFromString(string s)
```

##### Parameters

Type

Name

Description

System.String

s

##### Returns

Type

Description

System.Nullable<System.UInt32\>

#### GetUIntFromString(String, UInt32)

##### Declaration

```
public static uint GetUIntFromString(string s, uint defaultValue)
```

##### Parameters

Type

Name

Description

System.String

s

System.UInt32

defaultValue

##### Returns

Type

Description

System.UInt32

#### GetULongFromString(String)

##### Declaration

```
public static Nullable<ulong> GetULongFromString(string s)
```

##### Parameters

Type

Name

Description

System.String

s

##### Returns

Type

Description

System.Nullable<System.UInt64\>

#### GetVector3Scaled(Vector3D, Single)

##### Declaration

```
public static Vector3D GetVector3Scaled(Vector3D originalVector, float newLength)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

originalVector

System.Single

newLength

##### Returns

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### HasValidLength(Vector3)

##### Declaration

```
public static bool HasValidLength(Vector3 vec)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

vec

##### Returns

Type

Description

System.Boolean

#### HasValidLength(Vector3D)

##### Declaration

```
public static bool HasValidLength(Vector3D vec)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

vec

##### Returns

Type

Description

System.Boolean

#### Init<T>(ref T)

When location is null, creates new instance, stores it in location and returns it. When location is not null, returns it.

##### Declaration

```
public static T Init<T>(ref T location)
    where T : class, new()
```
