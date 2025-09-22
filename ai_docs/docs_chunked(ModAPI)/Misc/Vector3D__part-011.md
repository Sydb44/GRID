Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

vect3d

##### Returns

Type

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

#### Round(Vector3D, Int32)

##### Declaration

```
public static Vector3D Round(Vector3D v, int numDecimals)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

v

System.Int32

numDecimals

##### Returns

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### SetDim(Int32, Double)

##### Declaration

```
public void SetDim(int i, double value)
```

##### Parameters

Type

Name

Description

System.Int32

i

System.Double

value

#### Sign(Vector3D)

##### Declaration

```
public static Vector3D Sign(Vector3D value)
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

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### SignNonZero(Vector3D)

Returns per component sign, never returns zero. For zero component returns sign 1. Faster than Sign.

##### Declaration

```
public static Vector3D SignNonZero(Vector3D value)
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

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### SmoothStep(Vector3D, Vector3D, Double)

Interpolates between two values using a cubic equation.

##### Declaration

```
public static Vector3D SmoothStep(Vector3D value1, Vector3D value2, double amount)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

value1

Source value.

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

value2

Source value.

System.Double

amount

Weighting value.

##### Returns

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### SmoothStep(ref Vector3D, ref Vector3D, Double, out Vector3D)

Interpolates between two values using a cubic equation.

##### Declaration

```
public static void SmoothStep(ref Vector3D value1, ref Vector3D value2, double amount, out Vector3D result)
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

Weighting value.

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

result

\[OutAttribute\] The interpolated value.

#### Step(Vector3D)

##### Declaration

```
public static Vector3D Step(Vector3D value)
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

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### Subtract(Vector3D, Vector3D)

Subtracts a vector from a vector.

##### Declaration

```
public static Vector3D Subtract(Vector3D value1, Vector3D value2)
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

#### Subtract(ref Vector3D, ref Vector3D, out Vector3D)

Subtracts a vector from a vector.

##### Declaration

```
public static void Subtract(ref Vector3D value1, ref Vector3D value2, out Vector3D result)
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

\[OutAttribute\] The result of the subtraction.

#### SwapYZCoordinates(Vector3D)

##### Declaration

```
public static Vector3D SwapYZCoordinates(Vector3D v)
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

#### ToString(String)

##### Declaration

```
public string ToString(string format)
```

##### Parameters

Type

Name

Description

System.String

format

##### Returns

Type

Description

System.String

#### Transform(Vector3, MatrixD)

##### Declaration

```
public static Vector3D Transform(Vector3 position, MatrixD matrix)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

position

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

matrix

##### Returns

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)
