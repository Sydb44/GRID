volumetricTest

System.Collections.Generic.List<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\>

result

#### GetTopMostEntitiesInBox(ref BoundingBoxD, List<MyEntity>, MyEntityQueryType)

##### Declaration

```
public static void GetTopMostEntitiesInBox(ref BoundingBoxD boundingBox, List<MyEntity> foundElements, MyEntityQueryType qtype)
```

##### Parameters

Type

Name

Description

[BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html)

boundingBox

System.Collections.Generic.List<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\>

foundElements

[MyEntityQueryType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntityQueryType.html)

qtype

#### GetTopMostEntitiesInSphere(ref BoundingSphereD)

Returns list of entities that intersects with oriented bounding box. If you are modder, you better use IMyEntities method. It is safe to use.

##### Declaration

```
public static List<MyEntity> GetTopMostEntitiesInSphere(ref BoundingSphereD boundingSphere)
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

#### HasEntitiesToDelete()

##### Declaration

```
public static bool HasEntitiesToDelete()
```

##### Returns

Type

Description

System.Boolean

#### InitAsync(MyEntity, MyObjectBuilder\_EntityBase, Boolean, Action<MyEntity>, Double, Boolean)

##### Declaration

```
public static void InitAsync(MyEntity entity, MyObjectBuilder_EntityBase objectBuilder, bool addToScene, Action<MyEntity> doneHandler = null, double serializationTimestamp = 0, bool fadeIn = false)
```

##### Parameters

Type

Name

Description

[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)

entity

[MyObjectBuilder\_EntityBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_EntityBase.html)

objectBuilder

System.Boolean

addToScene

System.Action<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\>

doneHandler

System.Double

serializationTimestamp

System.Boolean

fadeIn

#### InitEntity(MyObjectBuilder\_EntityBase, ref MyEntity, Boolean)

##### Declaration

```
public static bool InitEntity(MyObjectBuilder_EntityBase objectBuilder, ref MyEntity entity, bool tolerateBlacklistedPlanets = false)
```

##### Parameters

Type

Name

Description

[MyObjectBuilder\_EntityBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_EntityBase.html)

objectBuilder

[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)

entity

System.Boolean

tolerateBlacklistedPlanets

##### Returns

Type

Description

System.Boolean

#### InvokeLater(Action, String)

##### Declaration

```
public static void InvokeLater(Action action, string callerDebugName = null)
```

##### Parameters

Type

Name

Description

System.Action

action

System.String

callerDebugName

#### IsCloseAllowed()

##### Declaration

```
public static bool IsCloseAllowed()
```

##### Returns

Type

Description

System.Boolean

#### IsEntityIdValid(Int64)

##### Declaration

```
public static bool IsEntityIdValid(long entityId)
```

##### Parameters

Type

Name

Description

System.Int64

entityId

##### Returns

Type

Description

System.Boolean

#### IsInsideVoxel(Vector3D, Vector3D, out Vector3D)

##### Declaration

```
public static bool IsInsideVoxel(Vector3D pos, Vector3D hintPosition, out Vector3D lastOutsidePos)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

pos

Position of object

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

hintPosition

Position of object few frames back to test whether object enterred voxel. Usually pos - LinearVelocity \* x, where x it time.

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

lastOutsidePos
