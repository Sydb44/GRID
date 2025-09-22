---
title: "Interface IMyMultiplayer"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyMultiplayer.html"
category: "Misc"
namespace: "VRage.Game.ModAPI"
class: "IMyMultiplayer"
---

# Interface IMyMultiplayer | Space Engineers ModAPI

ModAPI interface giving access to interaction between server and client

###### **Namespace**: [VRage.Game.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public interface IMyMultiplayer
```

### Properties

#### IsServer

Returns if current game instance is server

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### MultiplayerActive

Gets if game supports several people

##### Declaration

```
bool MultiplayerActive { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### MyId

Gets this game instance id (steamId or other)

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.UInt64 |     |

#### MyName

Get current player name

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### Players

Gets players currently connected to server

##### Declaration

```
IMyPlayerCollection Players { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [IMyPlayerCollection](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyPlayerCollection.html) |     |

#### ServerId

Gets id (steamId or other) of server

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.UInt64 |     |

### Methods

#### IsServerPlayer(IMyNetworkClient)

Gets if provided network is a player and also server

##### Declaration

```
bool IsServerPlayer(IMyNetworkClient player)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyNetworkClient](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyNetworkClient.html) | player | Player to test if he is server |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if provided network is a player and also server |

#### JoinServer(String)

Exiting current server, and joining other server

##### Declaration

```
void JoinServer(string address)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | address |     |

#### RegisterMessageHandler(UInt16, Action<Byte\[\]>)

##### Declaration

```
void RegisterMessageHandler(ushort id, Action<byte[]> messageHandler)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.UInt16 | id  |     |
| System.Action<System.Byte\[\]> | messageHandler |     |

#### RegisterSecureMessageHandler(UInt16, Action<UInt16, Byte\[\], UInt64, Boolean>)

Allows you do reliable checks WHO have sent message to you. Action - HandlerId, Package, Player SteamID or 0 for Dedicated server, Sent message comes from server

##### Declaration

```
void RegisterSecureMessageHandler(ushort id, Action<ushort, byte[], ulong, bool> messageHandler)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.UInt16 | id  | Handler id, may be not unique, but then for each message multiple handlers would be executed |
| System.Action<System.UInt16, System.Byte\[\], System.UInt64, System.Boolean\> | messageHandler | Call function. Arguments: handlerId, messageSentBytes, senderPlayerId, isArrivedFromServer |

#### SendEntitiesCreated(List<MyObjectBuilder\_EntityBase>)

Does nothing

##### Declaration

```
void SendEntitiesCreated(List<MyObjectBuilder_EntityBase> objectBuilders)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<[MyObjectBuilder\_EntityBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_EntityBase.html)\> | objectBuilders | Ignored |

#### SendMessageTo(UInt16, Byte\[\], UInt64, Boolean)

Send message to one recipient.

##### Declaration

```
bool SendMessageTo(ushort id, byte[] message, ulong recipient, bool reliable = true)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.UInt16 | id  | Some random number from 0-65535, that you use in [RegisterSecureMessageHandler(UInt16, Action<UInt16, Byte\[\], UInt64, Boolean>)](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyMultiplayer.html#VRage_Game_ModAPI_IMyMultiplayer_RegisterSecureMessageHandler_System_UInt16_System_Action_System_UInt16_System_Byte___System_UInt64_System_Boolean__). Dont use beautiful numbers like 11111, 22222. You may conflict with other mods. |
| System.Byte\[\] | message | Byte data. Use [SerializeToBinary<T>(T)](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyUtilities.html#VRage_Game_ModAPI_IMyUtilities_SerializeToBinary__1___0_) |
| System.UInt64 | recipient | Use [SteamUserId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyPlayer.html#VRage_Game_ModAPI_IMyPlayer_SteamUserId). **Not** IdentityId (long) |
| System.Boolean | reliable | When false, message may not arrive to client, but faster. Unreliable messages are also limited by 1024 bytes. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if message was sent |

#### SendMessageToOthers(UInt16, Byte\[\], Boolean)

Send message to everyone on server (including server)

##### Declaration

```
bool SendMessageToOthers(ushort id, byte[] message, bool reliable = true)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.UInt16 | id  | Some random number from 0-65535, that you use in [RegisterSecureMessageHandler(UInt16, Action<UInt16, Byte\[\], UInt64, Boolean>)](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyMultiplayer.html#VRage_Game_ModAPI_IMyMultiplayer_RegisterSecureMessageHandler_System_UInt16_System_Action_System_UInt16_System_Byte___System_UInt64_System_Boolean__). Dont use beautiful numbers like 11111, 22222. You may conflict with other mods. |
| System.Byte\[\] | message | Byte data. Use [SerializeToBinary<T>(T)](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyUtilities.html#VRage_Game_ModAPI_IMyUtilities_SerializeToBinary__1___0_) |
| System.Boolean | reliable | When false, message may not arrive to client, but faster. Unreliable messages are also limited by 1024 bytes. |
