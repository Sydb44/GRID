##### Declaration

```
public Vector3D Col2 { get; }
```

##### Property Value

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### Down

Gets and sets the down vector of the Matrix.

##### Declaration

```
public Vector3D Down { get; set; }
```

##### Property Value

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### Forward

Gets and sets the forward vector of the Matrix.

##### Declaration

```
public Vector3D Forward { get; set; }
```

##### Property Value

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### Item\[Int32, Int32\]

##### Declaration

```
public double this[int row, int column] { get; set; }
```

##### Parameters

Type

Name

Description

System.Int32

row

System.Int32

column

##### Property Value

Type

Description

System.Double

#### Left

Gets and sets the left vector of the Matrix.

##### Declaration

```
public Vector3D Left { get; set; }
```

##### Property Value

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### Right

Gets and sets the right vector of the Matrix.

##### Declaration

```
public Vector3D Right { get; set; }
```

##### Property Value

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### Rotation

##### Declaration

```
public Matrix3x3 Rotation { get; }
```

##### Property Value

Type

Description

[Matrix3x3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix3x3.html)

#### Scale

##### Declaration

```
public Vector3D Scale { get; }
```

##### Property Value

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### Translation

Gets and sets the translation vector of the Matrix.

##### Declaration

```
public Vector3D Translation { get; set; }
```

##### Property Value

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### Up

Gets and sets the up vector of the Matrix.

##### Declaration

```
public Vector3D Up { get; set; }
```

##### Property Value

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

### Methods

#### Add(MatrixD, MatrixD)

Adds a matrix to another matrix.

##### Declaration

```
public static MatrixD Add(MatrixD matrix1, MatrixD matrix2)
```

##### Parameters

Type

Name

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

matrix1

Source matrix.

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

matrix2

Source matrix.

##### Returns

Type

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

#### Add(ref MatrixD, ref MatrixD, out MatrixD)

Adds a matrix to another matrix.

##### Declaration

```
public static void Add(ref MatrixD matrix1, ref MatrixD matrix2, out MatrixD result)
```

##### Parameters

Type

Name

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

matrix1

Source matrix.

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

matrix2

Source matrix.

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

result

\[OutAttribute\] Resulting matrix.

#### AlignRotationToAxes(ref MatrixD, ref MatrixD)

##### Declaration

```
public static MatrixD AlignRotationToAxes(ref MatrixD toAlign, ref MatrixD axisDefinitionMatrix)
```

##### Parameters

Type

Name

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

toAlign

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

axisDefinitionMatrix

##### Returns

Type

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

#### AssertIsValid(String)

##### Declaration

```
public void AssertIsValid(string message = null)
```

##### Parameters

Type

Name

Description

System.String

message

#### CreateBillboard(Vector3D, Vector3D, Vector3D, Nullable<Vector3D>)

Creates a spherical billboard that rotates around a specified object position.

##### Declaration

```
public static MatrixD CreateBillboard(Vector3D objectPosition, Vector3D cameraPosition, Vector3D cameraUpVector, Nullable<Vector3D> cameraForwardVector)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

objectPosition

Position of the object the billboard will rotate around.

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

cameraPosition

Position of the camera.

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

cameraUpVector

The up vector of the camera.

System.Nullable<[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\>

cameraForwardVector

Optional forward vector of the camera.

##### Returns

Type

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

#### CreateBillboard(ref Vector3D, ref Vector3D, ref Vector3D, Nullable<Vector3D>, out MatrixD)

Creates a spherical billboard that rotates around a specified object position.

##### Declaration

```
public static void CreateBillboard(ref Vector3D objectPosition, ref Vector3D cameraPosition, ref Vector3D cameraUpVector, Nullable<Vector3D> cameraForwardVector, out MatrixD result)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

objectPosition

Position of the object the billboard will rotate around.

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

cameraPosition

Position of the camera.

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

cameraUpVector

The up vector of the camera.

System.Nullable<[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\>

cameraForwardVector

Optional forward vector of the camera.

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

result

\[OutAttribute\] The created billboard matrix.
