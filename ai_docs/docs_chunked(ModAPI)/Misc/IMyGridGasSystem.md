---
title: "Interface IMyGridGasSystem"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyGridGasSystem.html"
category: "Misc"
namespace: "VRage.Game.ModAPI"
class: "IMyGridGasSystem"
---

# Interface IMyGridGasSystem | Space Engineers ModAPI

ModAPI interface giving access to grid-group gas system

###### **Namespace**: [VRage.Game.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public interface IMyGridGasSystem
```

### [](#properties)Properties

#### [](#VRage_Game_ModAPI_IMyGridGasSystem_ForcePressurize)ForcePressurize

Specifies if the grid should be able to pressurize without air vents present.

##### Declaration

```
bool ForcePressurize { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Game_ModAPI_IMyGridGasSystem_IsProcessingData)IsProcessingData

Returns true if the grid is currently recalculating airtightness (It's multithreaded)

##### Declaration

```
bool IsProcessingData { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Game_ModAPI_IMyGridGasSystem_OnProcessingDataComplete)OnProcessingDataComplete

Called when ProcessingData becomes false

##### Declaration

```
Action OnProcessingDataComplete { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Action |     |

#### [](#VRage_Game_ModAPI_IMyGridGasSystem_OnProcessingDataStart)OnProcessingDataStart

Called when ProcessingData becomes true

##### Declaration

```
Action OnProcessingDataStart { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Action |     |

### [](#methods)Methods

#### [](#VRage_Game_ModAPI_IMyGridGasSystem_GetOxygenBlock_VRageMath_Vector3D_)GetOxygenBlock(Vector3D)

Returns an oxygen block at the position if there is one

##### Declaration

```
IMyOxygenBlock GetOxygenBlock(Vector3D worldPosition)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | worldPosition |     |

##### Returns

#### [](#VRage_Game_ModAPI_IMyGridGasSystem_GetOxygenRoomForCubeGridPosition_VRageMath_Vector3I__)GetOxygenRoomForCubeGridPosition(ref Vector3I)

Returns an oxygen room at the position if there is one

##### Declaration

```
IMyOxygenRoom GetOxygenRoomForCubeGridPosition(ref Vector3I gridPosition)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | gridPosition |     |

##### Returns

#### [](#VRage_Game_ModAPI_IMyGridGasSystem_GetRooms_System_Collections_Generic_List_VRage_Game_ModAPI_IMyOxygenRoom__)GetRooms(List<IMyOxygenRoom>)

Gets all oxygen rooms on the grid

##### Declaration

```
bool GetRooms(List<IMyOxygenRoom> list)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<[IMyOxygenRoom](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyOxygenRoom.html)\> | list |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |