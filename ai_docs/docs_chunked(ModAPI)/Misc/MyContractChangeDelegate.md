---
title: "Class MyContractChangeDelegate"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyContractChangeDelegate.html"
category: "Misc"
namespace: "VRage.Game.ModAPI"
class: "MyContractChangeDelegate"
---

# Class MyContractChangeDelegate | Space Engineers ModAPI

Delegate used for various events related with contract state change.

##### Inheritance

System.Object

MyContractChangeDelegate

###### **Namespace**: [VRage.Game.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public sealed class MyContractChangeDelegate : MulticastDelegate
```

### Constructors

#### MyContractChangeDelegate(Object, IntPtr)

##### Declaration

```
public MyContractChangeDelegate(object object, IntPtr method)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | object |     |
| System.IntPtr | method |     |

### Methods

#### BeginInvoke(Int64, AsyncCallback, Object)

##### Declaration

```
public virtual IAsyncResult BeginInvoke(long contractId, AsyncCallback callback, object object)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
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

#### Invoke(Int64)

##### Declaration

```
public virtual void Invoke(long contractId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | contractId |     |