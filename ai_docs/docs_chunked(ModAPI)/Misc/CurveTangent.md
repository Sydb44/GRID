---
title: "Class CurveTangent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.CurveTangent.html"
category: "Misc"
namespace: "VRageMath"
class: "CurveTangent"
---

# Class CurveTangent | Space Engineers ModAPI

Specifies different tangent types to be calculated for CurveKey points in a Curve.

##### Inheritance

System.Object

CurveTangent

###### **Namespace**: [VRageMath](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.html)

###### **Assembly**: VRage.Math.dll

##### Syntax

```
public sealed class CurveTangent : Enum
```

### Fields

#### Flat

A Flat tangent always has a value equal to zero.

##### Declaration

```
public const CurveTangent Flat
```

##### Field Value

| Type | Description |
| --- | --- |
| [CurveTangent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.CurveTangent.html) |     |

#### Linear

A Linear tangent at a CurveKey is equal to the difference between its Value and the Value of the preceding or succeeding CurveKey. For example, in Curve MyCurve, where i is greater than zero and (i + 1) is less than the total number of CurveKeys in MyCurve, the linear TangentIn of MyCurve.Keys\[i\] is equal to: ( MyCurve.Keys\[i\].Value - MyCurve.Keys\[i - 1\].Value ) Similarly, the linear TangentOut is equal to: ( MyCurve.Keys\[i + 1\].Value - MyCurve.Keys\[i\].Value.)

##### Declaration

```
public const CurveTangent Linear
```

##### Field Value

| Type | Description |
| --- | --- |
| [CurveTangent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.CurveTangent.html) |     |

#### Smooth

A Smooth tangent smooths the inflection between a TangentIn and TangentOut by taking into account the values of both neighbors of the CurveKey. The smooth TangentIn of MyCurve.Keys\[i\] is equal to: ( ( MyCurve.Keys\[i + 1\].Value - MyCurve.Keys\[i - 1\].Value ) \* ( ( MyCurve.Keys\[i\].Position - MyCurve.Keys\[i - 1\].Position ) / ( MyCurve.Keys\[i + 1\].Position - MyCurve.Keys\[i-1\].Position ) ) ) Similarly, the smooth TangentOut is equal to: ( ( MyCurve.Keys\[i + 1\].Value - MyCurve.Keys\[i - 1\].Value ) \* ( ( MyCurve.Keys\[i + 1\].Position - MyCurve.Keys\[i\].Position ) / ( MyCurve.Keys\[i + 1\].Position - MyCurve.Keys\[i - 1\].Position ) ) )

##### Declaration

```
public const CurveTangent Smooth
```

##### Field Value

| Type | Description |
| --- | --- |
| [CurveTangent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.CurveTangent.html) |     |

#### value\_\_

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |