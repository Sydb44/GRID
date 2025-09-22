Description

System.Double

#### Distance(ref Vector3D, ref Vector3D, out Double)

Calculates the distance between two vectors.

##### Declaration

```
public static void Distance(ref Vector3D value1, ref Vector3D value2, out double result)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

value1

Source vector.

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

value2

Source vector.

System.Double

result

\[OutAttribute\] The distance between the vectors.

#### DistanceSquared(Vector3D, Vector3D)

Calculates the distance between two vectors squared.

##### Declaration

```
public static double DistanceSquared(Vector3D value1, Vector3D value2)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

value1

Source vector.

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

value2

Source vector.

##### Returns

Type

Description

System.Double

#### DistanceSquared(ref Vector3D, ref Vector3D, out Double)

Calculates the distance between two vectors squared.

##### Declaration

```
public static void DistanceSquared(ref Vector3D value1, ref Vector3D value2, out double result)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

value1

Source vector.

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

value2

Source vector.

System.Double

result

\[OutAttribute\] The distance between the two vectors squared.

#### Divide(Vector3D, Double)

Divides a vector by a scalar value.

##### Declaration

```
public static Vector3D Divide(Vector3D value1, double value2)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

value1

Source vector.

System.Double

value2

The divisor.

##### Returns

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### Divide(Vector3D, Vector3D)

Divides the components of a vector by the components of another vector.

##### Declaration

```
public static Vector3D Divide(Vector3D value1, Vector3D value2)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

value1

Source vector.

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

value2

Divisor vector.

##### Returns

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### Divide(ref Vector3D, Double, out Vector3D)

Divides a vector by a scalar value.

##### Declaration

```
public static void Divide(ref Vector3D value1, double value2, out Vector3D result)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

value1

Source vector.

System.Double

value2

The divisor.

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

result

\[OutAttribute\] The result of the division.

#### Divide(ref Vector3D, ref Vector3D, out Vector3D)

Divides the components of a vector by the components of another vector.

##### Declaration

```
public static void Divide(ref Vector3D value1, ref Vector3D value2, out Vector3D result)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

value1

Source vector.

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

value2

The divisor.

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

result

\[OutAttribute\] The result of the division.

#### DominantAxisProjection(Vector3D)

Returns a vector that is equal to the projection of the input vector to the coordinate axis that corresponds to the original vector's largest value.

##### Declaration

```
public static Vector3D DominantAxisProjection(Vector3D value1)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

value1

Source vector.

##### Returns

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### DominantAxisProjection(ref Vector3D, out Vector3D)

Calculates a vector that is equal to the projection of the input vector to the coordinate axis that corresponds to the original vector's largest value. The result is saved into a user-specified variable.

##### Declaration

```
public static void DominantAxisProjection(ref Vector3D value1, out Vector3D result)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

value1

Source vector.

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

result

\[OutAttribute\] The projected vector.

#### Dot(Vector3)

##### Declaration

```
public double Dot(Vector3 v)
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

System.Double

#### Dot(ref Vector3, ref Vector3D, out Double)

##### Declaration

```
public static void Dot(ref Vector3 vector1, ref Vector3D vector2, out double result)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

vector1

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

vector2

System.Double

result
