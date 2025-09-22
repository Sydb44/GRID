```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

value

##### Returns

Type

Description

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

#### Floor(ref Vector3D, out Vector3L)

##### Declaration

```
public static void Floor(ref Vector3D v, out Vector3L r)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

v

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

r

#### GetDominantDirection(Vector3L)

##### Declaration

```
public static CubeFace GetDominantDirection(Vector3L val)
```

##### Parameters

Type

Name

Description

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

val

##### Returns

Type

Description

[CubeFace](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.CubeFace.html)

#### GetDominantDirectionVector(Vector3L)

##### Declaration

```
public static Vector3L GetDominantDirectionVector(Vector3L val)
```

##### Parameters

Type

Name

Description

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

val

##### Returns

Type

Description

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

#### GetHashCode()

##### Declaration

```
public override int GetHashCode()
```

##### Returns

Type

Description

System.Int32

#### IsInside(Vector3L, Vector3L)

##### Declaration

```
public bool IsInside(Vector3L inclusiveMin, Vector3L exclusiveMax)
```

##### Parameters

Type

Name

Description

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

inclusiveMin

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

exclusiveMax

##### Returns

Type

Description

System.Boolean

#### IsInside(ref Vector3L, ref Vector3L)

##### Declaration

```
public bool IsInside(ref Vector3L inclusiveMin, ref Vector3L exclusiveMax)
```

##### Parameters

Type

Name

Description

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

inclusiveMin

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

exclusiveMax

##### Returns

Type

Description

System.Boolean

#### IsInsideInclusiveEnd(Vector3L, Vector3L)

##### Declaration

```
public bool IsInsideInclusiveEnd(Vector3L min, Vector3L max)
```

##### Parameters

Type

Name

Description

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

min

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

max

##### Returns

Type

Description

System.Boolean

#### IsInsideInclusiveEnd(ref Vector3L, ref Vector3L)

##### Declaration

```
public bool IsInsideInclusiveEnd(ref Vector3L min, ref Vector3L max)
```

##### Parameters

Type

Name

Description

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

min

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

max

##### Returns

Type

Description

System.Boolean

#### Length()

##### Declaration

##### Returns

Type

Description

System.Int64

#### Max(Vector3L, Vector3L)

##### Declaration

```
public static Vector3L Max(Vector3L value1, Vector3L value2)
```

##### Parameters

Type

Name

Description

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

value1

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

value2

##### Returns

Type

Description

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

#### Max(ref Vector3L, ref Vector3L, out Vector3L)

##### Declaration

```
public static void Max(ref Vector3L value1, ref Vector3L value2, out Vector3L result)
```

##### Parameters

Type

Name

Description

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

value1

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

value2

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

result

#### Min(Vector3L, Vector3L)

##### Declaration

```
public static Vector3L Min(Vector3L value1, Vector3L value2)
```

##### Parameters

Type

Name

Description

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

value1

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

value2

##### Returns

Type

Description

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

#### Min(ref Vector3L, ref Vector3L, out Vector3L)

##### Declaration

```
public static void Min(ref Vector3L value1, ref Vector3L value2, out Vector3L result)
```

##### Parameters

Type

Name

Description

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

value1

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

value2

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

result

#### RectangularDistance(Vector3L)

Calculates rectangular distance. It's how many sectors you have to travel to get to other sector from current sector.

##### Declaration

```
public long RectangularDistance(Vector3L otherVector)
```

##### Parameters

Type

Name

Description

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

otherVector

##### Returns

Type

Description

System.Int64

#### RectangularLength()

Calculates rectangular distance of this vector, longerpreted as a polong, from the origin.
