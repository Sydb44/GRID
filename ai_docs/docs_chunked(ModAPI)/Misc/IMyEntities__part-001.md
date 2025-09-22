---
title: "Interface IMyEntities"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntities.html"
category: "Misc"
namespace: "VRage.ModAPI"
class: "IMyEntities"
---

# Interface IMyEntities | Space Engineers ModAPI

Provides API, that granting access to enitities (mods interface)

###### **Namespace**: [VRage.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public interface IMyEntities
```

### Methods

#### AddEntity(IMyEntity, Boolean)

Registers entity

##### Declaration

```
void AddEntity(IMyEntity entity, bool insertIntoScene = true)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | entity | Entity that should be registered |
| System.Boolean | insertIntoScene | When true [OnAddedToScene(Object)](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html#VRage_ModAPI_IMyEntity_OnAddedToScene_System_Object_) is called |

#### CreateFromObjectBuilder(MyObjectBuilder\_EntityBase)

Create entity from object builder

##### Declaration

```
IMyEntity CreateFromObjectBuilder(MyObjectBuilder_EntityBase objectBuilder)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_EntityBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_EntityBase.html) | objectBuilder | Object builder of entity |

##### Returns

| Type | Description |
| --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | Created entity |

#### CreateFromObjectBuilderAndAdd(MyObjectBuilder\_EntityBase)

##### Declaration

```
IMyEntity CreateFromObjectBuilderAndAdd(MyObjectBuilder_EntityBase objectBuilder)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_EntityBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_EntityBase.html) | objectBuilder | Object builder of entity |

##### Returns

| Type | Description |
| --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | Created entity |

#### CreateFromObjectBuilderNoinit(MyObjectBuilder\_EntityBase)

Create new entity from objectBuilder, but doesn't call **Init(MyObjectBuilder\_EntityBase objectBuilder)**

##### Declaration

```
IMyEntity CreateFromObjectBuilderNoinit(MyObjectBuilder_EntityBase objectBuilder)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_EntityBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_EntityBase.html) | objectBuilder |     |

##### Returns

| Type | Description |
| --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) |     |

#### CreateFromObjectBuilderParallel(MyObjectBuilder\_EntityBase, Boolean, Action<IMyEntity>)

Creates and asynchronously initializes and entity.

##### Declaration

```
IMyEntity CreateFromObjectBuilderParallel(MyObjectBuilder_EntityBase objectBuilder, bool addToScene = false, Action<IMyEntity> completionCallback = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_EntityBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_EntityBase.html) | objectBuilder | Object builder of grid |
| System.Boolean | addToScene | Call [AddEntity(IMyEntity, Boolean)](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntities.html#VRage_ModAPI_IMyEntities_AddEntity_VRage_ModAPI_IMyEntity_System_Boolean_) and call OnAddedToScene |
| System.Action<[IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html)\> | completionCallback | Callback called in main thread. |

##### Returns

| Type | Description |
| --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | Create **but not inited yet** entity. Entity would be inited correctly after callback trigger |

#### EnableEntityBoundingBoxDraw(IMyEntity, Boolean, Nullable<Vector4>, Single, Nullable<Vector3>)

Draw bounding box around entity

##### Declaration

```
void EnableEntityBoundingBoxDraw(IMyEntity entity, bool enable, Nullable<Vector4> color = null, float lineWidth = 0.01F, Nullable<Vector3> inflateAmount = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | entity | That should have visible bounding box |
| System.Boolean | enable | When true, bounding box start draw around entity |
| System.Nullable<[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)\> | color | Color of lines |
| System.Single | lineWidth | With of lines |
| System.Nullable<[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)\> | inflateAmount | Distance from original bounding box, from each side in meters |

#### EntityExists(Int64)

Returns if entity with provided name exists

##### Declaration

```
bool EntityExists(long entityId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | entityId | [EntityId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html#VRage_ModAPI_IMyEntity_EntityId) |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if entity exists |

#### EntityExists(Nullable<Int64>)

Returns if entity with provided name exists

##### Declaration

```
bool EntityExists(Nullable<long> entityId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Nullable<System.Int64\> | entityId | [EntityId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html#VRage_ModAPI_IMyEntity_EntityId) |
