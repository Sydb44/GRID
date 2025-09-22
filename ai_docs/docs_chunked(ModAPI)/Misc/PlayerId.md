---
title: "Class MyObjectBuilder\\_Checkpoint.PlayerId"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_Checkpoint.PlayerId.html"
category: "Misc"
namespace: "VRage.Game.MyObjectBuilder_Checkpoint"
class: "PlayerId"
---

# Class MyObjectBuilder\_Checkpoint.PlayerId | Space Engineers ModAPI

##### Inheritance

System.Object

MyObjectBuilder\_Checkpoint.PlayerId

###### **Namespace**: [VRage.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public sealed class PlayerId : ValueType, IEquatable<MyObjectBuilder_Checkpoint.PlayerId>
```

### Constructors

#### PlayerId(UInt64, Int32)

##### Declaration

```
public PlayerId(ulong steamId, int serialId = 0)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.UInt64 | steamId |     |
| System.Int32 | serialId |     |

### Fields

#### ClientId

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.UInt64 |     |

#### HashedId

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.UInt64 |     |

#### SerialId

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

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

#### Equals(MyObjectBuilder\_Checkpoint.PlayerId)

##### Declaration

```
public bool Equals(MyObjectBuilder_Checkpoint.PlayerId other)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_Checkpoint.PlayerId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_Checkpoint.PlayerId.html) | other |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### GetClientId()

##### Declaration

```
public ulong GetClientId()
```

##### Returns

| Type | Description |
| --- | --- |
| System.UInt64 |     |

#### GetHashCode()

##### Declaration

```
public override int GetHashCode()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### GetHashedId()

##### Declaration

```
public ulong GetHashedId()
```

##### Returns

| Type | Description |
| --- | --- |
| System.UInt64 |     |