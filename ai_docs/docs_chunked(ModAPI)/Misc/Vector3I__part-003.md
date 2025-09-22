value1

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

min

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

max

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

result

#### CompareTo(Vector3I)

##### Declaration

```
public int CompareTo(Vector3I other)
```

##### Parameters

Type

Name

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

other

##### Returns

Type

Description

System.Int32

#### Cross(ref Vector3I, ref Vector3I, out Vector3I)

Calculates the cross product of two vectors.

##### Declaration

```
public static void Cross(ref Vector3I vector1, ref Vector3I vector2, out Vector3I result)
```

##### Parameters

Type

Name

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

vector1

Source vector.

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

vector2

Source vector.

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

result

\[OutAttribute\] The cross product of the vectors.

#### DistanceManhattan(Vector3I, Vector3I)

Manhattan distance (cube distance) X + Y + Z of Abs(first - second)

##### Declaration

```
public static int DistanceManhattan(Vector3I first, Vector3I second)
```

##### Parameters

Type

Name

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

first

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

second

##### Returns

Type

Description

System.Int32

#### DominantAxisProjection(Vector3I)

Returns a vector that is equal to the projection of the input vector to the coordinate axis that corresponds to the original vector's largest value.

##### Declaration

```
public static Vector3I DominantAxisProjection(Vector3I value1)
```

##### Parameters

Type

Name

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

value1

Source vector.

##### Returns

Type

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

#### DominantAxisProjection(ref Vector3I, out Vector3I)

Calculates a vector that is equal to the projection of the input vector to the coordinate axis that corresponds to the original vector's largest value. The result is saved into a user-specified variable.

##### Declaration

```
public static void DominantAxisProjection(ref Vector3I value1, out Vector3I result)
```

##### Parameters

Type

Name

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

value1

Source vector.

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

result

\[OutAttribute\] The projected vector.

#### Dot(Vector3I, Vector3I)

##### Declaration

```
public static int Dot(Vector3I vector1, Vector3I vector2)
```

##### Parameters

Type

Name

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

vector1

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

vector2

##### Returns

Type

Description

System.Int32

#### Dot(ref Vector3I)

##### Declaration

```
public int Dot(ref Vector3I v)
```

##### Parameters

Type

Name

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

v

##### Returns

Type

Description

System.Int32

#### Dot(ref Vector3I, ref Vector3I)

##### Declaration

```
public static int Dot(ref Vector3I vector1, ref Vector3I vector2)
```

##### Parameters

Type

Name

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

vector1

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

vector2

##### Returns

Type

Description

System.Int32

#### Dot(ref Vector3I, ref Vector3I, out Int32)

##### Declaration

```
public static void Dot(ref Vector3I vector1, ref Vector3I vector2, out int dot)
```

##### Parameters

Type

Name

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

vector1

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

vector2

System.Int32

dot

#### EnumerateRange(Vector3I, Vector3I)

Enumerate all values in a integer interval (a cuboid).

This method is an allocating version of the Vector3I\_RangeIterator. This once can be used in the foreach syntax though so it's more convenient for debug routines.

##### Declaration

```
public static IEnumerable<Vector3I> EnumerateRange(Vector3I minInclusive, Vector3I maxExclusive)
```

##### Parameters

Type

Name

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

minInclusive

Minimum range (inclusive)

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

maxExclusive

Maximum range (exclusive)

##### Returns

Type

Description

System.Collections.Generic.IEnumerable<[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)\>

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

#### Equals(Vector3I)

##### Declaration

```
public bool Equals(Vector3I other)
```

##### Parameters

Type

Name

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

other

##### Returns

Type

Description

System.Boolean
