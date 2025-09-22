---
title: "Class CurveContinuity"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.CurveContinuity.html"
category: "Misc"
namespace: "VRageMath"
class: "CurveContinuity"
---

# Class CurveContinuity | Space Engineers ModAPI

Defines the continuity of CurveKeys on a Curve.

##### Inheritance

System.Object

CurveContinuity

###### **Namespace**: [VRageMath](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.html)

###### **Assembly**: VRage.Math.dll

##### Syntax

```
public sealed class CurveContinuity : Enum
```

### Fields

#### Smooth

Interpolation can be used between this CurveKey and the next.

##### Declaration

```
public const CurveContinuity Smooth
```

##### Field Value

| Type | Description |
| --- | --- |
| [CurveContinuity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.CurveContinuity.html) |     |

#### Step

Interpolation cannot be used between this CurveKey and the next. Specifying a position between the two points returns this point.

##### Declaration

```
public const CurveContinuity Step
```

##### Field Value

| Type | Description |
| --- | --- |
| [CurveContinuity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.CurveContinuity.html) |     |

#### value\_\_

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |