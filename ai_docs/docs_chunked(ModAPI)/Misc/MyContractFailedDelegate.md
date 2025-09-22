---
title: "Class MyContractFailedDelegate"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyContractFailedDelegate.html"
category: "Misc"
namespace: "VRage.Game.ModAPI"
class: "MyContractFailedDelegate"
---

# Class MyContractFailedDelegate | Space Engineers ModAPI

Delegate used for event of contract failure.

##### Inheritance

System.Object

MyContractFailedDelegate

###### **Namespace**: [VRage.Game.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public sealed class MyContractFailedDelegate : MulticastDelegate
```

### Constructors

#### MyContractFailedDelegate(Object, IntPtr)

##### Declaration

```
public MyContractFailedDelegate(object object, IntPtr method)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | object |     |
| System.IntPtr | method |     |

### Methods

#### BeginInvoke(Int64, Int64, Boolean, AsyncCallback, Object)

##### Declaration

```
public virtual IAsyncResult BeginInvoke(long contractId, long identityId, bool isAbandon, AsyncCallback callback, object object)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | contractId |     |
| System.Int64 | identityId |     |
| System.Boolean | isAbandon |     |
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

#### Invoke(Int64, Int64, Boolean)

##### Declaration

```
public virtual void Invoke(long contractId, long identityId, bool isAbandon)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | contractId |     |
| System.Int64 | identityId |     |
| System.Boolean | isAbandon |     |