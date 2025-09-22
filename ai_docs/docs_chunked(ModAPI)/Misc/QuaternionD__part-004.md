##### Returns

| Type | Description |
| --- | --- |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) |     |

#### GetAxisAngle(out Vector3D, out Double)

##### Declaration

```
public void GetAxisAngle(out Vector3D axis, out double angle)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | axis |     |
| System.Double | angle |     |

#### GetHashCode()

Get the hash code of this object.

##### Declaration

```
public override int GetHashCode()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### Inverse(QuaternionD)

Returns the inverse of a QuaternionD.

##### Declaration

```
public static QuaternionD Inverse(QuaternionD quaternion)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) | quaternion | Source QuaternionD. |

##### Returns

| Type | Description |
| --- | --- |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) |     |

#### Inverse(ref QuaternionD, out QuaternionD)

Returns the inverse of a QuaternionD.

##### Declaration

```
public static void Inverse(ref QuaternionD quaternion, out QuaternionD result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) | quaternion | Source QuaternionD. |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) | result | \[OutAttribute\] The inverse of the QuaternionD. |

#### IsZero(QuaternionD)

##### Declaration

```
public static bool IsZero(QuaternionD value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) | value |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsZero(QuaternionD, Double)

##### Declaration

```
public static bool IsZero(QuaternionD value, double epsilon)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) | value |     |
| System.Double | epsilon |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Length()

Calculates the length of a QuaternionD.

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.Double |     |

#### LengthSquared()

Calculates the length squared of a QuaternionD.

##### Declaration

```
public double LengthSquared()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Double |     |

#### Lerp(QuaternionD, QuaternionD, Double)

Linearly interpolates between two quaternions.

##### Declaration

```
public static QuaternionD Lerp(QuaternionD quaternion1, QuaternionD quaternion2, double amount)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) | quaternion1 | Source quaternion. |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) | quaternion2 | Source quaternion. |
| System.Double | amount | Value indicating how far to interpolate between the quaternions. |

##### Returns

| Type | Description |
| --- | --- |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) |     |

#### Lerp(ref QuaternionD, ref QuaternionD, Double, out QuaternionD)

Linearly interpolates between two quaternions.

##### Declaration

```
public static void Lerp(ref QuaternionD quaternion1, ref QuaternionD quaternion2, double amount, out QuaternionD result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) | quaternion1 | Source quaternion. |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) | quaternion2 | Source quaternion. |
| System.Double | amount | Value indicating how far to interpolate between the quaternions. |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) | result | \[OutAttribute\] The resulting quaternion. |

#### Multiply(QuaternionD, Double)

Multiplies a quaternion by a scalar value.

##### Declaration

```
public static QuaternionD Multiply(QuaternionD quaternion1, double scaleFactor)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) | quaternion1 | Source quaternion. |
| System.Double | scaleFactor | Scalar value. |

##### Returns

| Type | Description |
| --- | --- |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) |     |

#### Multiply(QuaternionD, QuaternionD)

Multiplies two quaternions.

##### Declaration

```
public static QuaternionD Multiply(QuaternionD quaternion1, QuaternionD quaternion2)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) | quaternion1 | The quaternion on the left of the multiplication. |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) | quaternion2 | The quaternion on the right of the multiplication. |

##### Returns

| Type | Description |
| --- | --- |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) |     |
