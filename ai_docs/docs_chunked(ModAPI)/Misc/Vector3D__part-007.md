##### Declaration

```
public override int GetHashCode()
```

##### Returns

Type

Description

System.Int32

#### Hermite(Vector3D, Vector3D, Vector3D, Vector3D, Double)

Performs a Hermite spline interpolation.

##### Declaration

```
public static Vector3D Hermite(Vector3D value1, Vector3D tangent1, Vector3D value2, Vector3D tangent2, double amount)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

value1

Source position vector.

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

tangent1

Source tangent vector.

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

value2

Source position vector.

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

tangent2

Source tangent vector.

System.Double

amount

Weighting factor.

##### Returns

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### Hermite(ref Vector3D, ref Vector3D, ref Vector3D, ref Vector3D, Double, out Vector3D)

Performs a Hermite spline interpolation.

##### Declaration

```
public static void Hermite(ref Vector3D value1, ref Vector3D tangent1, ref Vector3D value2, ref Vector3D tangent2, double amount, out Vector3D result)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

value1

Source position vector.

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

tangent1

Source tangent vector.

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

value2

Source position vector.

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

tangent2

Source tangent vector.

System.Double

amount

Weighting factor.

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

result

\[OutAttribute\] The result of the Hermite spline interpolation.

#### Interpolate3(Vector3D, Vector3D, Double)

##### Declaration

```
public void Interpolate3(Vector3D v0, Vector3D v1, double rt)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

v0

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

v1

System.Double

rt

#### IsInsideInclusive(ref Vector3D, ref Vector3D)

##### Declaration

```
public bool IsInsideInclusive(ref Vector3D min, ref Vector3D max)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

min

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

max

##### Returns

Type

Description

System.Boolean

#### IsUnit(ref Vector3D)

##### Declaration

```
public static bool IsUnit(ref Vector3D value)
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

System.Boolean

#### IsValid()

##### Declaration

##### Returns

Type

Description

System.Boolean

#### IsZero()

##### Declaration

##### Returns

Type

Description

System.Boolean

#### IsZero(Vector3D)

##### Declaration

```
public static bool IsZero(Vector3D value)
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

System.Boolean

#### IsZero(Vector3D, Double)

##### Declaration

```
public static bool IsZero(Vector3D value, double epsilon)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

value

System.Double

epsilon

##### Returns

Type

Description

System.Boolean

#### IsZeroVector(Vector3D)

##### Declaration

```
public static Vector3D IsZeroVector(Vector3D value)
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

#### IsZeroVector(Vector3D, Double)

##### Declaration

```
public static Vector3D IsZeroVector(Vector3D value, double epsilon)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

value

System.Double

epsilon

##### Returns

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### Length()

Calculates the length of the vector.

##### Declaration

##### Returns

Type

Description

System.Double

#### LengthSquared()

Calculates the length of the vector squared.

##### Declaration

```
public double LengthSquared()
```

##### Returns

Type

Description

System.Double

#### Lerp(Vector3D, Vector3D, Double)

Performs a linear interpolation between two vectors.

##### Declaration

```
public static Vector3D Lerp(Vector3D value1, Vector3D value2, double amount)
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

##### Returns

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### Lerp(ref Vector3D, ref Vector3D, Double, out Vector3D)

Performs a linear interpolation between two vectors.
