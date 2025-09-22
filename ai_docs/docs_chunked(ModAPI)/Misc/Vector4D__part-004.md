Description

System.Double

#### [](#VRageMath_Vector4D_Dot_VRageMath_Vector4__VRageMath_Vector4__System_Double__)Dot(ref Vector4, ref Vector4, out Double)

Calculates the dot product of two vectors.

##### Declaration

```
public static void Dot(ref Vector4 vector1, ref Vector4 vector2, out double result)
```

##### Parameters

Type

Name

Description

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)

vector1

Source vector.

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)

vector2

Source vector.

System.Double

result

\[OutAttribute\] The dot product of the two vectors.

#### [](#VRageMath_Vector4D_Equals_System_Object_)Equals(Object)

Returns a value that indicates whether the current instance is equal to a specified object.

##### Declaration

```
public override bool Equals(object obj)
```

##### Parameters

Type

Name

Description

System.Object

obj

Object with which to make the comparison.

##### Returns

Type

Description

System.Boolean

#### [](#VRageMath_Vector4D_Equals_VRageMath_Vector4_)Equals(Vector4)

Determines whether the specified Object is equal to the Vector4.

##### Declaration

```
public bool Equals(Vector4 other)
```

##### Parameters

Type

Name

Description

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)

other

The Vector4 to compare with the current Vector4.

##### Returns

Type

Description

System.Boolean

#### [](#VRageMath_Vector4D_GetHashCode)GetHashCode()

Gets the hash code of this object.

##### Declaration

```
public override int GetHashCode()
```

##### Returns

Type

Description

System.Int32

#### [](#VRageMath_Vector4D_Hermite_VRageMath_Vector4D_VRageMath_Vector4D_VRageMath_Vector4D_VRageMath_Vector4D_System_Double_)Hermite(Vector4D, Vector4D, Vector4D, Vector4D, Double)

Performs a Hermite spline interpolation.

##### Declaration

```
public static Vector4D Hermite(Vector4D value1, Vector4D tangent1, Vector4D value2, Vector4D tangent2, double amount)
```

##### Parameters

Type

Name

Description

[Vector4D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4D.html)

value1

Source position vector.

[Vector4D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4D.html)

tangent1

Source tangent vector.

[Vector4D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4D.html)

value2

Source position vector.

[Vector4D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4D.html)

tangent2

Source tangent vector.

System.Double

amount

Weighting factor.

##### Returns

#### [](#VRageMath_Vector4D_Hermite_VRageMath_Vector4D__VRageMath_Vector4D__VRageMath_Vector4D__VRageMath_Vector4D__System_Double_VRageMath_Vector4D__)Hermite(ref Vector4D, ref Vector4D, ref Vector4D, ref Vector4D, Double, out Vector4D)

Performs a Hermite spline interpolation.

##### Declaration

```
public static void Hermite(ref Vector4D value1, ref Vector4D tangent1, ref Vector4D value2, ref Vector4D tangent2, double amount, out Vector4D result)
```

##### Parameters

Type

Name

Description

[Vector4D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4D.html)

value1

Source position vector.

[Vector4D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4D.html)

tangent1

Source tangent vector.

[Vector4D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4D.html)

value2

Source position vector.

[Vector4D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4D.html)

tangent2

Source tangent vector.

System.Double

amount

Weighting factor.

[Vector4D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4D.html)

result

\[OutAttribute\] The result of the Hermite spline interpolation.

#### [](#VRageMath_Vector4D_Length)Length()

Calculates the length of the vector.

##### Declaration

##### Returns

Type

Description

System.Double

#### [](#VRageMath_Vector4D_LengthSquared)LengthSquared()

Calculates the length of the vector squared.

##### Declaration

```
public double LengthSquared()
```

##### Returns

Type

Description

System.Double

#### [](#VRageMath_Vector4D_Lerp_VRageMath_Vector4D_VRageMath_Vector4D_System_Double_)Lerp(Vector4D, Vector4D, Double)

Performs a linear interpolation between two vectors.

##### Declaration

```
public static Vector4D Lerp(Vector4D value1, Vector4D value2, double amount)
```

##### Parameters

Type

Name

Description

[Vector4D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4D.html)

value1

Source vector.

[Vector4D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4D.html)

value2

Source vector.

System.Double

amount

Value between 0 and 1 indicating the weight of value2.

##### Returns

#### [](#VRageMath_Vector4D_Lerp_VRageMath_Vector4D__VRageMath_Vector4D__System_Double_VRageMath_Vector4D__)Lerp(ref Vector4D, ref Vector4D, Double, out Vector4D)

Performs a linear interpolation between two vectors.

##### Declaration

```
public static void Lerp(ref Vector4D value1, ref Vector4D value2, double amount, out Vector4D result)
```

##### Parameters

Type

Name

Description

[Vector4D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4D.html)

value1

Source vector.

[Vector4D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4D.html)

value2

Source vector.

System.Double

amount

Value between 0 and 1 indicating the weight of value2.

[Vector4D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4D.html)

result

\[OutAttribute\] The result of the interpolation.

#### [](#VRageMath_Vector4D_Max_VRageMath_Vector4_VRageMath_Vector4_)Max(Vector4, Vector4)

Returns a vector that contains the highest value from each matching pair of components.
