---
title: "Class MyEntity"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html"
category: "Misc"
namespace: "VRage.Game.Entity"
class: "MyEntity"
---

# Class MyEntity | Space Engineers ModAPI

Implements entity features for ModAPI interface

##### Inheritance

System.Object

MyEntity

##### Implements

###### **Namespace**: [VRage.Game.Entity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
[MyEntityType]
public class MyEntity : Object, IMyEntity, IMyEntity
```

### Constructors

#### MyEntity()

##### Declaration

#### MyEntity(Boolean)

##### Declaration

```
public MyEntity(bool testingPurpouses)
```

##### Parameters

Type

Name

Description

System.Boolean

testingPurpouses

### Fields

#### AddToGamePruningStructureExtCallBack

##### Declaration

```
public static Action<MyEntity> AddToGamePruningStructureExtCallBack
```

##### Field Value

Type

Description

System.Action<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\>

#### CreateDefaultSyncEntityExtCallback

##### Declaration

```
public static MyEntity.CreateDefaultSyncEntityDelegate CreateDefaultSyncEntityExtCallback
```

##### Field Value

Type

Description

[MyEntity.CreateDefaultSyncEntityDelegate](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.CreateDefaultSyncEntityDelegate.html)

#### CreateStandardRenderComponentsExtCallback

##### Declaration

```
public static Action<MyEntity> CreateStandardRenderComponentsExtCallback
```

##### Field Value

Type

Description

System.Action<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\>

#### DebugAsyncLoading

##### Declaration

```
public bool DebugAsyncLoading
```

##### Field Value

Type

Description

System.Boolean

#### DefinitionId

##### Declaration

```
public Nullable<MyDefinitionId> DefinitionId
```

##### Field Value

Type

Description

System.Nullable<[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)\>

#### GamePruningProxyId

##### Declaration

```
public int GamePruningProxyId
```

##### Field Value

Type

Description

System.Int32

#### InitComponentsExtCallback

##### Declaration

```
public static Action<IMyComponentContainer, MyObjectBuilderType, MyStringHash, MyObjectBuilder_ComponentContainer> InitComponentsExtCallback
```

##### Field Value

Type

Description

System.Action<VRage.Game.Components.Interfaces.IMyComponentContainer, [MyObjectBuilderType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilderType.html), [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html), [MyObjectBuilder\_ComponentContainer](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.ComponentSystem.MyObjectBuilder_ComponentContainer.html)\>

#### InstantiateSubpartOverrideFunc

##### Declaration

```
public Func<MyModelDummy, MyEntitySubpart.Data, MyEntitySubpart> InstantiateSubpartOverrideFunc
```

##### Field Value

Type

Description

System.Func<VRageRender.Import.MyModelDummy, [MyEntitySubpart.Data](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntitySubpart.Data.html), [MyEntitySubpart](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntitySubpart.html)\>

#### IsPreviewChanged

##### Declaration

```
public Action<bool> IsPreviewChanged
```

##### Field Value

Type

Description

System.Action<System.Boolean\>

#### m\_contactPoint

##### Declaration

```
protected readonly Sync<MyEntity.ContactPointData, SyncDirection.FromServer> m_contactPoint
```

##### Field Value

Type

Description

VRage.Sync.Sync<[MyEntity.ContactPointData](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.ContactPointData.html), VRage.Sync.SyncDirection.FromServer\>

#### m\_hudParams

##### Declaration

```
protected List<MyHudEntityParams> m_hudParams
```

##### Field Value

Type

Description

System.Collections.Generic.List<VRage.Game.Gui.MyHudEntityParams\>

#### m\_modelCollision

##### Declaration

```
protected MyModel m_modelCollision
```

##### Field Value

Type

Description

VRage.Game.Models.MyModel

#### m\_positionResetFromServer

##### Declaration

```
public bool m_positionResetFromServer
```

##### Field Value

Type

Description

System.Boolean

#### MyEntitiesCreateFromObjectBuilderExtCallback

##### Declaration

```
public static Func<MyObjectBuilder_EntityBase, bool, MyEntity> MyEntitiesCreateFromObjectBuilderExtCallback
```

##### Field Value

Type

Description

System.Func<[MyObjectBuilder\_EntityBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_EntityBase.html), System.Boolean, [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\>

#### MyEntityFactoryCreateObjectBuilderExtCallback

##### Declaration

```
public static MyEntity.MyEntityFactoryCreateObjectBuilderDelegate MyEntityFactoryCreateObjectBuilderExtCallback
```

##### Field Value

Type

Description

[MyEntity.MyEntityFactoryCreateObjectBuilderDelegate](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.MyEntityFactoryCreateObjectBuilderDelegate.html)

#### MyProceduralWorldGeneratorTrackEntityExtCallback

##### Declaration

```
public static Action<MyEntity> MyProceduralWorldGeneratorTrackEntityExtCallback
```

##### Field Value

Type

Description

System.Action<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\>

#### MyWeldingGroupsAddNodeExtCallback

##### Declaration

```
public static Action<MyEntity> MyWeldingGroupsAddNodeExtCallback
```

##### Field Value

Type

Description

System.Action<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\>
