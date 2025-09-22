Description

[Plane](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Plane.html)

value

The Plane about which to create a reflection.

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

result

\[OutAttribute\] A Matrix that creates the reflection.

#### CreateRotationFromTwoVectors(ref Vector3, ref Vector3, out Matrix)

##### Declaration

```
public static void CreateRotationFromTwoVectors(ref Vector3 fromVector, ref Vector3 toVector, out Matrix resultMatrix)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

fromVector

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

toVector

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

resultMatrix

#### CreateRotationX(Single)

Returns a matrix that can be used to rotate a set of vertices around the x-axis.

##### Declaration

```
public static Matrix CreateRotationX(float radians)
```

##### Parameters

Type

Name

Description

System.Single

radians

The amount, in radians, in which to rotate around the x-axis. Note that you can use ToRadians to convert degrees to radians.

##### Returns

Type

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

#### CreateRotationX(Single, out Matrix)

Populates data into a user-specified matrix that can be used to rotate a set of vertices around the x-axis.

##### Declaration

```
public static void CreateRotationX(float radians, out Matrix result)
```

##### Parameters

Type

Name

Description

System.Single

radians

The amount, in radians, in which to rotate around the x-axis. Note that you can use ToRadians to convert degrees to radians.

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

result

\[OutAttribute\] The matrix in which to place the calculated data.

#### CreateRotationY(Single)

Returns a matrix that can be used to rotate a set of vertices around the y-axis.

##### Declaration

```
public static Matrix CreateRotationY(float radians)
```

##### Parameters

Type

Name

Description

System.Single

radians

The amount, in radians, in which to rotate around the y-axis. Note that you can use ToRadians to convert degrees to radians.

##### Returns

Type

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

#### CreateRotationY(Single, out Matrix)

Populates data into a user-specified matrix that can be used to rotate a set of vertices around the y-axis.

##### Declaration

```
public static void CreateRotationY(float radians, out Matrix result)
```

##### Parameters

Type

Name

Description

System.Single

radians

The amount, in radians, in which to rotate around the y-axis. Note that you can use ToRadians to convert degrees to radians.

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

result

\[OutAttribute\] The matrix in which to place the calculated data.

#### CreateRotationZ(Single)

Returns a matrix that can be used to rotate a set of vertices around the z-axis.

##### Declaration

```
public static Matrix CreateRotationZ(float radians)
```

##### Parameters

Type

Name

Description

System.Single

radians

The amount, in radians, in which to rotate around the z-axis. Note that you can use ToRadians to convert degrees to radians.

##### Returns

Type

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

#### CreateRotationZ(Single, out Matrix)

Populates data into a user-specified matrix that can be used to rotate a set of vertices around the z-axis.

##### Declaration

```
public static void CreateRotationZ(float radians, out Matrix result)
```

##### Parameters

Type

Name

Description

System.Single

radians

The amount, in radians, in which to rotate around the z-axis. Note that you can use ToRadians to convert degrees to radians.

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

result

\[OutAttribute\] The rotation matrix.

#### CreateScale(Single)

Creates a scaling Matrix.

##### Declaration

```
public static Matrix CreateScale(float scale)
```

##### Parameters

Type

Name

Description

System.Single

scale

Amount to scale by.

##### Returns

Type

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

#### CreateScale(Single, Single, Single)

Creates a scaling Matrix.

##### Declaration

```
public static Matrix CreateScale(float xScale, float yScale, float zScale)
```

##### Parameters

Type

Name

Description

System.Single

xScale

Value to scale by on the x-axis.

System.Single

yScale

Value to scale by on the y-axis.

System.Single

zScale

Value to scale by on the z-axis.

##### Returns

Type

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

#### CreateScale(Single, Single, Single, out Matrix)

Creates a scaling Matrix.

##### Declaration

```
public static void CreateScale(float xScale, float yScale, float zScale, out Matrix result)
```

##### Parameters

Type

Name

Description

System.Single

xScale

Value to scale by on the x-axis.

System.Single

yScale

Value to scale by on the y-axis.

System.Single

zScale

Value to scale by on the z-axis.

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

result

\[OutAttribute\] The created scaling Matrix.

#### CreateScale(Single, out Matrix)

Creates a scaling Matrix.

##### Declaration

```
public static void CreateScale(float scale, out Matrix result)
```

##### Parameters

Type

Name

Description

System.Single

scale

Value to scale by.

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

result

\[OutAttribute\] The created scaling Matrix.
