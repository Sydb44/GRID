---
title: "Class MyObjectBuilder\\_AnimationTreeNodeMix1D"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNodeMix1D.html"
category: "Misc"
namespace: "VRage.Game.ObjectBuilders"
class: "MyObjectBuilder_AnimationTreeNodeMix1D"
---

# Class MyObjectBuilder\_AnimationTreeNodeMix1D | Space Engineers ModAPI

Linear mixing node. Maps child nodes on 1D axis, interpolates according to parameter value.

##### Inheritance

System.Object

MyObjectBuilder\_AnimationTreeNodeMix1D

##### Inherited Members

###### **Namespace**: [VRage.Game.ObjectBuilders](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
[MyObjectBuilderDefinition]
public class MyObjectBuilder_AnimationTreeNodeMix1D : MyObjectBuilder_AnimationTreeNode
```

### [](#constructors)Constructors

#### [](#VRage_Game_ObjectBuilders_MyObjectBuilder_AnimationTreeNodeMix1D__ctor)MyObjectBuilder\_AnimationTreeNodeMix1D()

##### Declaration

```
public MyObjectBuilder_AnimationTreeNodeMix1D()
```

### [](#fields)Fields

#### [](#VRage_Game_ObjectBuilders_MyObjectBuilder_AnimationTreeNodeMix1D_Children)Children

Mapping children to axis. Each child has assigned its value.

##### Declaration

```
public MyParameterAnimTreeNodeMapping[] Children
```

##### Field Value

#### [](#VRage_Game_ObjectBuilders_MyObjectBuilder_AnimationTreeNodeMix1D_Circular)Circular

True if the value wraps around.

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Game_ObjectBuilders_MyObjectBuilder_AnimationTreeNodeMix1D_MaxChange)MaxChange

Threshold: maximum change of variable to take sensitivity in account, if crossed, value is set immediatelly.

##### Declaration

```
public Nullable<float> MaxChange
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<System.Single\> |     |

#### [](#VRage_Game_ObjectBuilders_MyObjectBuilder_AnimationTreeNodeMix1D_ParameterName)ParameterName

Name of parameter controlling blending inside this node.

##### Declaration

```
public string ParameterName
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### [](#VRage_Game_ObjectBuilders_MyObjectBuilder_AnimationTreeNodeMix1D_Sensitivity)Sensitivity

Sensitivity to changes of parameter value. 1=immediate change, 0=no sensitivity.

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

### [](#methods)Methods

#### [](#VRage_Game_ObjectBuilders_MyObjectBuilder_AnimationTreeNodeMix1D_DeepCopyWithMask_System_Collections_Generic_HashSet_VRage_Game_ObjectBuilders_MyObjectBuilder_AnimationTreeNode__VRage_Game_ObjectBuilders_MyObjectBuilder_AnimationTreeNode_System_Collections_Generic_List_VRage_Game_ObjectBuilders_MyObjectBuilder_AnimationTreeNode__)DeepCopyWithMask(HashSet<MyObjectBuilder\_AnimationTreeNode>, MyObjectBuilder\_AnimationTreeNode, List<MyObjectBuilder\_AnimationTreeNode>)

##### Declaration

```
protected override MyObjectBuilder_AnimationTreeNode DeepCopyWithMask(HashSet<MyObjectBuilder_AnimationTreeNode> selectedNodes, MyObjectBuilder_AnimationTreeNode parentNode, List<MyObjectBuilder_AnimationTreeNode> orphans)
```

##### Parameters

##### Returns

##### Overrides

#### [](#VRage_Game_ObjectBuilders_MyObjectBuilder_AnimationTreeNodeMix1D_GetChildren)GetChildren()

##### Declaration

```
public override MyObjectBuilder_AnimationTreeNode[] GetChildren()
```

##### Returns

##### Overrides

### [](#extensionmethods)Extension Methods