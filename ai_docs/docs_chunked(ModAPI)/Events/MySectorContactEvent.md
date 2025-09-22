---
title: "Class MySectorContactEvent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.MySectorContactEvent.html"
category: "Events"
namespace: "Sandbox.Game.WorldEnvironment"
class: "MySectorContactEvent"
---

# Class MySectorContactEvent | Space Engineers ModAPI

##### Inheritance

System.Object

MySectorContactEvent

###### **Namespace**: [Sandbox.Game.WorldEnvironment](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public sealed class MySectorContactEvent : MulticastDelegate
```

### Constructors

#### MySectorContactEvent(Object, IntPtr)

##### Declaration

```
public MySectorContactEvent(object object, IntPtr method)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | object |     |
| System.IntPtr | method |     |

### Methods

#### BeginInvoke(Int32, MyEntity, ref MyPhysics.MyContactPointEvent, AsyncCallback, Object)

##### Declaration

```
public virtual IAsyncResult BeginInvoke(int itemId, MyEntity other, ref MyPhysics.MyContactPointEvent evt, AsyncCallback callback, object object)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | itemId |     |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) | other |     |
| Sandbox.Engine.Physics.MyPhysics.MyContactPointEvent | evt |     |
| System.AsyncCallback | callback |     |
| System.Object | object |     |

##### Returns

| Type | Description |
| --- | --- |
| System.IAsyncResult |     |

#### EndInvoke(ref MyPhysics.MyContactPointEvent, IAsyncResult)

##### Declaration

```
public virtual void EndInvoke(ref MyPhysics.MyContactPointEvent evt, IAsyncResult result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| Sandbox.Engine.Physics.MyPhysics.MyContactPointEvent | evt |     |
| System.IAsyncResult | result |     |

#### Invoke(Int32, MyEntity, ref MyPhysics.MyContactPointEvent)

##### Declaration

```
public virtual void Invoke(int itemId, MyEntity other, ref MyPhysics.MyContactPointEvent evt)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | itemId |     |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) | other |     |
| Sandbox.Engine.Physics.MyPhysics.MyContactPointEvent | evt |     |