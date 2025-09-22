| Type | Description |
| --- | --- |
| [PlaneIntersectionType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.PlaneIntersectionType.html) |     |

#### Intersects(ref BoundingSphere, out PlaneIntersectionType)

Checks whether the current Plane intersects a BoundingSphere.

##### Declaration

```
public void Intersects(ref BoundingSphere sphere, out PlaneIntersectionType result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphere](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphere.html) | sphere | The BoundingSphere to check for intersection with. |
| [PlaneIntersectionType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.PlaneIntersectionType.html) | result | \[OutAttribute\] An enumeration indicating whether the Plane intersects the BoundingSphere. |

#### Normalize()

Changes the coefficients of the Normal vector of this Plane to make it of unit length.

##### Declaration

#### Normalize(Plane)

Changes the coefficients of the Normal vector of a Plane to make it of unit length.

##### Declaration

```
public static Plane Normalize(Plane value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Plane](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Plane.html) | value | The Plane to normalize. |

##### Returns

| Type | Description |
| --- | --- |
| [Plane](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Plane.html) |     |

#### Normalize(ref Plane, out Plane)

Changes the coefficients of the Normal vector of a Plane to make it of unit length.

##### Declaration

```
public static void Normalize(ref Plane value, out Plane result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Plane](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Plane.html) | value | The Plane to normalize. |
| [Plane](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Plane.html) | result | \[OutAttribute\] An existing plane Plane filled in with a normalized version of the specified plane. |

#### RandomPoint()

##### Declaration

```
public Vector3 RandomPoint()
```

##### Returns

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### ToString()

Returns a String that represents the current Plane.

##### Declaration

```
public override string ToString()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

#### Transform(Plane, Matrix)

Transforms a normalized Plane by a Matrix.

##### Declaration

```
public static Plane Transform(Plane plane, Matrix matrix)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Plane](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Plane.html) | plane | The normalized Plane to transform. This Plane must already be normalized, so that its Normal vector is of unit length, before this method is called. |
| [Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html) | matrix | The transform Matrix to apply to the Plane. |

##### Returns

| Type | Description |
| --- | --- |
| [Plane](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Plane.html) |     |

#### Transform(ref Plane, ref Matrix, out Plane)

Transforms a normalized Plane by a Matrix.

##### Declaration

```
public static void Transform(ref Plane plane, ref Matrix matrix, out Plane result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Plane](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Plane.html) | plane | The normalized Plane to transform. This Plane must already be normalized, so that its Normal vector is of unit length, before this method is called. |
| [Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html) | matrix | The transform Matrix to apply to the Plane. |
| [Plane](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Plane.html) | result | \[OutAttribute\] An existing Plane filled in with the results of applying the transform. |

### Operators

#### Equality(Plane, Plane)

Determines whether two instances of Plane are equal.

##### Declaration

```
public static bool operator ==(Plane lhs, Plane rhs)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Plane](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Plane.html) | lhs | The object to the left of the equality operator. |
| [Plane](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Plane.html) | rhs | The object to the right of the equality operator. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Inequality(Plane, Plane)

Determines whether two instances of Plane are not equal.

##### Declaration

```
public static bool operator !=(Plane lhs, Plane rhs)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Plane](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Plane.html) | lhs | The object to the left of the inequality operator. |
| [Plane](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Plane.html) | rhs | The object to the right of the inequality operator. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |