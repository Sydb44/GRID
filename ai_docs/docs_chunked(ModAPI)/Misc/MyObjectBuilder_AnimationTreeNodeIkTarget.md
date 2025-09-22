---
title: "Class MyObjectBuilder\\_AnimationTreeNodeIkTarget"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNodeIkTarget.html"
category: "Misc"
namespace: "VRage.Game.ObjectBuilders"
class: "MyObjectBuilder_AnimationTreeNodeIkTarget"
---

# Class MyObjectBuilder\_AnimationTreeNodeIkTarget | Space Engineers ModAPI

Track node, storing information about track and playing settings.

##### Inheritance

System.Object

MyObjectBuilder\_AnimationTreeNodeIkTarget

##### Inherited Members

###### **Namespace**: [VRage.Game.ObjectBuilders](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
[MyObjectBuilderDefinition]
public class MyObjectBuilder_AnimationTreeNodeIkTarget : MyObjectBuilder_AnimationTreeNode
```

### [](#constructors)Constructors

#### [](#VRage_Game_ObjectBuilders_MyObjectBuilder_AnimationTreeNodeIkTarget__ctor)MyObjectBuilder\_AnimationTreeNodeIkTarget()

##### Declaration

```
public MyObjectBuilder_AnimationTreeNodeIkTarget()
```

### [](#fields)Fields

#### [](#VRage_Game_ObjectBuilders_MyObjectBuilder_AnimationTreeNodeIkTarget_BoneChain)BoneChain

Name of the bones which form the chain.

##### Declaration

```
public string[] BoneChain
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String\[\] |     |

#### [](#VRage_Game_ObjectBuilders_MyObjectBuilder_AnimationTreeNodeIkTarget_TargetBoneName)TargetBoneName

Name of the bone which serves as a target for the end effector.

##### Declaration

```
public string TargetBoneName
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### [](#VRage_Game_ObjectBuilders_MyObjectBuilder_AnimationTreeNodeIkTarget_TargetPoint)TargetPoint

Target point name.

##### Declaration

```
public string TargetPoint
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

### [](#methods)Methods

#### [](#VRage_Game_ObjectBuilders_MyObjectBuilder_AnimationTreeNodeIkTarget_DeepCopyWithMask_System_Collections_Generic_HashSet_VRage_Game_ObjectBuilders_MyObjectBuilder_AnimationTreeNode__VRage_Game_ObjectBuilders_MyObjectBuilder_AnimationTreeNode_System_Collections_Generic_List_VRage_Game_ObjectBuilders_MyObjectBuilder_AnimationTreeNode__)DeepCopyWithMask(HashSet<MyObjectBuilder\_AnimationTreeNode>, MyObjectBuilder\_AnimationTreeNode, List<MyObjectBuilder\_AnimationTreeNode>)

##### Declaration

```
protected override MyObjectBuilder_AnimationTreeNode DeepCopyWithMask(HashSet<MyObjectBuilder_AnimationTreeNode> selectedNodes, MyObjectBuilder_AnimationTreeNode parentNode, List<MyObjectBuilder_AnimationTreeNode> orphans)
```

##### Parameters

##### Returns

##### Overrides

#### [](#VRage_Game_ObjectBuilders_MyObjectBuilder_AnimationTreeNodeIkTarget_GetChildren)GetChildren()

##### Declaration

```
public override MyObjectBuilder_AnimationTreeNode[] GetChildren()
```

##### Returns

##### Overrides

### [](#extensionmethods)Extension Methods