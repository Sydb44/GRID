##### Declaration

```
public bool IntersectsTriangle(ref Vector3I v0, ref Vector3I v1, ref Vector3I v2)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | v0  |     |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | v1  |     |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | v2  |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IntersectWith(ref BoundingBoxI)

Returns bounding box which is intersection of this and box  
Result is invalid box when there's no intersection (Min > Max)

##### Declaration

```
public void IntersectWith(ref BoundingBoxI box)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxI.html) | box |     |

#### IterateDifference(BoundingBoxI, BoundingBoxI)

Iterate every cell contained in {left} - {right}, where we interpret {box} as the set of all distinct Vector3I points inside a 'box'.

Containment is taken in a typical inclusive start, exclusive end fashion.

##### Declaration

```
public static IEnumerable<Vector3I> IterateDifference(BoundingBoxI left, BoundingBoxI right)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxI.html) | left | The left bounding box. |
| [BoundingBoxI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxI.html) | right | The right bounding box. |

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.IEnumerable<[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)\> |     |

#### SurfaceArea()

##### Declaration

```
public float SurfaceArea()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### ToString()

Returns a String that represents the current BoundingBoxI.

##### Declaration

```
public override string ToString()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

#### Translate(Vector3I)

Translate

##### Declaration

```
public BoundingBoxI Translate(Vector3I vctTranlsation)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | vctTranlsation |     |

##### Returns

| Type | Description |
| --- | --- |
| [BoundingBoxI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxI.html) |     |

#### Volume()

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

### Operators

#### Equality(BoundingBoxI, BoundingBoxI)

Determines whether two instances of BoundingBoxI are equal.

##### Declaration

```
public static bool operator ==(BoundingBoxI a, BoundingBoxI b)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxI.html) | a   | BoundingBoxI to compare. |
| [BoundingBoxI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxI.html) | b   | BoundingBoxI to compare. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Explicit(BoundingBox to BoundingBoxI)

##### Declaration

```
public static explicit operator BoundingBoxI(BoundingBox box)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) | box |     |

##### Returns

| Type | Description |
| --- | --- |
| [BoundingBoxI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxI.html) |     |

#### Explicit(BoundingBoxD to BoundingBoxI)

##### Declaration

```
public static explicit operator BoundingBoxI(BoundingBoxD box)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | box |     |

##### Returns

| Type | Description |
| --- | --- |
| [BoundingBoxI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxI.html) |     |

#### Inequality(BoundingBoxI, BoundingBoxI)

Determines whether two instances of BoundingBoxI are not equal.

##### Declaration

```
public static bool operator !=(BoundingBoxI a, BoundingBoxI b)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxI.html) | a   | The object to the left of the inequality operator. |
| [BoundingBoxI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxI.html) | b   | The object to the right of the inequality operator. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |