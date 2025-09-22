---
title: "Class MyDebugWorkTracker<T>"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyDebugWorkTracker-1.html"
category: "Misc"
namespace: "VRage.Utils"
class: "MyDebugWorkTracker-1"
---

# Class MyDebugWorkTracker<T> | Space Engineers ModAPI

##### Inheritance

System.Object

MyDebugWorkTracker<T>

###### **Namespace**: [VRage.Utils](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public class MyDebugWorkTracker<T> : Object where T : new()
```

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

### Constructors

#### MyDebugWorkTracker(UInt32)

##### Declaration

```
public MyDebugWorkTracker(uint historyLength = 10U)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.UInt32 | historyLength |     |

### Fields

#### Current

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| T   |     |

#### History

##### Declaration

```
public readonly MyQueue<T> History
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyQueue](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.MyQueue-1.html)<T> |     |

### Methods

#### Wrap()

##### Declaration