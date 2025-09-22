---
title: "Class MyMovingAverage"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyMovingAverage.html"
category: "Misc"
namespace: "VRageMath"
class: "MyMovingAverage"
---

# Class MyMovingAverage | Space Engineers ModAPI

##### Inheritance

System.Object

MyMovingAverage

###### **Namespace**: [VRageMath](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.html)

###### **Assembly**: VRage.Math.dll

##### Syntax

```
public class MyMovingAverage : Object
```

### Constructors

#### MyMovingAverage(Int32, Int32)

##### Declaration

```
public MyMovingAverage(int windowSize, int enqueueCountToReset = 1000)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | windowSize |     |
| System.Int32 | enqueueCountToReset |     |

### Properties

#### Avg

##### Declaration

```
public float Avg { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Sum

##### Declaration

```
public double Sum { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Double |     |

### Methods

#### Enqueue(Single)

##### Declaration

```
public void Enqueue(float value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | value |     |

#### Reset()

##### Declaration