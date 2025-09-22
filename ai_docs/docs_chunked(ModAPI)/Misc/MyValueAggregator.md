---
title: "Class MyValueAggregator"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Library.Utils.MyValueAggregator.html"
category: "Misc"
namespace: "VRage.Library.Utils"
class: "MyValueAggregator"
---

# Class MyValueAggregator | Space Engineers ModAPI

##### Inheritance

System.Object

MyValueAggregator

###### **Namespace**: [VRage.Library.Utils](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Library.Utils.html)

###### **Assembly**: VRage.Library.dll

##### Syntax

```
public class MyValueAggregator : Object
```

### Constructors

#### MyValueAggregator(Int32, Int32\[\])

##### Declaration

```
public MyValueAggregator(int bufferSize, params int[] percentiles)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | bufferSize |     |
| System.Int32\[\] | percentiles |     |

### Properties

#### HasData

##### Declaration

```
public bool HasData { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### PercentileValues

##### Declaration

```
public double[] PercentileValues { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Double\[\] |     |

### Methods

#### Clear()

##### Declaration

#### GetPercentileValues(Double\[\])

##### Declaration

```
public void GetPercentileValues(double[] valuesBuffer)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Double\[\] | valuesBuffer |     |

#### Push(Double)

##### Declaration

```
public void Push(double value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Double | value |     |