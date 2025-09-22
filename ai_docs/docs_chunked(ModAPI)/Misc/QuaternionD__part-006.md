
```
public static void Slerp(ref QuaternionD quaternion1, ref QuaternionD quaternion2, double amount, out QuaternionD result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) | quaternion1 | Source quaternion. |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) | quaternion2 | Source quaternion. |
| System.Double | amount | Value that indicates how far to interpolate between the quaternions. |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) | result | \[OutAttribute\] Result of the interpolation. |

#### Subtract(QuaternionD, QuaternionD)

Subtracts a quaternion from another quaternion.

##### Declaration

```
public static QuaternionD Subtract(QuaternionD quaternion1, QuaternionD quaternion2)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) | quaternion1 | Source quaternion. |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) | quaternion2 | Source quaternion. |

##### Returns

| Type | Description |
| --- | --- |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) |     |

#### Subtract(ref QuaternionD, ref QuaternionD, out QuaternionD)

Subtracts a quaternion from another quaternion.

##### Declaration

```
public static void Subtract(ref QuaternionD quaternion1, ref QuaternionD quaternion2, out QuaternionD result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) | quaternion1 | Source quaternion. |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) | quaternion2 | Source quaternion. |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) | result | \[OutAttribute\] Result of the subtraction. |

#### ToString()

Retireves a string representation of the current object.

##### Declaration

```
public override string ToString()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

#### ToVector4()

##### Declaration

```
public Vector4D ToVector4()
```

##### Returns

| Type | Description |
| --- | --- |
| [Vector4D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4D.html) |     |

### Operators

#### Addition(QuaternionD, QuaternionD)

Adds two Quaternions.

##### Declaration

```
public static QuaternionD operator +(QuaternionD quaternion1, QuaternionD quaternion2)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) | quaternion1 | QuaternionD to add. |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) | quaternion2 | QuaternionD to add. |

##### Returns

| Type | Description |
| --- | --- |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) |     |

#### Division(QuaternionD, QuaternionD)

Divides a QuaternionD by another QuaternionD.

##### Declaration

```
public static QuaternionD operator /(QuaternionD quaternion1, QuaternionD quaternion2)
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

#### Equality(QuaternionD, QuaternionD)

Compares two Quaternions for equality.

##### Declaration

```
public static bool operator ==(QuaternionD quaternion1, QuaternionD quaternion2)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) | quaternion1 | Source QuaternionD. |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) | quaternion2 | Source QuaternionD. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Inequality(QuaternionD, QuaternionD)

Compare two Quaternions for inequality.

##### Declaration

```
public static bool operator !=(QuaternionD quaternion1, QuaternionD quaternion2)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) | quaternion1 | Source QuaternionD. |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) | quaternion2 | Source QuaternionD. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Multiply(QuaternionD, Double)

Multiplies a quaternion by a scalar value.

##### Declaration

```
public static QuaternionD operator *(QuaternionD quaternion1, double scaleFactor)
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
