##### Declaration

```
public Vector3 Col2 { get; }
```

##### Property Value

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### Down

Gets and sets the down vector of the Matrix.

##### Declaration

```
public Vector3 Down { get; set; }
```

##### Property Value

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### Forward

Gets and sets the forward vector of the Matrix.

##### Declaration

```
public Vector3 Forward { get; set; }
```

##### Property Value

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### Item\[Int32, Int32\]

##### Declaration

```
public float this[int row, int column] { get; set; }
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

System.Single

#### Left

Gets and sets the left vector of the Matrix.

##### Declaration

```
public Vector3 Left { get; set; }
```

##### Property Value

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### Right

Gets and sets the right vector of the Matrix.

##### Declaration

```
public Vector3 Right { get; set; }
```

##### Property Value

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### Scale

##### Declaration

```
public Vector3 Scale { get; }
```

##### Property Value

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### Translation

Gets and sets the translation vector of the Matrix.

##### Declaration

```
public Vector3 Translation { get; set; }
```

##### Property Value

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### Up

Gets and sets the up vector of the Matrix.

##### Declaration

```
public Vector3 Up { get; set; }
```

##### Property Value

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

### Methods

#### Add(Matrix, Matrix)

Adds a matrix to another matrix.

##### Declaration

```
public static Matrix Add(Matrix matrix1, Matrix matrix2)
```

##### Parameters

Type

Name

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

matrix1

Source matrix.

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

matrix2

Source matrix.

##### Returns

Type

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

#### Add(ref Matrix, ref Matrix, out Matrix)

Adds a matrix to another matrix.

##### Declaration

```
public static void Add(ref Matrix matrix1, ref Matrix matrix2, out Matrix result)
```

##### Parameters

Type

Name

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

matrix1

Source matrix.

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

matrix2

Source matrix.

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

result

\[OutAttribute\] Resulting matrix.

#### AlignRotationToAxes(ref Matrix, ref Matrix)

##### Declaration

```
public static Matrix AlignRotationToAxes(ref Matrix toAlign, ref Matrix axisDefinitionMatrix)
```

##### Parameters

Type

Name

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

toAlign

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

axisDefinitionMatrix

##### Returns

Type

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

#### AssertIsValid()

##### Declaration

```
public void AssertIsValid()
```

#### CreateBillboard(Vector3, Vector3, Vector3, Nullable<Vector3>)

Creates a spherical billboard that rotates around a specified object position.

##### Declaration

```
public static Matrix CreateBillboard(Vector3 objectPosition, Vector3 cameraPosition, Vector3 cameraUpVector, Nullable<Vector3> cameraForwardVector)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

objectPosition

Position of the object the billboard will rotate around.

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

cameraPosition

Position of the camera.

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

cameraUpVector

The up vector of the camera.

System.Nullable<[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)\>

cameraForwardVector

Optional forward vector of the camera.

##### Returns

Type

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

#### CreateBillboard(ref Vector3, ref Vector3, ref Vector3, Nullable<Vector3>, out Matrix)

Creates a spherical billboard that rotates around a specified object position.

##### Declaration

```
public static void CreateBillboard(ref Vector3 objectPosition, ref Vector3 cameraPosition, ref Vector3 cameraUpVector, Nullable<Vector3> cameraForwardVector, out Matrix result)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

objectPosition

Position of the object the billboard will rotate around.

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

cameraPosition

Position of the camera.

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

cameraUpVector

The up vector of the camera.

System.Nullable<[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)\>

cameraForwardVector

Optional forward vector of the camera.

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

result

\[OutAttribute\] The created billboard matrix.
