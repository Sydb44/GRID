    *   [Vector3L](VRageMath.Vector3L.html "Vector3L")
    *   [Vector3L.EqualityComparer](VRageMath.Vector3L.EqualityComparer.html "Vector3L.EqualityComparer")
    *   [Vector3L\_RangeIterator](VRageMath.Vector3L_RangeIterator.html "Vector3L_RangeIterator")
    *   [Vector3LNormalEqualityComparer](VRageMath.Vector3LNormalEqualityComparer.html "Vector3LNormalEqualityComparer")
    *   [Vector3S](VRageMath.Vector3S.html "Vector3S")
    *   [Vector3UByte](VRageMath.Vector3UByte.html "Vector3UByte")
    *   [Vector3UByte.EqualityComparer](VRageMath.Vector3UByte.EqualityComparer.html "Vector3UByte.EqualityComparer")
    *   [Vector3Ushort](VRageMath.Vector3Ushort.html "Vector3Ushort")
    *   [Vector4](VRageMath.Vector4.html "Vector4")
    *   [Vector4D](VRageMath.Vector4D.html "Vector4D")
    *   [Vector4I](VRageMath.Vector4I.html "Vector4I")
    *   [Vector4I.EqualityComparer](VRageMath.Vector4I.EqualityComparer.html "Vector4I.EqualityComparer")
    *   [Vector4UByte](VRageMath.Vector4UByte.html "Vector4UByte")

# Class MyAPIUtilities

##### Inheritance

System.Object

MyAPIUtilities

##### Implements

[IMyUtilities](VRage.Game.ModAPI.IMyUtilities.html)

[IMyGamePaths](VRage.Game.ModAPI.IMyGamePaths.html)

###### **Namespace**: [Sandbox.ModAPI](Sandbox.ModAPI.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public class MyAPIUtilities : Object, IMyUtilities, IMyGamePaths
```

### [](#constructors)Constructors

#### [](#Sandbox_ModAPI_MyAPIUtilities__ctor)MyAPIUtilities()

##### Declaration

```
public MyAPIUtilities()
```

### [](#fields)Fields

#### [](#Sandbox_ModAPI_MyAPIUtilities_Static)Static

##### Declaration

```
public static readonly MyAPIUtilities Static
```

##### Field Value

Type

Description

[MyAPIUtilities](Sandbox.ModAPI.MyAPIUtilities.html)

#### [](#Sandbox_ModAPI_MyAPIUtilities_Variables)Variables

##### Declaration

```
public Dictionary<string, object> Variables
```

##### Field Value

Type

Description

System.Collections.Generic.Dictionary<System.String, System.Object\>

### [](#methods)Methods

#### [](#Sandbox_ModAPI_MyAPIUtilities_add_MessageEntered_VRage_Game_ModAPI_MessageEnteredDel_)add\_MessageEntered(MessageEnteredDel)

##### Declaration

```
public void add_MessageEntered(MessageEnteredDel value)
```

##### Parameters

Type

Name

Description

[MessageEnteredDel](VRage.Game.ModAPI.MessageEnteredDel.html)

value

#### [](#Sandbox_ModAPI_MyAPIUtilities_add_MessageEnteredSender_VRage_Game_ModAPI_MessageEnteredSenderDel_)add\_MessageEnteredSender(MessageEnteredSenderDel)

##### Declaration

```
public void add_MessageEnteredSender(MessageEnteredSenderDel value)
```

##### Parameters

Type

Name

Description

[MessageEnteredSenderDel](VRage.Game.ModAPI.MessageEnteredSenderDel.html)

value

#### [](#Sandbox_ModAPI_MyAPIUtilities_EnterMessage_System_UInt64_System_String_System_Boolean__)EnterMessage(UInt64, String, ref Boolean)

##### Declaration

```
public void EnterMessage(ulong sender, string messageText, ref bool sendToOthers)
```

##### Parameters

Type

Name

Description

System.UInt64

sender

System.String

messageText

System.Boolean

sendToOthers

#### [](#Sandbox_ModAPI_MyAPIUtilities_EnterMessageSender_System_UInt64_System_String_System_Boolean__)EnterMessageSender(UInt64, String, ref Boolean)

##### Declaration

```
public void EnterMessageSender(ulong sender, string messageText, ref bool sendToOthers)
```

##### Parameters

Type

Name

Description

System.UInt64

sender

System.String

messageText

System.Boolean

sendToOthers

#### [](#Sandbox_ModAPI_MyAPIUtilities_RecieveMessage_System_UInt64_System_String_)RecieveMessage(UInt64, String)

##### Declaration

```
public void RecieveMessage(ulong senderSteamId, string message)
```

##### Parameters

Type

Name

Description

System.UInt64

senderSteamId

System.String

message

#### [](#Sandbox_ModAPI_MyAPIUtilities_RegisterMessageHandler_System_Int64_System_Action_System_Object__)RegisterMessageHandler(Int64, Action<Object>)

##### Declaration

```
public void RegisterMessageHandler(long id, Action<object> messageHandler)
```

##### Parameters

Type

Name

Description

System.Int64

id

System.Action<System.Object\>

messageHandler

#### [](#Sandbox_ModAPI_MyAPIUtilities_remove_MessageEntered_VRage_Game_ModAPI_MessageEnteredDel_)remove\_MessageEntered(MessageEnteredDel)

##### Declaration

```
public void remove_MessageEntered(MessageEnteredDel value)
```

##### Parameters

Type

Name

Description

[MessageEnteredDel](VRage.Game.ModAPI.MessageEnteredDel.html)

value

#### [](#Sandbox_ModAPI_MyAPIUtilities_remove_MessageEnteredSender_VRage_Game_ModAPI_MessageEnteredSenderDel_)remove\_MessageEnteredSender(MessageEnteredSenderDel)

##### Declaration

```
public void remove_MessageEnteredSender(MessageEnteredSenderDel value)
```

##### Parameters

Type

Name

Description

[MessageEnteredSenderDel](VRage.Game.ModAPI.MessageEnteredSenderDel.html)

value

#### [](#Sandbox_ModAPI_MyAPIUtilities_SendModMessage_System_Int64_System_Object_)SendModMessage(Int64, Object)

##### Declaration

```
public void SendModMessage(long id, object payload)
```

##### Parameters

Type

Name

Description

System.Int64

id

System.Object

payload

#### [](#Sandbox_ModAPI_MyAPIUtilities_UnregisterMessageHandler_System_Int64_System_Action_System_Object__)UnregisterMessageHandler(Int64, Action<Object>)

##### Declaration

```
public void UnregisterMessageHandler(long id, Action<object> messageHandler)
```

##### Parameters

Type

Name

Description

System.Int64

id

System.Action<System.Object\>

messageHandler

### [](#events)Events

#### [](#Sandbox_ModAPI_MyAPIUtilities_MessageEntered)MessageEntered

##### Declaration

```
public event MessageEnteredDel MessageEntered
```

##### Event Type

Type

Description

[MessageEnteredDel](VRage.Game.ModAPI.MessageEnteredDel.html)

#### [](#Sandbox_ModAPI_MyAPIUtilities_MessageEnteredSender)MessageEnteredSender

##### Declaration

```
public event MessageEnteredSenderDel MessageEnteredSender
```
