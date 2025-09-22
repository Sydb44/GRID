Description

System.Single

scale

Value to scale by.

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

result

\[OutAttribute\] The created scaling Matrix.

#### CreateScale(Vector3)

Creates a scaling Matrix.

##### Declaration

```
public static Matrix CreateScale(Vector3 scales)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

scales

Amounts to scale by on the x, y, and z axes.

##### Returns

Type

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

#### CreateScale(ref Vector3, out Matrix)

Creates a scaling Matrix.

##### Declaration

```
public static void CreateScale(ref Vector3 scales, out Matrix result)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

scales

Amounts to scale by on the x, y, and z axes.

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

result

\[OutAttribute\] The created scaling Matrix.

#### CreateShadow(Vector3, Plane)

Creates a Matrix that flattens geometry into a specified Plane as if casting a shadow from a specified light source.

##### Declaration

```
public static Matrix CreateShadow(Vector3 lightDirection, Plane plane)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

lightDirection

A Vector3 specifying the direction from which the light that will cast the shadow is coming.

[Plane](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Plane.html)

plane

The Plane onto which the new matrix should flatten geometry so as to cast a shadow.

##### Returns

Type

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

#### CreateShadow(ref Vector3, ref Plane, out Matrix)

Fills in a Matrix to flatten geometry into a specified Plane as if casting a shadow from a specified light source.

##### Declaration

```
public static void CreateShadow(ref Vector3 lightDirection, ref Plane plane, out Matrix result)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

lightDirection

A Vector3 specifying the direction from which the light that will cast the shadow is coming.

[Plane](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Plane.html)

plane

The Plane onto which the new matrix should flatten geometry so as to cast a shadow.

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

result

\[OutAttribute\] A Matrix that can be used to flatten geometry onto the specified plane from the specified direction.

#### CreateTranslation(Single, Single, Single)

Creates a translation Matrix.

##### Declaration

```
public static Matrix CreateTranslation(float xPosition, float yPosition, float zPosition)
```

##### Parameters

Type

Name

Description

System.Single

xPosition

Value to translate by on the x-axis.

System.Single

yPosition

Value to translate by on the y-axis.

System.Single

zPosition

Value to translate by on the z-axis.

##### Returns

Type

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

#### CreateTranslation(Single, Single, Single, out Matrix)

Creates a translation Matrix.

##### Declaration

```
public static void CreateTranslation(float xPosition, float yPosition, float zPosition, out Matrix result)
```

##### Parameters

Type

Name

Description

System.Single

xPosition

Value to translate by on the x-axis.

System.Single

yPosition

Value to translate by on the y-axis.

System.Single

zPosition

Value to translate by on the z-axis.

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

result

\[OutAttribute\] The created translation Matrix.

#### CreateTranslation(Vector3)

Creates a translation Matrix.

##### Declaration

```
public static Matrix CreateTranslation(Vector3 position)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

position

Amounts to translate by on the x, y, and z axes.

##### Returns

Type

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

#### CreateTranslation(ref Vector3, out Matrix)

Creates a translation Matrix.

##### Declaration

```
public static void CreateTranslation(ref Vector3 position, out Matrix result)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

position

Amounts to translate by on the x, y, and z axes.

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

result

\[OutAttribute\] The created translation Matrix.

#### CreateWorld(Vector3)

##### Declaration

```
public static Matrix CreateWorld(Vector3 position)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

position

##### Returns

Type

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

#### CreateWorld(Vector3, Vector3, Vector3)

Creates a world matrix with the specified parameters.

##### Declaration

```
public static Matrix CreateWorld(Vector3 position, Vector3 forward, Vector3 up)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

position

Position of the object. This value is used in translation operations.

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

forward

Forward direction of the object.

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

up

Upward direction of the object; usually \[0, 1, 0\].
