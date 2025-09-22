```
public override int GetHashCode()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### [](#VRageMath_RectangleF_Intersect_VRageMath_RectangleF__VRageMath_RectangleF__VRageMath_RectangleF__)Intersect(ref RectangleF, ref RectangleF, out RectangleF)

Creates a Rectangle defining the area where one rectangle overlaps with another rectangle.

##### Declaration

```
public static bool Intersect(ref RectangleF value1, ref RectangleF value2, out RectangleF result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [RectangleF](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.RectangleF.html) | value1 | The first Rectangle to compare. |
| [RectangleF](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.RectangleF.html) | value2 | The second Rectangle to compare. |
| [RectangleF](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.RectangleF.html) | result | \[OutAttribute\] The area where the two first parameters overlap. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRageMath_RectangleF_Min_System_Nullable_VRageMath_RectangleF__System_Nullable_VRageMath_RectangleF__)Min(Nullable<RectangleF>, Nullable<RectangleF>)

##### Declaration

```
public static RectangleF Min(Nullable<RectangleF> rectangle, Nullable<RectangleF> scissors)
```

##### Parameters

##### Returns

#### [](#VRageMath_RectangleF_ToString)ToString()

##### Declaration

```
public override string ToString()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

### [](#operators)Operators

#### [](#VRageMath_RectangleF_op_Equality_VRageMath_RectangleF_VRageMath_RectangleF_)Equality(RectangleF, RectangleF)

Implements the operator ==.

##### Declaration

```
public static bool operator ==(RectangleF left, RectangleF right)
```

##### Parameters

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | The result of the operator. |

#### [](#VRageMath_RectangleF_op_Inequality_VRageMath_RectangleF_VRageMath_RectangleF_)Inequality(RectangleF, RectangleF)

Implements the operator !=.

##### Declaration

```
public static bool operator !=(RectangleF left, RectangleF right)
```

##### Parameters

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | The result of the operator. |