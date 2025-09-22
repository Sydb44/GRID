Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

vector1

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

vector2

System.Double

result

#### Dot(Vector3D)

##### Declaration

```
public double Dot(Vector3D v)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

v

##### Returns

Type

Description

System.Double

#### Dot(Vector3D, Vector3)

##### Declaration

```
public static double Dot(Vector3D vector1, Vector3 vector2)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

vector1

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

vector2

##### Returns

Type

Description

System.Double

#### Dot(Vector3D, Vector3D)

Calculates the dot product of two vectors. If the two vectors are unit vectors, the dot product returns a doubleing point value between -1 and 1 that can be used to determine some properties of the angle between two vectors. For example, it can show whether the vectors are orthogonal, parallel, or have an acute or obtuse angle between them.

##### Declaration

```
public static double Dot(Vector3D vector1, Vector3D vector2)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

vector1

Source vector.

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

vector2

Source vector.

##### Returns

Type

Description

System.Double

#### Dot(ref Vector3D)

##### Declaration

```
public double Dot(ref Vector3D v)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

v

##### Returns

Type

Description

System.Double

#### Dot(ref Vector3D, ref Vector3, out Double)

##### Declaration

```
public static void Dot(ref Vector3D vector1, ref Vector3 vector2, out double result)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

vector1

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

vector2

System.Double

result

#### Dot(ref Vector3D, ref Vector3D, out Double)

Calculates the dot product of two vectors and writes the result to a user-specified variable. If the two vectors are unit vectors, the dot product returns a doubleing point value between -1 and 1 that can be used to determine some properties of the angle between two vectors. For example, it can show whether the vectors are orthogonal, parallel, or have an acute or obtuse angle between them.

##### Declaration

```
public static void Dot(ref Vector3D vector1, ref Vector3D vector2, out double result)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

vector1

Source vector.

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

vector2

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

#### Equals(Vector3D)

Determines whether the specified Object is equal to the Vector3.

##### Declaration

```
public bool Equals(Vector3D other)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

other

The Vector3 to compare with the current Vector3.

##### Returns

Type

Description

System.Boolean

#### Equals(Vector3D, Double)

##### Declaration

```
public bool Equals(Vector3D other, double epsilon)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

other

System.Double

epsilon

##### Returns

Type

Description

System.Boolean

#### Floor(Vector3D)

##### Declaration

```
public static Vector3I Floor(Vector3D vect3d)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

vect3d

##### Returns

Type

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

#### Fract(ref Vector3D, out Vector3D)

##### Declaration

```
public static void Fract(ref Vector3D o, out Vector3D r)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

o

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

r

#### GetAzimuthAndElevation(Vector3D, out Double, out Double)

##### Declaration

```
public static void GetAzimuthAndElevation(Vector3D v, out double azimuth, out double elevation)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

v

System.Double

azimuth

System.Double

elevation

#### GetDim(Int32)

##### Declaration

```
public double GetDim(int i)
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

System.Double

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
