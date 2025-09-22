A Vector4 containing the 4D Cartesian coordinates of vertex 3 of the triangle.

System.Double

amount1

Barycentric coordinate b2, which expresses the weighting factor toward vertex 2 (specified in value2).

System.Double

amount2

Barycentric coordinate b3, which expresses the weighting factor toward vertex 3 (specified in value3).

##### Returns

#### [](#VRageMath_Vector4D_Barycentric_VRageMath_Vector4D__VRageMath_Vector4D__VRageMath_Vector4D__System_Double_System_Double_VRageMath_Vector4D__)Barycentric(ref Vector4D, ref Vector4D, ref Vector4D, Double, Double, out Vector4D)

Returns a Vector4 containing the 4D Cartesian coordinates of a point specified in Barycentric (areal) coordinates relative to a 4D triangle.

##### Declaration

```
public static void Barycentric(ref Vector4D value1, ref Vector4D value2, ref Vector4D value3, double amount1, double amount2, out Vector4D result)
```

##### Parameters

Type

Name

Description

[Vector4D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4D.html)

value1

A Vector4 containing the 4D Cartesian coordinates of vertex 1 of the triangle.

[Vector4D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4D.html)

value2

A Vector4 containing the 4D Cartesian coordinates of vertex 2 of the triangle.

[Vector4D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4D.html)

value3

A Vector4 containing the 4D Cartesian coordinates of vertex 3 of the triangle.

System.Double

amount1

Barycentric coordinate b2, which expresses the weighting factor toward vertex 2 (specified in value2).

System.Double

amount2

Barycentric coordinate b3, which expresses the weighting factor toward vertex 3 (specified in value3).

[Vector4D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4D.html)

result

\[OutAttribute\] The 4D Cartesian coordinates of the specified point are placed in this Vector4 on exit.

#### [](#VRageMath_Vector4D_CatmullRom_VRageMath_Vector4D_VRageMath_Vector4D_VRageMath_Vector4D_VRageMath_Vector4D_System_Double_)CatmullRom(Vector4D, Vector4D, Vector4D, Vector4D, Double)

Performs a Catmull-Rom interpolation using the specified positions.

##### Declaration

```
public static Vector4D CatmullRom(Vector4D value1, Vector4D value2, Vector4D value3, Vector4D value4, double amount)
```

##### Parameters

Type

Name

Description

[Vector4D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4D.html)

value1

The first position in the interpolation.

[Vector4D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4D.html)

value2

The second position in the interpolation.

[Vector4D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4D.html)

value3

The third position in the interpolation.

[Vector4D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4D.html)

value4

The fourth position in the interpolation.

System.Double

amount

Weighting factor.

##### Returns

#### [](#VRageMath_Vector4D_CatmullRom_VRageMath_Vector4D__VRageMath_Vector4D__VRageMath_Vector4D__VRageMath_Vector4D__System_Double_VRageMath_Vector4D__)CatmullRom(ref Vector4D, ref Vector4D, ref Vector4D, ref Vector4D, Double, out Vector4D)

Performs a Catmull-Rom interpolation using the specified positions.

##### Declaration

```
public static void CatmullRom(ref Vector4D value1, ref Vector4D value2, ref Vector4D value3, ref Vector4D value4, double amount, out Vector4D result)
```

##### Parameters

Type

Name

Description

[Vector4D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4D.html)

value1

The first position in the interpolation.

[Vector4D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4D.html)

value2

The second position in the interpolation.

[Vector4D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4D.html)

value3

The third position in the interpolation.

[Vector4D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4D.html)

value4

The fourth position in the interpolation.

System.Double

amount

Weighting factor.

[Vector4D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4D.html)

result

\[OutAttribute\] A vector that is the result of the Catmull-Rom interpolation.

#### [](#VRageMath_Vector4D_Clamp_VRageMath_Vector4D_VRageMath_Vector4D_VRageMath_Vector4D_)Clamp(Vector4D, Vector4D, Vector4D)

Restricts a value to be within a specified range.

##### Declaration

```
public static Vector4D Clamp(Vector4D value1, Vector4D min, Vector4D max)
```

##### Parameters

Type

Name

Description

[Vector4D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4D.html)

value1

The value to clamp.

[Vector4D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4D.html)

min

The minimum value.

[Vector4D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4D.html)

max

The maximum value.

##### Returns

#### [](#VRageMath_Vector4D_Clamp_VRageMath_Vector4D__VRageMath_Vector4D__VRageMath_Vector4D__VRageMath_Vector4D__)Clamp(ref Vector4D, ref Vector4D, ref Vector4D, out Vector4D)

Restricts a value to be within a specified range.

##### Declaration

```
public static void Clamp(ref Vector4D value1, ref Vector4D min, ref Vector4D max, out Vector4D result)
```

##### Parameters

Type

Name

Description

[Vector4D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4D.html)

value1

The value to clamp.

[Vector4D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4D.html)

min

The minimum value.

[Vector4D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4D.html)

max

The maximum value.

[Vector4D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4D.html)

result

\[OutAttribute\] The clamped value.
