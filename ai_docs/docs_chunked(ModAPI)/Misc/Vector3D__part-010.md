Description

System.Double

#### RectangularDistance(ref Vector3D, ref Vector3D)

Calculates rectangular distance (a.k.a. Manhattan distance or Chessboard distace) between two vectors.

##### Declaration

```
public static double RectangularDistance(ref Vector3D value1, ref Vector3D value2)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

value1

Source vector.

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

value2

Source vector.

##### Returns

Type

Description

System.Double

#### Reflect(Vector3D, Vector3D)

Returns the reflection of a vector off a surface that has the specified normal. Reference page contains code sample.

##### Declaration

```
public static Vector3D Reflect(Vector3D vector, Vector3D normal)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

vector

Source vector.

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

normal

Normal of the surface.

##### Returns

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### Reflect(ref Vector3D, ref Vector3D, out Vector3D)

Returns the reflection of a vector off a surface that has the specified normal. Reference page contains code sample.

##### Declaration

```
public static void Reflect(ref Vector3D vector, ref Vector3D normal, out Vector3D result)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

vector

Source vector.

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

normal

Normal of the surface.

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

result

\[OutAttribute\] The reflected vector.

#### Reject(Vector3D, Vector3D)

Returns the rejection of vector from direction, i.e. projection of vector onto the plane defined by origin and direction

##### Declaration

```
public static Vector3D Reject(Vector3D vector, Vector3D direction)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

vector

Vector which is to be rejected

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

direction

Direction from which the input vector will be rejected

##### Returns

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

Rejection of the vector from the given direction

#### Reject(ref Vector3D, ref Vector3D, out Vector3D)

Returns the rejection of vector from direction, i.e. projection of vector onto the plane defined by origin and direction

##### Declaration

```
public static void Reject(ref Vector3D vector, ref Vector3D direction, out Vector3D result)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

vector

Vector which is to be rejected

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

direction

Direction from which the input vector will be rejected

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

result

Rejection of the vector from the given direction

#### Rotate(Vector3D, Double)

##### Declaration

```
public Vector3D Rotate(Vector3D axis, double rotationInRadians)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

axis

System.Double

rotationInRadians

##### Returns

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### Rotate(Vector3D, MatrixD)

##### Declaration

```
public static Vector3D Rotate(Vector3D vector, MatrixD rotationMatrix)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

vector

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

rotationMatrix

##### Returns

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### Rotate(ref Vector3D, ref MatrixD, out Vector3D)

##### Declaration

```
public static void Rotate(ref Vector3D vector, ref MatrixD rotationMatrix, out Vector3D result)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

vector

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

rotationMatrix

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

result

#### RotateAndScale(ref Vector3D, ref MatrixD, out Vector3D)

##### Declaration

```
public static void RotateAndScale(ref Vector3D vector, ref MatrixD matrix, out Vector3D result)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

vector

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

matrix

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

result

#### Round(Vector3D)

##### Declaration

```
public static Vector3I Round(Vector3D vect3d)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

vect3d

##### Returns

Type

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)
