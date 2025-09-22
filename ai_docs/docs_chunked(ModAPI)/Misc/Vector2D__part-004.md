result

\[OutAttribute\] The dot product of the two vectors.

#### Equals(Object)

Returns a value that indicates whether the current instance is equal to a specified object.

##### Declaration

```
public override bool Equals(object obj)
```

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

#### Equals(Vector2D)

Determines whether the specified Object is equal to the Vector2D.

##### Declaration

```
public bool Equals(Vector2D other)
```

##### Parameters

Type

Name

Description

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

other

The Object to compare with the current Vector2D.

##### Returns

Type

Description

System.Boolean

#### Floor(Vector2D)

##### Declaration

```
public static Vector2D Floor(Vector2D position)
```

##### Parameters

Type

Name

Description

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

position

##### Returns

Type

Description

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

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

#### Hermite(Vector2D, Vector2D, Vector2D, Vector2D, Double)

Performs a Hermite spline interpolation.

##### Declaration

```
public static Vector2D Hermite(Vector2D value1, Vector2D tangent1, Vector2D value2, Vector2D tangent2, double amount)
```

##### Parameters

Type

Name

Description

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

value1

Source position vector.

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

tangent1

Source tangent vector.

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

value2

Source position vector.

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

tangent2

Source tangent vector.

System.Double

amount

Weighting factor.

##### Returns

Type

Description

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

#### Hermite(ref Vector2D, ref Vector2D, ref Vector2D, ref Vector2D, Double, out Vector2D)

Performs a Hermite spline interpolation.

##### Declaration

```
public static void Hermite(ref Vector2D value1, ref Vector2D tangent1, ref Vector2D value2, ref Vector2D tangent2, double amount, out Vector2D result)
```

##### Parameters

Type

Name

Description

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

value1

Source position vector.

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

tangent1

Source tangent vector.

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

value2

Source position vector.

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

tangent2

Source tangent vector.

System.Double

amount

Weighting factor.

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

result

\[OutAttribute\] The result of the Hermite spline interpolation.

#### IsValid()

##### Declaration

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

System.Double

#### LengthSquared()

Calculates the length of the vector squared.

##### Declaration

```
public double LengthSquared()
```

##### Returns

Type

Description

System.Double

#### Lerp(Vector2D, Vector2D, Double)

Performs a linear interpolation between two vectors.

##### Declaration

```
public static Vector2D Lerp(Vector2D value1, Vector2D value2, double amount)
```

##### Parameters

Type

Name

Description

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

value1

Source vector.

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

value2

Source vector.

System.Double

amount

Value between 0 and 1 indicating the weight of value2.

##### Returns

Type

Description

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

#### Lerp(ref Vector2D, ref Vector2D, Double, out Vector2D)

Performs a linear interpolation between two vectors.

##### Declaration

```
public static void Lerp(ref Vector2D value1, ref Vector2D value2, double amount, out Vector2D result)
```

##### Parameters

Type

Name

Description

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

value1

Source vector.

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

value2

Source vector.

System.Double

amount

Value between 0 and 1 indicating the weight of value2.

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

result

\[OutAttribute\] The result of the interpolation.

#### Max(Vector2D, Vector2D)

Returns a vector that contains the highest value from each matching pair of components.

##### Declaration

```
public static Vector2D Max(Vector2D value1, Vector2D value2)
```

##### Parameters

Type

Name

Description

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

value1

Source vector.

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

value2

Source vector.

##### Returns

Type

Description

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

#### Max(ref Vector2D, ref Vector2D, out Vector2D)

Returns a vector that contains the highest value from each matching pair of components.
