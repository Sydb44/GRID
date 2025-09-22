Distance to the far view plane.

##### Returns

Type

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

#### CreatePerspectiveFieldOfView(Double, Double, Double, Double, out MatrixD)

Builds a perspective projection matrix based on a field of view and returns by reference.

##### Declaration

```
public static void CreatePerspectiveFieldOfView(double fieldOfView, double aspectRatio, double nearPlaneDistance, double farPlaneDistance, out MatrixD result)
```

##### Parameters

Type

Name

Description

System.Double

fieldOfView

Field of view in the y direction, in radians.

System.Double

aspectRatio

Aspect ratio, defined as view space width divided by height. To match the aspect ratio of the viewport, the property AspectRatio.

System.Double

nearPlaneDistance

Distance to the near view plane.

System.Double

farPlaneDistance

Distance to the far view plane.

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

result

\[OutAttribute\] The perspective projection matrix.

#### CreatePerspectiveOffCenter(Double, Double, Double, Double, Double, Double)

Builds a customized, perspective projection matrix.

##### Declaration

```
public static MatrixD CreatePerspectiveOffCenter(double left, double right, double bottom, double top, double nearPlaneDistance, double farPlaneDistance)
```

##### Parameters

Type

Name

Description

System.Double

left

Minimum x-value of the view volume at the near view plane.

System.Double

right

Maximum x-value of the view volume at the near view plane.

System.Double

bottom

Minimum y-value of the view volume at the near view plane.

System.Double

top

Maximum y-value of the view volume at the near view plane.

System.Double

nearPlaneDistance

Distance to the near view plane.

System.Double

farPlaneDistance

Distance to of the far view plane.

##### Returns

Type

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

#### CreatePerspectiveOffCenter(Double, Double, Double, Double, Double, Double, out MatrixD)

Builds a customized, perspective projection matrix.

##### Declaration

```
public static void CreatePerspectiveOffCenter(double left, double right, double bottom, double top, double nearPlaneDistance, double farPlaneDistance, out MatrixD result)
```

##### Parameters

Type

Name

Description

System.Double

left

Minimum x-value of the view volume at the near view plane.

System.Double

right

Maximum x-value of the view volume at the near view plane.

System.Double

bottom

Minimum y-value of the view volume at the near view plane.

System.Double

top

Maximum y-value of the view volume at the near view plane.

System.Double

nearPlaneDistance

Distance to the near view plane.

System.Double

farPlaneDistance

Distance to of the far view plane.

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

result

\[OutAttribute\] The created projection matrix.

#### CreateReflection(Plane)

Creates a Matrix that reflects the coordinate system about a specified Plane.

##### Declaration

```
public static MatrixD CreateReflection(Plane value)
```

##### Parameters

Type

Name

Description

[Plane](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Plane.html)

value

The Plane about which to create a reflection.

##### Returns

Type

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

#### CreateReflection(ref Plane, out MatrixD)

Fills in an existing Matrix so that it reflects the coordinate system about a specified Plane.

##### Declaration

```
public static void CreateReflection(ref Plane value, out MatrixD result)
```

##### Parameters

Type

Name

Description

[Plane](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Plane.html)

value

The Plane about which to create a reflection.

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

result

\[OutAttribute\] A Matrix that creates the reflection.

#### CreateRotationX(Double)

Returns a matrix that can be used to rotate a set of vertices around the x-axis.

##### Declaration

```
public static MatrixD CreateRotationX(double radians)
```

##### Parameters

Type

Name

Description

System.Double

radians

The amount, in radians, in which to rotate around the x-axis. Note that you can use ToRadians to convert degrees to radians.

##### Returns

Type

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

#### CreateRotationX(Double, out MatrixD)

Populates data into a user-specified matrix that can be used to rotate a set of vertices around the x-axis.

##### Declaration

```
public static void CreateRotationX(double radians, out MatrixD result)
```

##### Parameters

Type

Name

Description

System.Double

radians

The amount, in radians, in which to rotate around the x-axis. Note that you can use ToRadians to convert degrees to radians.

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

result

\[OutAttribute\] The matrix in which to place the calculated data.

#### CreateRotationY(Double)

Returns a matrix that can be used to rotate a set of vertices around the y-axis.

##### Declaration

```
public static MatrixD CreateRotationY(double radians)
```

##### Parameters

Type

Name

Description

System.Double

radians

The amount, in radians, in which to rotate around the y-axis. Note that you can use ToRadians to convert degrees to radians.

##### Returns

Type

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

#### CreateRotationY(Double, out MatrixD)

Populates data into a user-specified matrix that can be used to rotate a set of vertices around the y-axis.

##### Declaration

```
public static void CreateRotationY(double radians, out MatrixD result)
```
