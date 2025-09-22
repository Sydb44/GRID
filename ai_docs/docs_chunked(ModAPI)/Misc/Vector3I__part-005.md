Type

Name

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

value1

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

value2

##### Returns

Type

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

#### Min(ref Vector3I, ref Vector3I, out Vector3I)

##### Declaration

```
public static void Min(ref Vector3I value1, ref Vector3I value2, out Vector3I result)
```

##### Parameters

Type

Name

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

value1

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

value2

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

result

#### MinMax(ref Vector3I, ref Vector3I)

Separates minimal and maximal values of any two input vectors

##### Declaration

```
public static void MinMax(ref Vector3I min, ref Vector3I max)
```

##### Parameters

Type

Name

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

min

minimal values of the two vectors

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

max

maximal values of the two vectors

#### RectangularDistance(Vector3I)

Calculates rectangular distance. It's how many sectors you have to travel to get to other sector from current sector.

##### Declaration

```
public int RectangularDistance(Vector3I otherVector)
```

##### Parameters

Type

Name

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

otherVector

##### Returns

Type

Description

System.Int32

#### RectangularLength()

Calculates rectangular distance of this vector, interpreted as a point, from the origin.

##### Declaration

```
public int RectangularLength()
```

##### Returns

Type

Description

System.Int32

#### Round(Vector3)

##### Declaration

```
public static Vector3I Round(Vector3 value)
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

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

#### Round(ref Vector3, out Vector3I)

##### Declaration

```
public static void Round(ref Vector3 v, out Vector3I r)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

v

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

r

#### Round(Vector3D)

##### Declaration

```
public static Vector3I Round(Vector3D value)
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

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

#### Round(ref Vector3D, out Vector3I)

##### Declaration

```
public static void Round(ref Vector3D v, out Vector3I r)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

v

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

r

#### Shift(Vector3I)

##### Declaration

```
public static Vector3I Shift(Vector3I value)
```

##### Parameters

Type

Name

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

value

##### Returns

Type

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

#### Sign(Vector3)

##### Declaration

```
public static Vector3I Sign(Vector3 value)
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

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

#### Sign(Vector3I)

##### Declaration

```
public static Vector3I Sign(Vector3I value)
```

##### Parameters

Type

Name

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

value

##### Returns

Type

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

#### ToBytes(List<Byte>)

##### Declaration

```
public void ToBytes(List<byte> result)
```

##### Parameters

Type

Name

Description

System.Collections.Generic.List<System.Byte\>

result

#### ToString()

##### Declaration

```
public override string ToString()
```

##### Returns

Type

Description

System.String

#### Transform(Vector3I, MatrixI)

##### Declaration

```
public static Vector3I Transform(Vector3I value, MatrixI transformation)
```

##### Parameters

Type

Name

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

value

[MatrixI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixI.html)

transformation

##### Returns

Type

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

#### Transform(Vector3I, ref MatrixI)

##### Declaration

```
public static Vector3I Transform(Vector3I value, ref MatrixI transformation)
```

##### Parameters

Type

Name

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

value

[MatrixI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixI.html)

transformation

##### Returns

Type

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)
