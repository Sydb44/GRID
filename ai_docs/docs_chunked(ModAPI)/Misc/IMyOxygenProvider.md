---
title: "Interface IMyOxygenProvider"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyOxygenProvider.html"
category: "Misc"
namespace: "VRage.Game.ModAPI"
class: "IMyOxygenProvider"
---

# Interface IMyOxygenProvider | Space Engineers ModAPI

ModAPI interface representing provider of oxygen

###### **Namespace**: [VRage.Game.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public interface IMyOxygenProvider
```

### Methods

#### GetOxygenForPosition(Vector3D)

Gets oxygen for position

##### Declaration

```
float GetOxygenForPosition(Vector3D worldPoint)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | worldPoint | World coordinates |

##### Returns

| Type | Description |
| --- | --- |
| System.Single | Oxygen level |

#### IsPositionInRange(Vector3D)

Checks if provider can provide oxygen in that position

##### Declaration

```
bool IsPositionInRange(Vector3D worldPoint)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | worldPoint | World coordinates |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if can provide oxygen in that position |