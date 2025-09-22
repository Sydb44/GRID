Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

#### CreateRotationY(Double, out MatrixD)

Populates data into a user-specified matrix that can be used to rotate a set of vertices around the y-axis.

##### Declaration

```
public static void CreateRotationY(double radians, out MatrixD result)
```

##### Parameters

Type

Name

Description

System.Double

radians

The amount, in radians, in which to rotate around the y-axis. Note that you can use ToRadians to convert degrees to radians.

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

result

\[OutAttribute\] The matrix in which to place the calculated data.

#### CreateRotationZ(Double)

Returns a matrix that can be used to rotate a set of vertices around the z-axis.

##### Declaration

```
public static MatrixD CreateRotationZ(double radians)
```

##### Parameters

Type

Name

Description

System.Double

radians

The amount, in radians, in which to rotate around the z-axis. Note that you can use ToRadians to convert degrees to radians.

##### Returns

Type

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

#### CreateRotationZ(Double, out MatrixD)

Populates data into a user-specified matrix that can be used to rotate a set of vertices around the z-axis.

##### Declaration

```
public static void CreateRotationZ(double radians, out MatrixD result)
```

##### Parameters

Type

Name

Description

System.Double

radians

The amount, in radians, in which to rotate around the z-axis. Note that you can use ToRadians to convert degrees to radians.

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

result

\[OutAttribute\] The rotation matrix.

#### CreateScale(Double)

Creates a scaling Matrix.

##### Declaration

```
public static MatrixD CreateScale(double scale)
```

##### Parameters

Type

Name

Description

System.Double

scale

Amount to scale by.

##### Returns

Type

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

#### CreateScale(Double, Double, Double)

Creates a scaling Matrix.

##### Declaration

```
public static MatrixD CreateScale(double xScale, double yScale, double zScale)
```

##### Parameters

Type

Name

Description

System.Double

xScale

Value to scale by on the x-axis.

System.Double

yScale

Value to scale by on the y-axis.

System.Double

zScale

Value to scale by on the z-axis.

##### Returns

Type

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

#### CreateScale(Double, Double, Double, out MatrixD)

Creates a scaling Matrix.

##### Declaration

```
public static void CreateScale(double xScale, double yScale, double zScale, out MatrixD result)
```

##### Parameters

Type

Name

Description

System.Double

xScale

Value to scale by on the x-axis.

System.Double

yScale

Value to scale by on the y-axis.

System.Double

zScale

Value to scale by on the z-axis.

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

result

\[OutAttribute\] The created scaling Matrix.

#### CreateScale(Double, out MatrixD)

Creates a scaling Matrix.

##### Declaration

```
public static void CreateScale(double scale, out MatrixD result)
```

##### Parameters

Type

Name

Description

System.Double

scale

Value to scale by.

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

result

\[OutAttribute\] The created scaling Matrix.

#### CreateScale(Vector3D)

Creates a scaling Matrix.

##### Declaration

```
public static MatrixD CreateScale(Vector3D scales)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

scales

Amounts to scale by on the x, y, and z axes.

##### Returns

Type

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

#### CreateScale(ref Vector3D, out MatrixD)

Creates a scaling Matrix.

##### Declaration

```
public static void CreateScale(ref Vector3D scales, out MatrixD result)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

scales

Amounts to scale by on the x, y, and z axes.

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

result

\[OutAttribute\] The created scaling Matrix.

#### CreateShadow(Vector3D, Plane)

Creates a Matrix that flattens geometry into a specified Plane as if casting a shadow from a specified light source.

##### Declaration

```
public static MatrixD CreateShadow(Vector3D lightDirection, Plane plane)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

lightDirection

A Vector3 specifying the direction from which the light that will cast the shadow is coming.

[Plane](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Plane.html)

plane

The Plane onto which the new matrix should flatten geometry so as to cast a shadow.

##### Returns

Type

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

#### CreateShadow(ref Vector3D, ref Plane, out MatrixD)

Fills in a Matrix to flatten geometry into a specified Plane as if casting a shadow from a specified light source.

##### Declaration

```
public static void CreateShadow(ref Vector3D lightDirection, ref Plane plane, out MatrixD result)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

lightDirection

A Vector3 specifying the direction from which the light that will cast the shadow is coming.

[Plane](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Plane.html)

plane

The Plane onto which the new matrix should flatten geometry so as to cast a shadow.

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

result

\[OutAttribute\] A Matrix that can be used to flatten geometry onto the specified plane from the specified direction.
