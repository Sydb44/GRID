---
title: "Class BoxCornerEnumerator"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoxCornerEnumerator.html"
category: "Misc"
namespace: "VRageMath"
class: "BoxCornerEnumerator"
---

# Class BoxCornerEnumerator | Space Engineers ModAPI

##### Inheritance

System.Object

BoxCornerEnumerator

###### **Namespace**: [VRageMath](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.html)

###### **Assembly**: VRage.Math.dll

##### Syntax

```
public sealed class BoxCornerEnumerator : ValueType, IEnumerator<Vector3>, IEnumerator, IDisposable, IEnumerable<Vector3>, IEnumerable
```

### Constructors

#### BoxCornerEnumerator(Vector3, Vector3)

##### Declaration

```
public BoxCornerEnumerator(Vector3 min, Vector3 max)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | min |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | max |     |

### Properties

#### Current

##### Declaration

```
public Vector3 Current { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

### Methods

#### Add(Object)

##### Declaration

```
public void Add(object tmp)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | tmp |     |

#### GetEnumerator()

##### Declaration

```
public BoxCornerEnumerator GetEnumerator()
```

##### Returns

| Type | Description |
| --- | --- |
| [BoxCornerEnumerator](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoxCornerEnumerator.html) |     |

#### MoveNext()

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |