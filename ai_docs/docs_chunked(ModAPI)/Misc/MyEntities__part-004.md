stepSize

System.Single

radiusIncrement

[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)

ignoreEnt

System.Boolean

allowSafezones

##### Returns

Type

Description

System.Nullable<[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\>

#### ForceCloseEntityOnClients(Int64)

##### Declaration

```
[Event(null, 2901)]
[Reliable]
[Broadcast]
public static void ForceCloseEntityOnClients(long entityId)
```

##### Parameters

Type

Name

Description

System.Int64

entityId

#### GetElementsInBox(ref BoundingBoxD, List<MyEntity>)

##### Declaration

```
public static void GetElementsInBox(ref BoundingBoxD boundingBox, List<MyEntity> foundElements)
```

##### Parameters

Type

Name

Description

[BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html)

boundingBox

System.Collections.Generic.List<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\>

foundElements

#### GetEntities()

##### Declaration

```
public static MyConcurrentHashSet<MyEntity> GetEntities()
```

##### Returns

Type

Description

[MyConcurrentHashSet](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.MyConcurrentHashSet-1.html)<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\>

#### GetEntitiesInAABB(ref BoundingBox)

Get all rigid body elements touching a bounding box. Clear() the result list after you're done with it!

##### Declaration

```
public static List<MyEntity> GetEntitiesInAABB(ref BoundingBox boundingBox)
```

##### Parameters

Type

Name

Description

[BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html)

boundingBox

##### Returns

Type

Description

System.Collections.Generic.List<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\>

The list of results.

#### GetEntitiesInAABB(ref BoundingBoxD, Boolean)

Returns list of entities that intersects with BoundingBox. If you are modder, you better use IMyEntities method. It is safe to use.

##### Declaration

```
public static List<MyEntity> GetEntitiesInAABB(ref BoundingBoxD boundingBox, bool exact = false)
```

##### Parameters

Type

Name

Description

[BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html)

boundingBox

Bounding box in world coordinates

System.Boolean

exact

When true more accurate

##### Returns

Type

Description

System.Collections.Generic.List<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\>

WARNING: Next call of function GetEntitiesInAABB would add elements to that list. **Always clean** right after use. It may break or slow game, if you won't clean array before next [GetEntitiesInAABB(ref BoundingBox)](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntities.html#Sandbox_Game_Entities_MyEntities_GetEntitiesInAABB_VRageMath_BoundingBox__), [GetEntitiesInAABB(ref BoundingBoxD, Boolean)](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntities.html#Sandbox_Game_Entities_MyEntities_GetEntitiesInAABB_VRageMath_BoundingBoxD__System_Boolean_), [GetEntitiesInSphere(ref BoundingSphereD)](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntities.html#Sandbox_Game_Entities_MyEntities_GetEntitiesInSphere_VRageMath_BoundingSphereD__) [GetElementsInBox(ref BoundingBoxD, List<MyEntity>)](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntities.html#Sandbox_Game_Entities_MyEntities_GetElementsInBox_VRageMath_BoundingBoxD__System_Collections_Generic_List_VRage_Game_Entity_MyEntity__) [GetTopMostEntitiesInSphere(ref BoundingSphereD)](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntities.html#Sandbox_Game_Entities_MyEntities_GetTopMostEntitiesInSphere_VRageMath_BoundingSphereD__) [GetTopMostEntitiesInBox(ref BoundingBoxD, List<MyEntity>, MyEntityQueryType)](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntities.html#Sandbox_Game_Entities_MyEntities_GetTopMostEntitiesInBox_VRageMath_BoundingBoxD__System_Collections_Generic_List_VRage_Game_Entity_MyEntity__Sandbox_Game_Entities_MyEntityQueryType_)

#### GetEntitiesInOBB(ref MyOrientedBoundingBoxD)

Returns list of entities that intersects with oriented bounding box. If you are modder, you better use IMyEntities method. It is safe to use.

##### Declaration

```
public static List<MyEntity> GetEntitiesInOBB(ref MyOrientedBoundingBoxD obb)
```

##### Parameters

Type

Name

Description

[MyOrientedBoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyOrientedBoundingBoxD.html)

obb

Oriented bounding box in world coordinates

##### Returns

Type

Description

System.Collections.Generic.List<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\>

WARNING: Next call of function GetEntitiesInAABB would add elements to that list. **Always clean** right after use. It may break or slow game, if you won't clean array before next [GetEntitiesInAABB(ref BoundingBox)](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntities.html#Sandbox_Game_Entities_MyEntities_GetEntitiesInAABB_VRageMath_BoundingBox__), [GetEntitiesInAABB(ref BoundingBoxD, Boolean)](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntities.html#Sandbox_Game_Entities_MyEntities_GetEntitiesInAABB_VRageMath_BoundingBoxD__System_Boolean_), [GetEntitiesInSphere(ref BoundingSphereD)](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntities.html#Sandbox_Game_Entities_MyEntities_GetEntitiesInSphere_VRageMath_BoundingSphereD__) [GetElementsInBox(ref BoundingBoxD, List<MyEntity>)](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntities.html#Sandbox_Game_Entities_MyEntities_GetElementsInBox_VRageMath_BoundingBoxD__System_Collections_Generic_List_VRage_Game_Entity_MyEntity__) [GetTopMostEntitiesInSphere(ref BoundingSphereD)](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntities.html#Sandbox_Game_Entities_MyEntities_GetTopMostEntitiesInSphere_VRageMath_BoundingSphereD__) [GetTopMostEntitiesInBox(ref BoundingBoxD, List<MyEntity>, MyEntityQueryType)](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntities.html#Sandbox_Game_Entities_MyEntities_GetTopMostEntitiesInBox_VRageMath_BoundingBoxD__System_Collections_Generic_List_VRage_Game_Entity_MyEntity__Sandbox_Game_Entities_MyEntityQueryType_)
