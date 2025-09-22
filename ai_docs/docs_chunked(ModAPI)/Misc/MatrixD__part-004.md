Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

#### CreateFromQuaternion(ref Quaternion, out MatrixD)

Creates a rotation Matrix from a Quaternion.

##### Declaration

```
public static void CreateFromQuaternion(ref Quaternion quaternion, out MatrixD result)
```

##### Parameters

Type

Name

Description

[Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html)

quaternion

Quaternion to create the Matrix from.

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

result

\[OutAttribute\] The created Matrix.

#### CreateFromQuaternion(QuaternionD)

##### Declaration

```
public static MatrixD CreateFromQuaternion(QuaternionD quaternion)
```

##### Parameters

Type

Name

Description

[QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html)

quaternion

##### Returns

Type

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

#### CreateFromTransformScale(Quaternion, Vector3D, Vector3D)

##### Declaration

```
public static MatrixD CreateFromTransformScale(Quaternion orientation, Vector3D position, Vector3D scale)
```

##### Parameters

Type

Name

Description

[Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html)

orientation

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

position

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

scale

##### Returns

Type

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

#### CreateFromYawPitchRoll(Double, Double, Double)

Creates a new rotation matrix from a specified yaw, pitch, and roll.

##### Declaration

```
public static MatrixD CreateFromYawPitchRoll(double yaw, double pitch, double roll)
```

##### Parameters

Type

Name

Description

System.Double

yaw

Angle of rotation, in radians, around the y-axis.

System.Double

pitch

Angle of rotation, in radians, around the x-axis.

System.Double

roll

Angle of rotation, in radians, around the z-axis.

##### Returns

Type

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

#### CreateFromYawPitchRoll(Double, Double, Double, out MatrixD)

Fills in a rotation matrix from a specified yaw, pitch, and roll.

##### Declaration

```
public static void CreateFromYawPitchRoll(double yaw, double pitch, double roll, out MatrixD result)
```

##### Parameters

Type

Name

Description

System.Double

yaw

Angle of rotation, in radians, around the y-axis.

System.Double

pitch

Angle of rotation, in radians, around the x-axis.

System.Double

roll

Angle of rotation, in radians, around the z-axis.

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

result

\[OutAttribute\] An existing matrix filled in to represent the specified yaw, pitch, and roll.

#### CreateLookAt(Vector3D, Vector3D, Vector3)

##### Declaration

```
public static MatrixD CreateLookAt(Vector3D cameraPosition, Vector3D cameraTarget, Vector3 cameraUpVector)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

cameraPosition

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

cameraTarget

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

cameraUpVector

##### Returns

Type

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

#### CreateLookAt(Vector3D, Vector3D, Vector3D)

Creates a view matrix.

##### Declaration

```
public static MatrixD CreateLookAt(Vector3D cameraPosition, Vector3D cameraTarget, Vector3D cameraUpVector)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

cameraPosition

The position of the camera.

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

cameraTarget

The target towards which the camera is pointing.

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

cameraUpVector

The direction that is "up" from the camera's point of view.

##### Returns

Type

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

#### CreateLookAt(ref Vector3D, ref Vector3D, ref Vector3D, out MatrixD)

Creates a view matrix.

##### Declaration

```
public static void CreateLookAt(ref Vector3D cameraPosition, ref Vector3D cameraTarget, ref Vector3D cameraUpVector, out MatrixD result)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

cameraPosition

The position of the camera.

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

cameraTarget

The target towards which the camera is pointing.

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

cameraUpVector

The direction that is "up" from the camera's point of view.

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

result

\[OutAttribute\] The created view matrix.

#### CreateLookAtInverse(Vector3D, Vector3D, Vector3D)

##### Declaration

```
public static MatrixD CreateLookAtInverse(Vector3D cameraPosition, Vector3D cameraTarget, Vector3D cameraUpVector)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

cameraPosition

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

cameraTarget

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

cameraUpVector
