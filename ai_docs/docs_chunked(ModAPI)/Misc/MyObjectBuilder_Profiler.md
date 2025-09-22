---
title: "Class MyObjectBuilder\\_Profiler"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_Profiler.html"
category: "Misc"
namespace: "VRage.Game"
class: "MyObjectBuilder_Profiler"
---

# Class MyObjectBuilder\_Profiler | Space Engineers ModAPI

##### Inheritance

System.Object

MyObjectBuilder\_Profiler

##### Inherited Members

###### **Namespace**: [VRage.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
[MyObjectBuilderDefinition]
public class MyObjectBuilder_Profiler : MyObjectBuilder_Base
```

### Constructors

#### MyObjectBuilder\_Profiler()

##### Declaration

```
public MyObjectBuilder_Profiler()
```

### Fields

#### AxisName

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### CommitTimes

##### Declaration

```
public CompactSerializedArray<long> CommitTimes
```

##### Field Value

| Type | Description |
| --- | --- |
| [CompactSerializedArray](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.CompactSerializedArray-1.html)<System.Int64\> |     |

#### CustomName

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### ProfilingBlocks

##### Declaration

```
public List<MyObjectBuilder_ProfilerBlock> ProfilingBlocks
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MyObjectBuilder\_ProfilerBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_ProfilerBlock.html)\> |     |

#### RootBlocks

##### Declaration

```
public List<MyProfilerBlockKey> RootBlocks
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<VRage.Profiler.MyProfilerBlockKey\> |     |

#### ShallowProfile

##### Declaration

```
public bool ShallowProfile
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Tasks

##### Declaration

```
public List<MyProfiler.TaskInfo> Tasks
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<VRage.Profiler.MyProfiler.TaskInfo\> |     |

#### TotalCalls

##### Declaration

```
public CompactSerializedArray<int> TotalCalls
```

##### Field Value

| Type | Description |
| --- | --- |
| [CompactSerializedArray](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.CompactSerializedArray-1.html)<System.Int32\> |     |

### Methods

#### GetObjectBuilder(MyProfiler)

##### Declaration

```
public static MyObjectBuilder_Profiler GetObjectBuilder(MyProfiler profiler)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| VRage.Profiler.MyProfiler | profiler |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_Profiler](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_Profiler.html) |     |

#### Init(MyObjectBuilder\_Profiler)

##### Declaration

```
public static MyProfiler Init(MyObjectBuilder_Profiler objectBuilder)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_Profiler](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_Profiler.html) | objectBuilder |     |

##### Returns

| Type | Description |
| --- | --- |
| VRage.Profiler.MyProfiler |     |

#### LoadFromFile(Int32)

##### Declaration

```
public static void LoadFromFile(int index)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | index |     |

#### SaveToFile(Int32)

##### Declaration

```
public static void SaveToFile(int index)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | index |     |

### Extension Methods