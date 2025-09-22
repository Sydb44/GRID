---
title: "Class MyVector3ISet"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyVector3ISet.html"
category: "Misc"
namespace: "VRage.Utils"
class: "MyVector3ISet"
---

# Class MyVector3ISet | Space Engineers ModAPI

A data structure for a set of Vector3I coordinates optimized for sets with high spatial coherence (hence the name)

##### Inheritance

System.Object

MyVector3ISet

###### **Namespace**: [VRage.Utils](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.html)

###### **Assembly**: VRage.dll

##### Syntax

```
public class MyVector3ISet : Object, IEnumerable<Vector3I>, IEnumerable
```

### [](#constructors)Constructors

#### [](#VRage_Utils_MyVector3ISet__ctor)MyVector3ISet()

##### Declaration

### [](#properties)Properties

#### [](#VRage_Utils_MyVector3ISet_Empty)Empty

##### Declaration

```
public bool Empty { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### [](#methods)Methods

#### [](#VRage_Utils_MyVector3ISet_Add_VRageMath_Vector3I_)Add(Vector3I)

##### Declaration

```
public void Add(Vector3I position)
```

##### Parameters

#### [](#VRage_Utils_MyVector3ISet_Add_VRageMath_Vector3I__)Add(ref Vector3I)

##### Declaration

```
public void Add(ref Vector3I position)
```

##### Parameters

#### [](#VRage_Utils_MyVector3ISet_Clear)Clear()

##### Declaration

#### [](#VRage_Utils_MyVector3ISet_Contains_VRageMath_Vector3I_)Contains(Vector3I)

##### Declaration

```
public bool Contains(Vector3I position)
```

##### Parameters

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Utils_MyVector3ISet_Contains_VRageMath_Vector3I__)Contains(ref Vector3I)

##### Declaration

```
public bool Contains(ref Vector3I position)
```

##### Parameters

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Utils_MyVector3ISet_GetEnumerator)GetEnumerator()

##### Declaration

```
public MyVector3ISet.Enumerator GetEnumerator()
```

##### Returns

#### [](#VRage_Utils_MyVector3ISet_Remove_VRageMath_Vector3I_)Remove(Vector3I)

##### Declaration

```
public void Remove(Vector3I position)
```

##### Parameters

#### [](#VRage_Utils_MyVector3ISet_Remove_VRageMath_Vector3I__)Remove(ref Vector3I)

##### Declaration

```
public void Remove(ref Vector3I position)
```

##### Parameters

#### [](#VRage_Utils_MyVector3ISet_Union_VRage_Utils_MyVector3ISet_)Union(MyVector3ISet)

Makes a union of this set and the other set and saves it in this set

##### Declaration

```
public void Union(MyVector3ISet otherSet)
```

##### Parameters