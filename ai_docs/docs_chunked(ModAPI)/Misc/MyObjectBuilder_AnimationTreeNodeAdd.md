---
title: "Class MyObjectBuilder\\_AnimationTreeNodeAdd"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNodeAdd.html"
category: "Misc"
namespace: "VRage.Game.ObjectBuilders"
class: "MyObjectBuilder_AnimationTreeNodeAdd"
---

# Class MyObjectBuilder\_AnimationTreeNodeAdd | Space Engineers ModAPI

Additive node. Child nodes are base node + additive node.

##### Inheritance

System.Object

MyObjectBuilder\_AnimationTreeNodeAdd

##### Inherited Members

###### **Namespace**: [VRage.Game.ObjectBuilders](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
[MyObjectBuilderDefinition]
public class MyObjectBuilder_AnimationTreeNodeAdd : MyObjectBuilder_AnimationTreeNode
```

### [](#constructors)Constructors

#### [](#VRage_Game_ObjectBuilders_MyObjectBuilder_AnimationTreeNodeAdd__ctor)MyObjectBuilder\_AnimationTreeNodeAdd()

##### Declaration

```
public MyObjectBuilder_AnimationTreeNodeAdd()
```

### [](#fields)Fields

#### [](#VRage_Game_ObjectBuilders_MyObjectBuilder_AnimationTreeNodeAdd_AddNode)AddNode

Child node, additive "layer".

##### Declaration

```
public MyParameterAnimTreeNodeMapping AddNode
```

##### Field Value

#### [](#VRage_Game_ObjectBuilders_MyObjectBuilder_AnimationTreeNodeAdd_BaseNode)BaseNode

Child node, base "layer".

##### Declaration

```
public MyParameterAnimTreeNodeMapping BaseNode
```

##### Field Value

#### [](#VRage_Game_ObjectBuilders_MyObjectBuilder_AnimationTreeNodeAdd_ParameterName)ParameterName

Name of parameter controlling blending inside this node.

##### Declaration

```
public string ParameterName
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

### [](#methods)Methods

#### [](#VRage_Game_ObjectBuilders_MyObjectBuilder_AnimationTreeNodeAdd_DeepCopyWithMask_System_Collections_Generic_HashSet_VRage_Game_ObjectBuilders_MyObjectBuilder_AnimationTreeNode__VRage_Game_ObjectBuilders_MyObjectBuilder_AnimationTreeNode_System_Collections_Generic_List_VRage_Game_ObjectBuilders_MyObjectBuilder_AnimationTreeNode__)DeepCopyWithMask(HashSet<MyObjectBuilder\_AnimationTreeNode>, MyObjectBuilder\_AnimationTreeNode, List<MyObjectBuilder\_AnimationTreeNode>)

##### Declaration

```
protected override MyObjectBuilder_AnimationTreeNode DeepCopyWithMask(HashSet<MyObjectBuilder_AnimationTreeNode> selectedNodes, MyObjectBuilder_AnimationTreeNode parentNode, List<MyObjectBuilder_AnimationTreeNode> orphans)
```

##### Parameters

##### Returns

##### Overrides

#### [](#VRage_Game_ObjectBuilders_MyObjectBuilder_AnimationTreeNodeAdd_GetChildren)GetChildren()

##### Declaration

```
public override MyObjectBuilder_AnimationTreeNode[] GetChildren()
```

##### Returns

##### Overrides

### [](#extensionmethods)Extension Methods