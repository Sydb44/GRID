---
title: "Class CurveKey"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.CurveKey.html"
category: "Misc"
namespace: "VRageMath"
class: "CurveKey"
---

# Class CurveKey | Space Engineers ModAPI

Represents a point in a multi-point curve.

##### Inheritance

System.Object

CurveKey

###### **Namespace**: [VRageMath](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.html)

###### **Assembly**: VRage.Math.dll

##### Syntax

```
public class CurveKey : Object, IEquatable<CurveKey>, IComparable<CurveKey>
```

### [](#constructors)Constructors

#### [](#VRageMath_CurveKey__ctor)CurveKey()

##### Declaration

#### [](#VRageMath_CurveKey__ctor_System_Single_System_Single_)CurveKey(Single, Single)

Initializes a new instance of CurveKey.

##### Declaration

```
public CurveKey(float position, float value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | position | Position in the curve. |
| System.Single | value | Value of the control point. |

#### [](#VRageMath_CurveKey__ctor_System_Single_System_Single_System_Single_System_Single_)CurveKey(Single, Single, Single, Single)

Initializes a new instance of CurveKey.

##### Declaration

```
public CurveKey(float position, float value, float tangentIn, float tangentOut)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | position | Position in the curve. |
| System.Single | value | Value of the control point. |
| System.Single | tangentIn | Tangent approaching point from the previous point in the curve. |
| System.Single | tangentOut | Tangent leaving point toward next point in the curve. |

#### [](#VRageMath_CurveKey__ctor_System_Single_System_Single_System_Single_System_Single_VRageMath_CurveContinuity_)CurveKey(Single, Single, Single, Single, CurveContinuity)

Initializes a new instance of CurveKey.

##### Declaration

```
public CurveKey(float position, float value, float tangentIn, float tangentOut, CurveContinuity continuity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | position | Position in the curve. |
| System.Single | value | Value of the control point. |
| System.Single | tangentIn | Tangent approaching point from the previous point in the curve. |
| System.Single | tangentOut | Tangent leaving point toward next point in the curve. |
| [CurveContinuity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.CurveContinuity.html) | continuity | Enum indicating whether the curve is discrete or continuous. |

### [](#properties)Properties

#### [](#VRageMath_CurveKey_Continuity)Continuity

Describes whether the segment between this point and the next point in the curve is discrete or continuous.

##### Declaration

```
public CurveContinuity Continuity { get; set; }
```

##### Property Value

#### [](#VRageMath_CurveKey_Position)Position

Position of the CurveKey in the curve.

##### Declaration

```
public float Position { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### [](#VRageMath_CurveKey_TangentIn)TangentIn

Describes the tangent when approaching this point from the previous point in the curve.

##### Declaration

```
public float TangentIn { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### [](#VRageMath_CurveKey_TangentOut)TangentOut

Describes the tangent when leaving this point to the next point in the curve.

##### Declaration

```
public float TangentOut { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### [](#VRageMath_CurveKey_Value)Value

Describes the value of this point.

##### Declaration

```
public float Value { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

### [](#methods)Methods

#### [](#VRageMath_CurveKey_Clone)Clone()

Creates a copy of the CurveKey.

##### Declaration

##### Returns

#### [](#VRageMath_CurveKey_CompareTo_VRageMath_CurveKey_)CompareTo(CurveKey)

Compares this instance to another CurveKey and returns an indication of their relative values.

##### Declaration

```
public int CompareTo(CurveKey other)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [CurveKey](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.CurveKey.html) | other | CurveKey to compare to. |

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### [](#VRageMath_CurveKey_Equals_System_Object_)Equals(Object)

Returns a value that indicates whether the current instance is equal to a specified object.

##### Declaration

```
public override bool Equals(object obj)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | obj | Object with which to make the comparison. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRageMath_CurveKey_Equals_VRageMath_CurveKey_)Equals(CurveKey)

Determines whether the specified Object is equal to the CurveKey.

##### Declaration

```
public bool Equals(CurveKey other)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [CurveKey](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.CurveKey.html) | other | The Object to compare with the current CurveKey. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRageMath_CurveKey_GetHashCode)GetHashCode()

Returns the hash code for this instance.

##### Declaration

```
public override int GetHashCode()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

### [](#operators)Operators

#### [](#VRageMath_CurveKey_op_Equality_VRageMath_CurveKey_VRageMath_CurveKey_)Equality(CurveKey, CurveKey)

Determines whether two CurveKey instances are equal.

##### Declaration

```
public static bool operator ==(CurveKey a, CurveKey b)
```
