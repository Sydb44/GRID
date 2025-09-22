---
title: "Class MyCurrentResourceInputChangedDelegate"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyCurrentResourceInputChangedDelegate.html"
category: "Components"
namespace: "Sandbox.Game.EntityComponents"
class: "MyCurrentResourceInputChangedDelegate"
---

# Class MyCurrentResourceInputChangedDelegate | Space Engineers ModAPI

##### Inheritance

System.Object

MyCurrentResourceInputChangedDelegate

###### **Namespace**: [Sandbox.Game.EntityComponents](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public sealed class MyCurrentResourceInputChangedDelegate : MulticastDelegate
```

### Constructors

#### MyCurrentResourceInputChangedDelegate(Object, IntPtr)

##### Declaration

```
public MyCurrentResourceInputChangedDelegate(object object, IntPtr method)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | object |     |
| System.IntPtr | method |     |

### Methods

#### BeginInvoke(MyDefinitionId, Single, MyResourceSinkComponent, AsyncCallback, Object)

##### Declaration

```
public virtual IAsyncResult BeginInvoke(MyDefinitionId resourceTypeId, float oldInput, MyResourceSinkComponent sink, AsyncCallback callback, object object)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | resourceTypeId |     |
| System.Single | oldInput |     |
| [MyResourceSinkComponent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyResourceSinkComponent.html) | sink |     |
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

#### Invoke(MyDefinitionId, Single, MyResourceSinkComponent)

##### Declaration

```
public virtual void Invoke(MyDefinitionId resourceTypeId, float oldInput, MyResourceSinkComponent sink)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | resourceTypeId |     |
| System.Single | oldInput |     |
| [MyResourceSinkComponent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyResourceSinkComponent.html) | sink |     |