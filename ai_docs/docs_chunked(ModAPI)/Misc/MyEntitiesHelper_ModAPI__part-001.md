---
title: "Class MyEntitiesHelper\\_ModAPI"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.MyEntitiesHelper_ModAPI.html"
category: "Misc"
namespace: "Sandbox.ModAPI"
class: "MyEntitiesHelper_ModAPI"
---

# Class MyEntitiesHelper\_ModAPI | Space Engineers ModAPI

##### Inheritance

System.Object

MyEntitiesHelper\_ModAPI

##### Implements

###### **Namespace**: [Sandbox.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public class MyEntitiesHelper_ModAPI : Object, IMyEntities
```

### Constructors

#### MyEntitiesHelper\_ModAPI()

##### Declaration

```
public MyEntitiesHelper_ModAPI()
```

### Explicit Interface Implementations

#### IMyEntities.AddEntity(IMyEntity, Boolean)

##### Declaration

```
void IMyEntities.AddEntity(IMyEntity entity, bool insertIntoScene)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | entity |     |
| System.Boolean | insertIntoScene |     |

#### IMyEntities.CreateFromObjectBuilder(MyObjectBuilder\_EntityBase)

##### Declaration

```
IMyEntity IMyEntities.CreateFromObjectBuilder(MyObjectBuilder_EntityBase objectBuilder)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_EntityBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_EntityBase.html) | objectBuilder |     |

##### Returns

| Type | Description |
| --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) |     |

#### IMyEntities.CreateFromObjectBuilderAndAdd(MyObjectBuilder\_EntityBase)

##### Declaration

```
IMyEntity IMyEntities.CreateFromObjectBuilderAndAdd(MyObjectBuilder_EntityBase objectBuilder)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_EntityBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_EntityBase.html) | objectBuilder |     |

##### Returns

| Type | Description |
| --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) |     |

#### IMyEntities.CreateFromObjectBuilderNoinit(MyObjectBuilder\_EntityBase)

##### Declaration

```
IMyEntity IMyEntities.CreateFromObjectBuilderNoinit(MyObjectBuilder_EntityBase objectBuilder)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_EntityBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_EntityBase.html) | objectBuilder |     |

##### Returns

| Type | Description |
| --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) |     |

#### IMyEntities.CreateFromObjectBuilderParallel(MyObjectBuilder\_EntityBase, Boolean, Action<IMyEntity>)

##### Declaration

```
IMyEntity IMyEntities.CreateFromObjectBuilderParallel(MyObjectBuilder_EntityBase objectBuilder, bool addToScene, Action<IMyEntity> completionCallback)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_EntityBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_EntityBase.html) | objectBuilder |     |
| System.Boolean | addToScene |     |
| System.Action<[IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html)\> | completionCallback |     |

##### Returns

| Type | Description |
| --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) |     |

#### IMyEntities.EnableEntityBoundingBoxDraw(IMyEntity, Boolean, Nullable<Vector4>, Single, Nullable<Vector3>)

##### Declaration

```
void IMyEntities.EnableEntityBoundingBoxDraw(IMyEntity entity, bool enable, Nullable<Vector4> color, float lineWidth, Nullable<Vector3> inflateAmount)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | entity |     |
| System.Boolean | enable |     |
| System.Nullable<[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)\> | color |     |
| System.Single | lineWidth |     |
| System.Nullable<[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)\> | inflateAmount |     |

#### IMyEntities.EntityExists(Int64)

##### Declaration

```
bool IMyEntities.EntityExists(long entityId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | entityId |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IMyEntities.EntityExists(Nullable<Int64>)

##### Declaration

```
bool IMyEntities.EntityExists(Nullable<long> entityId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Nullable<System.Int64\> | entityId |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IMyEntities.EntityExists(String)

##### Declaration

```
bool IMyEntities.EntityExists(string name)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | name |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IMyEntities.Exist(IMyEntity)

##### Declaration

```
bool IMyEntities.Exist(IMyEntity entity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | entity |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IMyEntities.FindFreePlace(Vector3D, Single, Int32, Int32, Single)
