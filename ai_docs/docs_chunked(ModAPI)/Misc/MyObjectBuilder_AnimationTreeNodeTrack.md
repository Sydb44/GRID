---
title: "Class MyObjectBuilder\\_AnimationTreeNodeTrack"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.MyObjectBuilder_AnimationTreeNodeTrack.html"
category: "Misc"
namespace: "VRage.Game.ObjectBuilders"
class: "MyObjectBuilder_AnimationTreeNodeTrack"
---

# Class MyObjectBuilder\_AnimationTreeNodeTrack | Space Engineers ModAPI

Track node, storing information about track and playing settings.

##### Inheritance

System.Object

MyObjectBuilder\_AnimationTreeNodeTrack

##### Inherited Members

###### **Namespace**: [VRage.Game.ObjectBuilders](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
[MyObjectBuilderDefinition]
public class MyObjectBuilder_AnimationTreeNodeTrack : MyObjectBuilder_AnimationTreeNode
```

### [](#constructors)Constructors

#### [](#VRage_Game_ObjectBuilders_MyObjectBuilder_AnimationTreeNodeTrack__ctor)MyObjectBuilder\_AnimationTreeNodeTrack()

##### Declaration

```
public MyObjectBuilder_AnimationTreeNodeTrack()
```

### [](#fields)Fields

#### [](#VRage_Game_ObjectBuilders_MyObjectBuilder_AnimationTreeNodeTrack_AnimationName)AnimationName

Name of used track (animation) in MWM file.

##### Declaration

```
public string AnimationName
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### [](#VRage_Game_ObjectBuilders_MyObjectBuilder_AnimationTreeNodeTrack_Interpolate)Interpolate

Interpolate between keyframes. If false, track will be played frame by frame.

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Game_ObjectBuilders_MyObjectBuilder_AnimationTreeNodeTrack_Loop)Loop

If true, animation will be looped. Default value is true.

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Game_ObjectBuilders_MyObjectBuilder_AnimationTreeNodeTrack_PathToModel)PathToModel

Path to MWM file.

##### Declaration

```
public string PathToModel
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### [](#VRage_Game_ObjectBuilders_MyObjectBuilder_AnimationTreeNodeTrack_Speed)Speed

Playing speed multiplier.

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Double |     |

#### [](#VRage_Game_ObjectBuilders_MyObjectBuilder_AnimationTreeNodeTrack_SynchronizeWithLayer)SynchronizeWithLayer

Synchronize time in this track with the specified layer.

##### Declaration

```
public string SynchronizeWithLayer
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

### [](#methods)Methods

#### [](#VRage_Game_ObjectBuilders_MyObjectBuilder_AnimationTreeNodeTrack_DeepCopyWithMask_System_Collections_Generic_HashSet_VRage_Game_ObjectBuilders_MyObjectBuilder_AnimationTreeNode__VRage_Game_ObjectBuilders_MyObjectBuilder_AnimationTreeNode_System_Collections_Generic_List_VRage_Game_ObjectBuilders_MyObjectBuilder_AnimationTreeNode__)DeepCopyWithMask(HashSet<MyObjectBuilder\_AnimationTreeNode>, MyObjectBuilder\_AnimationTreeNode, List<MyObjectBuilder\_AnimationTreeNode>)

##### Declaration

```
protected override MyObjectBuilder_AnimationTreeNode DeepCopyWithMask(HashSet<MyObjectBuilder_AnimationTreeNode> selectedNodes, MyObjectBuilder_AnimationTreeNode parentNode, List<MyObjectBuilder_AnimationTreeNode> orphans)
```

##### Parameters

##### Returns

##### Overrides

#### [](#VRage_Game_ObjectBuilders_MyObjectBuilder_AnimationTreeNodeTrack_GetChildren)GetChildren()

##### Declaration

```
public override MyObjectBuilder_AnimationTreeNode[] GetChildren()
```

##### Returns

##### Overrides

### [](#extensionmethods)Extension Methods