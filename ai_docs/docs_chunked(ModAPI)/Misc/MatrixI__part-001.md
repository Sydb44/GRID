---
title: "Class MatrixI"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixI.html"
category: "Misc"
namespace: "VRageMath"
class: "MatrixI"
---

# Class MatrixI | Space Engineers ModAPI

##### Inheritance

System.Object

MatrixI

###### **Namespace**: [VRageMath](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.html)

###### **Assembly**: VRage.Math.dll

##### Syntax

```
public sealed class MatrixI : ValueType
```

### Constructors

#### MatrixI(Base6Directions.Direction, Base6Directions.Direction)

##### Declaration

```
public MatrixI(Base6Directions.Direction forward, Base6Directions.Direction up)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Base6Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.Direction.html) | forward |     |
| [Base6Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.Direction.html) | up  |     |

#### MatrixI(MyBlockOrientation)

##### Declaration

```
public MatrixI(MyBlockOrientation orientation)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyBlockOrientation](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyBlockOrientation.html) | orientation |     |

#### MatrixI(Vector3I, Base6Directions.Direction, Base6Directions.Direction)

##### Declaration

```
public MatrixI(Vector3I position, Base6Directions.Direction forward, Base6Directions.Direction up)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | position |     |
| [Base6Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.Direction.html) | forward |     |
| [Base6Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.Direction.html) | up  |     |

#### MatrixI(ref Vector3I, Base6Directions.Direction, Base6Directions.Direction)

##### Declaration

```
public MatrixI(ref Vector3I position, Base6Directions.Direction forward, Base6Directions.Direction up)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | position |     |
| [Base6Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.Direction.html) | forward |     |
| [Base6Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.Direction.html) | up  |     |

#### MatrixI(ref Vector3I, ref Vector3, ref Vector3)

##### Declaration

```
public MatrixI(ref Vector3I position, ref Vector3 forward, ref Vector3 up)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | position |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | forward |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | up  |     |

#### MatrixI(ref Vector3I, ref Vector3I, ref Vector3I)

##### Declaration

```
public MatrixI(ref Vector3I position, ref Vector3I forward, ref Vector3I up)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | position |     |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | forward |     |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | up  |     |

### Fields

#### Backward

##### Declaration

```
public Base6Directions.Direction Backward
```

##### Field Value

| Type | Description |
| --- | --- |
| [Base6Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.Direction.html) |     |

#### Right

##### Declaration

```
public Base6Directions.Direction Right
```

##### Field Value

| Type | Description |
| --- | --- |
| [Base6Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.Direction.html) |     |

#### Translation

##### Declaration

```
public Vector3I Translation
```

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) |     |

#### Up

##### Declaration

```
public Base6Directions.Direction Up
```

##### Field Value

| Type | Description |
| --- | --- |
| [Base6Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.Direction.html) |     |

### Properties

#### BackwardVector

##### Declaration

```
public Vector3I BackwardVector { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) |     |

#### Down

##### Declaration

```
public Base6Directions.Direction Down { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Base6Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.Direction.html) |     |

#### DownVector

##### Declaration

```
public Vector3I DownVector { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) |     |

#### Forward

##### Declaration

```
public Base6Directions.Direction Forward { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Base6Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.Direction.html) |     |
