---
title: "Class MyContractUpdateDelegate"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyContractUpdateDelegate.html"
category: "Misc"
namespace: "VRage.Game.ModAPI"
class: "MyContractUpdateDelegate"
---

# Class MyContractUpdateDelegate | Space Engineers ModAPI

Delegate used for custom update event.

##### Inheritance

System.Object

MyContractUpdateDelegate

###### **Namespace**: [VRage.Game.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public sealed class MyContractUpdateDelegate : MulticastDelegate
```

### Constructors

#### MyContractUpdateDelegate(Object, IntPtr)

##### Declaration

```
public MyContractUpdateDelegate(object object, IntPtr method)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | object |     |
| System.IntPtr | method |     |

### Methods

#### BeginInvoke(Int64, MyCustomContractStateEnum, MyTimeSpan, AsyncCallback, Object)

##### Declaration

```
public virtual IAsyncResult BeginInvoke(long contractId, MyCustomContractStateEnum newState, MyTimeSpan currentTime, AsyncCallback callback, object object)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | contractId |     |
| [MyCustomContractStateEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyCustomContractStateEnum.html) | newState |     |
| [MyTimeSpan](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Library.Utils.MyTimeSpan.html) | currentTime |     |
| System.AsyncCallback | callback |     |
| System.Object | object |     |

##### Returns

| Type | Description |
| --- | --- |
| System.IAsyncResult |     |

#### EndInvoke(IAsyncResult)

##### Declaration

```
public virtual void EndInvoke(IAsyncResult result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.IAsyncResult | result |     |

#### Invoke(Int64, MyCustomContractStateEnum, MyTimeSpan)

##### Declaration

```
public virtual void Invoke(long contractId, MyCustomContractStateEnum newState, MyTimeSpan currentTime)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | contractId |     |
| [MyCustomContractStateEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyCustomContractStateEnum.html) | newState |     |
| [MyTimeSpan](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Library.Utils.MyTimeSpan.html) | currentTime |     |