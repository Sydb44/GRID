---
title: "Class MyLogicalEnvironmentSectorBase.ItemIterator"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase.ItemIterator.html"
category: "Misc"
namespace: "Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase"
class: "ItemIterator"
---

# Class MyLogicalEnvironmentSectorBase.ItemIterator | Space Engineers ModAPI

##### Inheritance

System.Object

MyLogicalEnvironmentSectorBase.ItemIterator

###### **Namespace**: [Sandbox.Game.WorldEnvironment](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public sealed class ItemIterator : MulticastDelegate
```

### Constructors

#### ItemIterator(Object, IntPtr)

##### Declaration

```
public ItemIterator(object object, IntPtr method)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | object |     |
| System.IntPtr | method |     |

### Methods

#### BeginInvoke(Int32, ref ItemInfo, AsyncCallback, Object)

##### Declaration

```
public virtual IAsyncResult BeginInvoke(int index, ref ItemInfo item, AsyncCallback callback, object object)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | index |     |
| [ItemInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.ItemInfo.html) | item |     |
| System.AsyncCallback | callback |     |
| System.Object | object |     |

##### Returns

| Type | Description |
| --- | --- |
| System.IAsyncResult |     |

#### EndInvoke(ref ItemInfo, IAsyncResult)

##### Declaration

```
public virtual void EndInvoke(ref ItemInfo item, IAsyncResult result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [ItemInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.ItemInfo.html) | item |     |
| System.IAsyncResult | result |     |

#### Invoke(Int32, ref ItemInfo)

##### Declaration

```
public virtual void Invoke(int index, ref ItemInfo item)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | index |     |
| [ItemInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.ItemInfo.html) | item |     |