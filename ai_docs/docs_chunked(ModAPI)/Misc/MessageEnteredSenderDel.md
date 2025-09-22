---
title: "Class MessageEnteredSenderDel"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MessageEnteredSenderDel.html"
category: "Misc"
namespace: "VRage.Game.ModAPI"
class: "MessageEnteredSenderDel"
---

# Class MessageEnteredSenderDel | Space Engineers ModAPI

##### Inheritance

System.Object

MessageEnteredSenderDel

###### **Namespace**: [VRage.Game.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public sealed class MessageEnteredSenderDel : MulticastDelegate
```

### [](#constructors)Constructors

#### [](#VRage_Game_ModAPI_MessageEnteredSenderDel__ctor_System_Object_System_IntPtr_)MessageEnteredSenderDel(Object, IntPtr)

##### Declaration

```
public MessageEnteredSenderDel(object object, IntPtr method)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | object |     |
| System.IntPtr | method |     |

### [](#methods)Methods

#### [](#VRage_Game_ModAPI_MessageEnteredSenderDel_BeginInvoke_System_UInt64_System_String_System_Boolean__System_AsyncCallback_System_Object_)BeginInvoke(UInt64, String, ref Boolean, AsyncCallback, Object)

##### Declaration

```
public virtual IAsyncResult BeginInvoke(ulong sender, string messageText, ref bool sendToOthers, AsyncCallback callback, object object)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.UInt64 | sender |     |
| System.String | messageText |     |
| System.Boolean | sendToOthers |     |
| System.AsyncCallback | callback |     |
| System.Object | object |     |

##### Returns

| Type | Description |
| --- | --- |
| System.IAsyncResult |     |

#### [](#VRage_Game_ModAPI_MessageEnteredSenderDel_EndInvoke_System_Boolean__System_IAsyncResult_)EndInvoke(ref Boolean, IAsyncResult)

##### Declaration

```
public virtual void EndInvoke(ref bool sendToOthers, IAsyncResult result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | sendToOthers |     |
| System.IAsyncResult | result |     |

#### [](#VRage_Game_ModAPI_MessageEnteredSenderDel_Invoke_System_UInt64_System_String_System_Boolean__)Invoke(UInt64, String, ref Boolean)

##### Declaration

```
public virtual void Invoke(ulong sender, string messageText, ref bool sendToOthers)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.UInt64 | sender |     |
| System.String | messageText |     |
| System.Boolean | sendToOthers |     |