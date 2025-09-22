
##### Declaration

```
public static Base6Directions.Direction GetLeft(Base6Directions.Direction up, Base6Directions.Direction forward)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Base6Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.Direction.html) | up  |     |
| [Base6Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.Direction.html) | forward |     |

##### Returns

| Type | Description |
| --- | --- |
| [Base6Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.Direction.html) |     |

#### GetOppositeDirection(Base6Directions.Direction)

##### Declaration

```
public static Base6Directions.Direction GetOppositeDirection(Base6Directions.Direction dir)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Base6Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.Direction.html) | dir |     |

##### Returns

| Type | Description |
| --- | --- |
| [Base6Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.Direction.html) |     |

#### GetOrientation(Base6Directions.Direction, Base6Directions.Direction)

##### Declaration

```
public static Quaternion GetOrientation(Base6Directions.Direction forward, Base6Directions.Direction up)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Base6Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.Direction.html) | forward |     |
| [Base6Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.Direction.html) | up  |     |

##### Returns

| Type | Description |
| --- | --- |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) |     |

#### GetPerpendicular(Base6Directions.Direction)

##### Declaration

```
public static Base6Directions.Direction GetPerpendicular(Base6Directions.Direction dir)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Base6Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.Direction.html) | dir |     |

##### Returns

| Type | Description |
| --- | --- |
| [Base6Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.Direction.html) |     |

#### GetUp(ref Matrix)

##### Declaration

```
public static Base6Directions.Direction GetUp(ref Matrix rotation)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html) | rotation |     |

##### Returns

| Type | Description |
| --- | --- |
| [Base6Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.Direction.html) |     |

#### GetUp(Quaternion)

##### Declaration

```
public static Base6Directions.Direction GetUp(Quaternion rot)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | rot |     |

##### Returns

| Type | Description |
| --- | --- |
| [Base6Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.Direction.html) |     |

#### GetUp(ref Quaternion)

##### Declaration

```
public static Base6Directions.Direction GetUp(ref Quaternion rot)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | rot |     |

##### Returns

| Type | Description |
| --- | --- |
| [Base6Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.Direction.html) |     |

#### GetVector(Int32)

##### Declaration

```
public static Vector3 GetVector(int direction)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | direction |     |

##### Returns

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### GetVector(Base6Directions.Direction)

##### Declaration

```
public static Vector3 GetVector(Base6Directions.Direction dir)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Base6Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.Direction.html) | dir |     |

##### Returns

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### GetVector(Base6Directions.Direction, out Vector3)

##### Declaration

```
public static void GetVector(Base6Directions.Direction dir, out Vector3 result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Base6Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.Direction.html) | dir |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | result |     |

#### IsBaseDirection(Vector3)

##### Declaration

```
public static bool IsBaseDirection(Vector3 vec)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | vec |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsBaseDirection(ref Vector3)

##### Declaration

```
public static bool IsBaseDirection(ref Vector3 vec)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | vec |     |
