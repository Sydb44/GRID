---
title: "Class MyHierarchyComponent<TYPE>"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyHierarchyComponent-1.html"
category: "Components"
namespace: "VRage.Game.Components"
class: "MyHierarchyComponent-1"
---

# Class MyHierarchyComponent<TYPE> | Space Engineers ModAPI

##### Inheritance

System.Object

MyHierarchyComponent<TYPE>

##### Inherited Members

###### **Namespace**: [VRage.Game.Components](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public class MyHierarchyComponent<TYPE> : MyHierarchyComponentBase, IMyEntityComponentBase, IMyComponentBase
```

##### Type Parameters

| Name | Description |
| --- | --- |
| TYPE |     |

### Constructors

#### MyHierarchyComponent()

##### Declaration

```
public MyHierarchyComponent()
```

### Fields

#### QueryAABBImpl

##### Declaration

```
public Action<BoundingBoxD, List<TYPE>> QueryAABBImpl
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Action<[BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html), System.Collections.Generic.List<TYPE>> |     |

#### QueryLineImpl

##### Declaration

```
public Action<LineD, List<MyLineSegmentOverlapResult<TYPE>>> QueryLineImpl
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Action<[LineD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.LineD.html), System.Collections.Generic.List<[MyLineSegmentOverlapResult](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyLineSegmentOverlapResult-1.html)<TYPE>>> |     |

#### QuerySphereImpl

##### Declaration

```
public Action<BoundingSphereD, List<TYPE>> QuerySphereImpl
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Action<[BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html), System.Collections.Generic.List<TYPE>> |     |

### Methods

#### QueryAABB(ref BoundingBoxD, List<TYPE>)

##### Declaration

```
public void QueryAABB(ref BoundingBoxD aabb, List<TYPE> result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | aabb |     |
| System.Collections.Generic.List<TYPE> | result |     |

#### QueryLine(ref LineD, List<MyLineSegmentOverlapResult<TYPE>>)

##### Declaration

```
public void QueryLine(ref LineD line, List<MyLineSegmentOverlapResult<TYPE>> result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [LineD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.LineD.html) | line |     |
| System.Collections.Generic.List<[MyLineSegmentOverlapResult](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyLineSegmentOverlapResult-1.html)<TYPE>> | result |     |

#### QuerySphere(ref BoundingSphereD, List<TYPE>)

##### Declaration

```
public void QuerySphere(ref BoundingSphereD sphere, List<TYPE> result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html) | sphere |     |
| System.Collections.Generic.List<TYPE> | result |     |

### Extension Methods