---
title: "Class MyUseObjectBase"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.UseObject.MyUseObjectBase.html"
category: "Misc"
namespace: "VRage.Game.Entity.UseObject"
class: "MyUseObjectBase"
---

# Class MyUseObjectBase | Space Engineers ModAPI

##### Inheritance

System.Object

MyUseObjectBase

##### Implements

###### **Namespace**: [VRage.Game.Entity.UseObject](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.UseObject.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public abstract class MyUseObjectBase : Object, IMyUseObject
```

### Constructors

#### MyUseObjectBase(IMyEntity, IMyModelDummy)

##### Declaration

```
protected MyUseObjectBase(IMyEntity owner, IMyModelDummy dummy)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | owner |     |
| [IMyModelDummy](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyModelDummy.html) | dummy |     |

### Properties

#### ActivationMatrix

##### Declaration

```
public virtual MatrixD ActivationMatrix { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) |     |

#### ContinuousUsage

##### Declaration

```
public virtual bool ContinuousUsage { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Dummy

##### Declaration

```
public IMyModelDummy Dummy { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [IMyModelDummy](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyModelDummy.html) |     |

#### InstanceID

##### Declaration

```
public virtual int InstanceID { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### InteractiveDistance

##### Declaration

```
public virtual float InteractiveDistance { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Owner

##### Declaration

```
public IMyEntity Owner { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) |     |

#### PlayIndicatorSound

##### Declaration

```
public virtual bool PlayIndicatorSound { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### PrimaryAction

##### Declaration

```
public abstract UseActionEnum PrimaryAction { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [UseActionEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.UseObject.UseActionEnum.html) |     |

#### RenderObjectID

##### Declaration

```
public virtual uint RenderObjectID { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.UInt32 |     |

#### SecondaryAction

##### Declaration

```
public abstract UseActionEnum SecondaryAction { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [UseActionEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.UseObject.UseActionEnum.html) |     |

#### ShouldUpdateTooltips

##### Declaration

```
public virtual bool ShouldUpdateTooltips { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ShowOverlay

##### Declaration

```
public virtual bool ShowOverlay { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### SupportedActions

##### Declaration

```
public virtual UseActionEnum SupportedActions { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [UseActionEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.UseObject.UseActionEnum.html) |     |

#### WorldMatrix

##### Declaration

```
public virtual MatrixD WorldMatrix { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) |     |

### Methods

#### GetActionInfo(UseActionEnum)

##### Declaration

```
public abstract MyActionDescription GetActionInfo(UseActionEnum actionEnum)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [UseActionEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.UseObject.UseActionEnum.html) | actionEnum |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyActionDescription](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.UseObject.MyActionDescription.html) |     |

#### HandleInput()

##### Declaration

```
public virtual bool HandleInput()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### OnSelectionLost()

##### Declaration

```
public virtual void OnSelectionLost()
```

#### SetInstanceID(Int32)

##### Declaration

```
public virtual void SetInstanceID(int id)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | id  |     |

#### SetRenderID(UInt32)

##### Declaration

```
public virtual void SetRenderID(uint id)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.UInt32 | id  |     |

#### Use(UseActionEnum, IMyEntity)

##### Declaration

```
public abstract void Use(UseActionEnum actionEnum, IMyEntity user)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [UseActionEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.UseObject.UseActionEnum.html) | actionEnum |     |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | user |     |

### Implements