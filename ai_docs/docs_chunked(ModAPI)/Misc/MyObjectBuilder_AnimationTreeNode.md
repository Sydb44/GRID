---
title: "Class MyObjectBuilder\\_AnimationTreeNode"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNode.html"
category: "Misc"
namespace: "VRage.Game.ObjectBuilders"
class: "MyObjectBuilder_AnimationTreeNode"
---

# Class MyObjectBuilder\_AnimationTreeNode | Space Engineers ModAPI

Base class of all object builders of animation tree nodes.

##### Inheritance

System.Object

MyObjectBuilder\_AnimationTreeNode

##### Inherited Members

###### **Namespace**: [VRage.Game.ObjectBuilders](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
[MyObjectBuilderDefinition]
public abstract class MyObjectBuilder_AnimationTreeNode : MyObjectBuilder_Base
```

### [](#constructors)Constructors

#### [](#VRage_Game_ObjectBuilders_MyObjectBuilder_AnimationTreeNode__ctor)MyObjectBuilder\_AnimationTreeNode()

##### Declaration

```
protected MyObjectBuilder_AnimationTreeNode()
```

### [](#fields)Fields

#### [](#VRage_Game_ObjectBuilders_MyObjectBuilder_AnimationTreeNode_EdPos)EdPos

Position in editor.

##### Declaration

```
public Nullable<Vector2I> EdPos
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<[Vector2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2I.html)\> |     |

#### [](#VRage_Game_ObjectBuilders_MyObjectBuilder_AnimationTreeNode_EventNames)EventNames

##### Declaration

```
public List<string> EventNames
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<System.String\> |     |

#### [](#VRage_Game_ObjectBuilders_MyObjectBuilder_AnimationTreeNode_EventTimes)EventTimes

##### Declaration

```
public List<double> EventTimes
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<System.Double\> |     |

#### [](#VRage_Game_ObjectBuilders_MyObjectBuilder_AnimationTreeNode_Key)Key

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

### [](#methods)Methods

#### [](#VRage_Game_ObjectBuilders_MyObjectBuilder_AnimationTreeNode_DeepCopyWithMask_System_Collections_Generic_HashSet_VRage_Game_ObjectBuilders_MyObjectBuilder_AnimationTreeNode__VRage_Game_ObjectBuilders_MyObjectBuilder_AnimationTreeNode_System_Collections_Generic_List_VRage_Game_ObjectBuilders_MyObjectBuilder_AnimationTreeNode__)DeepCopyWithMask(HashSet<MyObjectBuilder\_AnimationTreeNode>, MyObjectBuilder\_AnimationTreeNode, List<MyObjectBuilder\_AnimationTreeNode>)

Create deep copy of this node and its children.

##### Declaration

```
protected abstract MyObjectBuilder_AnimationTreeNode DeepCopyWithMask(HashSet<MyObjectBuilder_AnimationTreeNode> selectedNodes, MyObjectBuilder_AnimationTreeNode parentNode, List<MyObjectBuilder_AnimationTreeNode> orphans)
```

##### Parameters

##### Returns

#### [](#VRage_Game_ObjectBuilders_MyObjectBuilder_AnimationTreeNode_GetChildren)GetChildren()

Get the child nodes of this node.

##### Declaration

```
public abstract MyObjectBuilder_AnimationTreeNode[] GetChildren()
```

##### Returns

### [](#extensionmethods)Extension Methods