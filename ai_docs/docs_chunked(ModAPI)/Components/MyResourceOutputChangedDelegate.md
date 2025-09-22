---
title: "Class MyResourceOutputChangedDelegate"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyResourceOutputChangedDelegate.html"
category: "Components"
namespace: "Sandbox.Game.EntityComponents"
class: "MyResourceOutputChangedDelegate"
---

# Class MyResourceOutputChangedDelegate | Space Engineers ModAPI

##### Inheritance

System.Object

MyResourceOutputChangedDelegate

###### **Namespace**: [Sandbox.Game.EntityComponents](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public sealed class MyResourceOutputChangedDelegate : MulticastDelegate
```

### Constructors

#### MyResourceOutputChangedDelegate(Object, IntPtr)

##### Declaration

```
public MyResourceOutputChangedDelegate(object object, IntPtr method)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | object |     |
| System.IntPtr | method |     |

### Methods

#### BeginInvoke(MyDefinitionId, Single, MyResourceSourceComponent, AsyncCallback, Object)

##### Declaration

```
public virtual IAsyncResult BeginInvoke(MyDefinitionId changedResourceId, float oldOutput, MyResourceSourceComponent source, AsyncCallback callback, object object)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | changedResourceId |     |
| System.Single | oldOutput |     |
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

#### Invoke(MyDefinitionId, Single, MyResourceSourceComponent)

##### Declaration

```
public virtual void Invoke(MyDefinitionId changedResourceId, float oldOutput, MyResourceSourceComponent source)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | changedResourceId |     |
| System.Single | oldOutput |     |
| [MyResourceSourceComponent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyResourceSourceComponent.html) | source |     |