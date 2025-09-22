---
title: "Class MyAverageFiltering"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyAverageFiltering.html"
category: "Misc"
namespace: "VRage.Utils"
class: "MyAverageFiltering"
---

# Class MyAverageFiltering | Space Engineers ModAPI

Mean (average) filtering.

##### Inheritance

System.Object

MyAverageFiltering

###### **Namespace**: [VRage.Utils](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.html)

###### **Assembly**: VRage.dll

##### Syntax

```
public class MyAverageFiltering : Object
```

### Constructors

#### MyAverageFiltering(Int32)

##### Declaration

```
public MyAverageFiltering(int sampleCount)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | sampleCount | Number of samples used in this mean filter. |

### Methods

#### Add(Double)

Add raw value to be filtered.

##### Declaration

```
public void Add(double value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Double | value |     |

#### Clear()

##### Declaration

#### Get()

Get filtered value.

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.Double |     |