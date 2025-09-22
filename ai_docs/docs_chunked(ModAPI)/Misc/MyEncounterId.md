---
title: "Class MyEncounterId"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyEncounterId.html"
category: "Misc"
namespace: "VRage.Game"
class: "MyEncounterId"
---

# Class MyEncounterId | Space Engineers ModAPI

##### Inheritance

System.Object

MyEncounterId

###### **Namespace**: [VRage.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public sealed class MyEncounterId : ValueType, IEquatable<MyEncounterId>
```

### Constructors

#### MyEncounterId(BoundingBoxD, Int32, Int32)

##### Declaration

```
public MyEncounterId(BoundingBoxD box, int seed, int encounterId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | box |     |
| System.Int32 | seed |     |
| System.Int32 | encounterId |     |

### Fields

#### BoundingBox

##### Declaration

```
public BoundingBoxD BoundingBox
```

##### Field Value

| Type | Description |
| --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) |     |

#### EncounterId

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### Seed

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

### Methods

#### Equals(Object)

##### Declaration

```
public override bool Equals(object o)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | o   |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Equals(MyEncounterId)

##### Declaration

```
public bool Equals(MyEncounterId other)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEncounterId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyEncounterId.html) | other |     |

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

#### ToString()

##### Declaration

```
public override string ToString()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

### Operators

#### Equality(MyEncounterId, MyEncounterId)

##### Declaration

```
public static bool operator ==(MyEncounterId x, MyEncounterId y)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEncounterId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyEncounterId.html) | x   |     |
| [MyEncounterId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyEncounterId.html) | y   |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Inequality(MyEncounterId, MyEncounterId)

##### Declaration

```
public static bool operator !=(MyEncounterId x, MyEncounterId y)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEncounterId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyEncounterId.html) | x   |     |
| [MyEncounterId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyEncounterId.html) | y   |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |