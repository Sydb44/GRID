---
title: "Interface IMyNPCGridClaimSessionComponent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyNPCGridClaimSessionComponent.html"
category: "Components"
namespace: "Sandbox.ModAPI"
class: "IMyNPCGridClaimSessionComponent"
---

# Interface IMyNPCGridClaimSessionComponent | Space Engineers ModAPI

Session for maintaining info about claims on npc grids

###### **Namespace**: [Sandbox.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyNPCGridClaimSessionComponent
```

### Methods

#### GetFramesElapsed(Int64)

Gets frame elapsed since countdown started

##### Declaration

```
Nullable<int> GetFramesElapsed(long gridEntityId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | gridEntityId |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Nullable<System.Int32\> |     |

#### GetTimeRemaining(Int64)

Gets remaining time for that gridId

##### Declaration

```
Nullable<TimeSpan> GetTimeRemaining(long gridEntityId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | gridEntityId |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Nullable<System.TimeSpan\> |     |

#### RequestRegisterGrid(Int64)

Registers a npc grid as such

##### Declaration

```
void RequestRegisterGrid(long gridId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | gridId |     |

#### RequestSetFramesElapsed(Int64, Nullable<Int32>)

Sets frame elapsed since countdown started

##### Declaration

```
void RequestSetFramesElapsed(long gridEntityId, Nullable<int> elapsed)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | gridEntityId |     |
| System.Nullable<System.Int32\> | elapsed |     |

#### RequestUnregisterGrid(Int64)

Registers a npc grid as such

##### Declaration

```
void RequestUnregisterGrid(long gridId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | gridId |     |

### Events

#### ClaimTimerResumed

When claim timer resumes on some grid, grid entity id in parameter during world load

##### Declaration

```
event Action<long> ClaimTimerResumed
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<System.Int64\> |     |

#### ClaimTimerStarted

When claim timer starts for the first time on some grid, grid entity id in parameter

##### Declaration

```
event Action<long> ClaimTimerStarted
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<System.Int64\> |     |

#### GridUnregistered

When grid is unregistered, grid instance in parameter

##### Declaration

```
event Action<IMyCubeGrid> GridUnregistered
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<[IMyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCubeGrid.html)\> |     |