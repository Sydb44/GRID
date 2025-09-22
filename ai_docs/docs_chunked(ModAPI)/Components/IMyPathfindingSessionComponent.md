---
title: "Interface IMyPathfindingSessionComponent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyPathfindingSessionComponent.html"
category: "Components"
namespace: "Sandbox.ModAPI"
class: "IMyPathfindingSessionComponent"
---

# Interface IMyPathfindingSessionComponent | Space Engineers ModAPI

Describes pathfinding session component

###### **Namespace**: [Sandbox.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyPathfindingSessionComponent
```

### Methods

#### FindAvoidPath(IMyEntity, Vector3D, Vector3D, Single, out MyAutopilotPathfindingState)

Finds the path between start and end position

##### Declaration

```
MyPath<MyPathVertex> FindAvoidPath(IMyEntity entity, Vector3D startPosition, Vector3D endPosition, float shipRadius, out MyAutopilotPathfindingState state)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | entity | entity |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | startPosition | start position |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | endPosition | end position |
| System.Single | shipRadius | radius of ship(grid) which is looking for path |
| [MyAutopilotPathfindingState](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.MyAutopilotPathfindingState.html) | state | result state |

##### Returns

| Type | Description |
| --- | --- |
| VRage.Algorithms.MyPath<VRage.Game.AI.MyPathVertex\> |     |