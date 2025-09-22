---
title: "Class MyDebugHitCounter"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyDebugHitCounter.html"
category: "Misc"
namespace: "VRage.Utils"
class: "MyDebugHitCounter"
---

# Class MyDebugHitCounter | Space Engineers ModAPI

##### Inheritance

System.Object

MyDebugHitCounter

###### **Namespace**: [VRage.Utils](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public class MyDebugHitCounter : Object, IEnumerable<MyDebugHitCounter.Sample>, IEnumerable
```

### [](#constructors)Constructors

#### [](#VRage_Utils_MyDebugHitCounter__ctor_System_UInt32_)MyDebugHitCounter(UInt32)

##### Declaration

```
public MyDebugHitCounter(uint cycleSize = 100000U)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.UInt32 | cycleSize |     |

### [](#fields)Fields

#### [](#VRage_Utils_MyDebugHitCounter_History)History

##### Declaration

```
public readonly MyQueue<MyDebugHitCounter.Sample> History
```

##### Field Value

### [](#properties)Properties

#### [](#VRage_Utils_MyDebugHitCounter_CurrentHitRatio)CurrentHitRatio

##### Declaration

```
public float CurrentHitRatio { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### [](#VRage_Utils_MyDebugHitCounter_LastCycleHitRatio)LastCycleHitRatio

##### Declaration

```
public float LastCycleHitRatio { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

### [](#methods)Methods

#### [](#VRage_Utils_MyDebugHitCounter_Cycle)Cycle()

##### Declaration

#### [](#VRage_Utils_MyDebugHitCounter_CycleWork)CycleWork()

##### Declaration

#### [](#VRage_Utils_MyDebugHitCounter_GetEnumerator)GetEnumerator()

##### Declaration

```
public ConcurrentEnumerator<SpinLockRef.Token, MyDebugHitCounter.Sample, IEnumerator<MyDebugHitCounter.Sample>> GetEnumerator()
```

##### Returns

#### [](#VRage_Utils_MyDebugHitCounter_Hit)Hit()

##### Declaration

#### [](#VRage_Utils_MyDebugHitCounter_Miss)Miss()

##### Declaration

#### [](#VRage_Utils_MyDebugHitCounter_ValueAndCycle)ValueAndCycle()

##### Declaration

```
public float ValueAndCycle()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |