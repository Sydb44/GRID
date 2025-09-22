---
title: "Interface IMyAutopilotWaypoint"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyAutopilotWaypoint.html"
category: "AI"
namespace: "Sandbox.ModAPI.Ingame"
class: "IMyAutopilotWaypoint"
---

# Interface IMyAutopilotWaypoint | Space Engineers ModAPI

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyAutopilotWaypoint
```

### Properties

#### Matrix

Gets matrix representing recorded position and rotation

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) |     |

#### Name

Name of waypoint

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### RelatedEntityId

Sets Id of entity in relation to which the Coords are set

##### Declaration

```
long RelatedEntityId { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### RelativeMatrix

Coordinates in relation to relatedEntity

##### Declaration

```
MatrixD RelativeMatrix { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) |     |