---
title: "Class CurveLoopType"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.CurveLoopType.html"
category: "Misc"
namespace: "VRageMath"
class: "CurveLoopType"
---

# Class CurveLoopType | Space Engineers ModAPI

Defines how the value of a Curve will be determined for positions before the first point on the Curve or after the last point on the Curve.

##### Inheritance

System.Object

CurveLoopType

###### **Namespace**: [VRageMath](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.html)

###### **Assembly**: VRage.Math.dll

##### Syntax

```
public sealed class CurveLoopType : Enum
```

### Fields

#### Constant

The Curve will evaluate to its first key for positions before the first point in the Curve and to the last key for positions after the last point.

##### Declaration

```
public const CurveLoopType Constant
```

##### Field Value

| Type | Description |
| --- | --- |
| [CurveLoopType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.CurveLoopType.html) |     |

#### Cycle

Positions specified past the ends of the curve will wrap around to the opposite side of the Curve.

##### Declaration

```
public const CurveLoopType Cycle
```

##### Field Value

| Type | Description |
| --- | --- |
| [CurveLoopType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.CurveLoopType.html) |     |

#### CycleOffset

Positions specified past the ends of the curve will wrap around to the opposite side of the Curve. The value will be offset by the difference between the values of the first and last CurveKey multiplied by the number of times the position wraps around. If the position is before the first point in the Curve, the difference will be subtracted from its value; otherwise, the difference will be added.

##### Declaration

```
public const CurveLoopType CycleOffset
```

##### Field Value

| Type | Description |
| --- | --- |
| [CurveLoopType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.CurveLoopType.html) |     |

#### Linear

Linear interpolation will be performed to determine the value.

##### Declaration

```
public const CurveLoopType Linear
```

##### Field Value

| Type | Description |
| --- | --- |
| [CurveLoopType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.CurveLoopType.html) |     |

#### Oscillate

Positions specified past the ends of the Curve act as an offset from the same side of the Curve toward the opposite side.

##### Declaration

```
public const CurveLoopType Oscillate
```

##### Field Value

| Type | Description |
| --- | --- |
| [CurveLoopType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.CurveLoopType.html) |     |

#### value\_\_

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |