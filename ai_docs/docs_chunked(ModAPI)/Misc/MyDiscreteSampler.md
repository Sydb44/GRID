---
title: "Class MyDiscreteSampler"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyDiscreteSampler.html"
category: "Misc"
namespace: "VRage.Utils"
class: "MyDiscreteSampler"
---

# Class MyDiscreteSampler | Space Engineers ModAPI

Provides a simple and efficient way of sampling a discrete probability distribution as described in [http://www.jstatsoft.org/v11/i03/paper](http://www.jstatsoft.org/v11/i03/paper) Instances can be reused by calling the Prepare method every time you want to change the distribution. Sampling a value is O(1), while the storage requirements are O(N), where N is number of possible values

##### Inheritance

System.Object

MyDiscreteSampler

###### **Namespace**: [VRage.Utils](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.html)

###### **Assembly**: VRage.dll

##### Syntax

```
public class MyDiscreteSampler : Object
```

### Constructors

#### MyDiscreteSampler()

##### Declaration

```
public MyDiscreteSampler()
```

#### MyDiscreteSampler(Int32)

##### Declaration

```
public MyDiscreteSampler(int prealloc)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | prealloc |     |

### Properties

#### Initialized

##### Declaration

```
public bool Initialized { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Methods

#### Prepare(IEnumerable<Single>)

##### Declaration

```
public void Prepare(IEnumerable<float> densities)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.IEnumerable<System.Single\> | densities |     |

#### ReadBins()

Get a copy of the internal bins.

##### Declaration

```
public MyDiscreteSampler.SamplingBin[] ReadBins()
```

##### Returns

| Type | Description |
| --- | --- |
| [MyDiscreteSampler.SamplingBin](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyDiscreteSampler.SamplingBin.html)\[\] |     |

#### Sample()

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### Sample(Single)

##### Declaration

```
public int Sample(float rate)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | rate |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### Sample(MyRandom)

##### Declaration

```
public int Sample(MyRandom rng)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyRandom](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Library.Utils.MyRandom.html) | rng |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |