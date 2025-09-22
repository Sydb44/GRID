Type

Name

Description

System.String

s

System.Single

defaultValue

##### Returns

Type

Description

System.Single

#### GetHash(Double, Int32)

##### Declaration

```
public static int GetHash(double d, int hash = -2128831035)
```

##### Parameters

Type

Name

Description

System.Double

d

System.Int32

hash

##### Returns

Type

Description

System.Int32

#### GetHash(String, Int32)

##### Declaration

```
public static int GetHash(string str, int hash = -2128831035)
```

##### Parameters

Type

Name

Description

System.String

str

System.Int32

hash

##### Returns

Type

Description

System.Int32

#### GetHash(String, Int32, Int32, Int32)

##### Declaration

```
public static int GetHash(string str, int start, int length, int hash = -2128831035)
```

##### Parameters

Type

Name

Description

System.String

str

System.Int32

start

System.Int32

length

System.Int32

hash

##### Returns

Type

Description

System.Int32

#### GetHashUpperCase(String, Int32, Int32, Int32)

##### Declaration

```
public static int GetHashUpperCase(string str, int start, int length, int hash = -2128831035)
```

##### Parameters

Type

Name

Description

System.String

str

System.Int32

start

System.Int32

length

System.Int32

hash

##### Returns

Type

Description

System.Int32

#### GetInsidePolygonForSphereCollision(ref Vector3, ref MyTriangle\_Vertices)

Return true if point is inside the triangle.

##### Declaration

```
public static bool GetInsidePolygonForSphereCollision(ref Vector3 point, ref MyTriangle_Vertices triangle)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

point

VRage.MyTriangle\_Vertices

triangle

##### Returns

Type

Description

System.Boolean

#### GetInsidePolygonForSphereCollision(ref Vector3D, ref MyTriangle\_Vertices)

Return true if point is inside the triangle.

##### Declaration

```
public static bool GetInsidePolygonForSphereCollision(ref Vector3D point, ref MyTriangle_Vertices triangle)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

point

VRage.MyTriangle\_Vertices

triangle

##### Returns

Type

Description

System.Boolean

#### GetInt32FromString(String)

##### Declaration

```
public static Nullable<int> GetInt32FromString(string s)
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

System.Nullable<System.Int32\>

#### GetIntFromString(String)

##### Declaration

```
public static Nullable<int> GetIntFromString(string s)
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

System.Nullable<System.Int32\>

#### GetIntFromString(String, Int32)

##### Declaration

```
public static int GetIntFromString(string s, int defaultValue)
```

##### Parameters

Type

Name

Description

System.String

s

System.Int32

defaultValue

##### Returns

Type

Description

System.Int32

#### GetLargestDistanceToSphere(ref Vector3D, ref BoundingSphereD)

Distance between "from" and opposite side of the "sphere". Always positive.

##### Declaration

```
public static double GetLargestDistanceToSphere(ref Vector3D from, ref BoundingSphereD sphere)
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

#### GetLineBoundingBoxIntersection(ref Line, ref BoundingBox)

Calculates intersection between line and bounding box and if found, distance is returned. Otherwise null is returned.

##### Declaration

```
public static Nullable<float> GetLineBoundingBoxIntersection(ref Line line, ref BoundingBox boundingBox)
```

##### Parameters

Type

Name

Description

[Line](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Line.html)

line

[BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html)

boundingBox

##### Returns

Type

Description

System.Nullable<System.Single\>

#### GetLineTriangleIntersection(ref Line, ref MyTriangle\_Vertices)

Checks whether a ray intersects a triangleVertexes. This uses the algorithm developed by Tomas Moller and Ben Trumbore, which was published in the Journal of Graphics Tools, pitch 2, "Fast, Minimum Storage Ray-Triangle Intersection".

This method is implemented using the pass-by-reference versions of the XNA math functions. Using these overloads is generally not recommended, because they make the code less readable than the normal pass-by-value versions. This method can be called very frequently in a tight inner loop, however, so in this particular case the performance benefits from passing everything by reference outweigh the loss of readability.

##### Declaration

```
public static Nullable<float> GetLineTriangleIntersection(ref Line line, ref MyTriangle_Vertices triangle)
```

##### Parameters

Type

Name

Description

[Line](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Line.html)

line

VRage.MyTriangle\_Vertices

triangle

##### Returns

Type

Description

System.Nullable<System.Single\>

##### Declaration

```
public static int GetMaxValueFromEnum<T>()
```

##### Returns

Type

Description

System.Int32

##### Type Parameters

Name

Description

T

#### GetNormalVectorFromTriangle(ref MyTriangle\_Vertices)

##### Declaration

```
public static Vector3 GetNormalVectorFromTriangle(ref MyTriangle_Vertices inputTriangle)
```

##### Parameters

Type

Name

Description

VRage.MyTriangle\_Vertices

inputTriangle

##### Returns

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### GetOpenBoundaries(Vector3\[\], Int32\[\], List<Vector3>)

##### Declaration

```
public static void GetOpenBoundaries(Vector3[] vertices, int[] indices, List<Vector3> openBoundaries)
```
