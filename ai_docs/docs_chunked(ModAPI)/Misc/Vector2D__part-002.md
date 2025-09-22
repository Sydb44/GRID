Barycentric coordinate b2, which expresses the weighting factor toward vertex 2 (specified in value2).

System.Double

amount2

Barycentric coordinate b3, which expresses the weighting factor toward vertex 3 (specified in value3).

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

result

\[OutAttribute\] The 2D Cartesian coordinates of the specified point are placed in this Vector2D on exit.

#### Between(ref Vector2D, ref Vector2D)

##### Declaration

```
public bool Between(ref Vector2D start, ref Vector2D end)
```

##### Parameters

Type

Name

Description

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

start

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

end

##### Returns

Type

Description

System.Boolean

#### CatmullRom(Vector2D, Vector2D, Vector2D, Vector2D, Double)

Performs a Catmull-Rom interpolation using the specified positions.

##### Declaration

```
public static Vector2D CatmullRom(Vector2D value1, Vector2D value2, Vector2D value3, Vector2D value4, double amount)
```

##### Parameters

Type

Name

Description

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

value1

The first position in the interpolation.

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

value2

The second position in the interpolation.

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

value3

The third position in the interpolation.

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

value4

The fourth position in the interpolation.

System.Double

amount

Weighting factor.

##### Returns

Type

Description

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

#### CatmullRom(ref Vector2D, ref Vector2D, ref Vector2D, ref Vector2D, Double, out Vector2D)

Performs a Catmull-Rom interpolation using the specified positions.

##### Declaration

```
public static void CatmullRom(ref Vector2D value1, ref Vector2D value2, ref Vector2D value3, ref Vector2D value4, double amount, out Vector2D result)
```

##### Parameters

Type

Name

Description

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

value1

The first position in the interpolation.

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

value2

The second position in the interpolation.

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

value3

The third position in the interpolation.

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

value4

The fourth position in the interpolation.

System.Double

amount

Weighting factor.

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

result

\[OutAttribute\] A vector that is the result of the Catmull-Rom interpolation.

#### Clamp(Vector2D, Vector2D, Vector2D)

Restricts a value to be within a specified range.

##### Declaration

```
public static Vector2D Clamp(Vector2D value1, Vector2D min, Vector2D max)
```

##### Parameters

Type

Name

Description

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

value1

The value to clamp.

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

min

The minimum value.

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

max

The maximum value.

##### Returns

Type

Description

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

#### Clamp(ref Vector2D, ref Vector2D, ref Vector2D, out Vector2D)

Restricts a value to be within a specified range.

##### Declaration

```
public static void Clamp(ref Vector2D value1, ref Vector2D min, ref Vector2D max, out Vector2D result)
```

##### Parameters

Type

Name

Description

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

value1

The value to clamp.

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

min

The minimum value.

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

max

The maximum value.

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

result

\[OutAttribute\] The clamped value.

#### ClampToSphere(Vector2D, Double)

##### Declaration

```
public static Vector2D ClampToSphere(Vector2D vector, double radius)
```

##### Parameters

Type

Name

Description

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

vector

System.Double

radius

##### Returns

Type

Description

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

#### ClampToSphere(ref Vector2D, Double)

##### Declaration

```
public static void ClampToSphere(ref Vector2D vector, double radius)
```

##### Parameters

Type

Name

Description

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

vector

System.Double

radius

#### Distance(Vector2D, Vector2D)

Calculates the distance between two vectors.

##### Declaration

```
public static double Distance(Vector2D value1, Vector2D value2)
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

#### Distance(ref Vector2D, ref Vector2D, out Double)

Calculates the distance between two vectors.
