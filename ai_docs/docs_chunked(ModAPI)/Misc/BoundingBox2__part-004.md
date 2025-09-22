| Type | Name | Description |
| --- | --- | --- |
| [BoundingBox2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2.html) | box |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Intersects(ref BoundingBox2, out Boolean)

Checks whether the current BoundingBox2 intersects another BoundingBox2.

##### Declaration

```
public void Intersects(ref BoundingBox2 box, out bool result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBox2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2.html) | box | The BoundingBox2 to check for intersection with. |
| System.Boolean | result | \[OutAttribute\] true if the BoundingBox2 instances intersect; false otherwise. |

#### Perimeter()

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### Scale(Vector2)

##### Declaration

```
public void Scale(Vector2 scale)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html) | scale |     |

#### ToString()

Returns a String that represents the current BoundingBox2.

##### Declaration

```
public override string ToString()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

#### Translate(Vector2)

Translate

##### Declaration

```
public BoundingBox2 Translate(Vector2 vctTranlsation)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html) | vctTranlsation |     |

##### Returns

| Type | Description |
| --- | --- |
| [BoundingBox2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2.html) |     |

### Operators

#### Equality(BoundingBox2, BoundingBox2)

Determines whether two instances of BoundingBox2 are equal.

##### Declaration

```
public static bool operator ==(BoundingBox2 a, BoundingBox2 b)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBox2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2.html) | a   | BoundingBox2 to compare. |
| [BoundingBox2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2.html) | b   | BoundingBox2 to compare. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Inequality(BoundingBox2, BoundingBox2)

Determines whether two instances of BoundingBox2 are not equal.

##### Declaration

```
public static bool operator !=(BoundingBox2 a, BoundingBox2 b)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBox2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2.html) | a   | The object to the left of the inequality operator. |
| [BoundingBox2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2.html) | b   | The object to the right of the inequality operator. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |