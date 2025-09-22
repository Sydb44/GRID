---
title: "Class MyObjectBuilder\\_ProfilerBlock"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_ProfilerBlock.html"
category: "Misc"
namespace: "VRage.Game"
class: "MyObjectBuilder_ProfilerBlock"
---

# Class MyObjectBuilder\_ProfilerBlock | Space Engineers ModAPI

##### Inheritance

System.Object

MyObjectBuilder\_ProfilerBlock

###### **Namespace**: [VRage.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public class MyObjectBuilder_ProfilerBlock : Object
```

### [](#constructors)Constructors

#### [](#VRage_Game_MyObjectBuilder_ProfilerBlock__ctor)MyObjectBuilder\_ProfilerBlock()

##### Declaration

```
public MyObjectBuilder_ProfilerBlock()
```

### [](#fields)Fields

#### [](#VRage_Game_MyObjectBuilder_ProfilerBlock_Allocations)Allocations

##### Declaration

```
public Nullable<CompactSerializedArray<float>> Allocations
```

##### Field Value

#### [](#VRage_Game_MyObjectBuilder_ProfilerBlock_CallFormat)CallFormat

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### [](#VRage_Game_MyObjectBuilder_ProfilerBlock_Children)Children

##### Declaration

```
public List<MyProfilerBlockKey> Children
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<VRage.Profiler.MyProfilerBlockKey\> |     |

#### [](#VRage_Game_MyObjectBuilder_ProfilerBlock_CustomValues)CustomValues

##### Declaration

```
public Nullable<CompactSerializedArray<float>> CustomValues
```

##### Field Value

#### [](#VRage_Game_MyObjectBuilder_ProfilerBlock_Id)Id

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### [](#VRage_Game_MyObjectBuilder_ProfilerBlock_Key)Key

##### Declaration

```
public MyProfilerBlockKey Key
```

##### Field Value

| Type | Description |
| --- | --- |
| VRage.Profiler.MyProfilerBlockKey |     |

#### [](#VRage_Game_MyObjectBuilder_ProfilerBlock_ManagedMemoryBytes)ManagedMemoryBytes

##### Declaration

```
public Nullable<CompactSerializedArray<long>> ManagedMemoryBytes
```

##### Field Value

#### [](#VRage_Game_MyObjectBuilder_ProfilerBlock_Milliseconds)Milliseconds

##### Declaration

```
public Nullable<CompactSerializedArray<float>> Milliseconds
```

##### Field Value

#### [](#VRage_Game_MyObjectBuilder_ProfilerBlock_NumCallsArray)NumCallsArray

##### Declaration

```
public Nullable<CompactSerializedArray<int>> NumCallsArray
```

##### Field Value

#### [](#VRage_Game_MyObjectBuilder_ProfilerBlock_Parent)Parent

##### Declaration

```
public MyProfilerBlockKey Parent
```

##### Field Value

| Type | Description |
| --- | --- |
| VRage.Profiler.MyProfilerBlockKey |     |

#### [](#VRage_Game_MyObjectBuilder_ProfilerBlock_ProcessMemory)ProcessMemory

##### Declaration

```
public Nullable<CompactSerializedArray<float>> ProcessMemory
```

##### Field Value

#### [](#VRage_Game_MyObjectBuilder_ProfilerBlock_TimeFormat)TimeFormat

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### [](#VRage_Game_MyObjectBuilder_ProfilerBlock_ValueFormat)ValueFormat

##### Declaration

```
public string ValueFormat
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

### [](#methods)Methods

#### [](#VRage_Game_MyObjectBuilder_ProfilerBlock_GetObjectBuilder_VRage_Profiler_MyProfilerBlock_System_Boolean_)GetObjectBuilder(MyProfilerBlock, Boolean)

##### Declaration

```
public static MyObjectBuilder_ProfilerBlock GetObjectBuilder(MyProfilerBlock profilerBlock, bool serializeAllocations)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| VRage.Profiler.MyProfilerBlock | profilerBlock |     |
| System.Boolean | serializeAllocations |     |

##### Returns

#### [](#VRage_Game_MyObjectBuilder_ProfilerBlock_Init_VRage_Game_MyObjectBuilder_ProfilerBlock_VRage_Profiler_MyProfiler_MyProfilerObjectBuilderInfo_)Init(MyObjectBuilder\_ProfilerBlock, MyProfiler.MyProfilerObjectBuilderInfo)

##### Declaration

```
public static MyProfilerBlock Init(MyObjectBuilder_ProfilerBlock objectBuilder, MyProfiler.MyProfilerObjectBuilderInfo profiler)
```

##### Parameters

##### Returns

| Type | Description |
| --- | --- |
| VRage.Profiler.MyProfilerBlock |     |