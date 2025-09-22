Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

coordCenter

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

size

[MyGuiDrawAlignEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyGuiDrawAlignEnum.html)

drawAlign

##### Returns

Type

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

#### GetCoordAlignedFromRectangle(ref RectangleF, MyGuiDrawAlignEnum)

Returns coordinate within given rectangle specified by draw align. Rectangle position should be upper left corner. Conversion assumes that Y coordinates increase downwards.

##### Declaration

```
public static Vector2 GetCoordAlignedFromRectangle(ref RectangleF rect, MyGuiDrawAlignEnum drawAlign)
```

##### Parameters

Type

Name

Description

[RectangleF](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.RectangleF.html)

rect

[MyGuiDrawAlignEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyGuiDrawAlignEnum.html)

drawAlign

##### Returns

Type

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

#### GetCoordAlignedFromTopLeft(Vector2, Vector2, MyGuiDrawAlignEnum)

##### Declaration

```
public static Vector2 GetCoordAlignedFromTopLeft(Vector2 topLeft, Vector2 size, MyGuiDrawAlignEnum drawAlign)
```

##### Parameters

Type

Name

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

topLeft

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

size

[MyGuiDrawAlignEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyGuiDrawAlignEnum.html)

drawAlign

##### Returns

Type

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

#### GetCoordCenterFromAligned(Vector2, Vector2, MyGuiDrawAlignEnum)

Reverses effect of alignment to compute center coordinate.

##### Declaration

```
public static Vector2 GetCoordCenterFromAligned(Vector2 alignedCoord, Vector2 size, MyGuiDrawAlignEnum drawAlign)
```

##### Parameters

Type

Name

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

alignedCoord

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

size

[MyGuiDrawAlignEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyGuiDrawAlignEnum.html)

drawAlign

##### Returns

Type

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

#### GetCoordTopLeftFromAligned(Vector2, Vector2, MyGuiDrawAlignEnum)

Reverses effect of alignment to compute top-left corner coordinate.

##### Declaration

```
public static Vector2 GetCoordTopLeftFromAligned(Vector2 alignedCoord, Vector2 size, MyGuiDrawAlignEnum drawAlign)
```

##### Parameters

Type

Name

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

alignedCoord

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

size

[MyGuiDrawAlignEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyGuiDrawAlignEnum.html)

drawAlign

##### Returns

Type

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

#### GetCoordTopLeftFromAligned(Vector2I, Vector2I, MyGuiDrawAlignEnum)

Reverses effect of alignment to compute top-left corner coordinate.

##### Declaration

```
public static Vector2I GetCoordTopLeftFromAligned(Vector2I alignedCoord, Vector2I size, MyGuiDrawAlignEnum drawAlign)
```

##### Parameters

Type

Name

Description

[Vector2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2I.html)

alignedCoord

[Vector2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2I.html)

size

[MyGuiDrawAlignEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyGuiDrawAlignEnum.html)

drawAlign

##### Returns

Type

Description

[Vector2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2I.html)

#### GetEdgeSphereCollision(ref Vector3, Single, ref MyTriangle\_Vertices)

Returns intersection point between sphere and its edges. But only if there is intersection between sphere and one of the edges. If sphere intersects somewhere inside the triangle, this method will not detect it.

##### Declaration

```
public static Nullable<Vector3> GetEdgeSphereCollision(ref Vector3 sphereCenter, float sphereRadius, ref MyTriangle_Vertices triangle)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

sphereCenter

System.Single

sphereRadius

VRage.MyTriangle\_Vertices

triangle

##### Returns

Type

Description

System.Nullable<[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)\>

#### GetFixedInvalidFileNameChars()

##### Declaration

```
public static char[] GetFixedInvalidFileNameChars()
```

##### Returns

Type

Description

System.Char\[\]

#### GetFixedInvalidPathChars()

##### Declaration

```
public static char[] GetFixedInvalidPathChars()
```

##### Returns

Type

Description

System.Char\[\]

#### GetFloatFromString(String)

##### Declaration

```
public static Nullable<float> GetFloatFromString(string s)
```

##### Parameters

Type

Name

Description

System.String

s

##### Returns

Type

Description

System.Nullable<System.Single\>

#### GetFloatFromString(String, Single)

##### Declaration

```
public static float GetFloatFromString(string s, float defaultValue)
```

##### Parameters

Type

Name

Description

System.String

s

System.Single

defaultValue
