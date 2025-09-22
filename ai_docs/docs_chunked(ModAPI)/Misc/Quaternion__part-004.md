
##### Declaration

```
public static float Dot(Quaternion quaternion1, Quaternion quaternion2)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | quaternion1 | Source Quaternion. |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | quaternion2 | Source Quaternion. |

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### Dot(ref Quaternion, ref Quaternion, out Single)

Calculates the dot product of two Quaternions.

##### Declaration

```
public static void Dot(ref Quaternion quaternion1, ref Quaternion quaternion2, out float result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | quaternion1 | Source Quaternion. |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | quaternion2 | Source Quaternion. |
| System.Single | result | \[OutAttribute\] Dot product of the Quaternions. |

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

#### Equals(Quaternion)

Determines whether the specified Object is equal to the Quaternion.

##### Declaration

```
public bool Equals(Quaternion other)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | other | The Quaternion to compare with the current Quaternion. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Equals(Quaternion, Single)

##### Declaration

```
public bool Equals(Quaternion value, float epsilon)
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

#### FindLargestIndex()

##### Declaration

```
public int FindLargestIndex()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### FromVector4(Vector4)

##### Declaration

```
public static Quaternion FromVector4(Vector4 v)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html) | v   |     |

##### Returns

| Type | Description |
| --- | --- |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) |     |

#### GetAxisAngle(out Vector3, out Single)

##### Declaration

```
public void GetAxisAngle(out Vector3 axis, out float angle)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | axis |     |
| System.Single | angle |     |

#### GetComponent(Int32)

##### Declaration

```
public float GetComponent(int index)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | index |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### GetForward(ref Quaternion, out Vector3)

Gets forward vector (0,0,-1) transformed by quaternion.

##### Declaration

```
public static void GetForward(ref Quaternion q, out Vector3 result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | q   |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | result |     |

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

#### GetRight(ref Quaternion, out Vector3)

Gets right vector (1,0,0) transformed by quaternion.

##### Declaration

```
public static void GetRight(ref Quaternion q, out Vector3 result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | q   |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | result |     |

#### GetUp(ref Quaternion, out Vector3)

Gets up vector (0,1,0) transformed by quaternion.

##### Declaration

```
public static void GetUp(ref Quaternion q, out Vector3 result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | q   |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | result |     |

#### Inverse(Quaternion)

Returns the inverse of a Quaternion.

##### Declaration

```
public static Quaternion Inverse(Quaternion quaternion)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | quaternion | Source Quaternion. |

##### Returns

| Type | Description |
| --- | --- |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) |     |

#### Inverse(ref Quaternion, out Quaternion)

Returns the inverse of a Quaternion.

##### Declaration

```
public static void Inverse(ref Quaternion quaternion, out Quaternion result)
```
