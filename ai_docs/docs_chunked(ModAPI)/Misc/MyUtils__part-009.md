
System.Boolean

#### Init<T>(ref T)

When location is null, creates new instance, stores it in location and returns it. When location is not null, returns it.

##### Declaration

```
public static T Init<T>(ref T location)
    where T : class, new()
```

##### Parameters

Type

Name

Description

T

location

##### Returns

Type

Description

T

##### Type Parameters

Name

Description

T

#### InterlockedMax(ref Int32, Int32)

##### Declaration

```
public static int InterlockedMax(ref int storage, int value)
```

##### Parameters

Type

Name

Description

System.Int32

storage

System.Int32

value

##### Returns

Type

Description

System.Int32

Previous value, not max!

#### InterlockedMax(ref Int64, Int64)

##### Declaration

```
public static void InterlockedMax(ref long storage, long value)
```

##### Parameters

Type

Name

Description

System.Int64

storage

System.Int64

value

#### IsEqual(Single, Single)

##### Declaration

```
public static bool IsEqual(float value1, float value2)
```

##### Parameters

Type

Name

Description

System.Single

value1

System.Single

value2

##### Returns

Type

Description

System.Boolean

#### IsEqual(Matrix, Matrix)

##### Declaration

```
public static bool IsEqual(Matrix value1, Matrix value2)
```

##### Parameters

Type

Name

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

value1

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

value2

##### Returns

Type

Description

System.Boolean

#### IsEqual(Quaternion, Quaternion)

##### Declaration

```
public static bool IsEqual(Quaternion value1, Quaternion value2)
```

##### Parameters

Type

Name

Description

[Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html)

value1

[Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html)

value2

##### Returns

Type

Description

System.Boolean

#### IsEqual(QuaternionD, QuaternionD)

##### Declaration

```
public static bool IsEqual(QuaternionD value1, QuaternionD value2)
```

##### Parameters

Type

Name

Description

[QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html)

value1

[QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html)

value2

##### Returns

Type

Description

System.Boolean

#### IsEqual(Vector2, Vector2)

##### Declaration

```
public static bool IsEqual(Vector2 value1, Vector2 value2)
```

##### Parameters

Type

Name

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

value1

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

value2

##### Returns

Type

Description

System.Boolean

#### IsEqual(Vector3, Vector3)

##### Declaration

```
public static bool IsEqual(Vector3 value1, Vector3 value2)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

value1

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

value2

##### Returns

Type

Description

System.Boolean

#### IsLineIntersectingBoundingSphere(ref LineD, ref BoundingSphereD)

Check intersection between line and bounding sphere We don't use BoundingSphere.Contains(Ray ...) because ray doesn't have an end, but line does, so we need to check if line really intersects the sphere.

##### Declaration

```
public static bool IsLineIntersectingBoundingSphere(ref LineD line, ref BoundingSphereD boundingSphere)
```

##### Parameters

Type

Name

Description

[LineD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.LineD.html)

line

[BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html)

boundingSphere

##### Returns

Type

Description

System.Boolean

#### IsValid(Double)

##### Declaration

```
public static bool IsValid(double f)
```

##### Parameters

Type

Name

Description

System.Double

f

##### Returns

Type

Description

System.Boolean

#### IsValid(Nullable<Vector3>)

##### Declaration

```
public static bool IsValid(Nullable<Vector3> vec)
```

##### Parameters

Type

Name

Description

System.Nullable<[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)\>

vec

##### Returns

Type

Description

System.Boolean

#### IsValid(Single)

##### Declaration

```
public static bool IsValid(float f)
```

##### Parameters

Type

Name

Description

System.Single

f

##### Returns

Type

Description

System.Boolean

#### IsValid(Matrix)

##### Declaration

```
public static bool IsValid(Matrix matrix)
```

##### Parameters

Type

Name

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

matrix

##### Returns

Type

Description

System.Boolean

#### IsValid(MatrixD)

##### Declaration

```
public static bool IsValid(MatrixD matrix)
```

##### Parameters

Type

Name

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

matrix

##### Returns

Type

Description

System.Boolean

#### IsValid(Quaternion)

##### Declaration

```
public static bool IsValid(Quaternion q)
```

##### Parameters

Type

Name

Description

[Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html)

q

##### Returns

Type

Description

System.Boolean

#### IsValid(Vector2)

##### Declaration

```
public static bool IsValid(Vector2 vec)
```

##### Parameters

Type

Name

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

vec

##### Returns

Type

Description

System.Boolean

#### IsValid(Vector3)

##### Declaration

```
public static bool IsValid(Vector3 vec)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

vec
