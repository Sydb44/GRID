##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| T   | obj | Object to serialize |

##### Returns

| Type | Description |
| --- | --- |
| System.Byte\[\] | Object serialized as bytes |

##### Type Parameters

#### [](#VRage_Game_ModAPI_IMyUtilities_SerializeToXML__1___0_)SerializeToXML<T>(T)

##### Declaration

```
string SerializeToXML<T>(T objToSerialize)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| T   | objToSerialize | Object to save |

##### Returns

| Type | Description |
| --- | --- |
| System.String | Xml |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   | Type of object to save |

#### [](#VRage_Game_ModAPI_IMyUtilities_SetVariable__1_System_String___0_)SetVariable<T>(String, T)

Registers variable in game. It would be saved and loaded through game restarts

##### Declaration

```
void SetVariable<T>(string name, T value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | name | Name of variable |
| T   | value | Value of variable |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   | Type of variable |

#### [](#VRage_Game_ModAPI_IMyUtilities_ShowMessage_System_String_System_String_)ShowMessage(String, String)

Shows message for local player without sending it to other players

##### Declaration

```
void ShowMessage(string sender, string messageText)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | sender | Who is sender. Example: Good.bot |
| System.String | messageText | Text of message |

#### [](#VRage_Game_ModAPI_IMyUtilities_ShowMissionScreen_System_String_System_String_System_String_System_String_System_Action_VRage_Game_ModAPI_ResultEnum__System_String_)ShowMissionScreen(String, String, String, String, Action<ResultEnum>, String)

Shows mission screen

##### Declaration

```
void ShowMissionScreen(string screenTitle = null, string currentObjectivePrefix = null, string currentObjective = null, string screenDescription = null, Action<ResultEnum> callback = null, string okButtonCaption = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | screenTitle | Screen title |
| System.String | currentObjectivePrefix | Subtitle prefix |
| System.String | currentObjective | Subtitle |
| System.String | screenDescription | Description |
| System.Action<[ResultEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.ResultEnum.html)\> | callback | Called when player press ok button or close window |
| System.String | okButtonCaption | Ok button text |

#### [](#VRage_Game_ModAPI_IMyUtilities_ShowNotification_System_String_System_Int32_System_String_)ShowNotification(String, Int32, String)

Shows notification

##### Declaration

```
void ShowNotification(string message, int disappearTimeMs = 2000, string font = "White")
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | message | Message text |
| System.Int32 | disappearTimeMs | How long notification would stay (in milliseconds) |
| System.String | font | Font (color). |

##### See Also

#### [](#VRage_Game_ModAPI_IMyUtilities_UnregisterMessageHandler_System_Int64_System_Action_System_Object__)UnregisterMessageHandler(Int64, Action<Object>)

Removes a handler from the mod message system.

##### Declaration

```
void UnregisterMessageHandler(long id, Action<object> messageHandler)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | id  | Id of handler |
| System.Action<System.Object\> | messageHandler | Function was used as messageHandler |

##### See Also

#### [](#VRage_Game_ModAPI_IMyUtilities_WriteBinaryFileInGlobalStorage_System_String_)WriteBinaryFileInGlobalStorage(String)

Write bytes to file from local storage %APPDATA%/Roaming/SpaceEngineers/Storage/{Assembly Scope}

##### Declaration

```
BinaryWriter WriteBinaryFileInGlobalStorage(string file)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | file | Relative file path |

##### Returns

| Type | Description |
| --- | --- |
| System.IO.BinaryWriter | Text writer |

#### [](#VRage_Game_ModAPI_IMyUtilities_WriteBinaryFileInLocalStorage_System_String_System_Type_)WriteBinaryFileInLocalStorage(String, Type)

Write bytes to file from local storage %APPDATA%/Roaming/SpaceEngineers/Storage/{Assembly Scope}

##### Declaration

```
BinaryWriter WriteBinaryFileInLocalStorage(string file, Type callingType)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | file | Relative file path |
| System.Type | callingType | Use any of your mod classes |

##### Returns

| Type | Description |
| --- | --- |
| System.IO.BinaryWriter | Text writer |

#### [](#VRage_Game_ModAPI_IMyUtilities_WriteBinaryFileInWorldStorage_System_String_System_Type_)WriteBinaryFileInWorldStorage(String, Type)

Write file to the current world's Storage directory.

##### Declaration

```
BinaryWriter WriteBinaryFileInWorldStorage(string file, Type callingType)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | file |     |
| System.Type | callingType |     |

##### Returns

| Type | Description |
| --- | --- |
| System.IO.BinaryWriter |     |

#### [](#VRage_Game_ModAPI_IMyUtilities_WriteFileInGlobalStorage_System_String_)WriteFileInGlobalStorage(String)

Write text to file from local storage %APPDATA%/Roaming/SpaceEngineers/Storage/{Assembly Scope}

##### Declaration

```
TextWriter WriteFileInGlobalStorage(string file)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | file | Relative file path |

##### Returns

| Type | Description |
| --- | --- |
| System.IO.TextWriter | Text writer |

#### [](#VRage_Game_ModAPI_IMyUtilities_WriteFileInLocalStorage_System_String_System_Type_)WriteFileInLocalStorage(String, Type)

Write text to file from local storage %APPDATA%/Roaming/SpaceEngineers/Storage/{Assembly Scope}
