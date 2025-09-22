---
title: "Class MyDiscreteSampler<T>"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyDiscreteSampler-1.html"
category: "Misc"
namespace: "VRage.Utils"
class: "MyDiscreteSampler-1"
---

# Class MyDiscreteSampler<T> | Space Engineers ModAPI

A templated class for sampling from a set of objects with given probabilities. Uses MyDiscreteSampler.

##### Inheritance

System.Object

MyDiscreteSampler<T>

###### **Namespace**: [VRage.Utils](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.html)

###### **Assembly**: VRage.dll

##### Syntax

```
public class MyDiscreteSampler<T> : Object, IEnumerable<T>, IEnumerable
```

##### Type Parameters

### [](#constructors)Constructors

#### [](#VRage_Utils_MyDiscreteSampler_1__ctor__0___System_Collections_Generic_IEnumerable_System_Single__)MyDiscreteSampler(T\[\], IEnumerable<Single>)

##### Declaration

```
public MyDiscreteSampler(T[] values, IEnumerable<float> densities)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| T\[\] | values |     |
| System.Collections.Generic.IEnumerable<System.Single\> | densities |     |

#### [](#VRage_Utils_MyDiscreteSampler_1__ctor_System_Collections_Generic_Dictionary__0_System_Single__)MyDiscreteSampler(Dictionary<T, Single>)

##### Declaration

```
public MyDiscreteSampler(Dictionary<T, float> densities)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.Dictionary<T, System.Single\> | densities |     |

#### [](#VRage_Utils_MyDiscreteSampler_1__ctor_System_Collections_Generic_IEnumerable__0__System_Collections_Generic_IEnumerable_System_Single__)MyDiscreteSampler(IEnumerable<T>, IEnumerable<Single>)

##### Declaration

```
public MyDiscreteSampler(IEnumerable<T> values, IEnumerable<float> densities)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.IEnumerable<T> | values |     |
| System.Collections.Generic.IEnumerable<System.Single\> | densities |     |

#### [](#VRage_Utils_MyDiscreteSampler_1__ctor_System_Collections_Generic_List__0__System_Collections_Generic_IEnumerable_System_Single__)MyDiscreteSampler(List<T>, IEnumerable<Single>)

##### Declaration

```
public MyDiscreteSampler(List<T> values, IEnumerable<float> densities)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<T> | values |     |
| System.Collections.Generic.IEnumerable<System.Single\> | densities |     |

### [](#properties)Properties

#### [](#VRage_Utils_MyDiscreteSampler_1_Count)Count

##### Declaration

```
public int Count { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### [](#VRage_Utils_MyDiscreteSampler_1_Initialized)Initialized

##### Declaration

```
public bool Initialized { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### [](#methods)Methods

#### [](#VRage_Utils_MyDiscreteSampler_1_GetEnumerator)GetEnumerator()

##### Declaration

```
public IEnumerator<T> GetEnumerator()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.IEnumerator<T> |     |

#### [](#VRage_Utils_MyDiscreteSampler_1_Sample)Sample()

##### Declaration

##### Returns

#### [](#VRage_Utils_MyDiscreteSampler_1_Sample_System_Single_)Sample(Single)

##### Declaration

```
public T Sample(float sample)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | sample |     |

##### Returns

#### [](#VRage_Utils_MyDiscreteSampler_1_Sample_VRage_Library_Utils_MyRandom_)Sample(MyRandom)

##### Declaration

```
public T Sample(MyRandom rng)
```

##### Parameters

##### Returns