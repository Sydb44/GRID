---
title: "Class MyContractActivateDelegate"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyContractActivateDelegate.html"
category: "Misc"
namespace: "VRage.Game.ModAPI"
class: "MyContractActivateDelegate"
---

# Class MyContractActivateDelegate | Space Engineers ModAPI

Delegate used for contract activation.

##### Inheritance

System.Object

MyContractActivateDelegate

###### **Namespace**: [VRage.Game.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public sealed class MyContractActivateDelegate : MulticastDelegate
```

### Constructors

#### MyContractActivateDelegate(Object, IntPtr)

##### Declaration

```
public MyContractActivateDelegate(object object, IntPtr method)
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
public virtual IAsyncResult BeginInvoke(long contractId, long identityId, AsyncCallback callback, object object)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | contractId |     |
| System.Int64 | identityId |     |
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
public virtual void Invoke(long contractId, long identityId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | contractId |     |
| System.Int64 | identityId |     |