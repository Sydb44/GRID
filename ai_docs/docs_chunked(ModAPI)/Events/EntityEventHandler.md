---
title: "Class MyEntityContainerEventExtensions.EntityEventHandler"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyEntityContainerEventExtensions.EntityEventHandler.html"
category: "Events"
namespace: "VRage.Game.Components.MyEntityContainerEventExtensions"
class: "EntityEventHandler"
---

# Class MyEntityContainerEventExtensions.EntityEventHandler | Space Engineers ModAPI

Handler to be called on event

##### Inheritance

System.Object

MyEntityContainerEventExtensions.EntityEventHandler

###### **Namespace**: [VRage.Game.Components](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public sealed class EntityEventHandler : MulticastDelegate
```

### Constructors

#### EntityEventHandler(Object, IntPtr)

##### Declaration

```
public EntityEventHandler(object object, IntPtr method)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | object |     |
| System.IntPtr | method |     |

### Methods

#### BeginInvoke(MyEntityContainerEventExtensions.EntityEventParams, AsyncCallback, Object)

##### Declaration

```
public virtual IAsyncResult BeginInvoke(MyEntityContainerEventExtensions.EntityEventParams eventParams, AsyncCallback callback, object object)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEntityContainerEventExtensions.EntityEventParams](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyEntityContainerEventExtensions.EntityEventParams.html) | eventParams |     |
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

#### Invoke(MyEntityContainerEventExtensions.EntityEventParams)

##### Declaration

```
public virtual void Invoke(MyEntityContainerEventExtensions.EntityEventParams eventParams)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEntityContainerEventExtensions.EntityEventParams](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyEntityContainerEventExtensions.EntityEventParams.html) | eventParams |     |