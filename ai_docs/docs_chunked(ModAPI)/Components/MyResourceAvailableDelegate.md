---
title: "Class MyResourceAvailableDelegate"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyResourceAvailableDelegate.html"
category: "Components"
namespace: "Sandbox.Game.EntityComponents"
class: "MyResourceAvailableDelegate"
---

# Class MyResourceAvailableDelegate | Space Engineers ModAPI

##### Inheritance

System.Object

MyResourceAvailableDelegate

###### **Namespace**: [Sandbox.Game.EntityComponents](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public sealed class MyResourceAvailableDelegate : MulticastDelegate
```

### Constructors

#### MyResourceAvailableDelegate(Object, IntPtr)

##### Declaration

```
public MyResourceAvailableDelegate(object object, IntPtr method)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | object |     |
| System.IntPtr | method |     |

### Methods

#### BeginInvoke(MyDefinitionId, MyResourceSinkComponent, AsyncCallback, Object)

##### Declaration

```
public virtual IAsyncResult BeginInvoke(MyDefinitionId resourceTypeId, MyResourceSinkComponent sink, AsyncCallback callback, object object)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | resourceTypeId |     |
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
public virtual float EndInvoke(IAsyncResult result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.IAsyncResult | result |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### Invoke(MyDefinitionId, MyResourceSinkComponent)

##### Declaration

```
public virtual float Invoke(MyDefinitionId resourceTypeId, MyResourceSinkComponent sink)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | resourceTypeId |     |
| [MyResourceSinkComponent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyResourceSinkComponent.html) | sink |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |