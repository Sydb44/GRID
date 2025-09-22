The up vector of the camera.

System.Nullable<[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\>

cameraForwardVector

Optional forward vector of the camera.

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

result

\[OutAttribute\] The created billboard matrix.

#### CreateConstrainedBillboard(Vector3D, Vector3D, Vector3D, Nullable<Vector3D>, Nullable<Vector3D>)

Creates a cylindrical billboard that rotates around a specified axis.

##### Declaration

```
public static MatrixD CreateConstrainedBillboard(Vector3D objectPosition, Vector3D cameraPosition, Vector3D rotateAxis, Nullable<Vector3D> cameraForwardVector, Nullable<Vector3D> objectForwardVector)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

objectPosition

Position of the object the billboard will rotate around.

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

cameraPosition

Position of the camera.

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

rotateAxis

Axis to rotate the billboard around.

System.Nullable<[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\>

cameraForwardVector

Optional forward vector of the camera.

System.Nullable<[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\>

objectForwardVector

Optional forward vector of the object.

##### Returns

Type

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

#### CreateConstrainedBillboard(ref Vector3D, ref Vector3D, ref Vector3D, Nullable<Vector3D>, Nullable<Vector3D>, out MatrixD)

Creates a cylindrical billboard that rotates around a specified axis.

##### Declaration

```
public static void CreateConstrainedBillboard(ref Vector3D objectPosition, ref Vector3D cameraPosition, ref Vector3D rotateAxis, Nullable<Vector3D> cameraForwardVector, Nullable<Vector3D> objectForwardVector, out MatrixD result)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

objectPosition

Position of the object the billboard will rotate around.

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

cameraPosition

Position of the camera.

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

rotateAxis

Axis to rotate the billboard around.

System.Nullable<[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\>

cameraForwardVector

Optional forward vector of the camera.

System.Nullable<[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\>

objectForwardVector

Optional forward vector of the object.

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

result

\[OutAttribute\] The created billboard matrix.

#### CreateFromAxisAngle(Vector3D, Double)

Creates a new Matrix that rotates around an arbitrary vector.

##### Declaration

```
public static MatrixD CreateFromAxisAngle(Vector3D axis, double angle)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

axis

The axis to rotate around.

System.Double

angle

The angle to rotate around the vector.

##### Returns

Type

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

#### CreateFromAxisAngle(ref Vector3D, Double, out MatrixD)

Creates a new Matrix that rotates around an arbitrary vector.

##### Declaration

```
public static void CreateFromAxisAngle(ref Vector3D axis, double angle, out MatrixD result)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

axis

The axis to rotate around.

System.Double

angle

The angle to rotate around the vector.

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

result

\[OutAttribute\] The created Matrix.

#### CreateFromDir(Vector3D)

##### Declaration

```
public static MatrixD CreateFromDir(Vector3D dir)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

dir

##### Returns

Type

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

#### CreateFromDir(Vector3D, Vector3D)

##### Declaration

```
public static MatrixD CreateFromDir(Vector3D dir, Vector3D suggestedUp)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

dir

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

suggestedUp

##### Returns

Type

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

#### CreateFromQuaternion(Quaternion)

Creates a rotation Matrix from a Quaternion.

##### Declaration

```
public static MatrixD CreateFromQuaternion(Quaternion quaternion)
```

##### Parameters

Type

Name

Description

[Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html)

quaternion

Quaternion to create the Matrix from.

##### Returns

Type

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

#### CreateFromQuaternion(ref Quaternion, out MatrixD)

Creates a rotation Matrix from a Quaternion.

##### Declaration

```
public static void CreateFromQuaternion(ref Quaternion quaternion, out MatrixD result)
```
