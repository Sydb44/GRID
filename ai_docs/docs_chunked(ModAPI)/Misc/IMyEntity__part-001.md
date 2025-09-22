---
title: "Interface IMyEntity"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html"
category: "Misc"
namespace: "VRage.ModAPI"
class: "IMyEntity"
---

# Interface IMyEntity | Space Engineers ModAPI

##### Inherited Members

###### **Namespace**: [VRage.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public interface IMyEntity : IMyEntity
```

### Properties

#### CastShadows

##### Declaration

```
bool CastShadows { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### DebugAsyncLoading

Used for internal usage. Modders should not use it. Will be eventually removed

##### Declaration

```
bool DebugAsyncLoading { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### DisplayName

Gets or sets user friendly name of entity

##### Declaration

```
string DisplayName { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### EntityId

Uniq id of entity.

##### Declaration

```
long EntityId { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

##### See Also

#### FastCastShadowResolve

##### Declaration

```
bool FastCastShadowResolve { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Flags

Gets or set some behavior of entity. [EntityFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.EntityFlags.html)

##### Declaration

```
EntityFlags Flags { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [EntityFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.EntityFlags.html) |     |

#### GameLogic

Gets or sets game logic for object. If there is more than 1 game logic attached it should be wrapped into **MyCompositeGameLogicComponent**.

##### Declaration

```
MyEntityComponentBase GameLogic { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyEntityComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyEntityComponentBase.html) |     |

##### See Also

#### Hierarchy

Gets or sets Hierarchy component

##### Declaration

```
MyHierarchyComponentBase Hierarchy { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyHierarchyComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyHierarchyComponentBase.html) |     |

#### InScene

Gets or set if grid is InScene. Objects that are not in scene are not updated and drawn.

##### Declaration

```
bool InScene { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### InvalidateOnMove

Gets if entity is invalidated on move When visual look of entity depends on position - then InvalidateOnMove should be true

##### Declaration

```
bool InvalidateOnMove { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsCCDForProjectiles

##### Declaration

```
bool IsCCDForProjectiles { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsVolumetric

Always returns false

##### Declaration

```
bool IsVolumetric { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### LocalAABB

##### Declaration

```
BoundingBox LocalAABB { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) |     |

#### LocalAABBHr

##### Declaration

```
BoundingBox LocalAABBHr { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) |     |

#### LocalMatrix

Gets or sets local matrix. When entity, has parent, it's world coordinates are calculated from localMatrix and parent world matrix

##### Declaration

```
Matrix LocalMatrix { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html) |     |

#### LocalVolume

Gets or sets local volume. Same as [LocalVolume](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyPositionComponentBase.html#VRage_Game_Components_MyPositionComponentBase_LocalVolume)

##### Declaration

```
BoundingSphere LocalVolume { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [BoundingSphere](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphere.html) |     |

#### LocalVolumeOffset

##### Declaration

```
Vector3 LocalVolumeOffset { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### LocationForHudMarker

##### Declaration

```
Vector3D LocationForHudMarker { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

#### MarkedForClose

Checked if [Close()](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html#VRage_ModAPI_IMyEntity_Close) was called

##### Declaration

```
bool MarkedForClose { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### MaxGlassDistSq

Not used in game anymore

##### Declaration

```
float MaxGlassDistSq { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Model

Gets model of block

##### Declaration
