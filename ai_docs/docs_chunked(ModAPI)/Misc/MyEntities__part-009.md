```

##### Parameters

Type

Name

Description

[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)

entity

#### RaiseEntityRemove(MyEntity)

##### Declaration

```
public static void RaiseEntityRemove(MyEntity entity)
```

##### Parameters

Type

Name

Description

[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)

entity

#### RegisterForDraw(IMyEntity)

##### Declaration

```
public static void RegisterForDraw(IMyEntity entity)
```

##### Parameters

Type

Name

Description

[IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html)

entity

#### RegisterForUpdate(MyEntity)

##### Declaration

```
public static void RegisterForUpdate(MyEntity entity)
```

##### Parameters

Type

Name

Description

[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)

entity

#### ReleaseWaitingAsync(Byte, Dictionary<Int64, MatrixD>)

##### Declaration

```
public static void ReleaseWaitingAsync(byte index, Dictionary<long, MatrixD> matrices)
```

##### Parameters

Type

Name

Description

System.Byte

index

System.Collections.Generic.Dictionary<System.Int64, [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)\>

matrices

#### RemapObjectBuilder(MyObjectBuilder\_EntityBase)

##### Declaration

```
public static IMyRemapHelper RemapObjectBuilder(MyObjectBuilder_EntityBase objectBuilder)
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

[IMyRemapHelper](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyRemapHelper.html)

#### RemapObjectBuilderCollection(IEnumerable<MyObjectBuilder\_EntityBase>)

##### Declaration

```
public static void RemapObjectBuilderCollection(IEnumerable<MyObjectBuilder_EntityBase> objectBuilders)
```

##### Parameters

Type

Name

Description

System.Collections.Generic.IEnumerable<[MyObjectBuilder\_EntityBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_EntityBase.html)\>

objectBuilders

#### Remove(MyEntity)

Removes the specified entity from scene

##### Declaration

```
public static bool Remove(MyEntity entity)
```

##### Parameters

Type

Name

Description

[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)

entity

The entity.

##### Returns

Type

Description

System.Boolean

#### RemoveFromClosedEntities(MyEntity)

##### Declaration

```
public static void RemoveFromClosedEntities(MyEntity entity)
```

##### Parameters

Type

Name

Description

[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)

entity

#### RemoveName(MyEntity)

Remove name of entity from used names

##### Declaration

```
public static void RemoveName(MyEntity entity)
```

##### Parameters

Type

Name

Description

[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)

entity

#### RemoveRenderObjectFromMap(UInt32)

##### Declaration

```
public static void RemoveRenderObjectFromMap(uint id)
```

##### Parameters

Type

Name

Description

System.UInt32

id

#### SendCloseRequest(IMyEntity)

##### Declaration

```
public static void SendCloseRequest(IMyEntity entity)
```

##### Parameters

Type

Name

Description

[IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html)

entity

#### SetEntityName(MyEntity, Boolean)

##### Declaration

```
public static void SetEntityName(MyEntity myEntity, bool possibleRename = true)
```

##### Parameters

Type

Name

Description

[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)

myEntity

System.Boolean

possibleRename

#### SetTypeHidden(Type, Boolean)

##### Declaration

```
public static void SetTypeHidden(Type type, bool hidden)
```

##### Parameters

Type

Name

Description

System.Type

type

System.Boolean

hidden

#### Simulate()

##### Declaration

```
public static void Simulate()
```

#### StartAsyncUpdateBlock()

Start a asynchronous update block.

##### Declaration

```
public static MyEntities.AsyncUpdateToken StartAsyncUpdateBlock()
```

##### Returns

Type

Description

[MyEntities.AsyncUpdateToken](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntities.AsyncUpdateToken.html)

#### TestPlaceInSpace(Vector3D, Single, Func<IMyEntity, Boolean>, Boolean)

##### Declaration

```
public static Nullable<Vector3D> TestPlaceInSpace(Vector3D basePos, float radius, Func<IMyEntity, bool> ignoredEntity, bool detailedVoxelsCheck = false)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

basePos

System.Single

radius

System.Func<[IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html), System.Boolean\>

ignoredEntity

System.Boolean

detailedVoxelsCheck

##### Returns

Type

Description

System.Nullable<[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\>

#### TestPlaceInSpace(Vector3D, Single, MyEntity, Boolean)

##### Declaration

```
public static Nullable<Vector3D> TestPlaceInSpace(Vector3D basePos, float radius, MyEntity ignoredEntity = null, bool detailedVoxelsCheck = false)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

basePos

System.Single

radius

[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)

ignoredEntity

System.Boolean

detailedVoxelsCheck
