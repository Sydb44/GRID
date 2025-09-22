---
title: "Class EntityFlags"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.EntityFlags.html"
category: "Misc"
namespace: "VRage.ModAPI"
class: "EntityFlags"
---

# Class EntityFlags | Space Engineers ModAPI

Entity flags.

##### Inheritance

System.Object

EntityFlags

###### **Namespace**: [VRage.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public sealed class EntityFlags : Enum
```

### Fields

#### Default

##### Declaration

```
public const EntityFlags Default
```

##### Field Value

| Type | Description |
| --- | --- |
| [EntityFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.EntityFlags.html) |     |

#### DrawOutsideViewDistance

Flags would be delivered to render component. VRageRender.RenderFlags.DrawOutsideViewDistance

##### Declaration

```
public const EntityFlags DrawOutsideViewDistance
```

##### Field Value

| Type | Description |
| --- | --- |
| [EntityFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.EntityFlags.html) |     |

#### FastCastShadowResolve

Flags would be delivered to render component. VRageRender.RenderFlags.FastCastShadowResolve

##### Declaration

```
public const EntityFlags FastCastShadowResolve
```

##### Field Value

| Type | Description |
| --- | --- |
| [EntityFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.EntityFlags.html) |     |

#### InvalidateOnMove

If object is moved, invalidate its renderobjects (update render)

##### Declaration

```
public const EntityFlags InvalidateOnMove
```

##### Field Value

| Type | Description |
| --- | --- |
| [EntityFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.EntityFlags.html) |     |

#### IsGamePrunningStructureObject

Can be added, removed, or updated in **Sandbox.Game.Entities.MyGamePruningStructure**

##### Declaration

```
public const EntityFlags IsGamePrunningStructureObject
```

##### Field Value

| Type | Description |
| --- | --- |
| [EntityFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.EntityFlags.html) |     |

#### IsNotGamePrunningStructureObject

Do not use in prunning, even though it is a root entity

##### Declaration

```
public const EntityFlags IsNotGamePrunningStructureObject
```

##### Field Value

| Type | Description |
| --- | --- |
| [EntityFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.EntityFlags.html) |     |

#### Near

Specifies whether entity is "near", near entities are cockpit and weapons, these entities are rendered in special way

##### Declaration

```
public const EntityFlags Near
```

##### Field Value

| Type | Description |
| --- | --- |
| [EntityFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.EntityFlags.html) |     |

#### NeedsDraw

Draw method of this entity will be called when suitable. [NeedsDraw](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyRenderComponentBase.html#VRage_Game_Components_MyRenderComponentBase_NeedsDraw)

##### Declaration

```
public const EntityFlags NeedsDraw
```

##### Field Value

| Type | Description |
| --- | --- |
| [EntityFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.EntityFlags.html) |     |

#### NeedsDrawFromParent

Draw method of this entity will be called when suitable and only from parent

##### Declaration

```
public const EntityFlags NeedsDrawFromParent
```

##### Field Value

| Type | Description |
| --- | --- |
| [EntityFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.EntityFlags.html) |     |

#### NeedsResolveCastShadow

Flags would be delivered to render component. VRageRender.RenderFlags.NeedsResolveCastShadow

##### Declaration

```
public const EntityFlags NeedsResolveCastShadow
```

##### Field Value

| Type | Description |
| --- | --- |
| [EntityFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.EntityFlags.html) |     |

#### NeedsSimulate

Entity has special simulation update. [SIMULATE](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.MyEntityUpdateEnum.html#VRage_ModAPI_MyEntityUpdateEnum_SIMULATE)

##### Declaration

```
public const EntityFlags NeedsSimulate
```

##### Field Value

| Type | Description |
| --- | --- |
| [EntityFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.EntityFlags.html) |     |

#### NeedsUpdate

On this entity and its children will be called UpdateBeforeSimulation and UpdateAfterSimulation each frame

##### Declaration

```
public const EntityFlags NeedsUpdate
```

##### Field Value

| Type | Description |
| --- | --- |
| [EntityFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.EntityFlags.html) |     |

#### NeedsUpdate10

Entity updated each 10th frame

##### Declaration

```
public const EntityFlags NeedsUpdate10
```

##### Field Value

| Type | Description |
| --- | --- |
| [EntityFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.EntityFlags.html) |     |

#### NeedsUpdate100

Entity updated each 100th frame

##### Declaration

```
public const EntityFlags NeedsUpdate100
```

##### Field Value

| Type | Description |
| --- | --- |
| [EntityFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.EntityFlags.html) |     |

#### NeedsUpdateAfter

On this entity and its children will be called UpdateAfterSimulation each frame

##### Declaration

```
public const EntityFlags NeedsUpdateAfter
```

##### Field Value

| Type | Description |
| --- | --- |
| [EntityFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.EntityFlags.html) |     |

#### NeedsUpdateBeforeNextFrame

Entity updated once before first frame.

##### Declaration

```
public const EntityFlags NeedsUpdateBeforeNextFrame
```
