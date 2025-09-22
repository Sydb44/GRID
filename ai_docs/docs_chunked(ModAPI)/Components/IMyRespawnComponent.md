---
title: "Interface IMyRespawnComponent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyRespawnComponent.html"
category: "Components"
namespace: "Sandbox.ModAPI"
class: "IMyRespawnComponent"
---

# Interface IMyRespawnComponent | Space Engineers ModAPI

###### **Namespace**: [Sandbox.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyRespawnComponent : IMyComponentBase
```

### Properties

#### SpawnWithoutOxygen

##### Declaration

```
bool SpawnWithoutOxygen { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Methods

#### CanPlayerSpawn(Int64, Boolean)

##### Declaration

```
bool CanPlayerSpawn(long playerId, bool acceptPublicRespawn)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | playerId |     |
| System.Boolean | acceptPublicRespawn |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### GetOxygenLevel()

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### GetSpawnPosition()

##### Declaration

```
MatrixD GetSpawnPosition()
```

##### Returns

| Type | Description |
| --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) |     |