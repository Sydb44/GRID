---
title: "Interface IMyGpsCollection"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyGpsCollection.html"
category: "Misc"
namespace: "VRage.Game.ModAPI"
class: "IMyGpsCollection"
---

# Interface IMyGpsCollection | Space Engineers ModAPI

###### **Namespace**: [VRage.Game.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public interface IMyGpsCollection
```

### Methods

#### AddGps(Int64, IMyGps)

Sends a network request to add the GPS entry for the said player, which will also save it to the server.

##### Declaration

```
void AddGps(long identityId, IMyGps gps)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | identityId | Players IdentityId |
| [IMyGps](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyGps.html) | gps | Use the Create() method to get this object |

#### AddLocalGps(IMyGps)

Adds a GPS entry only for this client which won't be synchronized or saved.

##### Declaration

```
void AddLocalGps(IMyGps gps)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyGps](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyGps.html) | gps | GPS |

#### Create(String, String, Vector3D, Boolean, Boolean)

Creates a GPS entry object. Does not automatically add it, you need to use AddGps() or AddLocalGps().

##### Declaration

```
IMyGps Create(string name, string description, Vector3D coords, bool showOnHud, bool temporary = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | name | Name of GPS |
| System.String | description | Description of GPS |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | coords | GPS coordinates |
| System.Boolean | showOnHud | Should gps be visible to player |
| System.Boolean | temporary | whether it automatically expires or not (DiscardAt field) |

##### Returns

| Type | Description |
| --- | --- |
| [IMyGps](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyGps.html) | GPS object |

#### GetGpsList(Int64)

Gets the GPS entries from the specified identity (does not use network traffic).

##### Declaration

```
List<IMyGps> GetGpsList(long identityId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | identityId | Players IdentityId |

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[IMyGps](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyGps.html)\> | The GPS entry list. |

#### GetGpsList(Int64, List<IMyGps>)

Gets the GPS entries from the specified identity (does not use network traffic).

##### Declaration

```
void GetGpsList(long identityId, List<IMyGps> list)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | identityId | Players IdentityId |
| System.Collections.Generic.List<[IMyGps](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyGps.html)\> | list | GPS entries will be added to this list. The list is not cleared internally. |

#### ModifyGps(Int64, IMyGps)

Sends a network request to modify the contents of an existing GPS entry.

##### Declaration

```
void ModifyGps(long identityId, IMyGps gps)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | identityId | Players IdentityId |
| [IMyGps](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyGps.html) | gps | NOTE: it must contain the original hash id |

#### RemoveGps(Int64, Int32)

Sends a network request to remove the specified GPS entry.

##### Declaration

```
void RemoveGps(long identityId, int gpsHash)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | identityId | Players IdentityId |
| System.Int32 | gpsHash | [Hash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyGps.html#VRage_Game_ModAPI_IMyGps_Hash) |

#### RemoveGps(Int64, IMyGps)

Sends a network request to remove the specified GPS entry.

##### Declaration

```
void RemoveGps(long identityId, IMyGps gps)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | identityId | Players IdentityId |
| [IMyGps](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyGps.html) | gps | GPS |

#### RemoveLocalGps(Int32)

Remove a local GPS entry, no network updates sent.

NOTE: This can remove synchronized ones too.

##### Declaration

```
void RemoveLocalGps(int gpsHash)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | gpsHash | [Hash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyGps.html#VRage_Game_ModAPI_IMyGps_Hash) |

#### RemoveLocalGps(IMyGps)

Remove a local GPS entry, no network updates sent.

NOTE: This can remove synchronized ones too.

##### Declaration

```
void RemoveLocalGps(IMyGps gps)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyGps](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyGps.html) | gps | GPS |

#### SetShowOnHud(Int64, Int32, Boolean)

Sends a network request to set the GPS entry if it's shown on HUD or not.

##### Declaration

```
void SetShowOnHud(long identityId, int gpsHash, bool show)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | identityId | Players IdentityId |
| System.Int32 | gpsHash | Hash of gps |
| System.Boolean | show | When true, gps should be shown on Hud |

#### SetShowOnHud(Int64, IMyGps, Boolean)

Sends a network request to set the GPS entry if it's shown on HUD or not.

##### Declaration

```
void SetShowOnHud(long identityId, IMyGps gps, bool show)
```
