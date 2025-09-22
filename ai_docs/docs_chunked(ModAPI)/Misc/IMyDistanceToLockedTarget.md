---
title: "Interface IMyDistanceToLockedTarget"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyDistanceToLockedTarget.html"
category: "Misc"
namespace: "Sandbox.ModAPI"
class: "IMyDistanceToLockedTarget"
---

# Interface IMyDistanceToLockedTarget | Space Engineers ModAPI

Describes distance to locked target interface for block, which is able to target lock

###### **Namespace**: [Sandbox.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyDistanceToLockedTarget
```

### Properties

#### DistanceToLockedTarget

Gets distance to locked target in meters

##### Declaration

```
float DistanceToLockedTarget { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Entity

Gets the entity of this interface entity component

##### Declaration

```
IMyEntity Entity { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) |     |

### Events

#### DistanceToLockedTargetChanged

Event distance to locked target is changed (block, old value, new value)

##### Declaration

```
event Action<IMyDistanceToLockedTarget, float, float> DistanceToLockedTargetChanged
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<[IMyDistanceToLockedTarget](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyDistanceToLockedTarget.html), System.Single, System.Single\> |     |