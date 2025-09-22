Type

Description

[MessageEnteredDel](VRage.Game.ModAPI.MessageEnteredDel.html)

#### [](#Sandbox_ModAPI_MyAPIUtilities_MessageEnteredSender)MessageEnteredSender

##### Declaration

```
public event MessageEnteredSenderDel MessageEnteredSender
```

##### Event Type

Type

Description

[MessageEnteredSenderDel](VRage.Game.ModAPI.MessageEnteredSenderDel.html)

#### [](#Sandbox_ModAPI_MyAPIUtilities_MessageRecieved)MessageRecieved

##### Declaration

```
public event Action<ulong, string> MessageRecieved
```

##### Event Type

Type

Description

System.Action<System.UInt64, System.String\>

### [](#eii)Explicit Interface Implementations

#### [](#Sandbox_ModAPI_MyAPIUtilities_VRage_Game_ModAPI_IMyGamePaths_ContentPath)IMyGamePaths.ContentPath

##### Declaration

```
string IMyGamePaths.ContentPath { get; }
```

##### Returns

Type

Description

System.String

#### [](#Sandbox_ModAPI_MyAPIUtilities_VRage_Game_ModAPI_IMyGamePaths_ModScopeName)IMyGamePaths.ModScopeName

##### Declaration

```
string IMyGamePaths.ModScopeName { get; }
```

##### Returns

Type

Description

System.String

#### [](#Sandbox_ModAPI_MyAPIUtilities_VRage_Game_ModAPI_IMyGamePaths_ModsPath)IMyGamePaths.ModsPath

##### Declaration

```
string IMyGamePaths.ModsPath { get; }
```

##### Returns

Type

Description

System.String

#### [](#Sandbox_ModAPI_MyAPIUtilities_VRage_Game_ModAPI_IMyGamePaths_SavesPath)IMyGamePaths.SavesPath

##### Declaration

```
string IMyGamePaths.SavesPath { get; }
```

##### Returns

Type

Description

System.String

#### [](#Sandbox_ModAPI_MyAPIUtilities_VRage_Game_ModAPI_IMyGamePaths_UserDataPath)IMyGamePaths.UserDataPath

##### Declaration

```
string IMyGamePaths.UserDataPath { get; }
```

##### Returns

Type

Description

System.String

#### [](#Sandbox_ModAPI_MyAPIUtilities_VRage_Game_ModAPI_IMyUtilities_add_MessageEntered_VRage_Game_ModAPI_MessageEnteredDel_)IMyUtilities.add\_MessageEntered(MessageEnteredDel)

##### Declaration

```
void IMyUtilities.add_MessageEntered(MessageEnteredDel value)
```

##### Parameters

Type

Name

Description

[MessageEnteredDel](VRage.Game.ModAPI.MessageEnteredDel.html)

value

#### [](#Sandbox_ModAPI_MyAPIUtilities_VRage_Game_ModAPI_IMyUtilities_ConfigDedicated)IMyUtilities.ConfigDedicated

##### Declaration

```
IMyConfigDedicated IMyUtilities.ConfigDedicated { get; }
```

##### Returns

Type

Description

[IMyConfigDedicated](VRage.Game.ModAPI.IMyConfigDedicated.html)

#### [](#Sandbox_ModAPI_MyAPIUtilities_VRage_Game_ModAPI_IMyUtilities_CreateNotification_System_String_System_Int32_System_String_)IMyUtilities.CreateNotification(String, Int32, String)

##### Declaration

```
IMyHudNotification IMyUtilities.CreateNotification(string message, int disappearTimeMs, string font)
```

##### Parameters

Type

Name

Description

System.String

message

System.Int32

disappearTimeMs

System.String

font

##### Returns

Type

Description

[IMyHudNotification](VRage.Game.ModAPI.IMyHudNotification.html)

#### [](#Sandbox_ModAPI_MyAPIUtilities_VRage_Game_ModAPI_IMyUtilities_DeleteFileInGlobalStorage_System_String_)IMyUtilities.DeleteFileInGlobalStorage(String)

##### Declaration

```
void IMyUtilities.DeleteFileInGlobalStorage(string file)
```

##### Parameters

Type

Name

Description

System.String

file

#### [](#Sandbox_ModAPI_MyAPIUtilities_VRage_Game_ModAPI_IMyUtilities_DeleteFileInLocalStorage_System_String_System_Type_)IMyUtilities.DeleteFileInLocalStorage(String, Type)

##### Declaration

```
void IMyUtilities.DeleteFileInLocalStorage(string file, Type callingType)
```

##### Parameters

Type

Name

Description

System.String

file

System.Type

callingType

#### [](#Sandbox_ModAPI_MyAPIUtilities_VRage_Game_ModAPI_IMyUtilities_DeleteFileInWorldStorage_System_String_System_Type_)IMyUtilities.DeleteFileInWorldStorage(String, Type)

##### Declaration

```
void IMyUtilities.DeleteFileInWorldStorage(string file, Type callingType)
```

##### Parameters

Type

Name

Description

System.String

file

System.Type

callingType

#### [](#Sandbox_ModAPI_MyAPIUtilities_VRage_Game_ModAPI_IMyUtilities_FileExistsInGameContent_System_String_)IMyUtilities.FileExistsInGameContent(String)

##### Declaration

```
bool IMyUtilities.FileExistsInGameContent(string file)
```

##### Parameters

Type

Name

Description

System.String

file

##### Returns

Type

Description

System.Boolean

#### [](#Sandbox_ModAPI_MyAPIUtilities_VRage_Game_ModAPI_IMyUtilities_FileExistsInGlobalStorage_System_String_)IMyUtilities.FileExistsInGlobalStorage(String)

##### Declaration

```
bool IMyUtilities.FileExistsInGlobalStorage(string file)
```

##### Parameters

Type

Name

Description

System.String

file

##### Returns

Type

Description

System.Boolean

#### [](#Sandbox_ModAPI_MyAPIUtilities_VRage_Game_ModAPI_IMyUtilities_FileExistsInLocalStorage_System_String_System_Type_)IMyUtilities.FileExistsInLocalStorage(String, Type)

##### Declaration

```
bool IMyUtilities.FileExistsInLocalStorage(string file, Type callingType)
```

##### Parameters

Type

Name

Description

System.String

file

System.Type

callingType

##### Returns

Type

Description

System.Boolean

#### [](#Sandbox_ModAPI_MyAPIUtilities_VRage_Game_ModAPI_IMyUtilities_FileExistsInModLocation_System_String_VRage_Game_MyObjectBuilder_Checkpoint_ModItem_)IMyUtilities.FileExistsInModLocation(String, MyObjectBuilder\_Checkpoint.ModItem)

##### Declaration

```
bool IMyUtilities.FileExistsInModLocation(string file, MyObjectBuilder_Checkpoint.ModItem modItem)
```

##### Parameters

Type

Name

Description

System.String

file

[MyObjectBuilder\_Checkpoint.ModItem](VRage.Game.MyObjectBuilder_Checkpoint.ModItem.html)

modItem

##### Returns

Type

Description

System.Boolean

#### [](#Sandbox_ModAPI_MyAPIUtilities_VRage_Game_ModAPI_IMyUtilities_FileExistsInWorldStorage_System_String_System_Type_)IMyUtilities.FileExistsInWorldStorage(String, Type)

##### Declaration

```
bool IMyUtilities.FileExistsInWorldStorage(string file, Type callingType)
```
