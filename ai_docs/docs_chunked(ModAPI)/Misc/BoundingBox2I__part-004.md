| Type | Name | Description |
| --- | --- | --- |
| [BoundingBox2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2I.html) | box |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Intersects(ref BoundingBox2I, out Boolean)

Checks whether the current BoundingBox2I intersects another BoundingBox2I.

##### Declaration

```
public void Intersects(ref BoundingBox2I box, out bool result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBox2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2I.html) | box | The BoundingBox2I to check for intersection with. |
| System.Boolean | result | \[OutAttribute\] true if the BoundingBox2I instances intersect; false otherwise. |

#### Perimeter()

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### Scale(Vector2I)

##### Declaration

```
public void Scale(Vector2I scale)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2I.html) | scale |     |

#### ToString()

Returns a String that represents the current BoundingBox2I.

##### Declaration

```
public override string ToString()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

#### Translate(Vector2I)

Translate

##### Declaration

```
public BoundingBox2I Translate(Vector2I vctTranlsation)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2I.html) | vctTranlsation |     |

##### Returns

| Type | Description |
| --- | --- |
| [BoundingBox2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2I.html) |     |

### Operators

#### Equality(BoundingBox2I, BoundingBox2I)

Determines whether two instances of BoundingBox2I are equal.

##### Declaration

```
public static bool operator ==(BoundingBox2I a, BoundingBox2I b)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBox2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2I.html) | a   | BoundingBox2I to compare. |
| [BoundingBox2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2I.html) | b   | BoundingBox2I to compare. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Inequality(BoundingBox2I, BoundingBox2I)

Determines whether two instances of BoundingBox2I are not equal.

##### Declaration

```
public static bool operator !=(BoundingBox2I a, BoundingBox2I b)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBox2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2I.html) | a   | The object to the left of the inequality operator. |
| [BoundingBox2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2I.html) | b   | The object to the right of the inequality operator. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |