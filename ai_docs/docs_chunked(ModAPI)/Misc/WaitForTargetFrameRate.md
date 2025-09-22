---
title: "Class WaitForTargetFrameRate"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Library.Utils.WaitForTargetFrameRate.html"
category: "Misc"
namespace: "VRage.Library.Utils"
class: "WaitForTargetFrameRate"
---

# Class WaitForTargetFrameRate | Space Engineers ModAPI

##### Inheritance

System.Object

WaitForTargetFrameRate

###### **Namespace**: [VRage.Library.Utils](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Library.Utils.html)

###### **Assembly**: VRage.Library.dll

##### Syntax

```
public class WaitForTargetFrameRate : Object
```

### Constructors

#### WaitForTargetFrameRate(MyGameTimer, Single)

##### Declaration

```
public WaitForTargetFrameRate(MyGameTimer timer, float targetFrequency = 60F)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyGameTimer](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Library.Utils.MyGameTimer.html) | timer |     |
| System.Single | targetFrequency |     |

### Fields

#### ENABLE\_TIMING\_HOTFIX

##### Declaration

```
public static bool ENABLE_TIMING_HOTFIX
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### EnableMaxSpeed

##### Declaration

```
public bool EnableMaxSpeed
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Properties

#### TickPerFrame

##### Declaration

```
public long TickPerFrame { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

### Methods

#### SetNextFrameDelayDelta(Single)

##### Declaration

```
public void SetNextFrameDelayDelta(float delta)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | delta |     |

#### Wait()

##### Declaration