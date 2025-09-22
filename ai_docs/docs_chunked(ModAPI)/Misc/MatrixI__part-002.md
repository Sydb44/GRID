#### Forward

##### Declaration

```
public Base6Directions.Direction Forward { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Base6Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.Direction.html) |     |

#### ForwardVector

##### Declaration

```
public Vector3I ForwardVector { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) |     |

#### Left

##### Declaration

```
public Base6Directions.Direction Left { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Base6Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.Direction.html) |     |

#### LeftVector

##### Declaration

```
public Vector3I LeftVector { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) |     |

#### RightVector

##### Declaration

```
public Vector3I RightVector { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) |     |

#### UpVector

##### Declaration

```
public Vector3I UpVector { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) |     |

### Methods

#### CreateRotation(Base6Directions.Direction, Base6Directions.Direction, Base6Directions.Direction, Base6Directions.Direction)

##### Declaration

```
public static MatrixI CreateRotation(Base6Directions.Direction oldA, Base6Directions.Direction oldB, Base6Directions.Direction newA, Base6Directions.Direction newB)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Base6Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.Direction.html) | oldA |     |
| [Base6Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.Direction.html) | oldB |     |
| [Base6Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.Direction.html) | newA |     |
| [Base6Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.Direction.html) | newB |     |

##### Returns

| Type | Description |
| --- | --- |
| [MatrixI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixI.html) |     |

#### GetBlockOrientation()

##### Declaration

```
public MyBlockOrientation GetBlockOrientation()
```

##### Returns

| Type | Description |
| --- | --- |
| [MyBlockOrientation](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyBlockOrientation.html) |     |

#### GetDirection(Base6Directions.Direction)

##### Declaration

```
public Base6Directions.Direction GetDirection(Base6Directions.Direction direction)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Base6Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.Direction.html) | direction |     |

##### Returns

| Type | Description |
| --- | --- |
| [Base6Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.Direction.html) |     |

#### GetFloatMatrix()

##### Declaration

```
public Matrix GetFloatMatrix()
```

##### Returns

| Type | Description |
| --- | --- |
| [Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html) |     |

#### Invert(ref MatrixI, out MatrixI)

##### Declaration

```
public static void Invert(ref MatrixI matrix, out MatrixI result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MatrixI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixI.html) | matrix |     |
| [MatrixI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixI.html) | result |     |

#### Multiply(ref MatrixI, ref MatrixI, out MatrixI)

##### Declaration

```
public static void Multiply(ref MatrixI leftMatrix, ref MatrixI rightMatrix, out MatrixI result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MatrixI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixI.html) | leftMatrix |     |
| [MatrixI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixI.html) | rightMatrix |     |
| [MatrixI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixI.html) | result |     |

#### SetDirection(Base6Directions.Direction, Base6Directions.Direction)

##### Declaration

```
public void SetDirection(Base6Directions.Direction dirToSet, Base6Directions.Direction newDirection)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Base6Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.Direction.html) | dirToSet |     |
| [Base6Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.Direction.html) | newDirection |     |

#### Transform(ref MyBlockOrientation, ref MatrixI)

##### Declaration

```
public static MyBlockOrientation Transform(ref MyBlockOrientation orientation, ref MatrixI transform)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyBlockOrientation](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyBlockOrientation.html) | orientation |     |
| [MatrixI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixI.html) | transform |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyBlockOrientation](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyBlockOrientation.html) |     |