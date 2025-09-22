---
title: "Interface IMyUtilities"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyUtilities.html"
category: "Misc"
namespace: "VRage.Game.ModAPI"
class: "IMyUtilities"
---

# Interface IMyUtilities | Space Engineers ModAPI

ModAPI interface giving access to utility functions

###### **Namespace**: [VRage.Game.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public interface IMyUtilities
```

### [](#properties)Properties

#### [](#VRage_Game_ModAPI_IMyUtilities_ConfigDedicated)ConfigDedicated

Gets config of dedicated server

##### Declaration

```
IMyConfigDedicated ConfigDedicated { get; }
```

##### Property Value

#### [](#VRage_Game_ModAPI_IMyUtilities_GamePaths)GamePaths

Gets ModAPI interface that, giving you information about most important game paths

##### Declaration

```
IMyGamePaths GamePaths { get; }
```

##### Property Value

#### [](#VRage_Game_ModAPI_IMyUtilities_IsDedicated)IsDedicated

Gets if this game instance is dedicated server

##### Declaration

```
bool IsDedicated { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### [](#methods)Methods

#### [](#VRage_Game_ModAPI_IMyUtilities_add_MessageEntered_VRage_Game_ModAPI_MessageEnteredDel_)add\_MessageEntered(MessageEnteredDel)

##### Declaration

```
void add_MessageEntered(MessageEnteredDel value)
```

##### Parameters

#### [](#VRage_Game_ModAPI_IMyUtilities_add_MessageEnteredSender_VRage_Game_ModAPI_MessageEnteredSenderDel_)add\_MessageEnteredSender(MessageEnteredSenderDel)

##### Declaration

```
void add_MessageEnteredSender(MessageEnteredSenderDel value)
```

##### Parameters

#### [](#VRage_Game_ModAPI_IMyUtilities_CreateNotification_System_String_System_Int32_System_String_)CreateNotification(String, Int32, String)

Create a notification object. The object needs to have Show() called on it to be shown. On top of that you can dynamically change the text, font and adjust the time to live.

##### Declaration

```
IMyHudNotification CreateNotification(string message, int disappearTimeMs = 2000, string font = "White")
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | message | Message text |
| System.Int32 | disappearTimeMs | How long notification would stay (in milliseconds) |
| System.String | font | Font (color). |

##### Returns

##### See Also

#### [](#VRage_Game_ModAPI_IMyUtilities_DeleteFileInGlobalStorage_System_String_)DeleteFileInGlobalStorage(String)

Deletes file in global storage %APPDATA%/Roaming/SpaceEngineers/Storage

##### Declaration

```
void DeleteFileInGlobalStorage(string file)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | file | Relative path |

#### [](#VRage_Game_ModAPI_IMyUtilities_DeleteFileInLocalStorage_System_String_System_Type_)DeleteFileInLocalStorage(String, Type)

Deletes file in local storage %APPDATA%/Roaming/SpaceEngineers/Storage/{Assembly Scope} Where {Assembly Scope} - callingType.Assembly.ManifestModule.ScopeName

##### Declaration

```
void DeleteFileInLocalStorage(string file, Type callingType)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | file | Relative file path |
| System.Type | callingType | Use any of your mod classes |

#### [](#VRage_Game_ModAPI_IMyUtilities_DeleteFileInWorldStorage_System_String_System_Type_)DeleteFileInWorldStorage(String, Type)

Deletes file in world storage %APPDATA%/Roaming/SpaceEngineers/Save/{SteamId}/{WorldName}/Storage/{Assembly Scope} Where {Assembly Scope} - callingType.Assembly.ManifestModule.ScopeName

##### Declaration

```
void DeleteFileInWorldStorage(string file, Type callingType)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | file | Relative file path |
| System.Type | callingType | Use any of your mod classes |

#### [](#VRage_Game_ModAPI_IMyUtilities_FileExistsInGameContent_System_String_)FileExistsInGameContent(String)

Checks if file exists in game content folder. (Folder where SE is installed)

##### Declaration

```
bool FileExistsInGameContent(string file)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | file | Relative file path |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if file exists |

#### [](#VRage_Game_ModAPI_IMyUtilities_FileExistsInGlobalStorage_System_String_)FileExistsInGlobalStorage(String)

Checks if file exists in %APPDATA%/Roaming/SpaceEngineers/Storage folder. (Folder where SE is installed)

##### Declaration

```
bool FileExistsInGlobalStorage(string file)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | file | Relative file path |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if file exists |

#### [](#VRage_Game_ModAPI_IMyUtilities_FileExistsInLocalStorage_System_String_System_Type_)FileExistsInLocalStorage(String, Type)

Checks if file exists in %APPDATA%/Roaming/SpaceEngineers/Storage/{Assembly Scope} Where {Assembly Scope} - callingType.Assembly.ManifestModule.ScopeName

##### Declaration

```
bool FileExistsInLocalStorage(string file, Type callingType)
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

#### [](#VRage_Game_ModAPI_IMyUtilities_FileExistsInModLocation_System_String_VRage_Game_MyObjectBuilder_Checkpoint_ModItem_)FileExistsInModLocation(String, MyObjectBuilder\_Checkpoint.ModItem)

Checks if file exists in other mod folder

##### Declaration

```
bool FileExistsInModLocation(string file, MyObjectBuilder_Checkpoint.ModItem modItem)
```

##### Parameters

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if file exists |
