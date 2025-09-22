A Vector4 containing the 4D Cartesian coordinates of vertex 3 of the triangle.

System.Single

amount1

Barycentric coordinate b2, which expresses the weighting factor toward vertex 2 (specified in value2).

System.Single

amount2

Barycentric coordinate b3, which expresses the weighting factor toward vertex 3 (specified in value3).

##### Returns

#### [](#VRageMath_Vector4_Barycentric_VRageMath_Vector4__VRageMath_Vector4__VRageMath_Vector4__System_Single_System_Single_VRageMath_Vector4__)Barycentric(ref Vector4, ref Vector4, ref Vector4, Single, Single, out Vector4)

Returns a Vector4 containing the 4D Cartesian coordinates of a point specified in Barycentric (areal) coordinates relative to a 4D triangle.

##### Declaration

```
public static void Barycentric(ref Vector4 value1, ref Vector4 value2, ref Vector4 value3, float amount1, float amount2, out Vector4 result)
```

##### Parameters

Type

Name

Description

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)

value1

A Vector4 containing the 4D Cartesian coordinates of vertex 1 of the triangle.

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)

value2

A Vector4 containing the 4D Cartesian coordinates of vertex 2 of the triangle.

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)

value3

A Vector4 containing the 4D Cartesian coordinates of vertex 3 of the triangle.

System.Single

amount1

Barycentric coordinate b2, which expresses the weighting factor toward vertex 2 (specified in value2).

System.Single

amount2

Barycentric coordinate b3, which expresses the weighting factor toward vertex 3 (specified in value3).

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)

result

\[OutAttribute\] The 4D Cartesian coordinates of the specified point are placed in this Vector4 on exit.

#### [](#VRageMath_Vector4_CatmullRom_VRageMath_Vector4_VRageMath_Vector4_VRageMath_Vector4_VRageMath_Vector4_System_Single_)CatmullRom(Vector4, Vector4, Vector4, Vector4, Single)

Performs a Catmull-Rom interpolation using the specified positions.

##### Declaration

```
public static Vector4 CatmullRom(Vector4 value1, Vector4 value2, Vector4 value3, Vector4 value4, float amount)
```

##### Parameters

Type

Name

Description

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)

value1

The first position in the interpolation.

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)

value2

The second position in the interpolation.

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)

value3

The third position in the interpolation.

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)

value4

The fourth position in the interpolation.

System.Single

amount

Weighting factor.

##### Returns

#### [](#VRageMath_Vector4_CatmullRom_VRageMath_Vector4__VRageMath_Vector4__VRageMath_Vector4__VRageMath_Vector4__System_Single_VRageMath_Vector4__)CatmullRom(ref Vector4, ref Vector4, ref Vector4, ref Vector4, Single, out Vector4)

Performs a Catmull-Rom interpolation using the specified positions.

##### Declaration

```
public static void CatmullRom(ref Vector4 value1, ref Vector4 value2, ref Vector4 value3, ref Vector4 value4, float amount, out Vector4 result)
```

##### Parameters

Type

Name

Description

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)

value1

The first position in the interpolation.

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)

value2

The second position in the interpolation.

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)

value3

The third position in the interpolation.

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)

value4

The fourth position in the interpolation.

System.Single

amount

Weighting factor.

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)

result

\[OutAttribute\] A vector that is the result of the Catmull-Rom interpolation.

#### [](#VRageMath_Vector4_Clamp_VRageMath_Vector4_VRageMath_Vector4_VRageMath_Vector4_)Clamp(Vector4, Vector4, Vector4)

Restricts a value to be within a specified range.

##### Declaration

```
public static Vector4 Clamp(Vector4 value1, Vector4 min, Vector4 max)
```

##### Parameters

Type

Name

Description

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)

value1

The value to clamp.

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)

min

The minimum value.

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)

max

The maximum value.

##### Returns

#### [](#VRageMath_Vector4_Clamp_VRageMath_Vector4__VRageMath_Vector4__VRageMath_Vector4__VRageMath_Vector4__)Clamp(ref Vector4, ref Vector4, ref Vector4, out Vector4)

Restricts a value to be within a specified range.

##### Declaration

```
public static void Clamp(ref Vector4 value1, ref Vector4 min, ref Vector4 max, out Vector4 result)
```

##### Parameters

Type

Name

Description

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)

value1

The value to clamp.

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)

min

The minimum value.

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)

max

The maximum value.

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)

result

\[OutAttribute\] The clamped value.

#### [](#VRageMath_Vector4_Distance_VRageMath_Vector4_VRageMath_Vector4_)Distance(Vector4, Vector4)

Calculates the distance between two vectors.
