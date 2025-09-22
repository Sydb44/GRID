Barycentric coordinate b2, which expresses the weighting factor toward vertex 2 (specified in value2).

System.Single

amount2

Barycentric coordinate b3, which expresses the weighting factor toward vertex 3 (specified in value3).

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

result

\[OutAttribute\] The 2D Cartesian coordinates of the specified point are placed in this Vector2 on exit.

#### Between(ref Vector2, ref Vector2)

##### Declaration

```
public bool Between(ref Vector2 start, ref Vector2 end)
```

##### Parameters

Type

Name

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

start

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

end

##### Returns

Type

Description

System.Boolean

#### CatmullRom(Vector2, Vector2, Vector2, Vector2, Single)

Performs a Catmull-Rom interpolation using the specified positions.

##### Declaration

```
public static Vector2 CatmullRom(Vector2 value1, Vector2 value2, Vector2 value3, Vector2 value4, float amount)
```

##### Parameters

Type

Name

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

value1

The first position in the interpolation.

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

value2

The second position in the interpolation.

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

value3

The third position in the interpolation.

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

value4

The fourth position in the interpolation.

System.Single

amount

Weighting factor.

##### Returns

Type

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

#### CatmullRom(ref Vector2, ref Vector2, ref Vector2, ref Vector2, Single, out Vector2)

Performs a Catmull-Rom interpolation using the specified positions.

##### Declaration

```
public static void CatmullRom(ref Vector2 value1, ref Vector2 value2, ref Vector2 value3, ref Vector2 value4, float amount, out Vector2 result)
```

##### Parameters

Type

Name

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

value1

The first position in the interpolation.

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

value2

The second position in the interpolation.

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

value3

The third position in the interpolation.

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

value4

The fourth position in the interpolation.

System.Single

amount

Weighting factor.

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

result

\[OutAttribute\] A vector that is the result of the Catmull-Rom interpolation.

#### Clamp(Vector2, Vector2, Vector2)

Restricts a value to be within a specified range.

##### Declaration

```
public static Vector2 Clamp(Vector2 value1, Vector2 min, Vector2 max)
```

##### Parameters

Type

Name

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

value1

The value to clamp.

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

min

The minimum value.

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

max

The maximum value.

##### Returns

Type

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

#### Clamp(ref Vector2, ref Vector2, ref Vector2, out Vector2)

Restricts a value to be within a specified range.

##### Declaration

```
public static void Clamp(ref Vector2 value1, ref Vector2 min, ref Vector2 max, out Vector2 result)
```

##### Parameters

Type

Name

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

value1

The value to clamp.

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

min

The minimum value.

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

max

The maximum value.

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

result

\[OutAttribute\] The clamped value.

#### ClampToSphere(Vector2, Single)

##### Declaration

```
public static Vector2 ClampToSphere(Vector2 vector, float radius)
```

##### Parameters

Type

Name

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

vector

System.Single

radius

##### Returns

Type

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

#### ClampToSphere(ref Vector2, Single)

##### Declaration

```
public static void ClampToSphere(ref Vector2 vector, float radius)
```

##### Parameters

Type

Name

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

vector

System.Single

radius

#### Distance(Vector2, Vector2)

Calculates the distance between two vectors.

##### Declaration

```
public static float Distance(Vector2 value1, Vector2 value2)
```

##### Parameters

Type

Name

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

value1

Source vector.

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

value2

Source vector.

##### Returns

Type

Description

System.Single

#### Distance(ref Vector2, ref Vector2, out Single)

Calculates the distance between two vectors.

##### Declaration

```
public static void Distance(ref Vector2 value1, ref Vector2 value2, out float result)
```
