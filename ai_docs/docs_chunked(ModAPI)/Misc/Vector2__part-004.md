##### Parameters

Type

Name

Description

System.Object

obj

Object to make the comparison with.

##### Returns

Type

Description

System.Boolean

#### Equals(Vector2)

Determines whether the specified Object is equal to the Vector2.

##### Declaration

```
public bool Equals(Vector2 other)
```

##### Parameters

Type

Name

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

other

The Object to compare with the current Vector2.

##### Returns

Type

Description

System.Boolean

#### Floor(Vector2)

##### Declaration

```
public static Vector2 Floor(Vector2 position)
```

##### Parameters

Type

Name

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

position

##### Returns

Type

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

#### GetHashCode()

Gets the hash code of the vector object.

##### Declaration

```
public override int GetHashCode()
```

##### Returns

Type

Description

System.Int32

#### Hermite(Vector2, Vector2, Vector2, Vector2, Single)

Performs a Hermite spline interpolation.

##### Declaration

```
public static Vector2 Hermite(Vector2 value1, Vector2 tangent1, Vector2 value2, Vector2 tangent2, float amount)
```

##### Parameters

Type

Name

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

value1

Source position vector.

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

tangent1

Source tangent vector.

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

value2

Source position vector.

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

tangent2

Source tangent vector.

System.Single

amount

Weighting factor.

##### Returns

Type

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

#### Hermite(ref Vector2, ref Vector2, ref Vector2, ref Vector2, Single, out Vector2)

Performs a Hermite spline interpolation.

##### Declaration

```
public static void Hermite(ref Vector2 value1, ref Vector2 tangent1, ref Vector2 value2, ref Vector2 tangent2, float amount, out Vector2 result)
```

##### Parameters

Type

Name

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

value1

Source position vector.

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

tangent1

Source tangent vector.

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

value2

Source position vector.

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

tangent2

Source tangent vector.

System.Single

amount

Weighting factor.

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

result

\[OutAttribute\] The result of the Hermite spline interpolation.

#### IsValid()

##### Declaration

##### Returns

Type

Description

System.Boolean

#### IsZero(Vector2, Single)

##### Declaration

```
public static bool IsZero(Vector2 value, float epsilon)
```

##### Parameters

Type

Name

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

value

System.Single

epsilon

##### Returns

Type

Description

System.Boolean

#### IsZero(ref Vector2)

##### Declaration

```
public static bool IsZero(ref Vector2 value)
```

##### Parameters

Type

Name

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

value

##### Returns

Type

Description

System.Boolean

#### IsZero(ref Vector2, Single)

##### Declaration

```
public static bool IsZero(ref Vector2 value, float epsilon)
```

##### Parameters

Type

Name

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

value

System.Single

epsilon

##### Returns

Type

Description

System.Boolean

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

#### Lerp(Vector2, Vector2, Single)

Performs a linear interpolation between two vectors.

##### Declaration

```
public static Vector2 Lerp(Vector2 value1, Vector2 value2, float amount)
```

##### Parameters

Type

Name

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

value1

Source vector.

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

value2

Source vector.

System.Single

amount

Value between 0 and 1 indicating the weight of value2.

##### Returns

Type

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

#### Lerp(ref Vector2, ref Vector2, Single, out Vector2)

Performs a linear interpolation between two vectors.

##### Declaration

```
public static void Lerp(ref Vector2 value1, ref Vector2 value2, float amount, out Vector2 result)
```

##### Parameters

Type

Name

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

value1

Source vector.

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

value2

Source vector.

System.Single

amount

Value between 0 and 1 indicating the weight of value2.

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

result

\[OutAttribute\] The result of the interpolation.

#### Max(Vector2, Vector2)

Returns a vector that contains the highest value from each matching pair of components.
