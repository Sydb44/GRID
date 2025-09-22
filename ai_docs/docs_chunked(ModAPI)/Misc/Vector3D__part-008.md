Value between 0 and 1 indicating the weight of value2.

##### Returns

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### Lerp(ref Vector3D, ref Vector3D, Double, out Vector3D)

Performs a linear interpolation between two vectors.

##### Declaration

```
public static void Lerp(ref Vector3D value1, ref Vector3D value2, double amount, out Vector3D result)
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

System.Double

amount

Value between 0 and 1 indicating the weight of value2.

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

result

\[OutAttribute\] The result of the interpolation.

#### Max()

Returns the component of the vector that is largest of all the three components.

##### Declaration

##### Returns

Type

Description

System.Double

#### Max(Vector3D, Vector3D)

Returns a vector that contains the highest value from each matching pair of components.

##### Declaration

```
public static Vector3D Max(Vector3D value1, Vector3D value2)
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

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### Max(ref Vector3D, ref Vector3D, out Vector3D)

Returns a vector that contains the highest value from each matching pair of components.

##### Declaration

```
public static void Max(ref Vector3D value1, ref Vector3D value2, out Vector3D result)
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

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

result

\[OutAttribute\] The maximized vector.

#### Min()

Returns the component of the vector that is smallest of all the three components.

##### Declaration

##### Returns

Type

Description

System.Double

#### Min(Vector3D, Vector3D)

Returns a vector that contains the lowest value from each matching pair of components.

##### Declaration

```
public static Vector3D Min(Vector3D value1, Vector3D value2)
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

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### Min(ref Vector3D, ref Vector3D, out Vector3D)

Returns a vector that contains the lowest value from each matching pair of components.

##### Declaration

```
public static void Min(ref Vector3D value1, ref Vector3D value2, out Vector3D result)
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

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

result

\[OutAttribute\] The minimized vector.

#### MinMax(ref Vector3D, ref Vector3D)

Separates minimal and maximal values of any two input vectors

##### Declaration

```
public static void MinMax(ref Vector3D min, ref Vector3D max)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

min

minimal values of the two vectors

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

max

maximal values of the two vectors

#### Multiply(Vector3D, Double)

Multiplies a vector by a scalar value.

##### Declaration

```
public static Vector3D Multiply(Vector3D value1, double scaleFactor)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

value1

Source vector.

System.Double

scaleFactor

Scalar value.

##### Returns

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### Multiply(Vector3D, Vector3D)

Multiplies the components of two vectors by each other.

##### Declaration

```
public static Vector3D Multiply(Vector3D value1, Vector3D value2)
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

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### Multiply(ref Vector3D, Double, out Vector3D)

Multiplies a vector by a scalar value.

##### Declaration

```
public static void Multiply(ref Vector3D value1, double scaleFactor, out Vector3D result)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

value1

Source vector.

System.Double

scaleFactor

Scalar value.

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

result

\[OutAttribute\] The result of the multiplication.
