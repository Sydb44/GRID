| Type | Description |
| --- | --- |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) |     |

#### Subtract(ref Quaternion, ref Quaternion, out Quaternion)

Subtracts a quaternion from another quaternion.

##### Declaration

```
public static void Subtract(ref Quaternion quaternion1, ref Quaternion quaternion2, out Quaternion result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | quaternion1 | Source quaternion. |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | quaternion2 | Source quaternion. |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | result | \[OutAttribute\] Result of the subtraction. |

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

#### ToString(String)

##### Declaration

```
public string ToString(string format)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | format |     |

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

#### ToStringAxisAngle(String)

##### Declaration

```
public string ToStringAxisAngle(string format = "G")
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | format |     |

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

#### ToVector4()

##### Declaration

```
public Vector4 ToVector4()
```

##### Returns

| Type | Description |
| --- | --- |
| [Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html) |     |

### Operators

#### Addition(Quaternion, Quaternion)

Adds two Quaternions.

##### Declaration

```
public static Quaternion operator +(Quaternion quaternion1, Quaternion quaternion2)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | quaternion1 | Quaternion to add. |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | quaternion2 | Quaternion to add. |

##### Returns

| Type | Description |
| --- | --- |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) |     |

#### Division(Quaternion, Quaternion)

Divides a Quaternion by another Quaternion.

##### Declaration

```
public static Quaternion operator /(Quaternion quaternion1, Quaternion quaternion2)
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

#### Equality(Quaternion, Quaternion)

Compares two Quaternions for equality.

##### Declaration

```
public static bool operator ==(Quaternion quaternion1, Quaternion quaternion2)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | quaternion1 | Source Quaternion. |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | quaternion2 | Source Quaternion. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Inequality(Quaternion, Quaternion)

Compare two Quaternions for inequality.

##### Declaration

```
public static bool operator !=(Quaternion quaternion1, Quaternion quaternion2)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | quaternion1 | Source Quaternion. |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | quaternion2 | Source Quaternion. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Multiply(Quaternion, Single)

Multiplies a quaternion by a scalar value.

##### Declaration

```
public static Quaternion operator *(Quaternion quaternion1, float scaleFactor)
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
public static Quaternion operator *(Quaternion quaternion1, Quaternion quaternion2)
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

#### Multiply(Quaternion, Vector3)

Multiplies a vector by a quaternion. Resulting vector rotated by quaternion

##### Declaration

```
public static Vector3 operator *(Quaternion quaternion, Vector3 vector)
```
