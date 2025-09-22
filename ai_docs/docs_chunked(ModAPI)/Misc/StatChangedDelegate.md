---
title: "Class MyEntityStat.StatChangedDelegate"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntityStat.StatChangedDelegate.html"
category: "Misc"
namespace: "Sandbox.Game.Entities.MyEntityStat"
class: "StatChangedDelegate"
---

# Class MyEntityStat.StatChangedDelegate | Space Engineers ModAPI

##### Inheritance

System.Object

MyEntityStat.StatChangedDelegate

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public sealed class StatChangedDelegate : MulticastDelegate
```

### [](#constructors)Constructors

#### [](#Sandbox_Game_Entities_MyEntityStat_StatChangedDelegate__ctor_System_Object_System_IntPtr_)StatChangedDelegate(Object, IntPtr)

##### Declaration

```
public StatChangedDelegate(object object, IntPtr method)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | object |     |
| System.IntPtr | method |     |

### [](#methods)Methods

#### [](#Sandbox_Game_Entities_MyEntityStat_StatChangedDelegate_BeginInvoke_System_Single_System_Single_System_Object_System_AsyncCallback_System_Object_)BeginInvoke(Single, Single, Object, AsyncCallback, Object)

##### Declaration

```
public virtual IAsyncResult BeginInvoke(float newValue, float oldValue, object statChangeData, AsyncCallback callback, object object)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | newValue |     |
| System.Single | oldValue |     |
| System.Object | statChangeData |     |
| System.AsyncCallback | callback |     |
| System.Object | object |     |

##### Returns

| Type | Description |
| --- | --- |
| System.IAsyncResult |     |

#### [](#Sandbox_Game_Entities_MyEntityStat_StatChangedDelegate_EndInvoke_System_IAsyncResult_)EndInvoke(IAsyncResult)

##### Declaration

```
public virtual void EndInvoke(IAsyncResult result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.IAsyncResult | result |     |

#### [](#Sandbox_Game_Entities_MyEntityStat_StatChangedDelegate_Invoke_System_Single_System_Single_System_Object_)Invoke(Single, Single, Object)

##### Declaration

```
public virtual void Invoke(float newValue, float oldValue, object statChangeData)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | newValue |     |
| System.Single | oldValue |     |
| System.Object | statChangeData |     |