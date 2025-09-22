---
title: "Class MyCubeGrid.DebugUpdateRecord"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.DebugUpdateRecord.html"
category: "Misc"
namespace: "Sandbox.Game.Entities.MyCubeGrid"
class: "DebugUpdateRecord"
---

# Class MyCubeGrid.DebugUpdateRecord | Space Engineers ModAPI

##### Inheritance

System.Object

MyCubeGrid.DebugUpdateRecord

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public sealed class DebugUpdateRecord : ValueType
```

### Constructors

#### DebugUpdateRecord(MethodInfo, MyCubeGrid.UpdateQueue, Int32)

##### Declaration

```
public DebugUpdateRecord(MethodInfo method, MyCubeGrid.UpdateQueue queue, int priority)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Reflection.MethodInfo | method |     |
| [MyCubeGrid.UpdateQueue](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.UpdateQueue.html) | queue |     |
| System.Int32 | priority |     |

### Fields

#### Method

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Reflection.MethodInfo |     |

#### Priority

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### Queue

##### Declaration

```
public MyCubeGrid.UpdateQueue Queue
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyCubeGrid.UpdateQueue](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.UpdateQueue.html) |     |

### Properties

#### Comparer

##### Declaration

```
public static IEqualityComparer<MyCubeGrid.DebugUpdateRecord> Comparer { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.IEqualityComparer<[MyCubeGrid.DebugUpdateRecord](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.DebugUpdateRecord.html)\> |     |

### Methods

#### ToString()

##### Declaration

```
public override string ToString()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |