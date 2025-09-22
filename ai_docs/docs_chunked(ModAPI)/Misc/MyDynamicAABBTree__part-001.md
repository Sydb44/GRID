---
title: "Class MyDynamicAABBTree"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyDynamicAABBTree.html"
category: "Misc"
namespace: "VRageMath"
class: "MyDynamicAABBTree"
---

# Class MyDynamicAABBTree | Space Engineers ModAPI

Dynamic aabb tree implementation as a prunning structure

##### Inheritance

System.Object

MyDynamicAABBTree

###### **Namespace**: [VRageMath](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.html)

###### **Assembly**: VRage.Math.dll

##### Syntax

```
public class MyDynamicAABBTree : Object
```

### Constructors

#### MyDynamicAABBTree()

##### Declaration

```
public MyDynamicAABBTree()
```

#### MyDynamicAABBTree(Vector3, Single)

##### Declaration

```
public MyDynamicAABBTree(Vector3 extension, float aabbMultiplier = 1F)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | extension |     |
| System.Single | aabbMultiplier |     |

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

#### Leaves

##### Declaration

```
public DictionaryValuesReader<int, MyDynamicAABBTree.DynamicTreeNode> Leaves { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [DictionaryValuesReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.DictionaryValuesReader-2.html)<System.Int32, [MyDynamicAABBTree.DynamicTreeNode](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyDynamicAABBTree.DynamicTreeNode.html)\> |     |

#### Nodes

##### Declaration

```
public ReadOnlySpan<MyDynamicAABBTree.DynamicTreeNode> Nodes { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.ReadOnlySpan<[MyDynamicAABBTree.DynamicTreeNode](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyDynamicAABBTree.DynamicTreeNode.html)\> |     |

### Methods

#### AddProxy(ref BoundingBox, Object, UInt32, Boolean)

Create a proxy. Provide a tight fitting BoundingBox and a userData pointer.

##### Declaration

```
public int AddProxy(ref BoundingBox aabb, object userData, uint userFlags, bool rebalance = true)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) | aabb | The aabb. |
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
public BoundingBox GetAabb(int proxyId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | proxyId |     |

##### Returns

| Type | Description |
| --- | --- |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) |     |

#### GetAll<T>(List<T>, Boolean, List<BoundingBox>)

##### Declaration

```
public void GetAll<T>(List<T> elementsList, bool clear, List<BoundingBox> boxsList = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<T> | elementsList |     |
| System.Boolean | clear |     |
| System.Collections.Generic.List<[BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html)\> | boxsList |     |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

#### GetAllNodeBounds(List<BoundingBox>)

##### Declaration

```
public void GetAllNodeBounds(List<BoundingBox> boxsList)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<[BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html)\> | boxsList |     |

#### GetChildren(Int32, out Int32, out Int32)

##### Declaration

```
public void GetChildren(int proxyId, out int left, out int right)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | proxyId |     |
| System.Int32 | left |     |
| System.Int32 | right |     |

#### GetFatAABB(Int32, out BoundingBox)

Get the fat BoundingBox for a proxy.

##### Declaration

```
public void GetFatAABB(int proxyId, out BoundingBox fatAABB)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | proxyId | The proxy id. |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) | fatAABB | The fat BoundingBox. |

#### GetHeight()

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### GetLeafCount()

##### Declaration

```
public int GetLeafCount()
```
