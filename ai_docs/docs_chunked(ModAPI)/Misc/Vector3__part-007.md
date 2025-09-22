Source tangent vector.

System.Single

amount

Weighting factor.

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

result

\[OutAttribute\] The result of the Hermite spline interpolation.

#### Interpolate3(Vector3, Vector3, Single)

##### Declaration

```
public void Interpolate3(Vector3 v0, Vector3 v1, float rt)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

v0

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

v1

System.Single

rt

#### IsInsideInclusive(ref Vector3, ref Vector3)

##### Declaration

```
public bool IsInsideInclusive(ref Vector3 min, ref Vector3 max)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

min

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

max

##### Returns

Type

Description

System.Boolean

#### IsUnit(ref Vector3)

##### Declaration

```
public static bool IsUnit(ref Vector3 value)
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

System.Boolean

#### IsValid()

##### Declaration

##### Returns

Type

Description

System.Boolean

#### IsZero(Vector3)

##### Declaration

```
public static bool IsZero(Vector3 value)
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

System.Boolean

#### IsZero(Vector3, Single)

##### Declaration

```
public static bool IsZero(Vector3 value, float epsilon)
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

System.Boolean

#### IsZero(ref Vector3)

##### Declaration

```
public static bool IsZero(ref Vector3 vec)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

vec

##### Returns

Type

Description

System.Boolean

#### IsZeroVector(Vector3)

##### Declaration

```
public static Vector3 IsZeroVector(Vector3 value)
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

#### IsZeroVector(Vector3, Single)

##### Declaration

```
public static Vector3 IsZeroVector(Vector3 value, float epsilon)
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

#### Length()

Calculates the length of the vector.

##### Declaration

##### Returns

Type

Description

System.Single

#### LengthSquared()

Calculates the length of the vector squared.

##### Declaration

```
public float LengthSquared()
```

##### Returns

Type

Description

System.Single

#### Lerp(Vector3, Vector3, Single)

Performs a linear interpolation between two vectors.

##### Declaration

```
public static Vector3 Lerp(Vector3 value1, Vector3 value2, float amount)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

value1

Source vector.

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

value2

Source vector.

System.Single

amount

Value between 0 and 1 indicating the weight of value2.

##### Returns

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### Lerp(ref Vector3, ref Vector3, Single, out Vector3)

Performs a linear interpolation between two vectors.

##### Declaration

```
public static void Lerp(ref Vector3 value1, ref Vector3 value2, float amount, out Vector3 result)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

value1

Source vector.

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

value2

Source vector.

System.Single

amount

Value between 0 and 1 indicating the weight of value2.

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

result

\[OutAttribute\] The result of the interpolation.

#### Max()

Returns the component of the vector that is largest of all the three components.

##### Declaration

##### Returns

Type

Description

System.Single

#### Max(Vector3, Vector3)

Returns a vector that contains the highest value from each matching pair of components.

##### Declaration

```
public static Vector3 Max(Vector3 value1, Vector3 value2)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

value1

Source vector.

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

value2

Source vector.

##### Returns

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### Max(ref Vector3, ref Vector3, out Vector3)

Returns a vector that contains the highest value from each matching pair of components.

##### Declaration

```
public static void Max(ref Vector3 value1, ref Vector3 value2, out Vector3 result)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

value1

Source vector.

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

value2

Source vector.

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

result

\[OutAttribute\] The maximized vector.
