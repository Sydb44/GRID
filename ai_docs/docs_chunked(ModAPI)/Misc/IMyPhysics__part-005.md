Ensure aabb is inside only one subspace. If no, reorder. Must not be called from parallel thread!!!

##### Declaration

```
void EnsurePhysicsSpace(BoundingBoxD aabb)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | aabb | World bounding box |

#### GetCollisionLayer(String)

Given a string, gets the numeric value for the collision layer. Default: 0. TargetDummyLayer = 6 BlockPlacementTestCollisionLayer = 7 MissileLayer = 8 NoVoxelCollisionLayer = 9 LightFloatingObjectCollisionLayer = 10 VoxelLod1CollisionLayer = 11 NotCollideWithStaticLayer = 12 StaticCollisionLayer = 13 CollideWithStaticLayer = 14 DefaultCollisionLayer = 15 DynamicDoubledCollisionLayer = 16 KinematicDoubledCollisionLayer = 17 CharacterCollisionLayer = 18 NoCollisionLayer = 19 DebrisCollisionLayer = 20 GravityPhantomLayer = 21 CharacterNetworkCollisionLayer = 22 FloatingObjectCollisionLayer = 23 ObjectDetectionCollisionLayer = 24 VirtualMassLayer = 25 CollectorCollisionLayer = 26 AmmoLayer = 27 VoxelCollisionLayer = 28 ExplosionRaycastLayer = 29 CollisionLayerWithoutCharacter = 30 RagdollCollisionLayer = 31

##### Declaration

```
int GetCollisionLayer(string strLayer)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | strLayer | Name of collision layer. See MyPhysics.CollisionLayers for valid names. |

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 | Numeric value from MyPhysics.CollisionLayers |

#### GetWeaponLeadPrediction(IMyEntity, IMyEntity, MyDefinitionId)

Gets the predicted target coordinates of an entity for weapon leading. Will return Vector3D.Zero if the entity is not valid. If the predicted intercept position cannot be calculated because of missing physics or ammo definitions, then it will return the entity position instead.

##### Declaration

```
Vector3D GetWeaponLeadPrediction(IMyEntity shooter, IMyEntity target, MyDefinitionId ammoDefinitionId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | shooter | The entity shooting the target, usually a weapon block or tool |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | target | The target entity you want to hit |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | ammoDefinitionId | The definition id for the MyAmmoDefinition object the shooter uses. |

##### Returns

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | Vector3D world coordinates of where a fired shot from the weapon should intercept the provided entity target. |