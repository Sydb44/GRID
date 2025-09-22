---
title: "Class TeamBalancerSortEvent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.TeamBalancerSortEvent.html"
category: "Events"
namespace: "Sandbox.Game"
class: "TeamBalancerSortEvent"
---

# Class TeamBalancerSortEvent | Space Engineers ModAPI

##### Inheritance

System.Object

TeamBalancerSortEvent

###### **Namespace**: [Sandbox.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[VisualScriptingEvent]
public sealed class TeamBalancerSortEvent : MulticastDelegate
```

### Constructors

#### TeamBalancerSortEvent(Object, IntPtr)

##### Declaration

```
public TeamBalancerSortEvent(object object, IntPtr method)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | object |     |
| System.IntPtr | method |     |

### Methods

#### BeginInvoke(Int64, String, AsyncCallback, Object)

##### Declaration

```
public virtual IAsyncResult BeginInvoke(long playerId, string factionTag, AsyncCallback callback, object object)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | playerId |     |
| System.String | factionTag |     |
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

#### Invoke(Int64, String)

##### Declaration

```
public virtual void Invoke(long playerId, string factionTag)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | playerId |     |
| System.String | factionTag |     |