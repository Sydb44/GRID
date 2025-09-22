---
title: "Class MyObjectBuilder\\_Identity"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_Identity.html"
category: "Misc"
namespace: "VRage.Game"
class: "MyObjectBuilder_Identity"
---

# Class MyObjectBuilder\_Identity | Space Engineers ModAPI

##### Inheritance

System.Object

MyObjectBuilder\_Identity

##### Inherited Members

###### **Namespace**: [VRage.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
[MyObjectBuilderDefinition]
public class MyObjectBuilder_Identity : MyObjectBuilder_Base
```

### Constructors

#### MyObjectBuilder\_Identity()

##### Declaration

```
public MyObjectBuilder_Identity()
```

### Fields

#### ActiveContracts

##### Declaration

```
public List<long> ActiveContracts
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<System.Int64\> |     |

#### BlockLimitModifier

##### Declaration

```
public int BlockLimitModifier
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### CharacterEntityId

##### Declaration

```
public long CharacterEntityId
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### ColorMask

##### Declaration

```
public Nullable<SerializableVector3> ColorMask
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<VRage.SerializableVector3\> |     |

#### DisplayName

##### Declaration

```
[Serialize]
public string DisplayName
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### IdentityId

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### IsGlobalEncounterSpawner

##### Declaration

```
public bool IsGlobalEncounterSpawner
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### LastDeathPosition

##### Declaration

```
[NoSerialize]
public Nullable<Vector3D> LastDeathPosition
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\> |     |

#### LastLoginTime

##### Declaration

```
public DateTime LastLoginTime
```

##### Field Value

| Type | Description |
| --- | --- |
| System.DateTime |     |

#### LastLogoutTime

##### Declaration

```
public DateTime LastLogoutTime
```

##### Field Value

| Type | Description |
| --- | --- |
| System.DateTime |     |

#### Model

##### Declaration

```
[Serialize]
public string Model
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### RespawnShips

##### Declaration

```
public List<long> RespawnShips
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<System.Int64\> |     |

#### SavedCharacters

##### Declaration

```
public HashSet<long> SavedCharacters
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.HashSet<System.Int64\> |     |

#### TransferedPCUDelta

##### Declaration

```
public int TransferedPCUDelta
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

### Properties

#### PlayerId

##### Declaration

```
[NoSerialize]
public long PlayerId { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

### Methods

#### ShouldSerializeColorMask()

##### Declaration

```
public bool ShouldSerializeColorMask()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ShouldSerializePlayerId()

##### Declaration

```
public bool ShouldSerializePlayerId()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Extension Methods