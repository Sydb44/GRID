---
title: "Class MyContractEscort"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Contracts.MyContractEscort.html"
category: "Misc"
namespace: "Sandbox.ModAPI.Contracts"
class: "MyContractEscort"
---

# Class MyContractEscort | Space Engineers ModAPI

##### Inheritance

System.Object

MyContractEscort

##### Implements

###### **Namespace**: [Sandbox.ModAPI.Contracts](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Contracts.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public class MyContractEscort : Object, IMyContractEscort, IMyContract
```

### Constructors

#### MyContractEscort(Int64, Int32, Int32, Int32, Vector3D, Vector3D, Int64)

##### Declaration

```
public MyContractEscort(long startBlockId, int moneyReward, int collateral, int duration, Vector3D start, Vector3D end, long ownerIdentityId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | startBlockId |     |
| System.Int32 | moneyReward |     |
| System.Int32 | collateral |     |
| System.Int32 | duration |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | start |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | end |     |
| System.Int64 | ownerIdentityId |     |

### Properties

#### Collateral

##### Declaration

```
public int Collateral { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### Duration

##### Declaration

```
public int Duration { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### End

##### Declaration

```
public Vector3D End { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

#### MoneyReward

##### Declaration

```
public int MoneyReward { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### OnContractAcquired

##### Declaration

```
public Action<long> OnContractAcquired { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Action<System.Int64\> |     |

#### OnContractFailed

##### Declaration

```
public Action OnContractFailed { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Action |     |

#### OnContractSucceeded

##### Declaration

```
public Action OnContractSucceeded { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Action |     |

#### OwnerIdentityId

##### Declaration

```
public long OwnerIdentityId { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### Start

##### Declaration

```
public Vector3D Start { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

#### StartBlockId

##### Declaration

```
public long StartBlockId { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

### Implements