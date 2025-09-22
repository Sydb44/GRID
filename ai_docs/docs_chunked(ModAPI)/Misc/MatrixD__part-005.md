Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

cameraPosition

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

cameraTarget

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

cameraUpVector

##### Returns

Type

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

#### CreateOrthographic(Double, Double, Double, Double)

Builds an orthogonal projection matrix.

##### Declaration

```
public static MatrixD CreateOrthographic(double width, double height, double zNearPlane, double zFarPlane)
```

##### Parameters

Type

Name

Description

System.Double

width

Width of the view volume.

System.Double

height

Height of the view volume.

System.Double

zNearPlane

Minimum z-value of the view volume.

System.Double

zFarPlane

Maximum z-value of the view volume.

##### Returns

Type

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

#### CreateOrthographic(Double, Double, Double, Double, out MatrixD)

Builds an orthogonal projection matrix.

##### Declaration

```
public static void CreateOrthographic(double width, double height, double zNearPlane, double zFarPlane, out MatrixD result)
```

##### Parameters

Type

Name

Description

System.Double

width

Width of the view volume.

System.Double

height

Height of the view volume.

System.Double

zNearPlane

Minimum z-value of the view volume.

System.Double

zFarPlane

Maximum z-value of the view volume.

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

result

\[OutAttribute\] The projection matrix.

#### CreateOrthographicOffCenter(Double, Double, Double, Double, Double, Double)

Builds a customized, orthogonal projection matrix.

##### Declaration

```
public static MatrixD CreateOrthographicOffCenter(double left, double right, double bottom, double top, double zNearPlane, double zFarPlane)
```

##### Parameters

Type

Name

Description

System.Double

left

Minimum x-value of the view volume.

System.Double

right

Maximum x-value of the view volume.

System.Double

bottom

Minimum y-value of the view volume.

System.Double

top

Maximum y-value of the view volume.

System.Double

zNearPlane

Minimum z-value of the view volume.

System.Double

zFarPlane

Maximum z-value of the view volume.

##### Returns

Type

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

#### CreateOrthographicOffCenter(Double, Double, Double, Double, Double, Double, out MatrixD)

Builds a customized, orthogonal projection matrix.

##### Declaration

```
public static void CreateOrthographicOffCenter(double left, double right, double bottom, double top, double zNearPlane, double zFarPlane, out MatrixD result)
```

##### Parameters

Type

Name

Description

System.Double

left

Minimum x-value of the view volume.

System.Double

right

Maximum x-value of the view volume.

System.Double

bottom

Minimum y-value of the view volume.

System.Double

top

Maximum y-value of the view volume.

System.Double

zNearPlane

Minimum z-value of the view volume.

System.Double

zFarPlane

Maximum z-value of the view volume.

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

result

\[OutAttribute\] The projection matrix.

#### CreatePerspective(Double, Double, Double, Double)

Builds a perspective projection matrix and returns the result by value.

##### Declaration

```
public static MatrixD CreatePerspective(double width, double height, double nearPlaneDistance, double farPlaneDistance)
```

##### Parameters

Type

Name

Description

System.Double

width

Width of the view volume at the near view plane.

System.Double

height

Height of the view volume at the near view plane.

System.Double

nearPlaneDistance

Distance to the near view plane.

System.Double

farPlaneDistance

Distance to the far view plane.

##### Returns

Type

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

#### CreatePerspective(Double, Double, Double, Double, out MatrixD)

Builds a perspective projection matrix and returns the result by reference.

##### Declaration

```
public static void CreatePerspective(double width, double height, double nearPlaneDistance, double farPlaneDistance, out MatrixD result)
```

##### Parameters

Type

Name

Description

System.Double

width

Width of the view volume at the near view plane.

System.Double

height

Height of the view volume at the near view plane.

System.Double

nearPlaneDistance

Distance to the near view plane.

System.Double

farPlaneDistance

Distance to the far view plane.

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

result

\[OutAttribute\] The projection matrix.

#### CreatePerspectiveFieldOfView(Double, Double, Double, Double)

Builds a perspective projection matrix based on a field of view and returns by value.

##### Declaration

```
public static MatrixD CreatePerspectiveFieldOfView(double fieldOfView, double aspectRatio, double nearPlaneDistance, double farPlaneDistance)
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

##### Returns

Type

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

#### CreatePerspectiveFieldOfView(Double, Double, Double, Double, out MatrixD)

Builds a perspective projection matrix based on a field of view and returns by reference.
