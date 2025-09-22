---
title: "Interface IMyAiRvoSessionComponent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyAiRvoSessionComponent.html"
category: "Components"
namespace: "Sandbox.ModAPI"
class: "IMyAiRvoSessionComponent"
---

# Interface IMyAiRvoSessionComponent | Space Engineers ModAPI

Describes AI RVO (Collision Avoidance) session component for dynamic grids

###### **Namespace**: [Sandbox.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyAiRvoSessionComponent
```

### Methods

#### IsCubeGridSimulationComputed(IMyCubeGrid, out Vector3D)

Gets whether the cube grid was simulation is computed

##### Declaration

```
bool IsCubeGridSimulationComputed(IMyCubeGrid grid, out Vector3D newVelocity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCubeGrid.html) | grid | dynamic grid |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | newVelocity | new computed velocity |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | true if new velocity is computed |

#### RequestUpdate(IMyCubeGrid)

Requests Update of the RVO for specific grid.

##### Declaration

```
void RequestUpdate(IMyCubeGrid grid)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCubeGrid.html) | grid | dynamic grid |