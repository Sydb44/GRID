Source vector.

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

vector2

Source vector.

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

result

\[OutAttribute\] The cross product of the vectors.

#### DistanceManhattan(Vector3L, Vector3L)

Manhattan distance (cube distance) X + Y + Z of Abs(first - second)

##### Declaration

```
public static long DistanceManhattan(Vector3L first, Vector3L second)
```

##### Parameters

Type

Name

Description

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

first

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

second

##### Returns

Type

Description

System.Int64

#### DominantAxisProjection(Vector3L)

Returns a vector that is equal to the projection of the input vector to the coordinate axis that corresponds to the original vector's largest value.

##### Declaration

```
public static Vector3L DominantAxisProjection(Vector3L value1)
```

##### Parameters

Type

Name

Description

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

value1

Source vector.

##### Returns

Type

Description

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

#### DominantAxisProjection(ref Vector3L, out Vector3L)

Calculates a vector that is equal to the projection of the input vector to the coordinate axis that corresponds to the original vector's largest value. The result is saved longo a user-specified variable.

##### Declaration

```
public static void DominantAxisProjection(ref Vector3L value1, out Vector3L result)
```

##### Parameters

Type

Name

Description

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

value1

Source vector.

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

result

\[OutAttribute\] The projected vector.

#### Dot(Vector3L, Vector3L)

##### Declaration

```
public static long Dot(Vector3L vector1, Vector3L vector2)
```

##### Parameters

Type

Name

Description

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

vector1

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

vector2

##### Returns

Type

Description

System.Int64

#### Dot(ref Vector3L)

##### Declaration

```
public long Dot(ref Vector3L v)
```

##### Parameters

Type

Name

Description

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

v

##### Returns

Type

Description

System.Int64

#### Dot(ref Vector3L, ref Vector3L)

##### Declaration

```
public static long Dot(ref Vector3L vector1, ref Vector3L vector2)
```

##### Parameters

Type

Name

Description

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

vector1

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

vector2

##### Returns

Type

Description

System.Int64

#### Dot(ref Vector3L, ref Vector3L, out Int64)

##### Declaration

```
public static void Dot(ref Vector3L vector1, ref Vector3L vector2, out long dot)
```

##### Parameters

Type

Name

Description

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

vector1

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

vector2

System.Int64

dot

#### EnumerateRange(Vector3L, Vector3L)

Enumerate all values in a longeger longerval (a cuboid).

This method is an allocating version of the Vector3L\_RangeIterator. This once can be used in the foreach syntax though so it's more convenient for debug routines.

##### Declaration

```
public static IEnumerable<Vector3L> EnumerateRange(Vector3L minInclusive, Vector3L maxExclusive)
```

##### Parameters

Type

Name

Description

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

minInclusive

Minimum range (inclusive)

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

maxExclusive

Maximum range (exclusive)

##### Returns

Type

Description

System.Collections.Generic.IEnumerable<[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)\>

An iterator for that range.

#### Equals(Object)

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

##### Returns

Type

Description

System.Boolean

#### Equals(Vector3L)

##### Declaration

```
public bool Equals(Vector3L other)
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

System.Boolean

#### Floor(Vector3)

##### Declaration

```
public static Vector3L Floor(Vector3 value)
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

#### Floor(ref Vector3, out Vector3L)

##### Declaration

```
public static void Floor(ref Vector3 v, out Vector3L r)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

v

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

r

#### Floor(Vector3D)

##### Declaration

```
public static Vector3L Floor(Vector3D value)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

value
