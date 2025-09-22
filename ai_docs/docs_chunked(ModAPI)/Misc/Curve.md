---
title: "Class Curve"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Curve.html"
category: "Misc"
namespace: "VRageMath"
class: "Curve"
---

# Class Curve | Space Engineers ModAPI

Stores an arbitrary collection of 2D CurveKey points, and provides methods for evaluating features of the curve they define.

##### Inheritance

System.Object

Curve

###### **Namespace**: [VRageMath](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.html)

###### **Assembly**: VRage.Math.dll

##### Syntax

```
public class Curve : Object
```

### Constructors

#### Curve()

##### Declaration

### Properties

#### IsConstant

Gets a value indicating whether the curve is constant.

##### Declaration

```
public bool IsConstant { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Keys

The points that make up the curve.

##### Declaration

```
public CurveKeyCollection Keys { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [CurveKeyCollection](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.CurveKeyCollection.html) |     |

#### PostLoop

Specifies how to handle weighting values that are greater than the last control point in the curve.

##### Declaration

```
public CurveLoopType PostLoop { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [CurveLoopType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.CurveLoopType.html) |     |

#### PreLoop

Specifies how to handle weighting values that are less than the first control point in the curve.

##### Declaration

```
public CurveLoopType PreLoop { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [CurveLoopType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.CurveLoopType.html) |     |

### Methods

#### Clone()

Creates a copy of the Curve.

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| [Curve](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Curve.html) |     |

#### ComputeTangent(Int32, CurveTangent)

Computes both the TangentIn and the TangentOut for a CurveKey specified by its index.

##### Declaration

```
public void ComputeTangent(int keyIndex, CurveTangent tangentType)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | keyIndex | The index of the CurveKey for which to compute tangents (in the Keys collection of the Curve). |
| [CurveTangent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.CurveTangent.html) | tangentType | The type of tangents to compute (one of the types specified in the CurveTangent enumeration). |

#### ComputeTangent(Int32, CurveTangent, CurveTangent)

Computes a specified type of TangentIn and a specified type of TangentOut for a given CurveKey.

##### Declaration

```
public void ComputeTangent(int keyIndex, CurveTangent tangentInType, CurveTangent tangentOutType)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | keyIndex | The index of the CurveKey for which to compute tangents (in the Keys collection of the Curve). |
| [CurveTangent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.CurveTangent.html) | tangentInType | The type of TangentIn to compute (one of the types specified in the CurveTangent enumeration). |
| [CurveTangent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.CurveTangent.html) | tangentOutType | The type of TangentOut to compute (one of the types specified in the CurveTangent enumeration). |

#### ComputeTangents(CurveTangent)

Computes all tangents for all CurveKeys in this Curve, using a specified tangent type for both TangentIn and TangentOut.

##### Declaration

```
public void ComputeTangents(CurveTangent tangentType)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [CurveTangent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.CurveTangent.html) | tangentType | The type of TangentOut and TangentIn to compute (one of the types specified in the CurveTangent enumeration). |

#### ComputeTangents(CurveTangent, CurveTangent)

Computes all tangents for all CurveKeys in this Curve, using different tangent types for TangentOut and TangentIn.

##### Declaration

```
public void ComputeTangents(CurveTangent tangentInType, CurveTangent tangentOutType)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [CurveTangent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.CurveTangent.html) | tangentInType | The type of TangentIn to compute (one of the types specified in the CurveTangent enumeration). |
| [CurveTangent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.CurveTangent.html) | tangentOutType | The type of TangentOut to compute (one of the types specified in the CurveTangent enumeration). |

#### Evaluate(Single)

Finds the value at a position on the Curve.

##### Declaration

```
public float Evaluate(float position)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | position | The position on the Curve. |

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |