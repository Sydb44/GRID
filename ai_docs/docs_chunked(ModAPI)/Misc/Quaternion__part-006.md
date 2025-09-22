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

#### Negate(Quaternion)

Flips the sign of each component of the quaternion.

##### Declaration

```
public static Quaternion Negate(Quaternion quaternion)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | quaternion | Source quaternion. |

##### Returns

| Type | Description |
| --- | --- |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) |     |

#### Negate(ref Quaternion, out Quaternion)

Flips the sign of each component of the quaternion.

##### Declaration

```
public static void Negate(ref Quaternion quaternion, out Quaternion result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | quaternion | Source quaternion. |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | result | \[OutAttribute\] Negated quaternion. |

#### Normalize()

Divides each component of the quaternion by the length of the quaternion.

##### Declaration

#### Normalize(Quaternion)

Divides each component of the quaternion by the length of the quaternion.

##### Declaration

```
public static Quaternion Normalize(Quaternion quaternion)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | quaternion | Source quaternion. |

##### Returns

| Type | Description |
| --- | --- |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) |     |

#### Normalize(ref Quaternion, out Quaternion)

Divides each component of the quaternion by the length of the quaternion.

##### Declaration

```
public static void Normalize(ref Quaternion quaternion, out Quaternion result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | quaternion | Source quaternion. |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | result | \[OutAttribute\] Normalized quaternion. |

#### SetComponent(Int32, Single)

##### Declaration

```
public void SetComponent(int index, float value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | index |     |
| System.Single | value |     |

#### Slerp(Quaternion, Quaternion, Single)

Interpolates between two quaternions, using spherical linear interpolation.

##### Declaration

```
public static Quaternion Slerp(Quaternion quaternion1, Quaternion quaternion2, float amount)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | quaternion1 | Source quaternion. |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | quaternion2 | Source quaternion. |
| System.Single | amount | Value that indicates how far to interpolate between the quaternions. |

##### Returns

| Type | Description |
| --- | --- |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) |     |

#### Slerp(ref Quaternion, ref Quaternion, Single, out Quaternion)

Interpolates between two quaternions, using spherical linear interpolation.

##### Declaration

```
public static void Slerp(ref Quaternion quaternion1, ref Quaternion quaternion2, float amount, out Quaternion result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | quaternion1 | Source quaternion. |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | quaternion2 | Source quaternion. |
| System.Single | amount | Value that indicates how far to interpolate between the quaternions. |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | result | \[OutAttribute\] Result of the interpolation. |

#### Subtract(Quaternion, Quaternion)

Subtracts a quaternion from another quaternion.

##### Declaration

```
public static Quaternion Subtract(Quaternion quaternion1, Quaternion quaternion2)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | quaternion1 | Source quaternion. |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | quaternion2 | Source quaternion. |

##### Returns

| Type | Description |
| --- | --- |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) |     |

#### Subtract(ref Quaternion, ref Quaternion, out Quaternion)

Subtracts a quaternion from another quaternion.

##### Declaration

```
public static void Subtract(ref Quaternion quaternion1, ref Quaternion quaternion2, out Quaternion result)
```
