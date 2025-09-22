#### SurfaceArea()

##### Declaration

```
public float SurfaceArea()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### ToString()

Returns a String that represents the current BoundingBox.

##### Declaration

```
public override string ToString()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

#### Transform(Matrix)

##### Declaration

```
public BoundingBox Transform(Matrix worldMatrix)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html) | worldMatrix |     |

##### Returns

| Type | Description |
| --- | --- |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) |     |

#### Transform(ref Matrix)

##### Declaration

```
public BoundingBox Transform(ref Matrix m)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html) | m   |     |

##### Returns

| Type | Description |
| --- | --- |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) |     |

#### Transform(ref Matrix, ref BoundingBox)

##### Declaration

```
public void Transform(ref Matrix m, ref BoundingBox bb)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html) | m   |     |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) | bb  |     |

#### Transform(MatrixD)

##### Declaration

```
public BoundingBoxD Transform(MatrixD worldMatrix)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) | worldMatrix |     |

##### Returns

| Type | Description |
| --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) |     |

#### Transform(ref MatrixD)

##### Declaration

```
public BoundingBoxD Transform(ref MatrixD m)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) | m   |     |

##### Returns

| Type | Description |
| --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) |     |

#### Transform(ref MatrixD, ref BoundingBoxD)

##### Declaration

```
public void Transform(ref MatrixD m, ref BoundingBoxD bb)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) | m   |     |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | bb  |     |

#### Translate(Matrix)

Translate

##### Declaration

```
public BoundingBox Translate(Matrix worldMatrix)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html) | worldMatrix |     |

##### Returns

| Type | Description |
| --- | --- |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) |     |

#### Translate(Vector3)

Translate

##### Declaration

```
public BoundingBox Translate(Vector3 vctTranlsation)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | vctTranlsation |     |

##### Returns

| Type | Description |
| --- | --- |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) |     |

#### Volume()

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

### Operators

#### Equality(BoundingBox, BoundingBox)

Determines whether two instances of BoundingBox are equal.

##### Declaration

```
public static bool operator ==(BoundingBox a, BoundingBox b)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) | a   | BoundingBox to compare. |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) | b   | BoundingBox to compare. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Inequality(BoundingBox, BoundingBox)

Determines whether two instances of BoundingBox are not equal.

##### Declaration

```
public static bool operator !=(BoundingBox a, BoundingBox b)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) | a   | The object to the left of the inequality operator. |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) | b   | The object to the right of the inequality operator. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |