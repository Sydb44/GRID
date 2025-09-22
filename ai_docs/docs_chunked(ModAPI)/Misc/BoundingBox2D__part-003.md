##### Parameters

##### Returns

#### [](#VRageMath_BoundingBox2D_Include_VRageMath_BoundingBox2D__)Include(ref BoundingBox2D)

return expanded aabb (abb include point)

##### Declaration

```
public BoundingBox2D Include(ref BoundingBox2D box)
```

##### Parameters

##### Returns

#### [](#VRageMath_BoundingBox2D_Include_VRageMath_Vector2D_)Include(Vector2D)

##### Declaration

```
public BoundingBox2D Include(Vector2D point)
```

##### Parameters

##### Returns

#### [](#VRageMath_BoundingBox2D_Include_VRageMath_Vector2D_VRageMath_Vector2D_VRageMath_Vector2D_)Include(Vector2D, Vector2D, Vector2D)

##### Declaration

```
public BoundingBox2D Include(Vector2D p0, Vector2D p1, Vector2D p2)
```

##### Parameters

##### Returns

#### [](#VRageMath_BoundingBox2D_Include_VRageMath_Vector2D__)Include(ref Vector2D)

return expanded aabb (abb include point)

##### Declaration

```
public BoundingBox2D Include(ref Vector2D point)
```

##### Parameters

##### Returns

#### [](#VRageMath_BoundingBox2D_Include_VRageMath_Vector2D__VRageMath_Vector2D__VRageMath_Vector2D__)Include(ref Vector2D, ref Vector2D, ref Vector2D)

##### Declaration

```
public BoundingBox2D Include(ref Vector2D p0, ref Vector2D p1, ref Vector2D p2)
```

##### Parameters

##### Returns

#### [](#VRageMath_BoundingBox2D_Inflate_System_Double_)Inflate(Double)

##### Declaration

```
public void Inflate(double size)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Double | size |     |

#### [](#VRageMath_BoundingBox2D_InflateToMinimum_VRageMath_Vector2D_)InflateToMinimum(Vector2D)

##### Declaration

```
public void InflateToMinimum(Vector2D minimumSize)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html) | minimumSize |     |

#### [](#VRageMath_BoundingBox2D_Intersect_VRageMath_BoundingBox2D_)Intersect(BoundingBox2D)

Returns bounding box which is intersection of this and box It's called 'Prunik' Result is invalid box when there's no intersection (Min > Max)

##### Declaration

```
public BoundingBox2D Intersect(BoundingBox2D box)
```

##### Parameters

##### Returns

#### [](#VRageMath_BoundingBox2D_Intersects_VRageMath_BoundingBox2D_)Intersects(BoundingBox2D)

Checks whether the current BoundingBox2D intersects another BoundingBox2D.

##### Declaration

```
public bool Intersects(BoundingBox2D box)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBox2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2D.html) | box | The BoundingBox2D to check for intersection with. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRageMath_BoundingBox2D_Intersects_VRageMath_BoundingBox2D__)Intersects(ref BoundingBox2D)

##### Declaration

```
public bool Intersects(ref BoundingBox2D box)
```

##### Parameters

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRageMath_BoundingBox2D_Intersects_VRageMath_BoundingBox2D__System_Boolean__)Intersects(ref BoundingBox2D, out Boolean)

Checks whether the current BoundingBox2D intersects another BoundingBox2D.

##### Declaration

```
public void Intersects(ref BoundingBox2D box, out bool result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBox2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2D.html) | box | The BoundingBox2D to check for intersection with. |
| System.Boolean | result | \[OutAttribute\] true if the BoundingBox2D instances intersect; false otherwise. |

#### [](#VRageMath_BoundingBox2D_Perimeter)Perimeter()

##### Declaration

```
public double Perimeter()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Double |     |

#### [](#VRageMath_BoundingBox2D_Scale_VRageMath_Vector2D_)Scale(Vector2D)

##### Declaration

```
public void Scale(Vector2D scale)
```

##### Parameters

#### [](#VRageMath_BoundingBox2D_ToString)ToString()

Returns a String that represents the current BoundingBox2D.

##### Declaration

```
public override string ToString()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

#### [](#VRageMath_BoundingBox2D_Translate_VRageMath_Vector2D_)Translate(Vector2D)

Translate

##### Declaration

```
public BoundingBox2D Translate(Vector2D vctTranlsation)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html) | vctTranlsation |     |

##### Returns

### [](#operators)Operators

#### [](#VRageMath_BoundingBox2D_op_Equality_VRageMath_BoundingBox2D_VRageMath_BoundingBox2D_)Equality(BoundingBox2D, BoundingBox2D)

Determines whether two instances of BoundingBox2D are equal.

##### Declaration

```
public static bool operator ==(BoundingBox2D a, BoundingBox2D b)
```

##### Parameters

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRageMath_BoundingBox2D_op_Inequality_VRageMath_BoundingBox2D_VRageMath_BoundingBox2D_)Inequality(BoundingBox2D, BoundingBox2D)

Determines whether two instances of BoundingBox2D are not equal.

##### Declaration

```
public static bool operator !=(BoundingBox2D a, BoundingBox2D b)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBox2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2D.html) | a   | The object to the left of the inequality operator. |
| [BoundingBox2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2D.html) | b   | The object to the right of the inequality operator. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |