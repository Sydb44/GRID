basePos

System.Single

radius

[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)

ignoredEntity

System.Boolean

detailedVoxelsCheck

##### Returns

Type

Description

System.Nullable<[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\>

#### TryGetEntityById(Int64, out MyEntity, Boolean)

##### Declaration

```
public static bool TryGetEntityById(long entityId, out MyEntity entity, bool allowClosed = false)
```

##### Parameters

Type

Name

Description

System.Int64

entityId

[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)

entity

System.Boolean

allowClosed

##### Returns

Type

Description

System.Boolean

#### TryGetEntityById<T>(Int64, out T, Boolean)

##### Declaration

```
public static bool TryGetEntityById<T>(long entityId, out T entity, bool allowClosed = false)
    where T : MyEntity
```

##### Parameters

Type

Name

Description

System.Int64

entityId

T

entity

System.Boolean

allowClosed

##### Returns

Type

Description

System.Boolean

##### Type Parameters

Name

Description

T

#### TryGetEntityByName(String, out MyEntity)

##### Declaration

```
public static bool TryGetEntityByName(string name, out MyEntity entity)
```

##### Parameters

Type

Name

Description

System.String

name

[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)

entity

##### Returns

Type

Description

System.Boolean

#### TryGetEntityByName<T>(String, out T)

##### Declaration

```
public static bool TryGetEntityByName<T>(string name, out T entity)
    where T : MyEntity
```

##### Parameters

Type

Name

Description

System.String

name

T

entity

##### Returns

Type

Description

System.Boolean

##### Type Parameters

Name

Description

T

#### UnhideAllTypes()

##### Declaration

```
public static void UnhideAllTypes()
```

#### UnloadData()

##### Declaration

```
public static void UnloadData()
```

#### UnregisterForDraw(IMyEntity)

##### Declaration

```
public static void UnregisterForDraw(IMyEntity entity)
```

##### Parameters

Type

Name

Description

[IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html)

entity

#### UnregisterForUpdate(MyEntity, Boolean)

##### Declaration

```
public static void UnregisterForUpdate(MyEntity entity, bool immediate = false)
```

##### Parameters

Type

Name

Description

[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)

entity

System.Boolean

immediate

#### UpdateAfterSimulation()

##### Declaration

```
public static void UpdateAfterSimulation()
```

#### UpdateBeforeSimulation()

##### Declaration

```
public static void UpdateBeforeSimulation()
```

#### UpdateOnceBeforeFrame()

##### Declaration

```
public static void UpdateOnceBeforeFrame()
```

#### UpdatingStopped()

##### Declaration

```
public static void UpdatingStopped()
```

### Events

#### OnCloseAll

##### Declaration

```
public static event Action OnCloseAll
```

##### Event Type

Type

Description

System.Action

#### OnEntityAdd

##### Declaration

```
public static event Action<MyEntity> OnEntityAdd
```

##### Event Type

Type

Description

System.Action<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\>

#### OnEntityCreate

##### Declaration

```
public static event Action<MyEntity> OnEntityCreate
```

##### Event Type

Type

Description

System.Action<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\>

#### OnEntityDelete

##### Declaration

```
public static event Action<MyEntity> OnEntityDelete
```

##### Event Type

Type

Description

System.Action<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\>

#### OnEntityNameSet

##### Declaration

```
public static event Action<MyEntity, string, string> OnEntityNameSet
```

##### Event Type

Type

Description

System.Action<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html), System.String, System.String\>

#### OnEntityRemove

##### Declaration

```
public static event Action<MyEntity> OnEntityRemove
```

##### Event Type

Type

Description

System.Action<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\>