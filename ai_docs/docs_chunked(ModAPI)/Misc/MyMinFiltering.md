---
title: "Class MyMinFiltering"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyMinFiltering.html"
category: "Misc"
namespace: "VRage.Utils"
class: "MyMinFiltering"
---

# Class MyMinFiltering | Space Engineers ModAPI

Nonlinear minimum filtering.

##### Inheritance

System.Object

MyMinFiltering

###### **Namespace**: [VRage.Utils](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.html)

###### **Assembly**: VRage.dll

##### Syntax

```
public class MyMinFiltering : Object
```

### Constructors

#### MyMinFiltering(Int32)

##### Declaration

```
public MyMinFiltering(int sampleCount)
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

#### GetCurrentSampleCount()

##### Declaration

```
public int GetCurrentSampleCount()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### GetMaxSampleCount()

##### Declaration

```
public int GetMaxSampleCount()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |