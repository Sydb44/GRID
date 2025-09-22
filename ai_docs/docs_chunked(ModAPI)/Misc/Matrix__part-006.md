[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

result

\[OutAttribute\] The perspective projection matrix.

#### CreatePerspectiveFovRhComplementary(Single, Single, Single, Single)

##### Declaration

```
public static Matrix CreatePerspectiveFovRhComplementary(float fieldOfView, float aspectRatio, float nearPlaneDistance, float farPlaneDistance)
```

##### Parameters

Type

Name

Description

System.Single

fieldOfView

System.Single

aspectRatio

System.Single

nearPlaneDistance

System.Single

farPlaneDistance

##### Returns

Type

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

#### CreatePerspectiveFovRhInfinite(Single, Single, Single)

##### Declaration

```
public static Matrix CreatePerspectiveFovRhInfinite(float fieldOfView, float aspectRatio, float nearPlaneDistance)
```

##### Parameters

Type

Name

Description

System.Single

fieldOfView

System.Single

aspectRatio

System.Single

nearPlaneDistance

##### Returns

Type

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

#### CreatePerspectiveFovRhInfiniteComplementary(Single, Single, Single)

##### Declaration

```
public static Matrix CreatePerspectiveFovRhInfiniteComplementary(float fieldOfView, float aspectRatio, float nearPlaneDistance)
```

##### Parameters

Type

Name

Description

System.Single

fieldOfView

System.Single

aspectRatio

System.Single

nearPlaneDistance

##### Returns

Type

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

#### CreatePerspectiveFovRhInfiniteComplementaryInverse(Single, Single, Single)

##### Declaration

```
public static Matrix CreatePerspectiveFovRhInfiniteComplementaryInverse(float fieldOfView, float aspectRatio, float nearPlaneDistance)
```

##### Parameters

Type

Name

Description

System.Single

fieldOfView

System.Single

aspectRatio

System.Single

nearPlaneDistance

##### Returns

Type

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

#### CreatePerspectiveFovRhInfiniteInverse(Single, Single, Single)

##### Declaration

```
public static Matrix CreatePerspectiveFovRhInfiniteInverse(float fieldOfView, float aspectRatio, float nearPlaneDistance)
```

##### Parameters

Type

Name

Description

System.Single

fieldOfView

System.Single

aspectRatio

System.Single

nearPlaneDistance

##### Returns

Type

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

#### CreatePerspectiveFovRhInverse(Single, Single, Single, Single)

##### Declaration

```
public static Matrix CreatePerspectiveFovRhInverse(float fieldOfView, float aspectRatio, float nearPlaneDistance, float farPlaneDistance)
```

##### Parameters

Type

Name

Description

System.Single

fieldOfView

System.Single

aspectRatio

System.Single

nearPlaneDistance

System.Single

farPlaneDistance

##### Returns

Type

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

#### CreatePerspectiveOffCenter(Single, Single, Single, Single, Single, Single)

Builds a customized, perspective projection matrix.

##### Declaration

```
public static Matrix CreatePerspectiveOffCenter(float left, float right, float bottom, float top, float nearPlaneDistance, float farPlaneDistance)
```

##### Parameters

Type

Name

Description

System.Single

left

Minimum x-value of the view volume at the near view plane.

System.Single

right

Maximum x-value of the view volume at the near view plane.

System.Single

bottom

Minimum y-value of the view volume at the near view plane.

System.Single

top

Maximum y-value of the view volume at the near view plane.

System.Single

nearPlaneDistance

Distance to the near view plane.

System.Single

farPlaneDistance

Distance to of the far view plane.

##### Returns

Type

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

#### CreatePerspectiveOffCenter(Single, Single, Single, Single, Single, Single, out Matrix)

Builds a customized, perspective projection matrix.

##### Declaration

```
public static void CreatePerspectiveOffCenter(float left, float right, float bottom, float top, float nearPlaneDistance, float farPlaneDistance, out Matrix result)
```

##### Parameters

Type

Name

Description

System.Single

left

Minimum x-value of the view volume at the near view plane.

System.Single

right

Maximum x-value of the view volume at the near view plane.

System.Single

bottom

Minimum y-value of the view volume at the near view plane.

System.Single

top

Maximum y-value of the view volume at the near view plane.

System.Single

nearPlaneDistance

Distance to the near view plane.

System.Single

farPlaneDistance

Distance to of the far view plane.

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

result

\[OutAttribute\] The created projection matrix.

#### CreateReflection(Plane)

Creates a Matrix that reflects the coordinate system about a specified Plane.

##### Declaration

```
public static Matrix CreateReflection(Plane value)
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

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

#### CreateReflection(ref Plane, out Matrix)

Fills in an existing Matrix so that it reflects the coordinate system about a specified Plane.

##### Declaration

```
public static void CreateReflection(ref Plane value, out Matrix result)
```

##### Parameters

Type

Name

Description

[Plane](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Plane.html)

value

The Plane about which to create a reflection.

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

result

\[OutAttribute\] A Matrix that creates the reflection.
