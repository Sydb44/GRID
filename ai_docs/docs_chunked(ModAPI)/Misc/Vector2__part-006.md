Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

value

Source vector.

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

result

\[OutAttribute\] Vector pointing in the opposite direction.

#### Normalize()

Turns the current vector into a unit vector. The result is a vector one unit in length pointing in the same direction as the original vector.

##### Declaration

#### Normalize(Vector2)

Creates a unit vector from the specified vector. The result is a vector one unit in length pointing in the same direction as the original vector.

##### Declaration

```
public static Vector2 Normalize(Vector2 value)
```

##### Parameters

Type

Name

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

value

Source Vector2.

##### Returns

Type

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

#### Normalize(ref Vector2, out Vector2)

Creates a unit vector from the specified vector, writing the result to a user-specified variable. The result is a vector one unit in length pointing in the same direction as the original vector.

##### Declaration

```
public static void Normalize(ref Vector2 value, out Vector2 result)
```

##### Parameters

Type

Name

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

value

Source vector.

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

result

\[OutAttribute\] Normalized vector.

#### Reflect(Vector2, Vector2)

Determines the reflect vector of the given vector and normal.

##### Declaration

```
public static Vector2 Reflect(Vector2 vector, Vector2 normal)
```

##### Parameters

Type

Name

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

vector

Source vector.

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

normal

Normal of vector.

##### Returns

Type

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

#### Reflect(ref Vector2, ref Vector2, out Vector2)

Determines the reflect vector of the given vector and normal.

##### Declaration

```
public static void Reflect(ref Vector2 vector, ref Vector2 normal, out Vector2 result)
```

##### Parameters

Type

Name

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

vector

Source vector.

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

normal

Normal of vector.

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

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

#### SignNonZero(Vector2)

##### Declaration

```
public static Vector2 SignNonZero(Vector2 value)
```

##### Parameters

Type

Name

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

value

##### Returns

Type

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

#### SmoothStep(Vector2, Vector2, Single)

Interpolates between two values using a cubic equation.

##### Declaration

```
public static Vector2 SmoothStep(Vector2 value1, Vector2 value2, float amount)
```

##### Parameters

Type

Name

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

value1

Source value.

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

value2

Source value.

System.Single

amount

Weighting value.

##### Returns

Type

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

#### SmoothStep(ref Vector2, ref Vector2, Single, out Vector2)

Interpolates between two values using a cubic equation.

##### Declaration

```
public static void SmoothStep(ref Vector2 value1, ref Vector2 value2, float amount, out Vector2 result)
```

##### Parameters

Type

Name

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

value1

Source value.

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

value2

Source value.

System.Single

amount

Weighting value.

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

result

\[OutAttribute\] The interpolated value.

#### Subtract(Vector2, Vector2)

Subtracts a vector from a vector.

##### Declaration

```
public static Vector2 Subtract(Vector2 value1, Vector2 value2)
```

##### Parameters

Type

Name

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

value1

Source vector.

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

value2

Source vector.

##### Returns

Type

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

#### Subtract(ref Vector2, ref Vector2, out Vector2)

Subtracts a vector from a vector.

##### Declaration

```
public static void Subtract(ref Vector2 value1, ref Vector2 value2, out Vector2 result)
```

##### Parameters

Type

Name

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

value1

Source vector.

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

value2

Source vector.

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

result

\[OutAttribute\] The result of the subtraction.
