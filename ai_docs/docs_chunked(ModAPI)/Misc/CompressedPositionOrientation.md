---
title: "Class CompressedPositionOrientation"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.CompressedPositionOrientation.html"
category: "Misc"
namespace: "VRageMath"
class: "CompressedPositionOrientation"
---

# Class CompressedPositionOrientation | Space Engineers ModAPI

Defines a matrix.

##### Inheritance

System.Object

CompressedPositionOrientation

###### **Namespace**: [VRageMath](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.html)

###### **Assembly**: VRage.Math.dll

##### Syntax

```
public sealed class CompressedPositionOrientation : ValueType
```

### Constructors

#### CompressedPositionOrientation(ref Matrix)

##### Declaration

```
public CompressedPositionOrientation(ref Matrix matrix)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html) | matrix |     |

### Fields

#### Orientation

##### Declaration

```
public HalfVector4 Orientation
```

##### Field Value

| Type | Description |
| --- | --- |
| VRageMath.PackedVector.HalfVector4 |     |

#### Position

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

### Properties

#### Matrix

##### Declaration

```
public Matrix Matrix { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html) |     |

### Methods

#### FromMatrix(ref Matrix)

##### Declaration

```
public void FromMatrix(ref Matrix matrix)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html) | matrix |     |

#### ToMatrix(out Matrix)

##### Declaration

```
public void ToMatrix(out Matrix result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html) | result |     |