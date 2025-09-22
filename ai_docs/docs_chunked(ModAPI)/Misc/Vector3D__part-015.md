The destination Vector3 array.

System.Int32

destinationIndex

The starting index in the destination array.

System.Int32

length

The number of vectors to transform.

#### TransformNormal(Vector3D\[\], ref Matrix, Vector3D\*)

Transforms an array of 3D vector normals by a specified Matrix.

##### Declaration

```
public static void TransformNormal(Vector3D[] sourceArray, ref Matrix matrix, Vector3D*destinationArray)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\[\]

sourceArray

The array of Vector3 normals to transform.

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

matrix

The transform matrix to apply.

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\*

destinationArray

An existing Vector3 array into which the results of the transforms are written.

#### TransformNormal(Vector3D\[\], ref Matrix, Vector3D\[\])

Transforms an array of 3D vector normals by a specified Matrix.

##### Declaration

```
public static void TransformNormal(Vector3D[] sourceArray, ref Matrix matrix, Vector3D[] destinationArray)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\[\]

sourceArray

The array of Vector3 normals to transform.

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

matrix

The transform matrix to apply.

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\[\]

destinationArray

An existing Vector3 array into which the results of the transforms are written.

#### TryParse(String, out Vector3D)

##### Declaration

```
public static bool TryParse(string str, out Vector3D retval)
```

##### Parameters

Type

Name

Description

System.String

str

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

retval

##### Returns

Type

Description

System.Boolean

#### VolumeInt(Double)

##### Declaration

```
public long VolumeInt(double multiplier)
```

##### Parameters

Type

Name

Description

System.Double

multiplier

##### Returns

Type

Description

System.Int64

### Operators

#### Addition(Vector3, Vector3D)

##### Declaration

```
public static Vector3D operator +(Vector3 value1, Vector3D value2)
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

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### Addition(Vector3D, Double)

##### Declaration

```
public static Vector3D operator +(Vector3D value1, double value2)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

value1

System.Double

value2

##### Returns

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### Addition(Vector3D, Single)

##### Declaration

```
public static Vector3D operator +(Vector3D value1, float value2)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

value1

System.Single

value2

##### Returns

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### Addition(Vector3D, Vector3)

##### Declaration

```
public static Vector3D operator +(Vector3D value1, Vector3 value2)
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

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### Addition(Vector3D, Vector3D)

Adds two vectors.

##### Declaration

```
public static Vector3D operator +(Vector3D value1, Vector3D value2)
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

#### Addition(Vector3D, Vector3I)

##### Declaration

```
public static Vector3D operator +(Vector3D value1, Vector3I value2)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

value1

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

value2

##### Returns

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### Division(Double, Vector3D)

##### Declaration

```
public static Vector3D operator /(double value, Vector3D divider)
```

##### Parameters

Type

Name

Description

System.Double

value

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

divider

##### Returns

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### Division(Vector3D, Double)

Divides a vector by a scalar value.

##### Declaration

```
public static Vector3D operator /(Vector3D value, double divider)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

value

Source vector.

System.Double

divider

The divisor.
