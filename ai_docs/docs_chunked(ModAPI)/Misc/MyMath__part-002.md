| Type | Name | Description |
| --- | --- | --- |
| System.Single | x   |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### ForwardVectorProjection(Vector3, Vector3)

This projection results to initial velocity of non-engine objects, which parents move in some velocity We want to add only forward speed of the parent to the forward direction of the object, and if parent is going backward, no speed is added.

##### Declaration

```
public static Vector3 ForwardVectorProjection(Vector3 forwardVector, Vector3 projectedVector)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | forwardVector |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | projectedVector |     |

##### Returns

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### InitializeFastSin()

##### Declaration

```
public static void InitializeFastSin()
```

#### MaxComponents(ref Vector3, ref Vector3)

Return vector with each component max

##### Declaration

```
public static Vector3 MaxComponents(ref Vector3 a, ref Vector3 b)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | a   |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | b   |     |

##### Returns

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### Mod(Int32, Int32)

##### Declaration

```
public static int Mod(int x, int m)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | x   |     |
| System.Int32 | m   |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### Mod(Int64, Int32)

##### Declaration

```
public static long Mod(long x, int m)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | x   |     |
| System.Int32 | m   |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### NormalizeAngle(Single, Single)

##### Declaration

```
public static float NormalizeAngle(float angle, float center = 0F)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | angle |     |
| System.Single | center |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### QuaternionToEuler(Quaternion)

QuaternionToEuler

##### Declaration

```
public static Vector3 QuaternionToEuler(Quaternion Rotation)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | Rotation |     |

##### Returns

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | Converted quaternion to the euler pitch, rot, yaw |

#### VectorFromColor(Byte, Byte, Byte)

Calculates color from vector

##### Declaration

```
public static Vector3 VectorFromColor(byte red, byte green, byte blue)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Byte | red |     |
| System.Byte | green |     |
| System.Byte | blue |     |

##### Returns

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### VectorFromColor(Byte, Byte, Byte, Byte)

##### Declaration

```
public static Vector4 VectorFromColor(byte red, byte green, byte blue, byte alpha)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Byte | red |     |
| System.Byte | green |     |
| System.Byte | blue |     |
| System.Byte | alpha |     |

##### Returns

| Type | Description |
| --- | --- |
| [Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html) |     |