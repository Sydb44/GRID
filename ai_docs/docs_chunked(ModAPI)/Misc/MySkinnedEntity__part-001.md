---
title: "Class MySkinnedEntity"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MySkinnedEntity.html"
category: "Misc"
namespace: "Sandbox.Game.Entities"
class: "MySkinnedEntity"
---

# Class MySkinnedEntity | Space Engineers ModAPI

##### Inheritance

System.Object

MySkinnedEntity

##### Implements

##### Inherited Members

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public class MySkinnedEntity : MyEntity, IMySkinnedEntity, IMyParallelUpdateable, IMyEntity, IMyEntity
```

### Constructors

#### MySkinnedEntity()

##### Declaration

### Fields

#### m\_actualDrawFrame

##### Declaration

```
protected ulong m_actualDrawFrame
```

##### Field Value

| Type | Description |
| --- | --- |
| System.UInt64 |     |

#### m\_actualUpdateFrame

##### Declaration

```
protected ulong m_actualUpdateFrame
```

##### Field Value

| Type | Description |
| --- | --- |
| System.UInt64 |     |

#### m\_additionalRotations

##### Declaration

```
protected Dictionary<string, Quaternion> m_additionalRotations
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.Dictionary<System.String, [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html)\> |     |

#### UseNewAnimationSystem

VRAGE TODO: THIS IS TEMPORARY! Remove when by the time we use only the new animation system.

##### Declaration

```
public bool UseNewAnimationSystem
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Properties

#### AnimationController

##### Declaration

```
public MyAnimationControllerComponent AnimationController { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyAnimationControllerComponent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyAnimationControllerComponent.html) |     |

#### BoneAbsoluteTransforms

##### Declaration

```
public Matrix[] BoneAbsoluteTransforms { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)\[\] |     |

#### BoneRelativeTransforms

##### Declaration

```
public Matrix[] BoneRelativeTransforms { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)\[\] |     |

#### DecalBoneUpdates

##### Declaration

```
public List<MyBoneDecalUpdate> DecalBoneUpdates { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<VRageRender.Messages.MyBoneDecalUpdate\> |     |

#### UpdateFlags

##### Declaration

```
public MyParallelUpdateFlags UpdateFlags { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyParallelUpdateFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyParallelUpdateFlags.html) |     |

### Methods

#### AddBoneDecal(UInt32, Int32)

##### Declaration

```
protected void AddBoneDecal(uint decalId, int boneIndex)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.UInt32 | decalId |     |
| System.Int32 | boneIndex |     |

#### AddCommand(MyAnimationCommand, Boolean)

Enqueue animation command. Parameter sync is used in child classes.

##### Declaration

```
public virtual void AddCommand(MyAnimationCommand command, bool sync = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyAnimationCommand](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyAnimationCommand.html) | command |     |
| System.Boolean | sync |     |

#### CalculateTransforms(Single)

##### Declaration

```
protected virtual void CalculateTransforms(float distance)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | distance |     |

#### FlushAnimationQueue()

Process all commands in the animation queue at once. If any command is generated during flushing, it is processed as well.

##### Declaration

```
protected void FlushAnimationQueue()
```

#### GetAdditionalRotation(String)

##### Declaration

```
public Quaternion GetAdditionalRotation(string bone)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | bone |     |

##### Returns

| Type | Description |
| --- | --- |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) |     |

#### Init(StringBuilder, String, MyEntity, Nullable<Single>, String)

##### Declaration

```
public override void Init(StringBuilder displayName, string model, MyEntity parentObject, Nullable<float> scale, string modelCollision = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Text.StringBuilder | displayName |     |
| System.String | model |     |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) | parentObject |     |
| System.Nullable<System.Single\> | scale |     |
| System.String | modelCollision |     |

##### Overrides

#### InitBones()

##### Declaration

```
protected void InitBones()
```

#### ObtainBones()

Get the bones from the model and create a bone class object for each bone. We use our bone class to do the real animated bone work.

##### Declaration

```
public virtual void ObtainBones()
```

#### OnAnimationPlay(MyAnimationDefinition, MyAnimationCommand, ref String, ref MyFrameOption, ref Boolean)

Virtual method called when animation is started, used in MyCharacter.

##### Declaration

```
protected virtual void OnAnimationPlay(MyAnimationDefinition animDefinition, MyAnimationCommand command, ref string bonesArea, ref MyFrameOption frameOption, ref bool useFirstPersonVersion)
```
