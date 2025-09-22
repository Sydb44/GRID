result

\[OutAttribute\] A vector that is the result of the Catmull-Rom interpolation.

#### Clamp(Vector3D, Vector3D, Vector3D)

Restricts a value to be within a specified range.

##### Declaration

```
public static Vector3D Clamp(Vector3D value1, Vector3D min, Vector3D max)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

value1

The value to clamp.

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

min

The minimum value.

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

max

The maximum value.

##### Returns

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### Clamp(ref Vector3D, ref Vector3D, ref Vector3D, out Vector3D)

Restricts a value to be within a specified range.

##### Declaration

```
public static void Clamp(ref Vector3D value1, ref Vector3D min, ref Vector3D max, out Vector3D result)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

value1

The value to clamp.

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

min

The minimum value.

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

max

The maximum value.

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

result

\[OutAttribute\] The clamped value.

#### ClampToSphere(Vector3D, Double, Boolean)

##### Declaration

```
public static Vector3D ClampToSphere(Vector3D vector, double radius, bool force = false)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

vector

System.Double

radius

System.Boolean

force

##### Returns

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### ClampToSphere(ref Vector3D, Double)

##### Declaration

```
public static void ClampToSphere(ref Vector3D vector, double radius)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

vector

System.Double

radius

#### CreateFromAzimuthAndElevation(Double, Double, out Vector3D)

##### Declaration

```
public static void CreateFromAzimuthAndElevation(double azimuth, double elevation, out Vector3D direction)
```

##### Parameters

Type

Name

Description

System.Double

azimuth

System.Double

elevation

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

direction

#### Cross(Vector3D)

##### Declaration

```
public Vector3D Cross(Vector3D v)
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

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### Cross(Vector3D, Vector3D)

Calculates the cross product of two vectors.

##### Declaration

```
public static Vector3D Cross(Vector3D vector1, Vector3D vector2)
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

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### Cross(ref Vector3D, ref Vector3D, out Vector3D)

Calculates the cross product of two vectors.

##### Declaration

```
public static void Cross(ref Vector3D vector1, ref Vector3D vector2, out Vector3D result)
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

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

result

\[OutAttribute\] The cross product of the vectors.

#### Distance(Vector3, Vector3D)

##### Declaration

```
public static double Distance(Vector3 value1, Vector3D value2)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

value1

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

value2

##### Returns

Type

Description

System.Double

#### Distance(Vector3D, Vector3)

##### Declaration

```
public static double Distance(Vector3D value1, Vector3 value2)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

value1

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

value2

##### Returns

Type

Description

System.Double

#### Distance(Vector3D, Vector3D)

Calculates the distance between two vectors.

##### Declaration

```
public static double Distance(Vector3D value1, Vector3D value2)
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

#### Distance(ref Vector3D, ref Vector3D, out Double)

Calculates the distance between two vectors.

##### Declaration

```
public static void Distance(ref Vector3D value1, ref Vector3D value2, out double result)
```
