---
title: "Class CutsceneEvent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.CutsceneEvent.html"
category: "Events"
namespace: "Sandbox.Game"
class: "CutsceneEvent"
---

# Class CutsceneEvent | Space Engineers ModAPI

##### Inheritance

System.Object

CutsceneEvent

###### **Namespace**: [Sandbox.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[VisualScriptingEvent]
public sealed class CutsceneEvent : MulticastDelegate
```

### Constructors

#### CutsceneEvent(Object, IntPtr)

##### Declaration

```
public CutsceneEvent(object object, IntPtr method)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | object |     |
| System.IntPtr | method |     |

### Methods

#### BeginInvoke(String, AsyncCallback, Object)

##### Declaration

```
public virtual IAsyncResult BeginInvoke(string cutsceneName, AsyncCallback callback, object object)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | cutsceneName |     |
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

#### Invoke(String)

##### Declaration

```
public virtual void Invoke(string cutsceneName)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | cutsceneName |     |