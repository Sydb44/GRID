otherVector

##### Returns

Type

Description

System.Int64

#### RectangularLength()

Calculates rectangular distance of this vector, longerpreted as a polong, from the origin.

##### Declaration

```
public long RectangularLength()
```

##### Returns

Type

Description

System.Int64

#### Round(Vector3)

##### Declaration

```
public static Vector3L Round(Vector3 value)
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

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

#### Round(ref Vector3, out Vector3L)

##### Declaration

```
public static void Round(ref Vector3 v, out Vector3L r)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

v

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

r

#### Round(Vector3D)

##### Declaration

```
public static Vector3L Round(Vector3D value)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

value

##### Returns

Type

Description

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

#### Round(ref Vector3D, out Vector3L)

##### Declaration

```
public static void Round(ref Vector3D v, out Vector3L r)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

v

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

r

#### Shift(Vector3L)

##### Declaration

```
public static Vector3L Shift(Vector3L value)
```

##### Parameters

Type

Name

Description

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

value

##### Returns

Type

Description

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

#### Sign(Vector3)

##### Declaration

```
public static Vector3L Sign(Vector3 value)
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

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

#### Sign(Vector3L)

##### Declaration

```
public static Vector3L Sign(Vector3L value)
```

##### Parameters

Type

Name

Description

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

value

##### Returns

Type

Description

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

#### ToBytes(List<Byte>)

##### Declaration

```
public void ToBytes(List<byte> result)
```

##### Parameters

Type

Name

Description

System.Collections.Generic.List<System.Byte\>

result

#### ToString()

##### Declaration

```
public override string ToString()
```

##### Returns

Type

Description

System.String

#### Transform(Vector3L, Quaternion)

##### Declaration

```
public static Vector3L Transform(Vector3L value, Quaternion rotation)
```

##### Parameters

Type

Name

Description

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

value

[Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html)

rotation

##### Returns

Type

Description

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

#### Transform(ref Vector3L, ref Matrix, out Vector3L)

Transforms a Vector3L by the given Matrix.

##### Declaration

```
public static void Transform(ref Vector3L position, ref Matrix matrix, out Vector3L result)
```

##### Parameters

Type

Name

Description

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

position

The source Vector3L.

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

matrix

The transformation Matrix.

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

result

\[OutAttribute\] The transformed vector.

#### Transform(ref Vector3L, ref Quaternion, out Vector3L)

##### Declaration

```
public static void Transform(ref Vector3L value, ref Quaternion rotation, out Vector3L result)
```

##### Parameters

Type

Name

Description

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

value

[Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html)

rotation

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

result

#### TransformNormal(ref Vector3L, ref Matrix, out Vector3L)

Transforms a vector normal by a matrix.

##### Declaration

```
public static void TransformNormal(ref Vector3L normal, ref Matrix matrix, out Vector3L result)
```

##### Parameters

Type

Name

Description

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

normal

The source vector.

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

matrix

The transformation Matrix.

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

result

\[OutAttribute\] The Vector3 resulting from the transformation.

#### Trunc(Vector3)

##### Declaration

```
public static Vector3L Trunc(Vector3 value)
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

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)
