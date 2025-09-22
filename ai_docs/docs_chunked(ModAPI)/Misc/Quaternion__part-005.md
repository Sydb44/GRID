| Type | Description |
| --- | --- |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) |     |

#### Inverse(ref Quaternion, out Quaternion)

Returns the inverse of a Quaternion.

##### Declaration

```
public static void Inverse(ref Quaternion quaternion, out Quaternion result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | quaternion | Source Quaternion. |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | result | \[OutAttribute\] The inverse of the Quaternion. |

#### IsZero(Quaternion)

##### Declaration

```
public static bool IsZero(Quaternion value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | value |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsZero(Quaternion, Single)

##### Declaration

```
public static bool IsZero(Quaternion value, float epsilon)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | value |     |
| System.Single | epsilon |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Length()

Calculates the length of a Quaternion.

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### LengthSquared()

Calculates the length squared of a Quaternion.

##### Declaration

```
public float LengthSquared()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### Lerp(Quaternion, Quaternion, Single)

Linearly interpolates between two quaternions.

##### Declaration

```
public static Quaternion Lerp(Quaternion quaternion1, Quaternion quaternion2, float amount)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | quaternion1 | Source quaternion. |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | quaternion2 | Source quaternion. |
| System.Single | amount | Value indicating how far to interpolate between the quaternions. |

##### Returns

| Type | Description |
| --- | --- |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) |     |

#### Lerp(ref Quaternion, ref Quaternion, Single, out Quaternion)

Linearly interpolates between two quaternions.

##### Declaration

```
public static void Lerp(ref Quaternion quaternion1, ref Quaternion quaternion2, float amount, out Quaternion result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | quaternion1 | Source quaternion. |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | quaternion2 | Source quaternion. |
| System.Single | amount | Value indicating how far to interpolate between the quaternions. |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | result | \[OutAttribute\] The resulting quaternion. |

#### Multiply(Quaternion, Single)

Multiplies a quaternion by a scalar value.

##### Declaration

```
public static Quaternion Multiply(Quaternion quaternion1, float scaleFactor)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | quaternion1 | Source quaternion. |
| System.Single | scaleFactor | Scalar value. |

##### Returns

| Type | Description |
| --- | --- |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) |     |

#### Multiply(Quaternion, Quaternion)

Multiplies two quaternions.

##### Declaration

```
public static Quaternion Multiply(Quaternion quaternion1, Quaternion quaternion2)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | quaternion1 | The quaternion on the left of the multiplication. |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | quaternion2 | The quaternion on the right of the multiplication. |

##### Returns

| Type | Description |
| --- | --- |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) |     |

#### Multiply(ref Quaternion, Single, out Quaternion)

Multiplies a quaternion by a scalar value.

##### Declaration

```
public static void Multiply(ref Quaternion quaternion1, float scaleFactor, out Quaternion result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | quaternion1 | Source quaternion. |
| System.Single | scaleFactor | Scalar value. |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | result | \[OutAttribute\] The result of the multiplication. |

#### Multiply(ref Quaternion, ref Quaternion, out Quaternion)

Multiplies two quaternions.

##### Declaration

```
public static void Multiply(ref Quaternion quaternion1, ref Quaternion quaternion2, out Quaternion result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | quaternion1 | The quaternion on the left of the multiplication. |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | quaternion2 | The quaternion on the right of the multiplication. |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | result | \[OutAttribute\] The result of the multiplication. |
