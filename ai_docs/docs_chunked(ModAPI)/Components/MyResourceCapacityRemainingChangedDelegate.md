---
title: "Class MyResourceCapacityRemainingChangedDelegate"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyResourceCapacityRemainingChangedDelegate.html"
category: "Components"
namespace: "Sandbox.Game.EntityComponents"
class: "MyResourceCapacityRemainingChangedDelegate"
---

# Class MyResourceCapacityRemainingChangedDelegate | Space Engineers ModAPI

##### Inheritance

System.Object

MyResourceCapacityRemainingChangedDelegate

###### **Namespace**: [Sandbox.Game.EntityComponents](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public sealed class MyResourceCapacityRemainingChangedDelegate : MulticastDelegate
```

### Constructors

#### MyResourceCapacityRemainingChangedDelegate(Object, IntPtr)

##### Declaration

```
public MyResourceCapacityRemainingChangedDelegate(object object, IntPtr method)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | object |     |
| System.IntPtr | method |     |

### Methods

#### BeginInvoke(MyDefinitionId, MyResourceSourceComponent, AsyncCallback, Object)

##### Declaration

```
public virtual IAsyncResult BeginInvoke(MyDefinitionId changedResourceId, MyResourceSourceComponent source, AsyncCallback callback, object object)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | changedResourceId |     |
| [MyResourceSourceComponent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyResourceSourceComponent.html) | source |     |
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

#### Invoke(MyDefinitionId, MyResourceSourceComponent)

##### Declaration

```
public virtual void Invoke(MyDefinitionId changedResourceId, MyResourceSourceComponent source)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | changedResourceId |     |
| [MyResourceSourceComponent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyResourceSourceComponent.html) | source |     |