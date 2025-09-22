---
title: "Class MyRequiredResourceChangeDelegate"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyRequiredResourceChangeDelegate.html"
category: "Components"
namespace: "Sandbox.Game.EntityComponents"
class: "MyRequiredResourceChangeDelegate"
---

# Class MyRequiredResourceChangeDelegate | Space Engineers ModAPI

##### Inheritance

System.Object

MyRequiredResourceChangeDelegate

###### **Namespace**: [Sandbox.Game.EntityComponents](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public sealed class MyRequiredResourceChangeDelegate : MulticastDelegate
```

### Constructors

#### MyRequiredResourceChangeDelegate(Object, IntPtr)

##### Declaration

```
public MyRequiredResourceChangeDelegate(object object, IntPtr method)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | object |     |
| System.IntPtr | method |     |

### Methods

#### BeginInvoke(MyDefinitionId, MyResourceSinkComponent, Single, Single, AsyncCallback, Object)

##### Declaration

```
public virtual IAsyncResult BeginInvoke(MyDefinitionId changedResourceTypeId, MyResourceSinkComponent sink, float oldRequirement, float newRequirement, AsyncCallback callback, object object)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | changedResourceTypeId |     |
| [MyResourceSinkComponent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyResourceSinkComponent.html) | sink |     |
| System.Single | oldRequirement |     |
| System.Single | newRequirement |     |
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

#### Invoke(MyDefinitionId, MyResourceSinkComponent, Single, Single)

##### Declaration

```
public virtual void Invoke(MyDefinitionId changedResourceTypeId, MyResourceSinkComponent sink, float oldRequirement, float newRequirement)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | changedResourceTypeId |     |
| [MyResourceSinkComponent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyResourceSinkComponent.html) | sink |     |
| System.Single | oldRequirement |     |
| System.Single | newRequirement |     |