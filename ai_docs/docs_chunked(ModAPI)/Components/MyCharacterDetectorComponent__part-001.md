---
title: "Class MyCharacterDetectorComponent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.Character.Components.MyCharacterDetectorComponent.html"
category: "Components"
namespace: "Sandbox.Game.Entities.Character.Components"
class: "MyCharacterDetectorComponent"
---

# Class MyCharacterDetectorComponent | Space Engineers ModAPI

##### Inheritance

System.Object

MyCharacterDetectorComponent

##### Implements

##### Inherited Members

###### **Namespace**: [Sandbox.Game.Entities.Character.Components](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.Character.Components.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public abstract class MyCharacterDetectorComponent : MyUpdatingEntityComponent, IMyEntityComponentBase, IMyComponentBase, IMyEventProxy, IMyEventOwner, IMyUpdatingEntityComponent, IMyCharacterComponent
```

### Constructors

#### MyCharacterDetectorComponent()

##### Declaration

```
protected MyCharacterDetectorComponent()
```

### Fields

#### m\_charHitInfo

##### Declaration

```
protected MyCharacterHitInfo m_charHitInfo
```

##### Field Value

| Type | Description |
| --- | --- |
| Sandbox.Game.Entities.Character.MyCharacterHitInfo |     |

#### m\_interactiveObject

##### Declaration

```
protected IMyUseObject m_interactiveObject
```

##### Field Value

| Type | Description |
| --- | --- |
| [IMyUseObject](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.UseObject.IMyUseObject.html) |     |

#### m\_npcGridNotification

##### Declaration

```
protected MyHudNotification m_npcGridNotification
```

##### Field Value

| Type | Description |
| --- | --- |
| Sandbox.Game.Gui.MyHudNotification |     |

### Properties

#### Character

##### Declaration

```
public MyCharacter Character { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| Sandbox.Game.Entities.Character.MyCharacter |     |

#### DetectedEntity

##### Declaration

```
public IMyEntity DetectedEntity { get; protected set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) |     |

#### HitBody

##### Declaration

```
public HkRigidBody HitBody { get; protected set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| Havok.HkRigidBody |     |

#### HitMaterial

##### Declaration

```
public MyStringHash HitMaterial { get; protected set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) |     |

#### HitNormal

##### Declaration

```
public Vector3 HitNormal { get; protected set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### HitPosition

##### Declaration

```
public Vector3D HitPosition { get; protected set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

#### HitTag

##### Declaration

```
public object HitTag { get; protected set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Object |     |

#### ShapeKey

##### Declaration

```
public uint ShapeKey { get; protected set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.UInt32 |     |

#### StartPosition

##### Declaration

```
public Vector3D StartPosition { get; protected set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

#### UseObject

##### Declaration

```
public virtual IMyUseObject UseObject { get; protected set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [IMyUseObject](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.UseObject.IMyUseObject.html) |     |

### Methods

#### DisableDetectors()

##### Declaration

```
protected static void DisableDetectors()
```

#### DoDetection(Boolean)

##### Declaration

```
protected abstract void DoDetection(bool useHead)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | useHead |     |

#### EnableDetectorsInArea(Vector3D)

##### Declaration

```
protected static void EnableDetectorsInArea(Vector3D from)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | from |     |

#### HandleInteractiveObject(IMyUseObject)

##### Declaration

```
protected static void HandleInteractiveObject(IMyUseObject interactive)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyUseObject](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.UseObject.IMyUseObject.html) | interactive |     |

#### InteractiveObjectChanged()

##### Declaration

```
protected void InteractiveObjectChanged()
```

#### InteractiveObjectContinue()

##### Declaration

```
protected void InteractiveObjectContinue()
```

#### InteractiveObjectRemoved()

##### Declaration

```
protected void InteractiveObjectRemoved()
```

#### OnAddedToContainer()

##### Declaration

```
public override void OnAddedToContainer()
```

##### Overrides

#### OnBeforeRemovedFromContainer()

##### Declaration

```
public override void OnBeforeRemovedFromContainer()
```

##### Overrides

#### OnCharacterDead()

##### Declaration

```
public virtual void OnCharacterDead()
```

#### OnDetectedEntityMarkForClose(IMyEntity)

##### Declaration

```
protected virtual void OnDetectedEntityMarkForClose(IMyEntity obj)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | obj |     |
