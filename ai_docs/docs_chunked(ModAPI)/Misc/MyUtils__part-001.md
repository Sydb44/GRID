---
title: "Class MyUtils"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyUtils.html"
category: "Misc"
namespace: "VRage.Utils"
class: "MyUtils"
---

# Class MyUtils | Space Engineers ModAPI

MyFileSystemUtils

##### Inheritance

System.Object

MyUtils

###### **Namespace**: [VRage.Utils](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.html)

###### **Assembly**: VRage.dll

##### Syntax

```
public static class MyUtils : Object
```

### Fields

#### C\_CRLF

##### Declaration

```
public const string C_CRLF = "\r\n"
```

##### Field Value

Type

Description

System.String

#### DefaultNumberSuffix

Default number suffix, k = thousand, m = million, g/b = billion

##### Declaration

```
public static Tuple<string, float>[] DefaultNumberSuffix
```

##### Field Value

Type

Description

System.Tuple<System.String, System.Single\>\[\]

#### EmptyStringBuilder

##### Declaration

```
public static readonly StringBuilder EmptyStringBuilder
```

##### Field Value

Type

Description

System.Text.StringBuilder

#### ZeroMatrix

##### Declaration

```
public static readonly Matrix ZeroMatrix
```

##### Field Value

Type

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

### Properties

#### MainThread

##### Declaration

```
public static Thread MainThread { get; set; }
```

##### Property Value

Type

Description

System.Threading.Thread

### Methods

#### AlignCoord(Vector2, Vector2, MyGuiDrawAlignEnum)

##### Declaration

```
public static Vector2 AlignCoord(Vector2 coordScreen, Vector2 size, MyGuiDrawAlignEnum drawAlignEnum)
```

##### Parameters

Type

Name

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

coordScreen

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

size

[MyGuiDrawAlignEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyGuiDrawAlignEnum.html)

drawAlignEnum

##### Returns

Type

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

#### AlignIntToRight(Int32, Int32, Char)

##### Declaration

```
public static string AlignIntToRight(int value, int charsCount, char ch)
```

##### Parameters

Type

Name

Description

System.Int32

value

System.Int32

charsCount

System.Char

ch

##### Returns

Type

Description

System.String

#### AssertIsValid(Double)

##### Declaration

```
public static void AssertIsValid(double f)
```

##### Parameters

Type

Name

Description

System.Double

f

#### AssertIsValid(Nullable<Vector3>)

##### Declaration

```
public static void AssertIsValid(Nullable<Vector3> vec)
```

##### Parameters

Type

Name

Description

System.Nullable<[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)\>

vec

#### AssertIsValid(Single)

##### Declaration

```
public static void AssertIsValid(float f)
```

##### Parameters

Type

Name

Description

System.Single

f

#### AssertIsValid(Matrix)

##### Declaration

```
public static void AssertIsValid(Matrix matrix)
```

##### Parameters

Type

Name

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

matrix

#### AssertIsValid(MatrixD)

##### Declaration

```
public static void AssertIsValid(MatrixD matrix)
```

##### Parameters

Type

Name

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

matrix

#### AssertIsValid(Quaternion)

##### Declaration

```
public static void AssertIsValid(Quaternion q)
```

##### Parameters

Type

Name

Description

[Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html)

q

#### AssertIsValid(Vector2)

##### Declaration

```
public static void AssertIsValid(Vector2 vec)
```

##### Parameters

Type

Name

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

vec

#### AssertIsValid(Vector3)

##### Declaration

```
public static void AssertIsValid(Vector3 vec)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

vec

#### AssertIsValid(Vector3D)

##### Declaration

```
public static void AssertIsValid(Vector3D vec)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

vec

#### AssertIsValidOrZero(Matrix)

##### Declaration

```
public static void AssertIsValidOrZero(Matrix matrix)
```

##### Parameters

Type

Name

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

matrix

#### AssertLengthValid(ref Vector3)

##### Declaration

```
public static void AssertLengthValid(ref Vector3 vec)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

vec

#### AssertLengthValid(ref Vector3D)

##### Declaration

```
public static void AssertLengthValid(ref Vector3D vec)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

vec

#### CheckFloatValues(Object, String, ref Nullable<Double>, ref Nullable<Double>)

##### Declaration

```
public static void CheckFloatValues(object graph, string name, ref Nullable<double> min, ref Nullable<double> max)
```

##### Parameters

Type

Name

Description

System.Object

graph

System.String

name

System.Nullable<System.Double\>

min

System.Nullable<System.Double\>

max

#### CheckMainThread(String)

##### Declaration

```
public static void CheckMainThread(string message = "")
```

##### Parameters

Type

Name

Description

System.String

message

#### DeserializeValue(XmlReader, out Vector3)

##### Declaration

```
public static void DeserializeValue(XmlReader reader, out Vector3 value)
```
