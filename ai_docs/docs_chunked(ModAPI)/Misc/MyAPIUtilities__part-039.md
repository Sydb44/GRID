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

System.IO.TextReader

#### [](#Sandbox_ModAPI_MyAPIUtilities_VRage_Game_ModAPI_IMyUtilities_ReadFileInModLocation_System_String_VRage_Game_MyObjectBuilder_Checkpoint_ModItem_)IMyUtilities.ReadFileInModLocation(String, MyObjectBuilder\_Checkpoint.ModItem)

##### Declaration

```
TextReader IMyUtilities.ReadFileInModLocation(string file, MyObjectBuilder_Checkpoint.ModItem modItem)
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

System.IO.TextReader

#### [](#Sandbox_ModAPI_MyAPIUtilities_VRage_Game_ModAPI_IMyUtilities_ReadFileInWorldStorage_System_String_System_Type_)IMyUtilities.ReadFileInWorldStorage(String, Type)

##### Declaration

```
TextReader IMyUtilities.ReadFileInWorldStorage(string file, Type callingType)
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

System.IO.TextReader

#### [](#Sandbox_ModAPI_MyAPIUtilities_VRage_Game_ModAPI_IMyUtilities_remove_MessageEntered_VRage_Game_ModAPI_MessageEnteredDel_)IMyUtilities.remove\_MessageEntered(MessageEnteredDel)

##### Declaration

```
void IMyUtilities.remove_MessageEntered(MessageEnteredDel value)
```

##### Parameters

Type

Name

Description

[MessageEnteredDel](VRage.Game.ModAPI.MessageEnteredDel.html)

value

#### [](#Sandbox_ModAPI_MyAPIUtilities_VRage_Game_ModAPI_IMyUtilities_RemoveVariable_System_String_)IMyUtilities.RemoveVariable(String)

##### Declaration

```
bool IMyUtilities.RemoveVariable(string name)
```

##### Parameters

Type

Name

Description

System.String

name

##### Returns

Type

Description

System.Boolean

#### [](#Sandbox_ModAPI_MyAPIUtilities_VRage_Game_ModAPI_IMyUtilities_SendMessage_System_String_)IMyUtilities.SendMessage(String)

##### Declaration

```
void IMyUtilities.SendMessage(string messageText)
```

##### Parameters

Type

Name

Description

System.String

messageText

#### [](#Sandbox_ModAPI_MyAPIUtilities_VRage_Game_ModAPI_IMyUtilities_SerializeFromBinary__1_System_Byte___)IMyUtilities.SerializeFromBinary<T>(Byte\[\])

##### Declaration

```
T IMyUtilities.SerializeFromBinary<T>(byte[] data)
```

##### Parameters

Type

Name

Description

System.Byte\[\]

data

##### Returns

Type

Description

T

##### Type Parameters

Name

Description

T

#### [](#Sandbox_ModAPI_MyAPIUtilities_VRage_Game_ModAPI_IMyUtilities_SerializeFromXML__1_System_String_)IMyUtilities.SerializeFromXML<T>(String)

##### Declaration

```
T IMyUtilities.SerializeFromXML<T>(string xml)
```

##### Parameters

Type

Name

Description

System.String

xml

##### Returns

Type

Description

T

##### Type Parameters

Name

Description

T

#### [](#Sandbox_ModAPI_MyAPIUtilities_VRage_Game_ModAPI_IMyUtilities_SerializeToBinary__1___0_)IMyUtilities.SerializeToBinary<T>(T)

##### Declaration

```
byte[] IMyUtilities.SerializeToBinary<T>(T obj)
```

##### Parameters

Type

Name

Description

T

obj

##### Returns

Type

Description

System.Byte\[\]

##### Type Parameters

Name

Description

T

#### [](#Sandbox_ModAPI_MyAPIUtilities_VRage_Game_ModAPI_IMyUtilities_SerializeToXML__1___0_)IMyUtilities.SerializeToXML<T>(T)

##### Declaration

```
string IMyUtilities.SerializeToXML<T>(T objToSerialize)
```

##### Parameters

Type

Name

Description

T

objToSerialize

##### Returns

Type

Description

System.String

##### Type Parameters

Name

Description

T

#### [](#Sandbox_ModAPI_MyAPIUtilities_VRage_Game_ModAPI_IMyUtilities_SetVariable__1_System_String___0_)IMyUtilities.SetVariable<T>(String, T)

##### Declaration

```
void IMyUtilities.SetVariable<T>(string name, T value)
```

##### Parameters

Type

Name

Description

System.String

name

T

value

##### Type Parameters

Name

Description

T

#### [](#Sandbox_ModAPI_MyAPIUtilities_VRage_Game_ModAPI_IMyUtilities_ShowMessage_System_String_System_String_)IMyUtilities.ShowMessage(String, String)

##### Declaration

```
void IMyUtilities.ShowMessage(string sender, string messageText)
```

##### Parameters

Type

Name

Description

System.String

sender

System.String

messageText

#### [](#Sandbox_ModAPI_MyAPIUtilities_VRage_Game_ModAPI_IMyUtilities_ShowMissionScreen_System_String_System_String_System_String_System_String_System_Action_VRage_Game_ModAPI_ResultEnum__System_String_)IMyUtilities.ShowMissionScreen(String, String, String, String, Action<ResultEnum>, String)

##### Declaration

```
void IMyUtilities.ShowMissionScreen(string screenTitle, string currentObjectivePrefix, string currentObjective, string screenDescription, Action<ResultEnum> callback, string okButtonCaption)
```

##### Parameters

Type

Name

Description

System.String

screenTitle

System.String

currentObjectivePrefix

System.String

currentObjective

System.String

screenDescription

System.Action<[ResultEnum](VRage.Game.ModAPI.ResultEnum.html)\>

callback

System.String

okButtonCaption

#### [](#Sandbox_ModAPI_MyAPIUtilities_VRage_Game_ModAPI_IMyUtilities_ShowNotification_System_String_System_Int32_System_String_)IMyUtilities.ShowNotification(String, Int32, String)

##### Declaration

```
void IMyUtilities.ShowNotification(string message, int disappearTimeMs, string font)
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

#### [](#Sandbox_ModAPI_MyAPIUtilities_VRage_Game_ModAPI_IMyUtilities_WriteBinaryFileInGlobalStorage_System_String_)IMyUtilities.WriteBinaryFileInGlobalStorage(String)

##### Declaration

```
BinaryWriter IMyUtilities.WriteBinaryFileInGlobalStorage(string file)
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

System.IO.BinaryWriter

#### [](#Sandbox_ModAPI_MyAPIUtilities_VRage_Game_ModAPI_IMyUtilities_WriteBinaryFileInLocalStorage_System_String_System_Type_)IMyUtilities.WriteBinaryFileInLocalStorage(String, Type)
