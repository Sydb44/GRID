---
title: "Class Matrix"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html"
category: "Misc"
namespace: "VRageMath"
class: "Matrix"
---

# Class Matrix | Space Engineers ModAPI

Defines a matrix.

##### Inheritance

System.Object

Matrix

###### **Namespace**: [VRageMath](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.html)

###### **Assembly**: VRage.Math.dll

##### Syntax

```
public sealed class Matrix : ValueType, IEquatable<Matrix>
```

### Constructors

#### Matrix(Single, Single, Single, Single, Single, Single, Single, Single, Single)

Initializes a new instance of Matrix with rotation data

##### Declaration

```
public Matrix(float m11, float m12, float m13, float m21, float m22, float m23, float m31, float m32, float m33)
```

##### Parameters

Type

Name

Description

System.Single

m11

Value to initialize m11 to.

System.Single

m12

Value to initialize m12 to.

System.Single

m13

Value to initialize m13 to.

System.Single

m21

Value to initialize m21 to.

System.Single

m22

Value to initialize m22 to.

System.Single

m23

Value to initialize m23 to.

System.Single

m31

Value to initialize m31 to.

System.Single

m32

Value to initialize m32 to.

System.Single

m33

Value to initialize m33 to.

#### Matrix(Single, Single, Single, Single, Single, Single, Single, Single, Single, Single, Single, Single, Single, Single, Single, Single)

Initializes a new instance of Matrix.

##### Declaration

```
public Matrix(float m11, float m12, float m13, float m14, float m21, float m22, float m23, float m24, float m31, float m32, float m33, float m34, float m41, float m42, float m43, float m44)
```

##### Parameters

Type

Name

Description

System.Single

m11

Value to initialize m11 to.

System.Single

m12

Value to initialize m12 to.

System.Single

m13

Value to initialize m13 to.

System.Single

m14

Value to initialize m14 to.

System.Single

m21

Value to initialize m21 to.

System.Single

m22

Value to initialize m22 to.

System.Single

m23

Value to initialize m23 to.

System.Single

m24

Value to initialize m24 to.

System.Single

m31

Value to initialize m31 to.

System.Single

m32

Value to initialize m32 to.

System.Single

m33

Value to initialize m33 to.

System.Single

m34

Value to initialize m34 to.

System.Single

m41

Value to initialize m41 to.

System.Single

m42

Value to initialize m42 to.

System.Single

m43

Value to initialize m43 to.

System.Single

m44

Value to initialize m44 to.

#### Matrix(MatrixD)

##### Declaration

```
public Matrix(MatrixD other)
```

##### Parameters

Type

Name

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

other

### Fields

#### Identity

##### Declaration

```
public static Matrix Identity
```

##### Field Value

Type

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

#### M11

Value at row 1 column 1 of the matrix.

##### Declaration

##### Field Value

Type

Description

System.Single

#### M12

Value at row 1 column 2 of the matrix.

##### Declaration

##### Field Value

Type

Description

System.Single

#### M13

Value at row 1 column 3 of the matrix.

##### Declaration

##### Field Value

Type

Description

System.Single

#### M14

Value at row 1 column 4 of the matrix.

##### Declaration

##### Field Value

Type

Description

System.Single

#### M21

Value at row 2 column 1 of the matrix.

##### Declaration

##### Field Value

Type

Description

System.Single

#### M22

Value at row 2 column 2 of the matrix.

##### Declaration

##### Field Value

Type

Description

System.Single

#### M23

Value at row 2 column 3 of the matrix.

##### Declaration

##### Field Value

Type

Description

System.Single

#### M24

Value at row 2 column 4 of the matrix.

##### Declaration

##### Field Value

Type

Description

System.Single

#### M31

Value at row 3 column 1 of the matrix.

##### Declaration

##### Field Value

Type

Description

System.Single

#### M32

Value at row 3 column 2 of the matrix.

##### Declaration

##### Field Value

Type

Description

System.Single

#### M33

Value at row 3 column 3 of the matrix.

##### Declaration

##### Field Value

Type

Description

System.Single

#### M34

Value at row 3 column 4 of the matrix.

##### Declaration

##### Field Value

Type

Description

System.Single

#### M41

Value at row 4 column 1 of the matrix.

##### Declaration

##### Field Value

Type

Description

System.Single

#### M42

Value at row 4 column 2 of the matrix.

##### Declaration

##### Field Value

Type

Description

System.Single

#### M43

Value at row 4 column 3 of the matrix.

##### Declaration

##### Field Value

Type

Description

System.Single

#### M44

Value at row 4 column 4 of the matrix.

##### Declaration

##### Field Value

Type

Description

System.Single

#### Zero

##### Declaration

```
public static Matrix Zero
```

##### Field Value

Type

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

### Properties

#### Backward

Gets and sets the backward vector of the Matrix.

##### Declaration

```
public Vector3 Backward { get; set; }
```

##### Property Value

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### Col0

##### Declaration

```
public Vector3 Col0 { get; }
```

##### Property Value

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### Col1

##### Declaration

```
public Vector3 Col1 { get; }
```

##### Property Value

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### Col2

##### Declaration

```
public Vector3 Col2 { get; }
```

##### Property Value

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)
