Determines whether the specified Object is equal to the Rectangle.

##### Declaration

```
public bool Equals(Rectangle other)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Rectangle](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Rectangle.html) | other | The Object to compare with the current Rectangle. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### GetHashCode()

Gets the hash code for this object.

##### Declaration

```
public override int GetHashCode()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### Inflate(Int32, Int32)

Pushes the edges of the Rectangle out by the horizontal and vertical values specified.

##### Declaration

```
public void Inflate(int horizontalAmount, int verticalAmount)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | horizontalAmount | Value to push the sides out by. |
| System.Int32 | verticalAmount | Value to push the top and bottom out by. |

#### Intersect(Rectangle, Rectangle)

Creates a Rectangle defining the area where one rectangle overlaps with another rectangle.

##### Declaration

```
public static Rectangle Intersect(Rectangle value1, Rectangle value2)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Rectangle](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Rectangle.html) | value1 | The first Rectangle to compare. |
| [Rectangle](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Rectangle.html) | value2 | The second Rectangle to compare. |

##### Returns

| Type | Description |
| --- | --- |
| [Rectangle](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Rectangle.html) |     |

#### Intersect(ref Rectangle, ref Rectangle, out Rectangle)

Creates a Rectangle defining the area where one rectangle overlaps with another rectangle.

##### Declaration

```
public static void Intersect(ref Rectangle value1, ref Rectangle value2, out Rectangle result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Rectangle](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Rectangle.html) | value1 | The first Rectangle to compare. |
| [Rectangle](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Rectangle.html) | value2 | The second Rectangle to compare. |
| [Rectangle](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Rectangle.html) | result | \[OutAttribute\] The area where the two first parameters overlap. |

#### Intersects(Rectangle)

Determines whether a specified Rectangle intersects with this Rectangle.

##### Declaration

```
public bool Intersects(Rectangle value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Rectangle](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Rectangle.html) | value | The Rectangle to evaluate. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Intersects(ref Rectangle, out Boolean)

Determines whether a specified Rectangle intersects with this Rectangle.

##### Declaration

```
public void Intersects(ref Rectangle value, out bool result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Rectangle](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Rectangle.html) | value | The Rectangle to evaluate |
| System.Boolean | result | \[OutAttribute\] true if the specified Rectangle intersects with this one; false otherwise. |

#### Offset(Int32, Int32)

Changes the position of the Rectangle.

##### Declaration

```
public void Offset(int offsetX, int offsetY)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | offsetX | Change in the x-position. |
| System.Int32 | offsetY | Change in the y-position. |

#### Offset(Point)

Changes the position of the Rectangle.

##### Declaration

```
public void Offset(Point amount)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Point](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Point.html) | amount | The values to adjust the position of the Rectangle by. |

#### ToString()

Retrieves a string representation of the current object.

##### Declaration

```
public override string ToString()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

#### Union(Rectangle, Rectangle)

Creates a new Rectangle that exactly contains two other rectangles.

##### Declaration

```
public static Rectangle Union(Rectangle value1, Rectangle value2)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Rectangle](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Rectangle.html) | value1 | The first Rectangle to contain. |
| [Rectangle](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Rectangle.html) | value2 | The second Rectangle to contain. |

##### Returns

| Type | Description |
| --- | --- |
| [Rectangle](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Rectangle.html) |     |

#### Union(ref Rectangle, ref Rectangle, out Rectangle)

Creates a new Rectangle that exactly contains two other rectangles.

##### Declaration

```
public static void Union(ref Rectangle value1, ref Rectangle value2, out Rectangle result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Rectangle](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Rectangle.html) | value1 | The first Rectangle to contain. |
| [Rectangle](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Rectangle.html) | value2 | The second Rectangle to contain. |
| [Rectangle](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Rectangle.html) | result | \[OutAttribute\] The Rectangle that must be the union of the first two rectangles. |
