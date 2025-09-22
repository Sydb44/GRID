---
title: "Class MyMemoryLogs"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyMemoryLogs.html"
category: "Misc"
namespace: "VRage.Utils"
class: "MyMemoryLogs"
---

# Class MyMemoryLogs | Space Engineers ModAPI

##### Inheritance

System.Object

MyMemoryLogs

###### **Namespace**: [VRage.Utils](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.html)

###### **Assembly**: VRage.dll

##### Syntax

```
public class MyMemoryLogs : Object
```

### Constructors

#### MyMemoryLogs()

##### Declaration

### Methods

#### AddConsoleLine(String)

##### Declaration

```
public static void AddConsoleLine(string line)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | line |     |

#### DumpMemoryUsage()

##### Declaration

```
public static void DumpMemoryUsage()
```

#### EndEvent(MyMemoryLogs.MyMemoryEvent)

##### Declaration

```
public static void EndEvent(MyMemoryLogs.MyMemoryEvent ev)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyMemoryLogs.MyMemoryEvent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyMemoryLogs.MyMemoryEvent.html) | ev  |     |

#### GetEvents()

##### Declaration

```
public static List<MyMemoryLogs.MyMemoryEvent> GetEvents()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MyMemoryLogs.MyMemoryEvent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyMemoryLogs.MyMemoryEvent.html)\> |     |

#### GetManaged()

##### Declaration

```
public static List<MyMemoryLogs.MyMemoryEvent> GetManaged()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MyMemoryLogs.MyMemoryEvent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyMemoryLogs.MyMemoryEvent.html)\> |     |

#### GetNative()

##### Declaration

```
public static List<MyMemoryLogs.MyMemoryEvent> GetNative()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MyMemoryLogs.MyMemoryEvent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyMemoryLogs.MyMemoryEvent.html)\> |     |

#### GetTimed()

##### Declaration

```
public static List<MyMemoryLogs.MyMemoryEvent> GetTimed()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MyMemoryLogs.MyMemoryEvent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyMemoryLogs.MyMemoryEvent.html)\> |     |

#### StartEvent()

##### Declaration

```
public static void StartEvent()
```