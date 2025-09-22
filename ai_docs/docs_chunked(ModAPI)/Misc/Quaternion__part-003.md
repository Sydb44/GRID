
##### Declaration

```
public static void CreateFromRotationMatrix(ref Matrix3x3 matrix, out Quaternion result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Matrix3x3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix3x3.html) | matrix | The rotation Matrix to create the Quaternion from. |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | result | \[OutAttribute\] The created Quaternion. |

#### CreateFromRotationMatrix(in MatrixD)

##### Declaration

```
public static Quaternion CreateFromRotationMatrix(in MatrixD matrix)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) | matrix |     |

##### Returns

| Type | Description |
| --- | --- |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) |     |

#### CreateFromRotationMatrix(ref MatrixD, out Quaternion)

##### Declaration

```
public static void CreateFromRotationMatrix(ref MatrixD matrix, out Quaternion result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) | matrix |     |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | result |     |

#### CreateFromTwoVectors(Vector3, Vector3)

##### Declaration

```
public static Quaternion CreateFromTwoVectors(Vector3 firstVector, Vector3 secondVector)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | firstVector |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | secondVector |     |

##### Returns

| Type | Description |
| --- | --- |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) |     |

#### CreateFromTwoVectors(ref Vector3, ref Vector3, out Quaternion)

##### Declaration

```
public static void CreateFromTwoVectors(ref Vector3 firstVector, ref Vector3 secondVector, out Quaternion result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | firstVector |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | secondVector |     |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | result |     |

#### CreateFromYawPitchRoll(Single, Single, Single)

Creates a new Quaternion from specified yaw, pitch, and roll angles.

##### Declaration

```
public static Quaternion CreateFromYawPitchRoll(float yaw, float pitch, float roll)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | yaw | The yaw angle, in radians, around the y-axis. |
| System.Single | pitch | The pitch angle, in radians, around the x-axis. |
| System.Single | roll | The roll angle, in radians, around the z-axis. |

##### Returns

| Type | Description |
| --- | --- |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) |     |

#### CreateFromYawPitchRoll(Single, Single, Single, out Quaternion)

Creates a new Quaternion from specified yaw, pitch, and roll angles.

##### Declaration

```
public static void CreateFromYawPitchRoll(float yaw, float pitch, float roll, out Quaternion result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | yaw | The yaw angle, in radians, around the y-axis. |
| System.Single | pitch | The pitch angle, in radians, around the x-axis. |
| System.Single | roll | The roll angle, in radians, around the z-axis. |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | result | \[OutAttribute\] An existing Quaternion filled in to express the specified yaw, pitch, and roll angles. |

#### Divide(Quaternion, Quaternion)

Divides a Quaternion by another Quaternion.

##### Declaration

```
public static Quaternion Divide(Quaternion quaternion1, Quaternion quaternion2)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | quaternion1 | Source Quaternion. |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | quaternion2 | The divisor. |

##### Returns

| Type | Description |
| --- | --- |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) |     |

#### Divide(ref Quaternion, ref Quaternion, out Quaternion)

Divides a Quaternion by another Quaternion.

##### Declaration

```
public static void Divide(ref Quaternion quaternion1, ref Quaternion quaternion2, out Quaternion result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | quaternion1 | Source Quaternion. |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | quaternion2 | The divisor. |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | result | \[OutAttribute\] Result of the division. |

#### Dot(Quaternion, Quaternion)

Calculates the dot product of two Quaternions.

##### Declaration

```
public static float Dot(Quaternion quaternion1, Quaternion quaternion2)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | quaternion1 | Source Quaternion. |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | quaternion2 | Source Quaternion. |
