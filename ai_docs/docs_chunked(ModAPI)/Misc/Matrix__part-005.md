Maximum z-value of the view volume.

##### Returns

Type

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

#### CreateOrthographic(Single, Single, Single, Single, out Matrix)

Builds an orthogonal projection matrix.

##### Declaration

```
public static void CreateOrthographic(float width, float height, float zNearPlane, float zFarPlane, out Matrix result)
```

##### Parameters

Type

Name

Description

System.Single

width

Width of the view volume.

System.Single

height

Height of the view volume.

System.Single

zNearPlane

Minimum z-value of the view volume.

System.Single

zFarPlane

Maximum z-value of the view volume.

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

result

\[OutAttribute\] The projection matrix.

#### CreateOrthographicOffCenter(Single, Single, Single, Single, Single, Single)

Builds a customized, orthogonal projection matrix.

##### Declaration

```
public static Matrix CreateOrthographicOffCenter(float left, float right, float bottom, float top, float zNearPlane, float zFarPlane)
```

##### Parameters

Type

Name

Description

System.Single

left

Minimum x-value of the view volume.

System.Single

right

Maximum x-value of the view volume.

System.Single

bottom

Minimum y-value of the view volume.

System.Single

top

Maximum y-value of the view volume.

System.Single

zNearPlane

Minimum z-value of the view volume.

System.Single

zFarPlane

Maximum z-value of the view volume.

##### Returns

Type

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

#### CreateOrthographicOffCenter(Single, Single, Single, Single, Single, Single, out Matrix)

Builds a customized, orthogonal projection matrix.

##### Declaration

```
public static void CreateOrthographicOffCenter(float left, float right, float bottom, float top, float zNearPlane, float zFarPlane, out Matrix result)
```

##### Parameters

Type

Name

Description

System.Single

left

Minimum x-value of the view volume.

System.Single

right

Maximum x-value of the view volume.

System.Single

bottom

Minimum y-value of the view volume.

System.Single

top

Maximum y-value of the view volume.

System.Single

zNearPlane

Minimum z-value of the view volume.

System.Single

zFarPlane

Maximum z-value of the view volume.

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

result

\[OutAttribute\] The projection matrix.

#### CreatePerspective(Single, Single, Single, Single)

Builds a perspective projection matrix and returns the result by value.

##### Declaration

```
public static Matrix CreatePerspective(float width, float height, float nearPlaneDistance, float farPlaneDistance)
```

##### Parameters

Type

Name

Description

System.Single

width

Width of the view volume at the near view plane.

System.Single

height

Height of the view volume at the near view plane.

System.Single

nearPlaneDistance

Distance to the near view plane.

System.Single

farPlaneDistance

Distance to the far view plane.

##### Returns

Type

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

#### CreatePerspective(Single, Single, Single, Single, out Matrix)

Builds a perspective projection matrix and returns the result by reference.

##### Declaration

```
public static void CreatePerspective(float width, float height, float nearPlaneDistance, float farPlaneDistance, out Matrix result)
```

##### Parameters

Type

Name

Description

System.Single

width

Width of the view volume at the near view plane.

System.Single

height

Height of the view volume at the near view plane.

System.Single

nearPlaneDistance

Distance to the near view plane.

System.Single

farPlaneDistance

Distance to the far view plane.

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

result

\[OutAttribute\] The projection matrix.

#### CreatePerspectiveFieldOfView(Single, Single, Single, Single)

Builds a perspective projection matrix based on a field of view and returns by value.

##### Declaration

```
public static Matrix CreatePerspectiveFieldOfView(float fieldOfView, float aspectRatio, float nearPlaneDistance, float farPlaneDistance)
```

##### Parameters

Type

Name

Description

System.Single

fieldOfView

Field of view in the y direction, in radians.

System.Single

aspectRatio

Aspect ratio, defined as view space width divided by height. To match the aspect ratio of the viewport, the property AspectRatio.

System.Single

nearPlaneDistance

Distance to the near view plane.

System.Single

farPlaneDistance

Distance to the far view plane.

##### Returns

Type

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

#### CreatePerspectiveFieldOfView(Single, Single, Single, Single, out Matrix)

Builds a perspective projection matrix based on a field of view and returns by reference.

##### Declaration

```
public static void CreatePerspectiveFieldOfView(float fieldOfView, float aspectRatio, float nearPlaneDistance, float farPlaneDistance, out Matrix result)
```

##### Parameters

Type

Name

Description

System.Single

fieldOfView

Field of view in the y direction, in radians.

System.Single

aspectRatio

Aspect ratio, defined as view space width divided by height. To match the aspect ratio of the viewport, the property AspectRatio.

System.Single

nearPlaneDistance

Distance to the near view plane.

System.Single

farPlaneDistance

Distance to the far view plane.

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

result

\[OutAttribute\] The perspective projection matrix.

#### CreatePerspectiveFovRhComplementary(Single, Single, Single, Single)

##### Declaration

```
public static Matrix CreatePerspectiveFovRhComplementary(float fieldOfView, float aspectRatio, float nearPlaneDistance, float farPlaneDistance)
```
