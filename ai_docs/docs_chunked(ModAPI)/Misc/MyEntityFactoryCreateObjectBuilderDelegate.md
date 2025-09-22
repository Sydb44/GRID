---
title: "Class MyEntity.MyEntityFactoryCreateObjectBuilderDelegate"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.MyEntityFactoryCreateObjectBuilderDelegate.html"
category: "Misc"
namespace: "VRage.Game.Entity.MyEntity"
class: "MyEntityFactoryCreateObjectBuilderDelegate"
---

# Class MyEntity.MyEntityFactoryCreateObjectBuilderDelegate | Space Engineers ModAPI

##### Inheritance

System.Object

MyEntity.MyEntityFactoryCreateObjectBuilderDelegate

###### **Namespace**: [VRage.Game.Entity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public sealed class MyEntityFactoryCreateObjectBuilderDelegate : MulticastDelegate
```

### Constructors

#### MyEntityFactoryCreateObjectBuilderDelegate(Object, IntPtr)

##### Declaration

```
public MyEntityFactoryCreateObjectBuilderDelegate(object object, IntPtr method)
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
public virtual MyObjectBuilder_EntityBase EndInvoke(IAsyncResult result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.IAsyncResult | result |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_EntityBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_EntityBase.html) |     |

#### Invoke(MyEntity)

##### Declaration

```
public virtual MyObjectBuilder_EntityBase Invoke(MyEntity entity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) | entity |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_EntityBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_EntityBase.html) |     |