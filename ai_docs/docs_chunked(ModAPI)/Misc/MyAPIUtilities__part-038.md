Type

Description

System.Boolean

#### [](#Sandbox_ModAPI_MyAPIUtilities_VRage_Game_ModAPI_IMyUtilities_FileExistsInWorldStorage_System_String_System_Type_)IMyUtilities.FileExistsInWorldStorage(String, Type)

##### Declaration

```
bool IMyUtilities.FileExistsInWorldStorage(string file, Type callingType)
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

#### [](#Sandbox_ModAPI_MyAPIUtilities_VRage_Game_ModAPI_IMyUtilities_GamePaths)IMyUtilities.GamePaths

##### Declaration

```
IMyGamePaths IMyUtilities.GamePaths { get; }
```

##### Returns

Type

Description

[IMyGamePaths](VRage.Game.ModAPI.IMyGamePaths.html)

#### [](#Sandbox_ModAPI_MyAPIUtilities_VRage_Game_ModAPI_IMyUtilities_GetObjectiveLine)IMyUtilities.GetObjectiveLine()

##### Declaration

```
IMyHudObjectiveLine IMyUtilities.GetObjectiveLine()
```

##### Returns

Type

Description

[IMyHudObjectiveLine](VRage.Game.ModAPI.IMyHudObjectiveLine.html)

#### [](#Sandbox_ModAPI_MyAPIUtilities_VRage_Game_ModAPI_IMyUtilities_GetTypeName_System_Type_)IMyUtilities.GetTypeName(Type)

##### Declaration

```
string IMyUtilities.GetTypeName(Type type)
```

##### Parameters

Type

Name

Description

System.Type

type

##### Returns

Type

Description

System.String

#### [](#Sandbox_ModAPI_MyAPIUtilities_VRage_Game_ModAPI_IMyUtilities_GetVariable__1_System_String___0__)IMyUtilities.GetVariable<T>(String, out T)

##### Declaration

```
bool IMyUtilities.GetVariable<T>(string name, out T value)
```

##### Parameters

Type

Name

Description

System.String

name

T

value

##### Returns

Type

Description

System.Boolean

##### Type Parameters

Name

Description

T

#### [](#Sandbox_ModAPI_MyAPIUtilities_VRage_Game_ModAPI_IMyUtilities_InvokeOnGameThread_System_Action_System_String_System_Int32_System_Int32_)IMyUtilities.InvokeOnGameThread(Action, String, Int32, Int32)

##### Declaration

```
void IMyUtilities.InvokeOnGameThread(Action action, string invokerName, int StartAt, int RepeatTimes)
```

##### Parameters

Type

Name

Description

System.Action

action

System.String

invokerName

System.Int32

StartAt

System.Int32

RepeatTimes

#### [](#Sandbox_ModAPI_MyAPIUtilities_VRage_Game_ModAPI_IMyUtilities_IsDedicated)IMyUtilities.IsDedicated

##### Declaration

```
bool IMyUtilities.IsDedicated { get; }
```

##### Returns

Type

Description

System.Boolean

#### [](#Sandbox_ModAPI_MyAPIUtilities_VRage_Game_ModAPI_IMyUtilities_MessageRecieved)IMyUtilities.MessageRecieved

##### Declaration

```
event Action<ulong, string> IMyUtilities.MessageRecieved
```

##### Returns

Type

Description

System.Action<System.UInt64, System.String\>

#### [](#Sandbox_ModAPI_MyAPIUtilities_VRage_Game_ModAPI_IMyUtilities_ReadBinaryFileInGameContent_System_String_)IMyUtilities.ReadBinaryFileInGameContent(String)

##### Declaration

```
BinaryReader IMyUtilities.ReadBinaryFileInGameContent(string file)
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

System.IO.BinaryReader

#### [](#Sandbox_ModAPI_MyAPIUtilities_VRage_Game_ModAPI_IMyUtilities_ReadBinaryFileInGlobalStorage_System_String_)IMyUtilities.ReadBinaryFileInGlobalStorage(String)

##### Declaration

```
BinaryReader IMyUtilities.ReadBinaryFileInGlobalStorage(string file)
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

System.IO.BinaryReader

#### [](#Sandbox_ModAPI_MyAPIUtilities_VRage_Game_ModAPI_IMyUtilities_ReadBinaryFileInLocalStorage_System_String_System_Type_)IMyUtilities.ReadBinaryFileInLocalStorage(String, Type)

##### Declaration

```
BinaryReader IMyUtilities.ReadBinaryFileInLocalStorage(string file, Type callingType)
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

System.IO.BinaryReader

#### [](#Sandbox_ModAPI_MyAPIUtilities_VRage_Game_ModAPI_IMyUtilities_ReadBinaryFileInModLocation_System_String_VRage_Game_MyObjectBuilder_Checkpoint_ModItem_)IMyUtilities.ReadBinaryFileInModLocation(String, MyObjectBuilder\_Checkpoint.ModItem)

##### Declaration

```
BinaryReader IMyUtilities.ReadBinaryFileInModLocation(string file, MyObjectBuilder_Checkpoint.ModItem modItem)
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

System.IO.BinaryReader

#### [](#Sandbox_ModAPI_MyAPIUtilities_VRage_Game_ModAPI_IMyUtilities_ReadBinaryFileInWorldStorage_System_String_System_Type_)IMyUtilities.ReadBinaryFileInWorldStorage(String, Type)

##### Declaration

```
BinaryReader IMyUtilities.ReadBinaryFileInWorldStorage(string file, Type callingType)
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

System.IO.BinaryReader

#### [](#Sandbox_ModAPI_MyAPIUtilities_VRage_Game_ModAPI_IMyUtilities_ReadFileInGameContent_System_String_)IMyUtilities.ReadFileInGameContent(String)

##### Declaration

```
TextReader IMyUtilities.ReadFileInGameContent(string file)
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

System.IO.TextReader

#### [](#Sandbox_ModAPI_MyAPIUtilities_VRage_Game_ModAPI_IMyUtilities_ReadFileInGlobalStorage_System_String_)IMyUtilities.ReadFileInGlobalStorage(String)

##### Declaration

```
TextReader IMyUtilities.ReadFileInGlobalStorage(string file)
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

System.IO.TextReader

#### [](#Sandbox_ModAPI_MyAPIUtilities_VRage_Game_ModAPI_IMyUtilities_ReadFileInLocalStorage_System_String_System_Type_)IMyUtilities.ReadFileInLocalStorage(String, Type)

##### Declaration

```
TextReader IMyUtilities.ReadFileInLocalStorage(string file, Type callingType)
```

##### Parameters

Type

Name

Description

System.String

file

System.Type

callingType
