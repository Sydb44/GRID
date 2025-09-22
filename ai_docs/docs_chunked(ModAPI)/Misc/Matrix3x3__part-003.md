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

##### Parameters

#### [](#VRageMath_Matrix3x3_CreateRotationX_System_Single_)CreateRotationX(Single)

Returns a matrix that can be used to rotate a set of vertices around the x-axis.

##### Declaration

```
public static Matrix3x3 CreateRotationX(float radians)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | radians | The amount, in radians, in which to rotate around the x-axis. Note that you can use ToRadians to convert degrees to radians. |

##### Returns

#### [](#VRageMath_Matrix3x3_CreateRotationX_System_Single_VRageMath_Matrix3x3__)CreateRotationX(Single, out Matrix3x3)

Populates data into a user-specified matrix that can be used to rotate a set of vertices around the x-axis.

##### Declaration

```
public static void CreateRotationX(float radians, out Matrix3x3 result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | radians | The amount, in radians, in which to rotate around the x-axis. Note that you can use ToRadians to convert degrees to radians. |
| [Matrix3x3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix3x3.html) | result | \[OutAttribute\] The matrix in which to place the calculated data. |

#### [](#VRageMath_Matrix3x3_CreateRotationY_System_Single_)CreateRotationY(Single)

Returns a matrix that can be used to rotate a set of vertices around the y-axis.

##### Declaration

```
public static Matrix3x3 CreateRotationY(float radians)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | radians | The amount, in radians, in which to rotate around the y-axis. Note that you can use ToRadians to convert degrees to radians. |

##### Returns

#### [](#VRageMath_Matrix3x3_CreateRotationY_System_Single_VRageMath_Matrix3x3__)CreateRotationY(Single, out Matrix3x3)

Populates data into a user-specified matrix that can be used to rotate a set of vertices around the y-axis.

##### Declaration

```
public static void CreateRotationY(float radians, out Matrix3x3 result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | radians | The amount, in radians, in which to rotate around the y-axis. Note that you can use ToRadians to convert degrees to radians. |
| [Matrix3x3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix3x3.html) | result | \[OutAttribute\] The matrix in which to place the calculated data. |

#### [](#VRageMath_Matrix3x3_CreateRotationZ_System_Single_)CreateRotationZ(Single)

Returns a matrix that can be used to rotate a set of vertices around the z-axis.

##### Declaration

```
public static Matrix3x3 CreateRotationZ(float radians)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | radians | The amount, in radians, in which to rotate around the z-axis. Note that you can use ToRadians to convert degrees to radians. |

##### Returns

#### [](#VRageMath_Matrix3x3_CreateRotationZ_System_Single_VRageMath_Matrix3x3__)CreateRotationZ(Single, out Matrix3x3)

Populates data into a user-specified matrix that can be used to rotate a set of vertices around the z-axis.

##### Declaration

```
public static void CreateRotationZ(float radians, out Matrix3x3 result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | radians | The amount, in radians, in which to rotate around the z-axis. Note that you can use ToRadians to convert degrees to radians. |
| [Matrix3x3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix3x3.html) | result | \[OutAttribute\] The rotation matrix. |

#### [](#VRageMath_Matrix3x3_CreateScale_System_Single_)CreateScale(Single)

Creates a scaling Matrix3x3.

##### Declaration

```
public static Matrix3x3 CreateScale(float scale)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | scale | Amount to scale by. |

##### Returns

#### [](#VRageMath_Matrix3x3_CreateScale_System_Single_System_Single_System_Single_)CreateScale(Single, Single, Single)

Creates a scaling Matrix3x3.

##### Declaration

```
public static Matrix3x3 CreateScale(float xScale, float yScale, float zScale)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | xScale | Value to scale by on the x-axis. |
| System.Single | yScale | Value to scale by on the y-axis. |
| System.Single | zScale | Value to scale by on the z-axis. |

##### Returns

#### [](#VRageMath_Matrix3x3_CreateScale_System_Single_System_Single_System_Single_VRageMath_Matrix3x3__)CreateScale(Single, Single, Single, out Matrix3x3)

Creates a scaling Matrix3x3.

##### Declaration

```
public static void CreateScale(float xScale, float yScale, float zScale, out Matrix3x3 result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | xScale | Value to scale by on the x-axis. |
| System.Single | yScale | Value to scale by on the y-axis. |
| System.Single | zScale | Value to scale by on the z-axis. |
| [Matrix3x3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix3x3.html) | result | \[OutAttribute\] The created scaling Matrix3x3. |
