obb

Oriented bounding box in world coordinates

##### Returns

Type

Description

System.Collections.Generic.List<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\>

WARNING: Next call of function GetEntitiesInAABB would add elements to that list. **Always clean** right after use. It may break or slow game, if you won't clean array before next [GetEntitiesInAABB(ref BoundingBox)](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntities.html#Sandbox_Game_Entities_MyEntities_GetEntitiesInAABB_VRageMath_BoundingBox__), [GetEntitiesInAABB(ref BoundingBoxD, Boolean)](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntities.html#Sandbox_Game_Entities_MyEntities_GetEntitiesInAABB_VRageMath_BoundingBoxD__System_Boolean_), [GetEntitiesInSphere(ref BoundingSphereD)](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntities.html#Sandbox_Game_Entities_MyEntities_GetEntitiesInSphere_VRageMath_BoundingSphereD__) [GetElementsInBox(ref BoundingBoxD, List<MyEntity>)](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntities.html#Sandbox_Game_Entities_MyEntities_GetElementsInBox_VRageMath_BoundingBoxD__System_Collections_Generic_List_VRage_Game_Entity_MyEntity__) [GetTopMostEntitiesInSphere(ref BoundingSphereD)](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntities.html#Sandbox_Game_Entities_MyEntities_GetTopMostEntitiesInSphere_VRageMath_BoundingSphereD__) [GetTopMostEntitiesInBox(ref BoundingBoxD, List<MyEntity>, MyEntityQueryType)](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntities.html#Sandbox_Game_Entities_MyEntities_GetTopMostEntitiesInBox_VRageMath_BoundingBoxD__System_Collections_Generic_List_VRage_Game_Entity_MyEntity__Sandbox_Game_Entities_MyEntityQueryType_)

#### GetEntitiesInSphere(ref BoundingSphereD)

Returns list of entities that intersects with boundingSphere. If you are modder, you better use IMyEntities method. It is safe to use.

##### Declaration

```
public static List<MyEntity> GetEntitiesInSphere(ref BoundingSphereD boundingSphere)
```

##### Parameters

Type

Name

Description

[BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html)

boundingSphere

Bounding sphere in world coordinates

##### Returns

Type

Description

System.Collections.Generic.List<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\>

WARNING: Next call of function GetEntitiesInAABB would add elements to that list. **Always clean** right after use. It may break or slow game, if you won't clean array before next [GetEntitiesInAABB(ref BoundingBox)](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntities.html#Sandbox_Game_Entities_MyEntities_GetEntitiesInAABB_VRageMath_BoundingBox__), [GetEntitiesInAABB(ref BoundingBoxD, Boolean)](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntities.html#Sandbox_Game_Entities_MyEntities_GetEntitiesInAABB_VRageMath_BoundingBoxD__System_Boolean_), [GetEntitiesInSphere(ref BoundingSphereD)](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntities.html#Sandbox_Game_Entities_MyEntities_GetEntitiesInSphere_VRageMath_BoundingSphereD__) [GetElementsInBox(ref BoundingBoxD, List<MyEntity>)](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntities.html#Sandbox_Game_Entities_MyEntities_GetElementsInBox_VRageMath_BoundingBoxD__System_Collections_Generic_List_VRage_Game_Entity_MyEntity__) [GetTopMostEntitiesInSphere(ref BoundingSphereD)](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntities.html#Sandbox_Game_Entities_MyEntities_GetTopMostEntitiesInSphere_VRageMath_BoundingSphereD__) [GetTopMostEntitiesInBox(ref BoundingBoxD, List<MyEntity>, MyEntityQueryType)](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntities.html#Sandbox_Game_Entities_MyEntities_GetTopMostEntitiesInBox_VRageMath_BoundingBoxD__System_Collections_Generic_List_VRage_Game_Entity_MyEntity__Sandbox_Game_Entities_MyEntityQueryType_)

#### GetEntityById(Int64, Boolean)

##### Declaration

```
public static MyEntity GetEntityById(long entityId, bool allowClosed = false)
```

##### Parameters

Type

Name

Description

System.Int64

entityId

System.Boolean

allowClosed

##### Returns

Type

Description

[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)

#### GetEntityByIdOrDefault(Int64, MyEntity, Boolean)

##### Declaration

```
public static MyEntity GetEntityByIdOrDefault(long entityId, MyEntity defaultValue = null, bool allowClosed = false)
```

##### Parameters

Type

Name

Description

System.Int64

entityId

[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)

defaultValue

System.Boolean

allowClosed

##### Returns

Type

Description

[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)

#### GetEntityByIdOrDefault<T>(Int64, T, Boolean)

##### Declaration

```
public static T GetEntityByIdOrDefault<T>(long entityId, T defaultValue = null, bool allowClosed = false)
    where T : MyEntity
```

##### Parameters

Type

Name

Description

System.Int64

entityId

T

defaultValue

System.Boolean

allowClosed

##### Returns

Type

Description

T

##### Type Parameters

Name

Description

T

#### GetEntityByName(String)

##### Declaration

```
public static MyEntity GetEntityByName(string name)
```

##### Parameters

Type

Name

Description

System.String

name

##### Returns

Type

Description

[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)
