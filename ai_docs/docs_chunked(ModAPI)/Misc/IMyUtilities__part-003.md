```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | file | Relative file path |

##### Returns

| Type | Description |
| --- | --- |
| System.IO.TextReader | Text reader |

#### [](#VRage_Game_ModAPI_IMyUtilities_ReadFileInGlobalStorage_System_String_)ReadFileInGlobalStorage(String)

Reads text file from global storage %APPDATA%/Roaming/SpaceEngineers/Storage

##### Declaration

```
TextReader ReadFileInGlobalStorage(string file)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | file | Relative file path |

##### Returns

| Type | Description |
| --- | --- |
| System.IO.TextReader | Text reader |

#### [](#VRage_Game_ModAPI_IMyUtilities_ReadFileInLocalStorage_System_String_System_Type_)ReadFileInLocalStorage(String, Type)

Reads text file from local storage %APPDATA%/Roaming/SpaceEngineers/Storage/{Assembly Scope}

##### Declaration

```
TextReader ReadFileInLocalStorage(string file, Type callingType)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | file | Relative file path |
| System.Type | callingType | Use any of your mod classes |

##### Returns

| Type | Description |
| --- | --- |
| System.IO.TextReader | Text reader |

#### [](#VRage_Game_ModAPI_IMyUtilities_ReadFileInModLocation_System_String_VRage_Game_MyObjectBuilder_Checkpoint_ModItem_)ReadFileInModLocation(String, MyObjectBuilder\_Checkpoint.ModItem)

Reads text file from the specified mod's directory.

##### Declaration

```
TextReader ReadFileInModLocation(string file, MyObjectBuilder_Checkpoint.ModItem modItem)
```

##### Parameters

##### Returns

| Type | Description |
| --- | --- |
| System.IO.TextReader | Text reader |

#### [](#VRage_Game_ModAPI_IMyUtilities_ReadFileInWorldStorage_System_String_System_Type_)ReadFileInWorldStorage(String, Type)

Read text file from world storage %APPDATA%/Roaming/SpaceEngineers/Save/{SteamId}/{WorldName}/Storage/{Assembly Scope}

##### Declaration

```
TextReader ReadFileInWorldStorage(string file, Type callingType)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | file | Relative file path |
| System.Type | callingType | Use any of your mod classes |

##### Returns

| Type | Description |
| --- | --- |
| System.IO.TextReader | Text reader |

#### [](#VRage_Game_ModAPI_IMyUtilities_RegisterMessageHandler_System_Int64_System_Action_System_Object__)RegisterMessageHandler(Int64, Action<Object>)

Adds a handler to the mod message system.

##### Declaration

```
void RegisterMessageHandler(long id, Action<object> messageHandler)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | id  | Id of handler |
| System.Action<System.Object\> | messageHandler | Function that would be called |

##### See Also

#### [](#VRage_Game_ModAPI_IMyUtilities_remove_MessageEntered_VRage_Game_ModAPI_MessageEnteredDel_)remove\_MessageEntered(MessageEnteredDel)

##### Declaration

```
void remove_MessageEntered(MessageEnteredDel value)
```

##### Parameters

#### [](#VRage_Game_ModAPI_IMyUtilities_remove_MessageEnteredSender_VRage_Game_ModAPI_MessageEnteredSenderDel_)remove\_MessageEnteredSender(MessageEnteredSenderDel)

##### Declaration

```
void remove_MessageEnteredSender(MessageEnteredSenderDel value)
```

##### Parameters

#### [](#VRage_Game_ModAPI_IMyUtilities_RemoveVariable_System_String_)RemoveVariable(String)

Unregisters variable

##### Declaration

```
bool RemoveVariable(string name)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | name | Name of variable |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if it existed before this call |

##### See Also

#### [](#VRage_Game_ModAPI_IMyUtilities_SendMessage_System_String_)SendMessage(String)

Send message to other players

##### Declaration

```
void SendMessage(string messageText)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | messageText | Text of message |

#### [](#VRage_Game_ModAPI_IMyUtilities_SendModMessage_System_Int64_System_Object_)SendModMessage(Int64, Object)

Allows passing data between mods on the same client.

##### Declaration

```
void SendModMessage(long id, object payload)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | id  | Id of handler |
| System.Object | payload | Message that would be sent. Can be any type |

##### See Also

#### [](#VRage_Game_ModAPI_IMyUtilities_SerializeFromBinary__1_System_Byte___)SerializeFromBinary<T>(Byte\[\])

Uses ProtoBuf to deserialize an object from a byte array.

##### Declaration

```
T SerializeFromBinary<T>(byte[] data)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Byte\[\] | data | Object serialized as bytes |

##### Returns

| Type | Description |
| --- | --- |
| T   | Deserialized object |

##### Type Parameters

#### [](#VRage_Game_ModAPI_IMyUtilities_SerializeFromXML__1_System_String_)SerializeFromXML<T>(String)

##### Declaration

```
T SerializeFromXML<T>(string buffer)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | buffer | Xml |

##### Returns

| Type | Description |
| --- | --- |
| T   | Object of desired T |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   | Type of object you have been serializing to |

#### [](#VRage_Game_ModAPI_IMyUtilities_SerializeToBinary__1___0_)SerializeToBinary<T>(T)

Uses ProtoBuf to serialize an object into a byte array. You need mark class with **\[ProtoContract\]** and each member that you wish to serialize with **\[ProtoMember(uniqId)\]**

##### Declaration

```
byte[] SerializeToBinary<T>(T obj)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| T   | obj | Object to serialize |

##### Returns

| Type | Description |
| --- | --- |
| System.Byte\[\] | Object serialized as bytes |

##### Type Parameters
