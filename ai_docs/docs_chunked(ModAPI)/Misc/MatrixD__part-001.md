---
title: "Class MatrixD"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html"
category: "Misc"
namespace: "VRageMath"
class: "MatrixD"
---

# Class MatrixD | Space Engineers ModAPI

Defines a matrix.

##### Inheritance

System.Object

MatrixD

###### **Namespace**: [VRageMath](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.html)

###### **Assembly**: VRage.Math.dll

##### Syntax

```
public sealed class MatrixD : ValueType, IEquatable<MatrixD>
```

### Constructors

#### MatrixD(Double, Double, Double, Double, Double, Double, Double, Double, Double)

Initializes a new instance of Matrix with rotation data

##### Declaration

```
public MatrixD(double m11, double m12, double m13, double m21, double m22, double m23, double m31, double m32, double m33)
```

##### Parameters

Type

Name

Description

System.Double

m11

Value to initialize m11 to.

System.Double

m12

Value to initialize m12 to.

System.Double

m13

Value to initialize m13 to.

System.Double

m21

Value to initialize m21 to.

System.Double

m22

Value to initialize m22 to.

System.Double

m23

Value to initialize m23 to.

System.Double

m31

Value to initialize m31 to.

System.Double

m32

Value to initialize m32 to.

System.Double

m33

Value to initialize m33 to.

#### MatrixD(Double, Double, Double, Double, Double, Double, Double, Double, Double, Double, Double, Double, Double, Double, Double, Double)

Initializes a new instance of Matrix.

##### Declaration

```
public MatrixD(double m11, double m12, double m13, double m14, double m21, double m22, double m23, double m24, double m31, double m32, double m33, double m34, double m41, double m42, double m43, double m44)
```

##### Parameters

Type

Name

Description

System.Double

m11

Value to initialize m11 to.

System.Double

m12

Value to initialize m12 to.

System.Double

m13

Value to initialize m13 to.

System.Double

m14

Value to initialize m14 to.

System.Double

m21

Value to initialize m21 to.

System.Double

m22

Value to initialize m22 to.

System.Double

m23

Value to initialize m23 to.

System.Double

m24

Value to initialize m24 to.

System.Double

m31

Value to initialize m31 to.

System.Double

m32

Value to initialize m32 to.

System.Double

m33

Value to initialize m33 to.

System.Double

m34

Value to initialize m34 to.

System.Double

m41

Value to initialize m41 to.

System.Double

m42

Value to initialize m42 to.

System.Double

m43

Value to initialize m43 to.

System.Double

m44

Value to initialize m44 to.

#### MatrixD(Matrix)

##### Declaration

##### Parameters

Type

Name

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

m

### Fields

#### Identity

##### Declaration

```
public static MatrixD Identity
```

##### Field Value

Type

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

#### M11

Value at row 1 column 1 of the matrix.

##### Declaration

##### Field Value

Type

Description

System.Double

#### M12

Value at row 1 column 2 of the matrix.

##### Declaration

##### Field Value

Type

Description

System.Double

#### M13

Value at row 1 column 3 of the matrix.

##### Declaration

##### Field Value

Type

Description

System.Double

#### M14

Value at row 1 column 4 of the matrix.

##### Declaration

##### Field Value

Type

Description

System.Double

#### M21

Value at row 2 column 1 of the matrix.

##### Declaration

##### Field Value

Type

Description

System.Double

#### M22

Value at row 2 column 2 of the matrix.

##### Declaration

##### Field Value

Type

Description

System.Double

#### M23

Value at row 2 column 3 of the matrix.

##### Declaration

##### Field Value

Type

Description

System.Double

#### M24

Value at row 2 column 4 of the matrix.

##### Declaration

##### Field Value

Type

Description

System.Double

#### M31

Value at row 3 column 1 of the matrix.

##### Declaration

##### Field Value

Type

Description

System.Double

#### M32

Value at row 3 column 2 of the matrix.

##### Declaration

##### Field Value

Type

Description

System.Double

#### M33

Value at row 3 column 3 of the matrix.

##### Declaration

##### Field Value

Type

Description

System.Double

#### M34

Value at row 3 column 4 of the matrix.

##### Declaration

##### Field Value

Type

Description

System.Double

#### M41

Value at row 4 column 1 of the matrix.

##### Declaration

##### Field Value

Type

Description

System.Double

#### M42

Value at row 4 column 2 of the matrix.

##### Declaration

##### Field Value

Type

Description

System.Double

#### M43

Value at row 4 column 3 of the matrix.

##### Declaration

##### Field Value

Type

Description

System.Double

#### M44

Value at row 4 column 4 of the matrix.

##### Declaration

##### Field Value

Type

Description

System.Double

#### Zero

##### Declaration

```
public static MatrixD Zero
```

##### Field Value

Type

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

### Properties

#### Backward

Gets and sets the backward vector of the Matrix.

##### Declaration

```
public Vector3D Backward { get; set; }
```

##### Property Value

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### Col0

##### Declaration

```
public Vector3D Col0 { get; }
```

##### Property Value

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### Col1

##### Declaration

```
public Vector3D Col1 { get; }
```

##### Property Value

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### Col2

##### Declaration

```
public Vector3D Col2 { get; }
```

##### Property Value

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)
