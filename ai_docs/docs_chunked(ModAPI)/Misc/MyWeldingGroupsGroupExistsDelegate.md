---
title: "Class MyEntity.MyWeldingGroupsGroupExistsDelegate"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.MyWeldingGroupsGroupExistsDelegate.html"
category: "Misc"
namespace: "VRage.Game.Entity.MyEntity"
class: "MyWeldingGroupsGroupExistsDelegate"
---

# Class MyEntity.MyWeldingGroupsGroupExistsDelegate | Space Engineers ModAPI

##### Inheritance

System.Object

MyEntity.MyWeldingGroupsGroupExistsDelegate

###### **Namespace**: [VRage.Game.Entity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public sealed class MyWeldingGroupsGroupExistsDelegate : MulticastDelegate
```

### Constructors

#### MyWeldingGroupsGroupExistsDelegate(Object, IntPtr)

##### Declaration

```
public MyWeldingGroupsGroupExistsDelegate(object object, IntPtr method)
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
public virtual IAsyncResult BeginInvoke(MyEntity entity, AsyncCallback callback, object object)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) | entity |     |
| System.AsyncCallback | callback |     |
| System.Object | object |     |

##### Returns

| Type | Description |
| --- | --- |
| System.IAsyncResult |     |

#### EndInvoke(IAsyncResult)

##### Declaration

```
public virtual bool EndInvoke(IAsyncResult result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.IAsyncResult | result |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Invoke(MyEntity)

##### Declaration

```
public virtual bool Invoke(MyEntity entity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) | entity |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |