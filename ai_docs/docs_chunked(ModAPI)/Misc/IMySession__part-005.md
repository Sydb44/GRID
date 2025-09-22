| Type | Name | Description |
| --- | --- | --- |
| System.UInt64 | steamId |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Game_ModAPI_IMySession_IsUserShowAllPlayers_System_UInt64_)IsUserShowAllPlayers(UInt64)

Gets whether user can see all players

##### Declaration

```
bool IsUserShowAllPlayers(ulong steamId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.UInt64 | steamId | Player steamId |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if player can see all players |

#### [](#VRage_Game_ModAPI_IMySession_IsUserUntargetable_System_UInt64_)IsUserUntargetable(UInt64)

Gets whether user can't be targeted by turrets

##### Declaration

```
bool IsUserUntargetable(ulong steamId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.UInt64 | steamId | Player steamId |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if player can't be targeted by turrets |

#### [](#VRage_Game_ModAPI_IMySession_IsUserUseAllTerminals_System_UInt64_)IsUserUseAllTerminals(UInt64)

Gets whether user can see use all terminals

##### Declaration

```
bool IsUserUseAllTerminals(ulong steamId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.UInt64 | steamId | Player steamId |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if player can use all terminals |

#### [](#VRage_Game_ModAPI_IMySession_RegisterComponent_VRage_Game_Components_MySessionComponentBase_VRage_Game_Components_MyUpdateOrder_System_Int32_)RegisterComponent(MySessionComponentBase, MyUpdateOrder, Int32)

Registers game session component for updates.

##### Declaration

```
void RegisterComponent(MySessionComponentBase component, MyUpdateOrder updateOrder, int priority)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MySessionComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MySessionComponentBase.html) | component | Game session that should receive updates |
| [MyUpdateOrder](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyUpdateOrder.html) | updateOrder | Defines which update methods should be called |
| System.Int32 | priority | Ignored |

#### [](#VRage_Game_ModAPI_IMySession_Save_System_String_)Save(String)

Saves game

##### Declaration

```
bool Save(string customSaveName = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | customSaveName | Name of game save folder |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Game_ModAPI_IMySession_SetAsNotReady)SetAsNotReady()

Making game "not ready", preventing joining server for EOS server

##### Declaration

#### [](#VRage_Game_ModAPI_IMySession_SetCameraController_VRage_Game_MyCameraControllerEnum_VRage_ModAPI_IMyEntity_System_Nullable_VRageMath_Vector3D__)SetCameraController(MyCameraControllerEnum, IMyEntity, Nullable<Vector3D>)

Sets mode of camera controller

##### Declaration

```
void SetCameraController(MyCameraControllerEnum cameraControllerEnum, IMyEntity cameraEntity = null, Nullable<Vector3D> position = null)
```

##### Parameters

#### [](#VRage_Game_ModAPI_IMySession_SetComponentUpdateOrder_VRage_Game_Components_MySessionComponentBase_VRage_Game_Components_MyUpdateOrder_)SetComponentUpdateOrder(MySessionComponentBase, MyUpdateOrder)

Change the update order of a session component.

There is a proxy for this method in the session component itself.

##### Declaration

```
void SetComponentUpdateOrder(MySessionComponentBase component, MyUpdateOrder order)
```

##### Parameters

#### [](#VRage_Game_ModAPI_IMySession_TryGetAdminSettings_System_UInt64_VRage_Game_ModAPI_MyAdminSettingsEnum__)TryGetAdminSettings(UInt64, out MyAdminSettingsEnum)

Gets enabled admins settings

##### Declaration

```
bool TryGetAdminSettings(ulong steamId, out MyAdminSettingsEnum adminSettings)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.UInt64 | steamId | Player steam id |
| [MyAdminSettingsEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyAdminSettingsEnum.html) | adminSettings | Admin settings that is enabled for player |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True when player found |

#### [](#VRage_Game_ModAPI_IMySession_Unload)Unload()

##### Declaration

#### [](#VRage_Game_ModAPI_IMySession_UnloadDataComponents)UnloadDataComponents()

Unloads data components. Shouldn't be called directly. Use [Unload()](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMySession.html#VRage_Game_ModAPI_IMySession_Unload) instead

##### Declaration

```
void UnloadDataComponents()
```

#### [](#VRage_Game_ModAPI_IMySession_UnloadMultiplayer)UnloadMultiplayer()

Unloads data components. Shouldn't be called directly. Use [Unload()](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMySession.html#VRage_Game_ModAPI_IMySession_Unload) instead

##### Declaration

#### [](#VRage_Game_ModAPI_IMySession_UnregisterComponent_VRage_Game_Components_MySessionComponentBase_)UnregisterComponent(MySessionComponentBase)

Unregisters components from updates and calls.

##### Declaration

```
void UnregisterComponent(MySessionComponentBase component)
```

##### Parameters

#### [](#VRage_Game_ModAPI_IMySession_Update_VRage_Library_Utils_MyTimeSpan_)Update(MyTimeSpan)

Updates games. Does 1 simulation tick

##### Declaration

```
void Update(MyTimeSpan time)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyTimeSpan](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Library.Utils.MyTimeSpan.html) | time | Used in counting whether game save is required. Usually it is 16.67ms |

#### [](#VRage_Game_ModAPI_IMySession_UpdateComponents)UpdateComponents()

Updates games. Does 1 simulation tick, but without any other logic, that is executed in [Update(MyTimeSpan)](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMySession.html#VRage_Game_ModAPI_IMySession_Update_VRage_Library_Utils_MyTimeSpan_)
