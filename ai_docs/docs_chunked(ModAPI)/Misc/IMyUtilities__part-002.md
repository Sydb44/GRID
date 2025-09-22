##### Declaration

```
bool FileExistsInModLocation(string file, MyObjectBuilder_Checkpoint.ModItem modItem)
```

##### Parameters

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if file exists |

#### [](#VRage_Game_ModAPI_IMyUtilities_FileExistsInWorldStorage_System_String_System_Type_)FileExistsInWorldStorage(String, Type)

Checks if file exists in world save %APPDATA%/Roaming/SpaceEngineers/Save/{SteamId}/{WorldName}/Storage/{Assembly Scope} Where {Assembly Scope} - callingType.Assembly.ManifestModule.ScopeName

##### Declaration

```
bool FileExistsInWorldStorage(string file, Type callingType)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | file | Relative file path |
| System.Type | callingType | Use any of your mod classes |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if file exists |

#### [](#VRage_Game_ModAPI_IMyUtilities_GetObjectiveLine)GetObjectiveLine()

Gets objectives interface

##### Declaration

```
IMyHudObjectiveLine GetObjectiveLine()
```

##### Returns

#### [](#VRage_Game_ModAPI_IMyUtilities_GetTypeName_System_Type_)GetTypeName(Type)

Gets name of type

##### Declaration

```
string GetTypeName(Type type)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Type | type | Type |

##### Returns

| Type | Description |
| --- | --- |
| System.String | Name |

##### See Also

#### [](#VRage_Game_ModAPI_IMyUtilities_GetVariable__1_System_String___0__)GetVariable<T>(String, out T)

Gets registered variable.

##### Declaration

```
bool GetVariable<T>(string name, out T value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | name | Name of variable |
| T   | value | Returned value |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if variable exists |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   | Type of variable |

##### See Also

#### [](#VRage_Game_ModAPI_IMyUtilities_InvokeOnGameThread_System_Action_System_String_System_Int32_System_Int32_)InvokeOnGameThread(Action, String, Int32, Int32)

Invokes action on simulation thread

##### Declaration

```
void InvokeOnGameThread(Action action, string invokerName = "ModAPI", int StartAt = -1, int RepeatTimes = 0)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Action | action | Method to call |
| System.String | invokerName | Description of caller |
| System.Int32 | StartAt | Target frame when this action should be called ([GameplayFrameCounter](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMySession.html#VRage_Game_ModAPI_IMySession_GameplayFrameCounter)) |
| System.Int32 | RepeatTimes | How many times this action should be invoked |

#### [](#VRage_Game_ModAPI_IMyUtilities_ReadBinaryFileInGameContent_System_String_)ReadBinaryFileInGameContent(String)

Reads text file from game content folder. (Folder where SE is installed)

##### Declaration

```
BinaryReader ReadBinaryFileInGameContent(string file)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | file | Relative file path |

##### Returns

| Type | Description |
| --- | --- |
| System.IO.BinaryReader | Text reader |

#### [](#VRage_Game_ModAPI_IMyUtilities_ReadBinaryFileInGlobalStorage_System_String_)ReadBinaryFileInGlobalStorage(String)

Reads text file from global storage %APPDATA%/Roaming/SpaceEngineers/Storage

##### Declaration

```
BinaryReader ReadBinaryFileInGlobalStorage(string file)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | file | Relative file path |

##### Returns

| Type | Description |
| --- | --- |
| System.IO.BinaryReader | Text reader |

#### [](#VRage_Game_ModAPI_IMyUtilities_ReadBinaryFileInLocalStorage_System_String_System_Type_)ReadBinaryFileInLocalStorage(String, Type)

Reads binary file from local storage %APPDATA%/Roaming/SpaceEngineers/Storage/{Assembly Scope}

##### Declaration

```
BinaryReader ReadBinaryFileInLocalStorage(string file, Type callingType)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | file | Relative file path |
| System.Type | callingType | Use any of your mod classes |

##### Returns

| Type | Description |
| --- | --- |
| System.IO.BinaryReader | Text reader |

#### [](#VRage_Game_ModAPI_IMyUtilities_ReadBinaryFileInModLocation_System_String_VRage_Game_MyObjectBuilder_Checkpoint_ModItem_)ReadBinaryFileInModLocation(String, MyObjectBuilder\_Checkpoint.ModItem)

Reads text file from the specified mod's directory.

##### Declaration

```
BinaryReader ReadBinaryFileInModLocation(string file, MyObjectBuilder_Checkpoint.ModItem modItem)
```

##### Parameters

##### Returns

| Type | Description |
| --- | --- |
| System.IO.BinaryReader | Text reader |

#### [](#VRage_Game_ModAPI_IMyUtilities_ReadBinaryFileInWorldStorage_System_String_System_Type_)ReadBinaryFileInWorldStorage(String, Type)

Read binary file from world storage %APPDATA%/Roaming/SpaceEngineers/Save/{SteamId}/{WorldName}/Storage/{Assembly Scope}

##### Declaration

```
BinaryReader ReadBinaryFileInWorldStorage(string file, Type callingType)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | file | Relative file path |
| System.Type | callingType | Use any of your mod classes |

##### Returns

| Type | Description |
| --- | --- |
| System.IO.BinaryReader | Text reader |

#### [](#VRage_Game_ModAPI_IMyUtilities_ReadFileInGameContent_System_String_)ReadFileInGameContent(String)

Reads text file from game content folder. (Folder where SE is installed)

##### Declaration

```
TextReader ReadFileInGameContent(string file)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | file | Relative file path |

##### Returns

| Type | Description |
| --- | --- |
| System.IO.TextReader | Text reader |
