---
title: "Class ItemSpawnedEvent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.ItemSpawnedEvent.html"
category: "Events"
namespace: "Sandbox.Game"
class: "ItemSpawnedEvent"
---

# Class ItemSpawnedEvent | Space Engineers ModAPI

##### Inheritance

System.Object

ItemSpawnedEvent

###### **Namespace**: [Sandbox.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[VisualScriptingEvent]
public sealed class ItemSpawnedEvent : MulticastDelegate
```

### Constructors

#### ItemSpawnedEvent(Object, IntPtr)

##### Declaration

```
public ItemSpawnedEvent(object object, IntPtr method)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | object |     |
| System.IntPtr | method |     |

### Methods

#### BeginInvoke(String, String, Int64, Int32, Vector3D, AsyncCallback, Object)

##### Declaration

```
public virtual IAsyncResult BeginInvoke(string itemTypeName, string itemSubTypeName, long itemId, int amount, Vector3D position, AsyncCallback callback, object object)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | itemTypeName |     |
| System.String | itemSubTypeName |     |
| System.Int64 | itemId |     |
| System.Int32 | amount |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | position |     |
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

#### Invoke(String, String, Int64, Int32, Vector3D)

##### Declaration

```
public virtual void Invoke(string itemTypeName, string itemSubTypeName, long itemId, int amount, Vector3D position)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | itemTypeName |     |
| System.String | itemSubTypeName |     |
| System.Int64 | itemId |     |
| System.Int32 | amount |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | position |     |