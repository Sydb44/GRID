Name

Description

TElement

#### RotationMatrixToYawPitchRoll(ref Matrix, out Single, out Single, out Single)

##### Declaration

```
public static void RotationMatrixToYawPitchRoll(ref Matrix mx, out float yaw, out float pitch, out float roll)
```

##### Parameters

Type

Name

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

mx

System.Single

yaw

System.Single

pitch

System.Single

roll

#### RotationMatrixToYawPitchRoll(ref MatrixD, out Double, out Double, out Double)

##### Declaration

```
public static void RotationMatrixToYawPitchRoll(ref MatrixD mx, out double yaw, out double pitch, out double roll)
```

##### Parameters

Type

Name

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

mx

System.Double

yaw

System.Double

pitch

System.Double

roll

#### SerializeValue(XmlWriter, Vector3)

##### Declaration

```
public static void SerializeValue(XmlWriter writer, Vector3 v)
```

##### Parameters

Type

Name

Description

System.Xml.XmlWriter

writer

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

v

#### SerializeValue(XmlWriter, Vector4)

##### Declaration

```
public static void SerializeValue(XmlWriter writer, Vector4 v)
```

##### Parameters

Type

Name

Description

System.Xml.XmlWriter

writer

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)

v

#### ShuffleList<T>(IList<T>, Int32, Nullable<Int32>)

##### Declaration

```
public static void ShuffleList<T>(this IList<T> list, int offset = 0, Nullable<int> count = null)
```

##### Parameters

Type

Name

Description

System.Collections.Generic.IList<T>

list

System.Int32

offset

System.Nullable<System.Int32\>

count

##### Type Parameters

Name

Description

T

#### StripInvalidChars(String)

##### Declaration

```
public static string StripInvalidChars(string filename)
```

##### Parameters

Type

Name

Description

System.String

filename

##### Returns

Type

Description

System.String

#### Swap<T>(ref T, ref T)

##### Declaration

```
public static void Swap<T>(ref T lhs, ref T rhs)
```

##### Parameters

Type

Name

Description

T

lhs

T

rhs

##### Type Parameters

Name

Description

T

#### TryParseWithSuffix(String, NumberStyles, IFormatProvider, out Single, Tuple<String, Single>\[\])

##### Declaration

```
public static bool TryParseWithSuffix(this string text, NumberStyles numberStyle, IFormatProvider formatProvider, out float value, Tuple<string, float>[] suffix = null)
```

##### Parameters

Type

Name

Description

System.String

text

System.Globalization.NumberStyles

numberStyle

System.IFormatProvider

formatProvider

System.Single

value

System.Tuple<System.String, System.Single\>\[\]

suffix

##### Returns

Type

Description

System.Boolean

#### VectorPlaneRotation(Vector3D, Vector3D, out Vector3D, out Vector3D, Single)

##### Declaration

```
public static void VectorPlaneRotation(Vector3D xVector, Vector3D yVector, out Vector3D xOut, out Vector3D yOut, float angle)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

xVector

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

yVector

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

xOut

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

yOut

System.Single

angle