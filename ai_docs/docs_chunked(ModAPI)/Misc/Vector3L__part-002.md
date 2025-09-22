Type

Name

Description

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

value

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

result

#### AbsMax()

Returns the component of the vector, whose absolute value is largest of all the three components.

##### Declaration

##### Returns

Type

Description

System.Int64

#### AbsMin()

Returns the component of the vector, whose absolute value is smallest of all the three components.

##### Declaration

##### Returns

Type

Description

System.Int64

#### AxisValue(Base6Directions.Axis)

##### Declaration

```
public long AxisValue(Base6Directions.Axis axis)
```

##### Parameters

Type

Name

Description

[Base6Directions.Axis](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.Axis.html)

axis

##### Returns

Type

Description

System.Int64

#### BoxContains(Vector3L, Vector3L, Vector3L)

##### Declaration

```
public static bool BoxContains(Vector3L boxMin, Vector3L boxMax, Vector3L pt)
```

##### Parameters

Type

Name

Description

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

boxMin

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

boxMax

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

pt

##### Returns

Type

Description

System.Boolean

#### BoxContains(ref Vector3L, ref Vector3L, ref Vector3L)

##### Declaration

```
public static bool BoxContains(ref Vector3L boxMin, ref Vector3L boxMax, ref Vector3L pt)
```

##### Parameters

Type

Name

Description

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

boxMin

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

boxMax

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

pt

##### Returns

Type

Description

System.Boolean

#### Boxlongersects(Vector3L, Vector3L, Vector3L, Vector3L)

##### Declaration

```
public static bool Boxlongersects(Vector3L minA, Vector3L maxA, Vector3L minB, Vector3L maxB)
```

##### Parameters

Type

Name

Description

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

minA

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

maxA

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

minB

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

maxB

##### Returns

Type

Description

System.Boolean

#### Boxlongersects(ref Vector3L, ref Vector3L, ref Vector3L, ref Vector3L)

##### Declaration

```
public static bool Boxlongersects(ref Vector3L minA, ref Vector3L maxA, ref Vector3L minB, ref Vector3L maxB)
```

##### Parameters

Type

Name

Description

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

minA

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

maxA

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

minB

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

maxB

##### Returns

Type

Description

System.Boolean

#### Ceiling(Vector3)

##### Declaration

```
public static Vector3L Ceiling(Vector3 value)
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

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

#### Clamp(Vector3L, Vector3L, Vector3L)

##### Declaration

```
public static Vector3L Clamp(Vector3L value1, Vector3L min, Vector3L max)
```

##### Parameters

Type

Name

Description

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

value1

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

min

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

max

##### Returns

Type

Description

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

#### Clamp(ref Vector3L, ref Vector3L, ref Vector3L, out Vector3L)

##### Declaration

```
public static void Clamp(ref Vector3L value1, ref Vector3L min, ref Vector3L max, out Vector3L result)
```

##### Parameters

Type

Name

Description

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

value1

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

min

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

max

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

result

#### CompareTo(Vector3L)

##### Declaration

```
public int CompareTo(Vector3L other)
```

##### Parameters

Type

Name

Description

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

other

##### Returns

Type

Description

System.Int32

#### Cross(ref Vector3L, ref Vector3L, out Vector3L)

Calculates the cross product of two vectors.

##### Declaration

```
public static void Cross(ref Vector3L vector1, ref Vector3L vector2, out Vector3L result)
```

##### Parameters

Type

Name

Description

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

vector1

Source vector.

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

vector2

Source vector.

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

result

\[OutAttribute\] The cross product of the vectors.
