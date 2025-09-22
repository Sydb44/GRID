v

##### Returns

Type

Description

System.Single

#### Dot(Vector3, Vector3)

Calculates the dot product of two vectors. If the two vectors are unit vectors, the dot product returns a floating point value between -1 and 1 that can be used to determine some properties of the angle between two vectors. For example, it can show whether the vectors are orthogonal, parallel, or have an acute or obtuse angle between them.

##### Declaration

```
public static float Dot(Vector3 vector1, Vector3 vector2)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

vector1

Source vector.

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

vector2

Source vector.

##### Returns

Type

Description

System.Single

#### Dot(ref Vector3)

##### Declaration

```
public float Dot(ref Vector3 v)
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

System.Single

#### Dot(ref Vector3, ref Vector3, out Single)

Calculates the dot product of two vectors and writes the result to a user-specified variable. If the two vectors are unit vectors, the dot product returns a floating point value between -1 and 1 that can be used to determine some properties of the angle between two vectors. For example, it can show whether the vectors are orthogonal, parallel, or have an acute or obtuse angle between them.

##### Declaration

```
public static void Dot(ref Vector3 vector1, ref Vector3 vector2, out float result)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

vector1

Source vector.

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

vector2

Source vector.

System.Single

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

#### Equals(Vector3)

Determines whether the specified Object is equal to the Vector3.

##### Declaration

```
public bool Equals(Vector3 other)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

other

The Vector3 to compare with the current Vector3.

##### Returns

Type

Description

System.Boolean

#### Equals(Vector3, Single)

##### Declaration

```
public bool Equals(Vector3 other, float epsilon)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

other

System.Single

epsilon

##### Returns

Type

Description

System.Boolean

#### Floor(Vector3)

##### Declaration

```
public static Vector3 Floor(Vector3 v)
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

#### GetAzimuthAndElevation(Vector3, out Single, out Single)

##### Declaration

```
public static void GetAzimuthAndElevation(Vector3 v, out float azimuth, out float elevation)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

v

System.Single

azimuth

System.Single

elevation

#### GetDim(Int32)

##### Declaration

```
public float GetDim(int i)
```

##### Parameters

Type

Name

Description

System.Int32

i

##### Returns

Type

Description

System.Single

#### GetHash()

Gets the hash code of the vector object.

##### Declaration

##### Returns

Type

Description

System.Int64

#### GetHashCode()

##### Declaration

```
public override int GetHashCode()
```

##### Returns

Type

Description

System.Int32

#### GetNormalized(ref Vector3)

##### Declaration

```
public static bool GetNormalized(ref Vector3 value)
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

#### Hermite(Vector3, Vector3, Vector3, Vector3, Single)

Performs a Hermite spline interpolation.

##### Declaration

```
public static Vector3 Hermite(Vector3 value1, Vector3 tangent1, Vector3 value2, Vector3 tangent2, float amount)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

value1

Source position vector.

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

tangent1

Source tangent vector.

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

value2

Source position vector.

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

tangent2

Source tangent vector.

System.Single

amount

Weighting factor.

##### Returns

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### Hermite(ref Vector3, ref Vector3, ref Vector3, ref Vector3, Single, out Vector3)

Performs a Hermite spline interpolation.

##### Declaration

```
public static void Hermite(ref Vector3 value1, ref Vector3 tangent1, ref Vector3 value2, ref Vector3 tangent2, float amount, out Vector3 result)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

value1

Source position vector.

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

tangent1

Source tangent vector.

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

value2

Source position vector.

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

tangent2

Source tangent vector.

System.Single

amount

Weighting factor.

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

result

\[OutAttribute\] The result of the Hermite spline interpolation.
