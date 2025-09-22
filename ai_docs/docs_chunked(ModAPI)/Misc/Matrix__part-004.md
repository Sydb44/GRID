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

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

#### CreateFromQuaternion(ref Quaternion, out Matrix)

Creates a rotation Matrix from a Quaternion.

##### Declaration

```
public static void CreateFromQuaternion(ref Quaternion quaternion, out Matrix result)
```

##### Parameters

Type

Name

Description

[Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html)

quaternion

Quaternion to create the Matrix from.

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

result

\[OutAttribute\] The created Matrix.

#### CreateFromTransformScale(Quaternion, Vector3, Vector3)

##### Declaration

```
public static Matrix CreateFromTransformScale(Quaternion orientation, Vector3 position, Vector3 scale)
```

##### Parameters

Type

Name

Description

[Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html)

orientation

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

position

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

scale

##### Returns

Type

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

#### CreateFromYawPitchRoll(Single, Single, Single)

Creates a new rotation matrix from a specified yaw, pitch, and roll.

##### Declaration

```
public static Matrix CreateFromYawPitchRoll(float yaw, float pitch, float roll)
```

##### Parameters

Type

Name

Description

System.Single

yaw

Angle of rotation, in radians, around the y-axis.

System.Single

pitch

Angle of rotation, in radians, around the x-axis.

System.Single

roll

Angle of rotation, in radians, around the z-axis.

##### Returns

Type

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

#### CreateFromYawPitchRoll(Single, Single, Single, out Matrix)

Fills in a rotation matrix from a specified yaw, pitch, and roll.

##### Declaration

```
public static void CreateFromYawPitchRoll(float yaw, float pitch, float roll, out Matrix result)
```

##### Parameters

Type

Name

Description

System.Single

yaw

Angle of rotation, in radians, around the y-axis.

System.Single

pitch

Angle of rotation, in radians, around the x-axis.

System.Single

roll

Angle of rotation, in radians, around the z-axis.

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

result

\[OutAttribute\] An existing matrix filled in to represent the specified yaw, pitch, and roll.

#### CreateLookAt(Vector3, Vector3, Vector3)

Creates a view matrix.

##### Declaration

```
public static Matrix CreateLookAt(Vector3 cameraPosition, Vector3 cameraTarget, Vector3 cameraUpVector)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

cameraPosition

The position of the camera.

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

cameraTarget

The target towards which the camera is pointing.

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

cameraUpVector

The direction that is "up" from the camera's point of view.

##### Returns

Type

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

#### CreateLookAt(ref Vector3, ref Vector3, ref Vector3, out Matrix)

Creates a view matrix.

##### Declaration

```
public static void CreateLookAt(ref Vector3 cameraPosition, ref Vector3 cameraTarget, ref Vector3 cameraUpVector, out Matrix result)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

cameraPosition

The position of the camera.

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

cameraTarget

The target towards which the camera is pointing.

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

cameraUpVector

The direction that is "up" from the camera's point of view.

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

result

\[OutAttribute\] The created view matrix.

#### CreateLookAtInverse(Vector3, Vector3, Vector3)

##### Declaration

```
public static Matrix CreateLookAtInverse(Vector3 cameraPosition, Vector3 cameraTarget, Vector3 cameraUpVector)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

cameraPosition

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

cameraTarget

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

cameraUpVector

##### Returns

Type

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

#### CreateOrthographic(Single, Single, Single, Single)

Builds an orthogonal projection matrix.

##### Declaration

```
public static Matrix CreateOrthographic(float width, float height, float zNearPlane, float zFarPlane)
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

##### Returns

Type

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

#### CreateOrthographic(Single, Single, Single, Single, out Matrix)

Builds an orthogonal projection matrix.
