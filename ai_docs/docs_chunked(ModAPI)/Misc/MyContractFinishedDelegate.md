---
title: "Class MyContractFinishedDelegate"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyContractFinishedDelegate.html"
category: "Misc"
namespace: "VRage.Game.ModAPI"
class: "MyContractFinishedDelegate"
---

# Class MyContractFinishedDelegate | Space Engineers ModAPI

Delegate used for event triggered when contract is finished.

##### Inheritance

System.Object

MyContractFinishedDelegate

###### **Namespace**: [VRage.Game.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public sealed class MyContractFinishedDelegate : MulticastDelegate
```

### Constructors

#### MyContractFinishedDelegate(Object, IntPtr)

##### Declaration

```
public MyContractFinishedDelegate(object object, IntPtr method)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | object |     |
| System.IntPtr | method |     |

### Methods

#### BeginInvoke(Int64, Int64, Int32, AsyncCallback, Object)

##### Declaration

```
public virtual IAsyncResult BeginInvoke(long contractId, long identityId, int rewardeeCount, AsyncCallback callback, object object)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | contractId |     |
| System.Int64 | identityId |     |
| System.Int32 | rewardeeCount |     |
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

#### Invoke(Int64, Int64, Int32)

##### Declaration

```
public virtual void Invoke(long contractId, long identityId, int rewardeeCount)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | contractId |     |
| System.Int64 | identityId |     |
| System.Int32 | rewardeeCount |     |