---
title: "Interface IMyPrefabManager"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyPrefabManager.html"
category: "Misc"
namespace: "VRage.Game.ModAPI"
class: "IMyPrefabManager"
---

# Interface IMyPrefabManager | Space Engineers ModAPI

ModAPI interface giving ability for modders to spawn prefabs

###### **Namespace**: [VRage.Game.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public interface IMyPrefabManager
```

### [](#methods)Methods

#### [](#VRage_Game_ModAPI_IMyPrefabManager_IsPathClear_VRageMath_Vector3D_VRageMath_Vector3D_)IsPathClear(Vector3D, Vector3D)

Checks if there is noting between 2 points. Raycasts inside

##### Declaration

```
bool IsPathClear(Vector3D from, Vector3D to)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | from | World position 1 |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | to  | World position 2 |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True, if there is nothing between 2 points |

#### [](#VRage_Game_ModAPI_IMyPrefabManager_IsPathClear_VRageMath_Vector3D_VRageMath_Vector3D_System_Double_)IsPathClear(Vector3D, Vector3D, Double)

Checks if there is noting between 2 points, in cylinder shape. Does 4 Raycasts inside

##### Declaration

```
bool IsPathClear(Vector3D from, Vector3D to, double halfSize)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | from | World position 1 |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | to  | World position 2 |
| System.Double | halfSize | Cylinder radius |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True, if there is nothing between 2 points |

#### [](#VRage_Game_ModAPI_IMyPrefabManager_SpawnPrefab_System_Collections_Generic_List_VRage_Game_ModAPI_IMyCubeGrid__System_String_VRageMath_Vector3D_VRageMath_Vector3_VRageMath_Vector3_VRageMath_Vector3_VRageMath_Vector3_System_String_VRage_Game_ModAPI_SpawningOptions_System_Boolean_System_Action_)SpawnPrefab(List<IMyCubeGrid>, String, Vector3D, Vector3, Vector3, Vector3, Vector3, String, SpawningOptions, Boolean, Action)

Spawns prefab

##### Declaration

```
void SpawnPrefab(List<IMyCubeGrid> resultList, string prefabName, Vector3D position, Vector3 forward, Vector3 up, Vector3 initialLinearVelocity = null, Vector3 initialAngularVelocity = null, string beaconName = null, SpawningOptions spawningOptions, bool updateSync = false, Action callback = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<[IMyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCubeGrid.html)\> | resultList | List of grids were created |
| System.String | prefabName | Name of prefab |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | position | Place to spawn. See: [FindFreePlace(Vector3D, Single, Int32, Int32, Single)](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntities.html#VRage_ModAPI_IMyEntities_FindFreePlace_VRageMath_Vector3D_System_Single_System_Int32_System_Int32_System_Single_) |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | forward | Forward direction |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | up  | Up direction |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | initialLinearVelocity | When spawned, would it would have this linear speed |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | initialAngularVelocity | When spawned, would it would have this angular speed |
| System.String | beaconName | Sets name to all beacons |
| [SpawningOptions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.SpawningOptions.html) | spawningOptions | Special spawning options |
| System.Boolean | updateSync | Random seed depends on this |
| System.Action | callback | Called when prefab created |

#### [](#VRage_Game_ModAPI_IMyPrefabManager_SpawnPrefab_System_Collections_Generic_List_VRage_Game_ModAPI_IMyCubeGrid__System_String_VRageMath_Vector3D_VRageMath_Vector3_VRageMath_Vector3_VRageMath_Vector3_VRageMath_Vector3_System_String_VRage_Game_ModAPI_SpawningOptions_System_Int64_System_Boolean_System_Action_)SpawnPrefab(List<IMyCubeGrid>, String, Vector3D, Vector3, Vector3, Vector3, Vector3, String, SpawningOptions, Int64, Boolean, Action)

Spawns prefab

##### Declaration

```
void SpawnPrefab(List<IMyCubeGrid> resultList, string prefabName, Vector3D position, Vector3 forward, Vector3 up, Vector3 initialLinearVelocity = null, Vector3 initialAngularVelocity = null, string beaconName = null, SpawningOptions spawningOptions, long ownerId = 0L, bool updateSync = false, Action callback = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<[IMyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCubeGrid.html)\> | resultList | List of grids were created |
| System.String | prefabName | Name of prefab |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | position | Place to spawn. See: [FindFreePlace(Vector3D, Single, Int32, Int32, Single)](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntities.html#VRage_ModAPI_IMyEntities_FindFreePlace_VRageMath_Vector3D_System_Single_System_Int32_System_Int32_System_Single_) |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | forward | Forward direction |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | up  | Up direction |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | initialLinearVelocity | When spawned, would it would have this linear speed |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | initialAngularVelocity | When spawned, would it would have this angular speed |
| System.String | beaconName | Sets name to all beacons |
| [SpawningOptions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.SpawningOptions.html) | spawningOptions | Special spawning options |
| System.Int64 | ownerId |     |
| System.Boolean | updateSync | Random seed depends on this |
| System.Action | callback | Called when prefab created |