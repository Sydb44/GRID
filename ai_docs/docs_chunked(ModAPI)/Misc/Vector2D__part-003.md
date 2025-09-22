Source vector.

##### Returns

Type

Description

System.Double

#### Distance(ref Vector2D, ref Vector2D, out Double)

Calculates the distance between two vectors.

##### Declaration

```
public static void Distance(ref Vector2D value1, ref Vector2D value2, out double result)
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

result

\[OutAttribute\] The distance between the vectors.

#### DistanceSquared(Vector2D, Vector2D)

Calculates the distance between two vectors squared.

##### Declaration

```
public static double DistanceSquared(Vector2D value1, Vector2D value2)
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

System.Double

#### DistanceSquared(ref Vector2D, ref Vector2D, out Double)

Calculates the distance between two vectors squared.

##### Declaration

```
public static void DistanceSquared(ref Vector2D value1, ref Vector2D value2, out double result)
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

result

\[OutAttribute\] The distance between the vectors squared.

#### Divide(Vector2D, Double)

Divides a vector by a scalar value.

##### Declaration

```
public static Vector2D Divide(Vector2D value1, double divider)
```

##### Parameters

Type

Name

Description

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

value1

Source vector.

System.Double

divider

The divisor.

##### Returns

Type

Description

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

#### Divide(Vector2D, Vector2D)

Divides the components of a vector by the components of another vector.

##### Declaration

```
public static Vector2D Divide(Vector2D value1, Vector2D value2)
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

Divisor vector.

##### Returns

Type

Description

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

#### Divide(ref Vector2D, Double, out Vector2D)

Divides a vector by a scalar value.

##### Declaration

```
public static void Divide(ref Vector2D value1, double divider, out Vector2D result)
```

##### Parameters

Type

Name

Description

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

value1

Source vector.

System.Double

divider

The divisor.

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

result

\[OutAttribute\] The result of the division.

#### Divide(ref Vector2D, ref Vector2D, out Vector2D)

Divides the components of a vector by the components of another vector.

##### Declaration

```
public static void Divide(ref Vector2D value1, ref Vector2D value2, out Vector2D result)
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

The divisor.

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

result

\[OutAttribute\] The result of the division.

#### Dot(Vector2D, Vector2D)

Calculates the dot product of two vectors. If the two vectors are unit vectors, the dot product returns a doubleing point value between -1 and 1 that can be used to determine some properties of the angle between two vectors. For example, it can show whether the vectors are orthogonal, parallel, or have an acute or obtuse angle between them.

##### Declaration

```
public static double Dot(Vector2D value1, Vector2D value2)
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

System.Double

#### Dot(ref Vector2D, ref Vector2D, out Double)

Calculates the dot product of two vectors and writes the result to a user-specified variable. If the two vectors are unit vectors, the dot product returns a doubleing point value between -1 and 1 that can be used to determine some properties of the angle between two vectors. For example, it can show whether the vectors are orthogonal, parallel, or have an acute or obtuse angle between them.

##### Declaration

```
public static void Dot(ref Vector2D value1, ref Vector2D value2, out double result)
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

result

\[OutAttribute\] The dot product of the two vectors.

#### Equals(Object)

Returns a value that indicates whether the current instance is equal to a specified object.

##### Declaration

```
public override bool Equals(object obj)
```
