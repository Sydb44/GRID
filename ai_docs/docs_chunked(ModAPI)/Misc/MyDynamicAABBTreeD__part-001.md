---
title: "Class MyDynamicAABBTreeD"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyDynamicAABBTreeD.html"
category: "Misc"
namespace: "VRageMath"
class: "MyDynamicAABBTreeD"
---

# Class MyDynamicAABBTreeD | Space Engineers ModAPI

Dynamic aabb tree implementation as a prunning structure

##### Inheritance

System.Object

MyDynamicAABBTreeD

###### **Namespace**: [VRageMath](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.html)

###### **Assembly**: VRage.Math.dll

##### Syntax

```
public class MyDynamicAABBTreeD : Object
```

### Constructors

#### MyDynamicAABBTreeD()

##### Declaration

```
public MyDynamicAABBTreeD()
```

#### MyDynamicAABBTreeD(Vector3D, Double)

##### Declaration

```
public MyDynamicAABBTreeD(Vector3D extension, double aabbMultiplier = 1)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | extension |     |
| System.Double | aabbMultiplier |     |

### Fields

#### NullNode

A dynamic tree arranges data in a binary tree to accelerate queries such as volume queries and ray casts. Leafs are proxies with an BoundingBox. In the tree we expand the proxy BoundingBox by Settings.b2\_fatAABBFactor so that the proxy BoundingBox is bigger than the client object. This allows the client object to move by small amounts without triggering a tree update. Nodes are pooled and relocatable, so we use node indices rather than pointers.

##### Declaration

```
public const int NullNode = -1
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

### Properties

#### ElementsCount

##### Declaration

```
public int ElementsCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

### Methods

#### AddProxy(ref BoundingBoxD, Object, UInt32, Boolean)

Create a proxy. Provide a tight fitting BoundingBox and a userData pointer.

##### Declaration

```
public int AddProxy(ref BoundingBoxD aabb, object userData, uint userFlags, bool rebalance = true)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | aabb | The aabb. |
| System.Object | userData | The user data. |
| System.UInt32 | userFlags |     |
| System.Boolean | rebalance |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### Balance(Int32)

##### Declaration

```
public int Balance(int iA)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | iA  |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### Clear()

##### Declaration

#### CountLeaves(Int32)

##### Declaration

```
public int CountLeaves(int nodeId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | nodeId |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### Dispose()

##### Declaration

```
public static void Dispose()
```

#### GetAabb(Int32)

##### Declaration

```
public BoundingBoxD GetAabb(int proxyId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | proxyId |     |

##### Returns

| Type | Description |
| --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) |     |

#### GetAll<T>(Action<T, BoundingBoxD>)

##### Declaration

```
public void GetAll<T>(Action<T, BoundingBoxD> add)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Action<T, [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html)\> | add |     |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

#### GetAll<T>(Action<T>)

##### Declaration

```
public void GetAll<T>(Action<T> add)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Action<T> | add |     |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

#### GetAll<T>(List<T>, Boolean, List<BoundingBoxD>)

##### Declaration

```
public void GetAll<T>(List<T> elementsList, bool clear, List<BoundingBoxD> boxsList = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<T> | elementsList |     |
| System.Boolean | clear |     |
| System.Collections.Generic.List<[BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html)\> | boxsList |     |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

#### GetAllNodeBounds(List<BoundingBoxD>)

##### Declaration

```
public void GetAllNodeBounds(List<BoundingBoxD> boxsList)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<[BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html)\> | boxsList |     |

#### GetAproximateClustersForAabb(ref BoundingBoxD, Double, List<BoundingBoxD>)

##### Declaration

```
public void GetAproximateClustersForAabb(ref BoundingBoxD bbox, double minSize, List<BoundingBoxD> boundList)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | bbox |     |
| System.Double | minSize |     |
| System.Collections.Generic.List<[BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html)\> | boundList |     |

#### GetAproximateClustersForAabbDebug(ref BoundingBoxD, Double, List<BoundingBoxD>, List<MyTuple<Boolean, Int32, Object>>)

##### Declaration

```
public void GetAproximateClustersForAabbDebug(ref BoundingBoxD bbox, double minSize, List<BoundingBoxD> boundList, List<MyTuple<bool, int, object>> nodeList)
```
