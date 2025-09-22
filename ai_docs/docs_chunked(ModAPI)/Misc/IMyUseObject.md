---
title: "Interface IMyUseObject"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.UseObject.IMyUseObject.html"
category: "Misc"
namespace: "VRage.Game.Entity.UseObject"
class: "IMyUseObject"
---

# Interface IMyUseObject | Space Engineers ModAPI

###### **Namespace**: [VRage.Game.Entity.UseObject](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.UseObject.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public interface IMyUseObject
```

### Properties

#### ActivationMatrix

Matrix of object, scale represents size of object

##### Declaration

```
MatrixD ActivationMatrix { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) |     |

#### ContinuousUsage

When true, use will be called every frame

##### Declaration

```
bool ContinuousUsage { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Dummy

##### Declaration

```
IMyModelDummy Dummy { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [IMyModelDummy](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyModelDummy.html) |     |

#### InstanceID

Instance ID of objects (this should mostly be unused

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### InteractiveDistance

Consider object as being in interactive range only if distance from character is smaller or equal to this value

##### Declaration

```
float InteractiveDistance { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Owner

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) |     |

#### PlayIndicatorSound

##### Declaration

```
bool PlayIndicatorSound { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### PrimaryAction

Main action of this use object

##### Declaration

```
UseActionEnum PrimaryAction { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [UseActionEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.UseObject.UseActionEnum.html) |     |

#### RenderObjectID

Render ID of objects

##### Declaration

```
uint RenderObjectID { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.UInt32 |     |

#### SecondaryAction

Secondary action of this use object

##### Declaration

```
UseActionEnum SecondaryAction { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [UseActionEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.UseObject.UseActionEnum.html) |     |

#### ShouldUpdateTooltips

##### Declaration

```
bool ShouldUpdateTooltips { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ShowOverlay

Show overlay (semitransparent bounding box)

##### Declaration

```
bool ShowOverlay { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### SupportedActions

Returns supported actions

##### Declaration

```
UseActionEnum SupportedActions { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [UseActionEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.UseObject.UseActionEnum.html) |     |

#### WorldMatrix

Matrix of object, scale represents size of object

##### Declaration

```
MatrixD WorldMatrix { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) |     |

### Methods

#### GetActionInfo(UseActionEnum)

Gets action text Caller calls this method only on supported actions

##### Declaration

```
MyActionDescription GetActionInfo(UseActionEnum actionEnum)
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

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### OnSelectionLost()

##### Declaration

#### SetInstanceID(Int32)

##### Declaration

```
void SetInstanceID(int id)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | id  |     |

#### SetRenderID(UInt32)

##### Declaration

```
void SetRenderID(uint id)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.UInt32 | id  |     |

#### Use(UseActionEnum, IMyEntity)

Uses object by specified action Caller calls this method only on supported actions

##### Declaration

```
void Use(UseActionEnum actionEnum, IMyEntity user)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [UseActionEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.UseObject.UseActionEnum.html) | actionEnum |     |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | user |     |

### Extension Methods