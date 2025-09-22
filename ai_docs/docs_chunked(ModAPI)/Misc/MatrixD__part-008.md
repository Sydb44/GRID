A Vector3 specifying the direction from which the light that will cast the shadow is coming.

[Plane](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Plane.html)

plane

The Plane onto which the new matrix should flatten geometry so as to cast a shadow.

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

result

\[OutAttribute\] A Matrix that can be used to flatten geometry onto the specified plane from the specified direction.

#### CreateTranslation(Double, Double, Double)

Creates a translation Matrix.

##### Declaration

```
public static MatrixD CreateTranslation(double xPosition, double yPosition, double zPosition)
```

##### Parameters

Type

Name

Description

System.Double

xPosition

Value to translate by on the x-axis.

System.Double

yPosition

Value to translate by on the y-axis.

System.Double

zPosition

Value to translate by on the z-axis.

##### Returns

Type

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

#### CreateTranslation(Double, Double, Double, out MatrixD)

Creates a translation Matrix.

##### Declaration

```
public static void CreateTranslation(double xPosition, double yPosition, double zPosition, out MatrixD result)
```

##### Parameters

Type

Name

Description

System.Double

xPosition

Value to translate by on the x-axis.

System.Double

yPosition

Value to translate by on the y-axis.

System.Double

zPosition

Value to translate by on the z-axis.

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

result

\[OutAttribute\] The created translation Matrix.

#### CreateTranslation(Vector3)

##### Declaration

```
public static MatrixD CreateTranslation(Vector3 position)
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

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

#### CreateTranslation(Vector3D)

Creates a translation Matrix.

##### Declaration

```
public static MatrixD CreateTranslation(Vector3D position)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

position

Amounts to translate by on the x, y, and z axes.

##### Returns

Type

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

#### CreateTranslation(ref Vector3D, out MatrixD)

Creates a translation Matrix.

##### Declaration

```
public static void CreateTranslation(ref Vector3D position, out MatrixD result)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

position

Amounts to translate by on the x, y, and z axes.

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

result

\[OutAttribute\] The created translation Matrix.

#### CreateWorld(Vector3D)

##### Declaration

```
public static MatrixD CreateWorld(Vector3D position)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

position

##### Returns

Type

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

#### CreateWorld(Vector3D, Vector3, Vector3)

##### Declaration

```
public static MatrixD CreateWorld(Vector3D position, Vector3 forward, Vector3 up)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

position

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

forward

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

up

##### Returns

Type

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

#### CreateWorld(Vector3D, Vector3D, Vector3D)

Creates a world matrix with the specified parameters.

##### Declaration

```
public static MatrixD CreateWorld(Vector3D position, Vector3D forward, Vector3D up)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

position

Position of the object. This value is used in translation operations.

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

forward

Forward direction of the object.

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

up

Upward direction of the object; usually \[0, 1, 0\].

##### Returns

Type

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

#### CreateWorld(ref Vector3D, ref Vector3D, ref Vector3D, out MatrixD)

Creates a world matrix with the specified parameters.

##### Declaration

```
public static void CreateWorld(ref Vector3D position, ref Vector3D forward, ref Vector3D up, out MatrixD result)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

position

Position of the object. This value is used in translation operations.

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

forward

Forward direction of the object.

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

up

Upward direction of the object; usually \[0, 1, 0\].

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

result

\[OutAttribute\] The created world matrix.

#### Determinant()

Calculates the determinant of the matrix.
