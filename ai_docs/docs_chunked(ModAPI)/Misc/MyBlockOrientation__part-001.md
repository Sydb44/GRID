---
title: "Class MyBlockOrientation"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyBlockOrientation.html"
category: "Misc"
namespace: "VRageMath"
class: "MyBlockOrientation"
---

# Class MyBlockOrientation | Space Engineers ModAPI

##### Inheritance

System.Object

MyBlockOrientation

###### **Namespace**: [VRageMath](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.html)

###### **Assembly**: VRage.Math.dll

##### Syntax

```
public sealed class MyBlockOrientation : ValueType
```

### Constructors

#### MyBlockOrientation(Base6Directions.Direction, Base6Directions.Direction)

##### Declaration

```
public MyBlockOrientation(Base6Directions.Direction forward, Base6Directions.Direction up)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Base6Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.Direction.html) | forward |     |
| [Base6Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.Direction.html) | up  |     |

#### MyBlockOrientation(ref Matrix)

##### Declaration

```
public MyBlockOrientation(ref Matrix m)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html) | m   |     |

#### MyBlockOrientation(ref Quaternion)

##### Declaration

```
public MyBlockOrientation(ref Quaternion q)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | q   |     |

### Fields

#### Forward

##### Declaration

```
public Base6Directions.Direction Forward
```

##### Field Value

| Type | Description |
| --- | --- |
| [Base6Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.Direction.html) |     |

#### Identity

##### Declaration

```
public static readonly MyBlockOrientation Identity
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyBlockOrientation](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyBlockOrientation.html) |     |

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

#### IsValid

##### Declaration

```
public bool IsValid { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Left

##### Declaration

```
public Base6Directions.Direction Left { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Base6Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.Direction.html) |     |

### Methods

#### Equals(Object)

##### Declaration

```
public override bool Equals(object obj)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | obj |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### GetHashCode()

##### Declaration

```
public override int GetHashCode()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### GetMatrix(out Matrix)

##### Declaration

```
public void GetMatrix(out Matrix result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html) | result |     |

#### GetQuaternion(out Quaternion)

##### Declaration

```
public void GetQuaternion(out Quaternion result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | result |     |

#### ToString()

##### Declaration

```
public override string ToString()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

#### TransformDirection(Base6Directions.Direction)

Returns the direction baseDirection will point to after transformation

##### Declaration

```
public Base6Directions.Direction TransformDirection(Base6Directions.Direction baseDirection)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Base6Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.Direction.html) | baseDirection |     |

##### Returns

| Type | Description |
| --- | --- |
| [Base6Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.Direction.html) |     |

#### TransformDirectionInverse(Base6Directions.Direction)

Returns the direction that this orientation transforms to baseDirection

##### Declaration

```
public Base6Directions.Direction TransformDirectionInverse(Base6Directions.Direction baseDirection)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Base6Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.Direction.html) | baseDirection |     |

##### Returns

| Type | Description |
| --- | --- |
| [Base6Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.Direction.html) |     |

### Operators

#### Equality(MyBlockOrientation, MyBlockOrientation)

##### Declaration

```
public static bool operator ==(MyBlockOrientation orientation1, MyBlockOrientation orientation2)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyBlockOrientation](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyBlockOrientation.html) | orientation1 |     |
| [MyBlockOrientation](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyBlockOrientation.html) | orientation2 |     |
