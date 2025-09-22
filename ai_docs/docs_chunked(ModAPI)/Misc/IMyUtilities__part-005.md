| Type | Name | Description |
| --- | --- | --- |
| System.String | file | Relative file path |

##### Returns

| Type | Description |
| --- | --- |
| System.IO.TextWriter | Text writer |

#### [](#VRage_Game_ModAPI_IMyUtilities_WriteFileInLocalStorage_System_String_System_Type_)WriteFileInLocalStorage(String, Type)

Write text to file from local storage %APPDATA%/Roaming/SpaceEngineers/Storage/{Assembly Scope}

##### Declaration

```
TextWriter WriteFileInLocalStorage(string file, Type callingType)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | file | Relative file path |
| System.Type | callingType | Use any of your mod classes |

##### Returns

| Type | Description |
| --- | --- |
| System.IO.TextWriter | Text writer |

#### [](#VRage_Game_ModAPI_IMyUtilities_WriteFileInWorldStorage_System_String_System_Type_)WriteFileInWorldStorage(String, Type)

Write text to file from current world's storage directory. %APPDATA%/Roaming/SpaceEngineers/Save/{SteamId}/{WorldName}/Storage/{Assembly Scope}

##### Declaration

```
TextWriter WriteFileInWorldStorage(string file, Type callingType)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | file | Relative file path |
| System.Type | callingType | Use any of your mod classes |

##### Returns

| Type | Description |
| --- | --- |
| System.IO.TextWriter | Text writer |

### [](#events)Events

#### [](#VRage_Game_ModAPI_IMyUtilities_MessageEntered)MessageEntered

##### Declaration

```
event MessageEnteredDel MessageEntered
```

##### Event Type

#### [](#VRage_Game_ModAPI_IMyUtilities_MessageEnteredSender)MessageEnteredSender

Called when player sending message. If you change **SendMessageToOthers** to false, message won't be sent to other players and server It may be used to handle local commands like /wave

##### Declaration

```
event MessageEnteredSenderDel MessageEnteredSender
```

##### Event Type

#### [](#VRage_Game_ModAPI_IMyUtilities_MessageRecieved)MessageRecieved

Called when message arrived from server (other player). Arguments - Player SteamId and message text.

##### Declaration

```
event Action<ulong, string> MessageRecieved
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<System.UInt64, System.String\> |     |