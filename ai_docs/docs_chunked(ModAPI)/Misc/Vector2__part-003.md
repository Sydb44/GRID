Description

System.Single

#### Distance(ref Vector2, ref Vector2, out Single)

Calculates the distance between two vectors.

##### Declaration

```
public static void Distance(ref Vector2 value1, ref Vector2 value2, out float result)
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

result

\[OutAttribute\] The distance between the vectors.

#### DistanceSquared(Vector2, Vector2)

Calculates the distance between two vectors squared.

##### Declaration

```
public static float DistanceSquared(Vector2 value1, Vector2 value2)
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

##### Returns

Type

Description

System.Single

#### DistanceSquared(ref Vector2, ref Vector2, out Single)

Calculates the distance between two vectors squared.

##### Declaration

```
public static void DistanceSquared(ref Vector2 value1, ref Vector2 value2, out float result)
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

result

\[OutAttribute\] The distance between the vectors squared.

#### Divide(Vector2, Single)

Divides a vector by a scalar value.

##### Declaration

```
public static Vector2 Divide(Vector2 value1, float divider)
```

##### Parameters

Type

Name

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

value1

Source vector.

System.Single

divider

The divisor.

##### Returns

Type

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

#### Divide(Vector2, Vector2)

Divides the components of a vector by the components of another vector.

##### Declaration

```
public static Vector2 Divide(Vector2 value1, Vector2 value2)
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

Divisor vector.

##### Returns

Type

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

#### Divide(ref Vector2, Single, out Vector2)

Divides a vector by a scalar value.

##### Declaration

```
public static void Divide(ref Vector2 value1, float divider, out Vector2 result)
```

##### Parameters

Type

Name

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

value1

Source vector.

System.Single

divider

The divisor.

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

result

\[OutAttribute\] The result of the division.

#### Divide(ref Vector2, ref Vector2, out Vector2)

Divides the components of a vector by the components of another vector.

##### Declaration

```
public static void Divide(ref Vector2 value1, ref Vector2 value2, out Vector2 result)
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

The divisor.

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

result

\[OutAttribute\] The result of the division.

#### Dot(Vector2, Vector2)

Calculates the dot product of two vectors. If the two vectors are unit vectors, the dot product returns a floating point value between -1 and 1 that can be used to determine some properties of the angle between two vectors. For example, it can show whether the vectors are orthogonal, parallel, or have an acute or obtuse angle between them.

##### Declaration

```
public static float Dot(Vector2 value1, Vector2 value2)
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

##### Returns

Type

Description

System.Single

#### Dot(ref Vector2, ref Vector2, out Single)

Calculates the dot product of two vectors and writes the result to a user-specified variable. If the two vectors are unit vectors, the dot product returns a floating point value between -1 and 1 that can be used to determine some properties of the angle between two vectors. For example, it can show whether the vectors are orthogonal, parallel, or have an acute or obtuse angle between them.

##### Declaration

```
public static void Dot(ref Vector2 value1, ref Vector2 value2, out float result)
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
