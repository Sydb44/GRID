---
title: "Class SerializableBlockOrientation"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.SerializableBlockOrientation.html"
category: "Misc"
namespace: "VRage.Game"
class: "SerializableBlockOrientation"
---

# Class SerializableBlockOrientation | Space Engineers ModAPI

##### Inheritance

System.Object

SerializableBlockOrientation

###### **Namespace**: [VRage.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public sealed class SerializableBlockOrientation : ValueType
```

### Constructors

#### SerializableBlockOrientation(Base6Directions.Direction, Base6Directions.Direction)

##### Declaration

```
public SerializableBlockOrientation(Base6Directions.Direction forward, Base6Directions.Direction up)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Base6Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.Direction.html) | forward |     |
| [Base6Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.Direction.html) | up  |     |

#### SerializableBlockOrientation(ref Quaternion)

##### Declaration

```
public SerializableBlockOrientation(ref Quaternion q)
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
public static readonly SerializableBlockOrientation Identity
```

##### Field Value

| Type | Description |
| --- | --- |
| [SerializableBlockOrientation](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.SerializableBlockOrientation.html) |     |

#### Up

##### Declaration

```
public Base6Directions.Direction Up
```

##### Field Value

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

### Operators

#### Equality(SerializableBlockOrientation, SerializableBlockOrientation)

##### Declaration

```
public static bool operator ==(SerializableBlockOrientation a, SerializableBlockOrientation b)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [SerializableBlockOrientation](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.SerializableBlockOrientation.html) | a   |     |
| [SerializableBlockOrientation](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.SerializableBlockOrientation.html) | b   |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Implicit(SerializableBlockOrientation to MyBlockOrientation)

##### Declaration

```
public static implicit operator MyBlockOrientation(SerializableBlockOrientation v)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [SerializableBlockOrientation](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.SerializableBlockOrientation.html) | v   |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyBlockOrientation](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyBlockOrientation.html) |     |

#### Implicit(MyBlockOrientation to SerializableBlockOrientation)

##### Declaration

```
public static implicit operator SerializableBlockOrientation(MyBlockOrientation v)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyBlockOrientation](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyBlockOrientation.html) | v   |     |

##### Returns

| Type | Description |
| --- | --- |
| [SerializableBlockOrientation](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.SerializableBlockOrientation.html) |     |

#### Inequality(SerializableBlockOrientation, SerializableBlockOrientation)

##### Declaration

```
public static bool operator !=(SerializableBlockOrientation a, SerializableBlockOrientation b)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [SerializableBlockOrientation](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.SerializableBlockOrientation.html) | a   |     |
| [SerializableBlockOrientation](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.SerializableBlockOrientation.html) | b   |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |