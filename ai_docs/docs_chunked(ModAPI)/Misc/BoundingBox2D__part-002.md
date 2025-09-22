##### Declaration

```
public static BoundingBox2D CreateFromHalfExtent(Vector2D center, Vector2D halfExtent)
```

##### Parameters

##### Returns

#### [](#VRageMath_BoundingBox2D_CreateFromPoints_System_Collections_Generic_IEnumerable_VRageMath_Vector2D__)CreateFromPoints(IEnumerable<Vector2D>)

Creates the smallest BoundingBox2D that will contain a group of points.

##### Declaration

```
public static BoundingBox2D CreateFromPoints(IEnumerable<Vector2D> points)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.IEnumerable<[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)\> | points | A list of points the BoundingBox2D should contain. |

##### Returns

#### [](#VRageMath_BoundingBox2D_CreateInvalid)CreateInvalid()

##### Declaration

```
public static BoundingBox2D CreateInvalid()
```

##### Returns

#### [](#VRageMath_BoundingBox2D_CreateMerged_VRageMath_BoundingBox2D_VRageMath_BoundingBox2D_)CreateMerged(BoundingBox2D, BoundingBox2D)

Creates the smallest BoundingBox2D that contains the two specified BoundingBox2D instances.

##### Declaration

```
public static BoundingBox2D CreateMerged(BoundingBox2D original, BoundingBox2D additional)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBox2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2D.html) | original | One of the BoundingBox2Ds to contain. |
| [BoundingBox2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2D.html) | additional | One of the BoundingBox2Ds to contain. |

##### Returns

#### [](#VRageMath_BoundingBox2D_CreateMerged_VRageMath_BoundingBox2D__VRageMath_BoundingBox2D__VRageMath_BoundingBox2D__)CreateMerged(ref BoundingBox2D, ref BoundingBox2D, out BoundingBox2D)

Creates the smallest BoundingBox2D that contains the two specified BoundingBox2D instances.

##### Declaration

```
public static void CreateMerged(ref BoundingBox2D original, ref BoundingBox2D additional, out BoundingBox2D result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBox2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2D.html) | original | One of the BoundingBox2D instances to contain. |
| [BoundingBox2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2D.html) | additional | One of the BoundingBox2D instances to contain. |
| [BoundingBox2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2D.html) | result | \[OutAttribute\] The created BoundingBox2D. |

#### [](#VRageMath_BoundingBox2D_Distance_VRageMath_Vector2D_)Distance(Vector2D)

##### Declaration

```
public double Distance(Vector2D point)
```

##### Parameters

##### Returns

| Type | Description |
| --- | --- |
| System.Double |     |

#### [](#VRageMath_BoundingBox2D_Equals_System_Object_)Equals(Object)

Determines whether two instances of BoundingBox2D are equal.

##### Declaration

```
public override bool Equals(object obj)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | obj | The Object to compare with the current BoundingBox2D. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRageMath_BoundingBox2D_Equals_VRageMath_BoundingBox2D_)Equals(BoundingBox2D)

Determines whether two instances of BoundingBox2D are equal.

##### Declaration

```
public bool Equals(BoundingBox2D other)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBox2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2D.html) | other | The BoundingBox2D to compare with the current BoundingBox2D. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRageMath_BoundingBox2D_GetCorners)GetCorners()

Gets an array of points that make up the corners of the BoundingBox2D.

##### Declaration

```
public Vector2D[] GetCorners()
```

##### Returns

#### [](#VRageMath_BoundingBox2D_GetCorners_VRageMath_Vector2D___)GetCorners(Vector2D\[\])

Gets the array of points that make up the corners of the BoundingBox2D.

##### Declaration

```
public void GetCorners(Vector2D[] corners)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)\[\] | corners | An existing array of at least 8 Vector2D points where the corners of the BoundingBox2D are written. |

#### [](#VRageMath_BoundingBox2D_GetCornersUnsafe_VRageMath_Vector2D__)GetCornersUnsafe(Vector2D\*)

Gets the array of points that make up the corners of the BoundingBox2D.

##### Declaration

```
public void GetCornersUnsafe(Vector2D*corners)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)\* | corners | An existing array of at least 8 Vector2D points where the corners of the BoundingBox2D are written. |

#### [](#VRageMath_BoundingBox2D_GetHashCode)GetHashCode()

Gets the hash code for this instance.

##### Declaration

```
public override int GetHashCode()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### [](#VRageMath_BoundingBox2D_GetIncluded_VRageMath_Vector2D_)GetIncluded(Vector2D)

##### Declaration

```
public BoundingBox2D GetIncluded(Vector2D point)
```

##### Parameters

##### Returns

#### [](#VRageMath_BoundingBox2D_Include_VRageMath_BoundingBox2D_)Include(BoundingBox2D)

##### Declaration

```
public BoundingBox2D Include(BoundingBox2D box)
```

##### Parameters

##### Returns

#### [](#VRageMath_BoundingBox2D_Include_VRageMath_BoundingBox2D__)Include(ref BoundingBox2D)

return expanded aabb (abb include point)

##### Declaration

```
public BoundingBox2D Include(ref BoundingBox2D box)
```
