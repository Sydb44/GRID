---
title: "Class MyAnimationControllerComponent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyAnimationControllerComponent.html"
category: "Components"
namespace: "VRage.Game.Components"
class: "MyAnimationControllerComponent"
---

# Class MyAnimationControllerComponent | Space Engineers ModAPI

Entity component containing animation controller.

##### Inheritance

System.Object

MyAnimationControllerComponent

##### Inherited Members

###### **Namespace**: [VRage.Game.Components](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public class MyAnimationControllerComponent : MyEntityComponentBase, IMyEntityComponentBase, IMyComponentBase
```

### [](#constructors)Constructors

#### [](#VRage_Game_Components_MyAnimationControllerComponent__ctor_VRage_Game_Entity_MyEntity_System_Action_VRageRender_Animations_IMyTerrainHeightProvider_)MyAnimationControllerComponent(MyEntity, Action, IMyTerrainHeightProvider)

##### Declaration

```
public MyAnimationControllerComponent(MyEntity entity, Action obtainBones, IMyTerrainHeightProvider heightProvider)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) | entity |     |
| System.Action | obtainBones |     |
| VRageRender.Animations.IMyTerrainHeightProvider | heightProvider |     |

### [](#fields)Fields

#### [](#VRage_Game_Components_MyAnimationControllerComponent_CameraDistance)CameraDistance

##### Declaration

```
public float CameraDistance
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### [](#VRage_Game_Components_MyAnimationControllerComponent_MainLayerAnimationSpeed)MainLayerAnimationSpeed

##### Declaration

```
public float MainLayerAnimationSpeed
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### [](#VRage_Game_Components_MyAnimationControllerComponent_OtherLayersAnimationSpeed)OtherLayersAnimationSpeed

##### Declaration

```
public float OtherLayersAnimationSpeed
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### [](#VRage_Game_Components_MyAnimationControllerComponent_ReloadBonesNeeded)ReloadBonesNeeded

##### Declaration

```
public readonly Action ReloadBonesNeeded
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Action |     |

### [](#properties)Properties

#### [](#VRage_Game_Components_MyAnimationControllerComponent_BoneAbsoluteTransforms)BoneAbsoluteTransforms

##### Declaration

```
public Matrix[] BoneAbsoluteTransforms { get; }
```

##### Property Value

#### [](#VRage_Game_Components_MyAnimationControllerComponent_BoneRelativeTransforms)BoneRelativeTransforms

##### Declaration

```
public Matrix[] BoneRelativeTransforms { get; }
```

##### Property Value

#### [](#VRage_Game_Components_MyAnimationControllerComponent_CharacterBones)CharacterBones

Get reference to array of character pack and its contents.

##### Declaration

```
public MyCharacterBone[] CharacterBones { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| VRageRender.Animations.MyCharacterBone\[\] |     |

#### [](#VRage_Game_Components_MyAnimationControllerComponent_CharacterBonesSorted)CharacterBonesSorted

##### Declaration

```
public MyCharacterBone[] CharacterBonesSorted { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| VRageRender.Animations.MyCharacterBone\[\] |     |

#### [](#VRage_Game_Components_MyAnimationControllerComponent_ComponentTypeDebugString)ComponentTypeDebugString

Name of the component type for debug purposes (e.g.: "Position")

##### Declaration

```
public override string ComponentTypeDebugString { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

##### Overrides

#### [](#VRage_Game_Components_MyAnimationControllerComponent_Controller)Controller

Get the animation controller instance.

##### Declaration

```
public MyAnimationController Controller { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| VRageRender.Animations.MyAnimationController |     |

#### [](#VRage_Game_Components_MyAnimationControllerComponent_InverseKinematics)InverseKinematics

Get the instance of inverse kinematics.

##### Declaration

```
public MyAnimationInverseKinematics InverseKinematics { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| VRageRender.Animations.MyAnimationInverseKinematics |     |

#### [](#VRage_Game_Components_MyAnimationControllerComponent_LastFrameActions)LastFrameActions

##### Declaration

```
public List<MyStringId> LastFrameActions { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html)\> |     |

#### [](#VRage_Game_Components_MyAnimationControllerComponent_LastRawBoneResult)LastRawBoneResult

##### Declaration

```
public MyAnimationClip.BoneState[] LastRawBoneResult { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| VRageRender.Animations.MyAnimationClip.BoneState\[\] |     |

#### [](#VRage_Game_Components_MyAnimationControllerComponent_SourceId)SourceId

##### Declaration

```
public MyDefinitionId SourceId { get; set; }
```

##### Property Value

#### [](#VRage_Game_Components_MyAnimationControllerComponent_Variables)Variables

Get the variable storage of animation controller instance. Shortcut.

##### Declaration

```
public IMyVariableStorage<float> Variables { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| VRage.Generics.IMyVariableStorage<System.Single\> |     |

### [](#methods)Methods

#### [](#VRage_Game_Components_MyAnimationControllerComponent_ApplyVariables)ApplyVariables()

##### Declaration

```
public void ApplyVariables()
```
