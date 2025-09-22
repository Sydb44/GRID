---
title: "Class MyEntity.CreateDefaultSyncEntityDelegate"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.CreateDefaultSyncEntityDelegate.html"
category: "Misc"
namespace: "VRage.Game.Entity.MyEntity"
class: "CreateDefaultSyncEntityDelegate"
---

# Class MyEntity.CreateDefaultSyncEntityDelegate | Space Engineers ModAPI

##### Inheritance

System.Object

MyEntity.CreateDefaultSyncEntityDelegate

###### **Namespace**: [VRage.Game.Entity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public sealed class CreateDefaultSyncEntityDelegate : MulticastDelegate
```

### Constructors

#### CreateDefaultSyncEntityDelegate(Object, IntPtr)

##### Declaration

```
public CreateDefaultSyncEntityDelegate(object object, IntPtr method)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | object |     |
| System.IntPtr | method |     |

### Methods

#### BeginInvoke(MyEntity, AsyncCallback, Object)

##### Declaration

```
public virtual IAsyncResult BeginInvoke(MyEntity thisEntity, AsyncCallback callback, object object)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) | thisEntity |     |
| System.AsyncCallback | callback |     |
| System.Object | object |     |

##### Returns

| Type | Description |
| --- | --- |
| System.IAsyncResult |     |

#### EndInvoke(IAsyncResult)

##### Declaration

```
public virtual MySyncComponentBase EndInvoke(IAsyncResult result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.IAsyncResult | result |     |

##### Returns

| Type | Description |
| --- | --- |
| [MySyncComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MySyncComponentBase.html) |     |

#### Invoke(MyEntity)

##### Declaration

```
public virtual MySyncComponentBase Invoke(MyEntity thisEntity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) | thisEntity |     |

##### Returns

| Type | Description |
| --- | --- |
| [MySyncComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MySyncComponentBase.html) |     |