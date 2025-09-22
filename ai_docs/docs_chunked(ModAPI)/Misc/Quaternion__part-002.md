| Type | Description |
| --- | --- |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) |     |

#### Concatenate(ref Quaternion, ref Quaternion, out Quaternion)

Concatenates two Quaternions; the result represents the value1 rotation followed by the value2 rotation.

##### Declaration

```
public static void Concatenate(ref Quaternion value1, ref Quaternion value2, out Quaternion result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | value1 | The first Quaternion rotation in the series. |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | value2 | The second Quaternion rotation in the series. |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | result | \[OutAttribute\] The Quaternion rotation representing the concatenation of value1 followed by value2. |

#### Conjugate()

Transforms this Quaternion into its conjugate.

##### Declaration

#### Conjugate(Quaternion)

Returns the conjugate of a specified Quaternion.

##### Declaration

```
public static Quaternion Conjugate(Quaternion value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | value | The Quaternion of which to return the conjugate. |

##### Returns

| Type | Description |
| --- | --- |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) |     |

#### Conjugate(ref Quaternion, out Quaternion)

Returns the conjugate of a specified Quaternion.

##### Declaration

```
public static void Conjugate(ref Quaternion value, out Quaternion result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | value | The Quaternion of which to return the conjugate. |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | result | \[OutAttribute\] An existing Quaternion filled in to be the conjugate of the specified one. |

#### CreateFromAxisAngle(Vector3, Single)

Creates a Quaternion from a vector and an angle to rotate about the vector.

##### Declaration

```
public static Quaternion CreateFromAxisAngle(Vector3 axis, float angle)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | axis | The vector to rotate around. |
| System.Single | angle | The angle to rotate around the vector. |

##### Returns

| Type | Description |
| --- | --- |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) |     |

#### CreateFromAxisAngle(ref Vector3, Single, out Quaternion)

Creates a Quaternion from a vector and an angle to rotate about the vector.

##### Declaration

```
public static void CreateFromAxisAngle(ref Vector3 axis, float angle, out Quaternion result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | axis | The vector to rotate around. |
| System.Single | angle | The angle to rotate around the vector. |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | result | \[OutAttribute\] The created Quaternion. |

#### CreateFromForwardUp(Vector3, Vector3)

Works for normalized vectors only

##### Declaration

```
public static Quaternion CreateFromForwardUp(Vector3 forward, Vector3 up)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | forward |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | up  |     |

##### Returns

| Type | Description |
| --- | --- |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) |     |

#### CreateFromRotationMatrix(Matrix)

Creates a Quaternion from a rotation Matrix.

##### Declaration

```
public static Quaternion CreateFromRotationMatrix(Matrix matrix)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html) | matrix | The rotation Matrix to create the Quaternion from. |

##### Returns

| Type | Description |
| --- | --- |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) |     |

#### CreateFromRotationMatrix(ref Matrix, out Quaternion)

Creates a Quaternion from a rotation Matrix.

##### Declaration

```
public static void CreateFromRotationMatrix(ref Matrix matrix, out Quaternion result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html) | matrix | The rotation Matrix to create the Quaternion from. |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | result | \[OutAttribute\] The created Quaternion. |

#### CreateFromRotationMatrix(ref Matrix3x3, out Quaternion)

Creates a Quaternion from a rotation Matrix.

##### Declaration

```
public static void CreateFromRotationMatrix(ref Matrix3x3 matrix, out Quaternion result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Matrix3x3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix3x3.html) | matrix | The rotation Matrix to create the Quaternion from. |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | result | \[OutAttribute\] The created Quaternion. |
