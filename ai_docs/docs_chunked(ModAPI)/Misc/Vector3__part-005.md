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

System.Single

#### Distance(ref Vector3, ref Vector3, out Single)

Calculates the distance between two vectors.

##### Declaration

```
public static void Distance(ref Vector3 value1, ref Vector3 value2, out float result)
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

result

\[OutAttribute\] The distance between the vectors.

#### DistanceSquared(Vector3, Vector3)

Calculates the distance between two vectors squared.

##### Declaration

```
public static float DistanceSquared(Vector3 value1, Vector3 value2)
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

System.Single

#### DistanceSquared(ref Vector3, ref Vector3, out Single)

Calculates the distance between two vectors squared.

##### Declaration

```
public static void DistanceSquared(ref Vector3 value1, ref Vector3 value2, out float result)
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

result

\[OutAttribute\] The distance between the two vectors squared.

#### Divide(Single)

##### Declaration

```
public void Divide(float divider)
```

##### Parameters

Type

Name

Description

System.Single

divider

#### Divide(Vector3, Single)

Divides a vector by a scalar value.

##### Declaration

```
public static Vector3 Divide(Vector3 value1, float value2)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

value1

Source vector.

System.Single

value2

The divisor.

##### Returns

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### Divide(Vector3, Vector3)

Divides the components of a vector by the components of another vector.

##### Declaration

```
public static Vector3 Divide(Vector3 value1, Vector3 value2)
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

Divisor vector.

##### Returns

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### Divide(ref Vector3, Single, out Vector3)

Divides a vector by a scalar value.

##### Declaration

```
public static void Divide(ref Vector3 value1, float value2, out Vector3 result)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

value1

Source vector.

System.Single

value2

The divisor.

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

result

\[OutAttribute\] The result of the division.

#### Divide(ref Vector3, ref Vector3, out Vector3)

Divides the components of a vector by the components of another vector.

##### Declaration

```
public static void Divide(ref Vector3 value1, ref Vector3 value2, out Vector3 result)
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

The divisor.

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

result

\[OutAttribute\] The result of the division.

#### DominantAxisProjection(Vector3)

Returns a vector that is equal to the projection of the input vector to the coordinate axis that corresponds to the original vector's largest value.

##### Declaration

```
public static Vector3 DominantAxisProjection(Vector3 value1)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

value1

Source vector.

##### Returns

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### DominantAxisProjection(ref Vector3, out Vector3)

Calculates a vector that is equal to the projection of the input vector to the coordinate axis that corresponds to the original vector's largest value. The result is saved into a user-specified variable.

##### Declaration

```
public static void DominantAxisProjection(ref Vector3 value1, out Vector3 result)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

value1

Source vector.

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

result

\[OutAttribute\] The projected vector.

#### Dot(Vector3)

##### Declaration

```
public float Dot(Vector3 v)
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

#### Dot(Vector3, Vector3)

Calculates the dot product of two vectors. If the two vectors are unit vectors, the dot product returns a floating point value between -1 and 1 that can be used to determine some properties of the angle between two vectors. For example, it can show whether the vectors are orthogonal, parallel, or have an acute or obtuse angle between them.
