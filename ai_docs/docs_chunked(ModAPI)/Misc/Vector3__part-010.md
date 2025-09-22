Source vector.

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

normal

Normal of the surface.

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

result

\[OutAttribute\] The reflected vector.

#### Reject(Vector3, Vector3)

Returns the rejection of vector from direction, i.e. projection of vector onto the plane defined by origin and direction

##### Declaration

```
public static Vector3 Reject(Vector3 vector, Vector3 direction)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

vector

Vector which is to be rejected

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

direction

Direction from which the input vector will be rejected

##### Returns

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

Rejection of the vector from the given direction

#### Reject(ref Vector3, ref Vector3, out Vector3)

Returns the rejection of vector from direction, i.e. projection of vector onto the plane defined by origin and direction

##### Declaration

```
public static void Reject(ref Vector3 vector, ref Vector3 direction, out Vector3 result)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

vector

Vector which is to be rejected

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

direction

Direction from which the input vector will be rejected

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

result

Rejection of the vector from the given direction

#### RotateAndScale(Vector3, Matrix)

##### Declaration

```
public static Vector3 RotateAndScale(Vector3 vector, Matrix matrix)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

vector

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

matrix

##### Returns

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### RotateAndScale(ref Vector3, ref Matrix, out Vector3)

##### Declaration

```
public static void RotateAndScale(ref Vector3 vector, ref Matrix matrix, out Vector3 result)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

vector

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

matrix

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

result

#### Round(Vector3)

##### Declaration

```
public static Vector3 Round(Vector3 v)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

v

##### Returns

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### Round(Vector3, Int32)

##### Declaration

```
public static Vector3 Round(Vector3 v, int numDecimals)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

v

System.Int32

numDecimals

##### Returns

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### SetDim(Int32, Single)

##### Declaration

```
public void SetDim(int i, float value)
```

##### Parameters

Type

Name

Description

System.Int32

i

System.Single

value

#### Sign(Vector3)

##### Declaration

```
public static Vector3 Sign(Vector3 value)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

value

##### Returns

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### Sign(Vector3, Single)

##### Declaration

```
public static Vector3 Sign(Vector3 value, float epsilon)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

value

System.Single

epsilon

##### Returns

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### SignNonZero(Vector3)

Returns per component sign, never returns zero. For zero component returns sign 1. Faster than Sign.

##### Declaration

```
public static Vector3 SignNonZero(Vector3 value)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

value

##### Returns

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### SmoothStep(Vector3, Vector3, Single)

Interpolates between two values using a cubic equation.

##### Declaration

```
public static Vector3 SmoothStep(Vector3 value1, Vector3 value2, float amount)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

value1

Source value.

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

value2

Source value.

System.Single

amount

Weighting value.

##### Returns

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### SmoothStep(ref Vector3, ref Vector3, Single, out Vector3)

Interpolates between two values using a cubic equation.

##### Declaration

```
public static void SmoothStep(ref Vector3 value1, ref Vector3 value2, float amount, out Vector3 result)
```
