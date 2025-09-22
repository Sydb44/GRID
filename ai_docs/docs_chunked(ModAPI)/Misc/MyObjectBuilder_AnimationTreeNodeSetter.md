---
title: "Class MyObjectBuilder\\_AnimationTreeNodeSetter"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNodeSetter.html"
category: "Misc"
namespace: "VRage.Game.ObjectBuilders"
class: "MyObjectBuilder_AnimationTreeNodeSetter"
---

# Class MyObjectBuilder\_AnimationTreeNodeSetter | Space Engineers ModAPI

Setter node, storing information about timed variable setting.

##### Inheritance

System.Object

MyObjectBuilder\_AnimationTreeNodeSetter

##### Inherited Members

###### **Namespace**: [VRage.Game.ObjectBuilders](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
[MyObjectBuilderDefinition]
public class MyObjectBuilder_AnimationTreeNodeSetter : MyObjectBuilder_AnimationTreeNode
```

### [](#constructors)Constructors

#### [](#VRage_Game_ObjectBuilders_MyObjectBuilder_AnimationTreeNodeSetter__ctor)MyObjectBuilder\_AnimationTreeNodeSetter()

##### Declaration

```
public MyObjectBuilder_AnimationTreeNodeSetter()
```

### [](#fields)Fields

#### [](#VRage_Game_ObjectBuilders_MyObjectBuilder_AnimationTreeNodeSetter_Child)Child

Link to the child node.

##### Declaration

```
public MyObjectBuilder_AnimationTreeNode Child
```

##### Field Value

#### [](#VRage_Game_ObjectBuilders_MyObjectBuilder_AnimationTreeNodeSetter_ResetValue)ResetValue

Value that is set to animation storage once we leave current animation state.

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### [](#VRage_Game_ObjectBuilders_MyObjectBuilder_AnimationTreeNodeSetter_ResetValueEnabled)ResetValueEnabled

When the, the automatic resetting is enabled.

##### Declaration

```
public bool ResetValueEnabled
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Game_ObjectBuilders_MyObjectBuilder_AnimationTreeNodeSetter_Time)Time

Local animation time when the value should be set.

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### [](#VRage_Game_ObjectBuilders_MyObjectBuilder_AnimationTreeNodeSetter_Value)Value

Value that is set to animation storage once time spent in the node exceeds specified time (MyAnimationTreeNodeSetter.Time).

##### Declaration

```
public MyObjectBuilder_AnimationTreeNodeSetter.ValueAssignment Value
```

##### Field Value

### [](#methods)Methods

#### [](#VRage_Game_ObjectBuilders_MyObjectBuilder_AnimationTreeNodeSetter_DeepCopyWithMask_System_Collections_Generic_HashSet_VRage_Game_ObjectBuilders_MyObjectBuilder_AnimationTreeNode__VRage_Game_ObjectBuilders_MyObjectBuilder_AnimationTreeNode_System_Collections_Generic_List_VRage_Game_ObjectBuilders_MyObjectBuilder_AnimationTreeNode__)DeepCopyWithMask(HashSet<MyObjectBuilder\_AnimationTreeNode>, MyObjectBuilder\_AnimationTreeNode, List<MyObjectBuilder\_AnimationTreeNode>)

##### Declaration

```
protected override MyObjectBuilder_AnimationTreeNode DeepCopyWithMask(HashSet<MyObjectBuilder_AnimationTreeNode> selectedNodes, MyObjectBuilder_AnimationTreeNode parentNode, List<MyObjectBuilder_AnimationTreeNode> orphans)
```

##### Parameters

##### Returns

##### Overrides

#### [](#VRage_Game_ObjectBuilders_MyObjectBuilder_AnimationTreeNodeSetter_GetChildren)GetChildren()

##### Declaration

```
public override MyObjectBuilder_AnimationTreeNode[] GetChildren()
```

##### Returns

##### Overrides

### [](#extensionmethods)Extension Methods