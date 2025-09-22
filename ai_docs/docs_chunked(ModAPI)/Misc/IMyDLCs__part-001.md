---
title: "Interface IMyDLCs"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyDLCs.html"
category: "Misc"
namespace: "VRage.Game.ModAPI"
class: "IMyDLCs"
---

# Interface IMyDLCs | Space Engineers ModAPI

Describes API, that allows you get information about DLCs (mods interface)

###### **Namespace**: [VRage.Game.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

### Methods

#### ContainsRequiredDLC(MyDefinitionBase, List<UInt64>)

Returns whether the collection contains the DLCs in this definition.

##### Declaration

```
bool ContainsRequiredDLC(MyDefinitionBase definition, List<ulong> dlcs)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionBase.html) | definition | The definition to check. |
| System.Collections.Generic.List<System.UInt64\> | dlcs | The collection to compare against. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | true if the definition has no DLCs specified, or all the DLCs specified in `definition` are present in `dlcs`. |

#### GetAvailableClientDLCIds()

Returns a list of the DLCs installed on the local client.

##### Declaration

```
ListReader<uint> GetAvailableClientDLCIds()
```

##### Returns

| Type | Description |
| --- | --- |
| [ListReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.ListReader-1.html)<System.UInt32\> | List of [AppId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyDLC.html#VRage_Game_ModAPI_IMyDLC_AppId). |

#### GetDLC(String)

Gets information on the requested DLC.

##### Declaration

```
IMyDLC GetDLC(string name)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | name | The [Name](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyDLC.html#VRage_Game_ModAPI_IMyDLC_Name) of the DLC |

##### Returns

| Type | Description |
| --- | --- |
| [IMyDLC](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyDLC.html) | Requested DLC information. |

##### Exceptions

| Type | Condition |
| --- | --- |
| System.Collections.Generic.KeyNotFoundException | Name supplied doesn't match a known DLC. |

#### GetDLC(UInt32)

Gets information on the requested DLC.

##### Declaration

```
IMyDLC GetDLC(uint appId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.UInt32 | appId | The [AppId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyDLC.html#VRage_Game_ModAPI_IMyDLC_AppId) of the DLC |

##### Returns

| Type | Description |
| --- | --- |
| [IMyDLC](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyDLC.html) | Requested DLC information. |

##### Exceptions

| Type | Condition |
| --- | --- |
| System.Collections.Generic.KeyNotFoundException | AppId supplied doesn't match a known DLC. |

#### GetDLCs()

Get a list of all DLCs the game has. This will not change for the lifetime of the session and is safe to cache.

##### Declaration

```
ListReader<IMyDLC> GetDLCs()
```

##### Returns

| Type | Description |
| --- | --- |
| [ListReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.ListReader-1.html)<[IMyDLC](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyDLC.html)\> |     |

#### GetFirstMissingDefinitionDLC(MyDefinitionBase, UInt64)

Get the first DLC a player is missing that a definition requires. Null if they have all.

##### Declaration

```
IMyDLC GetFirstMissingDefinitionDLC(MyDefinitionBase definition, ulong steamId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionBase.html) | definition | The definition to check. |
| System.UInt64 | steamId | The SteamID of the user to check against. |

##### Returns

| Type | Description |
| --- | --- |
| [IMyDLC](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyDLC.html) | The first DLC not available by the specified `steamId`. null if definition has no DLC, or the user has all of them. |

#### GetRequiredDLCTooltip(String)

Returns the tooltip text that is shown to the user if they don't own the DLC.

##### Declaration

```
string GetRequiredDLCTooltip(string name)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | name | The [Name](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyDLC.html#VRage_Game_ModAPI_IMyDLC_Name) of the DLC |

##### Returns

| Type | Description |
| --- | --- |
| System.String | Localized and formatted version of MyCommonTexts.RequiresDlc |

#### GetRequiredDLCTooltip(UInt32)

Returns the tooltip text that is shown to the user if they don't own the DLC.

##### Declaration

```
string GetRequiredDLCTooltip(uint appId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.UInt32 | appId | The [AppId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyDLC.html#VRage_Game_ModAPI_IMyDLC_AppId) of the DLC |

##### Returns

| Type | Description |
| --- | --- |
| System.String | Localized and formatted version of MyCommonTexts.RequiresDlc |

#### HasDefinitionDLC(MyDefinitionBase, UInt64)

Returns whether a player owns all DLCs required by this definition.

##### Declaration

```
bool HasDefinitionDLC(MyDefinitionBase definition, ulong steamId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionBase.html) | definition | The definition to check. |
| System.UInt64 | steamId | The SteamID of the user to check against. |
