---
title: "Class MyObjectBuilder\\_AnimationTree"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTree.html"
category: "Misc"
namespace: "VRage.Game.ObjectBuilders"
class: "MyObjectBuilder_AnimationTree"
---

# Class MyObjectBuilder\_AnimationTree | Space Engineers ModAPI

Root node of the whole animation tree. Supports storing of orphaned nodes.

##### Inheritance

System.Object

MyObjectBuilder\_AnimationTree

##### Inherited Members

###### **Namespace**: [VRage.Game.ObjectBuilders](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
[MyObjectBuilderDefinition]
public class MyObjectBuilder_AnimationTree : MyObjectBuilder_AnimationTreeNode
```

### Constructors

#### MyObjectBuilder\_AnimationTree()

##### Declaration

```
public MyObjectBuilder_AnimationTree()
```

### Fields

#### Child

##### Declaration

```
public MyObjectBuilder_AnimationTreeNode Child
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_AnimationTreeNode](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNode.html) |     |

#### Orphans

##### Declaration

```
public MyObjectBuilder_AnimationTreeNode[] Orphans
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_AnimationTreeNode](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNode.html)\[\] |     |

### Methods

#### DeepCopyWithMask(HashSet<MyObjectBuilder\_AnimationTreeNode>)

Create deep copy of this node and its children.

##### Declaration

```
public MyObjectBuilder_AnimationTree DeepCopyWithMask(HashSet<MyObjectBuilder_AnimationTreeNode> selectedNodes)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.HashSet<[MyObjectBuilder\_AnimationTreeNode](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNode.html)\> | selectedNodes | the mask |

##### Returns

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_AnimationTree](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTree.html) | copied hierarchy |

#### DeepCopyWithMask(HashSet<MyObjectBuilder\_AnimationTreeNode>, MyObjectBuilder\_AnimationTreeNode, List<MyObjectBuilder\_AnimationTreeNode>)

##### Declaration

```
protected override MyObjectBuilder_AnimationTreeNode DeepCopyWithMask(HashSet<MyObjectBuilder_AnimationTreeNode> selectedNodes, MyObjectBuilder_AnimationTreeNode parentNode, List<MyObjectBuilder_AnimationTreeNode> orphans)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.HashSet<[MyObjectBuilder\_AnimationTreeNode](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNode.html)\> | selectedNodes |     |
| [MyObjectBuilder\_AnimationTreeNode](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNode.html) | parentNode |     |
| System.Collections.Generic.List<[MyObjectBuilder\_AnimationTreeNode](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNode.html)\> | orphans |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_AnimationTreeNode](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNode.html) |     |

##### Overrides

#### GetChildren()

##### Declaration

```
public override MyObjectBuilder_AnimationTreeNode[] GetChildren()
```

##### Returns

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_AnimationTreeNode](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNode.html)\[\] |     |

##### Overrides

### Extension Methods