| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | firstVector |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | secondVector |     |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) | result |     |

#### CreateFromYawPitchRoll(Double, Double, Double)

Creates a new QuaternionD from specified yaw, pitch, and roll angles.

##### Declaration

```
public static QuaternionD CreateFromYawPitchRoll(double yaw, double pitch, double roll)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Double | yaw | The yaw angle, in radians, around the y-axis. |
| System.Double | pitch | The pitch angle, in radians, around the x-axis. |
| System.Double | roll | The roll angle, in radians, around the z-axis. |

##### Returns

| Type | Description |
| --- | --- |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) |     |

#### CreateFromYawPitchRoll(Double, Double, Double, out QuaternionD)

Creates a new QuaternionD from specified yaw, pitch, and roll angles.

##### Declaration

```
public static void CreateFromYawPitchRoll(double yaw, double pitch, double roll, out QuaternionD result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Double | yaw | The yaw angle, in radians, around the y-axis. |
| System.Double | pitch | The pitch angle, in radians, around the x-axis. |
| System.Double | roll | The roll angle, in radians, around the z-axis. |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) | result | \[OutAttribute\] An existing QuaternionD filled in to express the specified yaw, pitch, and roll angles. |

#### Divide(QuaternionD, QuaternionD)

Divides a QuaternionD by another QuaternionD.

##### Declaration

```
public static QuaternionD Divide(QuaternionD quaternion1, QuaternionD quaternion2)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) | quaternion1 | Source QuaternionD. |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) | quaternion2 | The divisor. |

##### Returns

| Type | Description |
| --- | --- |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) |     |

#### Divide(ref QuaternionD, ref QuaternionD, out QuaternionD)

Divides a QuaternionD by another QuaternionD.

##### Declaration

```
public static void Divide(ref QuaternionD quaternion1, ref QuaternionD quaternion2, out QuaternionD result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) | quaternion1 | Source QuaternionD. |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) | quaternion2 | The divisor. |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) | result | \[OutAttribute\] Result of the division. |

#### Dot(QuaternionD, QuaternionD)

Calculates the dot product of two Quaternions.

##### Declaration

```
public static double Dot(QuaternionD quaternion1, QuaternionD quaternion2)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) | quaternion1 | Source QuaternionD. |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) | quaternion2 | Source QuaternionD. |

##### Returns

| Type | Description |
| --- | --- |
| System.Double |     |

#### Dot(ref QuaternionD, ref QuaternionD, out Double)

Calculates the dot product of two Quaternions.

##### Declaration

```
public static void Dot(ref QuaternionD quaternion1, ref QuaternionD quaternion2, out double result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) | quaternion1 | Source QuaternionD. |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) | quaternion2 | Source QuaternionD. |
| System.Double | result | \[OutAttribute\] Dot product of the Quaternions. |

#### Equals(Object)

Returns a value that indicates whether the current instance is equal to a specified object.

##### Declaration

```
public override bool Equals(object obj)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | obj | Object to make the comparison with. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Equals(QuaternionD)

Determines whether the specified Object is equal to the QuaternionD.

##### Declaration

```
public bool Equals(QuaternionD other)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) | other | The QuaternionD to compare with the current QuaternionD. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### FromVector4(Vector4D)

##### Declaration

```
public static QuaternionD FromVector4(Vector4D v)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector4D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4D.html) | v   |     |

##### Returns

| Type | Description |
| --- | --- |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) |     |

#### GetAxisAngle(out Vector3D, out Double)

##### Declaration

```
public void GetAxisAngle(out Vector3D axis, out double angle)
```
