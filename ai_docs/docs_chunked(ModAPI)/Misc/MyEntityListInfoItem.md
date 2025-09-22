---
title: "Class MyEntityList.MyEntityListInfoItem"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntityList.MyEntityListInfoItem.html"
category: "Misc"
namespace: "Sandbox.Game.Entities.MyEntityList"
class: "MyEntityListInfoItem"
---

# Class MyEntityList.MyEntityListInfoItem | Space Engineers ModAPI

##### Inheritance

System.Object

MyEntityList.MyEntityListInfoItem

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public class MyEntityListInfoItem : Object
```

### Constructors

#### MyEntityListInfoItem()

##### Declaration

```
public MyEntityListInfoItem()
```

#### MyEntityListInfoItem(String, Int64, Int32, Nullable<Int32>, Single, Vector3D, Single, Single, String, Int64, Single, Nullable<Single>, MyUpdateTiersPlayerPresence, MyUpdateTiersGridPresence, Nullable<Boolean>, Boolean)

##### Declaration

```
public MyEntityListInfoItem(string displayName, long entityId, int blockCount, Nullable<int> pcu, float mass, Vector3D position, float speed, float distanceFromPlayers, string ownerName, long owner, float ownerLogin, Nullable<float> ownerLogout, MyUpdateTiersPlayerPresence playerPresenceTier, MyUpdateTiersGridPresence gridPresenceTier, Nullable<bool> isReplicated = null, bool isGrid = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | displayName |     |
| System.Int64 | entityId |     |
| System.Int32 | blockCount |     |
| System.Nullable<System.Int32\> | pcu |     |
| System.Single | mass |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | position |     |
| System.Single | speed |     |
| System.Single | distanceFromPlayers |     |
| System.String | ownerName |     |
| System.Int64 | owner |     |
| System.Single | ownerLogin |     |
| System.Nullable<System.Single\> | ownerLogout |     |
| [MyUpdateTiersPlayerPresence](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyUpdateTiersPlayerPresence.html) | playerPresenceTier |     |
| [MyUpdateTiersGridPresence](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyUpdateTiersGridPresence.html) | gridPresenceTier |     |
| System.Nullable<System.Boolean\> | isReplicated |     |
| System.Boolean | isGrid |     |

### Fields

#### BlockCount

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### DisplayName

##### Declaration

```
public string DisplayName
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### DistanceFromPlayers

##### Declaration

```
public float DistanceFromPlayers
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### EntityId

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### GridPresenceTier

##### Declaration

```
public MyUpdateTiersGridPresence GridPresenceTier
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyUpdateTiersGridPresence](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyUpdateTiersGridPresence.html) |     |

#### IsGrid

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsReplicated

##### Declaration

```
public Nullable<bool> IsReplicated
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<System.Boolean\> |     |

#### Mass

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Owner

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### OwnerLoginTime

##### Declaration

```
public float OwnerLoginTime
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### OwnerLogoutTime

##### Declaration

```
public Nullable<float> OwnerLogoutTime
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<System.Single\> |     |

#### OwnerName

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### PCU

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<System.Int32\> |     |

#### PlayerPresenceTier

##### Declaration

```
public MyUpdateTiersPlayerPresence PlayerPresenceTier
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyUpdateTiersPlayerPresence](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyUpdateTiersPlayerPresence.html) |     |

#### Position

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

#### Speed

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

### Methods

#### Add(ref MyEntityList.MyEntityListInfoItem)

##### Declaration

```
public void Add(ref MyEntityList.MyEntityListInfoItem item)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEntityList.MyEntityListInfoItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntityList.MyEntityListInfoItem.html) | item |     |