---
title: "Class MyContractConditionDelegate"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyContractConditionDelegate.html"
category: "Misc"
namespace: "VRage.Game.ModAPI"
class: "MyContractConditionDelegate"
---

# Class MyContractConditionDelegate | Space Engineers ModAPI

Delegate used for contract condition finished.

##### Inheritance

System.Object

MyContractConditionDelegate

###### **Namespace**: [VRage.Game.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public sealed class MyContractConditionDelegate : MulticastDelegate
```

### Constructors

#### MyContractConditionDelegate(Object, IntPtr)

##### Declaration

```
public MyContractConditionDelegate(object object, IntPtr method)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | object |     |
| System.IntPtr | method |     |

### Methods

#### BeginInvoke(Int64, Int64, AsyncCallback, Object)

##### Declaration

```
public virtual IAsyncResult BeginInvoke(long conditionId, long contractId, AsyncCallback callback, object object)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | conditionId |     |
| System.Int64 | contractId |     |
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

#### Invoke(Int64, Int64)

##### Declaration

```
public virtual void Invoke(long conditionId, long contractId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | conditionId |     |
| System.Int64 | contractId |     |