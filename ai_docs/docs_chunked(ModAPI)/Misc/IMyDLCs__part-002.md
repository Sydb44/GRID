
##### Declaration

```
bool HasDefinitionDLC(MyDefinitionBase definition, ulong steamId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionBase.html) | definition | The definition to check. |
| System.UInt64 | steamId | The SteamID of the user to check against. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | true if the player owns all the DLC in the definition. |

#### HasDefinitionDLC(MyDefinitionId, UInt64)

Returns whether a player owns all DLCs required by this definition id.

##### Declaration

```
bool HasDefinitionDLC(MyDefinitionId definitionId, ulong steamId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | definitionId | The definition id to check. |
| System.UInt64 | steamId | The SteamID of the user to check against. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | true if the player owns all the DLC in the definition. |

#### HasDLC(String, UInt64)

Return whether a player owns a DLC.

##### Declaration

```
bool HasDLC(string name, ulong steamId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | name | The [Name](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyDLC.html#VRage_Game_ModAPI_IMyDLC_Name) of the DLC |
| System.UInt64 | steamId | The SteamID of the player to check. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | true if the player owns that DLC. |

#### HasDLC(UInt32, UInt64)

Return whether a player owns a DLC.

##### Declaration

```
bool HasDLC(uint appId, ulong steamId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.UInt32 | appId | The [AppId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyDLC.html#VRage_Game_ModAPI_IMyDLC_AppId) of the DLC |
| System.UInt64 | steamId | The SteamID of the player to check. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | true if the player owns that DLC. |

#### IsDLCSupported(String)

Check if DLC is supported on this platform.

##### Declaration

```
bool IsDLCSupported(string name)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | name | The [Name](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyDLC.html#VRage_Game_ModAPI_IMyDLC_Name) of the DLC |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### TryGetDLC(String, out IMyDLC)

Gets information on the requested DLC.

##### Declaration

```
bool TryGetDLC(string name, out IMyDLC dlc)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | name | The [Name](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyDLC.html#VRage_Game_ModAPI_IMyDLC_Name) of the DLC |
| [IMyDLC](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyDLC.html) | dlc | The requested DLC information. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | true if DLC exists and `dlc` has valid contents. |

#### TryGetDLC(UInt32, out IMyDLC)

Gets information on the requested DLC.

##### Declaration

```
bool TryGetDLC(uint appId, out IMyDLC dlc)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.UInt32 | appId | The [AppId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyDLC.html#VRage_Game_ModAPI_IMyDLC_AppId) of the DLC |
| [IMyDLC](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyDLC.html) | dlc | The requested DLC information. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | true if DLC exists and `dlc` has valid contents. |

### Events

#### DLCInstalled

Called when a new DLC is installed by a client. On the client, this only reports DLC installed on the local client.

##### Declaration

```
event Action<ulong, uint> DLCInstalled
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<System.UInt64, System.UInt32\> |     |