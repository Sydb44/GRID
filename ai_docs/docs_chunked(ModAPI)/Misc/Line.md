---
title: "Class Line"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Line.html"
category: "Misc"
namespace: "VRageMath"
class: "Line"
---

# Class Line | Space Engineers ModAPI

##### Inheritance

System.Object

Line

###### **Namespace**: [VRageMath](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.html)

###### **Assembly**: VRage.Math.dll

##### Syntax

```
public sealed class Line : ValueType
```

### Constructors

#### Line(Vector3, Vector3, Boolean)

##### Declaration

```
public Line(Vector3 from, Vector3 to, bool calculateBoundingBox = true)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | from |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | to  |     |
| System.Boolean | calculateBoundingBox |     |

### Fields

#### BoundingBox

##### Declaration

```
public BoundingBox BoundingBox
```

##### Field Value

| Type | Description |
| --- | --- |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) |     |

#### Direction

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### From

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### Length

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### To

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

### Methods

#### GetShortestDistanceSquared(Line, Line)

##### Declaration

```
public static float GetShortestDistanceSquared(Line line1, Line line2)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Line](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Line.html) | line1 |     |
| [Line](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Line.html) | line2 |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### GetShortestVector(ref Line, ref Line, out Vector3, out Vector3)

##### Declaration

```
public static Vector3 GetShortestVector(ref Line line1, ref Line line2, out Vector3 res1, out Vector3 res2)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Line](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Line.html) | line1 |     |
| [Line](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Line.html) | line2 |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | res1 |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | res2 |     |

##### Returns

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |