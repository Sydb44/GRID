Source vector.

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

value2

Source vector.

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

result

\[OutAttribute\] The maximized vector.

#### MaxAbsComponent()

Keeps only component with maximal absolute, others are set to zero.

##### Declaration

```
public Vector3 MaxAbsComponent()
```

##### Returns

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### Min()

Returns the component of the vector that is smallest of all the three components.

##### Declaration

##### Returns

Type

Description

System.Single

#### Min(Vector3, Vector3)

Returns a vector that contains the lowest value from each matching pair of components.

##### Declaration

```
public static Vector3 Min(Vector3 value1, Vector3 value2)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

value1

Source vector.

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

value2

Source vector.

##### Returns

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### Min(ref Vector3, ref Vector3, out Vector3)

Returns a vector that contains the lowest value from each matching pair of components.

##### Declaration

```
public static void Min(ref Vector3 value1, ref Vector3 value2, out Vector3 result)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

value1

Source vector.

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

value2

Source vector.

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

result

\[OutAttribute\] The minimized vector.

#### MinMax(ref Vector3, ref Vector3)

Separates minimal and maximal values of any two input vectors

##### Declaration

```
public static void MinMax(ref Vector3 min, ref Vector3 max)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

min

minimal values of the two vectors

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

max

maximal values of the two vectors

#### Multiply(Single)

##### Declaration

```
public void Multiply(float scale)
```

##### Parameters

Type

Name

Description

System.Single

scale

#### Multiply(Vector3, Single)

Multiplies a vector by a scalar value.

##### Declaration

```
public static Vector3 Multiply(Vector3 value1, float scaleFactor)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

value1

Source vector.

System.Single

scaleFactor

Scalar value.

##### Returns

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### Multiply(Vector3, Vector3)

Multiplies the components of two vectors by each other.

##### Declaration

```
public static Vector3 Multiply(Vector3 value1, Vector3 value2)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

value1

Source vector.

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

value2

Source vector.

##### Returns

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### Multiply(ref Vector3, Single, out Vector3)

Multiplies a vector by a scalar value.

##### Declaration

```
public static void Multiply(ref Vector3 value1, float scaleFactor, out Vector3 result)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

value1

Source vector.

System.Single

scaleFactor

Scalar value.

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

result

\[OutAttribute\] The result of the multiplication.

#### Multiply(ref Vector3, ref Vector3, out Vector3)

Multiplies the components of two vectors by each other.

##### Declaration

```
public static void Multiply(ref Vector3 value1, ref Vector3 value2, out Vector3 result)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

value1

Source vector.

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

value2

Source vector.

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

result

\[OutAttribute\] The result of the multiplication.

#### Negate(Vector3)

Returns a vector pointing in the opposite direction.

##### Declaration

```
public static Vector3 Negate(Vector3 value)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

value

Source vector.

##### Returns

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### Negate(ref Vector3, out Vector3)

Returns a vector pointing in the opposite direction.

##### Declaration

```
public static void Negate(ref Vector3 value, out Vector3 result)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

value

Source vector.

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

result

\[OutAttribute\] Vector pointing in the opposite direction.

#### Normalize()

Turns the current vector into a unit vector. The result is a vector one unit in length pointing in the same direction as the original vector.
