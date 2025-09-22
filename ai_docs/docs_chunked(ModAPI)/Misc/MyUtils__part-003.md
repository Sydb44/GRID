System.String

s

##### Returns

Type

Description

System.Nullable<System.Boolean\>

#### GetBoolFromString(String, Boolean)

##### Declaration

```
public static bool GetBoolFromString(string s, bool defaultValue)
```

##### Parameters

Type

Name

Description

System.String

s

System.Boolean

defaultValue

##### Returns

Type

Description

System.Boolean

#### GetBoundingSphereFromBoundingBox(ref BoundingBoxD)

##### Declaration

```
public static BoundingSphereD GetBoundingSphereFromBoundingBox(ref BoundingBoxD box)
```

##### Parameters

Type

Name

Description

[BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html)

box

##### Returns

Type

Description

[BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html)

#### GetByteFromString(String)

##### Declaration

```
public static Nullable<byte> GetByteFromString(string s)
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

System.Nullable<System.Byte\>

#### GetCartesianCoordinatesFromSpherical(Single, Single, Single)

##### Declaration

```
public static Vector3 GetCartesianCoordinatesFromSpherical(float angleHorizontal, float angleVertical, float radius)
```

##### Parameters

Type

Name

Description

System.Single

angleHorizontal

System.Single

angleVertical

System.Single

radius

##### Returns

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### GetClampInt(Int32, Int32, Int32)

##### Declaration

```
public static int GetClampInt(int value, int min, int max)
```

##### Parameters

Type

Name

Description

System.Int32

value

System.Int32

min

System.Int32

max

##### Returns

Type

Description

System.Int32

#### GetClosestPointOnLine(ref Vector3, ref Vector3, ref Vector3)

##### Declaration

```
public static Vector3 GetClosestPointOnLine(ref Vector3 linePointA, ref Vector3 linePointB, ref Vector3 point)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

linePointA

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

linePointB

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

point

##### Returns

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### GetClosestPointOnLine(ref Vector3, ref Vector3, ref Vector3, out Single)

##### Declaration

```
public static Vector3 GetClosestPointOnLine(ref Vector3 linePointA, ref Vector3 linePointB, ref Vector3 point, out float dist)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

linePointA

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

linePointB

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

point

System.Single

dist

##### Returns

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### GetClosestPointOnLine(ref Vector3D, ref Vector3D, ref Vector3D)

##### Declaration

```
public static Vector3D GetClosestPointOnLine(ref Vector3D linePointA, ref Vector3D linePointB, ref Vector3D point)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

linePointA

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

linePointB

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

point

##### Returns

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### GetClosestPointOnLine(ref Vector3D, ref Vector3D, ref Vector3D, out Double)

##### Declaration

```
public static Vector3D GetClosestPointOnLine(ref Vector3D linePointA, ref Vector3D linePointB, ref Vector3D point, out double dist)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

linePointA

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

linePointB

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

point

System.Double

dist

##### Returns

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### GetCoordAligned(Vector2, Vector2, MyGuiDrawAlignEnum)

Aligns rectangle, works in screen/texture/pixel coordinates, not normalized coordinates.

##### Declaration

```
public static Vector2 GetCoordAligned(Vector2 coordScreen, Vector2 size, MyGuiDrawAlignEnum drawAlign)
```

##### Parameters

Type

Name

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

coordScreen

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

size

[MyGuiDrawAlignEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyGuiDrawAlignEnum.html)

drawAlign

##### Returns

Type

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

Pixel coordinates for texture.

#### GetCoordAlignedFromCenter(Vector2, Vector2, MyGuiDrawAlignEnum)

Modifies input coordinate (in center) using alignment and size of the rectangle. Result is at position inside rectangle specified by alignment.

##### Declaration

```
public static Vector2 GetCoordAlignedFromCenter(Vector2 coordCenter, Vector2 size, MyGuiDrawAlignEnum drawAlign)
```

##### Parameters

Type

Name

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

coordCenter

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

size

[MyGuiDrawAlignEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyGuiDrawAlignEnum.html)

drawAlign
