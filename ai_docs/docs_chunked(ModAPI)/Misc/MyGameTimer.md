---
title: "Class MyGameTimer"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Library.Utils.MyGameTimer.html"
category: "Misc"
namespace: "VRage.Library.Utils"
class: "MyGameTimer"
---

# Class MyGameTimer | Space Engineers ModAPI

Global thread-safe timer. Time for update and time for draw must be copied at the beginning of update and draw.

##### Inheritance

System.Object

MyGameTimer

###### **Namespace**: [VRage.Library.Utils](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Library.Utils.html)

###### **Assembly**: VRage.Library.dll

##### Syntax

```
public class MyGameTimer : Object
```

### [](#constructors)Constructors

#### [](#VRage_Library_Utils_MyGameTimer__ctor)MyGameTimer()

##### Declaration

### [](#fields)Fields

#### [](#VRage_Library_Utils_MyGameTimer_Frequency)Frequency

Number of ticks per seconds

##### Declaration

```
public static readonly long Frequency
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

### [](#properties)Properties

#### [](#VRage_Library_Utils_MyGameTimer_Elapsed)Elapsed

##### Declaration

```
public MyTimeSpan Elapsed { get; }
```

##### Property Value

#### [](#VRage_Library_Utils_MyGameTimer_ElapsedTicks)ElapsedTicks

##### Declaration

```
public long ElapsedTicks { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### [](#VRage_Library_Utils_MyGameTimer_ElapsedTimeSpan)ElapsedTimeSpan

This may not be accurate for large values - double accuracy

##### Declaration

```
public TimeSpan ElapsedTimeSpan { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.TimeSpan |     |

### [](#methods)Methods

#### [](#VRage_Library_Utils_MyGameTimer_AddElapsed_VRage_Library_Utils_MyTimeSpan_)AddElapsed(MyTimeSpan)

##### Declaration

```
public void AddElapsed(MyTimeSpan timespan)
```

##### Parameters