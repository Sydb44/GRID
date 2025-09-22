The up vector of the camera.

System.Nullable<[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)\>

cameraForwardVector

Optional forward vector of the camera.

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

result

\[OutAttribute\] The created billboard matrix.

#### CreateConstrainedBillboard(Vector3, Vector3, Vector3, Nullable<Vector3>, Nullable<Vector3>)

Creates a cylindrical billboard that rotates around a specified axis.

##### Declaration

```
public static Matrix CreateConstrainedBillboard(Vector3 objectPosition, Vector3 cameraPosition, Vector3 rotateAxis, Nullable<Vector3> cameraForwardVector, Nullable<Vector3> objectForwardVector)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

objectPosition

Position of the object the billboard will rotate around.

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

cameraPosition

Position of the camera.

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

rotateAxis

Axis to rotate the billboard around.

System.Nullable<[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)\>

cameraForwardVector

Optional forward vector of the camera.

System.Nullable<[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)\>

objectForwardVector

Optional forward vector of the object.

##### Returns

Type

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

#### CreateConstrainedBillboard(ref Vector3, ref Vector3, ref Vector3, Nullable<Vector3>, Nullable<Vector3>, out Matrix)

Creates a cylindrical billboard that rotates around a specified axis.

##### Declaration

```
public static void CreateConstrainedBillboard(ref Vector3 objectPosition, ref Vector3 cameraPosition, ref Vector3 rotateAxis, Nullable<Vector3> cameraForwardVector, Nullable<Vector3> objectForwardVector, out Matrix result)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

objectPosition

Position of the object the billboard will rotate around.

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

cameraPosition

Position of the camera.

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

rotateAxis

Axis to rotate the billboard around.

System.Nullable<[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)\>

cameraForwardVector

Optional forward vector of the camera.

System.Nullable<[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)\>

objectForwardVector

Optional forward vector of the object.

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

result

\[OutAttribute\] The created billboard matrix.

#### CreateFromAxisAngle(Vector3, Single)

Creates a new Matrix that rotates around an arbitrary vector.

##### Declaration

```
public static Matrix CreateFromAxisAngle(Vector3 axis, float angle)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

axis

The axis to rotate around.

System.Single

angle

The angle to rotate around the vector.

##### Returns

Type

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

#### CreateFromAxisAngle(ref Vector3, Single, out Matrix)

Creates a new Matrix that rotates around an arbitrary vector.

##### Declaration

```
public static void CreateFromAxisAngle(ref Vector3 axis, float angle, out Matrix result)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

axis

The axis to rotate around.

System.Single

angle

The angle to rotate around the vector.

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

result

\[OutAttribute\] The created Matrix.

#### CreateFromDir(Vector3)

##### Declaration

```
public static Matrix CreateFromDir(Vector3 dir)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

dir

##### Returns

Type

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

#### CreateFromDir(Vector3, Vector3)

##### Declaration

```
public static Matrix CreateFromDir(Vector3 dir, Vector3 suggestedUp)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

dir

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

suggestedUp

##### Returns

Type

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

#### CreateFromPerspectiveFieldOfView(ref Matrix, Single, Single)

##### Declaration

```
public static Matrix CreateFromPerspectiveFieldOfView(ref Matrix proj, float nearPlaneDistance, float farPlaneDistance)
```

##### Parameters

Type

Name

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

proj

System.Single

nearPlaneDistance

System.Single

farPlaneDistance

##### Returns

Type

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

#### CreateFromQuaternion(Quaternion)

Creates a rotation Matrix from a Quaternion.

##### Declaration

```
public static Matrix CreateFromQuaternion(Quaternion quaternion)
```

##### Parameters

Type

Name

Description

[Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html)

quaternion

Quaternion to create the Matrix from.
