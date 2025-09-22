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

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if message was sent |

#### SendMessageToServer(UInt16, Byte\[\], Boolean)

Send message to server

##### Declaration

```
bool SendMessageToServer(ushort id, byte[] message, bool reliable = true)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.UInt16 | id  | Some random number from 0-65535, that you use in [RegisterSecureMessageHandler(UInt16, Action<UInt16, Byte\[\], UInt64, Boolean>)](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyMultiplayer.html#VRage_Game_ModAPI_IMyMultiplayer_RegisterSecureMessageHandler_System_UInt16_System_Action_System_UInt16_System_Byte___System_UInt64_System_Boolean__). Dont use beautiful numbers like 11111, 22222. You may conflict with other mods. |
| System.Byte\[\] | message | Byte data. Use [SerializeToBinary<T>(T)](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyUtilities.html#VRage_Game_ModAPI_IMyUtilities_SerializeToBinary__1___0_) |
| System.Boolean | reliable | When false, message may not arrive to client, but faster. They also may come in different order, that they have been sent. Unreliable messages are also limited by 1024 bytes. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if message was sent |

#### UnregisterMessageHandler(UInt16, Action<Byte\[\]>)

##### Declaration

```
void UnregisterMessageHandler(ushort id, Action<byte[]> messageHandler)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.UInt16 | id  |     |
| System.Action<System.Byte\[\]> | messageHandler |     |

#### UnregisterSecureMessageHandler(UInt16, Action<UInt16, Byte\[\], UInt64, Boolean>)

Unsubscribes from incoming messages

##### Declaration

```
void UnregisterSecureMessageHandler(ushort id, Action<ushort, byte[], ulong, bool> messageHandler)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.UInt16 | id  | Handler id. Should be same that was registered |
| System.Action<System.UInt16, System.Byte\[\], System.UInt64, System.Boolean\> | messageHandler | Call function. Should be same that was registered |