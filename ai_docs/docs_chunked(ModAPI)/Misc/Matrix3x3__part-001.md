---
title: "Class Matrix3x3"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix3x3.html"
category: "Misc"
namespace: "VRageMath"
class: "Matrix3x3"
---

# Class Matrix3x3 | Space Engineers ModAPI

Defines a matrix.

##### Inheritance

System.Object

Matrix3x3

###### **Namespace**: [VRageMath](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.html)

###### **Assembly**: VRage.Math.dll

##### Syntax

```
public sealed class Matrix3x3 : ValueType, IEquatable<Matrix3x3>
```

### [](#constructors)Constructors

#### [](#VRageMath_Matrix3x3__ctor_System_Single_System_Single_System_Single_System_Single_System_Single_System_Single_System_Single_System_Single_System_Single_)Matrix3x3(Single, Single, Single, Single, Single, Single, Single, Single, Single)

Initializes a new instance of Matrix3x3.

##### Declaration

```
public Matrix3x3(float m11, float m12, float m13, float m21, float m22, float m23, float m31, float m32, float m33)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | m11 | Value to initialize m11 to. |
| System.Single | m12 | Value to initialize m12 to. |
| System.Single | m13 | Value to initialize m13 to. |
| System.Single | m21 | Value to initialize m21 to. |
| System.Single | m22 | Value to initialize m22 to. |
| System.Single | m23 | Value to initialize m23 to. |
| System.Single | m31 | Value to initialize m31 to. |
| System.Single | m32 | Value to initialize m32 to. |
| System.Single | m33 | Value to initialize m33 to. |

#### [](#VRageMath_Matrix3x3__ctor_VRageMath_Matrix3x3_)Matrix3x3(Matrix3x3)

##### Declaration

```
public Matrix3x3(Matrix3x3 other)
```

##### Parameters

#### [](#VRageMath_Matrix3x3__ctor_VRageMath_MatrixD_)Matrix3x3(MatrixD)

##### Declaration

```
public Matrix3x3(MatrixD other)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) | other |     |

### [](#fields)Fields

#### [](#VRageMath_Matrix3x3_Identity)Identity

##### Declaration

```
public static Matrix3x3 Identity
```

##### Field Value

#### [](#VRageMath_Matrix3x3_M11)M11

Value at row 1 column 1 of the matrix.

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### [](#VRageMath_Matrix3x3_M12)M12

Value at row 1 column 2 of the matrix.

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### [](#VRageMath_Matrix3x3_M13)M13

Value at row 1 column 3 of the matrix.

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### [](#VRageMath_Matrix3x3_M21)M21

Value at row 2 column 1 of the matrix.

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### [](#VRageMath_Matrix3x3_M22)M22

Value at row 2 column 2 of the matrix.

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### [](#VRageMath_Matrix3x3_M23)M23

Value at row 2 column 3 of the matrix.

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### [](#VRageMath_Matrix3x3_M31)M31

Value at row 3 column 1 of the matrix.

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### [](#VRageMath_Matrix3x3_M32)M32

Value at row 3 column 2 of the matrix.

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### [](#VRageMath_Matrix3x3_M33)M33

Value at row 3 column 3 of the matrix.

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### [](#VRageMath_Matrix3x3_Zero)Zero

##### Declaration

```
public static Matrix3x3 Zero
```

##### Field Value

### [](#properties)Properties

#### [](#VRageMath_Matrix3x3_Backward)Backward

Gets and sets the backward vector of the Matrix3x3.

##### Declaration

```
public Vector3 Backward { get; set; }
```

##### Property Value

#### [](#VRageMath_Matrix3x3_Col0)Col0

##### Declaration

```
public Vector3 Col0 { get; }
```

##### Property Value

#### [](#VRageMath_Matrix3x3_Col1)Col1

##### Declaration

```
public Vector3 Col1 { get; }
```

##### Property Value

#### [](#VRageMath_Matrix3x3_Col2)Col2

##### Declaration

```
public Vector3 Col2 { get; }
```

##### Property Value

#### [](#VRageMath_Matrix3x3_Down)Down

Gets and sets the down vector of the Matrix3x3.

##### Declaration

```
public Vector3 Down { get; set; }
```

##### Property Value

#### [](#VRageMath_Matrix3x3_Forward)Forward

Gets and sets the forward vector of the Matrix3x3.

##### Declaration

```
public Vector3 Forward { get; set; }
```

##### Property Value

#### [](#VRageMath_Matrix3x3_Item_System_Int32_System_Int32_)Item\[Int32, Int32\]

##### Declaration

```
public float this[int row, int column] { get; set; }
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | row |     |
| System.Int32 | column |     |

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### [](#VRageMath_Matrix3x3_Left)Left

Gets and sets the left vector of the Matrix3x3.

##### Declaration

```
public Vector3 Left { get; set; }
```

##### Property Value

#### [](#VRageMath_Matrix3x3_Right)Right

Gets and sets the right vector of the Matrix3x3.

##### Declaration

```
public Vector3 Right { get; set; }
```

##### Property Value

#### [](#VRageMath_Matrix3x3_Scale)Scale

##### Declaration

```
public Vector3 Scale { get; }
```

##### Property Value

#### [](#VRageMath_Matrix3x3_Up)Up

Gets and sets the up vector of the Matrix3x3.

##### Declaration

```
public Vector3 Up { get; set; }
```

##### Property Value

### [](#methods)Methods

#### [](#VRageMath_Matrix3x3_Add_VRageMath_Matrix3x3__VRageMath_Matrix3x3__VRageMath_Matrix3x3__)Add(ref Matrix3x3, ref Matrix3x3, out Matrix3x3)

Adds a matrix to another matrix.
