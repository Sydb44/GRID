---
title: "Class MyDataReceiver.BroadcasterChangeInfo"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyDataReceiver.BroadcasterChangeInfo.html"
category: "Misc"
namespace: "Sandbox.Game.Entities.MyDataReceiver"
class: "BroadcasterChangeInfo"
---

# Class MyDataReceiver.BroadcasterChangeInfo | Space Engineers ModAPI

##### Inheritance

System.Object

MyDataReceiver.BroadcasterChangeInfo

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public sealed class BroadcasterChangeInfo : MulticastDelegate
```

### [](#constructors)Constructors

#### [](#Sandbox_Game_Entities_MyDataReceiver_BroadcasterChangeInfo__ctor_System_Object_System_IntPtr_)BroadcasterChangeInfo(Object, IntPtr)

##### Declaration

```
public BroadcasterChangeInfo(object object, IntPtr method)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | object |     |
| System.IntPtr | method |     |

### [](#methods)Methods

#### [](#Sandbox_Game_Entities_MyDataReceiver_BroadcasterChangeInfo_BeginInvoke_Sandbox_Game_Entities_MyDataBroadcaster_System_AsyncCallback_System_Object_)BeginInvoke(MyDataBroadcaster, AsyncCallback, Object)

##### Declaration

```
public virtual IAsyncResult BeginInvoke(MyDataBroadcaster broadcaster, AsyncCallback callback, object object)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDataBroadcaster](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyDataBroadcaster.html) | broadcaster |     |
| System.AsyncCallback | callback |     |
| System.Object | object |     |

##### Returns

| Type | Description |
| --- | --- |
| System.IAsyncResult |     |

#### [](#Sandbox_Game_Entities_MyDataReceiver_BroadcasterChangeInfo_EndInvoke_System_IAsyncResult_)EndInvoke(IAsyncResult)

##### Declaration

```
public virtual void EndInvoke(IAsyncResult result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.IAsyncResult | result |     |

#### [](#Sandbox_Game_Entities_MyDataReceiver_BroadcasterChangeInfo_Invoke_Sandbox_Game_Entities_MyDataBroadcaster_)Invoke(MyDataBroadcaster)

##### Declaration

```
public virtual void Invoke(MyDataBroadcaster broadcaster)
```

##### Parameters