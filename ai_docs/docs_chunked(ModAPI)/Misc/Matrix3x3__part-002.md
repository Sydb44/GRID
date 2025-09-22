##### Declaration

```
public Vector3 Up { get; set; }
```

##### Property Value

### [](#methods)Methods

#### [](#VRageMath_Matrix3x3_Add_VRageMath_Matrix3x3__VRageMath_Matrix3x3__VRageMath_Matrix3x3__)Add(ref Matrix3x3, ref Matrix3x3, out Matrix3x3)

Adds a matrix to another matrix.

##### Declaration

```
public static void Add(ref Matrix3x3 matrix1, ref Matrix3x3 matrix2, out Matrix3x3 result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Matrix3x3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix3x3.html) | matrix1 | Source matrix. |
| [Matrix3x3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix3x3.html) | matrix2 | Source matrix. |
| [Matrix3x3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix3x3.html) | result | \[OutAttribute\] Resulting matrix. |

#### [](#VRageMath_Matrix3x3_AlignRotationToAxes_VRageMath_Matrix3x3__VRageMath_Matrix3x3__)AlignRotationToAxes(ref Matrix3x3, ref Matrix3x3)

##### Declaration

```
public static Matrix3x3 AlignRotationToAxes(ref Matrix3x3 toAlign, ref Matrix3x3 axisDefinitionMatrix)
```

##### Parameters

##### Returns

#### [](#VRageMath_Matrix3x3_AssertIsValid)AssertIsValid()

##### Declaration

```
public void AssertIsValid()
```

#### [](#VRageMath_Matrix3x3_CreateFromAxisAngle_VRageMath_Vector3_System_Single_)CreateFromAxisAngle(Vector3, Single)

Creates a new Matrix3x3 that rotates around an arbitrary vector.

##### Declaration

```
public static Matrix3x3 CreateFromAxisAngle(Vector3 axis, float angle)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | axis | The axis to rotate around. |
| System.Single | angle | The angle to rotate around the vector. |

##### Returns

#### [](#VRageMath_Matrix3x3_CreateFromAxisAngle_VRageMath_Vector3__System_Single_VRageMath_Matrix3x3__)CreateFromAxisAngle(ref Vector3, Single, out Matrix3x3)

Creates a new Matrix3x3 that rotates around an arbitrary vector.

##### Declaration

```
public static void CreateFromAxisAngle(ref Vector3 axis, float angle, out Matrix3x3 result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | axis | The axis to rotate around. |
| System.Single | angle | The angle to rotate around the vector. |
| [Matrix3x3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix3x3.html) | result | \[OutAttribute\] The created Matrix3x3. |

#### [](#VRageMath_Matrix3x3_CreateFromDir_VRageMath_Vector3_)CreateFromDir(Vector3)

##### Declaration

```
public static Matrix3x3 CreateFromDir(Vector3 dir)
```

##### Parameters

##### Returns

#### [](#VRageMath_Matrix3x3_CreateFromDir_VRageMath_Vector3_VRageMath_Vector3_)CreateFromDir(Vector3, Vector3)

##### Declaration

```
public static Matrix3x3 CreateFromDir(Vector3 dir, Vector3 suggestedUp)
```

##### Parameters

##### Returns

#### [](#VRageMath_Matrix3x3_CreateFromQuaternion_VRageMath_Quaternion_)CreateFromQuaternion(Quaternion)

Creates a rotation Matrix3x3 from a Quaternion.

##### Declaration

```
public static Matrix3x3 CreateFromQuaternion(Quaternion quaternion)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | quaternion | Quaternion to create the Matrix3x3 from. |

##### Returns

#### [](#VRageMath_Matrix3x3_CreateFromQuaternion_VRageMath_Quaternion__VRageMath_Matrix3x3__)CreateFromQuaternion(ref Quaternion, out Matrix3x3)

Creates a rotation Matrix3x3 from a Quaternion.

##### Declaration

```
public static void CreateFromQuaternion(ref Quaternion quaternion, out Matrix3x3 result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | quaternion | Quaternion to create the Matrix3x3 from. |
| [Matrix3x3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix3x3.html) | result | \[OutAttribute\] The created Matrix3x3. |

#### [](#VRageMath_Matrix3x3_CreateFromYawPitchRoll_System_Single_System_Single_System_Single_)CreateFromYawPitchRoll(Single, Single, Single)

Creates a new rotation matrix from a specified yaw, pitch, and roll.

##### Declaration

```
public static Matrix3x3 CreateFromYawPitchRoll(float yaw, float pitch, float roll)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | yaw | Angle of rotation, in radians, around the y-axis. |
| System.Single | pitch | Angle of rotation, in radians, around the x-axis. |
| System.Single | roll | Angle of rotation, in radians, around the z-axis. |

##### Returns

#### [](#VRageMath_Matrix3x3_CreateFromYawPitchRoll_System_Single_System_Single_System_Single_VRageMath_Matrix3x3__)CreateFromYawPitchRoll(Single, Single, Single, out Matrix3x3)

Fills in a rotation matrix from a specified yaw, pitch, and roll.

##### Declaration

```
public static void CreateFromYawPitchRoll(float yaw, float pitch, float roll, out Matrix3x3 result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | yaw | Angle of rotation, in radians, around the y-axis. |
| System.Single | pitch | Angle of rotation, in radians, around the x-axis. |
| System.Single | roll | Angle of rotation, in radians, around the z-axis. |
| [Matrix3x3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix3x3.html) | result | \[OutAttribute\] An existing matrix filled in to represent the specified yaw, pitch, and roll. |

#### [](#VRageMath_Matrix3x3_CreateRotationFromTwoVectors_VRageMath_Vector3__VRageMath_Vector3__VRageMath_Matrix3x3__)CreateRotationFromTwoVectors(ref Vector3, ref Vector3, out Matrix3x3)

##### Declaration

```
public static void CreateRotationFromTwoVectors(ref Vector3 fromVector, ref Vector3 toVector, out Matrix3x3 resultMatrix)
```
