---
title: "Class Base27Directions"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base27Directions.html"
category: "Misc"
namespace: "VRageMath"
class: "Base27Directions"
---

# Class Base27Directions | Space Engineers ModAPI

Base 26 directions and Vector3.Zero Each component is only 0,-1 or 1;

##### Inheritance

System.Object

Base27Directions

###### **Namespace**: [VRageMath](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.html)

###### **Assembly**: VRage.Math.dll

##### Syntax

```
public class Base27Directions : Object
```

### Constructors

#### Base27Directions()

##### Declaration

```
public Base27Directions()
```

### Fields

#### Directions

##### Declaration

```
public static readonly Vector3[] Directions
```

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)\[\] |     |

#### DirectionsInt

##### Declaration

```
public static readonly Vector3I[] DirectionsInt
```

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)\[\] |     |

### Methods

#### GetDirection(Vector3)

Vector must be normalized, allowed values for components are: 0, 1, -1, 0.707, -0.707, 0.577, -0.577

##### Declaration

```
public static Base27Directions.Direction GetDirection(Vector3 vec)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | vec |     |

##### Returns

| Type | Description |
| --- | --- |
| [Base27Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base27Directions.Direction.html) |     |

#### GetDirection(ref Vector3)

##### Declaration

```
public static Base27Directions.Direction GetDirection(ref Vector3 vec)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | vec |     |

##### Returns

| Type | Description |
| --- | --- |
| [Base27Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base27Directions.Direction.html) |     |

#### GetDirection(Vector3I)

##### Declaration

```
public static Base27Directions.Direction GetDirection(Vector3I vec)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | vec |     |

##### Returns

| Type | Description |
| --- | --- |
| [Base27Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base27Directions.Direction.html) |     |

#### GetDirection(ref Vector3I)

##### Declaration

```
public static Base27Directions.Direction GetDirection(ref Vector3I vec)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | vec |     |

##### Returns

| Type | Description |
| --- | --- |
| [Base27Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base27Directions.Direction.html) |     |

#### GetForward(ref Quaternion)

##### Declaration

```
public static Base27Directions.Direction GetForward(ref Quaternion rot)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | rot |     |

##### Returns

| Type | Description |
| --- | --- |
| [Base27Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base27Directions.Direction.html) |     |

#### GetUp(ref Quaternion)

##### Declaration

```
public static Base27Directions.Direction GetUp(ref Quaternion rot)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | rot |     |

##### Returns

| Type | Description |
| --- | --- |
| [Base27Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base27Directions.Direction.html) |     |

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

#### GetVector(Base27Directions.Direction)

##### Declaration

```
public static Vector3 GetVector(Base27Directions.Direction dir)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Base27Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base27Directions.Direction.html) | dir |     |

##### Returns

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### GetVectorInt(Int32)

##### Declaration

```
public static Vector3I GetVectorInt(int direction)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | direction |     |

##### Returns

| Type | Description |
| --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) |     |

#### GetVectorInt(Base27Directions.Direction)

##### Declaration

```
public static Vector3I GetVectorInt(Base27Directions.Direction dir)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Base27Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base27Directions.Direction.html) | dir |     |

##### Returns

| Type | Description |
| --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) |     |
