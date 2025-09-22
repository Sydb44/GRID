Source vector.

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)

vector2

Source vector.

System.Single

result

\[OutAttribute\] The dot product of the two vectors.

#### [](#VRageMath_Vector4_Equals_System_Object_)Equals(Object)

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

#### [](#VRageMath_Vector4_Equals_VRageMath_Vector4_)Equals(Vector4)

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

#### [](#VRageMath_Vector4_GetHashCode)GetHashCode()

Gets the hash code of this object.

##### Declaration

```
public override int GetHashCode()
```

##### Returns

Type

Description

System.Int32

#### [](#VRageMath_Vector4_Hermite_VRageMath_Vector4_VRageMath_Vector4_VRageMath_Vector4_VRageMath_Vector4_System_Single_)Hermite(Vector4, Vector4, Vector4, Vector4, Single)

Performs a Hermite spline interpolation.

##### Declaration

```
public static Vector4 Hermite(Vector4 value1, Vector4 tangent1, Vector4 value2, Vector4 tangent2, float amount)
```

##### Parameters

Type

Name

Description

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)

value1

Source position vector.

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)

tangent1

Source tangent vector.

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)

value2

Source position vector.

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)

tangent2

Source tangent vector.

System.Single

amount

Weighting factor.

##### Returns

#### [](#VRageMath_Vector4_Hermite_VRageMath_Vector4__VRageMath_Vector4__VRageMath_Vector4__VRageMath_Vector4__System_Single_VRageMath_Vector4__)Hermite(ref Vector4, ref Vector4, ref Vector4, ref Vector4, Single, out Vector4)

Performs a Hermite spline interpolation.

##### Declaration

```
public static void Hermite(ref Vector4 value1, ref Vector4 tangent1, ref Vector4 value2, ref Vector4 tangent2, float amount, out Vector4 result)
```

##### Parameters

Type

Name

Description

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)

value1

Source position vector.

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)

tangent1

Source tangent vector.

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)

value2

Source position vector.

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)

tangent2

Source tangent vector.

System.Single

amount

Weighting factor.

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)

result

\[OutAttribute\] The result of the Hermite spline interpolation.

#### [](#VRageMath_Vector4_Length)Length()

Calculates the length of the vector.

##### Declaration

##### Returns

Type

Description

System.Single

#### [](#VRageMath_Vector4_LengthSquared)LengthSquared()

Calculates the length of the vector squared.

##### Declaration

```
public float LengthSquared()
```

##### Returns

Type

Description

System.Single

#### [](#VRageMath_Vector4_Lerp_VRageMath_Vector4_VRageMath_Vector4_System_Single_)Lerp(Vector4, Vector4, Single)

Performs a linear interpolation between two vectors.

##### Declaration

```
public static Vector4 Lerp(Vector4 value1, Vector4 value2, float amount)
```

##### Parameters

Type

Name

Description

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)

value1

Source vector.

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)

value2

Source vector.

System.Single

amount

Value between 0 and 1 indicating the weight of value2.

##### Returns

#### [](#VRageMath_Vector4_Lerp_VRageMath_Vector4__VRageMath_Vector4__System_Single_VRageMath_Vector4__)Lerp(ref Vector4, ref Vector4, Single, out Vector4)

Performs a linear interpolation between two vectors.

##### Declaration

```
public static void Lerp(ref Vector4 value1, ref Vector4 value2, float amount, out Vector4 result)
```

##### Parameters

Type

Name

Description

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)

value1

Source vector.

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)

value2

Source vector.

System.Single

amount

Value between 0 and 1 indicating the weight of value2.

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)

result

\[OutAttribute\] The result of the interpolation.

#### [](#VRageMath_Vector4_Max_VRageMath_Vector4_VRageMath_Vector4_)Max(Vector4, Vector4)

Returns a vector that contains the highest value from each matching pair of components.

##### Declaration

```
public static Vector4 Max(Vector4 value1, Vector4 value2)
```

##### Parameters

Type

Name

Description

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)

value1

Source vector.

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)

value2

Source vector.

##### Returns

#### [](#VRageMath_Vector4_Max_VRageMath_Vector4__VRageMath_Vector4__VRageMath_Vector4__)Max(ref Vector4, ref Vector4, out Vector4)

Returns a vector that contains the highest value from each matching pair of components.
