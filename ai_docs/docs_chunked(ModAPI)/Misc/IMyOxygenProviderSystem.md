---
title: "Interface IMyOxygenProviderSystem"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyOxygenProviderSystem.html"
category: "Misc"
namespace: "VRage.Game.ModAPI"
class: "IMyOxygenProviderSystem"
---

# Interface IMyOxygenProviderSystem | Space Engineers ModAPI

ModAPI interface allowing to get information about oxygen level and giving ability to register [IMyOxygenProvider](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyOxygenProvider.html)

###### **Namespace**: [VRage.Game.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public interface IMyOxygenProviderSystem
```

### Methods

#### AddOxygenGenerator(IMyOxygenProvider)

Registers oxygen provider

##### Declaration

```
void AddOxygenGenerator(IMyOxygenProvider provider)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyOxygenProvider](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyOxygenProvider.html) | provider | Provider of oxygen |

#### GetOxygenInPoint(Vector3D)

Gets oxygen level in point

##### Declaration

```
float GetOxygenInPoint(Vector3D worldPoint)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | worldPoint | World position |

##### Returns

| Type | Description |
| --- | --- |
| System.Single | Value from 0 to 1 |

#### RemoveOxygenGenerator(IMyOxygenProvider)

Unregisters oxygen provider

##### Declaration

```
void RemoveOxygenGenerator(IMyOxygenProvider provider)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyOxygenProvider](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyOxygenProvider.html) | provider | Provider of oxygen |