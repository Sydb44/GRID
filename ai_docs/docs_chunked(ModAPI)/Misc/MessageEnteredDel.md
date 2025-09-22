---
title: "Class MessageEnteredDel"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MessageEnteredDel.html"
category: "Misc"
namespace: "VRage.Game.ModAPI"
class: "MessageEnteredDel"
---

# Class MessageEnteredDel | Space Engineers ModAPI

##### Inheritance

System.Object

MessageEnteredDel

###### **Namespace**: [VRage.Game.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public sealed class MessageEnteredDel : MulticastDelegate
```

### [](#constructors)Constructors

#### [](#VRage_Game_ModAPI_MessageEnteredDel__ctor_System_Object_System_IntPtr_)MessageEnteredDel(Object, IntPtr)

##### Declaration

```
public MessageEnteredDel(object object, IntPtr method)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | object |     |
| System.IntPtr | method |     |

### [](#methods)Methods

#### [](#VRage_Game_ModAPI_MessageEnteredDel_BeginInvoke_System_String_System_Boolean__System_AsyncCallback_System_Object_)BeginInvoke(String, ref Boolean, AsyncCallback, Object)

##### Declaration

```
public virtual IAsyncResult BeginInvoke(string messageText, ref bool sendToOthers, AsyncCallback callback, object object)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | messageText |     |
| System.Boolean | sendToOthers |     |
| System.AsyncCallback | callback |     |
| System.Object | object |     |

##### Returns

| Type | Description |
| --- | --- |
| System.IAsyncResult |     |

#### [](#VRage_Game_ModAPI_MessageEnteredDel_EndInvoke_System_Boolean__System_IAsyncResult_)EndInvoke(ref Boolean, IAsyncResult)

##### Declaration

```
public virtual void EndInvoke(ref bool sendToOthers, IAsyncResult result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | sendToOthers |     |
| System.IAsyncResult | result |     |

#### [](#VRage_Game_ModAPI_MessageEnteredDel_Invoke_System_String_System_Boolean__)Invoke(String, ref Boolean)

##### Declaration

```
public virtual void Invoke(string messageText, ref bool sendToOthers)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | messageText |     |
| System.Boolean | sendToOthers |     |