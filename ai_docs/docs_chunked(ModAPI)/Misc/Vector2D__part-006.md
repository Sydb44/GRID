##### Parameters

Type

Name

Description

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

value

Source Vector2D.

##### Returns

Type

Description

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

#### Normalize(ref Vector2D, out Vector2D)

Creates a unit vector from the specified vector, writing the result to a user-specified variable. The result is a vector one unit in length pointing in the same direction as the original vector.

##### Declaration

```
public static void Normalize(ref Vector2D value, out Vector2D result)
```

##### Parameters

Type

Name

Description

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

value

Source vector.

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

result

\[OutAttribute\] Normalized vector.

#### Reflect(Vector2D, Vector2D)

Determines the reflect vector of the given vector and normal.

##### Declaration

```
public static Vector2D Reflect(Vector2D vector, Vector2D normal)
```

##### Parameters

Type

Name

Description

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

vector

Source vector.

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

normal

Normal of vector.

##### Returns

Type

Description

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

#### Reflect(ref Vector2D, ref Vector2D, out Vector2D)

Determines the reflect vector of the given vector and normal.

##### Declaration

```
public static void Reflect(ref Vector2D vector, ref Vector2D normal, out Vector2D result)
```

##### Parameters

Type

Name

Description

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

vector

Source vector.

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

normal

Normal of vector.

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

result

\[OutAttribute\] The created reflect vector.

#### Rotate(Double)

##### Declaration

```
public void Rotate(double angle)
```

##### Parameters

Type

Name

Description

System.Double

angle

#### SmoothStep(Vector2D, Vector2D, Double)

Interpolates between two values using a cubic equation.

##### Declaration

```
public static Vector2D SmoothStep(Vector2D value1, Vector2D value2, double amount)
```

##### Parameters

Type

Name

Description

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

value1

Source value.

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

value2

Source value.

System.Double

amount

Weighting value.

##### Returns

Type

Description

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

#### SmoothStep(ref Vector2D, ref Vector2D, Double, out Vector2D)

Interpolates between two values using a cubic equation.

##### Declaration

```
public static void SmoothStep(ref Vector2D value1, ref Vector2D value2, double amount, out Vector2D result)
```

##### Parameters

Type

Name

Description

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

value1

Source value.

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

value2

Source value.

System.Double

amount

Weighting value.

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

result

\[OutAttribute\] The interpolated value.

#### Subtract(Vector2D, Vector2D)

Subtracts a vector from a vector.

##### Declaration

```
public static Vector2D Subtract(Vector2D value1, Vector2D value2)
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

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

#### Subtract(ref Vector2D, ref Vector2D, out Vector2D)

Subtracts a vector from a vector.

##### Declaration

```
public static void Subtract(ref Vector2D value1, ref Vector2D value2, out Vector2D result)
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

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

result

\[OutAttribute\] The result of the subtraction.

#### ToString()

Retrieves a string representation of the current object.

##### Declaration

```
public override string ToString()
```

##### Returns

Type

Description

System.String

#### Transform(Vector2D, Matrix)

Transforms the vector (x, y, 0, 1) by the specified matrix.

##### Declaration

```
public static Vector2D Transform(Vector2D position, Matrix matrix)
```

##### Parameters

Type

Name

Description

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

position

The source vector.

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

matrix

The transformation matrix.

##### Returns

Type

Description

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

#### Transform(Vector2D, Quaternion)

Transforms a single Vector2D, or the vector normal (x, y, 0, 0), by a specified Quaternion rotation.

##### Declaration

```
public static Vector2D Transform(Vector2D value, Quaternion rotation)
```
