[MyObjectBuilder\_EntityBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_EntityBase.html)

objectBuilder

System.Boolean

addToScene

System.Action<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\>

doneHandler

#### CreateEntity(MyDefinitionId, Boolean, Boolean, Nullable<Vector3>, Nullable<Vector3>, Nullable<Vector3>)

##### Declaration

```
public static MyEntity CreateEntity(MyDefinitionId entityContainerId, bool fadeIn, bool setPosAndRot = false, Nullable<Vector3> position = null, Nullable<Vector3> up = null, Nullable<Vector3> forward = null)
```

##### Parameters

Type

Name

Description

[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)

entityContainerId

System.Boolean

fadeIn

System.Boolean

setPosAndRot

System.Nullable<[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)\>

position

System.Nullable<[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)\>

up

System.Nullable<[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)\>

forward

##### Returns

Type

Description

[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)

#### CreateEntityAndAdd(MyDefinitionId, Boolean, Boolean, Nullable<Vector3>, Nullable<Vector3>, Nullable<Vector3>)

This method will try to retrieve a definition of components container of the entity and create the type of the entity.

##### Declaration

```
public static MyEntity CreateEntityAndAdd(MyDefinitionId entityContainerId, bool fadeIn, bool setPosAndRot = false, Nullable<Vector3> position = null, Nullable<Vector3> up = null, Nullable<Vector3> forward = null)
```

##### Parameters

Type

Name

Description

[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)

entityContainerId

This is the id of container definition

System.Boolean

fadeIn

System.Boolean

setPosAndRot

Set true if want to set entity position, orientation

System.Nullable<[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)\>

position

System.Nullable<[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)\>

up

System.Nullable<[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)\>

forward

##### Returns

Type

Description

[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)

#### CreateFromComponentContainerDefinitionAndAdd(MyDefinitionId, Boolean, Boolean)

##### Declaration

```
public static MyEntity CreateFromComponentContainerDefinitionAndAdd(MyDefinitionId entityContainerDefinitionId, bool fadeIn, bool insertIntoScene = true)
```

##### Parameters

Type

Name

Description

[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)

entityContainerDefinitionId

System.Boolean

fadeIn

System.Boolean

insertIntoScene

##### Returns

Type

Description

[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)

#### CreateFromObjectBuilder(MyObjectBuilder\_EntityBase, Boolean)

##### Declaration

```
public static MyEntity CreateFromObjectBuilder(MyObjectBuilder_EntityBase objectBuilder, bool fadeIn)
```

##### Parameters

Type

Name

Description

[MyObjectBuilder\_EntityBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_EntityBase.html)

objectBuilder

System.Boolean

fadeIn

##### Returns

Type

Description

[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)

#### CreateFromObjectBuilderAndAdd(MyObjectBuilder\_EntityBase, Boolean)

##### Declaration

```
public static MyEntity CreateFromObjectBuilderAndAdd(MyObjectBuilder_EntityBase objectBuilder, bool fadeIn)
```

##### Parameters

Type

Name

Description

[MyObjectBuilder\_EntityBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_EntityBase.html)

objectBuilder

System.Boolean

fadeIn

##### Returns

Type

Description

[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)

#### CreateFromObjectBuilderNoinit(MyObjectBuilder\_EntityBase)

##### Declaration

```
public static MyEntity CreateFromObjectBuilderNoinit(MyObjectBuilder_EntityBase objectBuilder)
```

##### Parameters

Type

Name

Description

[MyObjectBuilder\_EntityBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_EntityBase.html)

objectBuilder

##### Returns

Type

Description

[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)

#### CreateFromObjectBuilderParallel(MyObjectBuilder\_EntityBase, Boolean, Action<MyEntity>, MyEntity, MyEntity, Nullable<Vector3D>, Boolean, Boolean)

Create and asynchronously initialize and entity.

##### Declaration

```
public static MyEntity CreateFromObjectBuilderParallel(MyObjectBuilder_EntityBase objectBuilder, bool addToScene = false, Action<MyEntity> completionCallback = null, MyEntity entity = null, MyEntity relativeSpawner = null, Nullable<Vector3D> relativeOffset = null, bool checkPosition = false, bool fadeIn = false)
```

##### Parameters

Type

Name

Description

[MyObjectBuilder\_EntityBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_EntityBase.html)

objectBuilder

System.Boolean

addToScene

System.Action<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\>

completionCallback

Callback when the entity is initialized

[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)

entity

Already created entity you only want to init

[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)

relativeSpawner

System.Nullable<[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\>

relativeOffset

System.Boolean

checkPosition

System.Boolean

fadeIn
