---
title: "Class MyInterpolationQueue<T>"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Library.Utils.MyInterpolationQueue-1.html"
category: "Misc"
namespace: "VRage.Library.Utils"
class: "MyInterpolationQueue-1"
---

# Class MyInterpolationQueue<T> | Space Engineers ModAPI

##### Inheritance

System.Object

MyInterpolationQueue<T>

###### **Namespace**: [VRage.Library.Utils](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Library.Utils.html)

###### **Assembly**: VRage.Library.dll

##### Syntax

```
public class MyInterpolationQueue<T> : Object
```

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

### Constructors

#### MyInterpolationQueue(Int32, InterpolationHandler<T>)

##### Declaration

```
public MyInterpolationQueue(int defaultCapacity, InterpolationHandler<T> interpolator)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | defaultCapacity |     |
| [InterpolationHandler](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Library.Utils.InterpolationHandler-1.html)<T> | interpolator |     |

### Properties

#### Count

##### Declaration

```
public int Count { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### LastSample

##### Declaration

```
public MyTimeSpan LastSample { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyTimeSpan](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Library.Utils.MyTimeSpan.html) |     |

### Methods

#### AddSample(ref T, MyTimeSpan)

Adds sample with timestamp, it must be larger than last timestamp!

##### Declaration

```
public void AddSample(ref T item, MyTimeSpan sampleTimestamp)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| T   | item |     |
| [MyTimeSpan](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Library.Utils.MyTimeSpan.html) | sampleTimestamp |     |

#### Clear()

##### Declaration

#### DiscardOld(MyTimeSpan)

Discards old samples, keeps at least 2 samples to be able to interpolate or extrapolate.

##### Declaration

```
public void DiscardOld(MyTimeSpan currentTimestamp)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyTimeSpan](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Library.Utils.MyTimeSpan.html) | currentTimestamp |     |

#### Interpolate(MyTimeSpan, out T)

Discards old frame (keeps one older) and interpolates between two samples using interpolator. Returns interpolator There must be at least one sample!

##### Declaration

```
public float Interpolate(MyTimeSpan currentTimestamp, out T result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyTimeSpan](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Library.Utils.MyTimeSpan.html) | currentTimestamp |     |
| T   | result |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |