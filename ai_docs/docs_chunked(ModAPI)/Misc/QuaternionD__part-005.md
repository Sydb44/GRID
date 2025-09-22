
##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) | quaternion1 | The quaternion on the left of the multiplication. |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) | quaternion2 | The quaternion on the right of the multiplication. |

##### Returns

| Type | Description |
| --- | --- |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) |     |

#### Multiply(ref QuaternionD, Double, out QuaternionD)

Multiplies a quaternion by a scalar value.

##### Declaration

```
public static void Multiply(ref QuaternionD quaternion1, double scaleFactor, out QuaternionD result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) | quaternion1 | Source quaternion. |
| System.Double | scaleFactor | Scalar value. |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) | result | \[OutAttribute\] The result of the multiplication. |

#### Multiply(ref QuaternionD, ref QuaternionD, out QuaternionD)

Multiplies two quaternions.

##### Declaration

```
public static void Multiply(ref QuaternionD quaternion1, ref QuaternionD quaternion2, out QuaternionD result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) | quaternion1 | The quaternion on the left of the multiplication. |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) | quaternion2 | The quaternion on the right of the multiplication. |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) | result | \[OutAttribute\] The result of the multiplication. |

#### Negate(QuaternionD)

Flips the sign of each component of the quaternion.

##### Declaration

```
public static QuaternionD Negate(QuaternionD quaternion)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) | quaternion | Source quaternion. |

##### Returns

| Type | Description |
| --- | --- |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) |     |

#### Negate(ref QuaternionD, out QuaternionD)

Flips the sign of each component of the quaternion.

##### Declaration

```
public static void Negate(ref QuaternionD quaternion, out QuaternionD result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) | quaternion | Source quaternion. |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) | result | \[OutAttribute\] Negated quaternion. |

#### Normalize()

Divides each component of the quaternion by the length of the quaternion.

##### Declaration

#### Normalize(QuaternionD)

Divides each component of the quaternion by the length of the quaternion.

##### Declaration

```
public static QuaternionD Normalize(QuaternionD quaternion)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) | quaternion | Source quaternion. |

##### Returns

| Type | Description |
| --- | --- |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) |     |

#### Normalize(ref QuaternionD, out QuaternionD)

Divides each component of the quaternion by the length of the quaternion.

##### Declaration

```
public static void Normalize(ref QuaternionD quaternion, out QuaternionD result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) | quaternion | Source quaternion. |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) | result | \[OutAttribute\] Normalized quaternion. |

#### Slerp(QuaternionD, QuaternionD, Double)

Interpolates between two quaternions, using spherical linear interpolation.

##### Declaration

```
public static QuaternionD Slerp(QuaternionD quaternion1, QuaternionD quaternion2, double amount)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) | quaternion1 | Source quaternion. |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) | quaternion2 | Source quaternion. |
| System.Double | amount | Value that indicates how far to interpolate between the quaternions. |

##### Returns

| Type | Description |
| --- | --- |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) |     |

#### Slerp(ref QuaternionD, ref QuaternionD, Double, out QuaternionD)

Interpolates between two quaternions, using spherical linear interpolation.

##### Declaration

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
