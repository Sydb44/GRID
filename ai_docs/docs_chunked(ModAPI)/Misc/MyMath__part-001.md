---
title: "Class MyMath"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyMath.html"
category: "Misc"
namespace: "VRageMath"
class: "MyMath"
---

# Class MyMath | Space Engineers ModAPI

##### Inheritance

System.Object

MyMath

###### **Namespace**: [VRageMath](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.html)

###### **Assembly**: VRage.Math.dll

##### Syntax

```
public static class MyMath : Object
```

### Fields

#### Vector3One

##### Declaration

```
public static Vector3 Vector3One
```

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

### Methods

#### Abs(ref Vector3)

##### Declaration

```
public static Vector3 Abs(ref Vector3 vector)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | vector |     |

##### Returns

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### AngleBetween(Vector3, Vector3)

##### Declaration

```
public static float AngleBetween(Vector3 a, Vector3 b)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | a   |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | b   |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### AngleTo(Vector3, Vector3)

AngleTo

##### Declaration

```
public static Vector3 AngleTo(Vector3 From, Vector3 Location)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | From |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | Location |     |

##### Returns

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | Angle between the vector lines |

#### ArcTanAngle(Single, Single)

ArcTanAngle

##### Declaration

```
public static float ArcTanAngle(float x, float y)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | x   |     |
| System.Single | y   |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Single | ArcTan angle between x and y |

#### Clamp(Single, Single, Single)

##### Declaration

```
public static float Clamp(float val, float min, float max)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | val |     |
| System.Single | min |     |
| System.Single | max |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### CosineDistance(ref Vector3, ref Vector3)

##### Declaration

```
public static float CosineDistance(ref Vector3 a, ref Vector3 b)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | a   |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | b   |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### CosineDistance(ref Vector3D, ref Vector3D)

##### Declaration

```
public static double CosineDistance(ref Vector3D a, ref Vector3D b)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | a   |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | b   |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Double |     |

#### CreateFromInsideRadius(Single)

##### Declaration

```
public static BoundingBox CreateFromInsideRadius(float radius)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | radius |     |

##### Returns

| Type | Description |
| --- | --- |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) |     |

#### DistanceSquaredFromLineSegment(Vector3, Vector3, Vector3)

Return minimum distance between line segment v-w and point p.

##### Declaration

```
public static float DistanceSquaredFromLineSegment(Vector3 v, Vector3 w, Vector3 p)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | v   |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | w   |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | p   |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### FastCos(Single)

##### Declaration

```
public static float FastCos(float angle)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | angle |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### FastSin(Single)

##### Declaration

```
public static float FastSin(float angle)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | angle |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### FastTanH(Single)

Fast approximation of Hyperbolic tangent Max deviation is <3%

##### Declaration

```
public static float FastTanH(float x)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | x   |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### ForwardVectorProjection(Vector3, Vector3)

This projection results to initial velocity of non-engine objects, which parents move in some velocity We want to add only forward speed of the parent to the forward direction of the object, and if parent is going backward, no speed is added.
