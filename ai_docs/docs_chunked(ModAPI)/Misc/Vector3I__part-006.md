value

[MatrixI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixI.html)

transformation

##### Returns

Type

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

#### Transform(Vector3I, Quaternion)

##### Declaration

```
public static Vector3I Transform(Vector3I value, Quaternion rotation)
```

##### Parameters

Type

Name

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

value

[Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html)

rotation

##### Returns

Type

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

#### Transform(ref Vector3I, ref Matrix, out Vector3I)

Transforms a Vector3I by the given Matrix.

##### Declaration

```
public static void Transform(ref Vector3I position, ref Matrix matrix, out Vector3I result)
```

##### Parameters

Type

Name

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

position

The source Vector3I.

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

matrix

The transformation Matrix.

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

result

\[OutAttribute\] The transformed vector.

#### Transform(ref Vector3I, ref MatrixI, out Vector3I)

##### Declaration

```
public static void Transform(ref Vector3I value, ref MatrixI matrix, out Vector3I result)
```

##### Parameters

Type

Name

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

value

[MatrixI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixI.html)

matrix

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

result

#### Transform(ref Vector3I, ref Quaternion, out Vector3I)

##### Declaration

```
public static void Transform(ref Vector3I value, ref Quaternion rotation, out Vector3I result)
```

##### Parameters

Type

Name

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

value

[Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html)

rotation

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

result

#### TransformNormal(Vector3I, ref MatrixI)

##### Declaration

```
public static Vector3I TransformNormal(Vector3I value, ref MatrixI transformation)
```

##### Parameters

Type

Name

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

value

[MatrixI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixI.html)

transformation

##### Returns

Type

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

#### TransformNormal(ref Vector3I, ref Matrix, out Vector3I)

Transforms a vector normal by a matrix.

##### Declaration

```
public static void TransformNormal(ref Vector3I normal, ref Matrix matrix, out Vector3I result)
```

##### Parameters

Type

Name

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

normal

The source vector.

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

matrix

The transformation Matrix.

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

result

\[OutAttribute\] The Vector3 resulting from the transformation.

#### TransformNormal(ref Vector3I, ref MatrixI, out Vector3I)

##### Declaration

```
public static void TransformNormal(ref Vector3I normal, ref MatrixI matrix, out Vector3I result)
```

##### Parameters

Type

Name

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

normal

[MatrixI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixI.html)

matrix

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

result

#### Trunc(Vector3)

##### Declaration

```
public static Vector3I Trunc(Vector3 value)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

value

##### Returns

Type

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

#### TryParseFromString(String, out Vector3I)

##### Declaration

```
public static bool TryParseFromString(string p, out Vector3I vec)
```

##### Parameters

Type

Name

Description

System.String

p

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

vec

##### Returns

Type

Description

System.Boolean

#### Volume()

##### Declaration

##### Returns

Type

Description

System.Int32

### Operators

#### Addition(Vector3I, Int32)

##### Declaration

```
public static Vector3I operator +(Vector3I a, int b)
```

##### Parameters

Type

Name

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

a

System.Int32

b

##### Returns

Type

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

#### Addition(Vector3I, Single)

##### Declaration

```
public static Vector3 operator +(Vector3I a, float b)
```

##### Parameters

Type

Name

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

a

System.Single

b

##### Returns

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### Addition(Vector3I, Vector3I)

##### Declaration

```
public static Vector3I operator +(Vector3I a, Vector3I b)
```
