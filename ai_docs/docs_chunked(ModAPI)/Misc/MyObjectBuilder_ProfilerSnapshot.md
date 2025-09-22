---
title: "Class MyObjectBuilder\\_ProfilerSnapshot"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_ProfilerSnapshot.html"
category: "Misc"
namespace: "VRage.Game"
class: "MyObjectBuilder_ProfilerSnapshot"
---

# Class MyObjectBuilder\_ProfilerSnapshot | Space Engineers ModAPI

##### Inheritance

System.Object

MyObjectBuilder\_ProfilerSnapshot

##### Inherited Members

###### **Namespace**: [VRage.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
[MyObjectBuilderDefinition]
public class MyObjectBuilder_ProfilerSnapshot : MyObjectBuilder_Base
```

### Constructors

#### MyObjectBuilder\_ProfilerSnapshot()

##### Declaration

```
public MyObjectBuilder_ProfilerSnapshot()
```

### Fields

#### Profilers

##### Declaration

```
public List<MyObjectBuilder_Profiler> Profilers
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MyObjectBuilder\_Profiler](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_Profiler.html)\> |     |

#### SimulationFrames

##### Declaration

```
public List<MyRenderProfiler.FrameInfo> SimulationFrames
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<VRage.Profiler.MyRenderProfiler.FrameInfo\> |     |

### Methods

#### ClearProfilerDumps()

##### Declaration

```
public static void ClearProfilerDumps()
```

#### GetObjectBuilder(MyRenderProfiler)

##### Declaration

```
public static MyObjectBuilder_ProfilerSnapshot GetObjectBuilder(MyRenderProfiler profiler)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| VRage.Profiler.MyRenderProfiler | profiler |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_ProfilerSnapshot](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_ProfilerSnapshot.html) |     |

#### GetProfilerDumpCount()

##### Declaration

```
public static int GetProfilerDumpCount()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### GetProfilerDumpPath(Int32)

Get the path where a profiler dump with `index` should be stored.

##### Declaration

```
public static string GetProfilerDumpPath(int index)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | index | The index of the profiler dump. |

##### Returns

| Type | Description |
| --- | --- |
| System.String | The path where the dump should be stored. |

#### Init(MyRenderProfiler, SnapshotType, Boolean)

##### Declaration

```
public void Init(MyRenderProfiler profiler, SnapshotType type, bool subtract)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| VRage.Profiler.MyRenderProfiler | profiler |     |
| VRage.Profiler.SnapshotType | type |     |
| System.Boolean | subtract |     |

#### SetDelegates()

##### Declaration

```
public static void SetDelegates()
```

### Extension Methods