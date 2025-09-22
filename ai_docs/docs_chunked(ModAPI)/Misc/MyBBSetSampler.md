---
title: "Class MyBBSetSampler"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyBBSetSampler.html"
category: "Misc"
namespace: "VRage.Utils"
class: "MyBBSetSampler"
---

# Class MyBBSetSampler | Space Engineers ModAPI

This class allows for uniform generation of points from a set of bounding boxes.

You start by constructing a bounding box from where the points will be sampled. Then you can incrementally subtract bounding boxes and the resulting structure will allow you to generate uniformly distributed points using the Sample() function.

##### Inheritance

System.Object

MyBBSetSampler

###### **Namespace**: [VRage.Utils](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.html)

###### **Assembly**: VRage.dll

##### Syntax

```
public class MyBBSetSampler : Object
```

### Constructors

#### MyBBSetSampler(Vector3D, Vector3D)

##### Declaration

```
public MyBBSetSampler(Vector3D min, Vector3D max)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | min |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | max |     |

### Properties

#### Valid

##### Declaration

```
public bool Valid { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Methods

#### Sample()

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

#### SubtractBB(ref BoundingBoxD)

##### Declaration

```
public void SubtractBB(ref BoundingBoxD bb)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | bb  |     |